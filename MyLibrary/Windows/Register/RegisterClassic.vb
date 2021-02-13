Public Class RegisterClassic

#Region "Private Declarations"


#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"


#End Region ' End Properties

#Region "Constructors"

    ''' <summary>
    ''' Creates a new empty instance of Register class
    ''' </summary>
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Async Sub RegisterClassic_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim r = Await LocationSelector.LoadCountriesAsync

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
        With Language
            LabelLastName.Text = .GetString("person", "last_name")
            LabelFirstName.Text = .GetString("person", "first_name")
            LocationSelector.Translate(Language)
        End With
    End Sub

#End Region ' Fine Regions Subs

#Region "Events"


#End Region ' Fine Events

End Class
