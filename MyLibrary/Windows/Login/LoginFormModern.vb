Imports Newtonsoft.Json.Linq

Public Class LoginFormModern

#Region "Functions"


#End Region ' Fine Regione Functions

#Region "Subs"

    ''' <summary>
    ''' Login
    ''' </summary>
    Private Sub Login()
        Dim errorMessage As String = ""
        Dim user As New User(TxtUsername.Text, TxtPassword.Text)
        Dim db As New DatabaseHelper()
        Try
            If db.Login(user) Then
                Dim json As JObject = db.Response
                If Not IsNothing(json.SelectToken("user")) Then
                    Dim accountType As AccountType = Integer.Parse(json.SelectToken("user").SelectToken("account_type"))
                    Select Case accountType
                        Case AccountType.SUPERADMIN
                            Exit Select
                        Case AccountType.ADMIN
                            user = New Admin(json.SelectToken("user"))
                        Case AccountType.MAIN
                            Exit Select
                        Case AccountType.USER
                            Exit Select
                        Case AccountType.COMPANY
                            user = New Company(json.SelectToken("user"))
                        Case AccountType.EMPLOYEE
                            user = New Employee(json.SelectToken("user"))
                        Case AccountType.CUSTOMER
                            user = New Customer(json.SelectToken("user"))
                    End Select
                    Dim main As New ModernMain(user)
                    main.Show()
                    If SwitchRemember.Checked Then
                        My.Settings.Logged = True
                        My.Settings.Username = TxtUsername.Text
                        My.Settings.Password = TxtPassword.Text
                        My.Settings.Save()
                    End If
                    Close()
                End If
            End If
        Catch wrongCredentials As WrongCredentialsException
            errorMessage = wrongCredentials.GetMessage
            TxtUsername.StartBlink()
            TxtPassword.StartBlink()
        Catch unverified As UnverifiedUserException
            errorMessage = unverified.GetMessage
        Finally
            If Not String.IsNullOrEmpty(errorMessage) Then
                Dim message As New MessageSplash(errorMessage, MsgBoxStyle.Critical, MessageSplash.DisplayMode.TOAST)
                message.Show()
            End If
        End Try
    End Sub

    ''' <summary>
    ''' Translate current form
    ''' </summary>
    Protected Overrides Sub Translate()
        MyBase.Translate()
        With Language
            LabelUsername.Text = .GetString("user", "username")
            LabelPassword.Text = .GetString("user", "password")
            BtnLogin.Text = .GetString("actions", "login")
            LabelRemeber.Text = .GetString("actions", "stay_connected")
            LinkRegister.Text = .GetString("actions", "create_account")
        End With
    End Sub

#End Region ' Fine Regions Subs

#Region "Events"

    Private Sub LoginFormModern_Load(sender As Object, e As EventArgs) Handles Me.Load
        With My.Settings
            TxtUsername.Text = .Username
            TxtPassword.Text = .Password
            If .Logged And Not String.IsNullOrEmpty(TxtUsername.Text) And Not String.IsNullOrEmpty(TxtPassword.Text) Then
                Login()
            End If
        End With
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Try
            If Not String.IsNullOrEmpty(TxtUsername.Text) And Not String.IsNullOrEmpty(TxtPassword.Text) Then
                Login()
            Else
                CheckRequiredFields(TxtUsername, TxtPassword)
            End If
        Catch ex As RequiredFieldsException
            For Each t As MyTextBox In Me.Controls.OfType(Of MyTextBox)
                t.StartBlink()
            Next
            MyMessage("Sbrombacunio in the baby night tomorrow", MsgBoxStyle.Critical, MessageSplash.DisplayMode.TOAST)
        End Try
    End Sub

#End Region ' Fine Events

End Class