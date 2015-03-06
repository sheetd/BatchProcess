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
        Me.ButtonSourceFolder = New System.Windows.Forms.Button()
        Me.TextBoxSourceFolder = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxDestinationFolder = New System.Windows.Forms.TextBox()
        Me.ButtonDestinationFolder = New System.Windows.Forms.Button()
        Me.FolderBrowserDialogSource = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderBrowserDialogDestination = New System.Windows.Forms.FolderBrowserDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Drawings = New System.Windows.Forms.TabPage()
        Me.CheckBoxLayerTransfer = New System.Windows.Forms.CheckBox()
        Me.CheckBoxForceUpdate = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBoxDrawingUpdate = New System.Windows.Forms.CheckBox()
        Me.ButtonDrawingsGo = New System.Windows.Forms.Button()
        Me.CheckBoxDrawingExport = New System.Windows.Forms.CheckBox()
        Me.ComboBoxDrawingExportFormat = New System.Windows.Forms.ComboBox()
        Me.Parts = New System.Windows.Forms.TabPage()
        Me.ComboBoxPartExportSolidsFormat = New System.Windows.Forms.ComboBox()
        Me.CheckBoxPartExportSolids = New System.Windows.Forms.CheckBox()
        Me.CheckBoxPartUpdate = New System.Windows.Forms.CheckBox()
        Me.ButtonPartsGo = New System.Windows.Forms.Button()
        Me.Products = New System.Windows.Forms.TabPage()
        Me.CheckBoxProductUpdate = New System.Windows.Forms.CheckBox()
        Me.ButtonProductsGo = New System.Windows.Forms.Button()
        Me.CheckBoxSourceRecursive = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSourceOverwrite = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.Drawings.SuspendLayout()
        Me.Parts.SuspendLayout()
        Me.Products.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonSourceFolder
        '
        Me.ButtonSourceFolder.Location = New System.Drawing.Point(16, 36)
        Me.ButtonSourceFolder.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSourceFolder.Name = "ButtonSourceFolder"
        Me.ButtonSourceFolder.Size = New System.Drawing.Size(142, 37)
        Me.ButtonSourceFolder.TabIndex = 1
        Me.ButtonSourceFolder.Text = "Click to select"
        Me.ButtonSourceFolder.UseVisualStyleBackColor = True
        '
        'TextBoxSourceFolder
        '
        Me.TextBoxSourceFolder.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxSourceFolder.Location = New System.Drawing.Point(167, 36)
        Me.TextBoxSourceFolder.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxSourceFolder.Multiline = True
        Me.TextBoxSourceFolder.Name = "TextBoxSourceFolder"
        Me.TextBoxSourceFolder.Size = New System.Drawing.Size(380, 61)
        Me.TextBoxSourceFolder.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Source Folder"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 140)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Destination Folder"
        '
        'TextBoxDestinationFolder
        '
        Me.TextBoxDestinationFolder.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxDestinationFolder.Location = New System.Drawing.Point(167, 160)
        Me.TextBoxDestinationFolder.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxDestinationFolder.Multiline = True
        Me.TextBoxDestinationFolder.Name = "TextBoxDestinationFolder"
        Me.TextBoxDestinationFolder.Size = New System.Drawing.Size(380, 61)
        Me.TextBoxDestinationFolder.TabIndex = 6
        '
        'ButtonDestinationFolder
        '
        Me.ButtonDestinationFolder.Location = New System.Drawing.Point(16, 160)
        Me.ButtonDestinationFolder.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonDestinationFolder.Name = "ButtonDestinationFolder"
        Me.ButtonDestinationFolder.Size = New System.Drawing.Size(142, 37)
        Me.ButtonDestinationFolder.TabIndex = 5
        Me.ButtonDestinationFolder.Text = "Click to select"
        Me.ButtonDestinationFolder.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Drawings)
        Me.TabControl1.Controls.Add(Me.Parts)
        Me.TabControl1.Controls.Add(Me.Products)
        Me.TabControl1.ItemSize = New System.Drawing.Size(30, 18)
        Me.TabControl1.Location = New System.Drawing.Point(16, 229)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(537, 311)
        Me.TabControl1.TabIndex = 9
        '
        'Drawings
        '
        Me.Drawings.Controls.Add(Me.CheckBoxLayerTransfer)
        Me.Drawings.Controls.Add(Me.CheckBoxForceUpdate)
        Me.Drawings.Controls.Add(Me.Label3)
        Me.Drawings.Controls.Add(Me.CheckBoxDrawingUpdate)
        Me.Drawings.Controls.Add(Me.ButtonDrawingsGo)
        Me.Drawings.Controls.Add(Me.CheckBoxDrawingExport)
        Me.Drawings.Controls.Add(Me.ComboBoxDrawingExportFormat)
        Me.Drawings.Location = New System.Drawing.Point(4, 22)
        Me.Drawings.Margin = New System.Windows.Forms.Padding(4)
        Me.Drawings.Name = "Drawings"
        Me.Drawings.Padding = New System.Windows.Forms.Padding(4)
        Me.Drawings.Size = New System.Drawing.Size(529, 285)
        Me.Drawings.TabIndex = 0
        Me.Drawings.Text = "Drawings"
        Me.Drawings.UseVisualStyleBackColor = True
        '
        'CheckBoxLayerTransfer
        '
        Me.CheckBoxLayerTransfer.AutoSize = True
        Me.CheckBoxLayerTransfer.ForeColor = System.Drawing.Color.Red
        Me.CheckBoxLayerTransfer.Location = New System.Drawing.Point(13, 96)
        Me.CheckBoxLayerTransfer.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxLayerTransfer.Name = "CheckBoxLayerTransfer"
        Me.CheckBoxLayerTransfer.Size = New System.Drawing.Size(223, 21)
        Me.CheckBoxLayerTransfer.TabIndex = 14
        Me.CheckBoxLayerTransfer.Text = "Apply Layer Transfer on Views"
        Me.CheckBoxLayerTransfer.UseVisualStyleBackColor = True
        '
        'CheckBoxForceUpdate
        '
        Me.CheckBoxForceUpdate.AutoSize = True
        Me.CheckBoxForceUpdate.ForeColor = System.Drawing.Color.Red
        Me.CheckBoxForceUpdate.Location = New System.Drawing.Point(13, 68)
        Me.CheckBoxForceUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxForceUpdate.Name = "CheckBoxForceUpdate"
        Me.CheckBoxForceUpdate.Size = New System.Drawing.Size(171, 21)
        Me.CheckBoxForceUpdate.TabIndex = 13
        Me.CheckBoxForceUpdate.Text = "Force Drawing Update"
        Me.CheckBoxForceUpdate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(204, 42)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(295, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "(Destination Folder required for Batch Export)"
        '
        'CheckBoxDrawingUpdate
        '
        Me.CheckBoxDrawingUpdate.AutoSize = True
        Me.CheckBoxDrawingUpdate.Location = New System.Drawing.Point(13, 12)
        Me.CheckBoxDrawingUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxDrawingUpdate.Name = "CheckBoxDrawingUpdate"
        Me.CheckBoxDrawingUpdate.Size = New System.Drawing.Size(140, 21)
        Me.CheckBoxDrawingUpdate.TabIndex = 11
        Me.CheckBoxDrawingUpdate.Text = "Update and Save"
        Me.CheckBoxDrawingUpdate.UseVisualStyleBackColor = True
        '
        'ButtonDrawingsGo
        '
        Me.ButtonDrawingsGo.Location = New System.Drawing.Point(393, 238)
        Me.ButtonDrawingsGo.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonDrawingsGo.Name = "ButtonDrawingsGo"
        Me.ButtonDrawingsGo.Size = New System.Drawing.Size(125, 37)
        Me.ButtonDrawingsGo.TabIndex = 10
        Me.ButtonDrawingsGo.Text = "Go"
        Me.ButtonDrawingsGo.UseVisualStyleBackColor = True
        '
        'CheckBoxDrawingExport
        '
        Me.CheckBoxDrawingExport.AutoSize = True
        Me.CheckBoxDrawingExport.Location = New System.Drawing.Point(13, 40)
        Me.CheckBoxDrawingExport.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxDrawingExport.Name = "CheckBoxDrawingExport"
        Me.CheckBoxDrawingExport.Size = New System.Drawing.Size(111, 21)
        Me.CheckBoxDrawingExport.TabIndex = 9
        Me.CheckBoxDrawingExport.Text = "Export file as"
        Me.CheckBoxDrawingExport.UseVisualStyleBackColor = True
        '
        'ComboBoxDrawingExportFormat
        '
        Me.ComboBoxDrawingExportFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDrawingExportFormat.FormattingEnabled = True
        Me.ComboBoxDrawingExportFormat.Items.AddRange(New Object() {"dwg", "dxf", "pdf"})
        Me.ComboBoxDrawingExportFormat.Location = New System.Drawing.Point(128, 36)
        Me.ComboBoxDrawingExportFormat.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxDrawingExportFormat.Name = "ComboBoxDrawingExportFormat"
        Me.ComboBoxDrawingExportFormat.Size = New System.Drawing.Size(68, 24)
        Me.ComboBoxDrawingExportFormat.Sorted = True
        Me.ComboBoxDrawingExportFormat.TabIndex = 8
        '
        'Parts
        '
        Me.Parts.Controls.Add(Me.ComboBoxPartExportSolidsFormat)
        Me.Parts.Controls.Add(Me.CheckBoxPartExportSolids)
        Me.Parts.Controls.Add(Me.CheckBoxPartUpdate)
        Me.Parts.Controls.Add(Me.ButtonPartsGo)
        Me.Parts.Location = New System.Drawing.Point(4, 22)
        Me.Parts.Margin = New System.Windows.Forms.Padding(4)
        Me.Parts.Name = "Parts"
        Me.Parts.Padding = New System.Windows.Forms.Padding(4)
        Me.Parts.Size = New System.Drawing.Size(529, 285)
        Me.Parts.TabIndex = 1
        Me.Parts.Text = "Parts"
        Me.Parts.UseVisualStyleBackColor = True
        '
        'ComboBoxPartExportSolidsFormat
        '
        Me.ComboBoxPartExportSolidsFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPartExportSolidsFormat.FormattingEnabled = True
        Me.ComboBoxPartExportSolidsFormat.Items.AddRange(New Object() {"3dxml", "CATPart", "igs", "stp"})
        Me.ComboBoxPartExportSolidsFormat.Location = New System.Drawing.Point(139, 36)
        Me.ComboBoxPartExportSolidsFormat.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxPartExportSolidsFormat.Name = "ComboBoxPartExportSolidsFormat"
        Me.ComboBoxPartExportSolidsFormat.Size = New System.Drawing.Size(82, 24)
        Me.ComboBoxPartExportSolidsFormat.Sorted = True
        Me.ComboBoxPartExportSolidsFormat.TabIndex = 14
        '
        'CheckBoxPartExportSolids
        '
        Me.CheckBoxPartExportSolids.AutoSize = True
        Me.CheckBoxPartExportSolids.Checked = True
        Me.CheckBoxPartExportSolids.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxPartExportSolids.Location = New System.Drawing.Point(13, 40)
        Me.CheckBoxPartExportSolids.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxPartExportSolids.Name = "CheckBoxPartExportSolids"
        Me.CheckBoxPartExportSolids.Size = New System.Drawing.Size(131, 21)
        Me.CheckBoxPartExportSolids.TabIndex = 13
        Me.CheckBoxPartExportSolids.Text = "Export Solids as"
        Me.CheckBoxPartExportSolids.UseVisualStyleBackColor = True
        '
        'CheckBoxPartUpdate
        '
        Me.CheckBoxPartUpdate.AutoSize = True
        Me.CheckBoxPartUpdate.Location = New System.Drawing.Point(13, 12)
        Me.CheckBoxPartUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxPartUpdate.Name = "CheckBoxPartUpdate"
        Me.CheckBoxPartUpdate.Size = New System.Drawing.Size(140, 21)
        Me.CheckBoxPartUpdate.TabIndex = 12
        Me.CheckBoxPartUpdate.Text = "Update and Save"
        Me.CheckBoxPartUpdate.UseVisualStyleBackColor = True
        '
        'ButtonPartsGo
        '
        Me.ButtonPartsGo.Location = New System.Drawing.Point(393, 238)
        Me.ButtonPartsGo.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonPartsGo.Name = "ButtonPartsGo"
        Me.ButtonPartsGo.Size = New System.Drawing.Size(125, 37)
        Me.ButtonPartsGo.TabIndex = 11
        Me.ButtonPartsGo.Text = "Go"
        Me.ButtonPartsGo.UseVisualStyleBackColor = True
        '
        'Products
        '
        Me.Products.Controls.Add(Me.CheckBoxProductUpdate)
        Me.Products.Controls.Add(Me.ButtonProductsGo)
        Me.Products.Location = New System.Drawing.Point(4, 22)
        Me.Products.Margin = New System.Windows.Forms.Padding(4)
        Me.Products.Name = "Products"
        Me.Products.Size = New System.Drawing.Size(529, 285)
        Me.Products.TabIndex = 2
        Me.Products.Text = "Products"
        Me.Products.UseVisualStyleBackColor = True
        '
        'CheckBoxProductUpdate
        '
        Me.CheckBoxProductUpdate.AutoSize = True
        Me.CheckBoxProductUpdate.Location = New System.Drawing.Point(13, 12)
        Me.CheckBoxProductUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxProductUpdate.Name = "CheckBoxProductUpdate"
        Me.CheckBoxProductUpdate.Size = New System.Drawing.Size(140, 21)
        Me.CheckBoxProductUpdate.TabIndex = 13
        Me.CheckBoxProductUpdate.Text = "Update and Save"
        Me.CheckBoxProductUpdate.UseVisualStyleBackColor = True
        '
        'ButtonProductsGo
        '
        Me.ButtonProductsGo.Location = New System.Drawing.Point(393, 238)
        Me.ButtonProductsGo.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonProductsGo.Name = "ButtonProductsGo"
        Me.ButtonProductsGo.Size = New System.Drawing.Size(125, 37)
        Me.ButtonProductsGo.TabIndex = 12
        Me.ButtonProductsGo.Text = "Go"
        Me.ButtonProductsGo.UseVisualStyleBackColor = True
        '
        'CheckBoxSourceRecursive
        '
        Me.CheckBoxSourceRecursive.AutoSize = True
        Me.CheckBoxSourceRecursive.Location = New System.Drawing.Point(167, 105)
        Me.CheckBoxSourceRecursive.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxSourceRecursive.Name = "CheckBoxSourceRecursive"
        Me.CheckBoxSourceRecursive.Size = New System.Drawing.Size(184, 21)
        Me.CheckBoxSourceRecursive.TabIndex = 11
        Me.CheckBoxSourceRecursive.Text = "Process sub files/folders"
        Me.CheckBoxSourceRecursive.UseVisualStyleBackColor = True
        '
        'CheckBoxSourceOverwrite
        '
        Me.CheckBoxSourceOverwrite.AutoSize = True
        Me.CheckBoxSourceOverwrite.Checked = True
        Me.CheckBoxSourceOverwrite.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxSourceOverwrite.Location = New System.Drawing.Point(360, 105)
        Me.CheckBoxSourceOverwrite.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxSourceOverwrite.Name = "CheckBoxSourceOverwrite"
        Me.CheckBoxSourceOverwrite.Size = New System.Drawing.Size(115, 21)
        Me.CheckBoxSourceOverwrite.TabIndex = 12
        Me.CheckBoxSourceOverwrite.Text = "Save in place"
        Me.CheckBoxSourceOverwrite.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(565, 550)
        Me.Controls.Add(Me.CheckBoxSourceOverwrite)
        Me.Controls.Add(Me.CheckBoxSourceRecursive)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxDestinationFolder)
        Me.Controls.Add(Me.ButtonDestinationFolder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxSourceFolder)
        Me.Controls.Add(Me.ButtonSourceFolder)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.Text = "BatchProcess v1.0"
        Me.TabControl1.ResumeLayout(false)
        Me.Drawings.ResumeLayout(false)
        Me.Drawings.PerformLayout
        Me.Parts.ResumeLayout(false)
        Me.Parts.PerformLayout
        Me.Products.ResumeLayout(false)
        Me.Products.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents ButtonSourceFolder As System.Windows.Forms.Button
    Friend WithEvents TextBoxSourceFolder As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDestinationFolder As System.Windows.Forms.TextBox
    Friend WithEvents ButtonDestinationFolder As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialogSource As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents FolderBrowserDialogDestination As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Drawings As System.Windows.Forms.TabPage
    Friend WithEvents CheckBoxDrawingExport As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBoxDrawingExportFormat As System.Windows.Forms.ComboBox
    Friend WithEvents Parts As System.Windows.Forms.TabPage
    Friend WithEvents ButtonDrawingsGo As System.Windows.Forms.Button
    Friend WithEvents ButtonPartsGo As System.Windows.Forms.Button
    Friend WithEvents CheckBoxPartUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents Products As System.Windows.Forms.TabPage
    Friend WithEvents ButtonProductsGo As System.Windows.Forms.Button
    Friend WithEvents CheckBoxSourceRecursive As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDrawingUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxSourceOverwrite As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxProductUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxPartExportSolids As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBoxPartExportSolidsFormat As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBoxForceUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxLayerTransfer As System.Windows.Forms.CheckBox
End Class
