Imports System.Windows.Forms
''' <summary>
''' MessageSplash class
''' <para>Created by Antonino Razeti on August 08, 2020</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of MessageSplash object</para>
''' <para>Implements IMessageSplash</para>
''' </summary>
Public Class MessageSplash

#Region "Enumeration"

    Public Enum DisplayMode
        NORMAL = 0
        TOAST = 1
    End Enum

#End Region ' End Enumeration

#Region "Private Declarations"

    Friend WithEvents MessageTimer As Timer
    Private mCounter As Integer = 0
    Private Duration As Integer = My.Settings.MessageSplashTimer / 1000
    Private Type As MsgBoxStyle

#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"

    ''' <summary>
    ''' Gets or sets Counter
    ''' </summary>
    ''' <returns>Integer</returns>
    Private Property Counter() As Integer
        Get
            Return mCounter
        End Get
        Set(ByVal value As Integer)
            mCounter = value
            If Counter = Duration Then
                Me.Close()
            End If
        End Set
    End Property

#End Region ' End Properties

#Region "Constructors"

    ''' <summary>
    ''' Creates a new instance of Message splash form class given message
    ''' </summary>
    ''' <param name="message">String</param>
    Public Sub New(message As String, Optional type As MsgBoxStyle = MsgBoxStyle.Critical, Optional displayMode As DisplayMode = DisplayMode.NORMAL)
        InitializeComponent()
        MessageLabel.Text = message
        Text = My.Application.Info.ProductName
        Me.Type = type
        FormBorderStyle = If(displayMode = DisplayMode.NORMAL, FormBorderStyle.Sizable, FormBorderStyle.None)
        BackColor = If(displayMode = DisplayMode.NORMAL, Drawing.SystemColors.Control, Drawing.SystemColors.ControlDark)
        ForeColor = If(displayMode = DisplayMode.NORMAL, ForeColor, Drawing.Color.White)
        Region = BorderRadius(Size)
    End Sub

#End Region ' End Constructors

#Region "Subs"

    ''' <summary>
    ''' Stop and dispose the timer
    ''' </summary>
    Private Sub StopTimer()
        If Not IsNothing(MessageTimer) Then
            MessageTimer.Stop()
            MessageTimer.Enabled = False
            MessageTimer.Dispose()
        End If
    End Sub

    Public Overloads Sub Show()
        MyBase.Show()
        If Not IsNothing(Type) Then
            PlaySound(Type)
        End If
    End Sub

#End Region ' Fine Regions Subs

#Region "Events"

    Private Sub MessageTimer_Tick(sender As Object, e As EventArgs) Handles MessageTimer.Tick
        Counter += 1
    End Sub

    Private Sub MessageSplash_Load(sender As Object, e As EventArgs) Handles Me.Load
        MessageTimer = New Timer With {.Interval = 1000, .Enabled = True}
    End Sub

    Private Sub MessageSplash_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        StopTimer()
    End Sub

#End Region ' Fine Events


End Class