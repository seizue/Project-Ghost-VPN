<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TapDriver
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TapDriver))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PanelLine = New System.Windows.Forms.Panel()
        Me.NavBar = New System.Windows.Forms.Panel()
        Me.BtnClose = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator3 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BunifuSeparator4 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton7 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton8 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton4 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton5 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton6 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuSeparator5 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.NavBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 2
        Me.BunifuElipse1.TargetControl = Me
        '
        'PanelLine
        '
        Me.PanelLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PanelLine.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLine.Location = New System.Drawing.Point(2, 31)
        Me.PanelLine.Name = "PanelLine"
        Me.PanelLine.Size = New System.Drawing.Size(555, 2)
        Me.PanelLine.TabIndex = 52
        '
        'NavBar
        '
        Me.NavBar.Controls.Add(Me.BtnClose)
        Me.NavBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.NavBar.Location = New System.Drawing.Point(2, 2)
        Me.NavBar.Name = "NavBar"
        Me.NavBar.Size = New System.Drawing.Size(555, 29)
        Me.NavBar.TabIndex = 51
        '
        'BtnClose
        '
        Me.BtnClose.ActiveBorderThickness = 1
        Me.BtnClose.ActiveCornerRadius = 10
        Me.BtnClose.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BtnClose.ActiveForecolor = System.Drawing.Color.White
        Me.BtnClose.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.ButtonText = ""
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.SeaGreen
        Me.BtnClose.IdleBorderThickness = 1
        Me.BtnClose.IdleCornerRadius = 10
        Me.BtnClose.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BtnClose.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BtnClose.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BtnClose.Location = New System.Drawing.Point(534, 3)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(12, 22)
        Me.BtnClose.TabIndex = 7
        Me.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(2, 430)
        Me.Panel4.TabIndex = 50
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(557, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(3, 430)
        Me.Panel3.TabIndex = 49
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 432)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(560, 3)
        Me.Panel2.TabIndex = 48
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(560, 2)
        Me.Panel1.TabIndex = 47
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 2
        Me.BunifuSeparator1.Location = New System.Drawing.Point(36, 198)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(490, 18)
        Me.BunifuSeparator1.TabIndex = 95
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'BunifuSeparator3
        '
        Me.BunifuSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuSeparator3.LineThickness = 2
        Me.BunifuSeparator3.Location = New System.Drawing.Point(98, 46)
        Me.BunifuSeparator3.Name = "BunifuSeparator3"
        Me.BunifuSeparator3.Size = New System.Drawing.Size(425, 18)
        Me.BunifuSeparator3.TabIndex = 90
        Me.BunifuSeparator3.Transparency = 255
        Me.BunifuSeparator3.Vertical = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(29, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 15)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "TAP Driver"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuSeparator4
        '
        Me.BunifuSeparator4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuSeparator4.LineThickness = 2
        Me.BunifuSeparator4.Location = New System.Drawing.Point(113, 242)
        Me.BunifuSeparator4.Name = "BunifuSeparator4"
        Me.BunifuSeparator4.Size = New System.Drawing.Size(139, 18)
        Me.BunifuSeparator4.TabIndex = 119
        Me.BunifuSeparator4.Transparency = 255
        Me.BunifuSeparator4.Vertical = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(27, 242)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 15)
        Me.Label8.TabIndex = 114
        Me.Label8.Text = "Windows x32"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 2
        Me.BunifuFlatButton1.ButtonText = "Remove"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Nothing
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 60.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(34, 337)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(218, 29)
        Me.BunifuFlatButton1.TabIndex = 118
        Me.BunifuFlatButton1.Text = "Remove"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 2
        Me.BunifuFlatButton2.ButtonText = ""
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = Nothing
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 90.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(30, 333)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(226, 37)
        Me.BunifuFlatButton2.TabIndex = 117
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton7
        '
        Me.BunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuFlatButton7.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton7.BorderRadius = 2
        Me.BunifuFlatButton7.ButtonText = "Install"
        Me.BunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton7.Iconimage = Nothing
        Me.BunifuFlatButton7.Iconimage_right = Nothing
        Me.BunifuFlatButton7.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton7.Iconimage_Selected = Nothing
        Me.BunifuFlatButton7.IconMarginLeft = 0
        Me.BunifuFlatButton7.IconMarginRight = 0
        Me.BunifuFlatButton7.IconRightVisible = True
        Me.BunifuFlatButton7.IconRightZoom = 0R
        Me.BunifuFlatButton7.IconVisible = True
        Me.BunifuFlatButton7.IconZoom = 60.0R
        Me.BunifuFlatButton7.IsTab = False
        Me.BunifuFlatButton7.Location = New System.Drawing.Point(34, 286)
        Me.BunifuFlatButton7.Name = "BunifuFlatButton7"
        Me.BunifuFlatButton7.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.BunifuFlatButton7.selected = False
        Me.BunifuFlatButton7.Size = New System.Drawing.Size(218, 29)
        Me.BunifuFlatButton7.TabIndex = 116
        Me.BunifuFlatButton7.Text = "Install"
        Me.BunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton7.Textcolor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BunifuFlatButton7.TextFont = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton8
        '
        Me.BunifuFlatButton8.Activecolor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BunifuFlatButton8.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton8.BorderRadius = 2
        Me.BunifuFlatButton8.ButtonText = ""
        Me.BunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton8.Iconimage = Nothing
        Me.BunifuFlatButton8.Iconimage_right = Nothing
        Me.BunifuFlatButton8.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton8.Iconimage_Selected = Nothing
        Me.BunifuFlatButton8.IconMarginLeft = 0
        Me.BunifuFlatButton8.IconMarginRight = 0
        Me.BunifuFlatButton8.IconRightVisible = True
        Me.BunifuFlatButton8.IconRightZoom = 0R
        Me.BunifuFlatButton8.IconVisible = True
        Me.BunifuFlatButton8.IconZoom = 90.0R
        Me.BunifuFlatButton8.IsTab = False
        Me.BunifuFlatButton8.Location = New System.Drawing.Point(30, 282)
        Me.BunifuFlatButton8.Name = "BunifuFlatButton8"
        Me.BunifuFlatButton8.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BunifuFlatButton8.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton8.selected = False
        Me.BunifuFlatButton8.Size = New System.Drawing.Size(226, 37)
        Me.BunifuFlatButton8.TabIndex = 115
        Me.BunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton8.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton8.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(209, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 15)
        Me.Label5.TabIndex = 123
        Me.Label5.Text = "Please Wait..."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(209, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 15)
        Me.Label3.TabIndex = 122
        Me.Label3.Text = "Please Wait..."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(77, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 15)
        Me.Label2.TabIndex = 121
        Me.Label2.Text = "SYSTEM TYPE : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(77, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 15)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "OS NAME : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 2
        Me.BunifuSeparator2.Location = New System.Drawing.Point(383, 242)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(139, 18)
        Me.BunifuSeparator2.TabIndex = 129
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(297, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 15)
        Me.Label6.TabIndex = 124
        Me.Label6.Text = "Windows x32"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 2
        Me.BunifuFlatButton3.ButtonText = "Remove"
        Me.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Iconimage = Nothing
        Me.BunifuFlatButton3.Iconimage_right = Nothing
        Me.BunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton3.Iconimage_Selected = Nothing
        Me.BunifuFlatButton3.IconMarginLeft = 0
        Me.BunifuFlatButton3.IconMarginRight = 0
        Me.BunifuFlatButton3.IconRightVisible = True
        Me.BunifuFlatButton3.IconRightZoom = 0R
        Me.BunifuFlatButton3.IconVisible = True
        Me.BunifuFlatButton3.IconZoom = 60.0R
        Me.BunifuFlatButton3.IsTab = False
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(304, 337)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(218, 29)
        Me.BunifuFlatButton3.TabIndex = 128
        Me.BunifuFlatButton3.Text = "Remove"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton4
        '
        Me.BunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton4.BorderRadius = 2
        Me.BunifuFlatButton4.ButtonText = ""
        Me.BunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.Iconimage = Nothing
        Me.BunifuFlatButton4.Iconimage_right = Nothing
        Me.BunifuFlatButton4.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton4.Iconimage_Selected = Nothing
        Me.BunifuFlatButton4.IconMarginLeft = 0
        Me.BunifuFlatButton4.IconMarginRight = 0
        Me.BunifuFlatButton4.IconRightVisible = True
        Me.BunifuFlatButton4.IconRightZoom = 0R
        Me.BunifuFlatButton4.IconVisible = True
        Me.BunifuFlatButton4.IconZoom = 90.0R
        Me.BunifuFlatButton4.IsTab = False
        Me.BunifuFlatButton4.Location = New System.Drawing.Point(300, 333)
        Me.BunifuFlatButton4.Name = "BunifuFlatButton4"
        Me.BunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton4.selected = False
        Me.BunifuFlatButton4.Size = New System.Drawing.Size(226, 37)
        Me.BunifuFlatButton4.TabIndex = 127
        Me.BunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton4.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton4.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton5
        '
        Me.BunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton5.BorderRadius = 2
        Me.BunifuFlatButton5.ButtonText = "Install"
        Me.BunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.Iconimage = Nothing
        Me.BunifuFlatButton5.Iconimage_right = Nothing
        Me.BunifuFlatButton5.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton5.Iconimage_Selected = Nothing
        Me.BunifuFlatButton5.IconMarginLeft = 0
        Me.BunifuFlatButton5.IconMarginRight = 0
        Me.BunifuFlatButton5.IconRightVisible = True
        Me.BunifuFlatButton5.IconRightZoom = 0R
        Me.BunifuFlatButton5.IconVisible = True
        Me.BunifuFlatButton5.IconZoom = 60.0R
        Me.BunifuFlatButton5.IsTab = False
        Me.BunifuFlatButton5.Location = New System.Drawing.Point(304, 286)
        Me.BunifuFlatButton5.Name = "BunifuFlatButton5"
        Me.BunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.BunifuFlatButton5.selected = False
        Me.BunifuFlatButton5.Size = New System.Drawing.Size(218, 29)
        Me.BunifuFlatButton5.TabIndex = 126
        Me.BunifuFlatButton5.Text = "Install"
        Me.BunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton5.Textcolor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BunifuFlatButton5.TextFont = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton6
        '
        Me.BunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BunifuFlatButton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton6.BorderRadius = 2
        Me.BunifuFlatButton6.ButtonText = ""
        Me.BunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton6.Iconimage = Nothing
        Me.BunifuFlatButton6.Iconimage_right = Nothing
        Me.BunifuFlatButton6.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton6.Iconimage_Selected = Nothing
        Me.BunifuFlatButton6.IconMarginLeft = 0
        Me.BunifuFlatButton6.IconMarginRight = 0
        Me.BunifuFlatButton6.IconRightVisible = True
        Me.BunifuFlatButton6.IconRightZoom = 0R
        Me.BunifuFlatButton6.IconVisible = True
        Me.BunifuFlatButton6.IconZoom = 90.0R
        Me.BunifuFlatButton6.IsTab = False
        Me.BunifuFlatButton6.Location = New System.Drawing.Point(300, 282)
        Me.BunifuFlatButton6.Name = "BunifuFlatButton6"
        Me.BunifuFlatButton6.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton6.selected = False
        Me.BunifuFlatButton6.Size = New System.Drawing.Size(226, 37)
        Me.BunifuFlatButton6.TabIndex = 125
        Me.BunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton6.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton6.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuSeparator5
        '
        Me.BunifuSeparator5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuSeparator5.LineThickness = 2
        Me.BunifuSeparator5.Location = New System.Drawing.Point(31, 393)
        Me.BunifuSeparator5.Name = "BunifuSeparator5"
        Me.BunifuSeparator5.Size = New System.Drawing.Size(490, 18)
        Me.BunifuSeparator5.TabIndex = 130
        Me.BunifuSeparator5.Transparency = 255
        Me.BunifuSeparator5.Vertical = False
        '
        'TapDriver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(560, 435)
        Me.Controls.Add(Me.BunifuSeparator5)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BunifuFlatButton3)
        Me.Controls.Add(Me.BunifuFlatButton4)
        Me.Controls.Add(Me.BunifuFlatButton5)
        Me.Controls.Add(Me.BunifuFlatButton6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BunifuSeparator4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.BunifuFlatButton2)
        Me.Controls.Add(Me.BunifuFlatButton7)
        Me.Controls.Add(Me.BunifuFlatButton8)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.BunifuSeparator3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PanelLine)
        Me.Controls.Add(Me.NavBar)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TapDriver"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TapDriver"
        Me.NavBar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PanelLine As Panel
    Friend WithEvents NavBar As Panel
    Friend WithEvents BtnClose As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator3 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label4 As Label
    Friend WithEvents BunifuSeparator5 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label6 As Label
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton4 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton5 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton6 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuSeparator4 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label8 As Label
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton7 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton8 As Bunifu.Framework.UI.BunifuFlatButton
End Class
