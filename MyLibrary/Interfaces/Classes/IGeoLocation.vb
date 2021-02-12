''' <summary>
''' GeoLocation interface
''' <para>Created by Antonino Razeti on January 26, 2021</para>
''' <para>Version 1.0</para>
''' <para> GeoLocation Interface that contains all the properties, 
''' methods and functions of the GeoLocation class</para>
''' </summary>
Public Interface IGeoLocation
    Inherits IServerRequestHelper

#Region "Interfaces"

    Public Interface ILocationStatus

#Region "Getters and Setters"

        Property Status As GeoLocationStatus

#End Region ' End Getters and Setters

#Region "Functions"

        Function GetInt() As Integer

#End Region ' End Functions

#Region "Events"

        Event StatusChanged(sender As Object, e As GeoLocationStatus)

#End Region ' End Events

    End Interface

#End Region ' End interface

#Region "Getters and Setters"

    Property Address As String
    Property StreetNumber As String
    Property City As String
    Property Country As String
    Property ZipCode As String
    Property Latitude As String
    Property Longitude As String
    Property FormattedAddress As String
    Property Status As ILocationStatus
    Property Province As String
    Property Region As String
    Property PlaceId As String
    Property Municipality As String

#End Region ' End Properties

#Region "Events"

    Event AddressChanged(sender As Object, address As String)
    Event StreetNumberChanged(sender As Object, streetNumber As String)
    Event CityChanged(sender As Object, city As String)
    Event CountryChanged(sender As Object, country As String)
    Event ZipCodeChanged(ByVal sender As Object, ByVal zipCode As String)
    Event ProvinceChanged(sender As Object, province As String)
    Event RegionChanged(sender As Object, region As String)
    Event LatitudeChanged(sender As Object, latitude As String)
    Event LongitudeChanged(sender As Object, longitude As String)
    Event FormattedAddressChanged(sender As Object, formattedAddress As String)
    Event PlaceIdChanged(sender As Object, placeId As String)
    Event MunicipalityChanged(sender As Object, municipality As String)

#End Region ' End Events

#Region "Subs"

    Sub Initialize()

#End Region ' End Subs

End Interface
