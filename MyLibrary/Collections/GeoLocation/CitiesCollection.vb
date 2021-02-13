Imports Newtonsoft.Json.Linq
''' <summary>
''' Municipalities Collection class
''' <para>Created by Antonino Razeti on February 08, 2021</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of Municipalities Collection object</para>
''' <para>Implements IMunicipalities Collection</para>
''' </summary>
Public Class CitiesCollection
    Inherits CollectionBase

#Region "Private Declarations"


#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"


#End Region ' End Properties

#Region "Constructors"

    ''' <summary>
    ''' Creates a new empty instance of Municipalities Collection class
    ''' </summary>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' Creates a new instance of Municipalities Collection class given a json object that contains 
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
    ''' Add specified array of items given in json object format
    ''' </summary>
    ''' <param name="array">JArray</param>
    Public Overrides Sub AddRange(array As JArray)
        For index As Integer = 0 To array.Count - 1
            Items.Add(New City(array(index).SelectToken("city")))
        Next
    End Sub

    ''' <summary>
    ''' Returns current collection as an array of municipalities in json object format
    ''' </summary>
    ''' <returns>JArray</returns>
    Public Overrides Function ToJson() As JArray
        Return Nothing
    End Function

    Public ReadOnly Property GetNames() As String()
        Get
            Return (From municipality As City In ToList() Order By municipality.Name Ascending Select municipality.Name).ToArray
        End Get
    End Property

#End Region ' Fine Regions Subs

#Region "Events"


#End Region ' Fine Events


End Class
