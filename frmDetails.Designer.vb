<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetails
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
        Me.lblEnemyID = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblThreat = New System.Windows.Forms.Label()
        Me.lblAlliance = New System.Windows.Forms.Label()
        Me.txtEnemyID = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtThreatLevel = New System.Windows.Forms.TextBox()
        Me.txtAllianceID = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEnemyID
        '
        Me.lblEnemyID.Location = New System.Drawing.Point(13, 25)
        Me.lblEnemyID.Name = "lblEnemyID"
        Me.lblEnemyID.Size = New System.Drawing.Size(62, 13)
        Me.lblEnemyID.TabIndex = 0
        Me.lblEnemyID.Text = "EnemyID:"
        Me.lblEnemyID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFirstName
        '
        Me.lblFirstName.Location = New System.Drawing.Point(13, 58)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(62, 13)
        Me.lblFirstName.TabIndex = 1
        Me.lblFirstName.Text = "First Name:"
        Me.lblFirstName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblLastName
        '
        Me.lblLastName.Location = New System.Drawing.Point(13, 91)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(62, 13)
        Me.lblLastName.TabIndex = 2
        Me.lblLastName.Text = "Last Name:"
        Me.lblLastName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblThreat
        '
        Me.lblThreat.Location = New System.Drawing.Point(13, 124)
        Me.lblThreat.Name = "lblThreat"
        Me.lblThreat.Size = New System.Drawing.Size(62, 13)
        Me.lblThreat.TabIndex = 3
        Me.lblThreat.Text = "Threat:"
        Me.lblThreat.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAlliance
        '
        Me.lblAlliance.Location = New System.Drawing.Point(13, 157)
        Me.lblAlliance.Name = "lblAlliance"
        Me.lblAlliance.Size = New System.Drawing.Size(62, 20)
        Me.lblAlliance.TabIndex = 4
        Me.lblAlliance.Text = "Alliance:"
        Me.lblAlliance.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtEnemyID
        '
        Me.txtEnemyID.Location = New System.Drawing.Point(81, 21)
        Me.txtEnemyID.Name = "txtEnemyID"
        Me.txtEnemyID.Size = New System.Drawing.Size(121, 20)
        Me.txtEnemyID.TabIndex = 5
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(81, 54)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(121, 20)
        Me.txtFirstName.TabIndex = 6
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(81, 87)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(121, 20)
        Me.txtLastName.TabIndex = 7
        '
        'txtThreatLevel
        '
        Me.txtThreatLevel.Location = New System.Drawing.Point(81, 120)
        Me.txtThreatLevel.Name = "txtThreatLevel"
        Me.txtThreatLevel.Size = New System.Drawing.Size(121, 20)
        Me.txtThreatLevel.TabIndex = 8
        '
        'txtAllianceID
        '
        Me.txtAllianceID.Location = New System.Drawing.Point(81, 153)
        Me.txtAllianceID.Name = "txtAllianceID"
        Me.txtAllianceID.Size = New System.Drawing.Size(121, 20)
        Me.txtAllianceID.TabIndex = 9
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(13, 226)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(95, 225)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 11
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(177, 225)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(95, 196)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmDetails
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(269, 261)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtAllianceID)
        Me.Controls.Add(Me.txtThreatLevel)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtEnemyID)
        Me.Controls.Add(Me.lblAlliance)
        Me.Controls.Add(Me.lblThreat)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblEnemyID)
        Me.Name = "frmDetails"
        Me.Text = "frmDetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEnemyID As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblThreat As Label
    Friend WithEvents lblAlliance As Label
    Friend WithEvents txtEnemyID As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtThreatLevel As TextBox
    Friend WithEvents txtAllianceID As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
End Class
