Imports INFITF
Imports DRAFTINGITF
Imports MECMOD
Imports ProductStructureTypeLib

Public Class MainForm

    'Set-up
    Public CATIA As INFITF.Application
    Public PathSource As String
    Public PathDest As String

    Public Sub Main()

        CATIA = GetObject(, "CATIA.Application")

        'Process Forms
        PathSource = FolderBrowserDialogSource.SelectedPath
        PathDest = FolderBrowserDialogDestination.SelectedPath

        'Check for folder locations
        If PathDest = "" Then
            PathDest = PathSource
            'MsgBox("Please select a destination path", vbCritical, "Error")
            'Environment.Exit(0)
        End If

    End Sub

    'Userforms
    Private Sub ButtonSourceFolder_Click(sender As Object, e As EventArgs) Handles ButtonSourceFolder.Click
        'Set folder path with dialog box
        If FolderBrowserDialogSource.ShowDialog() = DialogResult.OK Then
            TextBoxSourceFolder.Text = FolderBrowserDialogSource.SelectedPath()
        End If
    End Sub

    Private Sub ButtonDestinationFolder_Click(sender As Object, e As EventArgs) Handles ButtonDestinationFolder.Click
        'Set folder path with dialog box
        If FolderBrowserDialogDestination.ShowDialog() = DialogResult.OK Then
            TextBoxDestinationFolder.Text = FolderBrowserDialogDestination.SelectedPath()
        End If
    End Sub

    Private Sub ButtonDrawingsGo_Click(sender As Object, e As EventArgs) Handles ButtonDrawingsGo.Click
        Me.Hide()
        Call Main()
        Call ProcessFiles(".CATDrawing")
        Me.Show()
    End Sub

    Private Sub ButtonPartsGo_Click(sender As Object, e As EventArgs) Handles ButtonPartsGo.Click
        Me.Hide()
        Call Main()
        Call ProcessFiles(".CATPart")
        Me.Show()
    End Sub

    Private Sub CheckBoxSourceOverwrite_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSourceOverwrite.CheckedChanged
        'Hide Dest button if option checked
        If CheckBoxSourceOverwrite.Checked = True Then
            ButtonDestinationFolder.Enabled = False
        Else
            ButtonDestinationFolder.Enabled = True
            FolderBrowserDialogDestination.SelectedPath = ""
        End If
    End Sub

    Public Sub ProcessFiles(FileExtension As String)

        'Process files
        Dim FS 'As FileSystem
        FS = CATIA.FileSystem

        Dim ExistDir As Folder
        ExistDir = FS.GetFolder(PathSource)

        For i = 1 To ExistDir.Files.Count
            Dim CurFile As File
            CurFile = ExistDir.Files.Item(i)

            If InStr(CurFile.Name, FileExtension) <> 0 Then
                Dim AvailDocs As Documents
                AvailDocs = CATIA.Documents
                AvailDocs.Open(CurFile.Path)
                CATIA.RefreshDisplay = True
                FileActions()
            End If

        Next i

        'Process sub-files
        If CheckBoxSourceRecursive.Checked = True Then
            For j = 1 To ExistDir.SubFolders.Count
                Dim CF As Folder
                CF = ExistDir.SubFolders.Item(j)
                ProcessSubfiles(CF, FileExtension)
            Next j
        End If

    End Sub

    Public Sub ProcessSubfiles(CurFolder As Folder, FileExtension As String)

        For X = 1 To CurFolder.Files.Count
            Dim CurFile As File
            CurFile = CurFolder.Files.Item(X)

            If InStr(CurFile.Name, FileExtension) <> 0 Then
                Dim AvailDocs As Documents
                AvailDocs = CATIA.Documents
                AvailDocs.Open(CurFile.Path)
                CATIA.RefreshDisplay = True
                FileActions()
            End If
        Next X

        For Y = 1 To CurFolder.SubFolders.Count
            Dim CF As Folder
            CF = CurFolder.SubFolders.Item(Y)
            ProcessSubfiles(CF, FileExtension)
        Next

    End Sub

    Public Sub FileActions()

        'Drawings
        If CheckBoxDrawingUpdate.Checked = True Then
            Call DrawingUpdate()
        End If

        If CheckBoxDrawingExport.Checked = True Then
            Call DrawingExport(ComboBoxDrawingExportFormat.Text)
        End If

        'Parts
        If CheckBoxPartUpdate.Checked = True Then
            Call PartUpdate()
        End If

        If CheckBoxPartExportSolids.Checked = True Then
            Call PartExportSolids(ComboBoxPartExportSolidsFormat.Text)
        End If

        'Close the window
        Dim ActiveDoc As Document
        ActiveDoc = CATIA.ActiveDocument
        ActiveDoc.Close()

    End Sub

    Public Sub DrawingUpdate()

        'Force update sheets within drawing
        Dim MyDrawing As DrawingDocument
        MyDrawing = CATIA.ActiveDocument

        Dim SavePath As String
        SavePath = PathDest & "\" & MyDrawing.Name

        For i = 1 To MyDrawing.Sheets.Count
            MyDrawing.Sheets.Item(i).ForceUpdate()
        Next i

        'Save drawing
        If PathSource = PathDest Then
            MyDrawing.Save()
        Else
            MyDrawing.SaveAs(SavePath)
            'Option for save as new .CATDrawing? (change UUID)
        End If

    End Sub

    Public Sub DrawingExport(FileType As String)

        'Export drawing to a specified format (dwx/dxf/pdf)
        Dim MyDrawing As DrawingDocument
        MyDrawing = CATIA.ActiveDocument

        Dim FileName As String
        FileName = Replace(MyDrawing.Name, ".CATDrawing", "." & FileType)

        Dim SavePath As String
        SavePath = PathDest & "\" & FileName

        'Export file (cannot export drawings to same folder path currently)
        If PathSource = PathDest Then
            MsgBox("Cannot export drawings to same folder as source. Please select an Output destination", vbCritical, "Error")
            Environment.Exit(0)
        Else
            MyDrawing.ExportData(SavePath, FileType)
        End If

    End Sub

    Public Sub PartUpdate()

        'Updates Part & Save
        Dim MyDoc As PartDocument
        MyDoc = CATIA.ActiveDocument

        Dim MyPart As Part
        MyPart = MyDoc.Part

        Dim FileName As String
        FileName = MyPart.Name & ".CATPart"

        Dim SavePath As String
        SavePath = PathDest & "\" & FileName

        MyPart.Update()

        'Save file
        If PathSource = PathDest Then
            MyDoc.Save()
        Else
            MyDoc.SaveAs(SavePath)
            'Option for save as new .CATPart? (change UUID)
        End If

        'MyDoc.Close()

    End Sub

    Public Sub PartExportSolids(FileType As String)

        'Grabs the solid bodies and exports as file type
        Dim MyDoc As PartDocument
        MyDoc = CATIA.ActiveDocument

        Dim MyPart As Part
        MyPart = MyDoc.Part

        Dim j As Integer
        j = MyPart.Bodies.Count

        For i = 1 To MyPart.Bodies.Count()

            Dim BodySel As Body
            BodySel = MyPart.Bodies.Item(i)

            'Skip empty part bodies
            If BodySel.Shapes.Count = 0 Then
                GoTo SkipExport
            End If

            Dim MySelection As Selection
            MySelection = MyDoc.Selection

            MySelection.Clear()
            MySelection.Add(BodySel)
            MySelection.Copy()

            Dim sPartName As String
            sPartName = MyPart.Name & "_" & BodySel.Name

            'Add a new part
            Dim NewDoc As PartDocument
            NewDoc = CATIA.Documents.Add("Part")

            Dim NewPart As Part
            NewPart = NewDoc.Part

            Dim NewProduct As Product
            NewProduct = NewDoc.GetItem(1)
            NewProduct.PartNumber = sPartName

            'TO DO: Axis to Axis Transformation
            'Paste body as result
            Dim NewBodySel As Body
            NewBodySel = NewPart.Bodies.Item(1)

            MySelection.Add(NewBodySel)
            MySelection.PasteSpecial("CATPrtResultWithOutLink")
            NewPart.Update()

            'Export file
            Dim SavePath As String
            SavePath = PathDest & "\" & sPartName & "." & FileType

            If FileType = "CATDrawing" Then
                NewDoc.SaveAs(SavePath)
            Else
                NewDoc.ExportData(SavePath, FileType)
            End If

            NewDoc.Close()

SkipExport:

        Next i

    End Sub

End Class