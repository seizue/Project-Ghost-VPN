<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As AnimatorNS.Animation = New AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PanelLine = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Home1 = New Ghost_Cyber_VPN.Home()
        Me.Settings1 = New Ghost_Cyber_VPN.Settings()
        Me.About1 = New Ghost_Cyber_VPN.About()
        Me.Indicator = New System.Windows.Forms.PictureBox()
        Me.BtnAbout = New System.Windows.Forms.Label()
        Me.BtnSettings = New System.Windows.Forms.Label()
        Me.BtnHome = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Animator1 = New AnimatorNS.Animator(Me.components)
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BtnAccount = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BtnClose = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.NavBar = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DisconnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TimerLog = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Indicator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBar.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
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
        Me.Animator1.SetDecoration(Me.PanelLine, AnimatorNS.DecorationType.None)
        Me.PanelLine.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLine.Location = New System.Drawing.Point(0, 29)
        Me.PanelLine.Name = "PanelLine"
        Me.PanelLine.Size = New System.Drawing.Size(612, 2)
        Me.PanelLine.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Indicator)
        Me.Panel1.Controls.Add(Me.BtnAbout)
        Me.Panel1.Controls.Add(Me.BtnSettings)
        Me.Panel1.Controls.Add(Me.BtnHome)
        Me.Animator1.SetDecoration(Me.Panel1, AnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 134)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(612, 395)
        Me.Panel1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Home1)
        Me.Panel2.Controls.Add(Me.Settings1)
        Me.Panel2.Controls.Add(Me.About1)
        Me.Animator1.SetDecoration(Me.Panel2, AnimatorNS.DecorationType.None)
        Me.Panel2.Location = New System.Drawing.Point(23, 51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(565, 319)
        Me.Panel2.TabIndex = 4
        '
        'Home1
        '
        Me.Home1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Animator1.SetDecoration(Me.Home1, AnimatorNS.DecorationType.None)
        Me.Home1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Home1.Location = New System.Drawing.Point(0, 0)
        Me.Home1.Name = "Home1"
        Me.Home1.Size = New System.Drawing.Size(565, 319)
        Me.Home1.TabIndex = 2
        '
        'Settings1
        '
        Me.Settings1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Animator1.SetDecoration(Me.Settings1, AnimatorNS.DecorationType.None)
        Me.Settings1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Settings1.Location = New System.Drawing.Point(0, 0)
        Me.Settings1.Name = "Settings1"
        Me.Settings1.Size = New System.Drawing.Size(565, 319)
        Me.Settings1.TabIndex = 1
        '
        'About1
        '
        Me.About1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Animator1.SetDecoration(Me.About1, AnimatorNS.DecorationType.None)
        Me.About1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.About1.Location = New System.Drawing.Point(0, 0)
        Me.About1.Name = "About1"
        Me.About1.Size = New System.Drawing.Size(565, 319)
        Me.About1.TabIndex = 0
        '
        'Indicator
        '
        Me.Indicator.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Animator1.SetDecoration(Me.Indicator, AnimatorNS.DecorationType.None)
        Me.Indicator.Location = New System.Drawing.Point(32, 43)
        Me.Indicator.Name = "Indicator"
        Me.Indicator.Size = New System.Drawing.Size(72, 2)
        Me.Indicator.TabIndex = 3
        Me.Indicator.TabStop = False
        '
        'BtnAbout
        '
        Me.BtnAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Animator1.SetDecoration(Me.BtnAbout, AnimatorNS.DecorationType.None)
        Me.BtnAbout.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAbout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.BtnAbout.Location = New System.Drawing.Point(264, 17)
        Me.BtnAbout.Name = "BtnAbout"
        Me.BtnAbout.Size = New System.Drawing.Size(72, 23)
        Me.BtnAbout.TabIndex = 2
        Me.BtnAbout.Text = "ABOUT"
        Me.BtnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSettings
        '
        Me.BtnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Animator1.SetDecoration(Me.BtnSettings, AnimatorNS.DecorationType.None)
        Me.BtnSettings.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.BtnSettings.Location = New System.Drawing.Point(152, 17)
        Me.BtnSettings.Name = "BtnSettings"
        Me.BtnSettings.Size = New System.Drawing.Size(72, 23)
        Me.BtnSettings.TabIndex = 1
        Me.BtnSettings.Text = "SETTINGS"
        Me.BtnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnHome
        '
        Me.BtnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Animator1.SetDecoration(Me.BtnHome, AnimatorNS.DecorationType.None)
        Me.BtnHome.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.BtnHome.Location = New System.Drawing.Point(32, 17)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(72, 23)
        Me.BtnHome.TabIndex = 0
        Me.BtnHome.Text = "HOME"
        Me.BtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Animator1.SetDecoration(Me.Panel7, AnimatorNS.DecorationType.None)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 132)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(612, 2)
        Me.Panel7.TabIndex = 8
        '
        'Animator1
        '
        Me.Animator1.AnimationType = AnimatorNS.AnimationType.HorizSlide
        Me.Animator1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.Animator1.DefaultAnimation = Animation1
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 2
        Me.BunifuThinButton22.ActiveCornerRadius = 41
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = ""
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Animator1.SetDecoration(Me.BunifuThinButton22, AnimatorNS.DecorationType.None)
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleBorderThickness = 2
        Me.BunifuThinButton22.IdleCornerRadius = 41
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BunifuThinButton22.Location = New System.Drawing.Point(520, 103)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(46, 56)
        Me.BunifuThinButton22.TabIndex = 10
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnAccount
        '
        Me.BtnAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BtnAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Animator1.SetDecoration(Me.BtnAccount, AnimatorNS.DecorationType.None)
        Me.BtnAccount.Image = Global.Ghost_Cyber_VPN.My.Resources.Resources.Plus_Math_48px
        Me.BtnAccount.ImageActive = Nothing
        Me.BtnAccount.Location = New System.Drawing.Point(531, 119)
        Me.BtnAccount.Name = "BtnAccount"
        Me.BtnAccount.Size = New System.Drawing.Size(26, 26)
        Me.BtnAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnAccount.TabIndex = 19
        Me.BtnAccount.TabStop = False
        Me.BtnAccount.Zoom = 10
        '
        'BtnClose
        '
        Me.BtnClose.ActiveBorderThickness = 1
        Me.BtnClose.ActiveCornerRadius = 10
        Me.BtnClose.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BtnClose.ActiveForecolor = System.Drawing.Color.White
        Me.BtnClose.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.ButtonText = ""
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Animator1.SetDecoration(Me.BtnClose, AnimatorNS.DecorationType.None)
        Me.BtnClose.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.SeaGreen
        Me.BtnClose.IdleBorderThickness = 1
        Me.BtnClose.IdleCornerRadius = 10
        Me.BtnClose.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BtnClose.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BtnClose.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BtnClose.Location = New System.Drawing.Point(586, 3)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(12, 22)
        Me.BtnClose.TabIndex = 7
        Me.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 10
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuThinButton21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = ""
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Animator1.SetDecoration(Me.BunifuThinButton21, AnimatorNS.DecorationType.None)
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 10
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuThinButton21.Location = New System.Drawing.Point(564, 3)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(12, 22)
        Me.BunifuThinButton21.TabIndex = 8
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NavBar
        '
        Me.NavBar.Controls.Add(Me.BunifuThinButton21)
        Me.NavBar.Controls.Add(Me.BtnClose)
        Me.Animator1.SetDecoration(Me.NavBar, AnimatorNS.DecorationType.None)
        Me.NavBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.NavBar.Location = New System.Drawing.Point(0, 0)
        Me.NavBar.Name = "NavBar"
        Me.NavBar.Size = New System.Drawing.Size(612, 29)
        Me.NavBar.TabIndex = 5
        '
        'ContextMenuStrip1
        '
        Me.Animator1.SetDecoration(Me.ContextMenuStrip1, AnimatorNS.DecorationType.None)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisconnectToolStripMenuItem, Me.ShowToolStripMenuItem, Me.HideToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(134, 92)
        Me.ContextMenuStrip1.Text = "Cyber VPN Beta"
        '
        'DisconnectToolStripMenuItem
        '
        Me.DisconnectToolStripMenuItem.Name = "DisconnectToolStripMenuItem"
        Me.DisconnectToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.DisconnectToolStripMenuItem.Text = "Disconnect"
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ShowToolStripMenuItem.Text = "Show"
        '
        'HideToolStripMenuItem
        '
        Me.HideToolStripMenuItem.Name = "HideToolStripMenuItem"
        Me.HideToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.HideToolStripMenuItem.Text = "Hide"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Cyber VPN Beta"
        Me.NotifyIcon1.Visible = True
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.NavBar
        Me.BunifuDragControl1.Vertical = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(612, 529)
        Me.Controls.Add(Me.BtnAccount)
        Me.Controls.Add(Me.BunifuThinButton22)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelLine)
        Me.Controls.Add(Me.NavBar)
        Me.Animator1.SetDecoration(Me, AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.Indicator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAccount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavBar.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PanelLine As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnAbout As Label
    Friend WithEvents BtnSettings As Label
    Friend WithEvents BtnHome As Label
    Friend WithEvents Indicator As PictureBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Animator1 As AnimatorNS.Animator
    Friend WithEvents Settings1 As Settings
    Friend WithEvents About1 As About
    Friend WithEvents Home1 As Home
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BtnAccount As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents NavBar As Panel
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BtnClose As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DisconnectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimerLog As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
End Class
