<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.lblAuthors = New System.Windows.Forms.Label()
        Me.lblAuthorsName = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Location = New System.Drawing.Point(469, 342)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WorstEnemies.My.Resources.Resources._2ndOrderLogo200
        Me.PictureBox1.Location = New System.Drawing.Point(12, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(208, 232)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblAbout
        '
        Me.lblAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout.Location = New System.Drawing.Point(280, 60)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(212, 73)
        Me.lblAbout.TabIndex = 2
        Me.lblAbout.Text = "Enemies Of The Second Order"
        '
        'lblAuthors
        '
        Me.lblAuthors.AutoSize = True
        Me.lblAuthors.Location = New System.Drawing.Point(248, 240)
        Me.lblAuthors.Name = "lblAuthors"
        Me.lblAuthors.Size = New System.Drawing.Size(46, 13)
        Me.lblAuthors.TabIndex = 3
        Me.lblAuthors.Text = "Authors:"
        '
        'lblAuthorsName
        '
        Me.lblAuthorsName.AutoSize = True
        Me.lblAuthorsName.Location = New System.Drawing.Point(315, 240)
        Me.lblAuthorsName.Name = "lblAuthorsName"
        Me.lblAuthorsName.Size = New System.Drawing.Size(140, 13)
        Me.lblAuthorsName.TabIndex = 4
        Me.lblAuthorsName.Text = "Ryan Beckett,  Shreeji Patel"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(248, 274)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(45, 13)
        Me.lblVersion.TabIndex = 5
        Me.lblVersion.Text = "Version:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(315, 274)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "1.1"
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 397)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblAuthorsName)
        Me.Controls.Add(Me.lblAuthors)
        Me.Controls.Add(Me.lblAbout)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "frmAbout"
        Me.Text = "frmAbout"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblAbout As Label
    Friend WithEvents lblAuthors As Label
    Friend WithEvents lblAuthorsName As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents Label1 As Label
End Class
