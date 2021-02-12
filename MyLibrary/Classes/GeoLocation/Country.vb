Imports Newtonsoft.Json.Linq
''' <summary>
''' Country class
''' <para>Created by Antonino Razeti on February 08, 2021</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of Country object</para>
''' <para>Implements ICountry</para>
''' </summary>
Public Class Country
    Inherits LocationBase

#Region "Private Declarations"

    Private WithEvents MRegions As RegionsCollection

#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"

    ''' <summary>
    ''' Gets or sets the regions of current country
    ''' </summary>
    ''' <returns>RegionsCollection</returns>
    Public Property Regions() As RegionsCollection
        Get
            Return mRegions
        End Get
        Set(ByVal value As RegionsCollection)
            MRegions = value
            RaiseEvent RegionsChanged(Me, value)
        End Set
    End Property

#End Region ' End Properties

#Region "Constructors"

    ''' <summary>
    ''' Creates a new empty instance of Country class
    ''' </summary>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' Creates a new instance of Country class given a json object that contains country properties information in json object format
    ''' </summary>
    ''' <param name="json">JObject</param>
    Public Sub New(json As JObject)
        MyBase.New(json)
    End Sub

    ''' <summary>
    ''' Creates a new instance of Location object class given the id number associated with the object 
    ''' into database, the id number associated with the parent of current object into database, the name and the regions
    ''' </summary>
    ''' <param name="id">Integer</param>
    ''' <param name="idParent">Integer</param>
    ''' <param name="name">String</param>
    ''' <param name="regions">RegionsCollection</param>
    Public Sub New(id As Integer, idParent As Integer, name As String, regions As RegionsCollection)
        MyBase.New(id, idParent, name)
        Me.Regions = regions
    End Sub

#End Region ' End Constructors

#Region "Functions"

    ''' <summary>
    ''' Returns a json object that represents current country
    ''' </summary>
    ''' <returns>JObject</returns>
    Public Overrides Function ToJson() As JObject
        Dim json As JObject = MyBase.ToJson()
        If Not IsNothing(Regions) Then
            json.Add("regions", Regions.ToJson)
        End If
        Return json
    End Function

#End Region ' Fine Regione Functions

#Region "Subs"

    ''' <summary>
    ''' Initialize current country
    ''' </summary>
    Protected Friend Overrides Sub Initialize()
        MyBase.Initialize()
        Regions = New RegionsCollection
    End Sub

    ''' <summary>
    ''' Sets current Country properties given specified json object
    ''' </summary>
    ''' <param name="json">JObject</param>
    ''' <see cref="JObject"/>
    Public Overrides Sub FromJson(json As JObject)
        MyBase.FromJson(json)
        If Not IsNothing(json) Then
            Regions = If(Not IsNothing(json.SelectToken("regions")), New RegionsCollection(json.SelectToken("regions")), New RegionsCollection)
        End If
    End Sub

#End Region ' Fine Regions Subs

#Region "Events"

    Public Event RegionsChanged(ByVal sender As Object, ByVal regions As RegionsCollection)

#End Region ' Fine Events

End Class
