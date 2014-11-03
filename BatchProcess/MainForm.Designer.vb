<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonGo = New System.Windows.Forms.Button()
        Me.ButtonSourceFolder = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelExportFormat = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CheckBoxRecursiveSource = New System.Windows.Forms.CheckBox()
        Me.CheckOverwriteOutput = New System.Windows.Forms.CheckBox()
        Me.TextBoxSourceFolder = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxDestinationFolder = New System.Windows.Forms.TextBox()
        Me.ButtonDestinationFolder = New System.Windows.Forms.Button()
        Me.FolderBrowserDialogSource = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderBrowserDialogDestination = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonGo
        '
        Me.ButtonGo.Location = New System.Drawing.Point(322, 424)
        Me.ButtonGo.Name = "ButtonGo"
        Me.ButtonGo.Size = New System.Drawing.Size(94, 36)
        Me.ButtonGo.TabIndex = 0
        Me.ButtonGo.Text = "Go"
        Me.ButtonGo.UseVisualStyleBackColor = True
        '
        'ButtonSourceFolder
        '
        Me.ButtonSourceFolder.Location = New System.Drawing.Point(12, 29)
        Me.ButtonSourceFolder.Name = "ButtonSourceFolder"
        Me.ButtonSourceFolder.Size = New System.Drawing.Size(107, 30)
        Me.ButtonSourceFolder.TabIndex = 1
        Me.ButtonSourceFolder.Text = "Click to select"
        Me.ButtonSourceFolder.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelExportFormat)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.CheckBoxRecursiveSource)
        Me.GroupBox1.Controls.Add(Me.CheckOverwriteOutput)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 161)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(404, 254)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options"
        '
        'LabelExportFormat
        '
        Me.LabelExportFormat.AutoSize = True
        Me.LabelExportFormat.Location = New System.Drawing.Point(56, 23)
        Me.LabelExportFormat.Name = "LabelExportFormat"
        Me.LabelExportFormat.Size = New System.Drawing.Size(85, 13)
        Me.LabelExportFormat.TabIndex = 4
        Me.LabelExportFormat.Text = "Export file format"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"DWG", "DXF", "PDF"})
        Me.ComboBox1.Location = New System.Drawing.Point(6, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(48, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'CheckBoxRecursiveSource
        '
        Me.CheckBoxRecursiveSource.AutoSize = True
        Me.CheckBoxRecursiveSource.Location = New System.Drawing.Point(6, 47)
        Me.CheckBoxRecursiveSource.Name = "CheckBoxRecursiveSource"
        Me.CheckBoxRecursiveSource.Size = New System.Drawing.Size(130, 17)
        Me.CheckBoxRecursiveSource.TabIndex = 1
        Me.CheckBoxRecursiveSource.Text = "Select files recursively"
        Me.CheckBoxRecursiveSource.UseVisualStyleBackColor = True
        '
        'CheckOverwriteOutput
        '
        Me.CheckOverwriteOutput.AutoSize = True
        Me.CheckOverwriteOutput.Location = New System.Drawing.Point(6, 70)
        Me.CheckOverwriteOutput.Name = "CheckOverwriteOutput"
        Me.CheckOverwriteOutput.Size = New System.Drawing.Size(125, 17)
        Me.CheckOverwriteOutput.TabIndex = 0
        Me.CheckOverwriteOutput.Text = "Overwrite output files"
        Me.CheckOverwriteOutput.UseVisualStyleBackColor = True
        '
        'TextBoxSourceFolder
        '
        Me.TextBoxSourceFolder.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxSourceFolder.Location = New System.Drawing.Point(125, 29)
        Me.TextBoxSourceFolder.Multiline = True
        Me.TextBoxSourceFolder.Name = "TextBoxSourceFolder"
        Me.TextBoxSourceFolder.Size = New System.Drawing.Size(291, 50)
        Me.TextBoxSourceFolder.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Source Folder (*.CATDrawing)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Destination Folder"
        '
        'TextBoxDestinationFolder
        '
        Me.TextBoxDestinationFolder.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxDestinationFolder.Location = New System.Drawing.Point(125, 107)
        Me.TextBoxDestinationFolder.Multiline = True
        Me.TextBoxDestinationFolder.Name = "TextBoxDestinationFolder"
        Me.TextBoxDestinationFolder.Size = New System.Drawing.Size(291, 50)
        Me.TextBoxDestinationFolder.TabIndex = 6
        '
        'ButtonDestinationFolder
        '
        Me.ButtonDestinationFolder.Location = New System.Drawing.Point(12, 107)
        Me.ButtonDestinationFolder.Name = "ButtonDestinationFolder"
        Me.ButtonDestinationFolder.Size = New System.Drawing.Size(107, 30)
        Me.ButtonDestinationFolder.TabIndex = 5
        Me.ButtonDestinationFolder.Text = "Click to select"
        Me.ButtonDestinationFolder.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 468)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxDestinationFolder)
        Me.Controls.Add(Me.ButtonDestinationFolder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxSourceFolder)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonSourceFolder)
        Me.Controls.Add(Me.ButtonGo)
        Me.Name = "MainForm"
        Me.Text = "BatchProcess v1.0"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonGo As System.Windows.Forms.Button
    Friend WithEvents ButtonSourceFolder As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckOverwriteOutput As System.Windows.Forms.CheckBox
    Friend WithEvents TextBoxSourceFolder As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDestinationFolder As System.Windows.Forms.TextBox
    Friend WithEvents ButtonDestinationFolder As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialogSource As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents FolderBrowserDialogDestination As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents CheckBoxRecursiveSource As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents LabelExportFormat As System.Windows.Forms.Label
End Class
