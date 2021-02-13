Imports Newtonsoft.Json.Linq
''' <summary>
''' DatabaseHelper class
''' <para>Created by Antonino Razeti on February 01, 2021</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of DatabaseHelper object</para>
''' <para>Implements IDatabaseHelper</para>
''' </summary>
Public Class DatabaseHelper

#Region "Private Declarations"

    Private mResponse As JObject

#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"

    ''' <summary>
    ''' Gets the response of the database request
    ''' </summary>
    ''' <returns>JObject</returns>
    Public ReadOnly Property Response As JObject
        Get
            Return mResponse
        End Get
    End Property

#End Region ' End Properties

#Region "Constructors"

    ''' <summary>
    ''' Creates a new empty instance of DatabaseHelper class
    ''' </summary>
    Public Sub New()

    End Sub

#End Region ' End Constructors

#Region "Functions"

    ''' <summary>
    ''' Login of specified user from server or local database
    ''' </summary>
    ''' <param name="user">User</param>
    ''' <returns>JObject</returns>
    Public Function Login(ByRef user As Account) As Boolean
        Try
            Return LoginFromServer(user)
        Catch server As ServerConnectionException
            Return LoginFromLocal(user)
        Catch internet As InternetConnectionException
            Return LoginFromLocal(user)
        Catch unverified As UnverifiedUserException
            Throw unverified
        End Try
        Return False
    End Function

    ''' <summary>
    ''' Login from server database
    ''' </summary>
    ''' <param name="user">User</param>
    ''' <returns>JObject</returns>
    Private Function LoginFromServer(user As Account) As Boolean
        Dim json As JObject = New ServerRequest("login").GetResponse(JsonToPost("user", user.ToJson))
        If Not IsNothing(json) Then
            If Not IsNothing(json.SelectToken("response")) Then
                Dim response As Boolean = json.SelectToken("response")
                If response Then
                    mResponse = json
                    Return response
                Else
                    If Not IsNothing(json.SelectToken("exception")) Then
                        Throw ExceptionBase.GetException(Integer.Parse(json.SelectToken("exception")))
                    Else
                        Throw New WrongCredentialsException
                    End If
                End If
            Else
                Throw New ServerConnectionException
            End If
        Else
            Throw New ServerConnectionException
        End If
    End Function

    ''' <summary>
    ''' Login of specified user from local database
    ''' </summary>
    ''' <param name="user">User</param>
    ''' <returns>Boolean</returns>
    Private Function LoginFromLocal(user As Account) As Boolean
        Return False
    End Function

#End Region ' Fine Regione Functions

#Region "Subs"


#End Region ' Fine Regions Subs

#Region "Events"


#End Region ' Fine Events


End Class
