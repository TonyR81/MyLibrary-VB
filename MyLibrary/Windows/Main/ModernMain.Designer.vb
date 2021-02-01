<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModernMain
    Inherits FormBase

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Language1 As MyLibrary.Language = New MyLibrary.Language()
        Me.MainToolbar = New MyLibrary.Toolbar()
        Me.SuspendLayout()
        '
        'MainToolbar
        '
        Me.MainToolbar.AutoSize = True
        Me.MainToolbar.BackColor = System.Drawing.Color.Transparent
        Me.MainToolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.MainToolbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainToolbar.HasClose = True
        Me.MainToolbar.HasMinimize = True
        Me.MainToolbar.HasWindowState = True
        Me.MainToolbar.Icon = Nothing
        Me.MainToolbar.Image = Nothing
        Me.MainToolbar.Location = New System.Drawing.Point(0, 0)
        Me.MainToolbar.Margin = New System.Windows.Forms.Padding(0)
        Me.MainToolbar.MaximumSize = New System.Drawing.Size(2000, 32)
        Me.MainToolbar.MinimumSize = New System.Drawing.Size(200, 32)
        Me.MainToolbar.Name = "MainToolbar"
        Me.MainToolbar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.MainToolbar.Size = New System.Drawing.Size(330, 32)
        Me.MainToolbar.TabIndex = 0
        Me.MainToolbar.Title = Nothing
        '
        'ModernMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 254)
        Me.Controls.Add(Me.MainToolbar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Language = Language1
        Me.Name = "ModernMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModernMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainToolbar As Toolbar
End Class
