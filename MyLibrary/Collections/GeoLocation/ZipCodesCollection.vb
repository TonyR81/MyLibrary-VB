Imports Newtonsoft.Json.Linq
''' <summary>
''' ZipCodes Collection class
''' <para>Created by Antonino Razeti on February 08, 2021</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of ZipCodes Collection object</para>
''' <para>Implements IZipCodes Collection</para>
''' </summary>
Public Class ZipCodesCollection
    Inherits CollectionBase

#Region "Private Declarations"


#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"


#End Region ' End Properties

#Region "Constructors"

    ''' <summary>
    ''' Creates a new empty instance of ZipCodes Collection class
    ''' </summary>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' Creates a new instance of ZipCodes Collection class given a json object that contains 
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
        For Each zipCode As ZipCode In Items.ToList
            array.Add(zipCode.ToJson())
        Next
        Return array
    End Function

#End Region ' Fine Regione Functions

#Region "Subs"

    ''' <summary>
    ''' Add specified array of zip codes given in json object format
    ''' </summary>
    ''' <param name="array">JArray</param>
    Public Overrides Sub AddRange(array As JArray)
        For index As Integer = 0 To array.Count - 1
            Items.Add(New ZipCode(array(index).SelectToken("zip_code")))
        Next
    End Sub

#End Region ' Fine Regions Subs

#Region "Events"


#End Region ' Fine Events

End Class
