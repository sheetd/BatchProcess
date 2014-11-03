Public Class MainForm

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


End Class