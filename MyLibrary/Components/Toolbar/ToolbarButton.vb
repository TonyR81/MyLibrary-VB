Imports System.Drawing
''' <summary>
''' Toolbar button class
''' <para>Created by Antonino Razeti on August 05, 2020</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of Toolbar button object</para>
''' <para>Implements IToolbar button</para>
''' </summary>
Public Class ToolbarButton

#Region "Private Declarations"

    Public OriginalSize As Size
    Public OriginalLocation As Point

#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"


#End Region ' End Properties

#Region "Constructors"

    ''' <summary>
    ''' Creates a new empty instance of Toolbar button
    ''' </summary>
    Public Sub New()
        InitializeComponent()
    End Sub

#End Region ' End Constructors

#Region "Functions"


#End Region ' Fine Regione Functions

#Region "Subs"


#End Region ' Fine Regions Subs

#Region "Events"

    Private Sub ToolbarButton_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        Try
            Me.Size = New Size(Me.OriginalSize.Width - 3, Me.OriginalSize.Height - 3)
            Me.Location = New Point(Me.OriginalLocation.X + 3, Me.OriginalLocation.Y + 3)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ToolbarButton_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        Try
            Me.Size = New Size(OriginalSize)
            Me.Location = New Point(OriginalLocation)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolbarButton_Click(sender As Object, e As EventArgs) Handles Me.Click
        Try
            Me.Size = New Size(OriginalSize)
            Me.Location = New Point(OriginalLocation)
        Catch ex As Exception

        End Try

    End Sub

#End Region ' Fine Events

End Class
