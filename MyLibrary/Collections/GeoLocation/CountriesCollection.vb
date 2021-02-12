Imports Newtonsoft.Json.Linq

Public Class CountriesCollection
    Inherits CollectionBase

#Region "Private Declarations"


#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"

    ''' <summary>
    ''' Returns an array of names of current countries collection 
    ''' </summary>
    ''' <returns>String()</returns>
    Public ReadOnly Property GetNames() As String()
        Get
            Return (From country As Country In Items.ToList
                    Select country.Name).ToArray
        End Get
    End Property

#End Region ' End Properties

#Region "Constructors"

    ''' <summary>
    ''' Create a new empty instance of countries collection class
    ''' </summary>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' Creates a new instance of Countries Collection class given a json object that contains 
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
    ''' Returns a json array object that represents current collection
    ''' </summary>
    ''' <returns>J</returns>
    Public Overrides Function ToJson() As JArray
        Dim array As JArray = New JArray()
        For Each country As Country In Items.ToList
            array.Add(country.ToJson)
        Next
        Return array
    End Function

#End Region ' Fine Regione Functions

#Region "Subs"

    ''' <summary>
    ''' Add specified array of countries given in json object format
    ''' </summary>
    ''' <param name="array">JArray</param>
    Public Overrides Sub AddRange(array As JArray)
        For index As Integer = 0 To array.Count - 1
            Items.Add(New Country(array(index).SelectToken("country")))
        Next
    End Sub

    ''' <summary>
    ''' Returns the region collection of the country at the specified index into current collection
    ''' </summary>
    ''' <param name="index">Integer</param>
    ''' <returns>Region()</returns>
    Public ReadOnly Property GetRegions(index As Integer) As RegionsCollection
        Get
            Return CType(Items(index), Country).Regions
        End Get
    End Property

#End Region ' Fine Regions Subs

#Region "Events"


#End Region ' Fine Events

End Class
