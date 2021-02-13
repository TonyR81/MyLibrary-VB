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
    Private WithEvents MCities As CitiesCollection

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
    ''' <returns>CitiesCollection</returns>
    Public Property Cities() As CitiesCollection
        Get
            Return MCities
        End Get
        Set(ByVal value As CitiesCollection)
            MCities = value
            RaiseEvent CitiesChanged(Me, value)
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
    ''' Creates a new instance of Province object class given a json object that contains province properties information
    ''' </summary>
    ''' <param name="json">JObject</param>
    ''' <see cref="JObject"/>
    Public Sub New(json As JObject)
        MyBase.New(json)
    End Sub

    ''' <summary>
    ''' Creates a new instance of Province class given the id number associated with the object 
    ''' into database, the id number associated with the parent of current province into database, the name and the cities collection
    ''' </summary>
    ''' <param name="id">Integer</param>
    ''' <param name="idParent">Integer</param>
    ''' <param name="name">String</param>
    ''' <param name="cities">CitiesCollection</param>
    Public Sub New(id As Integer, idParent As Integer, name As String, cities As CitiesCollection)
        MyBase.New(id, idParent, name)
        Me.Cities = cities
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
        Cities = New CitiesCollection
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
        Cities = If(Not IsNothing(json.SelectToken("cities")), New CitiesCollection(json.SelectToken("cities")), New CitiesCollection)
    End Sub

#End Region ' Fine Regions Subs

#Region "Events"

    Public Event AcronymChanged(ByVal sender As Object, ByVal acronym As String)
    Public Event CitiesChanged(ByVal sender As Object, ByVal cities As CitiesCollection)

#End Region ' Fine Events

End Class
