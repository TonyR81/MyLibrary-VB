Imports Newtonsoft.Json.Linq
''' <summary>
''' Province class
''' <para>Created by Antonino Razeti on February 08, 2021</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of Province object</para>
''' <para>Implements IProvince</para>
''' </summary>
Public Class Province
    Inherits LocationBase

#Region "Private Declarations"

    Private mAcronym As String
    Private WithEvents MMunicipalities As MunicipalitiesCollection

#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"

    ''' <summary>
    ''' Gets or sets Acronym
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Acronym() As String
        Get
            Return mAcronym
        End Get
        Set(ByVal value As String)
            mAcronym = value
            RaiseEvent AcronymChanged(Me, value)
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets Municipalities
    ''' </summary>
    ''' <returns>MunicipalitiesCollection</returns>
    Public Property Municipalities() As MunicipalitiesCollection
        Get
            Return mMunicipalities
        End Get
        Set(ByVal value As MunicipalitiesCollection)
            mMunicipalities = value
        End Set
    End Property

#End Region ' End Properties

#Region "Constructors"

    ''' <summary>
    ''' Creates a new empty instance of Province class
    ''' </summary>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' Creates a new instance of Province object class given a json object that contains database object properties information
    ''' </summary>
    ''' <param name="json">JObject</param>
    ''' <see cref="JObject"/>
    Public Sub New(json As JObject)
        MyBase.New(json)
    End Sub

    ''' <summary>
    ''' Creates a new instance of Province object class given the id number associated with the object 
    ''' into database, the id number associated with the parent of current object into database and the name
    ''' </summary>
    ''' <param name="id">Integer</param>
    ''' <param name="idParent">Integer</param>
    ''' <param name="name">String</param>
    Public Sub New(id As Integer, idParent As Integer, name As String, municipalities As MunicipalitiesCollection)
        MyBase.New(id, idParent, name)
        Me.Municipalities = municipalities
    End Sub

#End Region ' End Constructors

#Region "Functions"

    ''' <summary>
    ''' Returns a json object that represents current Province
    ''' </summary>
    ''' <returns>JObject</returns>
    Public Overrides Function ToJson() As JObject
        Dim json As JObject = MyBase.ToJson
        json.Add("acronym", Acronym)
        Return json
    End Function

    ''' <summary>
    ''' Returns a string that represents current province
    ''' </summary>
    ''' <returns>String</returns>
    Public Overrides Function ToString() As String
        Return String.Format("{0} ({1})", Name, Acronym.ToUpper)
    End Function

    ''' <summary>
    ''' Returns a string that represents the arguments of current province to query server database
    ''' </summary>
    ''' <returns>String</returns>
    Public Overrides Function ToPost() As String
        Return MyBase.ToPost().
            Append(String.Format("acronym={0}", Acronym))
    End Function

#End Region ' Fine Regione Functions

#Region "Subs"

    ''' <summary>
    ''' Initialize current province
    ''' </summary>
    Protected Friend Overrides Sub Initialize()
        MyBase.Initialize()
        Acronym = ""
    End Sub

    ''' <summary>
    ''' Sets current province properties given specified json object
    ''' </summary>
    ''' <param name="json">JObject</param>
    ''' <see cref="JObject"/>
    Public Overrides Sub FromJson(json As JObject)
        MyBase.FromJson(json)
        If Not IsNothing(json) Then
            Acronym = If(Not IsNothing(json.SelectToken("acronym")), json.SelectToken("acronym"), "")
        End If
        Municipalities = If(Not IsNothing(json.SelectToken("municipalities")), New MunicipalitiesCollection(json.SelectToken("municipalities")), New MunicipalitiesCollection)
    End Sub

#End Region ' Fine Regions Subs

#Region "Events"

    Public Event AcronymChanged(ByVal sender As Object, ByVal acronym As String)

#End Region ' Fine Events

End Class
