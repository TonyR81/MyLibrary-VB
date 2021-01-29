''' <summary>
''' MyColorDialog Class.
''' <para>Finestra di dialogo dei colori personalizzata</para>
''' <para>Author Antonino Razeti</para>
''' <para>Version 1.0 - 2019/02/12</para>
''' </summary>
Public Class MyColorDialog

#Region "Costruttori"

    ''' <summary>
    ''' Crea una nuova istanza della classe
    ''' </summary>
    Public Sub New()

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        Me.AllowFullOpen = True
        Me.AnyColor = True
        Me.Color = Color
        Me.FullOpen = True

    End Sub

#End Region ' Fine Regione Costruttori

#Region "Eventi"


#End Region ' Fine Regione Eventi

End Class
