Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Switch
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
        Me.BtnSwitch = New System.Windows.Forms.PictureBox()
        CType(Me.BtnSwitch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSwitch
        '
        Me.BtnSwitch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnSwitch.Image = Global.MyLibrary.My.Resources.Resources.switch_off
        Me.BtnSwitch.Location = New System.Drawing.Point(0, 0)
        Me.BtnSwitch.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnSwitch.Name = "BtnSwitch"
        Me.BtnSwitch.Size = New System.Drawing.Size(47, 44)
        Me.BtnSwitch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnSwitch.TabIndex = 0
        Me.BtnSwitch.TabStop = False
        '
        'Switch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BtnSwitch)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "Switch"
        Me.Size = New System.Drawing.Size(47, 44)
        CType(Me.BtnSwitch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnSwitch As PictureBox
End Class
