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


#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"


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
    Public Function Login(ByRef user As User) As Boolean
        Dim res As Boolean
        Try
            If CheckInternetConnection() Then
                res = LoginFromServer(user)

            Else
                ' TODO Effettuare login dal database locale
            End If
        Catch server As ServerConnectionException

        Catch internet As InternetConnectionException

        End Try
    End Function

    ''' <summary>
    ''' Login from server database
    ''' </summary>
    ''' <param name="user">User</param>
    ''' <returns>JObject</returns>
    Private Function LoginFromServer(user As User) As Boolean
        Dim json As JObject = New ServerRequest("login").GetResponse(user.ToPost)
        If Not IsNothing(json) Then

        Else
            Throw New ServerConnectionException
        End If
    End Function

    Private Function LoginFromLocal(user As User) As JObject

    End Function

#End Region ' Fine Regione Functions

#Region "Subs"


#End Region ' Fine Regions Subs

#Region "Events"


#End Region ' Fine Events


End Class
