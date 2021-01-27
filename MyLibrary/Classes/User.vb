''' <summary>
''' User class
''' <para>Created by Antonino Razeti on January 26, 2021</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of User object</para>
''' <para>Implements IUser</para>
''' </summary>
Public Class User
    Inherits Database
    Implements IUser

#Region "Private Declarations"

    Private mLocation As GeoLocation
    Private mFiscalCode As String
    Private mPhone As String
    Friend WithEvents mCredentials As Credentials

#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"

    ''' <summary>
    ''' Gets or sets Location
    ''' </summary>
    ''' <returns>GeoLocation</returns>
    Public Property Location() As GeoLocation Implements IUser.Location
        Get
            Return mLocation
        End Get
        Set(ByVal value As GeoLocation)
            mLocation = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets FiscalCode
    ''' </summary>
    ''' <returns>String</returns>
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
            Return mCredentials
        End Get
        Set(ByVal value As Credentials)
            mCredentials = value
        End Set
    End Property

#End Region ' End Properties

#Region "Constructors"


#End Region ' End Constructors

#Region "Functions"


#End Region ' Fine Regione Functions

#Region "Subs"


#End Region ' Fine Regions Subs

#Region "Events"


#End Region ' Fine Events


End Class
