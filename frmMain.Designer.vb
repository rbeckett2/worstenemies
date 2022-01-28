<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits WorstEnemiesBase

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
        Me.components = New System.ComponentModel.Container()
        Me.frmMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnemiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshEnemiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteCurrentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditCurrentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvMain = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnNotes = New System.Windows.Forms.Button()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.initTimer = New System.Windows.Forms.Timer(Me.components)
        Me.chkSticky = New System.Windows.Forms.CheckBox()
        Me.frmMenuStrip.SuspendLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'frmMenuStrip
        '
        Me.frmMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EnemiesToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.frmMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.frmMenuStrip.Name = "frmMenuStrip"
        Me.frmMenuStrip.Size = New System.Drawing.Size(583, 24)
        Me.frmMenuStrip.TabIndex = 0
        Me.frmMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EnemiesToolStripMenuItem
        '
        Me.EnemiesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshEnemiesToolStripMenuItem, Me.AddNewToolStripMenuItem, Me.DeleteCurrentToolStripMenuItem, Me.EditCurrentToolStripMenuItem, Me.NotesToolStripMenuItem})
        Me.EnemiesToolStripMenuItem.Name = "EnemiesToolStripMenuItem"
        Me.EnemiesToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.EnemiesToolStripMenuItem.Text = "&Enemies"
        '
        'RefreshEnemiesToolStripMenuItem
        '
        Me.RefreshEnemiesToolStripMenuItem.Name = "RefreshEnemiesToolStripMenuItem"
        Me.RefreshEnemiesToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.RefreshEnemiesToolStripMenuItem.Text = "&Refresh Enemies"
        '
        'AddNewToolStripMenuItem
        '
        Me.AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem"
        Me.AddNewToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.AddNewToolStripMenuItem.Text = "&Add New"
        '
        'DeleteCurrentToolStripMenuItem
        '
        Me.DeleteCurrentToolStripMenuItem.Name = "DeleteCurrentToolStripMenuItem"
        Me.DeleteCurrentToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.DeleteCurrentToolStripMenuItem.Text = "&Delete Current"
        '
        'EditCurrentToolStripMenuItem
        '
        Me.EditCurrentToolStripMenuItem.Name = "EditCurrentToolStripMenuItem"
        Me.EditCurrentToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.EditCurrentToolStripMenuItem.Text = "&Edit Current"
        '
        'NotesToolStripMenuItem
        '
        Me.NotesToolStripMenuItem.Name = "NotesToolStripMenuItem"
        Me.NotesToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.NotesToolStripMenuItem.Text = "&Notes"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToOrderColumns = True
        Me.dgvMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvMain.CausesValidation = False
        Me.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMain.Location = New System.Drawing.Point(0, 112)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.Size = New System.Drawing.Size(580, 286)
        Me.dgvMain.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 83)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add &New"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(93, 83)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "Edi&t"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnNotes
        '
        Me.btnNotes.Location = New System.Drawing.Point(174, 83)
        Me.btnNotes.Name = "btnNotes"
        Me.btnNotes.Size = New System.Drawing.Size(75, 23)
        Me.btnNotes.TabIndex = 4
        Me.btnNotes.Text = "N&otes"
        Me.btnNotes.UseVisualStyleBackColor = True
        '
        'lblHeader
        '
        Me.lblHeader.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHeader.BackColor = System.Drawing.Color.CornflowerBlue
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(65, 33)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(443, 36)
        Me.lblHeader.TabIndex = 5
        Me.lblHeader.Text = "Current Enemies of the Second Order"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'initTimer
        '
        Me.initTimer.Interval = 2000
        '
        'chkSticky
        '
        Me.chkSticky.AutoSize = True
        Me.chkSticky.Checked = True
        Me.chkSticky.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSticky.Location = New System.Drawing.Point(255, 87)
        Me.chkSticky.Name = "chkSticky"
        Me.chkSticky.Size = New System.Drawing.Size(253, 17)
        Me.chkSticky.TabIndex = 6
        Me.chkSticky.Text = "Stic&ky Cells (Clicking cell brings up details editor)"
        Me.chkSticky.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 397)
        Me.Controls.Add(Me.chkSticky)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.btnNotes)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvMain)
        Me.Controls.Add(Me.frmMenuStrip)
        Me.MainMenuStrip = Me.frmMenuStrip
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enemies of the Second Order"
        Me.frmMenuStrip.ResumeLayout(False)
        Me.frmMenuStrip.PerformLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents frmMenuStrip As MenuStrip
    Friend WithEvents dgvMain As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnNotes As Button
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnemiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblHeader As Label
    Friend WithEvents RefreshEnemiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteCurrentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditCurrentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents initTimer As Timer
    Friend WithEvents chkSticky As CheckBox
End Class
