Imports System.ComponentModel
Imports System.Text
Imports Newtonsoft.Json.Linq
''' <summary>
''' Person class
''' <para>Created by Antonino Razeti on January 28, 2021</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of Person object</para>
''' <para>Implements IPerson</para>
''' </summary>
Public Class Person
    Inherits Account
    Implements IPerson

#Region "Private Declarations"

    Private mLastName As String
    Private mFistName As String

#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"

    ''' <summary>
    ''' Gets or sets LastName
    ''' </summary>
    ''' <returns>String</returns>
    <DefaultValue(""), Category("Properties")>
    Public Property LastName() As String Implements IPerson.LastName
        Get
            Return mLastName
        End Get
        Set(ByVal value As String)
            mLastName = value
            RaiseEvent LastNameChanged(Me, value)
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets FirstName
    ''' </summary>
    ''' <returns>String</returns>
    <DefaultValue(""), Category("Properties")>
    Public Property FirstName() As String Implements IPerson.FirstName
        Get
            Return mFistName
        End Get
        Set(ByVal value As String)
            mFistName = value
            RaiseEvent FirstNameChanged(Me, value)
        End Set
    End Property

#End Region ' End Properties

#Region "Constructors"

    ''' <summary>
    ''' Creates a new empty instance of Person class
    ''' </summary>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' Creates a new instance of Person class given a json object that contains person properties information
    ''' </summary>
    ''' <param name="json">JObject</param>
    ''' <see cref="JObject"/>
    Public Sub New(json As JObject)
        MyBase.New(json)
    End Sub

    ''' <summary>
    ''' Creates a new instance of Person class given the id number associated with the Person into database, 
    ''' the id number associated with the parent of current Person into database, 
    ''' the last name and first name, the location, fiscal code, 
    ''' phone, the credentials, the registration and subscription day, the boolean value that indicates if newsletters are enabled for current Person, the account type and plan, 
    ''' the session status, the referral code, the id token to receive notification and the boolean value that indicates if current Person is verified
    ''' </summary>
    ''' <param name="id">Integer</param>
    ''' <param name="idParent">Integer</param>
    ''' <param name="lastName">String</param>
    ''' <param name="firstName">String</param>
    ''' <param name="location">GeoLocation</param>
    ''' <param name="fiscalCode">String</param>
    ''' <param name="phone">String</param>
    ''' <param name="credentials">Credentials</param>
    ''' <param name="registration">Date</param>
    ''' <param name="subscription">Date</param>
    ''' <param name="accountType">AccountType</param>
    ''' <param name="accountPlan">AccountPlan</param>
    ''' <param name="sessionStatus">SessionStatus</param>
    ''' <param name="referralCode">String</param>
    ''' <param name="idToken">String</param>
    ''' <param name="isVerified">Boolean</param>
    ''' <see cref="GeoLocation"/>
    ''' <see cref="Credentials"/>
    Public Sub New(id As Integer, idParent As Integer, lastName As String, firstName As String, location As GeoLocation, fiscalCode As String, phone As String, credentials As Credentials, email As String, username As String, password As String, registration As Date, subscription As Date, accountType As AccountType, accountPlan As AccountPlan, sessionStatus As SessionStatus, referralCode As String, idToken As String, isVerified As Boolean)
        MyBase.New(id, idParent, location, fiscalCode, phone, credentials, email, username, password, registration, subscription, accountType, accountPlan, sessionStatus, referralCode, idToken, isVerified)
        Me.LastName = lastName
        Me.FirstName = firstName
    End Sub

#End Region ' End Constructors

#Region "Functions"

    ''' <summary>
    ''' Returns a json object that contains current user properties information
    ''' </summary>
    ''' <returns>JObject</returns>
    Public Overrides Function ToJson() As JObject
        Dim json As JObject = MyBase.ToJson()
        json.Add(LastName)
        json.Add(FirstName)
        Return json
    End Function

    ''' <summary>
    ''' Returns a string that represents the arguments of current person to query server database
    ''' </summary>
    ''' <returns>String</returns>
    Public Overrides Function ToPost() As String
        Return New StringBuilder().
            Append(String.Format("{0}&", MyBase.ToPost)).
            Append(String.Format("last_name={0}&", LastName)).
            Append(String.Format("first_name={0}&", FirstName)).
        ToString()
    End Function

    ''' <summary>
    ''' Returns a string that represents current person
    ''' </summary>
    ''' <returns>String</returns>
    Public Overrides Function ToString() As String
        Return String.Format("{0} {1}", LastName, FirstName)
    End Function

#End Region ' Fine Regione Functions

#Region "Subs"

    ''' <summary>
    ''' Sets current person properties given specified json object that contains current person properties information
    ''' </summary>
    ''' <param name="json">JObject</param>
    ''' <see cref="JObject"/>
    Public Overrides Sub FromJson(json As JObject)
        MyBase.FromJson(json)
        If Not IsNothing(json) Then
            With json
                LastName = If(Not IsNothing(.SelectToken("last_name")), .SelectToken("last_name"), "")
                FirstName = If(Not IsNothing(.SelectToken("first_name")), .SelectToken("first_name"), "")
            End With
        End If
    End Sub

#End Region ' Fine Regions Subs

#Region "Events"

    Public Event LastNameChanged(ByVal sender As Object, ByVal lastName As String) Implements IPerson.LastNameChanged
    Public Event FirstNameChanged(ByVal sender As Object, ByVal firstName As String) Implements IPerson.FirstNameChanged

#End Region ' Fine Events

End Class
