''' <summary>
''' Database interface
''' <para>Created by Antonino Razeti on January 27, 2021</para>
''' <para>Version 1.0</para>
''' <para> Database Interface that contains all the properties, 
''' methods and functions of the Database class</para>
''' </summary>
Public Interface IDatabase
    Inherits IServerRequestHelper

#Region "Getters and Setters"

    Property Id As Integer
    Property IdParent As Integer

#End Region ' End Getters and Setters

#Region "Events"

    Event IdChanged(sender As Object, id As Integer)
    Event IdParentChanged(sender As Object, idParent As Integer)

#End Region ' End Events

End Interface
