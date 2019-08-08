<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaVSeparator1 = New Guna.UI.WinForms.GunaVSeparator()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.nav_settings = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.nav_history = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.nav_profile = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.nav_home = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.pnBody = New Guna.UI.WinForms.GunaPanel()
        Me.pn_home = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pn_settings = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pn_history = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pn_profile = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel2.SuspendLayout()
        Me.pnBody.SuspendLayout()
        Me.pn_home.SuspendLayout()
        Me.pn_settings.SuspendLayout()
        Me.pn_history.SuspendLayout()
        Me.pn_profile.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.GunaButton1)
        Me.GunaPanel1.Controls.Add(Me.GunaVSeparator1)
        Me.GunaPanel1.Controls.Add(Me.GunaPictureBox2)
        Me.GunaPanel1.Controls.Add(Me.GunaCirclePictureBox1)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaPanel1.Controls.Add(Me.GunaPictureBox1)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(880, 55)
        Me.GunaPanel1.TabIndex = 0
        '
        'GunaVSeparator1
        '
        Me.GunaVSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaVSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.GunaVSeparator1.Location = New System.Drawing.Point(802, 11)
        Me.GunaVSeparator1.Name = "GunaVSeparator1"
        Me.GunaVSeparator1.Size = New System.Drawing.Size(10, 32)
        Me.GunaVSeparator1.TabIndex = 4
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.Image = CType(resources.GetObject("GunaPictureBox2.Image"), System.Drawing.Image)
        Me.GunaPictureBox2.Location = New System.Drawing.Point(856, 22)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(12, 12)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.GunaPictureBox2.TabIndex = 3
        Me.GunaPictureBox2.TabStop = False
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.Image = CType(resources.GetObject("GunaCirclePictureBox1.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(818, 11)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 2
        Me.GunaCirclePictureBox1.TabStop = False
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(50, 17)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(47, 21)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "Guna"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.GunaPictureBox1.TabIndex = 0
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.White
        Me.GunaPanel2.Controls.Add(Me.nav_settings)
        Me.GunaPanel2.Controls.Add(Me.nav_history)
        Me.GunaPanel2.Controls.Add(Me.nav_profile)
        Me.GunaPanel2.Controls.Add(Me.nav_home)
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 55)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(880, 45)
        Me.GunaPanel2.TabIndex = 1
        '
        'nav_settings
        '
        Me.nav_settings.Animated = True
        Me.nav_settings.AnimationHoverSpeed = 0.07!
        Me.nav_settings.AnimationSpeed = 0.03!
        Me.nav_settings.BaseColor = System.Drawing.Color.White
        Me.nav_settings.BorderColor = System.Drawing.Color.Black
        Me.nav_settings.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.nav_settings.CheckedBaseColor = System.Drawing.Color.White
        Me.nav_settings.CheckedBorderColor = System.Drawing.Color.Black
        Me.nav_settings.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.nav_settings.CheckedImage = Nothing
        Me.nav_settings.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.nav_settings.Dock = System.Windows.Forms.DockStyle.Left
        Me.nav_settings.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.nav_settings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.nav_settings.Image = Nothing
        Me.nav_settings.ImageSize = New System.Drawing.Size(20, 20)
        Me.nav_settings.LineBottom = 4
        Me.nav_settings.LineColor = System.Drawing.Color.White
        Me.nav_settings.Location = New System.Drawing.Point(336, 0)
        Me.nav_settings.Name = "nav_settings"
        Me.nav_settings.OnHoverBaseColor = System.Drawing.Color.White
        Me.nav_settings.OnHoverBorderColor = System.Drawing.Color.Black
        Me.nav_settings.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.nav_settings.OnHoverImage = Nothing
        Me.nav_settings.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.nav_settings.OnPressedColor = System.Drawing.Color.Black
        Me.nav_settings.OnPressedDepth = 0
        Me.nav_settings.Size = New System.Drawing.Size(112, 45)
        Me.nav_settings.TabIndex = 3
        Me.nav_settings.Text = "Settings"
        Me.nav_settings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nav_history
        '
        Me.nav_history.Animated = True
        Me.nav_history.AnimationHoverSpeed = 0.07!
        Me.nav_history.AnimationSpeed = 0.03!
        Me.nav_history.BaseColor = System.Drawing.Color.White
        Me.nav_history.BorderColor = System.Drawing.Color.Black
        Me.nav_history.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.nav_history.CheckedBaseColor = System.Drawing.Color.White
        Me.nav_history.CheckedBorderColor = System.Drawing.Color.Black
        Me.nav_history.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.nav_history.CheckedImage = Nothing
        Me.nav_history.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.nav_history.Dock = System.Windows.Forms.DockStyle.Left
        Me.nav_history.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.nav_history.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.nav_history.Image = Nothing
        Me.nav_history.ImageSize = New System.Drawing.Size(20, 20)
        Me.nav_history.LineBottom = 4
        Me.nav_history.LineColor = System.Drawing.Color.White
        Me.nav_history.Location = New System.Drawing.Point(224, 0)
        Me.nav_history.Name = "nav_history"
        Me.nav_history.OnHoverBaseColor = System.Drawing.Color.White
        Me.nav_history.OnHoverBorderColor = System.Drawing.Color.Black
        Me.nav_history.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.nav_history.OnHoverImage = Nothing
        Me.nav_history.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.nav_history.OnPressedColor = System.Drawing.Color.Black
        Me.nav_history.OnPressedDepth = 0
        Me.nav_history.Size = New System.Drawing.Size(112, 45)
        Me.nav_history.TabIndex = 2
        Me.nav_history.Text = "History"
        Me.nav_history.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nav_profile
        '
        Me.nav_profile.Animated = True
        Me.nav_profile.AnimationHoverSpeed = 0.07!
        Me.nav_profile.AnimationSpeed = 0.03!
        Me.nav_profile.BaseColor = System.Drawing.Color.White
        Me.nav_profile.BorderColor = System.Drawing.Color.Black
        Me.nav_profile.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.nav_profile.CheckedBaseColor = System.Drawing.Color.White
        Me.nav_profile.CheckedBorderColor = System.Drawing.Color.Black
        Me.nav_profile.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.nav_profile.CheckedImage = Nothing
        Me.nav_profile.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.nav_profile.Dock = System.Windows.Forms.DockStyle.Left
        Me.nav_profile.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.nav_profile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.nav_profile.Image = Nothing
        Me.nav_profile.ImageSize = New System.Drawing.Size(20, 20)
        Me.nav_profile.LineBottom = 4
        Me.nav_profile.LineColor = System.Drawing.Color.White
        Me.nav_profile.Location = New System.Drawing.Point(112, 0)
        Me.nav_profile.Name = "nav_profile"
        Me.nav_profile.OnHoverBaseColor = System.Drawing.Color.White
        Me.nav_profile.OnHoverBorderColor = System.Drawing.Color.Black
        Me.nav_profile.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.nav_profile.OnHoverImage = Nothing
        Me.nav_profile.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.nav_profile.OnPressedColor = System.Drawing.Color.Black
        Me.nav_profile.OnPressedDepth = 0
        Me.nav_profile.Size = New System.Drawing.Size(112, 45)
        Me.nav_profile.TabIndex = 1
        Me.nav_profile.Text = "Profile"
        Me.nav_profile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nav_home
        '
        Me.nav_home.Animated = True
        Me.nav_home.AnimationHoverSpeed = 0.07!
        Me.nav_home.AnimationSpeed = 0.03!
        Me.nav_home.BaseColor = System.Drawing.Color.White
        Me.nav_home.BorderColor = System.Drawing.Color.Black
        Me.nav_home.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.nav_home.Checked = True
        Me.nav_home.CheckedBaseColor = System.Drawing.Color.White
        Me.nav_home.CheckedBorderColor = System.Drawing.Color.Black
        Me.nav_home.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.nav_home.CheckedImage = Nothing
        Me.nav_home.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.nav_home.Dock = System.Windows.Forms.DockStyle.Left
        Me.nav_home.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.nav_home.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.nav_home.Image = Nothing
        Me.nav_home.ImageSize = New System.Drawing.Size(20, 20)
        Me.nav_home.LineBottom = 4
        Me.nav_home.LineColor = System.Drawing.Color.White
        Me.nav_home.Location = New System.Drawing.Point(0, 0)
        Me.nav_home.Name = "nav_home"
        Me.nav_home.OnHoverBaseColor = System.Drawing.Color.White
        Me.nav_home.OnHoverBorderColor = System.Drawing.Color.Black
        Me.nav_home.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.nav_home.OnHoverImage = Nothing
        Me.nav_home.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.nav_home.OnPressedColor = System.Drawing.Color.Black
        Me.nav_home.OnPressedDepth = 0
        Me.nav_home.Size = New System.Drawing.Size(112, 45)
        Me.nav_home.TabIndex = 0
        Me.nav_home.Text = "Home"
        Me.nav_home.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnBody
        '
        Me.pnBody.Controls.Add(Me.pn_home)
        Me.pnBody.Controls.Add(Me.pn_settings)
        Me.pnBody.Controls.Add(Me.pn_history)
        Me.pnBody.Controls.Add(Me.pn_profile)
        Me.pnBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnBody.Location = New System.Drawing.Point(0, 100)
        Me.pnBody.Name = "pnBody"
        Me.pnBody.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.pnBody.Size = New System.Drawing.Size(880, 530)
        Me.pnBody.TabIndex = 2
        '
        'pn_home
        '
        Me.pn_home.Controls.Add(Me.Label2)
        Me.pn_home.Controls.Add(Me.Label1)
        Me.pn_home.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pn_home.Location = New System.Drawing.Point(0, 6)
        Me.pn_home.Name = "pn_home"
        Me.pn_home.Size = New System.Drawing.Size(880, 524)
        Me.pn_home.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(24, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "This is home page"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(22, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Home"
        '
        'pn_settings
        '
        Me.pn_settings.Controls.Add(Me.Label7)
        Me.pn_settings.Controls.Add(Me.Label8)
        Me.pn_settings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pn_settings.Location = New System.Drawing.Point(0, 6)
        Me.pn_settings.Name = "pn_settings"
        Me.pn_settings.Size = New System.Drawing.Size(880, 524)
        Me.pn_settings.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(27, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 21)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "This is settings page"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(25, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 32)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Settings"
        '
        'pn_history
        '
        Me.pn_history.Controls.Add(Me.Label5)
        Me.pn_history.Controls.Add(Me.Label6)
        Me.pn_history.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pn_history.Location = New System.Drawing.Point(0, 6)
        Me.pn_history.Name = "pn_history"
        Me.pn_history.Size = New System.Drawing.Size(880, 524)
        Me.pn_history.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(27, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "This is history page"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(25, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 32)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "History"
        '
        'pn_profile
        '
        Me.pn_profile.Controls.Add(Me.Label3)
        Me.pn_profile.Controls.Add(Me.Label4)
        Me.pn_profile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pn_profile.Location = New System.Drawing.Point(0, 6)
        Me.pn_profile.Name = "pn_profile"
        Me.pn_profile.Size = New System.Drawing.Size(880, 524)
        Me.pn_profile.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(36, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "This is profile page"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(34, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 32)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Profile"
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.GunaPanel1
        '
        'GunaButton1
        '
        Me.GunaButton1.Animated = True
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.White
        Me.GunaButton1.BorderSize = 1
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(710, 11)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 15
        Me.GunaButton1.Size = New System.Drawing.Size(86, 30)
        Me.GunaButton1.TabIndex = 5
        Me.GunaButton1.Text = "Upgrade"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(880, 630)
        Me.Controls.Add(Me.pnBody)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel2.ResumeLayout(False)
        Me.pnBody.ResumeLayout(False)
        Me.pn_home.ResumeLayout(False)
        Me.pn_home.PerformLayout()
        Me.pn_settings.ResumeLayout(False)
        Me.pn_settings.PerformLayout()
        Me.pn_history.ResumeLayout(False)
        Me.pn_history.PerformLayout()
        Me.pn_profile.ResumeLayout(False)
        Me.pn_profile.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaVSeparator1 As Guna.UI.WinForms.GunaVSeparator
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents nav_settings As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents nav_history As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents nav_profile As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents nav_home As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents pnBody As Guna.UI.WinForms.GunaPanel
    Friend WithEvents pn_home As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pn_settings As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents pn_history As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents pn_profile As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
End Class
