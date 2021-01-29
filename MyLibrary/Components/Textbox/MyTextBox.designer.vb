Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MyTextBox
    Inherits TextBox

    <System.Diagnostics.DebuggerStepThrough>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnEmptyBackColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnFillBackColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcceptedCharacterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllToolStripRadioButtonMenuItem = New MyLibrary.ToolStripRadioButtonMenuItem()
        Me.AlphabeticsToolStripRadioButtonMenuItem = New MyLibrary.ToolStripRadioButtonMenuItem()
        Me.NumericsToolStripRadioButtonMenuItem = New MyLibrary.ToolStripRadioButtonMenuItem()
        Me.AlphaNumericsToolStripRadioButtonMenuItem = New MyLibrary.ToolStripRadioButtonMenuItem()
        Me.SymbolToolStripRadioButtonMenuItem = New MyLibrary.ToolStripRadioButtonMenuItem()
        Me.MaxLenghtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LenghtToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClipboardSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Menu
        '
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.ClipboardSeparator, Me.FontToolStripMenuItem, Me.BackColorToolStripMenuItem, Me.AcceptedCharacterToolStripMenuItem, Me.MaxLenghtToolStripMenuItem})
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(179, 136)
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'BackColorToolStripMenuItem
        '
        Me.BackColorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OnEmptyBackColorToolStripMenuItem, Me.OnFillBackColorToolStripMenuItem})
        Me.BackColorToolStripMenuItem.Name = "BackColorToolStripMenuItem"
        Me.BackColorToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.BackColorToolStripMenuItem.Text = "BackColor"
        '
        'OnEmptyBackColorToolStripMenuItem
        '
        Me.OnEmptyBackColorToolStripMenuItem.Name = "OnEmptyBackColorToolStripMenuItem"
        Me.OnEmptyBackColorToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.OnEmptyBackColorToolStripMenuItem.Text = "On Empty BackColor"
        '
        'OnFillBackColorToolStripMenuItem
        '
        Me.OnFillBackColorToolStripMenuItem.Name = "OnFillBackColorToolStripMenuItem"
        Me.OnFillBackColorToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.OnFillBackColorToolStripMenuItem.Text = "On Fill BackColor"
        '
        'AcceptedCharacterToolStripMenuItem
        '
        Me.AcceptedCharacterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllToolStripRadioButtonMenuItem, Me.AlphabeticsToolStripRadioButtonMenuItem, Me.NumericsToolStripRadioButtonMenuItem, Me.AlphaNumericsToolStripRadioButtonMenuItem, Me.SymbolToolStripRadioButtonMenuItem})
        Me.AcceptedCharacterToolStripMenuItem.Name = "AcceptedCharacterToolStripMenuItem"
        Me.AcceptedCharacterToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.AcceptedCharacterToolStripMenuItem.Text = "Accepted Character"
        '
        'AllToolStripRadioButtonMenuItem
        '
        Me.AllToolStripRadioButtonMenuItem.CheckOnClick = True
        Me.AllToolStripRadioButtonMenuItem.Name = "AllToolStripRadioButtonMenuItem"
        Me.AllToolStripRadioButtonMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.AllToolStripRadioButtonMenuItem.Text = "All"
        '
        'AlphabeticsToolStripRadioButtonMenuItem
        '
        Me.AlphabeticsToolStripRadioButtonMenuItem.CheckOnClick = True
        Me.AlphabeticsToolStripRadioButtonMenuItem.Name = "AlphabeticsToolStripRadioButtonMenuItem"
        Me.AlphabeticsToolStripRadioButtonMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.AlphabeticsToolStripRadioButtonMenuItem.Text = "Alphabetics"
        '
        'NumericsToolStripRadioButtonMenuItem
        '
        Me.NumericsToolStripRadioButtonMenuItem.CheckOnClick = True
        Me.NumericsToolStripRadioButtonMenuItem.Name = "NumericsToolStripRadioButtonMenuItem"
        Me.NumericsToolStripRadioButtonMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.NumericsToolStripRadioButtonMenuItem.Text = "Numerics"
        '
        'AlphaNumericsToolStripRadioButtonMenuItem
        '
        Me.AlphaNumericsToolStripRadioButtonMenuItem.CheckOnClick = True
        Me.AlphaNumericsToolStripRadioButtonMenuItem.Name = "AlphaNumericsToolStripRadioButtonMenuItem"
        Me.AlphaNumericsToolStripRadioButtonMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.AlphaNumericsToolStripRadioButtonMenuItem.Text = "AlphaNumerics"
        '
        'SymbolToolStripRadioButtonMenuItem
        '
        Me.SymbolToolStripRadioButtonMenuItem.CheckOnClick = True
        Me.SymbolToolStripRadioButtonMenuItem.Name = "SymbolToolStripRadioButtonMenuItem"
        Me.SymbolToolStripRadioButtonMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.SymbolToolStripRadioButtonMenuItem.Text = "Symbols"
        '
        'MaxLenghtToolStripMenuItem
        '
        Me.MaxLenghtToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LenghtToolStripTextBox})
        Me.MaxLenghtToolStripMenuItem.Name = "MaxLenghtToolStripMenuItem"
        Me.MaxLenghtToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.MaxLenghtToolStripMenuItem.Text = "Max Lenght"
        '
        'LenghtToolStripTextBox
        '
        Me.LenghtToolStripTextBox.Name = "LenghtToolStripTextBox"
        Me.LenghtToolStripTextBox.Size = New System.Drawing.Size(100, 23)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'ClipboardSeparator
        '
        Me.ClipboardSeparator.Name = "ClipboardSeparator"
        Me.ClipboardSeparator.Size = New System.Drawing.Size(175, 6)
        '
        'MyTextBox
        '
        Me.ContextMenuStrip = Me.Menu
        Me.MaxLength = 150
        Me.Menu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Menu As ContextMenuStrip
    Private components As System.ComponentModel.IContainer
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcceptedCharacterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaxLenghtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllToolStripRadioButtonMenuItem As ToolStripRadioButtonMenuItem
    Friend WithEvents AlphabeticsToolStripRadioButtonMenuItem As ToolStripRadioButtonMenuItem
    Friend WithEvents NumericsToolStripRadioButtonMenuItem As ToolStripRadioButtonMenuItem
    Friend WithEvents AlphaNumericsToolStripRadioButtonMenuItem As ToolStripRadioButtonMenuItem
    Friend WithEvents SymbolToolStripRadioButtonMenuItem As ToolStripRadioButtonMenuItem
    Friend WithEvents LenghtToolStripTextBox As ToolStripTextBox
    Friend WithEvents OnEmptyBackColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OnFillBackColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClipboardSeparator As ToolStripSeparator
End Class
