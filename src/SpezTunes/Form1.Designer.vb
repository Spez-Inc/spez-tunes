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
        Dim ColorPack1 As gTrackBar.ColorPack = New gTrackBar.ColorPack()
        Dim ColorPack2 As gTrackBar.ColorPack = New gTrackBar.ColorPack()
        Dim ColorPack3 As gTrackBar.ColorPack = New gTrackBar.ColorPack()
        Dim ColorLinearGradient1 As gTrackBar.ColorLinearGradient = New gTrackBar.ColorLinearGradient()
        Dim ColorLinearGradient2 As gTrackBar.ColorLinearGradient = New gTrackBar.ColorLinearGradient()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ColorPack4 As gTrackBar.ColorPack = New gTrackBar.ColorPack()
        Dim ColorPack5 As gTrackBar.ColorPack = New gTrackBar.ColorPack()
        Dim ColorPack6 As gTrackBar.ColorPack = New gTrackBar.ColorPack()
        Dim ColorLinearGradient3 As gTrackBar.ColorLinearGradient = New gTrackBar.ColorLinearGradient()
        Dim ColorLinearGradient4 As gTrackBar.ColorLinearGradient = New gTrackBar.ColorLinearGradient()
        Me.ShadowPanel1 = New ShadowPanel.ShadowPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ArtistSubtitle = New System.Windows.Forms.Label()
        Me.TrackTitle = New System.Windows.Forms.Label()
        Me.NextBtn = New System.Windows.Forms.Button()
        Me.PlayPause = New System.Windows.Forms.Button()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.MenuBtn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SoundTrackBar = New gTrackBar.gTrackBar()
        Me.fullvol = New System.Windows.Forms.Button()
        Me.silent = New System.Windows.Forms.Button()
        Me.AxVLCPlugin21 = New AxAXVLC.AxVLCPlugin2()
        Me.HeaderSeporator1 = New System.Windows.Forms.PictureBox()
        Me.MaximizeButton = New System.Windows.Forms.Button()
        Me.MinimizeButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.Seekbar = New gTrackBar.gTrackBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TVTitle = New System.Windows.Forms.Label()
        Me.Itemweb = New System.Windows.Forms.Button()
        Me.ItemCUTV = New System.Windows.Forms.Button()
        Me.ItemLTV = New System.Windows.Forms.Button()
        Me.ItemStore = New System.Windows.Forms.Button()
        Me.ItemRadio = New System.Windows.Forms.Button()
        Me.ItemMovie = New System.Windows.Forms.Button()
        Me.SpezTunesTitle = New System.Windows.Forms.Label()
        Me.ItemSongs = New System.Windows.Forms.Button()
        Me.LeftR = New System.Windows.Forms.Panel()
        Me.UpR = New System.Windows.Forms.Panel()
        Me.RightR = New System.Windows.Forms.Panel()
        Me.DownR = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ShadowPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxVLCPlugin21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderSeporator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ShadowPanel1
        '
        Me.ShadowPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.ShadowPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ShadowPanel1.Controls.Add(Me.Panel2)
        Me.ShadowPanel1.Controls.Add(Me.NextBtn)
        Me.ShadowPanel1.Controls.Add(Me.PlayPause)
        Me.ShadowPanel1.Controls.Add(Me.BackBtn)
        Me.ShadowPanel1.Controls.Add(Me.MenuBtn)
        Me.ShadowPanel1.Controls.Add(Me.PictureBox2)
        Me.ShadowPanel1.Controls.Add(Me.SoundTrackBar)
        Me.ShadowPanel1.Controls.Add(Me.fullvol)
        Me.ShadowPanel1.Controls.Add(Me.silent)
        Me.ShadowPanel1.Controls.Add(Me.AxVLCPlugin21)
        Me.ShadowPanel1.Controls.Add(Me.HeaderSeporator1)
        Me.ShadowPanel1.Controls.Add(Me.MaximizeButton)
        Me.ShadowPanel1.Controls.Add(Me.MinimizeButton)
        Me.ShadowPanel1.Controls.Add(Me.CloseButton)
        Me.ShadowPanel1.Controls.Add(Me.Seekbar)
        Me.ShadowPanel1.Location = New System.Drawing.Point(-11, -1)
        Me.ShadowPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShadowPanel1.Name = "ShadowPanel1"
        Me.ShadowPanel1.PanelColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ShadowPanel1.Size = New System.Drawing.Size(994, 61)
        Me.ShadowPanel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.Controls.Add(Me.ArtistSubtitle)
        Me.Panel2.Controls.Add(Me.TrackTitle)
        Me.Panel2.Location = New System.Drawing.Point(285, 15)
        Me.Panel2.MaximumSize = New System.Drawing.Size(424, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(424, 29)
        Me.Panel2.TabIndex = 13
        '
        'ArtistSubtitle
        '
        Me.ArtistSubtitle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ArtistSubtitle.Font = New System.Drawing.Font("Calibri", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ArtistSubtitle.ForeColor = System.Drawing.Color.Gray
        Me.ArtistSubtitle.Location = New System.Drawing.Point(0, 15)
        Me.ArtistSubtitle.Name = "ArtistSubtitle"
        Me.ArtistSubtitle.Size = New System.Drawing.Size(424, 14)
        Me.ArtistSubtitle.TabIndex = 1
        Me.ArtistSubtitle.Text = "SpezTunes"
        Me.ArtistSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TrackTitle
        '
        Me.TrackTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.TrackTitle.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TrackTitle.Location = New System.Drawing.Point(0, 0)
        Me.TrackTitle.Name = "TrackTitle"
        Me.TrackTitle.Size = New System.Drawing.Size(424, 15)
        Me.TrackTitle.TabIndex = 0
        Me.TrackTitle.Text = "No tracks playing."
        Me.TrackTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NextBtn
        '
        Me.NextBtn.BackgroundImage = Global.SpezTunes.My.Resources.Resources.skip_next_black_192x192
        Me.NextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.NextBtn.FlatAppearance.BorderSize = 0
        Me.NextBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.NextBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.NextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NextBtn.Location = New System.Drawing.Point(216, 22)
        Me.NextBtn.Name = "NextBtn"
        Me.NextBtn.Size = New System.Drawing.Size(16, 16)
        Me.NextBtn.TabIndex = 12
        Me.NextBtn.UseVisualStyleBackColor = True
        '
        'PlayPause
        '
        Me.PlayPause.BackgroundImage = Global.SpezTunes.My.Resources.Resources.play_arrow_black_192x192
        Me.PlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PlayPause.FlatAppearance.BorderSize = 0
        Me.PlayPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.PlayPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.PlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlayPause.Location = New System.Drawing.Point(186, 22)
        Me.PlayPause.Name = "PlayPause"
        Me.PlayPause.Size = New System.Drawing.Size(16, 16)
        Me.PlayPause.TabIndex = 12
        Me.PlayPause.UseVisualStyleBackColor = True
        '
        'BackBtn
        '
        Me.BackBtn.BackgroundImage = Global.SpezTunes.My.Resources.Resources.skip_previous_black_192x192
        Me.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BackBtn.FlatAppearance.BorderSize = 0
        Me.BackBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BackBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackBtn.Location = New System.Drawing.Point(156, 22)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(16, 16)
        Me.BackBtn.TabIndex = 12
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'MenuBtn
        '
        Me.MenuBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuBtn.BackgroundImage = Global.SpezTunes.My.Resources.Resources.menu_black_18x18
        Me.MenuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MenuBtn.FlatAppearance.BorderSize = 0
        Me.MenuBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.MenuBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.MenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuBtn.Location = New System.Drawing.Point(933, 22)
        Me.MenuBtn.Name = "MenuBtn"
        Me.MenuBtn.Size = New System.Drawing.Size(16, 16)
        Me.MenuBtn.TabIndex = 11
        Me.MenuBtn.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(910, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1, 55)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'SoundTrackBar
        '
        Me.SoundTrackBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SoundTrackBar.BackColor = System.Drawing.Color.Transparent
        ColorPack1.Border = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(152, Byte), Integer))
        ColorPack1.Face = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(152, Byte), Integer))
        ColorPack1.Highlight = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.SoundTrackBar.ColorDown = ColorPack1
        ColorPack2.Border = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(152, Byte), Integer))
        ColorPack2.Face = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(152, Byte), Integer))
        ColorPack2.Highlight = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.SoundTrackBar.ColorHover = ColorPack2
        ColorPack3.Border = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(152, Byte), Integer))
        ColorPack3.Face = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(152, Byte), Integer))
        ColorPack3.Highlight = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.SoundTrackBar.ColorUp = ColorPack3
        Me.SoundTrackBar.FloatValue = False
        Me.SoundTrackBar.FloatValueFontColor = System.Drawing.Color.White
        Me.SoundTrackBar.ForeColor = System.Drawing.Color.DimGray
        Me.SoundTrackBar.Label = Nothing
        Me.SoundTrackBar.LabelAlighnment = System.Drawing.StringAlignment.Center
        Me.SoundTrackBar.LabelColor = System.Drawing.Color.DimGray
        Me.SoundTrackBar.Location = New System.Drawing.Point(752, 18)
        Me.SoundTrackBar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.SoundTrackBar.MaxValue = 100
        Me.SoundTrackBar.Name = "SoundTrackBar"
        Me.SoundTrackBar.Size = New System.Drawing.Size(100, 24)
        Me.SoundTrackBar.SliderCapEnd = System.Drawing.Drawing2D.LineCap.Flat
        Me.SoundTrackBar.SliderCapStart = System.Drawing.Drawing2D.LineCap.Flat
        ColorLinearGradient1.ColorA = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(186, Byte), Integer))
        ColorLinearGradient1.ColorB = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.SoundTrackBar.SliderColorHigh = ColorLinearGradient1
        ColorLinearGradient2.ColorA = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(152, Byte), Integer))
        ColorLinearGradient2.ColorB = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.SoundTrackBar.SliderColorLow = ColorLinearGradient2
        Me.SoundTrackBar.SliderHighlightPt = CType(resources.GetObject("SoundTrackBar.SliderHighlightPt"), System.Drawing.PointF)
        Me.SoundTrackBar.SliderSize = New System.Drawing.Size(10, 10)
        Me.SoundTrackBar.SliderWidthHigh = 3.0!
        Me.SoundTrackBar.SliderWidthLow = 3.0!
        Me.SoundTrackBar.TabIndex = 9
        Me.SoundTrackBar.TickColor = System.Drawing.Color.Gray
        Me.SoundTrackBar.TickThickness = 1.0!
        Me.SoundTrackBar.UpDownShow = False
        Me.SoundTrackBar.Value = 100
        Me.SoundTrackBar.ValueAdjusted = 100.0!
        Me.SoundTrackBar.ValueBoxBackColor = System.Drawing.Color.Transparent
        Me.SoundTrackBar.ValueBoxBorder = System.Drawing.Color.Transparent
        Me.SoundTrackBar.ValueBoxFont = New System.Drawing.Font("Arial", 1.0!)
        Me.SoundTrackBar.ValueBoxFontColor = System.Drawing.Color.Transparent
        Me.SoundTrackBar.ValueBoxShape = gTrackBar.gTrackBar.eShape.ArrowRight
        Me.SoundTrackBar.ValueBoxSize = New System.Drawing.Size(0, 0)
        Me.SoundTrackBar.ValueDivisor = gTrackBar.gTrackBar.eValueDivisor.e1
        Me.SoundTrackBar.ValueStrFormat = Nothing
        '
        'fullvol
        '
        Me.fullvol.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fullvol.BackgroundImage = Global.SpezTunes.My.Resources.Resources.volume_up_black_192x192
        Me.fullvol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.fullvol.FlatAppearance.BorderSize = 0
        Me.fullvol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.fullvol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.fullvol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fullvol.Location = New System.Drawing.Point(857, 18)
        Me.fullvol.Name = "fullvol"
        Me.fullvol.Size = New System.Drawing.Size(24, 24)
        Me.fullvol.TabIndex = 7
        Me.fullvol.UseVisualStyleBackColor = True
        '
        'silent
        '
        Me.silent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.silent.BackgroundImage = Global.SpezTunes.My.Resources.Resources.volume_off_grey_192x192
        Me.silent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.silent.FlatAppearance.BorderSize = 0
        Me.silent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.silent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.silent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.silent.Location = New System.Drawing.Point(723, 18)
        Me.silent.Name = "silent"
        Me.silent.Size = New System.Drawing.Size(24, 24)
        Me.silent.TabIndex = 8
        Me.silent.UseVisualStyleBackColor = True
        '
        'AxVLCPlugin21
        '
        Me.AxVLCPlugin21.Enabled = True
        Me.AxVLCPlugin21.Location = New System.Drawing.Point(139, 4)
        Me.AxVLCPlugin21.Name = "AxVLCPlugin21"
        Me.AxVLCPlugin21.OcxState = CType(resources.GetObject("AxVLCPlugin21.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVLCPlugin21.Size = New System.Drawing.Size(1, 1)
        Me.AxVLCPlugin21.TabIndex = 6
        Me.AxVLCPlugin21.Visible = False
        '
        'HeaderSeporator1
        '
        Me.HeaderSeporator1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.HeaderSeporator1.Location = New System.Drawing.Point(132, 1)
        Me.HeaderSeporator1.Name = "HeaderSeporator1"
        Me.HeaderSeporator1.Size = New System.Drawing.Size(1, 55)
        Me.HeaderSeporator1.TabIndex = 5
        Me.HeaderSeporator1.TabStop = False
        '
        'MaximizeButton
        '
        Me.MaximizeButton.BackgroundImage = Global.SpezTunes.My.Resources.Resources.FullScreen
        Me.MaximizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MaximizeButton.FlatAppearance.BorderSize = 0
        Me.MaximizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.MaximizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MaximizeButton.Location = New System.Drawing.Point(93, 20)
        Me.MaximizeButton.Name = "MaximizeButton"
        Me.MaximizeButton.Size = New System.Drawing.Size(16, 16)
        Me.MaximizeButton.TabIndex = 3
        Me.MaximizeButton.UseVisualStyleBackColor = True
        '
        'MinimizeButton
        '
        Me.MinimizeButton.BackgroundImage = Global.SpezTunes.My.Resources.Resources.minimize
        Me.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MinimizeButton.FlatAppearance.BorderSize = 0
        Me.MinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.MinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MinimizeButton.Location = New System.Drawing.Point(63, 20)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(16, 16)
        Me.MinimizeButton.TabIndex = 1
        Me.MinimizeButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.BackgroundImage = Global.SpezTunes.My.Resources.Resources.close
        Me.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CloseButton.FlatAppearance.BorderSize = 0
        Me.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Location = New System.Drawing.Point(33, 20)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(16, 16)
        Me.CloseButton.TabIndex = 0
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Seekbar
        '
        Me.Seekbar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Seekbar.BackColor = System.Drawing.Color.Transparent
        ColorPack4.Border = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(152, Byte), Integer))
        ColorPack4.Face = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(152, Byte), Integer))
        ColorPack4.Highlight = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.Seekbar.ColorDown = ColorPack4
        ColorPack5.Border = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(152, Byte), Integer))
        ColorPack5.Face = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(152, Byte), Integer))
        ColorPack5.Highlight = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.Seekbar.ColorHover = ColorPack5
        ColorPack6.Border = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(152, Byte), Integer))
        ColorPack6.Face = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(152, Byte), Integer))
        ColorPack6.Highlight = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.Seekbar.ColorUp = ColorPack6
        Me.Seekbar.FloatValue = False
        Me.Seekbar.FloatValueFontColor = System.Drawing.Color.White
        Me.Seekbar.ForeColor = System.Drawing.Color.DimGray
        Me.Seekbar.Label = Nothing
        Me.Seekbar.LabelAlighnment = System.Drawing.StringAlignment.Center
        Me.Seekbar.LabelColor = System.Drawing.Color.DimGray
        Me.Seekbar.Location = New System.Drawing.Point(285, 18)
        Me.Seekbar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Seekbar.MaxValue = 100
        Me.Seekbar.Name = "Seekbar"
        Me.Seekbar.Size = New System.Drawing.Size(424, 24)
        Me.Seekbar.SliderCapEnd = System.Drawing.Drawing2D.LineCap.Flat
        Me.Seekbar.SliderCapStart = System.Drawing.Drawing2D.LineCap.Flat
        ColorLinearGradient3.ColorA = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(186, Byte), Integer))
        ColorLinearGradient3.ColorB = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.Seekbar.SliderColorHigh = ColorLinearGradient3
        ColorLinearGradient4.ColorA = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(152, Byte), Integer))
        ColorLinearGradient4.ColorB = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.Seekbar.SliderColorLow = ColorLinearGradient4
        Me.Seekbar.SliderHighlightPt = CType(resources.GetObject("Seekbar.SliderHighlightPt"), System.Drawing.PointF)
        Me.Seekbar.SliderSize = New System.Drawing.Size(10, 10)
        Me.Seekbar.SliderWidthHigh = 3.0!
        Me.Seekbar.SliderWidthLow = 3.0!
        Me.Seekbar.TabIndex = 14
        Me.Seekbar.TickColor = System.Drawing.Color.Gray
        Me.Seekbar.TickThickness = 1.0!
        Me.Seekbar.UpDownShow = False
        Me.Seekbar.Value = 100
        Me.Seekbar.ValueAdjusted = 100.0!
        Me.Seekbar.ValueBoxBackColor = System.Drawing.Color.Transparent
        Me.Seekbar.ValueBoxBorder = System.Drawing.Color.Transparent
        Me.Seekbar.ValueBoxFont = New System.Drawing.Font("Arial", 1.0!)
        Me.Seekbar.ValueBoxFontColor = System.Drawing.Color.Transparent
        Me.Seekbar.ValueBoxShape = gTrackBar.gTrackBar.eShape.ArrowRight
        Me.Seekbar.ValueBoxSize = New System.Drawing.Size(0, 0)
        Me.Seekbar.ValueDivisor = gTrackBar.gTrackBar.eValueDivisor.e1
        Me.Seekbar.ValueStrFormat = Nothing
        Me.Seekbar.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.TVTitle)
        Me.Panel1.Controls.Add(Me.Itemweb)
        Me.Panel1.Controls.Add(Me.ItemCUTV)
        Me.Panel1.Controls.Add(Me.ItemLTV)
        Me.Panel1.Controls.Add(Me.ItemStore)
        Me.Panel1.Controls.Add(Me.ItemRadio)
        Me.Panel1.Controls.Add(Me.ItemMovie)
        Me.Panel1.Controls.Add(Me.SpezTunesTitle)
        Me.Panel1.Controls.Add(Me.ItemSongs)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 720)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Location = New System.Drawing.Point(199, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1, 720)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'TVTitle
        '
        Me.TVTitle.AutoSize = True
        Me.TVTitle.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.TVTitle.Location = New System.Drawing.Point(6, 239)
        Me.TVTitle.Name = "TVTitle"
        Me.TVTitle.Size = New System.Drawing.Size(70, 13)
        Me.TVTitle.TabIndex = 7
        Me.TVTitle.Text = "TELEVISION"
        '
        'Itemweb
        '
        Me.Itemweb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Itemweb.FlatAppearance.BorderSize = 0
        Me.Itemweb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Itemweb.Location = New System.Drawing.Point(0, 323)
        Me.Itemweb.Name = "Itemweb"
        Me.Itemweb.Padding = New System.Windows.Forms.Padding(4)
        Me.Itemweb.Size = New System.Drawing.Size(200, 28)
        Me.Itemweb.TabIndex = 6
        Me.Itemweb.Text = "🌐 Websites"
        Me.Itemweb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Itemweb.UseVisualStyleBackColor = True
        '
        'ItemCUTV
        '
        Me.ItemCUTV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemCUTV.FlatAppearance.BorderSize = 0
        Me.ItemCUTV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ItemCUTV.Location = New System.Drawing.Point(0, 289)
        Me.ItemCUTV.Name = "ItemCUTV"
        Me.ItemCUTV.Padding = New System.Windows.Forms.Padding(4)
        Me.ItemCUTV.Size = New System.Drawing.Size(200, 28)
        Me.ItemCUTV.TabIndex = 6
        Me.ItemCUTV.Text = "⏩ Catch-Up"
        Me.ItemCUTV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ItemCUTV.UseVisualStyleBackColor = True
        '
        'ItemLTV
        '
        Me.ItemLTV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemLTV.FlatAppearance.BorderSize = 0
        Me.ItemLTV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ItemLTV.Location = New System.Drawing.Point(0, 255)
        Me.ItemLTV.Name = "ItemLTV"
        Me.ItemLTV.Padding = New System.Windows.Forms.Padding(4)
        Me.ItemLTV.Size = New System.Drawing.Size(200, 28)
        Me.ItemLTV.TabIndex = 6
        Me.ItemLTV.Text = "📺 Live TV"
        Me.ItemLTV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ItemLTV.UseVisualStyleBackColor = True
        '
        'ItemStore
        '
        Me.ItemStore.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemStore.FlatAppearance.BorderSize = 0
        Me.ItemStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ItemStore.Location = New System.Drawing.Point(0, 192)
        Me.ItemStore.Name = "ItemStore"
        Me.ItemStore.Padding = New System.Windows.Forms.Padding(4)
        Me.ItemStore.Size = New System.Drawing.Size(200, 28)
        Me.ItemStore.TabIndex = 6
        Me.ItemStore.Text = "🛍 Store"
        Me.ItemStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ItemStore.UseVisualStyleBackColor = True
        '
        'ItemRadio
        '
        Me.ItemRadio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemRadio.FlatAppearance.BorderSize = 0
        Me.ItemRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ItemRadio.Location = New System.Drawing.Point(0, 158)
        Me.ItemRadio.Name = "ItemRadio"
        Me.ItemRadio.Padding = New System.Windows.Forms.Padding(4)
        Me.ItemRadio.Size = New System.Drawing.Size(200, 28)
        Me.ItemRadio.TabIndex = 6
        Me.ItemRadio.Text = "📻 Radio"
        Me.ItemRadio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ItemRadio.UseVisualStyleBackColor = True
        '
        'ItemMovie
        '
        Me.ItemMovie.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemMovie.FlatAppearance.BorderSize = 0
        Me.ItemMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ItemMovie.Location = New System.Drawing.Point(0, 124)
        Me.ItemMovie.Name = "ItemMovie"
        Me.ItemMovie.Padding = New System.Windows.Forms.Padding(4)
        Me.ItemMovie.Size = New System.Drawing.Size(200, 28)
        Me.ItemMovie.TabIndex = 6
        Me.ItemMovie.Text = "🎥 Movies"
        Me.ItemMovie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ItemMovie.UseVisualStyleBackColor = True
        '
        'SpezTunesTitle
        '
        Me.SpezTunesTitle.AutoSize = True
        Me.SpezTunesTitle.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.SpezTunesTitle.Location = New System.Drawing.Point(6, 74)
        Me.SpezTunesTitle.Name = "SpezTunesTitle"
        Me.SpezTunesTitle.Size = New System.Drawing.Size(72, 13)
        Me.SpezTunesTitle.TabIndex = 5
        Me.SpezTunesTitle.Text = "SPEZTUNES"
        '
        'ItemSongs
        '
        Me.ItemSongs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemSongs.FlatAppearance.BorderSize = 0
        Me.ItemSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ItemSongs.Location = New System.Drawing.Point(0, 90)
        Me.ItemSongs.Name = "ItemSongs"
        Me.ItemSongs.Padding = New System.Windows.Forms.Padding(4)
        Me.ItemSongs.Size = New System.Drawing.Size(200, 28)
        Me.ItemSongs.TabIndex = 4
        Me.ItemSongs.Text = "♪ Music"
        Me.ItemSongs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ItemSongs.UseVisualStyleBackColor = True
        '
        'LeftR
        '
        Me.LeftR.BackColor = System.Drawing.Color.Transparent
        Me.LeftR.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.LeftR.Location = New System.Drawing.Point(0, 0)
        Me.LeftR.Name = "LeftR"
        Me.LeftR.Size = New System.Drawing.Size(1, 720)
        Me.LeftR.TabIndex = 4
        '
        'UpR
        '
        Me.UpR.BackColor = System.Drawing.Color.Transparent
        Me.UpR.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.UpR.Location = New System.Drawing.Point(1, 0)
        Me.UpR.Name = "UpR"
        Me.UpR.Size = New System.Drawing.Size(960, 1)
        Me.UpR.TabIndex = 5
        '
        'RightR
        '
        Me.RightR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RightR.BackColor = System.Drawing.Color.Transparent
        Me.RightR.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.RightR.Location = New System.Drawing.Point(959, 0)
        Me.RightR.Name = "RightR"
        Me.RightR.Size = New System.Drawing.Size(1, 720)
        Me.RightR.TabIndex = 6
        '
        'DownR
        '
        Me.DownR.BackColor = System.Drawing.Color.Transparent
        Me.DownR.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.DownR.Location = New System.Drawing.Point(0, 719)
        Me.DownR.Name = "DownR"
        Me.DownR.Size = New System.Drawing.Size(960, 1)
        Me.DownR.TabIndex = 7
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1MinSize = 200
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(0, 60, 0, 0)
        Me.SplitContainer1.Panel2MinSize = 512
        Me.SplitContainer1.Size = New System.Drawing.Size(960, 720)
        Me.SplitContainer1.SplitterDistance = 200
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(960, 720)
        Me.Controls.Add(Me.DownR)
        Me.Controls.Add(Me.RightR)
        Me.Controls.Add(Me.UpR)
        Me.Controls.Add(Me.LeftR)
        Me.Controls.Add(Me.ShadowPanel1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(960, 720)
        Me.Name = "Form1"
        Me.Text = "SpezTunes"
        Me.ShadowPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxVLCPlugin21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaderSeporator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ShadowPanel1 As ShadowPanel.ShadowPanel
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents MaximizeButton As System.Windows.Forms.Button
    Friend WithEvents MinimizeButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LeftR As System.Windows.Forms.Panel
    Friend WithEvents UpR As System.Windows.Forms.Panel
    Friend WithEvents RightR As System.Windows.Forms.Panel
    Friend WithEvents DownR As System.Windows.Forms.Panel
    Friend WithEvents HeaderSeporator1 As System.Windows.Forms.PictureBox
    Friend WithEvents ItemSongs As System.Windows.Forms.Button
    Friend WithEvents SpezTunesTitle As System.Windows.Forms.Label
    Friend WithEvents ItemStore As System.Windows.Forms.Button
    Friend WithEvents ItemRadio As System.Windows.Forms.Button
    Friend WithEvents ItemMovie As System.Windows.Forms.Button
    Friend WithEvents TVTitle As System.Windows.Forms.Label
    Friend WithEvents ItemLTV As System.Windows.Forms.Button
    Friend WithEvents Itemweb As System.Windows.Forms.Button
    Friend WithEvents ItemCUTV As System.Windows.Forms.Button
    Friend WithEvents AxVLCPlugin21 As AxAXVLC.AxVLCPlugin2
    Friend WithEvents SoundTrackBar As gTrackBar.gTrackBar
    Friend WithEvents fullvol As System.Windows.Forms.Button
    Friend WithEvents silent As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuBtn As System.Windows.Forms.Button
    Friend WithEvents NextBtn As System.Windows.Forms.Button
    Friend WithEvents PlayPause As System.Windows.Forms.Button
    Friend WithEvents BackBtn As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ArtistSubtitle As System.Windows.Forms.Label
    Friend WithEvents TrackTitle As System.Windows.Forms.Label
    Friend WithEvents Seekbar As gTrackBar.gTrackBar

End Class
