''' <summary>
''' Person interface
''' <para>Created by Antonino Razeti on January 28, 2021</para>
''' <para>Version 1.0</para>
''' <para> Person Interface that contains all the properties, 
''' methods and functions of the Person class</para>
''' </summary>
Public Interface IPerson

#Region "Getters and Setters"

    Property LastName As String
    Property FirstName As String
    Event LastNameChanged(sender As Object, lastName As String)
    Event FirstNameChanged(sender As Object, firstName As String)

#End Region ' End Getters and Setters

#Region "Events"


#End Region ' End Events

End Interface
