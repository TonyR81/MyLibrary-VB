<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GeoLocationSelector
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
        Me.GroupBoxLocation = New System.Windows.Forms.GroupBox()
        Me.MainContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelTop = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelCountry = New System.Windows.Forms.Label()
        Me.LabelRegion = New System.Windows.Forms.Label()
        Me.LabelProvince = New System.Windows.Forms.Label()
        Me.LabelMunicipality = New System.Windows.Forms.Label()
        Me.ComboCountry = New System.Windows.Forms.ComboBox()
        Me.ComboRegion = New System.Windows.Forms.ComboBox()
        Me.ComboProvince = New System.Windows.Forms.ComboBox()
        Me.ComboMunicipality = New System.Windows.Forms.ComboBox()
        Me.PanelMiddle = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtStreetNumber = New System.Windows.Forms.TextBox()
        Me.LabelStreetNumber = New System.Windows.Forms.Label()
        Me.LabelAddress = New System.Windows.Forms.Label()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.PanelBottom = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelZipCode = New System.Windows.Forms.Label()
        Me.TxtZipCode = New System.Windows.Forms.TextBox()
        Me.GroupBoxLocation.SuspendLayout()
        Me.MainContainer.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        Me.PanelMiddle.SuspendLayout()
        Me.PanelBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxLocation
        '
        Me.GroupBoxLocation.AutoSize = True
        Me.GroupBoxLocation.Controls.Add(Me.MainContainer)
        Me.GroupBoxLocation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxLocation.Location = New System.Drawing.Point(0, 0)
        Me.GroupBoxLocation.Name = "GroupBoxLocation"
        Me.GroupBoxLocation.Size = New System.Drawing.Size(372, 198)
        Me.GroupBoxLocation.TabIndex = 0
        Me.GroupBoxLocation.TabStop = False
        Me.GroupBoxLocation.Text = "Location"
        '
        'MainContainer
        '
        Me.MainContainer.AutoSize = True
        Me.MainContainer.ColumnCount = 1
        Me.MainContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainContainer.Controls.Add(Me.PanelTop, 0, 0)
        Me.MainContainer.Controls.Add(Me.PanelMiddle, 0, 1)
        Me.MainContainer.Controls.Add(Me.PanelBottom, 0, 2)
        Me.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainContainer.Location = New System.Drawing.Point(3, 16)
        Me.MainContainer.Name = "MainContainer"
        Me.MainContainer.RowCount = 3
        Me.MainContainer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MainContainer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MainContainer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MainContainer.Size = New System.Drawing.Size(366, 179)
        Me.MainContainer.TabIndex = 0
        '
        'PanelTop
        '
        Me.PanelTop.AutoSize = True
        Me.PanelTop.ColumnCount = 2
        Me.PanelTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.PanelTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.PanelTop.Controls.Add(Me.LabelCountry, 0, 0)
        Me.PanelTop.Controls.Add(Me.LabelRegion, 1, 0)
        Me.PanelTop.Controls.Add(Me.LabelProvince, 0, 2)
        Me.PanelTop.Controls.Add(Me.LabelMunicipality, 1, 2)
        Me.PanelTop.Controls.Add(Me.ComboCountry, 0, 1)
        Me.PanelTop.Controls.Add(Me.ComboRegion, 1, 1)
        Me.PanelTop.Controls.Add(Me.ComboProvince, 0, 3)
        Me.PanelTop.Controls.Add(Me.ComboMunicipality, 1, 3)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTop.Location = New System.Drawing.Point(3, 3)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.RowCount = 4
        Me.PanelTop.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PanelTop.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PanelTop.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PanelTop.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PanelTop.Size = New System.Drawing.Size(360, 80)
        Me.PanelTop.TabIndex = 0
        '
        'LabelCountry
        '
        Me.LabelCountry.AutoSize = True
        Me.LabelCountry.Location = New System.Drawing.Point(3, 0)
        Me.LabelCountry.Name = "LabelCountry"
        Me.LabelCountry.Size = New System.Drawing.Size(43, 13)
        Me.LabelCountry.TabIndex = 0
        Me.LabelCountry.Text = "Country"
        '
        'LabelRegion
        '
        Me.LabelRegion.AutoSize = True
        Me.LabelRegion.Location = New System.Drawing.Point(183, 0)
        Me.LabelRegion.Name = "LabelRegion"
        Me.LabelRegion.Size = New System.Drawing.Size(41, 13)
        Me.LabelRegion.TabIndex = 1
        Me.LabelRegion.Text = "Region"
        '
        'LabelProvince
        '
        Me.LabelProvince.AutoSize = True
        Me.LabelProvince.Location = New System.Drawing.Point(3, 40)
        Me.LabelProvince.Name = "LabelProvince"
        Me.LabelProvince.Size = New System.Drawing.Size(49, 13)
        Me.LabelProvince.TabIndex = 2
        Me.LabelProvince.Text = "Province"
        '
        'LabelMunicipality
        '
        Me.LabelMunicipality.AutoSize = True
        Me.LabelMunicipality.Location = New System.Drawing.Point(183, 40)
        Me.LabelMunicipality.Name = "LabelMunicipality"
        Me.LabelMunicipality.Size = New System.Drawing.Size(62, 13)
        Me.LabelMunicipality.TabIndex = 3
        Me.LabelMunicipality.Text = "Municipality"
        '
        'ComboCountry
        '
        Me.ComboCountry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboCountry.FormattingEnabled = True
        Me.ComboCountry.Location = New System.Drawing.Point(3, 16)
        Me.ComboCountry.Name = "ComboCountry"
        Me.ComboCountry.Size = New System.Drawing.Size(174, 21)
        Me.ComboCountry.TabIndex = 0
        '
        'ComboRegion
        '
        Me.ComboRegion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboRegion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboRegion.FormattingEnabled = True
        Me.ComboRegion.Location = New System.Drawing.Point(183, 16)
        Me.ComboRegion.Name = "ComboRegion"
        Me.ComboRegion.Size = New System.Drawing.Size(174, 21)
        Me.ComboRegion.TabIndex = 1
        '
        'ComboProvince
        '
        Me.ComboProvince.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboProvince.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboProvince.FormattingEnabled = True
        Me.ComboProvince.Location = New System.Drawing.Point(3, 56)
        Me.ComboProvince.Name = "ComboProvince"
        Me.ComboProvince.Size = New System.Drawing.Size(174, 21)
        Me.ComboProvince.TabIndex = 2
        '
        'ComboMunicipality
        '
        Me.ComboMunicipality.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboMunicipality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboMunicipality.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboMunicipality.FormattingEnabled = True
        Me.ComboMunicipality.Location = New System.Drawing.Point(183, 56)
        Me.ComboMunicipality.Name = "ComboMunicipality"
        Me.ComboMunicipality.Size = New System.Drawing.Size(174, 21)
        Me.ComboMunicipality.TabIndex = 3
        '
        'PanelMiddle
        '
        Me.PanelMiddle.AutoSize = True
        Me.PanelMiddle.ColumnCount = 2
        Me.PanelMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.PanelMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.PanelMiddle.Controls.Add(Me.TxtStreetNumber, 1, 1)
        Me.PanelMiddle.Controls.Add(Me.LabelStreetNumber, 1, 0)
        Me.PanelMiddle.Controls.Add(Me.LabelAddress, 0, 0)
        Me.PanelMiddle.Controls.Add(Me.TxtAddress, 0, 1)
        Me.PanelMiddle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMiddle.Location = New System.Drawing.Point(3, 89)
        Me.PanelMiddle.Name = "PanelMiddle"
        Me.PanelMiddle.RowCount = 2
        Me.PanelMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PanelMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PanelMiddle.Size = New System.Drawing.Size(360, 39)
        Me.PanelMiddle.TabIndex = 1
        '
        'TxtStreetNumber
        '
        Me.TxtStreetNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtStreetNumber.Location = New System.Drawing.Point(255, 16)
        Me.TxtStreetNumber.Name = "TxtStreetNumber"
        Me.TxtStreetNumber.Size = New System.Drawing.Size(102, 20)
        Me.TxtStreetNumber.TabIndex = 1
        '
        'LabelStreetNumber
        '
        Me.LabelStreetNumber.AutoSize = True
        Me.LabelStreetNumber.Location = New System.Drawing.Point(255, 0)
        Me.LabelStreetNumber.Name = "LabelStreetNumber"
        Me.LabelStreetNumber.Size = New System.Drawing.Size(19, 13)
        Me.LabelStreetNumber.TabIndex = 3
        Me.LabelStreetNumber.Text = "N°"
        '
        'LabelAddress
        '
        Me.LabelAddress.AutoSize = True
        Me.LabelAddress.Location = New System.Drawing.Point(3, 0)
        Me.LabelAddress.Name = "LabelAddress"
        Me.LabelAddress.Size = New System.Drawing.Size(45, 13)
        Me.LabelAddress.TabIndex = 1
        Me.LabelAddress.Text = "Address"
        '
        'TxtAddress
        '
        Me.TxtAddress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtAddress.Location = New System.Drawing.Point(3, 16)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(246, 20)
        Me.TxtAddress.TabIndex = 0
        '
        'PanelBottom
        '
        Me.PanelBottom.AutoSize = True
        Me.PanelBottom.ColumnCount = 2
        Me.PanelBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelBottom.Controls.Add(Me.LabelZipCode, 0, 0)
        Me.PanelBottom.Controls.Add(Me.TxtZipCode, 0, 1)
        Me.PanelBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBottom.Location = New System.Drawing.Point(3, 134)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.RowCount = 2
        Me.PanelBottom.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PanelBottom.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PanelBottom.Size = New System.Drawing.Size(360, 42)
        Me.PanelBottom.TabIndex = 2
        '
        'LabelZipCode
        '
        Me.LabelZipCode.AutoSize = True
        Me.LabelZipCode.Location = New System.Drawing.Point(3, 0)
        Me.LabelZipCode.Name = "LabelZipCode"
        Me.LabelZipCode.Size = New System.Drawing.Size(49, 13)
        Me.LabelZipCode.TabIndex = 0
        Me.LabelZipCode.Text = "Zip code"
        '
        'TxtZipCode
        '
        Me.TxtZipCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtZipCode.Location = New System.Drawing.Point(3, 16)
        Me.TxtZipCode.Name = "TxtZipCode"
        Me.TxtZipCode.Size = New System.Drawing.Size(100, 20)
        Me.TxtZipCode.TabIndex = 0
        '
        'GeoLocationSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.GroupBoxLocation)
        Me.Name = "GeoLocationSelector"
        Me.Size = New System.Drawing.Size(372, 198)
        Me.GroupBoxLocation.ResumeLayout(False)
        Me.GroupBoxLocation.PerformLayout()
        Me.MainContainer.ResumeLayout(False)
        Me.MainContainer.PerformLayout()
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        Me.PanelMiddle.ResumeLayout(False)
        Me.PanelMiddle.PerformLayout()
        Me.PanelBottom.ResumeLayout(False)
        Me.PanelBottom.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxLocation As Windows.Forms.GroupBox
    Friend WithEvents MainContainer As Windows.Forms.TableLayoutPanel
    Private WithEvents PanelTop As Windows.Forms.TableLayoutPanel
    Private WithEvents PanelMiddle As Windows.Forms.TableLayoutPanel
    Private WithEvents PanelBottom As Windows.Forms.TableLayoutPanel
    Friend WithEvents LabelCountry As Windows.Forms.Label
    Friend WithEvents LabelRegion As Windows.Forms.Label
    Friend WithEvents LabelProvince As Windows.Forms.Label
    Friend WithEvents LabelMunicipality As Windows.Forms.Label
    Friend WithEvents ComboCountry As Windows.Forms.ComboBox
    Friend WithEvents ComboRegion As Windows.Forms.ComboBox
    Friend WithEvents ComboProvince As Windows.Forms.ComboBox
    Friend WithEvents ComboMunicipality As Windows.Forms.ComboBox
    Friend WithEvents TxtStreetNumber As Windows.Forms.TextBox
    Friend WithEvents LabelStreetNumber As Windows.Forms.Label
    Friend WithEvents LabelAddress As Windows.Forms.Label
    Friend WithEvents TxtAddress As Windows.Forms.TextBox
    Friend WithEvents LabelZipCode As Windows.Forms.Label
    Friend WithEvents TxtZipCode As Windows.Forms.TextBox
End Class
