Public Class Form1
    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim g As New GeoLocation With {
            .Address = "Via Serradifalco",
            .StreetNumber = "204",
            .City = "Palermo",
            .Country = "Italy",
            .ZipCode = "90145"
        }
        Dim r = Await g.FindCoordinatesAsync()
        If r Then
            MyTextBox1.Text = g.Latitude
        End If
    End Sub
End Class