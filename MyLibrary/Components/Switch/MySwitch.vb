Imports System.ComponentModel
''' <summary>
''' MySwitch class
''' <para>Created by Antonino Razeti on September 28, 2020</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of MySwitch object</para>
''' <para>Implements IMySwitch</para>
''' </summary>
Public Class MySwitch


#Region "Private Declarations"


#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"

    ''' <summary>
    ''' Gets or sets HasText
    ''' </summary>
    ''' <returns>Boolean</returns>
    <DefaultValue(True)>
    Public Property HasText() As Boolean
        Get
            Return LabelText.Visible
        End Get
        Set(ByVal value As Boolean)
            LabelText.Visible = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets Text
    ''' </summary>
    ''' <returns>String</returns>
    Public Property SwitchText() As String
        Get
            Return LabelText.Text
        End Get
        Set(ByVal value As String)
            LabelText.Text = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets if current switch is checked
    ''' </summary>
    ''' <returns>Boolean</returns>
    <DefaultValue(False)>
    Public Property Checked As Boolean
        Get
            Return Switch.Checked
        End Get
        Set(value As Boolean)
            Switch.Checked = value
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

    Private Sub LabelText_Click(sender As Object, e As EventArgs) Handles LabelText.Click
        Switch.PerformClick()
    End Sub

#End Region ' Fine Events

End Class
