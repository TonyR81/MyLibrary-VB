Imports Newtonsoft.Json.Linq

Public Class ModernMain

#Region "Private Declarations"

    Public Shared User As User

#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"


#End Region ' End Properties

#Region "Constructors"

    ''' <summary>
    ''' Creates a new instance of ModernMain given a json object that containts user in json object format
    ''' </summary>
    ''' <param name="json">JObject</param>
    Public Sub New(json As JObject)
        InitializeComponent()
        Dim accountType As AccountType = Integer.Parse(json.SelectToken("account_type"))
        Select Case accountType
            Case AccountType.SUPERADMIN
                ' TODO Implementare codice SuperAdmin
            Case AccountType.ADMIN
                User = New User(json)
            Case AccountType.COMPANY
                User = New Company(json)
            Case AccountType.EMPLOYEE
                User = New Employee(json)
            Case AccountType.CUSTOMER
                User = New Customer(json)
        End Select
    End Sub

    ''' <summary>
    ''' Creates a new instance of ModernMain class given the user
    ''' </summary>
    ''' <param name="aUser">User</param>
    Public Sub New(aUser As User)
        InitializeComponent()
        User = aUser
    End Sub

#End Region ' End Constructors

#Region "Functions"


#End Region ' Fine Regione Functions

#Region "Subs"

    ''' <summary>
    ''' Translate current form
    ''' </summary>
    Protected Overrides Sub Translate()
        MyBase.Translate()
    End Sub

#End Region ' Fine Regions Subs

#Region "Events"


#End Region ' Fine Events


End Class