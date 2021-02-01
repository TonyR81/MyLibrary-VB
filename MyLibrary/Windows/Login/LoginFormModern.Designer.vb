<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginFormModern
    Inherits FormBase

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Language1 As MyLibrary.Language = New MyLibrary.Language()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnLogin = New MyLibrary.MyButton()
        Me.TxtPassword = New MyLibrary.MyPassword()
        Me.TxtUsername = New MyLibrary.MyTextBox()
        Me.SwitchRemember = New MyLibrary.Switch()
        Me.LabelRemeber = New System.Windows.Forms.Label()
        Me.LinkRegister = New System.Windows.Forms.LinkLabel()
        Me.BtnClose = New MyLibrary.CloseButton()
        Me.SuspendLayout()
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Location = New System.Drawing.Point(57, 136)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(87, 21)
        Me.LabelUsername.TabIndex = 2
        Me.LabelUsername.Text = "Username"
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Location = New System.Drawing.Point(57, 194)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(82, 21)
        Me.LabelPassword.TabIndex = 3
        Me.LabelPassword.Text = "Password"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(61, 190)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(254, 1)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(61, 252)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(254, 1)
        Me.Panel2.TabIndex = 5
        '
        'BtnLogin
        '
        Me.BtnLogin.AutoSize = True
        Me.BtnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnLogin.FlatAppearance.BorderSize = 2
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.ForeColor = System.Drawing.Color.White
        Me.BtnLogin.Location = New System.Drawing.Point(49, 329)
        Me.BtnLogin.MinimumSize = New System.Drawing.Size(275, 23)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(275, 35)
        Me.BtnLogin.TabIndex = 7
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'TxtPassword
        '
        Me.TxtPassword.AcceptedCharacters = MyLibrary.AcceptedCharacters.All
        Me.TxtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPassword.EmptyBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TxtPassword.FillBackColor = System.Drawing.Color.Yellow
        Me.TxtPassword.Language = Nothing
        Me.TxtPassword.Location = New System.Drawing.Point(61, 226)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtPassword.MaxLength = 16
        Me.TxtPassword.MenuEnabled = False
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(254, 22)
        Me.TxtPassword.Status = MyLibrary.Visibility.CLOSED
        Me.TxtPassword.TabIndex = 1
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'TxtUsername
        '
        Me.TxtUsername.AcceptedCharacters = MyLibrary.AcceptedCharacters.All
        Me.TxtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUsername.EmptyBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TxtUsername.FillBackColor = System.Drawing.Color.Yellow
        Me.TxtUsername.Language = Nothing
        Me.TxtUsername.Location = New System.Drawing.Point(61, 164)
        Me.TxtUsername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtUsername.MaxLength = 150
        Me.TxtUsername.MenuEnabled = False
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(254, 22)
        Me.TxtUsername.TabIndex = 0
        '
        'SwitchRemember
        '
        Me.SwitchRemember.Checked = False
        Me.SwitchRemember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SwitchRemember.Location = New System.Drawing.Point(97, 262)
        Me.SwitchRemember.Margin = New System.Windows.Forms.Padding(5)
        Me.SwitchRemember.Name = "SwitchRemember"
        Me.SwitchRemember.Size = New System.Drawing.Size(49, 30)
        Me.SwitchRemember.TabIndex = 11
        '
        'LabelRemeber
        '
        Me.LabelRemeber.AutoSize = True
        Me.LabelRemeber.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelRemeber.Location = New System.Drawing.Point(154, 267)
        Me.LabelRemeber.Name = "LabelRemeber"
        Me.LabelRemeber.Size = New System.Drawing.Size(121, 21)
        Me.LabelRemeber.TabIndex = 12
        Me.LabelRemeber.Text = "Remember me"
        '
        'LinkRegister
        '
        Me.LinkRegister.AutoSize = True
        Me.LinkRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkRegister.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkRegister.Location = New System.Drawing.Point(136, 377)
        Me.LinkRegister.Name = "LinkRegister"
        Me.LinkRegister.Size = New System.Drawing.Size(92, 15)
        Me.LinkRegister.TabIndex = 14
        Me.LinkRegister.TabStop = True
        Me.LinkRegister.Text = "Create account"
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnClose.FlatAppearance.BorderSize = 2
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.IsRounded = True
        Me.BtnClose.Location = New System.Drawing.Point(320, 12)
        Me.BtnClose.MaximumSize = New System.Drawing.Size(40, 40)
        Me.BtnClose.MinimumSize = New System.Drawing.Size(30, 30)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(40, 40)
        Me.BtnClose.TabIndex = 15
        Me.BtnClose.Text = "X"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'LoginFormModern
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(372, 429)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.LinkRegister)
        Me.Controls.Add(Me.LabelRemeber)
        Me.Controls.Add(Me.SwitchRemember)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.LabelUsername)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUsername)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Language = Language1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "LoginFormModern"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ""
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtUsername As MyTextBox
    Friend WithEvents TxtPassword As MyPassword
    Friend WithEvents LabelUsername As Windows.Forms.Label
    Friend WithEvents LabelPassword As Windows.Forms.Label
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents Panel2 As Windows.Forms.Panel
    Friend WithEvents BtnLogin As MyButton
    Friend WithEvents SwitchRemember As Switch
    Friend WithEvents LabelRemeber As Windows.Forms.Label
    Friend WithEvents LinkRegister As Windows.Forms.LinkLabel
    Friend WithEvents BtnClose As CloseButton
End Class
