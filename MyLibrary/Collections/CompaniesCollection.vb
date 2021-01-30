Imports Newtonsoft.Json.Linq
''' <summary>
''' Companies Collection class
''' <para>Created by Antonino Razeti on January 30, 2021</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of Companies Collection object</para>
''' <para>Implements ICompanies Collection</para>
''' </summary>
Public Class CompaniesCollection
    Inherits UsersCollection
    Implements ICompaniesCollection

#Region "Private Declarations"


#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"


#End Region ' End Properties

#Region "Constructors"


#End Region ' End Constructors

#Region "Functions"


#End Region ' Fine Regione Functions

#Region "Subs"

    ''' <summary>
    ''' Add a range of companies to the current collection given an array of items in json object format
    ''' </summary>
    ''' <param name="array">JArray</param>
    ''' <see cref="JArray"/>
    Public Overrides Sub AddRange(array As JArray)
        For index As Integer = 0 To array.Count - 1
            Items.Add(New Company(array(index - 1).SelectToken("company")))
        Next
    End Sub

#End Region ' Fine Regions Subs

#Region "Events"


#End Region ' Fine Events


End Class
