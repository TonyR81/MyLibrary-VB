<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Me.MyTextBox1 = New MyLibrary.MyTextBox()
        Me.MyPassword1 = New MyLibrary.MyPassword()
        Me.SuspendLayout()
        '
        'MyTextBox1
        '
        Me.MyTextBox1.AcceptedCharacters = MyLibrary.AcceptedCharacters.All
        Me.MyTextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.MyTextBox1.EmptyBackColor = System.Drawing.Color.Empty
        Me.MyTextBox1.FillBackColor = System.Drawing.Color.Empty
        Me.MyTextBox1.Language = Nothing
        Me.MyTextBox1.Location = New System.Drawing.Point(122, 126)
        Me.MyTextBox1.MaxLength = 150
        Me.MyTextBox1.MenuEnabled = True
        Me.MyTextBox1.Name = "MyTextBox1"
        Me.MyTextBox1.Size = New System.Drawing.Size(274, 20)
        Me.MyTextBox1.TabIndex = 0
        '
        'MyPassword1
        '
        Me.MyPassword1.AcceptedCharacters = MyLibrary.AcceptedCharacters.All
        Me.MyPassword1.EmptyBackColor = System.Drawing.Color.Empty
        Me.MyPassword1.FillBackColor = System.Drawing.Color.Empty
        Me.MyPassword1.Language = Nothing
        Me.MyPassword1.Location = New System.Drawing.Point(122, 246)
        Me.MyPassword1.MaxLength = 16
        Me.MyPassword1.MenuEnabled = False
        Me.MyPassword1.Name = "MyPassword1"
        Me.MyPassword1.Size = New System.Drawing.Size(188, 20)
        Me.MyPassword1.Status = MyLibrary.Visibility.CLOSED
        Me.MyPassword1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MyPassword1)
        Me.Controls.Add(Me.MyTextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MyTextBox1 As MyTextBox
    Friend WithEvents MyPassword1 As MyPassword
End Class
