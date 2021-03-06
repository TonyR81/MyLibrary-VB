﻿Imports MyLibrary
Imports Newtonsoft.Json.Linq
''' <summary>
''' Customer class
''' <para>Created by Antonino Razeti on January 27, 2021</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of Customer object</para>
''' <para>Implements ICustomer</para>
''' </summary>
Public Class Customer
    Inherits Person
    Implements ICustomer

#Region "Private Declarations"


#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"


#End Region ' End Properties

#Region "Constructors"

    ''' <summary>
    ''' Creates a new empty instance of Customer class
    ''' </summary>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' Creates a new instance of Customer class given a json object that contains customer properties information
    ''' </summary>
    ''' <param name="json">JObject</param>
    ''' <see cref="JObject"/>
    Public Sub New(json As JObject)
        MyBase.New(json)
    End Sub

    ''' <summary>
    ''' Creates a new instance of Customer class given the id number associated with the Customer into database, 
    ''' the id number associated with the parent of current Customer into database, 
    ''' the last name and first name, the location, fiscal code, 
    ''' phone, the credentials, the registration and subscription day, the boolean value that indicates if newsletters are enabled for current Customer, the account type and plan, 
    ''' the session status, the referral code, the id token to receive notification and the boolean value that indicates if current Customer is verified
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


#End Region ' Fine Regione Functions

#Region "Subs"

    ''' <summary>
    ''' Initialize current customer class
    ''' </summary>
    Protected Friend Overrides Sub Initialize()
        MyBase.Initialize()
        AccountType = AccountType.CUSTOMER
    End Sub

#End Region ' Fine Regions Subs

#Region "Events"


#End Region ' Fine Events

End Class
