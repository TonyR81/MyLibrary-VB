Imports Newtonsoft.Json.Linq
''' <summary>
''' PersonsCollection class
''' <para>Created by Antonino Razeti on January 29, 2021</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of PersonsCollection object</para>
''' <para>Implements IPersonsCollection</para>
''' </summary>
Public MustInherit Class PersonsCollection
    Inherits UsersCollection
    Implements IPersonsCollection

#Region "Private Declarations"


#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"


#End Region ' End Properties

#Region "Constructors"

    ''' <summary>
    ''' Creates a new empty instance of Persons collection class
    ''' </summary>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' Creates a new instance of Persons Collection class given a json array that contains 
    ''' items in json object format
    ''' </summary>
    ''' <param name="array">JArray</param>
    ''' <see cref="JArray"/>
    Public Sub New(array As JArray)
        MyBase.New(array)
    End Sub

#End Region ' End Constructors

#Region "Functions"


#End Region ' Fine Regione Functions

#Region "Subs"


#End Region ' Fine Regions Subs

#Region "Events"


#End Region ' Fine Events

End Class
