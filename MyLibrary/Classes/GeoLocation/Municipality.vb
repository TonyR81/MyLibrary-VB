Imports System.Text
Imports Newtonsoft.Json.Linq
''' <summary>
''' Municipality class
''' <para>Created by Antonino Razeti on February 08, 2021</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of Municipality object</para>
''' <para>Implements IMunicipality</para>
''' </summary>
Public Class Municipality
    Inherits LocationBase

#Region "Private Declarations"

    Private WithEvents MZipCodes As ZipCodesCollection

#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"

    ''' <summary>
    ''' Gets or sets ZipCodes
    ''' </summary>
    ''' <returns>ZipCodesCollection</returns>
    Public Property ZipCodes() As ZipCodesCollection
        Get
            Return MZipCodes
        End Get
        Set(ByVal value As ZipCodesCollection)
            MZipCodes = value
            RaiseEvent ZipCodesChanged(Me, value)
        End Set
    End Property

#End Region ' End Properties

#Region "Constructors"

    ''' <summary>
    ''' Creates a new empty instance of Municipality class
    ''' </summary>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' Creates a new instance of Municipalities class given a json object that contains database object properties information
    ''' </summary>
    ''' <param name="json">JObject</param>
    ''' <see cref="JObject"/>
    Public Sub New(json As JObject)
        MyBase.New(json)
    End Sub

    ''' <summary>
    ''' Creates a new instance of Municipality class given the id number associated with the object 
    ''' into database, the id number associated with the parent of current object into database and the name
    ''' </summary>
    ''' <param name="id">Integer</param>
    ''' <param name="idParent">Integer</param>
    ''' <param name="name">String</param>
    Public Sub New(id As Integer, idParent As Integer, name As String, zipCodes As ZipCodesCollection)
        MyBase.New(id, idParent, name)
        Me.ZipCodes = zipCodes
    End Sub

#End Region ' End Constructors

#Region "Functions"

    ''' <summary>
    ''' Return a json object that represents current municipality
    ''' </summary>
    ''' <returns>JObject</returns>
    Public Overrides Function ToJson() As JObject
        Dim json As JObject = MyBase.ToJson()
        If Not IsNothing(ZipCodes) Then
            json.Add("zip_codes", ZipCodes.ToJson)
        End If
        Return json
    End Function

    ''' <summary>
    ''' Returns a string that represents current municipality to query server database
    ''' </summary>
    ''' <returns>String</returns>
    Public Overrides Function ToPost() As String
        Return MyBase.ToPost
    End Function

#End Region ' Fine Regione Functions

#Region "Subs"

    ''' <summary>
    ''' Sets current Municipality properties given specified json object
    ''' </summary>
    ''' <param name="json">JObject</param>
    ''' <see cref="JObject"/>
    Public Overrides Sub FromJson(json As JObject)
        MyBase.FromJson(json)
        Name = If(Not IsNothing(json.SelectToken("name")), json.SelectToken("name"), "")
        ZipCodes = New ZipCodesCollection
    End Sub

#End Region ' Fine Regions Subs

#Region "Events"

    Public Event ZipCodesChanged(ByVal sender As Object, ByVal zipCodes As ZipCodesCollection)

#End Region ' Fine Events

End Class
