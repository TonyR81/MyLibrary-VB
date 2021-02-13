Imports MyLibrary
Imports Newtonsoft.Json.Linq
Imports System.ComponentModel
Imports System.Text
''' <summary>
''' User class
''' <para>Created by Antonino Razeti on January 26, 2021</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of User object</para>
''' <para>Implements IUser</para>
''' </summary>
Public Class Account
    Inherits Database
    Implements IUser

#Region "Private Declarations"

    Private WithEvents MLocation As GeoLocation
    Private mFiscalCode As String
    Private mPhone As String
    Private WithEvents MCredentials As Credentials
    Private mRegistration As Date
    Private mSubscription As Date
    Private mNewsletters As Boolean
    Private mAccountType As AccountType
    Private mAccountPlan As AccountPlan
    Private mSessionStatus As SessionStatus
    Private mReferralCode As String
    Private mIdToken As String
    Private mIsVerified As Boolean

#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"

    ''' <summary>
    ''' Gets or sets Location
    ''' </summary>
    ''' <returns>GeoLocation</returns>
    Public Property Location() As GeoLocation Implements IUser.Location
        Get
            Return MLocation
        End Get
        Set(ByVal value As GeoLocation)
            MLocation = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets FiscalCode
    ''' </summary>
    ''' <returns>String</returns>
    <DefaultValue(""), Category("properties")>
    Public Property FiscalCode() As String Implements IUser.FiscalCode
        Get
            Return mFiscalCode
        End Get
        Set(ByVal value As String)
            mFiscalCode = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets Phone
    ''' </summary>
    ''' <returns>String</returns>
    <DefaultValue(""), Category("properties")>
    Public Property Phone() As String Implements IUser.Phone
        Get
            Return mPhone
        End Get
        Set(ByVal value As String)
            mPhone = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets Credentials
    ''' </summary>
    ''' <returns>Credentials</returns>
    Public Property Credentials() As Credentials
        Get
            Return MCredentials
        End Get
        Set(ByVal value As Credentials)
            MCredentials = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the email of current user
    ''' </summary>
    ''' <returns>String</returns>
    <DefaultValue(""), Category("Properties")>
    Public Property Email() As String Implements IUser.Email
        Get
            Return If(Not IsNothing(Credentials), Credentials.Email, "")
        End Get
        Set(ByVal value As String)
            If IsNothing(Credentials) Then
                Credentials = New Credentials()
            End If
            Credentials.Email = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the username of current user
    ''' </summary>
    ''' <returns>String</returns>
    <DefaultValue(""), Category("Properties")>
    Public Property Username() As String
        Get
            Return If(Not IsNothing(Credentials), Credentials.Username, "")
        End Get
        Set(ByVal value As String)
            If IsNothing(Credentials) Then
                Credentials = New Credentials
            End If
            Credentials.Username = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets Password
    ''' </summary>
    ''' <returns>String</returns>
    <DefaultValue(""), Category("Properties")>
    Public Property Password() As String
        Get
            Return If(Not IsNothing(Credentials), Credentials.Password, "")
        End Get
        Set(ByVal value As String)
            If IsNothing(Credentials) Then
                Credentials = New Credentials
            End If
            Credentials.Password = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets Registration
    ''' </summary>
    ''' <returns>Date</returns>
    <DefaultValue(""), Category("Properties")>
    Public Property Registration() As Date Implements IUser.Registration
        Get
            Return mRegistration
        End Get
        Set(ByVal value As Date)
            mRegistration = value
            RaiseEvent RegistrationChanged(Me, value)
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets Subscription
    ''' </summary>
    ''' <returns>Date</returns>
    <DefaultValue(""), Category("Properties")>
    Public Property Subscription() As Date Implements IUser.Subscription
        Get
            Return mSubscription
        End Get
        Set(ByVal value As Date)
            mSubscription = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets Newsletters
    ''' </summary>
    ''' <returns>Boolean</returns>
    <DefaultValue(False), Category("Properties")>
    Public Property Newsletters() As Boolean Implements IUser.Newsletters
        Get
            Return mNewsletters
        End Get
        Set(ByVal value As Boolean)
            mNewsletters = value
            RaiseEvent NewslettersChanged(Me, value)
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets AccountType
    ''' </summary>
    ''' <returns>AccountType</returns>
    <DefaultValue(AccountType.USER), Category("Properties")>
    Public Property AccountType() As AccountType Implements IUser.AccountType
        Get
            Return mAccountType
        End Get
        Set(ByVal value As AccountType)
            mAccountType = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets AccountPlan
    ''' </summary>
    ''' <returns>AccountPlan</returns>
    <DefaultValue(AccountPlan.DEMO), Category("Properties")>
    Public Property AccountPlan() As AccountPlan Implements IUser.AccountPlan
        Get
            Return mAccountPlan
        End Get
        Set(ByVal value As AccountPlan)
            mAccountPlan = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets SessionStatus
    ''' </summary>
    ''' <returns>SessionStatus</returns>
    <DefaultValue(SessionStatus.OFFLINE), Category("Properties")>
    Public Property SessionStatus() As SessionStatus Implements IUser.SessionStatus
        Get
            Return mSessionStatus
        End Get
        Set(ByVal value As SessionStatus)
            mSessionStatus = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets ReferralCode
    ''' </summary>
    ''' <returns>String</returns>
    <DefaultValue(""), Category("Properties")>
    Public Property ReferralCode() As String
        Get
            Return mReferralCode
        End Get
        Set(ByVal value As String)
            mReferralCode = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets IdToken
    ''' </summary>
    ''' <returns>String</returns>
    <DefaultValue(""), Category("Properties")>
    Public Property IdToken() As String Implements IUser.IdToken
        Get
            Return mIdToken
        End Get
        Set(ByVal value As String)
            mIdToken = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets IsVerified
    ''' </summary>
    ''' <returns>Boolean</returns>
    <DefaultValue(False), Category("Properties")>
    Public Property IsVerified() As Boolean Implements IUser.IsVerified
        Get
            Return mIsVerified
        End Get
        Set(ByVal value As Boolean)
            mIsVerified = value
        End Set
    End Property

#End Region ' End Properties

#Region "Constructors"

    ''' <summary>
    ''' Creates a new empty instance of User class
    ''' </summary>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' Creates a new instance of User class given a json object that contains user properties information
    ''' </summary>
    ''' <param name="json">JObject</param>
    ''' <see cref="JObject"/>
    Public Sub New(json As JObject)
        MyBase.New(json)
    End Sub

    ''' <summary>
    ''' Creates a new instance of User class given the id number associated with the user into database, 
    ''' the id number associated with the parent of current user into database, the location, fiscal code, 
    ''' phone, the credentials, the registration and subscription day, the boolean value that indicates if newsletters are enabled for current user, the account type and plan, 
    ''' the session status, the referral code, the id token to receive notification and the boolean value that indicates if current user is verified
    ''' </summary>
    ''' <param name="id">Integer</param>
    ''' <param name="idParent">Integer</param>
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
    Public Sub New(id As Integer, idParent As Integer, location As GeoLocation, fiscalCode As String, phone As String, credentials As Credentials, email As String, username As String, password As String, registration As Date, subscription As Date, accountType As AccountType, accountPlan As AccountPlan, sessionStatus As SessionStatus, referralCode As String, idToken As String, isVerified As Boolean)
        MyBase.New(id, idParent)
        Me.Location = location
        Me.FiscalCode = fiscalCode
        Me.Phone = phone
        Me.Credentials = credentials
        Me.Email = email
        Me.Username = username
        Me.Password = password
        Me.Registration = registration
        Me.Subscription = subscription
        Me.AccountType = accountType
        Me.AccountPlan = accountPlan
        Me.SessionStatus = sessionStatus
        Me.ReferralCode = referralCode
        Me.IdToken = idToken
        Me.IsVerified = isVerified
    End Sub

    ''' <summary>
    ''' Creates a new instance of User class given username and password to login
    ''' </summary>
    ''' <param name="username">String</param>
    ''' <param name="password">String</param>
    Public Sub New(username As String, password As String)
        Me.Username = username
        Me.Password = password
    End Sub

#End Region ' End Constructors

#Region "Functions"

    ''' <summary>
    ''' Returns a json object that contains current user properties information
    ''' </summary>
    ''' <returns>JObject</returns>
    ''' <see cref="JObject"/>
    Public Overrides Function ToJson() As JObject
        Dim json As JObject = MyBase.ToJson
        json.Add("location", Location.ToJson)
        json.Add("phone", Phone)
        json.Add("fiscal_code", FiscalCode)
        json.Add("credentials", Credentials.ToJson)
        json.Add("email", Email)
        json.Add("username", Username)
        json.Add("password", Password)
        json.Add("registration", Utility.DateToShortString(Registration))
        json.Add("subscription", If(IsNothing(Subscription) OrElse Date.Compare(Subscription, New Date(1, 1, 1)), "null", Utility.DateToShortString(Subscription)))
        json.Add("newsletters", If(Newsletters, 1, 0))
        json.Add("account_type", Integer.Parse(AccountType))
        json.Add("account_plan", Integer.Parse(AccountPlan))
        json.Add("session_status", Integer.Parse(SessionStatus))
        json.Add("referral_code", ReferralCode)
        json.Add("id_token", IdToken)
        json.Add("verified", If(IsVerified, 1, 0))
        Return json
    End Function

    ''' <summary>
    ''' Returns a string that represents the arguments of current user to query server database
    ''' </summary>
    ''' <returns>String</returns>
    Public Overrides Function ToPost() As String
        Return New StringBuilder().
            Append(String.Format("{0}&", MyBase.ToPost)).
            Append(String.Format("address={0}&", If(Not IsNothing(Location), Location.Address, ""))).
            Append(String.Format("street_number={0}&", If(Not IsNothing(Location), Location.StreetNumber, ""))).
            Append(String.Format("city={0}&", If(Not IsNothing(Location), Location.City, ""))).
            Append(String.Format("country={0}&", If(Not IsNothing(Location), Location.Country, ""))).
            Append(String.Format("zip_code={0}&", If(Not IsNothing(Location), Location.ZipCode, ""))).
            Append(String.Format("region={0}&", If(Not IsNothing(Location), Location.Region, ""))).
            Append(String.Format("province={0}&", If(Not IsNothing(Location), Location.Province, ""))).
            Append(String.Format("latitude={0}&", If(Not IsNothing(Location), Location.Latitude, ""))).
            Append(String.Format("longitude={0}&", If(Not IsNothing(Location), Location.Longitude, ""))).
            Append(String.Format("fiscal_code={0}&", FiscalCode)).
            Append(String.Format("phone={0}&", Phone)).
            Append(String.Format("email={0}&", Email)).
            Append(String.Format("username={0}&", Username)).
            Append(String.Format("password={0}&", Password)).
            Append(String.Format("registration={0}&", DateToShortString(Registration))).
            Append(String.Format("subscription={0}&", If(IsNothing(Subscription) OrElse Date.Compare(Subscription, New Date(1, 1, 1)), "null", DateToShortString(Subscription)))).
            Append(String.Format("newsletters={0}&", If(Newsletters, 1, 0))).
            Append(String.Format("account_type={0}&", Integer.Parse(AccountType))).
            Append(String.Format("account_plan={0}&", Integer.Parse(AccountPlan))).
            Append(String.Format("session_status={0}&", Integer.Parse(SessionStatus))).
            Append(String.Format("referral_code={0}&", ReferralCode)).
            Append(String.Format("id_token={0}&", IdToken)).
            Append(String.Format("verified={0}&", If(IsVerified, 1, 0))).
        ToString()
    End Function

    ''' <summary>
    ''' Returns a string that represents current user
    ''' </summary>
    ''' <returns>String</returns>
    Public Overrides Function ToString() As String
        Return Username
    End Function

#End Region ' Fine Regione Functions

#Region "Subs"

    ''' <summary>
    ''' Initialize current user
    ''' </summary>
    Protected Friend Overrides Sub Initialize()
        MyBase.Initialize()
        Location = New GeoLocation()
        FiscalCode = String.Empty
        Phone = String.Empty
        Credentials = New Credentials
        Registration = New Date
        Subscription = Nothing
        Newsletters = False
        AccountType = AccountType.USER
        AccountPlan = AccountPlan.DEMO
        SessionStatus = SessionStatus.OFFLINE
        ReferralCode = String.Empty
        IdToken = String.Empty
        IsVerified = False
    End Sub

    ''' <summary>
    ''' Sets current user properties given specified json object that contains user properties information
    ''' </summary>
    ''' <param name="json">JObject</param>
    ''' <see cref="JObject"/>
    Public Overrides Sub FromJson(json As JObject)
        MyBase.FromJson(json)
        With json
            Location = New GeoLocation(json)
            FiscalCode = If(Not IsNothing(.SelectToken("fiscal_code")), .SelectToken("fiscal_code"), "")
            Phone = If(Not IsNothing(.SelectToken("phone")), .SelectToken("phone"), "")
            Credentials = New Credentials(json)
            Registration = If(Not IsNothing(.SelectToken("registration")), StringToShortDate(.SelectToken("registration")), New Date())
            Dim s As String = If(Not IsNothing(.SelectToken("subscription")), .SelectToken("subscription"), "")
            Subscription = If(Not String.IsNullOrEmpty(s) AndAlso Not s.Equals("null"), StringToShortDate("subscription"), Nothing)
            Newsletters = Not IsNothing(.SelectToken("newsletters")) AndAlso Integer.Parse(.SelectToken("newsletters"), Globalization.NumberStyles.Integer).Equals(1)
            AccountType = If(Not IsNothing(.SelectToken("account_type")), Integer.Parse(.SelectToken("account_type")), AccountType.USER)
            AccountPlan = If(Not IsNothing(.SelectToken("account_plan")), Integer.Parse(.SelectToken("account_plan")), AccountPlan.DEMO)
            SessionStatus = If(Not IsNothing(.SelectToken("session_status")), Integer.Parse(.SelectToken("session_status")), SessionStatus.OFFLINE)
            ReferralCode = If(Not IsNothing(.SelectToken("referral_code")), .SelectToken("referral_code"), "")
            IdToken = If(Not IsNothing(.SelectToken("id_token")), .SelectToken("id_token"), "")
            IsVerified = Not IsNothing(.SelectToken("verified")) AndAlso Integer.Parse(.SelectToken("verified"), Globalization.NumberStyles.Integer).Equals(1)
        End With
    End Sub

#End Region ' Fine Regions Subs

#Region "Events"

#Region "Location Events"

    Public Sub OnLocationChanged(ByVal sender As Object, ByVal e As String) Handles mLocation.AddressChanged,
            mLocation.StreetNumberChanged,
            mLocation.CityChanged,
            mLocation.CountryChanged,
            mLocation.ZipCodeChanged,
            mLocation.RegionChanged,
            mLocation.ProvinceChanged,
            mLocation.FormattedAddressChanged,
            mLocation.LatitudeChanged,
            mLocation.LongitudeChanged,
            mLocation.PlaceIdChanged
        RaiseEvent LocationChanged(Me, sender)
    End Sub

#End Region ' End Location Events

#Region "Credentials events"

    Public Sub OnCredentialsChanged(ByVal sender As Object, ByVal e As String) Handles mCredentials.EmailChanged, mCredentials.UsernameChanged, mCredentials.PasswordChanged
        RaiseEvent credentialsChanged(Me, sender)
    End Sub

#End Region ' End Credentials events

    Public Event LocationChanged(ByVal sender As Object, ByVal location As GeoLocation) Implements IUser.LocationChanged
    Public Event credentialsChanged(ByVal sender As Object, ByVal credentials As Credentials) Implements IUser.CredentialsChanged
    Public Event FiscalCodeChanged(ByVal sender As Object, ByVal fiscalCode As String) Implements IUser.FiscalCodeChanged
    Public Event PhoneChanged(ByVal sender As Object, ByVal phone As String) Implements IUser.PhoneChanged
    Public Event RegistrationChanged(ByVal sender As Object, ByVal registration As Date) Implements IUser.RegistrationChanged
    Public Event SubscriptionChanged(ByVal sender As Object, ByVal subscription As EventArgs) Implements IUser.SubscriptionChanged
    Public Event NewslettersChanged(ByVal sender As Object, ByVal newsletters As Boolean) Implements IUser.NewslettersChanged
    Public Event AccountTypeChanged(ByVal sender As Object, ByVal accountType As AccountType) Implements IUser.AccountTypeChanged
    Public Event AccountPlanChanged(ByVal sender As Object, ByVal accountPlan As AccountPlan) Implements IUser.AccountPlanChanged
    Public Event SessionStatusChanged(ByVal sender As Object, ByVal sessionStatus As SessionStatus) Implements IUser.SessionStatusChanged
    Public Event ReferralCodeChanged(ByVal sender As Object, ByVal referralCode As String) Implements IUser.ReferralCodeChanged
    Public Event idTokenChanged(ByVal sender As Object, ByVal idToken As String) Implements IUser.idTokenChanged
    Public Event IsVerifiedChanged(ByVal sender As Object, ByVal isVerified As Boolean) Implements IUser.IsVerifiedChanged

#End Region ' Fine Events

End Class
