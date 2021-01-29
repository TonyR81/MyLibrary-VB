''' <summary>
''' Language interface
''' <para>Created by Antonino Razeti on January 29, 2021</para>
''' <para>Version 1.0</para>
''' <para> Language Interface that contains all the properties, 
''' methods and functions of the Language class</para>
''' </summary>
Public Interface ILanguage

#Region "Getters and Setters"

    ReadOnly Property Item(key As String) As String
    ReadOnly Property Element(key As XName) As XElement
    Property Document As XDocument
    ReadOnly Property Elements(key As XName) As String()

#End Region ' End Getters and Setters

#Region "Functions"

    Function GetString(rootElement As String, childElement As String) As String

#End Region ' End Functions

End Interface
