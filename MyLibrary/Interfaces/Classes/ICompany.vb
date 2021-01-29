''' <summary>
''' Company interface
''' <para>Created by Antonino Razeti on January 28, 2021</para>
''' <para>Version 1.0</para>
''' <para> Company Interface that contains all the properties, 
''' methods and functions of the Company class</para>
''' </summary>
Public Interface ICompany

#Region "Getters and Setters"

    Property Name As String
    Property BusinessName As String
    Property VatNumber As String
    Property Website As String

#End Region ' End Properties

#Region "Events"

    Event NameChanged(sender As Object, name As String)
    Event BusinessNameChanged(sender As Object, businessName As String)
    Event VatNumberChanged(sender As Object, vatNumber As String)
    Event WebsiteChanged(sender As Object, website As String)

#End Region ' Fine Events

End Interface
