''' <summary>
''' FormBase class
''' <para>Created by Antonino Razeti on February 01, 2021</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of FormBase object</para>
''' <para>Implements IFormBase</para>
''' </summary>
Public Class FormBase

#Region "Private Declarations"

    Private mLanguage As Language

#End Region ' End Private Declarations

#Region "Getters and Setters"

    ''' <summary>
    ''' Gets or sets Language
    ''' </summary>
    ''' <returns>Language</returns>
    Public Property Language() As Language
        Get
            Return If(Not IsNothing(mLanguage), mLanguage, New Language(My.Settings.Language))
        End Get
        Set(ByVal value As Language)
            mLanguage = value
            If Not IsNothing(value) Then
                Translate()
            End If
        End Set
    End Property

#End Region ' End Getters and Setters

#Region "Subs"

    ''' <summary>
    ''' Translate current form
    ''' </summary>
    Protected Overridable Sub Translate()
        If IsNothing(Language) Then
            Language = New Language(My.Settings.Language)
        End If
    End Sub

#End Region ' End Subs

#Region "Events"

    Private Sub FormBase_Load(sender As Object, e As EventArgs) Handles Me.Load
        Language = New Language(My.Settings.Language)
    End Sub

#End Region ' End Events

End Class