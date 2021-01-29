Imports Newtonsoft.Json.Linq
''' <summary>
''' CollectionBase class
''' <para>Created by Antonino Razeti on January 29, 2021</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of CollectionBase object</para>
''' <para>Implements ICollectionBase</para>
''' </summary>
Public MustInherit Class CollectionBase
    Implements ICollectionBase

#Region "Private Declarations"

    Protected Friend Items As List(Of Database)

#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"

    ''' <summary>
    ''' Returns the list of items of current collection
    ''' </summary>
    ''' <returns>List(Of Database)</returns>
    Public ReadOnly Property GetItems() As List(Of Database) Implements ICollectionBase.GetItems
        Get
            Return Items
        End Get
    End Property

    ''' <summary>
    ''' Returns the first element of current collection with specified id number associated with the element into database
    ''' </summary>
    ''' <param name="id">Intege</param>
    ''' <returns>Database</returns>
    Public ReadOnly Property GetItemById(id As Integer) As Database Implements ICollectionBase.GetItemById
        Get
            Return Items.FirstOrDefault(Function(x) x.Id = id)
        End Get
    End Property

#End Region ' End Properties

#Region "Constructors"

    ''' <summary>
    ''' Creates a new empty instance of CollectionBase class
    ''' </summary>
    Public Sub New()
        Initialize()
    End Sub

    ''' <summary>
    ''' Creates a new instance of CollectionBase class given a json object that contains 
    ''' items in json object format
    ''' </summary>
    ''' <param name="array">JArray</param>
    ''' <see cref="JArray"/>
    Public Sub New(array As JArray)
        AddRange(array)
    End Sub

#End Region ' End Constructors

#Region "Functions"


#End Region ' Fine Regione Functions

#Region "Subs"

    ''' <summary>
    ''' Initialize current collectionBase
    ''' </summary>
    Private Sub Initialize()
        Items = New List(Of Database)
    End Sub

    ''' <summary>
    ''' Add specified range of items given in json object format
    ''' </summary>
    ''' <param name="json">JObject</param>
    Public MustOverride Sub AddRange(array As JArray) Implements ICollectionBase.AddRange

#End Region ' Fine Regions Subs

#Region "Events"


#End Region ' Fine Events


End Class
