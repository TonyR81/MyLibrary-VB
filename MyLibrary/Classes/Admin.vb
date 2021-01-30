Imports MyLibrary
Imports Newtonsoft.Json.Linq
''' <summary>
''' Admin class
''' <para>Created by Antonino Razeti on January 30, 2021</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of Admin object</para>
''' <para>Implements IAdmin</para>
''' </summary>
Public Class Admin
    Inherits Person
    Implements IAdmin

#Region "Private Declarations"

    Friend WithEvents MCompanies As CompaniesCollection

#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"

    ''' <summary>
    ''' Gets or sets Companies
    ''' </summary>
    ''' <returns>CompaniesCollection</returns>
    Public Property Companies() As CompaniesCollection Implements IAdmin.Companies
        Get
            Return MCompanies
        End Get
        Set(ByVal value As CompaniesCollection)
            MCompanies = value
        End Set
    End Property

#End Region ' End Properties

#Region "Constructors"

    ''' <summary>
    ''' Creates a new empty instance of Admin class
    ''' </summary>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' Creates a new instance of Admin class given a json object that contains admin properties information
    ''' </summary>
    ''' <param name="json">JObject</param>
    ''' <see cref="JObject"/>
    Public Sub New(json As JObject)
        MyBase.New(json)
    End Sub

    ''' <summary>
    ''' Creates a new instance of Admin class given the id number associated with the Admin into database, 
    ''' the id number associated with the parent of current Admin into database, 
    ''' the last name and first name, the location, fiscal code, 
    ''' phone, the credentials, the registration and subscription day, the boolean value that indicates if newsletters are enabled for current Admin, the account type and plan, 
    ''' the session status, the referral code, the id token to receive notification and the boolean value that indicates if current Admin is verified
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
        MyBase.New(id, idParent, lastName, firstName, location, fiscalCode, phone, credentials, email, username, password, registration, subscription, accountType, accountPlan, sessionStatus, referralCode, idToken, isVerified)
    End Sub

#End Region ' End Constructors

#Region "Functions"

    ''' <summary>
    ''' Returns a json object format that represents current admin
    ''' </summary>
    ''' <returns>JObject</returns>
    ''' <see cref="JObject"/>
    Public Overrides Function ToJson() As JObject
        Dim json As JObject = MyBase.ToJson()
        If Not IsNothing(Companies) Then
            json.Add("companies", Companies.ToJson())
        End If
        Return json
    End Function

#End Region ' Fine Regione Functions

#Region "Subs"

    ''' <summary>
    ''' Initialize current admin
    ''' </summary>
    Protected Friend Overrides Sub Initialize()
        MyBase.Initialize()
        AccountType = AccountType.ADMIN
        Companies = New CompaniesCollection
    End Sub

    ''' <summary>
    ''' Sets current admin properties given specified json object that contains current admin properties information
    ''' </summary>
    ''' <param name="json">JObject</param>
    ''' <see cref="JObject"/>
    Public Overrides Sub FromJson(json As JObject)
        MyBase.FromJson(json)
        If Not IsNothing(json) AndAlso Not IsNothing(json.SelectToken("companies")) Then
            Companies = New CompaniesCollection(json.SelectToken("companies"))
        End If
    End Sub

#End Region ' Fine Regions Subs

#Region "Events"


#End Region ' Fine Events


End Class
