Imports System.Windows.Forms

Public Class AmountNumericUpDown

#Region "Constructors"

    ''' <summary>
    ''' Creates a new empty instance of AmountNumericUpDown
    ''' </summary>
    Public Sub New()
        InitializeComponent()
    End Sub

#End Region ' End Constructors

#Region "Events"

    Private Sub ImportoNumericUpDown_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Dim keyAscii As Single = AscW(e.KeyChar)
        ' Intercetta eventuale digitazione 
        ' del punto e la sostituisce con la virgola
        If keyAscii = 46 Then
            e.KeyChar = Chr(44)
        End If
    End Sub

    Private Sub ImportoNumericUpDown_Enter(sender As Object, e As EventArgs) Handles Me.Enter
        Dim s As String = Replace(FormatCurrency(Me.Value, 3), "€ ", "")
        Me.Select(0, s.Length)
    End Sub

#End Region ' Fine Events

End Class
