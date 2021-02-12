Imports Newtonsoft.Json.Linq
''' <summary>
''' Region class
''' <para>Created by Antonino Razeti on February 08, 2021</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of Region object</para>
''' <para>Implements IRegion</para>
''' </summary>
Public Class Region
    Inherits LocationBase

#Region "Private Declarations"

    Private WithEvents MProvinces As ProvincesCollection

#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"

    ''' <summary>
    ''' Gets or sets Provinces
    ''' </summary>
    ''' <returns>ProvincesCollection</returns>
    Public Property Provinces() As ProvincesCollection
        Get
            Return mProvinces
        End Get
        Set(ByVal value As ProvincesCollection)
            mProvinces = value
        End Set
    End Property

    Public ReadOnly Property GetNames() As String()
        Get
            Return (From province As Province In Provinces.Items Order By province.Name Ascending Select province.Name).ToArray
        End Get
    End Property

#End Region ' End Properties

#Region "Constructors"

    ''' <summary>
    ''' Creates a new empty instance of Region class
    ''' </summary>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' Creates a new instance of Region class given a json object that contains database object properties information
    ''' </summary>
    ''' <param name="json">JObject</param>
    ''' <see cref="JObject"/>
    Public Sub New(json As JObject)
        MyBase.New(json)
    End Sub

    ''' <summary>
    ''' Creates a new instance of Region class given the id number associated with the object 
    ''' into database, the id number associated with the parent of current object into database and the name
    ''' </summary>
    ''' <param name="id">Integer</param>
    ''' <param name="idParent">Integer</param>
    ''' <param name="name">String</param>
    ''' <param name="provinces">ProvincesCollection</param>
    ''' <see cref="ProvincesCollection"/>
    Public Sub New(id As Integer, idParent As Integer, name As String, provinces As ProvincesCollection)
        MyBase.New(id, idParent, name)
        Me.Provinces = provinces
    End Sub

#End Region ' End Constructors

#Region "Functions"

    ''' <summary>
    ''' Return a json object that represents current region
    ''' </summary>
    ''' <returns>JObject</returns>
    Public Overrides Function ToJson() As JObject
        Dim json As JObject = MyBase.ToJson()
        If Not IsNothing(Provinces) Then
            json.Add("provinces", Provinces.ToJson)
        End If
        Return json
    End Function

    ''' <summary>
    ''' Returns a string that represents the arguments to query server database
    ''' </summary>
    ''' <returns>String</returns>
    Public Overrides Function ToPost() As String
        Return MyBase.ToPost()
    End Function

#End Region ' Fine Regione Functions

#Region "Subs"

    ''' <summary>
    ''' Initilize current Region
    ''' </summary>
    Protected Friend Overrides Sub Initialize()
        MyBase.Initialize()
        Provinces = New ProvincesCollection
    End Sub

    ''' <summary>
    ''' Sets current Region properties given specified json object
    ''' </summary>
    ''' <param name="json">JObject</param>
    ''' <see cref="JObject"/>
    Public Overrides Sub FromJson(json As JObject)
        MyBase.FromJson(json)
        If Not IsNothing(json) Then
            Provinces = If(Not IsNothing(json.SelectToken("provinces")), New ProvincesCollection(json.SelectToken("provinces")), New ProvincesCollection)
        End If
    End Sub

#End Region ' Fine Regions Subs

#Region "Events"


#End Region ' Fine Events


End Class
