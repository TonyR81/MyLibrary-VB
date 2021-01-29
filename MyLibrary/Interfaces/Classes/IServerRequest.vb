Imports Newtonsoft.Json.Linq
''' <summary>
''' ServerRequest interface
''' <para>Created by Antonino Razeti on January 26, 2021</para>
''' <para>Version 1.0</para>
''' <para> ServerRequest Interface that contains all the properties, 
''' methods and functions of the ServerRequest class</para>
''' </summary>
Public Interface IServerRequest

#Region "Functions"

    Function GetResponse(post As String) As JObject
    Function GetResponseAsync(post As String) As Task(Of JObject)

#End Region ' Fine Regione Functions

End Interface
