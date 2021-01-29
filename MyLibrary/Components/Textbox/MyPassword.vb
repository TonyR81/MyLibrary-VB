Imports System.Windows.Forms
Public Class MyPassword

#Region "Enumeration"


#End Region ' End Enumeration

#Region "Dichiarazioni Private"

    Private mStatus As Visibility
    Private Baloon As ToolTip

#End Region ' Fine Regione Dichiarazioni Private

#Region "Proprietà"

    ''' <summary>
    ''' Ottiene o imposta lo stato
    ''' </summary>
    ''' <returns>Status</returns>	  
    Public Property Status() As Visibility
        Get
            Return mStatus
        End Get
        Set(ByVal value As Visibility)
            mStatus = value
            Select Case value
                Case Visibility.OPENED
                    Eye.Image = My.Resources.opened_eye
                    MyBase.PasswordChar = Nothing
                    MyBase.UseSystemPasswordChar = False
                Case Visibility.CLOSED
                    Eye.Image = My.Resources.closed_eye
                    MyBase.PasswordChar = "*"
                    MyBase.UseSystemPasswordChar = True
            End Select
        End Set
    End Property

#End Region ' Fine Regione Proprietà

#Region "Costruttori"

    ''' <summary>
    ''' Creates a new empty instance of MyPassword class
    ''' </summary>
    Public Sub New()
        InitializeComponent()
    End Sub

#End Region ' Fine Regione Costruttori

#Region "Eventi"

    Private Sub Occhio_Click(sender As Object, e As EventArgs) Handles Eye.Click
        Status = If(Status = Visibility.OPENED, Visibility.CLOSED, Visibility.OPENED)
    End Sub

    Private Sub Eye_MouseHover(sender As Object, e As EventArgs) Handles Eye.MouseHover
        If Not IsNothing(Baloon) Then
            Baloon.Dispose()
        End If
        Baloon = New ToolTip()
        Baloon.Show(New Language(My.Settings.Language).GetString("baloons", If(Status = Visibility.CLOSED, "show_password", "hide_password")), Eye)
    End Sub

#End Region ' Fine Regione Eventi

End Class
