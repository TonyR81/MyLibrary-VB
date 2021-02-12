Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginFormClassic
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginFormClassic))
        Dim Language1 As MyLibrary.Language = New MyLibrary.Language()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.LinkRegister = New System.Windows.Forms.Label()
        Me.UserPicture = New System.Windows.Forms.PictureBox()
        Me.LoginProgress = New System.Windows.Forms.ProgressBar()
        Me.LoginLabel = New System.Windows.Forms.Label()
        Me.TxtPassword = New MyLibrary.MyPassword()
        Me.TxtUsername = New MyLibrary.MyTextBox()
        Me.ChkCredentials = New MyLibrary.MySwitch()
        Me.BtnLogin = New System.Windows.Forms.Button()
        CType(Me.UserPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Location = New System.Drawing.Point(122, 16)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(55, 13)
        Me.LabelUsername.TabIndex = 1
        Me.LabelUsername.Text = "Username"
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Location = New System.Drawing.Point(122, 55)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(53, 13)
        Me.LabelPassword.TabIndex = 3
        Me.LabelPassword.Text = "Password"
        '
        'LinkRegister
        '
        Me.LinkRegister.AutoSize = True
        Me.LinkRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkRegister.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LinkRegister.Location = New System.Drawing.Point(214, 176)
        Me.LinkRegister.Name = "LinkRegister"
        Me.LinkRegister.Size = New System.Drawing.Size(80, 13)
        Me.LinkRegister.TabIndex = 8
        Me.LinkRegister.Text = "Create account"
        '
        'UserPicture
        '
        Me.UserPicture.Image = Global.MyLibrary.My.Resources.Resources.user
        Me.UserPicture.Location = New System.Drawing.Point(12, 55)
        Me.UserPicture.Name = "UserPicture"
        Me.UserPicture.Size = New System.Drawing.Size(100, 100)
        Me.UserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UserPicture.TabIndex = 6
        Me.UserPicture.TabStop = False
        '
        'LoginProgress
        '
        Me.LoginProgress.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoginProgress.Location = New System.Drawing.Point(12, 202)
        Me.LoginProgress.MarqueeAnimationSpeed = 1
        Me.LoginProgress.Name = "LoginProgress"
        Me.LoginProgress.Size = New System.Drawing.Size(363, 10)
        Me.LoginProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.LoginProgress.TabIndex = 9
        Me.LoginProgress.Visible = False
        '
        'LoginLabel
        '
        Me.LoginLabel.AutoSize = True
        Me.LoginLabel.Location = New System.Drawing.Point(12, 189)
        Me.LoginLabel.Name = "LoginLabel"
        Me.LoginLabel.Size = New System.Drawing.Size(0, 13)
        Me.LoginLabel.TabIndex = 10
        '
        'TxtPassword
        '
        Me.TxtPassword.AcceptedCharacters = MyLibrary.AcceptedCharacters.All
        Me.TxtPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPassword.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPassword.EmptyBackColor = System.Drawing.Color.Empty
        Me.TxtPassword.FillBackColor = System.Drawing.Color.Empty
        Me.TxtPassword.Language = Nothing
        Me.TxtPassword.Location = New System.Drawing.Point(125, 71)
        Me.TxtPassword.MaxLength = 150
        Me.TxtPassword.MenuEnabled = False
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(250, 20)
        Me.TxtPassword.Status = MyLibrary.Visibility.CLOSED
        Me.TxtPassword.TabIndex = 2
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'TxtUsername
        '
        Me.TxtUsername.AcceptedCharacters = MyLibrary.AcceptedCharacters.All
        Me.TxtUsername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtUsername.BackColor = System.Drawing.SystemColors.Window
        Me.TxtUsername.EmptyBackColor = System.Drawing.Color.Empty
        Me.TxtUsername.FillBackColor = System.Drawing.Color.Empty
        Me.TxtUsername.Language = Nothing
        Me.TxtUsername.Location = New System.Drawing.Point(125, 32)
        Me.TxtUsername.MaxLength = 150
        Me.TxtUsername.MenuEnabled = False
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(250, 20)
        Me.TxtUsername.TabIndex = 0
        '
        'ChkCredentials
        '
        Me.ChkCredentials.AutoSize = True
        Me.ChkCredentials.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkCredentials.Location = New System.Drawing.Point(149, 97)
        Me.ChkCredentials.Name = "ChkCredentials"
        Me.ChkCredentials.Size = New System.Drawing.Size(188, 24)
        Me.ChkCredentials.SwitchText = "Stay connected"
        Me.ChkCredentials.TabIndex = 12
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogin.FlatAppearance.BorderSize = 0
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnLogin.Location = New System.Drawing.Point(162, 137)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(175, 36)
        Me.BtnLogin.TabIndex = 13
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'LoginFormClassic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 224)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.ChkCredentials)
        Me.Controls.Add(Me.LoginLabel)
        Me.Controls.Add(Me.LoginProgress)
        Me.Controls.Add(Me.LinkRegister)
        Me.Controls.Add(Me.UserPicture)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.LabelUsername)
        Me.Controls.Add(Me.TxtUsername)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Language = Language1
        Me.MinimumSize = New System.Drawing.Size(403, 254)
        Me.Name = "LoginFormClassic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.UserPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtUsername As MyTextBox
    Friend WithEvents LabelUsername As Label
    Friend WithEvents LabelPassword As Label
    Friend WithEvents TxtPassword As MyPassword
    Friend WithEvents UserPicture As PictureBox
    Friend WithEvents LinkRegister As Label
    Friend WithEvents LoginProgress As ProgressBar
    Friend WithEvents LoginLabel As Label
    Friend WithEvents ChkCredentials As MySwitch
    Friend WithEvents BtnLogin As Button
End Class
