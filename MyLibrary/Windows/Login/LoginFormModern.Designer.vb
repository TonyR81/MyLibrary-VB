<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginFormModern
    Inherits System.Windows.Forms.Form

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnRegister = New MyLibrary.MyButton()
        Me.BtnLogin = New MyLibrary.MyButton()
        Me.TxtPassword = New MyLibrary.MyPassword()
        Me.TxtUsername = New MyLibrary.MyTextBox()
        Me.SwitchRemeberMe = New MyLibrary.MySwitch()
        Me.LabelNotAccount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
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
        Me.Panel2.Location = New System.Drawing.Point(61, 256)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(254, 1)
        Me.Panel2.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(372, 105)
        Me.Panel3.TabIndex = 6
        '
        'BtnRegister
        '
        Me.BtnRegister.AutoSize = True
        Me.BtnRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegister.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnRegister.FlatAppearance.BorderSize = 2
        Me.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegister.ForeColor = System.Drawing.Color.White
        Me.BtnRegister.Location = New System.Drawing.Point(46, 384)
        Me.BtnRegister.MinimumSize = New System.Drawing.Size(275, 23)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(275, 35)
        Me.BtnRegister.TabIndex = 8
        Me.BtnRegister.Text = "Register"
        Me.BtnRegister.UseVisualStyleBackColor = True
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
        Me.BtnLogin.Location = New System.Drawing.Point(52, 315)
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
        Me.TxtPassword.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPassword.EmptyBackColor = System.Drawing.Color.Empty
        Me.TxtPassword.FillBackColor = System.Drawing.Color.Empty
        Me.TxtPassword.Language = Nothing
        Me.TxtPassword.Location = New System.Drawing.Point(61, 220)
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
        Me.TxtUsername.BackColor = System.Drawing.SystemColors.Window
        Me.TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUsername.EmptyBackColor = System.Drawing.Color.Empty
        Me.TxtUsername.FillBackColor = System.Drawing.Color.Empty
        Me.TxtUsername.Language = Nothing
        Me.TxtUsername.Location = New System.Drawing.Point(61, 154)
        Me.TxtUsername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtUsername.MaxLength = 150
        Me.TxtUsername.MenuEnabled = False
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(254, 22)
        Me.TxtUsername.TabIndex = 0
        '
        'SwitchRemeberMe
        '
        Me.SwitchRemeberMe.AutoSize = True
        Me.SwitchRemeberMe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SwitchRemeberMe.Location = New System.Drawing.Point(72, 265)
        Me.SwitchRemeberMe.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.SwitchRemeberMe.Name = "SwitchRemeberMe"
        Me.SwitchRemeberMe.Size = New System.Drawing.Size(229, 33)
        Me.SwitchRemeberMe.SwitchText = "Remember me"
        Me.SwitchRemeberMe.TabIndex = 9
        '
        'LabelNotAccount
        '
        Me.LabelNotAccount.AutoSize = True
        Me.LabelNotAccount.Location = New System.Drawing.Point(130, 353)
        Me.LabelNotAccount.Name = "LabelNotAccount"
        Me.LabelNotAccount.Size = New System.Drawing.Size(112, 21)
        Me.LabelNotAccount.TabIndex = 10
        Me.LabelNotAccount.Text = "Not Account?"
        '
        'LoginFormModern
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(372, 441)
        Me.Controls.Add(Me.LabelNotAccount)
        Me.Controls.Add(Me.SwitchRemeberMe)
        Me.Controls.Add(Me.BtnRegister)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUsername)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "LoginFormModern"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtUsername As MyTextBox
    Friend WithEvents TxtPassword As MyPassword
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents Panel2 As Windows.Forms.Panel
    Friend WithEvents Panel3 As Windows.Forms.Panel
    Friend WithEvents BtnLogin As MyButton
    Friend WithEvents BtnRegister As MyButton
    Friend WithEvents SwitchRemeberMe As MySwitch
    Friend WithEvents LabelNotAccount As Windows.Forms.Label
End Class
