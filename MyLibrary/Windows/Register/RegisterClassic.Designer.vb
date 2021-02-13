<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterClassic
    Inherits FormBase

    <System.Diagnostics.DebuggerStepThrough>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GeoLocation1 As MyLibrary.GeoLocation = New MyLibrary.GeoLocation()
        Dim Language1 As MyLibrary.Language = New MyLibrary.Language()
        Dim Language2 As MyLibrary.Language = New MyLibrary.Language()
        Me.LabelLastName = New System.Windows.Forms.Label()
        Me.MyTextBox1 = New MyLibrary.MyTextBox()
        Me.MyTextBox2 = New MyLibrary.MyTextBox()
        Me.LabelFirstName = New System.Windows.Forms.Label()
        Me.LocationSelector = New MyLibrary.GeoLocationSelector()
        Me.SuspendLayout()
        '
        'LabelLastName
        '
        Me.LabelLastName.AutoSize = True
        Me.LabelLastName.Location = New System.Drawing.Point(12, 9)
        Me.LabelLastName.Name = "LabelLastName"
        Me.LabelLastName.Size = New System.Drawing.Size(58, 13)
        Me.LabelLastName.TabIndex = 0
        Me.LabelLastName.Text = "Last Name"
        '
        'MyTextBox1
        '
        Me.MyTextBox1.AcceptedCharacters = MyLibrary.AcceptedCharacters.All
        Me.MyTextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.MyTextBox1.EmptyBackColor = System.Drawing.Color.Empty
        Me.MyTextBox1.FillBackColor = System.Drawing.Color.Empty
        Me.MyTextBox1.Language = Nothing
        Me.MyTextBox1.Location = New System.Drawing.Point(12, 25)
        Me.MyTextBox1.MaxLength = 150
        Me.MyTextBox1.MenuEnabled = False
        Me.MyTextBox1.Name = "MyTextBox1"
        Me.MyTextBox1.Size = New System.Drawing.Size(239, 20)
        Me.MyTextBox1.TabIndex = 1
        '
        'MyTextBox2
        '
        Me.MyTextBox2.AcceptedCharacters = MyLibrary.AcceptedCharacters.All
        Me.MyTextBox2.BackColor = System.Drawing.SystemColors.Window
        Me.MyTextBox2.EmptyBackColor = System.Drawing.Color.Empty
        Me.MyTextBox2.FillBackColor = System.Drawing.Color.Empty
        Me.MyTextBox2.Language = Nothing
        Me.MyTextBox2.Location = New System.Drawing.Point(257, 25)
        Me.MyTextBox2.MaxLength = 150
        Me.MyTextBox2.MenuEnabled = False
        Me.MyTextBox2.Name = "MyTextBox2"
        Me.MyTextBox2.Size = New System.Drawing.Size(239, 20)
        Me.MyTextBox2.TabIndex = 3
        '
        'LabelFirstName
        '
        Me.LabelFirstName.AutoSize = True
        Me.LabelFirstName.Location = New System.Drawing.Point(257, 9)
        Me.LabelFirstName.Name = "LabelFirstName"
        Me.LabelFirstName.Size = New System.Drawing.Size(55, 13)
        Me.LabelFirstName.TabIndex = 2
        Me.LabelFirstName.Text = "First name"
        '
        'LocationSelector
        '
        Me.LocationSelector.AutoSize = True
        Me.LocationSelector.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.LocationSelector.GeoLocation = GeoLocation1
        Me.LocationSelector.Location = New System.Drawing.Point(12, 51)
        Me.LocationSelector.Name = "LocationSelector"
        Me.LocationSelector.Size = New System.Drawing.Size(372, 198)
        Me.LocationSelector.TabIndex = 4
        '
        'RegisterClassic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(507, 387)
        Me.Controls.Add(Me.LocationSelector)
        Me.Controls.Add(Me.MyTextBox2)
        Me.Controls.Add(Me.LabelFirstName)
        Me.Controls.Add(Me.MyTextBox1)
        Me.Controls.Add(Me.LabelLastName)
        Me.Language = Language2
        Me.Name = "RegisterClassic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelLastName As Windows.Forms.Label
    Friend WithEvents MyTextBox1 As MyTextBox
    Private components As ComponentModel.IContainer
    Friend WithEvents MyTextBox2 As MyTextBox
    Friend WithEvents LabelFirstName As Windows.Forms.Label
    Friend WithEvents LocationSelector As GeoLocationSelector
End Class
