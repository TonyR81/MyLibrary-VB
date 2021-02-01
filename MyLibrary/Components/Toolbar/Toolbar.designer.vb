Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Toolbar
    Inherits System.Windows.Forms.UserControl

    'UserControl esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.IconToolbar = New System.Windows.Forms.PictureBox()
        Me.ButtonsPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.BtnMinimize = New MyLibrary.ToolbarButton
        Me.BtnWindowState = New MyLibrary.ToolbarButton
        Me.BtnClose = New MyLibrary.ToolbarButton
        CType(Me.IconToolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ButtonsPanel.SuspendLayout()
        CType(Me.BtnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnWindowState, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Location = New System.Drawing.Point(39, 8)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(34, 16)
        Me.TitleLabel.TabIndex = 4
        Me.TitleLabel.Text = "Title"
        '
        'IconToolbar
        '
        Me.IconToolbar.Location = New System.Drawing.Point(11, 4)
        Me.IconToolbar.Margin = New System.Windows.Forms.Padding(1)
        Me.IconToolbar.Name = "IconToolbar"
        Me.IconToolbar.Size = New System.Drawing.Size(24, 24)
        Me.IconToolbar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IconToolbar.TabIndex = 0
        Me.IconToolbar.TabStop = False
        '
        'ButtonsPanel
        '
        Me.ButtonsPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonsPanel.AutoSize = True
        Me.ButtonsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonsPanel.Controls.Add(Me.BtnMinimize)
        Me.ButtonsPanel.Controls.Add(Me.BtnWindowState)
        Me.ButtonsPanel.Controls.Add(Me.BtnClose)
        Me.ButtonsPanel.Location = New System.Drawing.Point(107, 1)
        Me.ButtonsPanel.Name = "ButtonsPanel"
        Me.ButtonsPanel.Size = New System.Drawing.Size(90, 30)
        Me.ButtonsPanel.TabIndex = 8
        '
        'BtnMinimize
        '
        Me.BtnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMinimize.Image = Global.MyLibrary.My.Resources.Resources.Iconize
        Me.BtnMinimize.Location = New System.Drawing.Point(3, 3)
        Me.BtnMinimize.Name = "BtnMinimize"
        Me.BtnMinimize.Size = New System.Drawing.Size(24, 24)
        Me.BtnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnMinimize.TabIndex = 7
        Me.BtnMinimize.TabStop = False
        '
        'BtnWindowState
        '
        Me.BtnWindowState.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnWindowState.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnWindowState.Image = Global.MyLibrary.My.Resources.Resources.maximize
        Me.BtnWindowState.Location = New System.Drawing.Point(33, 3)
        Me.BtnWindowState.Name = "BtnWindowState"
        Me.BtnWindowState.Size = New System.Drawing.Size(24, 24)
        Me.BtnWindowState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnWindowState.TabIndex = 6
        Me.BtnWindowState.TabStop = False
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.Image = Global.MyLibrary.My.Resources.Resources.close
        Me.BtnClose.Location = New System.Drawing.Point(63, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(24, 24)
        Me.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnClose.TabIndex = 5
        Me.BtnClose.TabStop = False
        '
        'Toolbar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.ButtonsPanel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.IconToolbar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.MaximumSize = New System.Drawing.Size(2000, 32)
        Me.MinimumSize = New System.Drawing.Size(200, 32)
        Me.Name = "Toolbar"
        Me.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Size = New System.Drawing.Size(200, 32)
        CType(Me.IconToolbar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ButtonsPanel.ResumeLayout(False)
        CType(Me.BtnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnWindowState, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IconToolbar As PictureBox
    Friend WithEvents TitleLabel As Label
    Friend WithEvents BtnClose As ToolbarButton
    Friend WithEvents BtnWindowState As ToolbarButton
    Friend WithEvents BtnMinimize As ToolbarButton
    Friend WithEvents ButtonsPanel As FlowLayoutPanel
End Class
