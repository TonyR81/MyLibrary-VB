Imports System.Text
Imports Newtonsoft.Json.Linq
''' <summary>
''' Credentials class
''' <para>Created by Antonino Razeti on January 27, 2021</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of Credentials object</para>
''' <para>Implements ICredentials</para>
''' </summary>
Public Class Credentials
    Implements ICredentials

#Region "Private Declarations"

    Private mEmail As String
    Private mUsername As String
    Private mPassword As String
    Private mSecurity As SecurityType

#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"

    ''' <summary>
    ''' Gets or sets Email
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Email() As String Implements ICredentials.Email
        Get
            Return mEmail
        End Get
        Set(ByVal value As String)
            mEmail = value
            RaiseEvent EmailChanged(Me, value)
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets Username
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Username() As String Implements ICredentials.Username
        Get
            Return mUsername
        End Get
        Set(ByVal value As String)
            mUsername = value
            RaiseEvent UsernameChanged(Me, value)
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets Password
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Password() As String Implements ICredentials.Password
        Get
            Return mPassword
        End Get
        Set(ByVal value As String)
            mPassword = value
            RaiseEvent PasswordChanged(Me, value)
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets Security
    ''' </summary>
    ''' <returns>SecurityType</returns>
    Public Property Security() As SecurityType Implements ICredentials.Security
        Get
            Return mSecurity
        End Get
        Set(value As SecurityType)
            mSecurity = value
        End Set
    End Property

#End Region ' End Properties

#Region "Constructors"

    ''' <summary>
    ''' Creates a new empty instance of Credentials class
    ''' </summary>
    Public Sub New()
        Initialize()
    End Sub

    ''' <summary>
    ''' Creates a new instance of Credentials class given username and password
    ''' </summary>
    ''' <param name="username">String</param>
    ''' <param name="password">String</param>
    Public Sub New(username As String, password As String)
        Email = String.Empty
        Me.Username = username
        Me.Password = password
    End Sub

    ''' <summary>
    ''' Creates a new instance of Credentials class given email, username and password
    ''' </summary>
    ''' <param name="email">String</param>
    ''' <param name="username">String</param>
    ''' <param name="password">String</param>
    Public Sub New(email As String, username As String, password As String)
        Me.Email = email
        Me.Username = username
        Me.Password = password
    End Sub

    ''' <summary>
    ''' Creates a new instance of Credentials class given an existing credentials instance
    ''' </summary>
    ''' <param name="credentials">Credentials</param>
    Public Sub New(credentials As Credentials)
        If Not IsNothing(credentials) Then
            With credentials
                Email = .Email
                Username = .Username
                Password = .Password
            End With
        End If
    End Sub

    ''' <summary>
    ''' Creates a new instance of Credentials class given a json object that contains credentials object properties information
    ''' </summary>
    ''' <param name="json">JObject</param>
    ''' <see cref="JObject"/>
    Public Sub New(json As JObject)
        FromJson(json)
    End Sub

#End Region ' End Constructors

#Region "Functions"

    ''' <summary>
    ''' Returns a string that represents the arguments of current credentials
    ''' </summary>
    ''' <returns>String</returns>
    Public Function ToPost() As String Implements IServerRequestHelper.ToPost
        Return New StringBuilder().
            Append(String.Format("email={0}&", Email)).
            Append(String.Format("username={0}&", Username)).
            Append(String.Format("password={0}&", Password)).ToString
    End Function

    ''' <summary>
    ''' Returns a json object that contains credentials object properties information
    ''' </summary>
    ''' <returns>JObject</returns>
    ''' <see cref="JObject"/>
    Public Function ToJson() As JObject Implements IServerRequestHelper.ToJson
        Return New JObject() From {
            {"email", Email},
            {"username", Username},
            {"password", Password}}
    End Function

    ''' <summary>
    ''' Returns a string that represents current credentials
    ''' </summary>
    ''' <returns>String</returns>
    Public Overrides Function ToString() As String
        Return Username
    End Function

    ''' <summary>
    ''' Check if current password is equal to specified confirm password
    ''' </summary>
    ''' <param name="confirm">String</param>
    ''' <returns>Boolean</returns>
    Public Function CheckConfirm(confirm As String) As Boolean Implements ICredentials.CheckConfirm
        Return Password.Equals(confirm)
    End Function

    ''' <summary>
    ''' Check if email is available
    ''' </summary>
    ''' <returns>Boolean</returns>
    Public Function EmailAvailable() As Boolean Implements ICredentials.EmailAvailable
        Dim request As New ServerRequest("check_email")
        Return request.GetResponse(ToPost).SelectToken("response")
    End Function

    ''' <summary>
    ''' Check if username is available
    ''' </summary>
    ''' <returns>Boolean</returns>
    Public Function UsernameAvailable() As Boolean Implements ICredentials.UsernameAvailable
        Return New ServerRequest("check_username").GetResponse(ToPost).SelectToken("response")
    End Function

    ''' <summary>
    ''' Generate random credentials and returns them in json object format
    ''' </summary>
    ''' <returns>JObject</returns>
    Public Function GenerateRandom() As JObject Implements ICredentials.GenerateRandom
        Dim username As String = Utility.UsernameGenerator
        Return New JObject() From {
            {"username", username.ToUpper},
            {"password", username.ToLower}}
    End Function

#End Region ' Fine Regione Functions

#Region "Subs"

    ''' <summary>
    ''' Initialize current credentials class
    ''' </summary>
    Private Sub Initialize()
        Email = String.Empty
        Username = String.Empty
        Password = String.Empty
    End Sub

    ''' <summary>
    ''' Sets current credentials properties given a json object 
    ''' </summary>
    ''' <param name="json">JObject</param>
    ''' <see cref="JObject"/>
    Public Sub FromJson(json As JObject) Implements IServerRequestHelper.FromJson
        If Not IsNothing(json) Then
            With json
                Email = If(Not IsNothing(.SelectToken("email")), .SelectToken("email"), "")
                Username = If(Not IsNothing(.SelectToken("username")), .SelectToken("username"), "")
                Password = If(Not IsNothing(.SelectToken("password")), .SelectToken("password"), "")
                Security = If(Not IsNothing(.SelectToken("security")), .SelectToken("security"), New SecurityType())
            End With
        End If
    End Sub

#End Region ' Fine Regions Subs

#Region "Events"

    Public Event EmailChanged(ByVal sender As Object, ByVal email As String) Implements ICredentials.EmailChanged
    Public Event UsernameChanged(ByVal sender As Object, ByVal username As String) Implements ICredentials.UsernameChanged
    Public Event PasswordChanged(ByVal sender As Object, ByVal password As String) Implements ICredentials.PasswordChanged

#End Region ' Fine Events

    ''' <summary>
    ''' ShaType class
    ''' <para>Created by Antonino Razeti on January 27, 2021</para>
    ''' <para>Version 1.0</para>
    ''' <para> This class contains properties, methods and functions of ShaType object</para>
    ''' <para>Implements IShaType</para>
    ''' </summary>
    Public Class SecurityType

#Region "Private Declarations"

        Private mType As ShaType
        Private ReadOnly StringValue As String
        Private ReadOnly IntValue As Integer
        Private Const SHA1 As String = "SHA-1"
        Private Const SHA256 As String = "SHA-256"
        Private Const SHA512 As String = "SHA-512"
        Private Const MD5 As String = "MD5"

#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"

        ''' <summary>
        ''' Gets or sets Type
        ''' </summary>
        ''' <returns>ShaType</returns>
        Public Property Type() As ShaType
            Get
                Return mType
            End Get
            Set(ByVal value As ShaType)
                mType = value
                Select Case value
                    Case ShaType.SHA1
                        SetType(SHA1, ShaType.SHA1)
                    Case ShaType.SHA256
                        SetType(SHA256, ShaType.SHA256)
                    Case ShaType.SHA512
                        SetType(SHA512, ShaType.SHA512)
                    Case ShaType.MD5
                        SetType(MD5, ShaType.MD5)
                End Select
            End Set
        End Property

#End Region ' End Properties

#Region "Constructors"

        ''' <summary>
        ''' Creates a new instance of ShaType
        ''' </summary>
        Public Sub New()
            Type = ShaType.SHA1
        End Sub

        ''' <summary>
        ''' Creates a new instance of Security class given specified type of security
        ''' </summary>
        ''' <param name="type">ShaType</param>
        Public Sub New(type As ShaType)
            Me.Type = type
        End Sub

#End Region ' End Constructors

#Region "Functions"

        ''' <summary>
        ''' Returns the int value of current security type
        ''' </summary>
        ''' <returns>Integer</returns>
        Public Function GetInt() As Integer
            Return IntValue
        End Function

        ''' <summary>
        ''' Returns the secure algorithm type given int value
        ''' </summary>
        ''' <param name="value">Integer</param>
        ''' <returns>ShaType</returns>
        Public Shared Function GetSecurityType(value As Integer) As ShaType
            Dim res As ShaType
            Select Case value
                Case 0
                    res = ShaType.SHA1
                Case 1
                    res = ShaType.SHA256
                Case 2
                    res = ShaType.SHA512
                Case 3
                    res = ShaType.MD5
                Case Else
                    res = ShaType.MD5
            End Select
            Return res
        End Function

        ''' <summary>
        ''' Returns the secure algorithm type given string value
        ''' </summary>
        ''' <param name="value">String</param>
        ''' <returns>ShaType</returns>
        Public Shared Function GetSecurityType(value As String) As ShaType
            Dim res As ShaType
            Select Case value
                Case SHA1
                    res = ShaType.SHA1
                Case SHA256
                    res = ShaType.SHA256
                Case SHA512
                    res = ShaType.SHA512
                Case MD5
                    res = ShaType.MD5
                Case Else
                    res = ShaType.SHA1
            End Select
            Return res
        End Function

        ''' <summary>
        ''' Returns a string that represents current secure algorithm type
        ''' </summary>
        ''' <returns>String</returns>
        Public Overrides Function ToString() As String
            Return StringValue
        End Function

#End Region ' Fine Regione Functions

#Region "Subs"

        ''' <summary>
        ''' Initialize current security type
        ''' </summary>
        ''' <param name="stringValue">String</param>
        ''' <param name="intValue">Integer</param>
        Private Sub SetType(stringValue As String, intValue As Integer)
            stringValue = SHA1
            intValue = intValue
        End Sub

#End Region ' Fine Regions Subs

    End Class

End Class
