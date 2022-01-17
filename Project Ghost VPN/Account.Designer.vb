<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Account
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Account))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.PanelLine = New System.Windows.Forms.Panel()
        Me.NavBar = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuMaterialTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuMetroTextbox1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuMaterialTextbox2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuMetroTextbox2 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCheckbox1 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuFlatButton12 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnShowMeTheCode = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnClose = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.NavBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 2
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.NavBar
        Me.BunifuDragControl1.Vertical = True
        '
        'PanelLine
        '
        Me.PanelLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PanelLine.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLine.Location = New System.Drawing.Point(2, 31)
        Me.PanelLine.Name = "PanelLine"
        Me.PanelLine.Size = New System.Drawing.Size(410, 2)
        Me.PanelLine.TabIndex = 64
        '
        'NavBar
        '
        Me.NavBar.Controls.Add(Me.BtnClose)
        Me.NavBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.NavBar.Location = New System.Drawing.Point(2, 2)
        Me.NavBar.Name = "NavBar"
        Me.NavBar.Size = New System.Drawing.Size(410, 29)
        Me.NavBar.TabIndex = 63
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(2, 312)
        Me.Panel4.TabIndex = 62
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(412, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(3, 312)
        Me.Panel3.TabIndex = 61
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 314)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(415, 3)
        Me.Panel2.TabIndex = 60
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(415, 2)
        Me.Panel1.TabIndex = 59
        '
        'BunifuMaterialTextbox1
        '
        Me.BunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.BunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.BunifuMaterialTextbox1.HintText = "Username"
        Me.BunifuMaterialTextbox1.isPassword = False
        Me.BunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BunifuMaterialTextbox1.LineThickness = 2
        Me.BunifuMaterialTextbox1.Location = New System.Drawing.Point(87, 73)
        Me.BunifuMaterialTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox1.Name = "BunifuMaterialTextbox1"
        Me.BunifuMaterialTextbox1.Size = New System.Drawing.Size(239, 21)
        Me.BunifuMaterialTextbox1.TabIndex = 65
        Me.BunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMetroTextbox1
        '
        Me.BunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderThickness = 3
        Me.BunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.BunifuMetroTextbox1.isPassword = False
        Me.BunifuMetroTextbox1.Location = New System.Drawing.Point(75, 68)
        Me.BunifuMetroTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox1.Name = "BunifuMetroTextbox1"
        Me.BunifuMetroTextbox1.Size = New System.Drawing.Size(264, 36)
        Me.BunifuMetroTextbox1.TabIndex = 66
        Me.BunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMaterialTextbox2
        '
        Me.BunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.BunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.BunifuMaterialTextbox2.HintText = "Password"
        Me.BunifuMaterialTextbox2.isPassword = False
        Me.BunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BunifuMaterialTextbox2.LineThickness = 2
        Me.BunifuMaterialTextbox2.Location = New System.Drawing.Point(87, 122)
        Me.BunifuMaterialTextbox2.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox2.Name = "BunifuMaterialTextbox2"
        Me.BunifuMaterialTextbox2.Size = New System.Drawing.Size(239, 21)
        Me.BunifuMaterialTextbox2.TabIndex = 67
        Me.BunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMetroTextbox2
        '
        Me.BunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BunifuMetroTextbox2.BorderThickness = 3
        Me.BunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMetroTextbox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.BunifuMetroTextbox2.isPassword = False
        Me.BunifuMetroTextbox2.Location = New System.Drawing.Point(75, 117)
        Me.BunifuMetroTextbox2.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox2.Name = "BunifuMetroTextbox2"
        Me.BunifuMetroTextbox2.Size = New System.Drawing.Size(264, 36)
        Me.BunifuMetroTextbox2.TabIndex = 68
        Me.BunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCheckbox1
        '
        Me.BunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BunifuCheckbox1.Checked = False
        Me.BunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BunifuCheckbox1.ForeColor = System.Drawing.Color.White
        Me.BunifuCheckbox1.Location = New System.Drawing.Point(78, 168)
        Me.BunifuCheckbox1.Name = "BunifuCheckbox1"
        Me.BunifuCheckbox1.Size = New System.Drawing.Size(20, 20)
        Me.BunifuCheckbox1.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(101, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Show Password"
        '
        'BunifuFlatButton12
        '
        Me.BunifuFlatButton12.Activecolor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BunifuFlatButton12.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BunifuFlatButton12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton12.BorderRadius = 2
        Me.BunifuFlatButton12.ButtonText = ""
        Me.BunifuFlatButton12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton12.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton12.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton12.Iconimage = Nothing
        Me.BunifuFlatButton12.Iconimage_right = Nothing
        Me.BunifuFlatButton12.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton12.Iconimage_Selected = Nothing
        Me.BunifuFlatButton12.IconMarginLeft = 0
        Me.BunifuFlatButton12.IconMarginRight = 0
        Me.BunifuFlatButton12.IconRightVisible = True
        Me.BunifuFlatButton12.IconRightZoom = 0R
        Me.BunifuFlatButton12.IconVisible = True
        Me.BunifuFlatButton12.IconZoom = 90.0R
        Me.BunifuFlatButton12.IsTab = False
        Me.BunifuFlatButton12.Location = New System.Drawing.Point(71, 206)
        Me.BunifuFlatButton12.Name = "BunifuFlatButton12"
        Me.BunifuFlatButton12.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BunifuFlatButton12.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BunifuFlatButton12.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton12.selected = False
        Me.BunifuFlatButton12.Size = New System.Drawing.Size(272, 43)
        Me.BunifuFlatButton12.TabIndex = 71
        Me.BunifuFlatButton12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton12.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton12.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(157, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "CREATE ACCOUNT"
        '
        'BtnShowMeTheCode
        '
        Me.BtnShowMeTheCode.Activecolor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BtnShowMeTheCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BtnShowMeTheCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnShowMeTheCode.BorderRadius = 2
        Me.BtnShowMeTheCode.ButtonText = "LOGIN"
        Me.BtnShowMeTheCode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnShowMeTheCode.DisabledColor = System.Drawing.Color.Gray
        Me.BtnShowMeTheCode.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnShowMeTheCode.Iconimage = Nothing
        Me.BtnShowMeTheCode.Iconimage_right = Nothing
        Me.BtnShowMeTheCode.Iconimage_right_Selected = Nothing
        Me.BtnShowMeTheCode.Iconimage_Selected = Nothing
        Me.BtnShowMeTheCode.IconMarginLeft = 0
        Me.BtnShowMeTheCode.IconMarginRight = 0
        Me.BtnShowMeTheCode.IconRightVisible = True
        Me.BtnShowMeTheCode.IconRightZoom = 0R
        Me.BtnShowMeTheCode.IconVisible = True
        Me.BtnShowMeTheCode.IconZoom = 60.0R
        Me.BtnShowMeTheCode.IsTab = False
        Me.BtnShowMeTheCode.Location = New System.Drawing.Point(75, 210)
        Me.BtnShowMeTheCode.Name = "BtnShowMeTheCode"
        Me.BtnShowMeTheCode.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BtnShowMeTheCode.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BtnShowMeTheCode.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.BtnShowMeTheCode.selected = False
        Me.BtnShowMeTheCode.Size = New System.Drawing.Size(264, 35)
        Me.BtnShowMeTheCode.TabIndex = 72
        Me.BtnShowMeTheCode.Text = "LOGIN"
        Me.BtnShowMeTheCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnShowMeTheCode.Textcolor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BtnShowMeTheCode.TextFont = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.BtnClose.Location = New System.Drawing.Point(389, 3)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(12, 22)
        Me.BtnClose.TabIndex = 7
        Me.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(415, 317)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnShowMeTheCode)
        Me.Controls.Add(Me.BunifuFlatButton12)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BunifuCheckbox1)
        Me.Controls.Add(Me.BunifuMaterialTextbox2)
        Me.Controls.Add(Me.BunifuMetroTextbox2)
        Me.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.Controls.Add(Me.BunifuMetroTextbox1)
        Me.Controls.Add(Me.PanelLine)
        Me.Controls.Add(Me.NavBar)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Account"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account"
        Me.NavBar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents PanelLine As Panel
    Friend WithEvents NavBar As Panel
    Friend WithEvents BtnClose As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuMetroTextbox1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCheckbox1 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents BunifuMaterialTextbox2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuMetroTextbox2 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnShowMeTheCode As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton12 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label2 As Label
End Class
