''' <summary>
''' Switch class
''' <para>Created by Antonino Razeti on June 05, 2020</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of Switch object</para>
''' <para>Implements ISwitch</para>
''' </summary>
Public Class Switch


#Region "Private Declarations"

    Private mChecked As Boolean

#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"

    ''' <summary>
    ''' Gets or sets Checked
    ''' </summary>
    ''' <returns>Boolean</returns>
    Public Property Checked() As Boolean
        Get
            Return mChecked
        End Get
        Set(ByVal value As Boolean)
            mChecked = value
            BtnSwitch.Image = If(Checked, My.Resources.switch_on, My.Resources.switch_off)
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

    Public Sub SwitchClick() Handles BtnSwitch.Click
        Checked = If(Checked, False, True)
        RaiseEvent OnSwitchClick(Me, Checked)
    End Sub

    Public Event OnSwitchClick(ByVal sender As Object, ByVal switch As Boolean)

    Public Sub PerformClick()
        SwitchClick()
    End Sub

#End Region ' Fine Events


End Class
