''' <summary>
''' NumericCharacterException class
''' <para>Created by Antonino Razeti on January 28, 2021</para>
''' <para>Version 1.0</para>
''' <para> This class contains properties, methods and functions of NumericCharacterException object</para>
''' <para>Implements INumericCharacterException</para>
''' </summary>
Public Class NumericCharacterException
    Inherits ExceptionBase

#Region "Getters and Setters"

    ''' <summary>
    ''' Gets the message of current exception
    ''' </summary>
    ''' <returns>String</returns>
    Public Overrides ReadOnly Property GetMessage As String
        Get
            Return GetMessage("numeric_character")
        End Get
    End Property

#End Region ' End Getters and Setters

End Class
