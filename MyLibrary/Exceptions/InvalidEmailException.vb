''' <summary>
''' InvalidEmailException class
''' <para>Created by Antonino Razeti on January 26, 2021</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of InvalidEmailException object</para>
''' <para>Implements IInvalidEmailException</para>
''' </summary>
Public Class InvalidEmailException
    Inherits ExceptionBase

#Region "Getters and Setters"

    ''' <summary>
    ''' Gets the message of current exception
    ''' </summary>
    ''' <returns>String</returns>
    Public Overrides ReadOnly Property GetMessage As String
        Get
            Return GetMessage("invalid_email")
        End Get
    End Property

#End Region ' End Getters and Setters

End Class
