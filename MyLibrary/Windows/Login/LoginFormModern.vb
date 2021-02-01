Imports MyLibrary.Windows.Login
Imports Newtonsoft.Json.Linq

Public Class LoginFormModern

#Region "Functions"


#End Region ' Fine Regione Functions

#Region "Subs"

    ''' <summary>
    ''' Login
    ''' </summary>
    Private Sub Login()
        Dim user As New User(TxtUsername.Text, TxtPassword.Text)
        Dim json As JObject = New ServerRequest("login").GetResponse(user.ToPost)
        If Not IsNothing(json) Then
            Dim response As Boolean = json.SelectToken("response")
            Try

            Catch ex As WrongCredentialsException
                Dim message As New MessageSplash(ex.Message, MsgBoxStyle.Critical, MessageSplash.DisplayMode.TOAST)
                message.Show()
                TxtUsername.SelectAll()
            End Try
        End If
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