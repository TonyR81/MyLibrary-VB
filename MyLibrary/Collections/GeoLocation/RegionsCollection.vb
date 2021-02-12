Imports Newtonsoft.Json.Linq
''' <summary>
''' Regions Collection class
''' <para>Created by Antonino Razeti on February 08, 2021</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of Regions Collection object</para>
''' <para>Implements IRegions Collection</para>
''' </summary>
Public Class RegionsCollection
    Inherits CollectionBase

#Region "Private Declarations"


#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"

    Public ReadOnly Property GetNames() As String()
        Get
            Return (From region As Region In ToList()
                    Order By region.Name Ascending
                    Select region.Name).ToArray
        End Get
    End Property

#End Region ' End Properties

#Region "Constructors"

    ''' <summary>
    ''' Creates a new empty instance of RegionsCollection class
    ''' </summary>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' Creates a new instance of Regions collection class given a json object that contains 
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

    ''' <summary>
    ''' Add specified array of items to the current collection given in json object
    ''' </summary>
    ''' <param name="array">JArray</param>
    Public Overrides Sub AddRange(array As JArray)
        For index As Integer = 0 To array.Count - 1
            Items.Add(New Region(array(index).SelectToken("region")))
        Next
    End Sub

    ''' <summary>
    ''' Returns an array of json objects of current collection
    ''' </summary>
    ''' <returns>JArray</returns>
    Public Overrides Function ToJson() As JArray
        Throw New NotImplementedException()
    End Function

    Public ReadOnly Property GetProvinces(index As Integer) As ProvincesCollection
        Get
            Return CType(Items(index), Region).Provinces
        End Get
    End Property

#End Region ' Fine Regions Subs

#Region "Events"


#End Region ' Fine Events


End Class
