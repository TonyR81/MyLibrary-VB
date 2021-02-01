Imports System.Drawing
Imports System.Windows.Forms

Public Class CloseButton


#Region "Private Declarations"


#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"


#End Region ' End Properties

#Region "Constructors"

    ''' <summary>
    ''' Creates a new empty instance of Close Button class
    ''' </summary>
    Public Sub New()
        InitializeComponent()
        Text = "X"
        BackColor = Color.FromArgb(31, 30, 68)
    End Sub

#End Region ' End Constructors

#Region "Functions"


#End Region ' Fine Regione Functions

#Region "Subs"


#End Region ' Fine Regions Subs

#Region "Events"

    Private Sub CloseButton_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        BackColor = Color.Red
    End Sub

    Private Sub CloseButton_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        BackColor = Color.FromArgb(31, 30, 68)
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim f As Form = Parent
        f.Close()
    End Sub

#End Region ' Fine Events


End Class
