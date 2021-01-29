''' <summary>
''' MyColorDialog Class.
''' <para>Finestra di dialogo dei font personalizzata</para>
''' <para>Author Antonino Razeti</para>
''' <para>Version 1.0 - 2019/02/12</para>
''' </summary>
Public Class MyFontDialog

#Region "Costruttori"

    ''' <summary>
    ''' Crea una nuova istanza della classe
    ''' </summary>
    Public Sub New()

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        Me.AllowScriptChange = True
        Me.AllowSimulations = True
        Me.AllowVectorFonts = True
        Me.AllowVerticalFonts = True
        If Not IsNothing(Color) Then
            Me.Color = Color
        End If
        If Not IsNothing(Font) Then
            Me.Font = Font
        End If
        Me.ShowApply = True
        Me.ShowColor = True
        Me.ShowEffects = True
    End Sub

#End Region ' Fine Regione Costruttori

#Region "Eventi"


#End Region ' Fine Regione Eventi

End Class
