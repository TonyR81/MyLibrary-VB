Imports System.Text
Imports MyLibrary
Imports Newtonsoft.Json.Linq
''' <summary>
''' Database class
''' <para>Created by Antonino Razeti on January 27, 2021</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of Database object</para>
''' <para>Implements IDatabase</para>
''' </summary>
Public MustInherit Class Database
    Implements IDatabase

#Region "Private Declarations"

    Private mId As Integer
    Private mIdParent As Integer
    Private mResponse As JObject

#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"

    ''' <summary>
    ''' Gets or sets Integer
    ''' </summary>
    ''' <returns>Integer</returns>
    Public Property Id() As Integer Implements IDatabase.Id
        Get
            Return mId
        End Get
        Set(ByVal value As Integer)
            mId = value
            RaiseEvent IdChanged(Me, value)
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets IdParent
    ''' </summary>
    ''' <returns>Integer</returns>
    Public Property IdParent() As Integer Implements IDatabase.IdParent
        Get
            Return mIdParent
        End Get
        Set(ByVal value As Integer)
            mIdParent = value
            RaiseEvent IdParentChanged(Me, value)
        End Set
    End Property

#End Region ' End Properties

#Region "Constructors"

    ''' <summary>
    ''' Creates a new empty instance of Database object class
    ''' </summary>
    Public Sub New()
        Initialize()
    End Sub

    ''' <summary>
    ''' Creates a new instance of Database object class given a json object that contains database object properties information
    ''' </summary>
    ''' <param name="json">JObject</param>
    ''' <see cref="JObject"/>
    Public Sub New(json As JObject)
        FromJson(json)
    End Sub

    ''' <summary>
    ''' Creates a new instance of Database object class given a json object that contains database object properties information
    ''' </summary>
    ''' <param name="id">Integer</param>
    ''' <param name="idParent">Integer</param>
    Public Sub New(id As Integer, idParent As Integer)
        Me.Id = id
        Me.IdParent = idParent
    End Sub

#End Region ' End Constructors

#Region "Functions"

    ''' <summary>
    ''' Returns a string that represents the arguments of current database object
    ''' </summary>
    ''' <returns>String</returns>
    Public Function ToPost() As String Implements IServerRequestHelper.ToPost
        Return New StringBuilder().
            Append(String.Format("id={0}&", Id)).
            Append("id_parent={0}", IdParent).ToString
    End Function

    ''' <summary>
    ''' Returns a string that represents current database object
    ''' </summary>
    ''' <returns>JObject</returns>
    ''' <see cref="JObject"/>
    Public Function ToJson() As JObject Implements IServerRequestHelper.ToJson
        Return New JObject() From {
            {"id", Id},
            {"id_parent", IdParent}}
    End Function

#End Region ' Fine Regione Functions

#Region "Subs"

    ''' <summary>
    ''' Initialize current database object
    ''' </summary>
    Private Sub Initialize()
        Id = 0
        IdParent = 0
    End Sub

    ''' <summary>
    ''' Sets current database properties given specified json object
    ''' </summary>
    ''' <param name="json">JObject</param>
    ''' <see cref="JObject"/>
    Public Sub FromJson(json As JObject) Implements IServerRequestHelper.FromJson
        If Not IsNothing(json) Then
            Id = If(Not IsNothing(json.SelectToken("id")), json.SelectToken("id"), 0)
            IdParent = If(Not IsNothing(json.SelectToken("id_parent")), json.SelectToken("id_parent"), 0)
        End If
    End Sub

#End Region ' Fine Regions Subs

#Region "Events"

    Public Event IdChanged(ByVal sender As Object, ByVal id As Integer) Implements IDatabase.IdChanged
    Public Event IdParentChanged(ByVal sender As Object, ByVal idParent As Integer) Implements IDatabase.IdParentChanged

#End Region ' Fine Events

End Class
