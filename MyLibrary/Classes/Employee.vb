''' <summary>
''' Employee class
''' <para>Created by Antonino Razeti on January 29, 2021</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of Employee object</para>
''' <para>Implements IEmployee</para>
''' </summary>
Public Class Employee
    Inherits Person
    Implements IEmployee

#Region "Private Declarations"


#End Region ' Fine Regions Private Declarations	

#Region "Getters and Setters"


#End Region ' End Properties

#Region "Constructors"


#End Region ' End Constructors

#Region "Functions"


#End Region ' Fine Regione Functions

#Region "Subs"

    ''' <summary>
    ''' Initialize current employee class
    ''' </summary>
    Protected Friend Overrides Sub Initialize()
        MyBase.Initialize()
        AccountType = AccountType.EMPLOYEE
    End Sub

#End Region ' Fine Regions Subs

#Region "Events"


#End Region ' Fine Events


End Class
