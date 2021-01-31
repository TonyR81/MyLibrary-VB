Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MySwitch
    Inherits System.Windows.Forms.UserControl

    'UserControl esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MainContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.Switch = New MyLibrary.Switch()
        Me.LabelText = New System.Windows.Forms.Label()
        Me.MainContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainContainer
        '
        Me.MainContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainContainer.AutoSize = True
        Me.MainContainer.ColumnCount = 2
        Me.MainContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.MainContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainContainer.Controls.Add(Me.Switch, 0, 0)
        Me.MainContainer.Controls.Add(Me.LabelText, 1, 0)
        Me.MainContainer.Location = New System.Drawing.Point(0, 0)
        Me.MainContainer.Margin = New System.Windows.Forms.Padding(0)
        Me.MainContainer.Name = "MainContainer"
        Me.MainContainer.RowCount = 1
        Me.MainContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainContainer.Size = New System.Drawing.Size(150, 150)
        Me.MainContainer.TabIndex = 0
        '
        'Switch
        '
        Me.Switch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Switch.Checked = False
        Me.Switch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Switch.Location = New System.Drawing.Point(3, 3)
        Me.Switch.Name = "Switch"
        Me.Switch.Size = New System.Drawing.Size(52, 144)
        Me.Switch.TabIndex = 0
        '
        'LabelText
        '
        Me.LabelText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelText.AutoSize = True
        Me.LabelText.Location = New System.Drawing.Point(61, 0)
        Me.LabelText.Name = "LabelText"
        Me.LabelText.Size = New System.Drawing.Size(86, 150)
        Me.LabelText.TabIndex = 1
        Me.LabelText.Text = "Text"
        Me.LabelText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MySwitch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.MainContainer)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "MySwitch"
        Me.MainContainer.ResumeLayout(False)
        Me.MainContainer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainContainer As TableLayoutPanel
    Friend WithEvents Switch As Switch
    Friend WithEvents LabelText As Label
End Class
