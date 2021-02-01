''' <summary>
''' ServerConnectionException class
''' <para>Created by Antonino Razeti on February 01, 2021</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of ServerConnectionException object</para>
''' <para>Implements IServerConnectionException</para>
''' </summary>
Public Class ServerConnectionException
    Inherits ExceptionBase

#Region "Getters and Setters"

    ''' <summary>
    ''' Gets the message of current exception
    ''' </summary>
    ''' <returns>String</returns>
    Public Overrides ReadOnly Property GetMessage() As String
        Get
            Return GetMessage("server_connection")
        End Get
    End Property

#End Region ' End Properties

End Class
