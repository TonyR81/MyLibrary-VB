Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json.Linq

Public NotInheritable Class ServerRequest
    Implements IServerRequest

#Region "Private Declaration"

    Private Const DOMAIN As String = "https://lavanderialapegreen.it/gpricing/includes/"

    Private ReadOnly Type As RequestType
    Private Url As String

    Public Enum RequestType
        FORM = 0
        REQUEST = 1
    End Enum

#End Region ' End Private Declaration

#Region "Constructor"

    ''' <summary>
    ''' Creates a new empty instance of ServerDatabase class setting request type to x-www-form-urlencoded
    ''' </summary>
    Public Sub New(url As String)
        Me.Url = String.Format("{0}{1}", DOMAIN, If(Not url.Contains(".php"), String.Format("{0}.php", url), url))
        Type = RequestType.FORM
    End Sub

#End Region ' End Constructor

#Region "Functions"

    ''' <summary>
    ''' Returns the response from server given php file string and post. 
    ''' Throw ServerConnectionException and InternetConnectionException
    ''' </summary>
    ''' <param name="post">String</param>
    ''' <returns>JObject</returns>
    Public Function GetResponse(post As String) As JObject Implements IServerRequest.GetResponse
        Try
            If CheckInternetConnection() Then
                post &= "&device=0"
                Dim request As HttpWebRequest = HttpWebRequest.Create(Url)
                request.Method = "POST"
                ' request.ContentType = "application/json; charset=UTF-8"
                ' request.ContentType = "application/x-www-form-urlencoded"
                request.ContentType = If(Type = RequestType.FORM, "application/x-www-form-urlencoded", "application/json; charset=UTF-8")
                Dim byteArray() As Byte = Encoding.UTF8.GetBytes(post)
                request.ContentLength = byteArray.Length
                Dim dataStream As Stream = request.GetRequestStream
                dataStream.Write(byteArray, 0, byteArray.Length)
                dataStream.Close()
                Dim response As HttpWebResponse = request.GetResponse
                dataStream = response.GetResponseStream
                Dim reader As New StreamReader(dataStream)
                Dim res = reader.ReadToEnd
                Console.Write(res)
                reader.Close()
                response.Close()
                Return JObject.Parse(res)
            End If
        Catch internet As InternetConnectionException
            Throw internet
        End Try
        Return New JObject From {
            {"response", False},
            {"exception", 0}}
    End Function

    ''' <summary>
    ''' Returns the response from server given php file string and post in async mode
    ''' </summary>
    ''' <param name="post">String</param>
    ''' <returns>JObject</returns>
    ''' <see cref="JObject"/>
    Public Async Function GetResponseAsync(post As String) As Task(Of JObject) Implements IServerRequest.GetResponseAsync
        Return Await Task.Run(Function() GetResponse(post))
    End Function

#End Region ' End Region Functions

End Class
