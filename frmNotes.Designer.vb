<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotes
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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudEnemyID = New System.Windows.Forms.NumericUpDown()
        Me.rtxtMain = New System.Windows.Forms.RichTextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        CType(Me.nudEnemyID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(13, 303)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(95, 303)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "EnemyID:"
        '
        'nudEnemyID
        '
        Me.nudEnemyID.Location = New System.Drawing.Point(81, 11)
        Me.nudEnemyID.Name = "nudEnemyID"
        Me.nudEnemyID.ReadOnly = True
        Me.nudEnemyID.Size = New System.Drawing.Size(120, 20)
        Me.nudEnemyID.TabIndex = 3
        '
        'rtxtMain
        '
        Me.rtxtMain.Location = New System.Drawing.Point(16, 42)
        Me.rtxtMain.Name = "rtxtMain"
        Me.rtxtMain.Size = New System.Drawing.Size(419, 255)
        Me.rtxtMain.TabIndex = 4
        Me.rtxtMain.Text = ""
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(176, 303)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(218, 12)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(149, 23)
        Me.lblStatus.TabIndex = 6
        '
        'frmNotes
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(447, 338)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.rtxtMain)
        Me.Controls.Add(Me.nudEnemyID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Name = "frmNotes"
        Me.Text = "frmNotes"
        CType(Me.nudEnemyID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents nudEnemyID As NumericUpDown
    Friend WithEvents rtxtMain As RichTextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents lblStatus As Label
End Class
