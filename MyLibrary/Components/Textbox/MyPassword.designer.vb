Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MyPassword
    Inherits MyTextBox

    <System.Diagnostics.DebuggerStepThrough>
    Private Sub InitializeComponent()
        Me.Eye = New System.Windows.Forms.PictureBox()
        CType(Me.Eye, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Eye
        '
        Me.Eye.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Eye.Dock = System.Windows.Forms.DockStyle.Right
        Me.Eye.Image = Global.MyLibrary.My.Resources.Resources.closed_eye
        Me.Eye.Location = New System.Drawing.Point(74, 0)
        Me.Eye.Name = "Eye"
        Me.Eye.Size = New System.Drawing.Size(22, 16)
        Me.Eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Eye.TabIndex = 0
        Me.Eye.TabStop = False
        '
        'MyPassword
        '
        Me.Controls.Add(Me.Eye)
        Me.MaxLength = 16
        CType(Me.Eye, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Eye As PictureBox
End Class
