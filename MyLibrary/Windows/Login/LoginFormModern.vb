Imports System.Windows.Forms
Imports Newtonsoft.Json.Linq

Public Class LoginFormModern

#Region "Private Declarations"


#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"


#End Region ' End Properties

#Region "Constructors"


#End Region ' End Constructors

#Region "Functions"


#End Region ' Fine Regione Functions

#Region "Subs"

    Private Sub Login()

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