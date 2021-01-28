Imports System.ComponentModel
Imports System.Text
Imports Newtonsoft.Json.Linq
''' <summary>
''' Company class
''' <para>Created by Antonino Razeti on January 28, 2021</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of Company object</para>
''' <para>Implements ICompany</para>
''' </summary>
Public Class Company
    Inherits User
    Implements ICompany

#Region "Private Declarations"

    Private mName As String
    Private mBusinessName As String
    Private mVatNumber As String
    Private mWebsite As String

#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"

    ''' <summary>
    ''' Gets or sets Name
    ''' </summary>
    ''' <returns>String</returns>
    <DefaultValue(""), Category("Properties")>
    Public Property Name() As String Implements ICompany.Name
        Get
            Return mName
        End Get
        Set(ByVal value As String)
            mName = value
            RaiseEvent NameChanged(Me, value)
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets BusinessName
    ''' </summary>
    ''' <returns>String</returns>
    <DefaultValue(""), Category("Properties")>
    Public Property BusinessName() As String Implements ICompany.BusinessName
        Get
            Return mBusinessName
        End Get
        Set(ByVal value As String)
            mBusinessName = value
            RaiseEvent BusinessNameChanged(Me, value)
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets VatNumber
    ''' </summary>
    ''' <returns>String</returns>
    <DefaultValue(""), Category("Properties")>
    Public Property VatNumber() As String Implements ICompany.VatNumber
        Get
            Return mVatNumber
        End Get
        Set(ByVal value As String)
            mVatNumber = value
            RaiseEvent VatNumberChanged(Me, value)
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets Website
    ''' </summary>
    ''' <returns>String</returns>
    <DefaultValue(""), Category("Properties")>
    Public Property Website() As String Implements ICompany.Website
        Get
            Return mWebsite
        End Get
        Set(ByVal value As String)
            mWebsite = value
            RaiseEvent WebsiteChanged(Me, value)
        End Set
    End Property

#End Region ' End Properties

#Region "Constructors"

    ''' <summary>
    ''' Creates a new empty instance of Company class
    ''' </summary>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' Creates a new instance of Company class given a json object that contains company properties information
    ''' </summary>
    ''' <param name="json">JObject</param>
    ''' <see cref="JObject"/>
    Public Sub New(json As JObject)
        MyBase.New(json)
    End Sub

    ''' <summary>
    ''' Creates a new instance of Company class given the id number associated with the Company into database, 
    ''' the id number associated with the parent of current Company into database, the location, fiscal code, 
    ''' phone, the credentials, the registration and subscription day, the boolean value that indicates if newsletters are enabled for current Company, the account type and plan, 
    ''' the session status, the referral code, the id token to receive notification and the boolean value that indicates if current Company is verified
    ''' </summary>
    ''' <param name="id">Integer</param>
    ''' <param name="idParent">Integer</param>
    ''' <param name="name">String</param>
    ''' <param name="businessName">String</param>
    ''' <param name="vatNumber">String</param>
    ''' <param name="website">String</param>
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
    Public Sub New(id As Integer, idParent As Integer, name As String, businessName As String, vatNumber As String, website As String, location As GeoLocation, fiscalCode As String, phone As String, credentials As Credentials, email As String, username As String, password As String, registration As Date, subscription As Date, accountType As AccountType, accountPlan As AccountPlan, sessionStatus As SessionStatus, referralCode As String, idToken As String, isVerified As Boolean)
        MyBase.New(id, idParent, location, fiscalCode, phone, credentials, email, username, password, registration, subscription, accountType, accountPlan, sessionStatus, referralCode, idToken, isVerified)
        Me.Name = name
        Me.BusinessName = businessName
        Me.VatNumber = vatNumber
        Me.Website = website
    End Sub

#End Region ' End Constructors

#Region "Functions"

    ''' <summary>
    ''' Returns a json object that represents current company
    ''' </summary>
    ''' <returns>JObject</returns>
    ''' <see cref="JObject"/>
    Public Overrides Function ToJson() As JObject
        Dim json As JObject = MyBase.ToJson()
        json.Add("name", Name)
        json.Add("business_name", BusinessName)
        json.Add("vat_number", VatNumber)
        json.Add("website", Website)
        Return json
    End Function

    ''' <summary>
    ''' Returns a string that represents the arguments of current company to query server database
    ''' </summary>
    ''' <returns>String</returns>
    Public Overrides Function ToPost() As String
        Return New StringBuilder().
            Append(String.Format("name={0}&", Name)).
            Append(String.Format("business_name={0}&", BusinessName)).
            Append(String.Format("vat_number={0}&", VatNumber)).
            Append(String.Format("website={0}&", Website)).
            Append(MyBase.ToPost).
            ToString()
    End Function

    ''' <summary>
    ''' Returns a string that represents current company
    ''' </summary>
    ''' <returns>String</returns>
    Public Overrides Function ToString() As String
        Return Name
    End Function

#End Region ' Fine Regione Functions

#Region "Subs"

    ''' <summary>
    ''' Initialize current Company
    ''' </summary>
    Protected Friend Overrides Sub Initialize()
        MyBase.Initialize()
        Name = ""
        BusinessName = ""
        VatNumber = ""
        Website = ""
        AccountType = AccountType.COMPANY
    End Sub

    ''' <summary>
    ''' Sets current company properties given specified json object that contains company properties information
    ''' </summary>
    ''' <param name="json">JObject</param>
    ''' <see cref="JObject"/>
    Public Overrides Sub FromJson(json As JObject)
        MyBase.FromJson(json)
        If Not IsNothing(json) Then
            With json
                Name = If(Not IsNothing(.SelectToken("name")), .SelectToken("name"), "")
                BusinessName = If(Not IsNothing(.SelectToken("business_name")), .SelectToken("business_name"), "")
                VatNumber = If(Not IsNothing(.SelectToken("vat_number")), .SelectToken("vat_number"), "")
                Website = If(Not IsNothing(.SelectToken("website")), .SelectToken("website"), "")
            End With
        End If
    End Sub

#End Region ' Fine Regions Subs

#Region "Events"

    Public Event NameChanged(ByVal sender As Object, ByVal name As String) Implements ICompany.NameChanged
    Public Event BusinessNameChanged(ByVal sender As Object, ByVal businessName As String) Implements ICompany.BusinessNameChanged
    Public Event VatNumberChanged(ByVal sender As Object, ByVal vatNumber As String) Implements ICompany.VatNumberChanged
    Public Event WebsiteChanged(ByVal sender As Object, ByVal website As String) Implements ICompany.WebsiteChanged

#End Region ' Fine Events

End Class
