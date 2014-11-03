Imports INFITF
Imports MECMOD
Imports ProductStructureTypeLib
Imports DRAFTINGITF

Public Module MainModule

    Public CATIA As INFITF.Application
    Public SrcFolder As String
    Public DestFolder As String

    Sub Main()

        CATIA = GetObject(, "CATIA.Application")
        Call ProcessUserform()

    End Sub


    Sub ProcessUserform()

        SrcFolder = MainForm.FolderBrowserDialogSource.SelectedPath
        DestFolder = MainForm.FolderBrowserDialogDestination.SelectedPath

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


    Sub ExportDWG()

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


End Module

