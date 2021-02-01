Imports System.Drawing
Imports System.Windows.Forms
''' <summary>
''' Toolbar class
''' <para>Created by Antonino Razeti on August 04, 2020</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of Toolbar object</para>
''' </summary>
Public Class Toolbar

#Region "Private Declarations"

    Private mTitle As String
    Private MoveForm As Boolean
    Public _MousePosition As Point
    Private mIcon As Image
    Private mImage As Image

    Private OriginalSize As Size
    Private OriginalLocation As Point
    Private OnMouseHoverSize
    Private mHasMinimize As Boolean = True
    Private mHasWindowState As Boolean = True
    Private mHasClose As Boolean = True

#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"

    ''' <summary>
    ''' Gets or sets Title
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Title() As String
        Get
            Return mTitle
        End Get
        Set(ByVal value As String)
            mTitle = value
            TitleLabel.Text = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets Icon
    ''' </summary>
    ''' <returns>Image</returns>
    Public Property Icon() As Image
        Get
            Return mIcon
        End Get
        Set(ByVal value As Image)
            mIcon = value
            IconToolbar.Image = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets Image
    ''' </summary>
    ''' <returns>Image</returns>
    Public Property Image() As Image
        Get
            Return mImage
        End Get
        Set(ByVal value As Image)
            mImage = value
            IconToolbar.Image = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets HasMinimize
    ''' </summary>
    ''' <returns>Boolean</returns>
    Public Property HasMinimize() As Boolean
        Get
            Return mHasMinimize
        End Get
        Set(ByVal value As Boolean)
            mHasMinimize = value
            BtnMinimize.Visible = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets HasWindowState
    ''' </summary>
    ''' <returns>Boolean</returns>
    Public Property HasWindowState() As Boolean
        Get
            Return mHasWindowState
        End Get
        Set(ByVal value As Boolean)
            mHasWindowState = value
            BtnWindowState.Visible = value
        End Set
    End Property


    ''' <summary>
    ''' Gets or sets HasClose
    ''' </summary>
    ''' <returns>Boolean = True</returns>
    Public Property HasClose() As Boolean
        Get
            Return mHasClose
        End Get
        Set(ByVal value As Boolean)
            mHasClose = value
            BtnClose.Visible = value
        End Set
    End Property

#End Region ' End Properties

#Region "Constructors"

    ''' <summary>
    ''' Creates a new instance of Toolbar class component
    ''' </summary>
    Public Sub New()
        InitializeComponent()
        SetWindowStateIcon()
        Dock = DockStyle.Top
    End Sub

#End Region ' End Constructors

#Region "Functions"


#End Region ' Fine Regione Functions

#Region "Subs"


#End Region ' Fine Regions Subs

#Region "Events"

    Private Sub Toolbar_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, TitleLabel.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Cursor = Cursors.NoMove2D
            _MousePosition = e.Location
        End If
    End Sub

    Private Sub Toolbar_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, TitleLabel.MouseMove
        If MoveForm Then
            ParentForm.Location = ParentForm.Location + (e.Location - _MousePosition)
        End If
    End Sub

    Private Sub Toolbar_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp, TitleLabel.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        ParentForm.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub SetWindowStateIcon() Handles BtnWindowState.Click
        Try
            If Not IsNothing(ParentForm) Then
                ParentForm.WindowState = If(Me.ParentForm.WindowState = FormWindowState.Maximized, FormWindowState.Normal, FormWindowState.Maximized)
                Select Case Me.ParentForm.WindowState
                    Case FormWindowState.Normal
                        BtnWindowState.Image = My.Resources.maximize
                    Case FormWindowState.Minimized
                        BtnWindowState.Image = My.Resources.normalize
                    Case FormWindowState.Maximized
                        BtnWindowState.Image = My.Resources.normalize
                End Select
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        If Not IsNothing(Me.ParentForm) Then
            ParentForm.Close()
        End If
    End Sub

    Private Sub SetButtons() Handles Me.SizeChanged, Me.Resize, Me.Load
        Try
            BtnClose.OriginalSize = BtnClose.Size
            BtnClose.OriginalLocation = BtnClose.Location
            BtnWindowState.OriginalSize = BtnWindowState.Size
            BtnWindowState.OriginalLocation = BtnWindowState.Location
            BtnMinimize.OriginalSize = BtnMinimize.Size
            BtnMinimize.OriginalLocation = BtnMinimize.Location
        Catch ex As Exception

        End Try
    End Sub

#End Region ' Fine Events


End Class
