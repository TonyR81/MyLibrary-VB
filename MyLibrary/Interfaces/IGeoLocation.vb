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

        Property Status As Status

#End Region ' End Getters and Setters

#Region "Functions"

        Function GetInt() As Integer

#End Region ' End Functions

#Region "Events"

        Event StatusChanged(sender As Object, e As Status)

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
    Sub Initialize()

#End Region ' End Properties

End Interface
