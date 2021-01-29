Imports MyLibrary
Imports Newtonsoft.Json.Linq
''' <summary>
''' Credentials interface
''' <para>Created by Antonino Razeti on January 27, 2021</para>
''' <para>Version 1.0</para>
''' <para> Credentials Interface that contains all the properties, 
''' methods and functions of the Credentials class</para>
''' </summary>
Public Interface ICredentials
    Inherits IServerRequestHelper

#Region "Getters and Setters"

    Property Email As String
    Property Username As String
    Property Password As String
    Property Security As Credentials.SecurityType

#End Region ' End Getters and Setters

#Region "Functions"

    Function CheckConfirm(confirm As String) As Boolean
    Function EmailAvailable() As Boolean

#End Region ' End Functions

#Region "Events"

    Event EmailChanged(sender As Object, email As String)
    Event UsernameChanged(sender As Object, username As String)
    Event PasswordChanged(sender As Object, password As String)
    Function UsernameAvailable() As Boolean
    Function GenerateRandom() As JObject

#End Region ' End Events

End Interface
