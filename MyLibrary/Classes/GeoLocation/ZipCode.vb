Imports System.Text
Imports Newtonsoft.Json.Linq
''' <summary>
''' ZipCode class
''' <para>Created by Antonino Razeti on February 08, 2021</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of ZipCode object</para>
''' <para>Implements IZipCode</para>
''' </summary>
Public Class ZipCode
    Inherits Database

#Region "Private Declarations"

    Private mCode As String

#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"

    ''' <summary>
    ''' Gets or sets the code
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Code() As String
        Get
            Return mCode
        End Get
        Set(ByVal value As String)
            mCode = value
            RaiseEvent CodeChanged(Me, value)
        End Set
    End Property

#End Region ' End Properties

#Region "Constructors"

    ''' <summary>
    ''' Creates a new empty instance of ZipCode class
    ''' </summary>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' Creates a new instance of Zip Code class given a json object that contains database object properties information
    ''' </summary>
    ''' <param name="json">JObject</param>
    ''' <see cref="JObject"/>
    Public Sub New(json As JObject)
        MyBase.New(json)
    End Sub

    ''' <summary>
    ''' Creates a new instance of Zip Code class given the id number associated with the object 
    ''' into database, the id number associated with the parent of current object into database
    ''' </summary>
    ''' <param name="id">Integer</param>
    ''' <param name="idParent">Integer</param>
    Public Sub New(id As Integer, idParent As Integer, code As String)
        MyBase.New(id, idParent)
        Me.Code = code
    End Sub

#End Region ' End Constructors

#Region "Functions"

    ''' <summary>
    ''' Returns a json object that reprensents current zip code
    ''' </summary>
    ''' <returns>JObject</returns>
    Public Overrides Function ToJson() As JObject
        Dim json As JObject = MyBase.ToJson()
        json.Add("zip_code", Code)
        Return json
    End Function

    ''' <summary>
    ''' Returns a string that represents current zip code
    ''' </summary>
    ''' <returns>String</returns>
    Public Overrides Function ToString() As String
        Return Code
    End Function

    ''' <summary>
    ''' Returns a string that represents the arguments of current zip code to qquery server database
    ''' </summary>
    ''' <returns>String</returns>
    Public Overrides Function ToPost() As String
        Return New StringBuilder().Append(MyBase.ToPost).
            Append("&").
            Append(String.Format("zip_code={0}", Code)).ToString
    End Function

#End Region ' Fine Regione Functions

#Region "Subs"

    ''' <summary>
    ''' Initialize current Zip Code
    ''' </summary>
    Protected Friend Overrides Sub Initialize()
        MyBase.Initialize()
        Code = ""
    End Sub

    ''' <summary>
    ''' Sets current Zip code properties given specified json object
    ''' </summary>
    ''' <param name="json">JObject</param>
    ''' <see cref="JObject"/>
    Public Overrides Sub FromJson(json As JObject)
        MyBase.FromJson(json)
        If Not IsNothing(json) Then
            Code = If(json.SelectToken("zip_code"), json.SelectToken("zip_code"), "")
        End If
    End Sub

#End Region ' Fine Regions Subs

#Region "Events"

    Public Event CodeChanged(ByVal sender As Object, ByVal code As String)

#End Region ' Fine Events

End Class
