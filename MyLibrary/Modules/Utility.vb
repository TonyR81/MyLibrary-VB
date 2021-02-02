Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports System.Security.Cryptography
Imports System.Text
Imports Newtonsoft.Json.Linq
Imports System.Windows.Forms
Imports System.Drawing
Imports MessagingToolkit.QRCode.Codec
Imports System.Drawing.Imaging

Module Utility

    Public APP_NAME As String = My.Application.Info.ProductName.ToUpper

    Public Const COPYRIGHT As String = "©"
    Public COPYRIGHT_CODE As Char = ChrW(184)
    Public Const REGISTERED_TRADEMARK = "®"
    Public REGISTERED_TRADEMARK_CODE As Char = ChrW(169)
    Public Const TRADEMARK As String = "™"
    Public TRADEMARK_CODE As Char = ChrW(8482)
    Public QUOTATIONS_MARKS As Char = ChrW(34)

#Region "Internet tools"

    ''' <summary>
    ''' Returns a string that represents specified day in following format: yyyy-mm-dd
    ''' </summary>
    ''' <param name="day">Date</param>
    ''' <returns>String</returns>
    Public Function DateToShortString(day As Date) As String
        Return String.Format("{0}-{1}-{2}", day.Year, day.Month, day.Day)
    End Function

    ''' <summary>
    ''' Returns a string that represents specified day in following format: yyyy-mm-dd HH:mm:ss
    ''' </summary>
    ''' <param name="day">Date</param>
    ''' <returns>String</returns>
    Public Function DateToLongString(day As Date) As String
        Return String.Format("{0}-{1}-{2} {3}:{4}:{5}", day.Year, day.Month, day.Day, day.Hour, day.Minute, day.Second)
    End Function

    Public Function DateToShortStringLocal(day As Date) As String
        Return String.Format("#{0}/{1}/{2}#", day.Day, day.Month, day.Year)
    End Function

    ''' <summary>
    ''' Returns a string that represents specified day in following format: yyyy-mm-dd HH:mm:ss
    ''' </summary>
    ''' <param name="day">Date</param>
    ''' <returns>String</returns>
    Public Function DateToLongStringLocal(day As Date) As String
        Return String.Format("#{0}/{1}/{2} {3}:{4}:{5}#", day.Day, day.Month, day.Year, day.Hour, day.Minute, day.Second)
    End Function

    ''' <summary>
    ''' Returns a date from specified day string day in following format: yyyy-mm-dd HH:mm:ss
    ''' </summary>
    ''' <param name="day">String</param>
    ''' <returns>Date</returns>
    Public Function StringToLongDate(day As String) As Date
        Dim s As String() = Split(day, " ")
        Dim d As String() = Split(s(0), "-")
        Dim t As String() = Split(s(1), ":")
        Return New Date(d(0), d(1), d(2), t(0), t(1), t(2))
    End Function

    ''' <summary>
    ''' Returns a short date from specified day string
    ''' </summary>
    ''' <param name="day">Date</param>
    ''' <returns>Date</returns>
    Public Function StringToShortDate(day As String) As Date
        Dim s As String() = Split(day, "-")
        Return New Date(s(0), s(1), s(2))
    End Function

    ''' <summary>
    ''' Check if the email address is valid
    ''' </summary>
    ''' <param name="email">String</param>
    ''' <returns>Boolean</returns>
    Public Function CheckEmail(email As String) As Boolean
        Try
            Dim m As New MailAddress(email)
            Return True
        Catch ex As Exception
            Throw New InvalidEmailException
        End Try
    End Function

    ''' <summary>
    ''' Play the sound for specified type of message box style
    ''' </summary>
    ''' <param name="type">MsgBoxStyle</param>
    Friend Sub PlaySound(type As MsgBoxStyle)
        Select Case type
            Case MsgBoxStyle.Question, MsgBoxStyle.YesNoCancel, MsgBoxStyle.YesNo
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
            Case Else
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Hand)
        End Select
    End Sub

    ''' <summary>
    ''' Send email
    ''' </summary>
    ''' <param name="title">String</param>
    ''' <param name="message">String</param>
    ''' <param name="toEmail">String</param>
    ''' <param name="fromEmail">String</param>
    ''' <param name="credentials">NetworkCredential</param>
    ''' <param name="host">String (example: smtp.gmail.com; smtp.libero.it...)</param>
    ''' <param name="port">Integer</param>
    ''' <returns>Boolean</returns>
    Public Function SendEmail(title As String, message As String, toEmail As String, fromEmail As String, credentials As NetworkCredential, host As String, Optional port As Integer = 587) As Boolean
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = credentials
            Smtp_Server.Port = port
            Smtp_Server.EnableSsl = True
            ' Smtp_Server.Host = "smtp.gmail.com"
            Smtp_Server.Host = host
            e_mail = New MailMessage With {
                .From = New MailAddress(fromEmail)
            }
            e_mail.To.Add(toEmail)
            e_mail.Subject = title
            e_mail.IsBodyHtml = False
            e_mail.Body = message
            Smtp_Server.Send(e_mail)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, APP_NAME)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Send email in async mode
    ''' </summary>
    ''' <param name="title">String</param>
    ''' <param name="message">String</param>
    ''' <param name="toEmail">String</param>
    ''' <param name="fromEmail">String</param>
    ''' <param name="credentials">NetworkCredential</param>
    ''' <param name="host">String (example: smtp.gmail.com; smtp.libero.it...)</param>
    ''' <param name="port">Integer</param>
    ''' <returns>Task(Of Boolean)</returns>
    Public Async Function SendEmailAsync(title As String, message As String, toEmail As String, fromEmail As String, credentials As NetworkCredential, host As String, Optional port As Integer = 587) As Task(Of Boolean)
        Return Await Task.Run(Function() SendEmail(title, message, toEmail, fromEmail, credentials, port))
    End Function

    ''' <summary>
    ''' Check internet connection. If Internet connection is available return true, otherwise throw InternetConnectionException
    ''' </summary>
    ''' <returns>Boolean</returns>
    Public Function CheckInternetConnection() As Boolean
        Try
            Return My.Computer.Network.Ping("www.google.com")
        Catch ex As Exception
            Throw New InternetConnectionException()
        End Try
    End Function

    ''' <summary>
    ''' Generate random username
    ''' </summary>
    ''' <returns>String</returns>
    Public Function UsernameGenerator() As String

        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 8
            Dim idx As Integer = r.Next(0, 35)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString
    End Function

    ''' <summary>
    ''' Returns the IPv4 address
    ''' </summary>
    ''' <returns>String</returns>
    Public Function GetIpAddress() As String
        Return Dns.GetHostEntry(Dns.GetHostName()).AddressList _
    .Where(Function(a As IPAddress) Not a.IsIPv6LinkLocal AndAlso Not a.IsIPv6Multicast AndAlso Not a.IsIPv6SiteLocal) _
    .First() _
    .ToString()
    End Function

    ''' <summary>
    ''' Download file from internet given uri
    ''' </summary>
    Public Sub DownLoadFile(uri As Uri)
        Dim remoteUri As String = "http://belajar123.com/materi.zip"
        Dim fileName As String = "materi.zip"
        Dim password As String = "..."
        Dim username As String = "..."
        Using client As New WebClient()
            client.Credentials = New NetworkCredential(username, password)
            client.DownloadFile(remoteUri, fileName)
        End Using

    End Sub

    Public Sub UploadImage(sourceFileName As String)
        ' JVN2@cc9uMzVGm6
        ' vulloinfo@gmail.com
        ' "https://www.lavanderialapegreen.it/gpricing/includes"

        Try
            My.Computer.Network.UploadFile(sourceFileName, "https://www.lavanderialapegreen.it/gpricing/assets", "vulloinfo@gmail.com", "JVN2@cc9uMzVGm6")
        Catch ex As Exception
            MyMessage(ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' Returns a string to query server database given key and a json object that contains parameters 
    ''' </summary>
    ''' <param name="key">String</param>
    ''' <param name="json">JObject</param>
    ''' <returns>String</returns>
    Public Function JsonToPost(key As String, json As JObject) As String
        Return String.Format("{0}={1}", key, Replace(Newtonsoft.Json.JsonConvert.SerializeObject(json).ToString, "\", ""))
    End Function

#End Region ' End Internet tools

#Region "Files"

    ''' <summary>
    ''' Read file given path
    ''' </summary>
    ''' <param name="file">String</param>
    ''' <returns>String</returns>
    Public Function ReadFile(file As String) As String
        Dim sb As New StringBuilder
        Dim objReader As New StreamReader(file)
        Dim sLine As String = ""
        Dim arrText As New ArrayList()
        Do
            sLine = objReader.ReadLine()
            If Not sLine Is Nothing Then
                sb.AppendLine(sLine)
                'arrText.Add(sLine)
            End If
        Loop Until sLine Is Nothing
        objReader.Close()
        Return sb.ToString
    End Function

    ''' <summary>
    ''' Creates a log
    ''' </summary>
    ''' <param name="args">String()</param>
    Public Sub CreateLog(ParamArray args As String())
        Dim sb As New StringBuilder
        For index As Integer = 1 To args.Count
            Console.WriteLine(args(index - 1))
            sb.Append(args(index - 1) + vbCrLf)
        Next
        With Now
            Dim path As String = IO.Path.Combine(Application.StartupPath, "Files", "Logs")
            If Not Directory.Exists(path) Then
                Directory.CreateDirectory(path)
            End If
            Dim file As String = IO.Path.Combine(Application.StartupPath, "Files", "Logs", String.Format("{0}{1}{2}_{3}{4}{5}", .Year, .Month, .Day, .Hour, .Minute, .Second))
            My.Computer.FileSystem.WriteAllText(String.Format("{0}.txt", file), sb.ToString, False)
        End With
    End Sub

#End Region ' End Files

#Region "Check"

    ''' <summary>
    ''' Check if all required fields are not empty
    ''' </summary>
    ''' <param name="fields">MyTextBox</param>
    ''' <returns>Boolean</returns>
    Public Function CheckRequiredFields(ParamArray fields As TextBox()) As Boolean
        Dim res As Boolean = True
        For Each t As TextBox In fields
            If String.IsNullOrEmpty(t.Text) Then
                Throw New RequiredFieldsException()
            End If
        Next
        Return res
    End Function

#End Region ' End Check

#Region "Windows Forms"

    ''' <summary>
    ''' Gets the max area sizes available for children forms
    ''' </summary>
    ''' <param name="main">Main</param>
    ''' <returns>Size</returns>
    Public Function GetMaxAreaSize(main As Form) As Size
        Dim x, y As Integer
        x = main.Width
        y = main.Height
        For Each item In main.Controls.OfType(Of ToolStrip)
            y -= item.Size.Height
        Next
        x -= 20
        y -= 43
        Return New Size(x, y)
    End Function

    ''' <summary>
    ''' Sets corner radius and returns region
    ''' </summary>
    ''' <param name="cardSize">Size</param>
    ''' <returns>Region</returns>
    Public Function BorderRadius(cardSize As Size) As Region
        Dim radius As New Drawing2D.GraphicsPath
        With radius
            .StartFigure()
            .AddArc(New Rectangle(0, 0, 10, 10), 180, 90)
            .AddLine(10, 0, cardSize.Width - 20, 0)

            .AddArc(New Rectangle(cardSize.Width - 10, 0, 10, 10), -90, 90)
            .AddLine(cardSize.Width, 20, cardSize.Width, cardSize.Height - 10)

            .AddArc(New Rectangle(cardSize.Width - 10, cardSize.Height - 10, 10, 10), 0, 90)
            .AddLine(cardSize.Width - 10, cardSize.Height, 20, cardSize.Height)

            .AddArc(New Rectangle(0, cardSize.Height - 10, 10, 10), 90, 90)
            .CloseFigure()
        End With
        Return New Region(radius)
    End Function

#End Region ' End Windows Forms

#Region "Settings"


#End Region ' End Settings

#Region "Messages"

    ''' <summary>
    ''' Creates a splash message
    ''' </summary>
    ''' <param name="message">String</param>
    Public Sub MyMessage(message As String, Optional type As MsgBoxStyle = Nothing, Optional displayMode As MessageSplash.DisplayMode = MessageSplash.DisplayMode.NORMAL)
        Dim msg As New MessageSplash(message, type, displayMode)
        msg.Show()
    End Sub

#End Region ' End Messages

#Region "Maths"

    ''' <summary>
    ''' Returns the discounted price given initial price and discount value
    ''' </summary>
    ''' <param name="price">Decimal</param>
    ''' <param name="discountValue">Integer</param>
    ''' <returns>Decimal</returns>
    Public Function DiscountedPrice(price As Decimal, discountValue As Integer) As Decimal
        Return price - ((price * discountValue) / 100)
    End Function

    ''' <summary>
    ''' Returns the percentage value of a number
    ''' </summary>
    ''' <param name="n1">Decimal</param>
    ''' <param name="n2">Decimal</param>
    ''' <returns>Decimal</returns>
    Public Function PercentOf(n1 As Decimal, n2 As Decimal) As Decimal
        Return (n1 / n2) * 100
    End Function

#End Region ' End Maths

#Region "Conversions"

#Region "Strings"

    Public Function StringFormat(value As String) As String
        Return String.Format("{0}{1}{2}", ChrW(34), value, ChrW(34))
    End Function

#End Region

#Region "QRCode"

    Public Function QrCodeToString(image As Image) As String
        Dim reader As QRCodeDecoder = New QRCodeDecoder
        Try
            Return reader.decode(New Data.QRCodeBitmapImage(image))
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function QrCodeGenerator(content As String) As Bitmap
        Return New QRCodeEncoder().Encode(content)
    End Function

#End Region ' End QRCode

#Region "Images"

    ''' <summary>
    ''' Returns the extension of specified file name
    ''' </summary>
    ''' <param name="file">String</param>
    ''' <returns>String</returns>
    Public Function GetExtension(file As String) As String
        Dim s As String() = Split(file, ".")
        Return s(s.Count - 1)
    End Function

    Public Function FromImageToBase64String(file As String) As String
        Dim extension As String = GetExtension(file)
        Dim format As ImageFormat = Nothing
        Select Case extension
            Case ".jpg"
                format = ImageFormat.Jpeg
            Case "bmp"
                format = ImageFormat.Bmp
            Case "png"
                format = ImageFormat.Png
            Case "ico"
                format = ImageFormat.Icon
        End Select
        'Read Image File into Image object.
        Dim img As Image = Image.FromFile(file)
        'ImageConverter Class convert Image object to Byte array.
        Dim bytes As Byte() = CType((New ImageConverter()).ConvertTo(img, GetType(Byte())), Byte())
        Return Convert.ToBase64String(bytes, 0, bytes.Length)
    End Function

    ''' <summary>
    ''' Returns the type of extension of specified file name string
    ''' </summary>
    ''' <param name="file">String</param>
    ''' <returns>ExtensionType</returns>
    Public Function GetExtensionType(file As String) As ExtensionType
        Dim extension As ExtensionType = ExtensionType.BITMAP
        Dim s As String = GetExtension(file)
        Select Case s
            Case "bmp"
                extension = ExtensionType.BITMAP
            Case "png"
                extension = ExtensionType.PNG
            Case "jpg", "jpeg"
                extension = ExtensionType.JPG
            Case "ico"
                extension = ExtensionType.ICO
        End Select
        Return extension
    End Function

    ''' <summary>
    ''' Returns the image format of specified file name string
    ''' </summary>
    ''' <param name="file">String</param>
    ''' <returns>ImageFormat</returns>
    Public Function GetImageFormat(file As String) As ImageFormat
        Dim format As ImageFormat = ImageFormat.Bmp
        Select Case GetExtensionType(file)
            Case ExtensionType.BITMAP
                format = ImageFormat.Bmp
            Case ExtensionType.JPG
                format = ImageFormat.Jpeg
            Case ExtensionType.PNG
                format = ImageFormat.Png
            Case ExtensionType.ICO
                format = ImageFormat.Icon
        End Select
        Return format
    End Function

    ''' <summary>
    ''' Returns a base 64 string of specified image
    ''' </summary>
    ''' <param name="image">Image</param>
    ''' <returns>String</returns>
    Public Function ImageToBase64(image As Image) As String
        Dim base64String As String = ""

        Using ms As New MemoryStream()
            image.Save(ms, ImageFormat.Jpeg)
            Dim imageBytes As Byte() = ms.ToArray
            base64String = Convert.ToBase64String(imageBytes)
        End Using
        Return base64String
    End Function

    ''' <summary>
    ''' Converts an image to Base64 string from specified source
    ''' </summary>
    ''' <param name="src">String</param>
    ''' <returns>String</returns>
    Public Function ImageSourceToBase64(ByVal src As String) As String
        Dim base64String As String = ""
        Dim img As Image = Image.FromFile(src)
        Dim format As ImageFormat = GetImageFormat(src)
        Using ms As New MemoryStream()
            img.Save(ms, format)
            Dim imageBytes As Byte() = ms.ToArray
            base64String = Convert.ToBase64String(imageBytes)
            ' Return base64String
        End Using
        Return base64String
    End Function

    ''' <summary>
    ''' Converts a base64 string to image
    ''' </summary>
    ''' <param name="base64Code"></param>
    ''' <returns>Image</returns>
    Public Function Base64ToImage(ByVal base64Code As String) As Bitmap
        Try
            'If Not base64Code.Substring(0, 4).Equals("data") Then
            '    base64Code = "data:image/png;base64," & base64Code
            'End If
            If Not String.IsNullOrEmpty(base64Code) Then
                Dim imageBytes As Byte() = Convert.FromBase64String(Trim(base64Code))
                Dim ms As New MemoryStream(imageBytes, 0, imageBytes.Length)
                Dim tmpImage As Bitmap = Bitmap.FromStream(ms, True)
                Return tmpImage
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Convert specified bitmap image into a base64 string
    ''' </summary>
    ''' <param name="image">Bitmap</param>
    ''' <returns>String</returns>
    Public Function FromImageToString(image As Bitmap) As String
        Dim base64String As String = ""
        Dim format As ImageFormat = ImageFormat.Bmp
        Using ms As New MemoryStream()
            image.Save(ms, format)
            Dim imageBytes As Byte() = ms.ToArray
            base64String = Convert.ToBase64String(imageBytes)
            ' Return base64String
        End Using
        Return base64String
    End Function

    ''' <summary>
    ''' Convert specified bitmap image into a base64 string
    ''' </summary>
    ''' <param name="image">Bitmap</param>
    ''' <returns>Task(Of String)</returns>
    Public Async Function FromImageToStringAsync(image As Bitmap) As Task(Of String)
        Return Await Task.Run(Function() FromImageToString(image))
    End Function

    ''' <summary>
    ''' Decode specified image into a base 64 string in async mode
    ''' </summary>
    ''' <param name="image">Image</param>
    ''' <returns>String</returns>
    Public Function FromImageToString(image As Image) As String
        Dim base64String As String = ""
        Dim format As ImageFormat = ImageFormat.Jpeg
        Using ms As New MemoryStream()
            image.Save(ms, format)
            Dim imageBytes As Byte() = ms.ToArray
            base64String = Convert.ToBase64String(imageBytes) ' "data:image/png;base64," & 
        End Using
        Return base64String
    End Function

    ''' <summary>
    ''' Decode specified image into a base 64 string in async mode
    ''' </summary>
    ''' <param name="image">Image</param>
    ''' <returns>String</returns>
    Public Async Function FromImageToStringAsync(image As Image) As Task(Of String)
        Return Await Task.Run(Function() FromImageToString(image))
    End Function

#End Region ' End Images

#Region "Password"

    ''' <summary>
    ''' Converte la stringa specificata in MD5Hash
    ''' </summary>
    ''' <param name="password">String</param>
    ''' <returns>String</returns>
    Public Function Md5(password As String) As String
        Dim tmpSource() As Byte
        Dim tmpHash() As Byte
        'Create a byte array from source data.
        tmpSource = ASCIIEncoding.ASCII.GetBytes(password)
        'Compute hash based on source data.
        tmpHash = New MD5CryptoServiceProvider().ComputeHash(tmpSource)
        Return ByteArrayToString(tmpHash)
    End Function

    ''' <summary>
    ''' Ritorna la stringa criptata
    ''' </summary>
    ''' <param name="arrInput">Byte</param>
    ''' <returns>String</returns>
    Private Function ByteArrayToString(ByVal arrInput() As Byte) As String
        Dim i As Integer
        Dim sOutput As New StringBuilder(arrInput.Length)
        For i = 0 To arrInput.Length - 1
            sOutput.Append(arrInput(i).ToString("x2"))
        Next
        Return sOutput.ToString()
    End Function

#End Region ' End Password

#Region "Colors"

    ''' <summary>
    ''' Returns a string that represents specified color in argb format
    ''' </summary>
    ''' <param name="color">Color</param>
    ''' <returns>String</returns>
    Public Function FromColorToString(color As Color) As String
        Return String.Format("{0}:{1}:{2}:{3}", color.A, color.R, color.G, color.B)
    End Function

    ''' <summary>
    ''' Returns a Color from a string in argb format
    ''' </summary>
    ''' <param name="c">String</param>
    ''' <returns>Color</returns>
    Public Function FromStringToColor(c As String) As Color
        Dim s As String() = Split(c, ":")
        Return If(String.IsNullOrEmpty(c), Color.Transparent, Color.FromArgb(s(0), s(1), s(2), s(3)))
    End Function

    Friend Function ImageToBytes(image As Image) As Byte()
        Return CType((New ImageConverter()).ConvertTo(image, GetType(Byte())), Byte())
    End Function

#End Region ' Fine Regione Colore

#End Region ' End Conversions

End Module
