Imports System.Runtime.Serialization
''' <summary>
''' ExceptionBase class
''' <para>Created by Antonino Razeti on January 26, 2021</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of ExceptionBase object</para>
''' <para>Implements IExceptionBase</para>
''' </summary>
<Serializable>
Public MustInherit Class ExceptionBase
    Inherits Exception

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
            Return mLanguage
        End Get
        Set(ByVal value As Language)
            mLanguage = value
        End Set
    End Property

    ''' <summary>
    ''' Returns the message of current exception given the resource s
    ''' </summary>
    ''' <param name="resource"></param>
    ''' <returns></returns>
    Public ReadOnly Property GetMessage(resource As String) As String
        Get
            Return Language.GetString("exceptions", resource)
        End Get
    End Property

    ''' <summary>
    ''' Gets the message of current exception
    ''' </summary>
    ''' <returns>String</returns>
    Public MustOverride ReadOnly Property GetMessage() As String

#End Region ' End Getters and Setters

#Region "Constructors"

    ''' <summary>
    ''' Creates a new empty instance of ExceptionBase class
    ''' </summary>
    Public Sub New()
        Language = New Language(My.Settings.Language)
    End Sub

#End Region ' End Constructors

End Class
