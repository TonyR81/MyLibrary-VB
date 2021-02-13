Imports Newtonsoft.Json.Linq
''' <summary>
''' ProvincesCollection class
''' <para>Created by Antonino Razeti on February 08, 2021</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of ProvincesCollection object</para>
''' <para>Implements IProvincesCollection</para>
''' </summary>
Public Class ProvincesCollection
    Inherits CollectionBase

#Region "Private Declarations"


#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"

    ''' <summary>
    ''' Returns an array of names of current provinces collection
    ''' </summary>
    ''' <returns>String()</returns>
    Public ReadOnly Property GetNames() As String()
        Get
            Return (From province As Province In ToList()
                    Order By province.Name Ascending
                    Select province.Name).ToArray
        End Get
    End Property

#End Region ' End Properties

#Region "Constructors"

    ''' <summary>
    ''' Creates a new empty instace of Provinces Collection class
    ''' </summary>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' Creates a new instance of Provinces collection class given a json object that contains 
    ''' items in json object format
    ''' </summary>
    ''' <param name="array">JArray</param>
    ''' <see cref="JArray"/>
    Public Sub New(array As JArray)
        MyBase.New(array)
    End Sub

#End Region ' End Constructors

#Region "Functions"

    ''' <summary>
    ''' Returns an array of json objects that represents current collection
    ''' </summary>
    ''' <returns>JArray</returns>
    Public Overrides Function ToJson() As JArray
        Dim array As JArray = New JArray
        For Each province As Province In Items.ToList
            array.Add(province.ToJson)
        Next
        Return array
    End Function

#End Region ' Fine Regione Functions

#Region "Subs"

    ''' <summary>
    ''' Add specified array of items given in json object format
    ''' </summary>
    ''' <param name="array">JArray</param>
    Public Overrides Sub AddRange(array As JArray)
        For index As Integer = 0 To array.Count - 1
            Items.Add(New Province(array(index).SelectToken("province")))
        Next
    End Sub

    ''' <summary>
    ''' Get the list of municipalities of province at the specified index into current collection
    ''' </summary>
    ''' <param name="index">Integer</param>
    ''' <returns>MunicipalitiesCollection</returns>
    Public ReadOnly Property GetMunicipalities(index As Integer) As CitiesCollection
        Get
            Return CType(Items(index), Province).Cities
        End Get
    End Property

#End Region ' Fine Regions Subs

#Region "Events"


#End Region ' Fine Events

End Class
