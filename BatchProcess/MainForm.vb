Imports INFITF
Imports DRAFTINGITF

Public Class MainForm

    Public CATIA As INFITF.Application
    Public SrcFolder As String
    Public DestFolder As String

    Private Sub Main()
        CATIA = GetObject(, "CATIA.Application")
        Call ProcessUserform()
    End Sub

    Private Sub ButtonGo_Click(sender As Object, e As EventArgs) Handles ButtonGo.Click
        Me.Hide()
        Call Main()
        Me.Show()
    End Sub

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

    Public Sub ProcessUserform()
        SrcFolder = Me.FolderBrowserDialogSource.SelectedPath
        DestFolder = Me.FolderBrowserDialogDestination.SelectedPath

        Dim FS 'As FileSystem
        FS = CATIA.FileSystem

        Dim ExistDir As Folder
        ExistDir = FS.GetFolder(SrcFolder)

        For X = 1 To ExistDir.Files.Count
            Dim CurFile As File
            CurFile = ExistDir.Files.Item(X)

            If InStr(CurFile.Name, ".CATDrawing") <> 0 Then
                Dim AvailDocs As Documents
                AvailDocs = CATIA.Documents
                AvailDocs.Open(CurFile.Path)
                CATIA.RefreshDisplay = True
                Call ExportDWG()
            End If

        Next X
    End Sub

    Public Sub ExportDWG()
        Dim MyDrawing As DrawingDocument
        MyDrawing = CATIA.ActiveDocument

        'Clean-up file name
        Dim FileName As String
        FileName = Replace(MyDrawing.Name, ".CATDrawing", ".dwg")

        Dim SavePath As String
        SavePath = DestFolder & "\" & FileName

        'Export File & Close
        MyDrawing.ExportData(SavePath, "dwg")
        MyDrawing.Close()
    End Sub

End Class