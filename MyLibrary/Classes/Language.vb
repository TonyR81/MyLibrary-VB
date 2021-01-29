Imports System.Windows.Forms
''' <summary>
''' Language class
''' <para>Created by Antonino Razeti on 17th May, 2020</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of Language object</para>
''' <para>Implements ILanguage</para>
''' </summary>
Public Class Language
    Implements ILanguage

#Region "Private Declarations"

    Private WithEvents MDocument As XDocument

#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"

    ''' <summary>
    ''' Gets or sets Document
    ''' </summary>
    ''' <returns>XDocument</returns>
    Private Property Document() As XDocument Implements ILanguage.Document
        Get
            Return MDocument
        End Get
        Set(ByVal value As XDocument)
            MDocument = value
        End Set
    End Property

    ''' <summary>
    ''' Returns the value for the specified key
    ''' </summary>
    ''' <param name="key">String</param>
    ''' <returns>String</returns>
    Public ReadOnly Property Item(key As String) As String Implements ILanguage.Item
        Get
            Return Document.Element("strings").Element(key)
        End Get
    End Property

    ''' <summary>
    ''' Returns the XElement for the specified key
    ''' </summary>
    ''' <param name="key">XName</param>
    ''' <returns>XElement</returns>
    Public ReadOnly Property Element(key As XName) As XElement Implements ILanguage.Element
        Get
            Return Document.Element("strings").Element(key)
        End Get
    End Property

    ''' <summary>
    ''' Returns the string of root specifiyng root element and child element
    ''' </summary>
    ''' <param name="rootElement">String</param>
    ''' <param name="childElement">String</param>
    ''' <returns>String</returns>
    Public Function GetString(rootElement As String, childElement As String) As String Implements ILanguage.GetString
        Return Element(rootElement).Element(childElement)
    End Function

    ''' <summary>
    ''' Returns array of string for the specified key
    ''' </summary>
    ''' <param name="key">XName</param>
    ''' <returns>String()</returns>
    Public ReadOnly Property Elements(key As XName) As String() Implements ILanguage.Elements
        Get
            Return (From tag In Document.Element("strings").Element(key).Elements
                    Select tag.Value).ToArray
        End Get
    End Property

#End Region ' End Properties

#Region "Constructors"

    ''' <summary>
    ''' Create a new empty instance of Language Class
    ''' </summary>
    Public Sub New()
        Dim languageFile As String = ""
        If Not String.IsNullOrEmpty(My.Settings.Language) Then
            languageFile = String.Format("{0}.xml", My.Settings.Language)
        Else
            Dim files As String() = IO.Directory.GetFiles(IO.Path.Combine(Application.StartupPath, "Files", "Languages"))
            If files.Count > 0 Then
                languageFile = IO.Path.GetFileName(files(0))
            End If
        End If
        Document = XDocument.Load(IO.Path.Combine(Application.StartupPath, "Files", "Languages", languageFile))
    End Sub

    ''' <summary>
    ''' Create a new instance of Language Class given language path file that contains strings to translate
    ''' </summary>
    ''' <param name="language">String</param>
    Public Sub New(language As String)
        Document = XDocument.Load(IO.Path.Combine(Application.StartupPath, "Files", "Languages", String.Format("{0}.xml", language)))
    End Sub

#End Region ' End Constructors

#Region "Functions"


#End Region ' Fine Regione Functions

#Region "Subs"


#End Region ' Fine Regions Subs

#Region "Events"


#End Region ' Fine Events


End Class
