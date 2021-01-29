Imports Newtonsoft.Json.Linq
''' <summary>
''' Users Collection class
''' <para>Created by Antonino Razeti on January 29, 2021</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of Users Collection object</para>
''' <para>Implements IUsers Collection</para>
''' </summary>
Public MustInherit Class UsersCollection
    Inherits CollectionBase
    Implements IUsersCollection

#Region "Private Declarations"


#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"


#End Region ' End Properties

#Region "Constructors"

    ''' <summary>
    ''' Creates a new empty instance of UsersCollection class
    ''' </summary>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' Creates a new instance of Users Collection class given a json array that contains 
    ''' items in json object format
    ''' </summary>
    ''' <param name="array">JArray</param>
    ''' <see cref="JObject"/>
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
