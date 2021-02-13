Imports Newtonsoft.Json.Linq
''' <summary>
''' Login class
''' <para>Created by Antonino Razeti on 30th May, 2020</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of Login object</para>
''' <para>Implements ILogin</para>
''' </summary>
Public Class LoginFormClassic

#Region "Private Declarations"

    Private Delegate Sub OnStartLoginProgressDelegate()
    Private OnStartLoginProgress As New OnStartLoginProgressDelegate(AddressOf StartProgressLogin)


    Private Delegate Sub OnStopLoginProgressDelegate()
    Private OnStopLoginProgress As New OnStopLoginProgressDelegate(AddressOf StopLoginProgress)

#End Region ' End Private Declarations

#Region "Constructors"

    ''' <summary>
    ''' Creates a new empty instance of LoginForm class
    ''' </summary>
    Public Sub New()
        InitializeComponent()
    End Sub

#End Region ' End Constructors

#Region "Subs"

    ''' <summary>
    ''' Login
    ''' </summary>
    Private Sub Login()
        Invoke(OnStartLoginProgress)
        Dim errorMessage As String = ""
        Dim user As New Account(TxtUsername.Text, TxtPassword.Text)
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
                    If ChkCredentials.Checked Then
                        My.Settings.Logged = True
                        My.Settings.Username = TxtUsername.Text
                        My.Settings.Password = TxtPassword.Text
                        My.Settings.Save()
                    End If
                    Invoke(OnStopLoginProgress)
                    Close()
                End If
            End If
        Catch wrongCredentials As WrongCredentialsException
            errorMessage = wrongCredentials.GetMessage
            TxtUsername.StartBlink()
            TxtPassword.StartBlink()
            Invoke(OnStopLoginProgress)
        Catch unverified As UnverifiedUserException
            errorMessage = unverified.GetMessage
            Invoke(OnStopLoginProgress)
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
            Text = .GetString("forms", "login")
            LabelUsername.Text = .GetString("user", "username")
            LabelPassword.Text = .GetString("user", "password")
            BtnLogin.Text = .GetString("actions", "login")
            ChkCredentials.SwitchText = .GetString("actions", "stay_connected")
            LinkRegister.Text = .GetString("actions", "create_account")
        End With
    End Sub

    Private Sub StopLoginProgress()
        LoginProgress.Visible = False
    End Sub

    Private Sub StartProgressLogin()
        LoginProgress.Visible = True
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
            MyMessage(ex.GetMessage, MsgBoxStyle.Critical, MessageSplash.DisplayMode.TOAST)
        End Try
    End Sub

    Private Sub LinkRegister_Click(sender As Object, e As EventArgs) Handles LinkRegister.Click
        Try
            ' Process.Start(String.Format("{0}\register.php", My.Settings.Domain))
            Dim register As New RegisterClassic
            register.Show()
            Hide()
        Catch ex As Exception
            ' Registrazione tramite form locale
        End Try
    End Sub

#End Region ' Fine Events

End Class