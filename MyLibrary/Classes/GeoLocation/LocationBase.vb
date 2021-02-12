Imports Newtonsoft.Json.Linq
''' <summary>
''' LocationBase class
''' <para>Created by Antonino Razeti on February 08, 2021</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of LocationBase object</para>
''' <para>Implements ILocationBase</para>
''' </summary>
Public MustInherit Class LocationBase
    Inherits Database

#Region "Private Declarations"

    Private mName As String

#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"

    ''' <summary>
    ''' Gets or sets the name of current collection
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Name() As String
        Get
            Return mName.ToUpper
        End Get
        Set(ByVal value As String)
            mName = value.ToUpper
            RaiseEvent NameChanged(Me, value)
        End Set
    End Property

#End Region ' End Properties

#Region "Constructors"

    ''' <summary>
    ''' Creates a new empty instance of location class
    ''' </summary>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' Creates a new instance of Location object class given a json object that contains database object properties information
    ''' </summary>
    ''' <param name="json">JObject</param>
    ''' <see cref="JObject"/>
    Public Sub New(json As JObject)
        MyBase.New(json)
    End Sub

    ''' <summary>
    ''' Creates a new instance of Location object class given the id number associated with the object 
    ''' into database, the id number associated with the parent of current object into database and the name
    ''' </summary>
    ''' <param name="id">Integer</param>
    ''' <param name="idParent">Integer</param>
    ''' <param name="name">String</param>
    Public Sub New(id As Integer, idParent As Integer, name As String)
        MyBase.New(id, idParent)
        Me.Name = name
    End Sub

#End Region ' End Constructors

#Region "Functions"

    ''' <summary>
    ''' Returns a string that represents current location
    ''' </summary>
    ''' <returns>String</returns>
    Public Overrides Function ToString() As String
        Return Name
    End Function

    ''' <summary>
    ''' Return a json object that represents current location
    ''' </summary>
    ''' <returns></returns>
    Public Overrides Function ToJson() As JObject
        Dim json As JObject = MyBase.ToJson
        json.Add("name", Name)
        Return json
    End Function

    ''' <summary>
    ''' Returns a string that represents the arguments to query server database
    ''' </summary>
    ''' <returns>String</returns>
    Public Overrides Function ToPost() As String
        Return MyBase.ToPost().
            Append("&").
            Append(String.Format("name={0}&", Name)).ToString
    End Function

#End Region ' Fine Regione Functions

#Region "Subs"

    ''' <summary>
    ''' Initialize current location object
    ''' </summary>
    Protected Friend Overrides Sub Initialize()
        MyBase.Initialize()
        Name = ""
    End Sub

    ''' <summary>
    ''' Sets current Location properties given specified json object
    ''' </summary>
    ''' <param name="json">JObject</param>
    ''' <see cref="JObject"/>
    Public Overrides Sub FromJson(json As JObject)
        MyBase.FromJson(json)
        If Not IsNothing(json) Then
            Name = If(Not IsNothing(json.SelectToken("name")), json.SelectToken("name"), "")
        End If
    End Sub

#End Region ' Fine Regions Subs

#Region "Events"

    Public Event NameChanged(ByVal sender As Object, ByVal name As String)

#End Region ' Fine Events

End Class
