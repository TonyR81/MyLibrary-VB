Imports Newtonsoft.Json.Linq
Imports System.Windows.Forms
Imports System.Drawing
''' <summary>
''' GeoLocationSelector class
''' <para>Created by Antonino Razeti on February 03, 2021</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of GeoLocationSelector object</para>
''' <para>Implements IGeoLocationSelector</para>
''' </summary>
Public Class GeoLocationSelector
    Implements ITranslatable

#Region "Private Declarations"

    Private mGeoLocation As GeoLocation
    Private mCountries As CountriesCollection
    Private Delegate Sub OnSetCountriesDelegate()
    Private OnSetCountries As New OnSetCountriesDelegate(AddressOf SetCountries)

#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"

    ''' <summary>
    ''' Gets or sets GeoLocation
    ''' </summary>
    ''' <returns>GeoLocation</returns>
    Public Property GeoLocation() As GeoLocation
        Get
            Return mGeoLocation
        End Get
        Set(ByVal value As GeoLocation)
            mGeoLocation = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets Countries
    ''' </summary>
    ''' <returns>CountriesCollection</returns>
    Private Property Countries() As CountriesCollection
        Get
            Return mCountries
        End Get
        Set(ByVal value As CountriesCollection)
            mCountries = value
            Invoke(OnSetCountries)
        End Set
    End Property

    ''' <summary>
    ''' Gets the selected country of current selector
    ''' </summary>
    ''' <returns>Country</returns>
    Public ReadOnly Property SelectedCountry As Country
        Get
            Return If(ComboCountry.SelectedIndex = -1 OrElse IsNothing(Countries) OrElse String.IsNullOrEmpty(ComboCountry.Text), Nothing, Countries.Items(ComboCountry.SelectedIndex))
        End Get
    End Property

    ''' <summary>
    ''' Check if current location is valid
    ''' </summary>
    ''' <returns>Boolean</returns>
    Public ReadOnly Property IsValid() As Boolean
        Get
            Return (GroupBoxLocation.Controls.OfType(Of ComboBox).Where(Function(x) String.IsNullOrEmpty(x.Text)).Count = 0) AndAlso
                (GroupBoxLocation.Controls.OfType(Of TextBox).Where(Function(x) String.IsNullOrEmpty(x.Text)).Count = 0)
        End Get
    End Property

#End Region ' End Properties

#Region "Constructors"

    ''' <summary>
    ''' Creates a new instance of GeoLocationSelector class
    ''' </summary>
    Public Sub New()
        InitializeComponent()
        GeoLocation = New GeoLocation()
        ComboCountry.BackColor = Color.White
        ComboRegion.BackColor = Color.White
        ComboProvince.BackColor = Color.White
        ComboMunicipality.BackColor = Color.White
    End Sub

#End Region ' End Constructors

#Region "Functions"

    ''' <summary>
    ''' Load countries, in async mode, from server or local database in json object format
    ''' </summary>
    ''' <returns>Task(Of Jobject)</returns>
    Public Async Function LoadCountriesAsync() As Task(Of JObject)
        Return Await Task.Run(Function() LoadCountries())
    End Function

    ''' <summary>
    ''' Load countries from server or local database in json object format
    ''' </summary>
    ''' <returns>JObject</returns>
    Public Function LoadCountries() As JObject
        Try
            Dim request As New ServerRequest("load_countries")
            Dim post As String = String.Format("language={0}", My.Settings.Language)
            Dim response As JObject = request.GetResponse(post)
            If Not IsNothing(response) Then
                If Not IsNothing(response.SelectToken("countries")) Then
                    Countries = New CountriesCollection(response.SelectToken("countries"))
                End If
            End If
        Catch ex As Exception
            Dim m As New MessageSplash(ex.Message, MsgBoxStyle.Critical, MessageSplash.DisplayMode.TOAST) With {.TopMost = True}
            m.Show()
        End Try
        Return Nothing
    End Function

#End Region ' Fine Regione Functions

#Region "Subs"

    ''' <summary>
    ''' Set the countries into combobox
    ''' </summary>
    Private Sub SetCountries()
        ComboCountry.Items.Clear()
        ComboCountry.Items.AddRange(Countries.GetNames())
    End Sub

    ''' <summary>
    ''' Translate current component with the specified language
    ''' </summary>
    ''' <param name="language">Language</param>
    Public Sub Translate(language As Language) Implements ITranslatable.Translate
        With language
            GroupBoxLocation.Text = .GetString("location", "title")
            LabelAddress.Text = .GetString("location", "address")
            LabelStreetNumber.Text = .GetString("location", "street_number")
            LabelCountry.Text = .GetString("location", "country")
            LabelRegion.Text = .GetString("location", "region")
            LabelProvince.Text = .GetString("location", "province")
            LabelMunicipality.Text = .GetString("location", "municipality")
            LabelZipCode.Text = .GetString("location", "zip_code")
        End With
    End Sub

#End Region ' Fine Regions Subs

#Region "Events"

    Private Sub ClearAll()
        For Each combo As ComboBox In Me.Controls.OfType(Of ComboBox)
            combo.Items.Clear()
            combo.SelectedIndex = -1
        Next
    End Sub

    Private Sub ComboCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboCountry.SelectedIndexChanged
        ClearAll()
        If ComboCountry.SelectedIndex > -1 Then
            ComboRegion.Items.AddRange(Countries.GetRegions(ComboCountry.SelectedIndex).GetNames)
        End If
    End Sub

    Private Sub ComboRegion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboRegion.SelectedIndexChanged
        If ComboRegion.SelectedIndex > -1 Then
            ComboProvince.Items.Clear()
            ComboMunicipality.Items.Clear()
            TxtAddress.Text = String.Empty
            TxtStreetNumber.Text = String.Empty
            TxtZipCode.Text = String.Empty
            ComboProvince.Items.AddRange(Countries.GetRegions(ComboCountry.SelectedIndex).GetProvinces(ComboRegion.SelectedIndex).GetNames())
        End If
    End Sub

    Private Sub ComboMunicipality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboMunicipality.SelectedIndexChanged
        If ComboMunicipality.SelectedIndex > -1 Then
            TxtAddress.Text = String.Empty
            TxtStreetNumber.Text = String.Empty
            TxtZipCode.Text = String.Empty
        End If
    End Sub

    Private Sub ComboProvince_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboProvince.SelectedIndexChanged
        If ComboProvince.SelectedIndex > -1 Then
            ComboMunicipality.Items.Clear()
            TxtAddress.Text = String.Empty
            TxtStreetNumber.Text = String.Empty
            TxtZipCode.Text = String.Empty
            ComboMunicipality.Items.AddRange(Countries.GetRegions(ComboCountry.SelectedIndex).GetProvinces(ComboRegion.SelectedIndex).GetMunicipalities(ComboProvince.SelectedIndex).GetNames())
        End If
    End Sub

#End Region ' Fine Events

End Class
