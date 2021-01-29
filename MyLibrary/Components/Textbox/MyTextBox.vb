Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
''' <summary>
''' MyTextBox Class. Componente textbox personalizzato
''' </summary>
Public Class MyTextBox

#Region "Dichiarazioni Private"

    Private mAcceptedCharacters As AcceptedCharacters
    Private mEmptyBackColor As Color
    Private mFillBackColor As Color
    Private mLanguage As Language
    Private mMenuEnabled As Boolean

#End Region ' Fine Regione Dichiarazioni Private

#Region "Proprietà"

    ''' <summary>
    ''' Ottiene o imposta il tipo di caratteri accettati
    ''' </summary>
    ''' <returns>AcceptedCharacters</returns>	  
    Public Property AcceptedCharacters() As AcceptedCharacters
        Get
            Return mAcceptedCharacters
        End Get
        Set(ByVal value As AcceptedCharacters)
            mAcceptedCharacters = value
            RaiseEvent AcceptedCharactersChanged(Me, value)
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets color when the textbox is empty
    ''' </summary>
    ''' <returns>Color</returns>
    Public Property EmptyBackColor() As Color
        Get
            Return mEmptyBackColor
        End Get
        Set(ByVal value As Color)
            mEmptyBackColor = value
            Me.BackColor = If(String.IsNullOrEmpty(Me.Text), value, BackColor)
            RaiseEvent EmptyBackColorChanged(Me, value)
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets color when the textbox is not empty
    ''' </summary>
    ''' <returns>Color</returns>
    Public Property FillBackColor() As Color
        Get
            Return mFillBackColor
        End Get
        Set(ByVal value As Color)
            mFillBackColor = value
            Me.BackColor = If(Not String.IsNullOrEmpty(Me.Text), value, BackColor)
            RaiseEvent FillBackColorChanged(Me, value)
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets Language
    ''' </summary>
    ''' <returns>Language</returns>
    Public Property Language() As Language
        Get
            Return mLanguage
        End Get
        Set(ByVal value As Language)
            mLanguage = value
            If Not IsNothing(value) Then
                Translate()
            End If
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets MenuEnabled
    ''' </summary>
    ''' <returns>Boolean</returns>
    Public Property MenuEnabled() As Boolean
        Get
            Return mMenuEnabled
        End Get
        Set(ByVal value As Boolean)
            mMenuEnabled = value
        End Set
    End Property

#End Region ' Fine Regione Proprietà

#Region "Costruttori"

    ''' <summary>
    ''' Crea una nuova istanza della classe
    ''' </summary>
    Public Sub New()
        InitializeComponent()
    End Sub

#End Region ' Fine Regione Costruttori

#Region "Eventi"

    Private Sub MyTextBox_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged
        BackColor = If(String.IsNullOrEmpty(Text), EmptyBackColor, FillBackColor)
    End Sub

    Private Sub MyTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Try
            IsValid(e.KeyChar)
        Catch ex As Exception
            e.KeyChar = Chr(0)
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End Try
    End Sub

    Public Event AcceptedCharactersChanged(ByVal sender As Object, ByVal e As AcceptedCharacters)
    Public Event FillBackColorChanged(ByVal sender As Object, ByVal e As Color)
    Public Event EmptyBackColorChanged(ByVal sender As Object, ByVal e As Color)

#End Region ' Fine Regione Eventi

#Region "Functions"

    ''' <summary>
    ''' Determina se il carattere specificato è consentito
    ''' </summary>
    ''' <param name="character">Char</param>
    ''' <returns>Boolean</returns>
    Private Function IsValid(character As Char) As Boolean
        Dim ex As ExceptionType = Nothing
        Dim res As Boolean = False
        Select Case AscW(character)
            Case 8, 13, 32
                res = True
            Case Else
                Select Case AcceptedCharacters
                    Case AcceptedCharacters.Alphabetics
                        res = (Char.IsLower(character) OrElse Char.IsUpper(character))
                        If Not res Then
                            ex = ExceptionType.ALPHABETIC_EXCEPTION
                            'Throw New GPricingException(Language, ExceptionType.ALPHABETIC_EXCEPTION)
                        End If
                    Case AcceptedCharacters.AlphaNumerics
                        res = (Char.IsLower(character) OrElse Char.IsUpper(character) OrElse Char.IsNumber(character))
                        If Not res Then
                            ex = ExceptionType.ALPHANUMERIC_EXCEPTION
                            ' Throw New GPricingException(Language, ExceptionType.ALPHANUMERIC_EXCEPTION)
                        End If
                    Case AcceptedCharacters.Numerics
                        res = Char.IsNumber(character)

                        If Not res Then
                            ex = ExceptionType.NUMERIC_EXCEPTION
                            'Throw New GPricingException(Language, ExceptionType.NUMERIC_EXCEPTION)
                        End If
                    Case AcceptedCharacters.Symbols
                        res = Char.IsSymbol(character)
                        If Not res Then
                            ex = ExceptionType.SYMBOLIC_EXCEPTION
                            'Throw New GPricingException(Language, ExceptionType.SYMBOLIC_EXCEPTION)
                        End If
                    Case AcceptedCharacters.All
                        res = True
                End Select
        End Select
        If Not res Then
            Throw New NumericCharacterException
        Else
            Return res
        End If
        '        Return res
    End Function

#End Region ' Fine Regione Functions

#Region "Subs"

    ''' <summary>
    ''' Translate current textbox
    ''' </summary>
    Private Sub Translate()
        If IsNothing(Language) Then
            Language = New Language(My.Settings.Language)
        End If
        With Language.Element("character")
            FontToolStripMenuItem.Text = .Element("font")
            BackColorToolStripMenuItem.Text = .Element("backcolor")
            AcceptedCharacterToolStripMenuItem.Text = .Element("accepted_character")
            MaxLenghtToolStripMenuItem.Text = .Element("max_length")
            CopyToolStripMenuItem.Text = .Element("copy")
            PasteToolStripMenuItem.Text = .Element("paste")
            OnEmptyBackColorToolStripMenuItem.Text = .Element("primary")
            OnFillBackColorToolStripMenuItem.Text = .Element("secondary")
            AllToolStripRadioButtonMenuItem.Text = .Element("all")
            AlphabeticsToolStripRadioButtonMenuItem.Text = .Element("alphabetics")
            AlphaNumericsToolStripRadioButtonMenuItem.Text = .Element("alphanumerics")
            NumericsToolStripRadioButtonMenuItem.Text = .Element("numerics")
            SymbolToolStripRadioButtonMenuItem.Text = .Element("symbolics")
        End With
    End Sub

#End Region ' Fine Regione Subs

#Region "Menu"

    Private Sub CopyToClipboard() Handles CopyToolStripMenuItem.Click
        If Not String.IsNullOrEmpty(Me.Text) Then
            Clipboard.Clear()
            Clipboard.SetText(Me.Text)
        End If
    End Sub

    Private Sub PasteFromClipboard() Handles PasteToolStripMenuItem.Click
        If Clipboard.ContainsText And Not String.IsNullOrEmpty(Clipboard.GetText) Then
            Me.Text = Clipboard.GetText
        End If
    End Sub

    Private Sub CharacterAcceptedClick(ByVal sender As Object, ByVal e As EventArgs) Handles AllToolStripRadioButtonMenuItem.Click,
            AlphabeticsToolStripRadioButtonMenuItem.Click,
            AlphaNumericsToolStripRadioButtonMenuItem.Click,
            NumericsToolStripRadioButtonMenuItem.Click,
            SymbolToolStripRadioButtonMenuItem.Click
        AcceptedCharacters = AcceptedCharacterToolStripMenuItem.DropDownItems.IndexOf(DirectCast(sender, ToolStripRadioButtonMenuItem))
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Dim f As New MyFontDialog() With {.Font = Me.Font, .Color = Me.ForeColor}
        If f.ShowDialog = DialogResult.OK Then
            Me.Font = f.Font
            Me.ForeColor = f.Color
        End If
    End Sub

    Private Sub Menu_Opening(sender As Object, e As CancelEventArgs) Handles Menu.Opening
        Language = If(IsNothing(Language), New Language, Language)
        If MenuEnabled Then
            CopyToolStripMenuItem.Visible = Not String.IsNullOrEmpty(Me.Text)
            LenghtToolStripTextBox.Text = Me.MaxLength
            Dim r As ToolStripRadioButtonMenuItem = Me.AcceptedCharacterToolStripMenuItem.DropDownItems.Item(Integer.Parse(Me.AcceptedCharacters))
            r.Checked = True
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub LenghtToolStripTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LenghtToolStripTextBox.KeyPress
        Try
            If IsNumeric(e.KeyChar) OrElse AscW(e.KeyChar) = 13 OrElse AscW(e.KeyChar) = 8 Then
                Throw New NumericCharacterException()
            End If
        Catch ex As Exception
            e.KeyChar = Chr(0)
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End Try

    End Sub

    Private Sub LenghtToolStripTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles LenghtToolStripTextBox.KeyDown
        If e.KeyCode = Keys.Enter AndAlso Not String.IsNullOrEmpty(LenghtToolStripTextBox.Text) AndAlso IsNumeric(LenghtToolStripTextBox.Text) AndAlso Not Integer.Parse(LenghtToolStripTextBox.Text) = 0 Then
            Me.MaxLength = LenghtToolStripTextBox.Text
            Menu.Close()
        End If
    End Sub

    Private Sub OnEmptyBackColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnEmptyBackColorToolStripMenuItem.Click
        Dim c As New MyColorDialog() With {.Color = Me.EmptyBackColor}
        If c.ShowDialog = DialogResult.OK Then
            Me.EmptyBackColor = c.Color
        End If
    End Sub

    Private Sub OnFillBackColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnFillBackColorToolStripMenuItem.Click
        Dim c As New MyColorDialog() With {.Color = Me.FillBackColor}
        If c.ShowDialog = DialogResult.OK Then
            Me.FillBackColor = c.Color
        End If
    End Sub

#End Region ' Fine Regione Menu

End Class
