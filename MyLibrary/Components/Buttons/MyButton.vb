Imports System.ComponentModel
Imports System.Drawing
''' <summary>
''' RoundedButton class
''' <para>Created by Antonino Razeti on January 31, 2021</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of RoundedButton object</para>
''' <para>Implements IRoundedButton</para>
''' </summary>
Public Class MyButton

#Region "Private Declarations"

    Private mRounded As Boolean

#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"

    ''' <summary>
    ''' Gets or sets Rounded
    ''' </summary>
    ''' <returns>Boolean</returns>
    <DefaultValue(False), Category("Properties")>
    Public Property IsRounded() As Boolean
        Get
            Return mRounded
        End Get
        Set(ByVal value As Boolean)
            mRounded = value
            If value Then
                Region = BorderRadius(Size)
            End If
        End Set
    End Property

#End Region ' End Properties

#Region "Constructors"

    ''' <summary>
    ''' Creates a new instance of MyButton class
    ''' </summary>
    Public Sub New()
        InitializeComponent()
        If IsRounded Then
            Region = BorderRadius(Size)
        End If
    End Sub

#End Region ' End Constructors

#Region "Functions"


#End Region ' Fine Regione Functions

#Region "Subs"


#End Region ' Fine Regions Subs

#Region "Events"

    Private Sub RoundedButton_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Region = BorderRadius(Size)
    End Sub

#End Region ' Fine Events


End Class
