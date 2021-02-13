Imports System.ComponentModel
Imports System.Text
Imports Newtonsoft.Json.Linq

Public Class GeoLocation
    Implements IGeoLocation

#Region "Private declarations"

    Private mCountry As String
    Private mRegion As String
    Private mProvince As String
    Private mCity As String
    Private mAddress As String
    Private mStreetNumber As String
    Private mZipCode As String
    Private mFormattedAddress As String
    Private mLatitude As String
    Private mLongitude As String
    Private mStatus As LocationStatus
    Private mPlaceId As String

#End Region ' End Private Declarations

#Region "Getters and Setters"

    ''' <summary>
    ''' Gets or sets the address of current GeoLocation
    ''' </summary>
    ''' <returns>String</returns>
    <DefaultValue(""), Category("Properties")>
    Public Property Address() As String Implements IGeoLocation.Address
        Get
            Return mAddress
        End Get
        Set(ByVal value As String)
            mAddress = value
            RaiseEvent AddressChanged(Me, value)
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the street number of current GeoLocation
    ''' </summary>
    ''' <returns>String</returns>
    <DefaultValue(""), Category("Properties")>
    Public Property StreetNumber() As String Implements IGeoLocation.StreetNumber
        Get
            Return mStreetNumber
        End Get
        Set(ByVal value As String)
            mStreetNumber = value
            RaiseEvent StreetNumberChanged(Me, value)
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the city of current GeoLocation
    ''' </summary>
    ''' <returns>String</returns>
    <DefaultValue(""), Category("Properties")>
    Public Property City() As String Implements IGeoLocation.City
        Get
            Return mCity
        End Get
        Set(ByVal value As String)
            mCity = value
            RaiseEvent CityChanged(Me, value)
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the country of current GeoLocation
    ''' </summary>
    ''' <returns>String</returns>
    <DefaultValue(""), Category("Properties")>
    Public Property Country() As String Implements IGeoLocation.Country
        Get
            Return mCountry
        End Get
        Set(ByVal value As String)
            mCountry = value
            RaiseEvent CountryChanged(Me, value)
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets Province
    ''' </summary>
    ''' <returns>String</returns>
    <DefaultValue(""), Category("Properties")>
    Public Property Province() As String Implements IGeoLocation.Province
        Get
            Return mProvince
        End Get
        Set(ByVal value As String)
            mProvince = value
            RaiseEvent ProvinceChanged(Me, value)
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets Region
    ''' </summary>
    ''' <returns>String</returns>
    <DefaultValue(""), Category("Properties")>
    Public Property Region() As String Implements IGeoLocation.Region
        Get
            Return mRegion
        End Get
        Set(ByVal value As String)
            mRegion = value
            RaiseEvent RegionChanged(Me, value)
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the zip code of current GeoLocation
    ''' </summary>
    ''' <returns>String</returns>
    <DefaultValue(""), Category("Properties")>
    Public Property ZipCode() As String Implements IGeoLocation.ZipCode
        Get
            Return mZipCode
        End Get
        Set(ByVal value As String)
            mZipCode = value
            RaiseEvent ZipCodeChanged(Me, value)
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the formatted address of current GeoLocation
    ''' </summary>
    ''' <returns>String</returns>
    <DefaultValue(""), Category("Properties")>
    Public Property FormattedAddress() As String Implements IGeoLocation.FormattedAddress
        Get
            Return mFormattedAddress
        End Get
        Set(ByVal value As String)
            mFormattedAddress = value
            RaiseEvent FormattedAddressChanged(Me, value)
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the latitude of current GeoLocation
    ''' </summary>
    ''' <returns>String</returns>
    <DefaultValue(""), Category("Properties")>
    Public Property Latitude() As String Implements IGeoLocation.Latitude
        Get
            Return mLatitude
        End Get
        Set(ByVal value As String)
            mLatitude = value
            RaiseEvent LatitudeChanged(Me, value)
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets Longitude
    ''' </summary>
    ''' <returns>String</returns>
    <DefaultValue(""), Category("Properties")>
    Public Property Longitude() As String Implements IGeoLocation.Longitude
        Get
            Return mLongitude
        End Get
        Set(ByVal value As String)
            mLongitude = value
            RaiseEvent LongitudeChanged(Me, value)
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets Status
    ''' </summary>
    ''' <returns>LocationStatus</returns>
    Private Property Status() As IGeoLocation.ILocationStatus Implements IGeoLocation.Status
        Get
            Return mStatus
        End Get
        Set(ByVal value As IGeoLocation.ILocationStatus)
            mStatus = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets CoordinatesFound
    ''' </summary>
    ''' <returns>Boolean</returns>
    Public ReadOnly Property CoordinatesFound() As Boolean
        Get
            Return Not String.IsNullOrEmpty(Latitude) And Not String.IsNullOrEmpty(Longitude)
        End Get
    End Property

    ''' <summary>
    ''' Gets or sets PlaceId
    ''' </summary>
    ''' <returns>String</returns>
    <DefaultValue(""), Category("Properties")>
    Public Property PlaceId() As String Implements IGeoLocation.PlaceId
        Get
            Return mPlaceId
        End Get
        Set(ByVal value As String)
            mPlaceId = value
            RaiseEvent PlaceIdChanged(Me, value)
        End Set
    End Property

#End Region ' End Getters and Setters

#Region "Constructors"

    ''' <summary>
    ''' Creates a new empty instance of GeoLocation class
    ''' </summary>
    Public Sub New()
        Initialize()
    End Sub

    ''' <summary>
    ''' Creates a new instance of GeoLocation class given country, region, province, city, address, street number, zip code, the formatted address, 
    ''' </summary>
    ''' <param name="country">String</param>
    ''' <param name="region">String</param>
    ''' <param name="province">String</param>
    ''' <param name="city">String</param>
    ''' <param name="address">String</param>
    ''' <param name="streetNumber">String</param>
    ''' <param name="zipCode">String</param>
    ''' <param name="latitude">String</param>
    ''' <param name="longitude">String</param>
    Public Sub New(country As String, region As String, province As String, city As String, address As String, streetNumber As String, zipCode As String, latitude As String, longitude As String)
        Me.Address = address
        Me.StreetNumber = streetNumber
        Me.City = city
        Me.Country = country
        Me.Province = province
        Me.Region = region
        Me.ZipCode = zipCode
        FormattedAddress = String.Format("{0}, {1}, {2}, {3}, {4}", address, streetNumber, province, region, country)
        Me.Latitude = latitude
        Me.Longitude = longitude
        If String.IsNullOrEmpty(latitude) Or String.IsNullOrEmpty(longitude) Then
            Task.Run(Function() FindCoordinatesAsync())
        End If
    End Sub

    ''' <summary>
    ''' Creates a new instance of GeoLocation class given specified json object that contains 
    ''' address, street number, city, 
    ''' country, zip code, province, region, 
    ''' latitude, longitude and formatted address properties information
    ''' </summary>
    ''' <param name="json">JSONObject</param>
    ''' <see cref="JObject"/>
    Public Sub New(json As JObject)
        FromJson(json)
    End Sub

#End Region ' End Constructors

#Region "Functions"

    ''' <summary>
    ''' Returns a string that represents the arguments to request the server
    ''' </summary>
    ''' <returns>String</returns>
    Public Function ToPost() As String Implements IGeoLocation.ToPost
        Dim post As New StringBuilder()
        post.Append(String.Format("country={0}&", Country))
        post.Append(String.Format("region={0}&", Region))
        post.Append(String.Format("province={0}&", Province))
        post.Append(String.Format("city={0}&", City))
        post.Append(String.Format("address={0}&", Address))
        post.Append(String.Format("street_number={0}&", StreetNumber))
        post.Append(String.Format("zip_code={0}&", ZipCode))
        post.Append(String.Format("latitude={0}&", Latitude))
        post.Append(String.Format("longitude={0}&", Longitude))
        Return post.ToString
    End Function

    ''' <summary>
    ''' Returns a json object that contains geolocation properties
    ''' </summary>
    ''' <returns>JObject</returns>
    ''' <see cref="JObject"/>
    Public Function ToJson() As JObject Implements IGeoLocation.ToJson
        Return New JObject From {
            {"country", Country},
            {"region", Region},
            {"province", Province},
            {"city", City},
            {"address", Address},
            {"street_number", StreetNumber},
            {"zip_code", ZipCode},
            {"latitude", Latitude},
            {"longitude", Longitude},
            {"formatted_address", FormattedAddress},
            {"place_id", PlaceId}
        }
    End Function

    ''' <summary>
    ''' Find coordinates, latitude and longitude, of current Geolocation, in async mode
    ''' </summary>
    ''' <returns>Task(Of Boolean)</returns>
    Public Async Function FindCoordinatesAsync() As Task(Of Boolean)
        Return Await Task.Run(Function() FindCoordinates())
    End Function

    ''' <summary>
    ''' Find coordinates, latitude and longitude, of current Geolocation
    ''' </summary>
    ''' <returns>Boolean</returns>
    Public Function FindCoordinates() As Boolean
        Return FindCoordinates(Address, StreetNumber, City, Country, ZipCode)
    End Function

    ''' <summary>
    ''' Find coordinates given specified address, street number, city, country and 
    ''' zip code
    ''' </summary>
    ''' <param name="address">String</param>
    ''' <param name="streetNumber">String</param>
    ''' <param name="city">String</param>
    ''' <param name="country">String</param>
    ''' <param name="zipCode">String</param>
    ''' <returns>Boolean</returns>
    Public Async Function FindCoordinatesAsync(address As String, streetNumber As String, city As String, country As String, zipCode As String) As Task(Of Boolean)
        Return Await Task.Run(Function() FindCoordinates(address, streetNumber, city, country, zipCode))
    End Function

    ''' <summary>
    ''' Find coordinates, latitude and longitude, given specified address, street number, 
    ''' city, country and zip code
    ''' </summary>
    ''' <param name="address">String</param>
    ''' <param name="streetNumber">String</param>
    ''' <param name="city">String</param>
    ''' <param name="country">String</param>
    ''' <param name="zipCode">String</param>
    ''' <returns>Boolean</returns>
    Public Function FindCoordinates(address As String, streetNumber As String, city As String, country As String, zipCode As String) As Boolean
        If Not String.IsNullOrEmpty(address) And
            Not String.IsNullOrEmpty(streetNumber) And
            Not String.IsNullOrEmpty(city) Then
            Dim response As JObject = New ServerRequest("location").GetResponseAsync(ToPost).Result
            If Not IsNothing(response) Then
                Dim json As JObject = response.SelectToken("results")(0)
                With json
                    FormattedAddress = .Item("formatted_address")
                    PlaceId = .Item("place_id")
                    Dim geometry As JObject = .Item("geometry")
                    Dim location As JObject = geometry.Item("location")
                    Longitude = location.SelectToken("lng")
                    Latitude = location.SelectToken("lat")
                End With
            End If
        End If
        Return CoordinatesFound
    End Function

#End Region ' End Functions

#Region "Subs"

    ''' <summary>
    ''' Initialize current Geo Location
    ''' </summary>
    Private Sub Initialize() Implements IGeoLocation.Initialize
        Address = String.Empty
        StreetNumber = String.Empty
        City = String.Empty
        Country = String.Empty
        ZipCode = String.Empty
        Region = String.Empty
        Province = String.Empty
        Latitude = String.Empty
        Longitude = String.Empty
        FormattedAddress = String.Empty
        Status = New LocationStatus()
        PlaceId = String.Empty
    End Sub

    ''' <summary>
    ''' Sets current GeoLocation class given specified json object that contains 
    ''' address, street number, city, 
    ''' country, zip code, province, region, 
    ''' latitude, longitude and formatted address properties information
    ''' </summary>
    ''' <param name="json">JObject</param>
    ''' <see cref="JObject"/>
    Private Sub FromJson(json As JObject) Implements IGeoLocation.FromJson
        If Not IsNothing(json) Then
            Address = If(Not IsNothing(json.SelectToken("address")), json.SelectToken("address"), "")
            StreetNumber = If(Not IsNothing(json.SelectToken("street_number")), json.SelectToken("street_number"), "")
            City = If(Not IsNothing(json.SelectToken("city")), json.SelectToken("city"), "")
            Country = If(Not IsNothing(json.SelectToken("country")), json.SelectToken("country"), "")
            Region = If(Not IsNothing(json.SelectToken("region")), json.SelectToken("region"), "")
            Province = If(Not IsNothing(json.SelectToken("province")), json.SelectToken("province"), "")
            ZipCode = If(Not IsNothing(json.SelectToken("zip_code")), json.SelectToken("zip_code"), "")
            FormattedAddress = If(Not IsNothing(json.SelectToken("formatted_address")), json.SelectToken("formatted_address"), "")
            Latitude = If(Not IsNothing(json.SelectToken("latitude")), json.SelectToken("latitude"), "")
            Longitude = If(Not IsNothing(json.SelectToken("longitude")), json.SelectToken("longitude"), "")
            PlaceId = If(Not IsNothing(json.SelectToken("place_id")), json.SelectToken("place_id"), "")
            If String.IsNullOrEmpty(Latitude) Or String.IsNullOrEmpty(Longitude) Then
                Task.Run(Function() FindCoordinatesAsync())
            End If
        End If
    End Sub

#End Region ' End Subs

#Region "Events"

    Public Event AddressChanged(ByVal sender As Object, ByVal address As String) Implements IGeoLocation.AddressChanged
    Public Event StreetNumberChanged(ByVal sender As Object, ByVal streetNumber As String) Implements IGeoLocation.StreetNumberChanged
    Public Event CityChanged(ByVal sender As Object, ByVal city As String) Implements IGeoLocation.CityChanged
    Public Event CountryChanged(ByVal sender As Object, ByVal country As String) Implements IGeoLocation.CountryChanged
    Public Event ZipCodeChanged(ByVal sender As Object, ByVal zipCode As String) Implements IGeoLocation.ZipCodeChanged
    Public Event ProvinceChanged(ByVal sender As Object, ByVal province As String) Implements IGeoLocation.ProvinceChanged
    Public Event RegionChanged(ByVal sender As Object, ByVal region As String) Implements IGeoLocation.RegionChanged
    Public Event LatitudeChanged(ByVal sender As Object, ByVal latitude As String) Implements IGeoLocation.LatitudeChanged
    Public Event LongitudeChanged(ByVal sender As Object, ByVal longitude As String) Implements IGeoLocation.LongitudeChanged
    Public Event FormattedAddressChanged(ByVal sender As Object, ByVal formattedAddress As String) Implements IGeoLocation.FormattedAddressChanged
    Public Event PlaceIdChanged(ByVal sender As Object, ByVal placeId As String) Implements IGeoLocation.PlaceIdChanged

#End Region ' End Events

    ''' <summary>
    ''' LocationStatus class
    ''' <para>Created by Antonino Razeti on January 26, 2021</para>
    ''' <para>Version 1.0</para>
    ''' <para> This class contains properties, methods and functions of LocationStatus object</para>
    ''' <para>Implements ILocationStatus</para>
    ''' </summary>
    Public Class LocationStatus
        Implements IGeoLocation.ILocationStatus

#Region "Private Declarations"

        Private mStatus As GeoLocationStatus
        Private StringValue As String = "ZERO_RESULTS"
        Private IntValue As Integer = 0

#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"

        ''' <summary>
        ''' Gets or sets Status
        ''' </summary>
        ''' <returns>Status</returns>
        <DefaultValue(GeoLocationStatus.ZERO_RESULTS), Category("Properties")>
        Public Property Status() As GeoLocationStatus Implements IGeoLocation.ILocationStatus.Status
            Get
                Return mStatus
            End Get
            Set(ByVal value As GeoLocationStatus)
                mStatus = value
                Select Case value
                    Case GeoLocationStatus.OK
                        SetLocationStatus("OK", 1)
                    Case GeoLocationStatus.REQUEST_DENIED
                        SetLocationStatus("REQUEST_DENIED", 2)
                    Case GeoLocationStatus.ZERO_RESULTS
                        SetLocationStatus("ZERO_RESULTS", 0)
                End Select
                RaiseEvent StatusChanged(Me, value)
            End Set
        End Property

#End Region ' End Properties

#Region "Constructors"

        ''' <summary>
        ''' Creates a new empty instance of LocationStatus class
        ''' </summary>
        Public Sub New()
            Initialize()
        End Sub

        ''' <summary>
        ''' Creates a new instance of LocationStatus class given the specified status
        ''' </summary>
        ''' <param name="status">Status</param>
        Public Sub New(status As GeoLocationStatus)
            Me.Status = status
        End Sub

#End Region ' End Constructors

#Region "Functions"

        ''' <summary>
        ''' Returns the int value of current location status
        ''' </summary>
        ''' <returns>Integer</returns>
        Public Function GetInt() As Integer Implements IGeoLocation.ILocationStatus.GetInt
            Return IntValue
        End Function

        ''' <summary>
        ''' Returns the status of given value
        ''' </summary>
        ''' <param name="value">Integer</param>
        ''' <returns>Status</returns>
        Public Shared Function GetStatus(value As Integer) As GeoLocationStatus
            Dim res As GeoLocationStatus
            Select Case value
                Case 0
                    res = GeoLocationStatus.ZERO_RESULTS
                Case 1
                    res = GeoLocationStatus.OK
                Case 2
                    res = GeoLocationStatus.REQUEST_DENIED
                Case Else
                    res = GeoLocationStatus.ZERO_RESULTS
            End Select
            Return res
        End Function

        ''' <summary>
        ''' Returns the status of given string value
        ''' </summary>
        ''' <param name="value">String</param>
        ''' <returns>Status</returns>
        Public Shared Function GetStatus(value As String) As GeoLocationStatus
            Dim res As GeoLocationStatus
            Select Case value
                Case "ZERO_RESULTS"
                    res = GeoLocationStatus.ZERO_RESULTS
                Case "OK"
                    res = GeoLocationStatus.OK
                Case "REQUEST_DENIED"
                    res = GeoLocationStatus.REQUEST_DENIED
                Case Else
                    res = GeoLocationStatus.ZERO_RESULTS
            End Select
            Return res
        End Function

        ''' <summary>
        ''' Returns a string that represents current location status
        ''' </summary>
        ''' <returns>String</returns>
        Public Overrides Function ToString() As String
            Return StringValue
        End Function

#End Region ' Fine Regione Functions

#Region "Subs"

        ''' <summary>
        ''' Initialize current location status
        ''' </summary>
        Private Sub Initialize()
            Status = GeoLocationStatus.ZERO_RESULTS
        End Sub

        ''' <summary>
        ''' Sets current location status with specified string and int value
        ''' </summary>
        ''' <param name="stringValue">String</param>
        ''' <param name="intValue">Integer</param>
        Private Sub SetLocationStatus(stringValue As String, intValue As Integer)
            Me.StringValue = stringValue
            Me.IntValue = intValue
        End Sub

#End Region ' Fine Regions Subs

#Region "Events"

        Public Event StatusChanged(ByVal sender As Object, ByVal status As GeoLocationStatus) Implements IGeoLocation.ILocationStatus.StatusChanged

#End Region ' Fine Events

    End Class

End Class
