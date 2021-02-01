Public Class WrongCredentialsException
    Inherits ExceptionBase

#Region "Getters and Setters"

    ''' <summary>
    ''' Gets the message of current exception
    ''' </summary>
    ''' <returns>String</returns>
    Public Overrides ReadOnly Property GetMessage As String
        Get
            Return GetMessage("wrong_credentials")
        End Get
    End Property

#End Region ' End Getters and Setters

End Class
