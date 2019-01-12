Imports System.Drawing.Text

Public Class Form1
    Dim tbd As Boolean
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Const WM_NCHITTEST As Integer = 132
    Private Const HTCLIENT As Integer = 1
    Private Const HTCAPTION As Integer = 2
    Private m_aeroEnabled As Boolean
    Private Const CS_DROPSHADOW As Integer = 131072
    Private Const WM_NCPAINT As Integer = 133
    Private Const WM_ACTIVATEAPP As Integer = 28

    <System.Runtime.InteropServices.DllImport("dwmapi.dll")>
    Public Shared Function DwmExtendFrameIntoClientArea(ByVal hWnd As IntPtr, ByRef pMarInset As MARGINS) As Integer
    End Function

    <System.Runtime.InteropServices.DllImport("dwmapi.dll")>
    Public Shared Function DwmSetWindowAttribute(ByVal hwnd As IntPtr, ByVal attr As Integer, ByRef attrValue As Integer, ByVal attrSize As Integer) As Integer
    End Function

    <System.Runtime.InteropServices.DllImport("dwmapi.dll")>
    Public Shared Function DwmIsCompositionEnabled(ByRef pfEnabled As Integer) As Integer
    End Function

    <System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(ByVal nLeftRect As Integer, ByVal nTopRect As Integer, ByVal nRightRect As Integer, ByVal nBottomRect As Integer, ByVal nWidthEllipse As Integer, ByVal nHeightEllipse As Integer) As IntPtr
    End Function

    Public Structure MARGINS

        Public leftWidth As Integer

        Public rightWidth As Integer

        Public topHeight As Integer

        Public bottomHeight As Integer
    End Structure

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            m_aeroEnabled = CheckAeroEnabled()
            Dim cp As CreateParams = MyBase.CreateParams
            If Not m_aeroEnabled Then cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Function CheckAeroEnabled() As Boolean
        If Environment.OSVersion.Version.Major >= 6 Then
            Dim enabled As Integer = 0
            DwmIsCompositionEnabled(enabled)
            Return If((enabled = 1), True, False)
        End If

        Return False
    End Function

    Protected Overrides Sub WndProc(ByRef m As Message)
        Select Case m.Msg
            Case WM_NCPAINT
                If m_aeroEnabled Then
                    Dim v = 2
                    DwmSetWindowAttribute(Me.Handle, 2, v, 4)
                    Dim margins As MARGINS = New MARGINS() With {.bottomHeight = 1, .leftWidth = 0, .rightWidth = 0, .topHeight = 0}
                    DwmExtendFrameIntoClientArea(Me.Handle, margins)
                End If

            Case Else
        End Select

        MyBase.WndProc(m)
        If m.Msg = WM_NCHITTEST AndAlso CInt(m.Result) = HTCLIENT Then m.Result = CType(HTCAPTION, IntPtr)
    End Sub

    Private Sub Panel1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ShadowPanel1.MouseDown
        drag = True
        mousex = System.Windows.Forms.Cursor.Position.X - Me.Left
        mousey = System.Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ShadowPanel1.MouseMove
        If drag Then
            Me.Top = System.Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = System.Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Panel1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ShadowPanel1.MouseUp
        drag = False
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles CloseButton.MouseHover
        CloseButton.Location = New Point(31, 18)
        CloseButton.Size = New Size(20, 20)
        CloseButton.BackgroundImage = My.Resources.closehover
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles CloseButton.MouseLeave
        CloseButton.Location = New Point(31 + 2, 18 + 2)
        CloseButton.Size = New Size(16, 16)
        CloseButton.BackgroundImage = My.Resources.close
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        End
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles MinimizeButton.MouseHover
        MinimizeButton.Location = New Point(61, 18)
        MinimizeButton.Size = New Size(20, 20)
        MinimizeButton.BackgroundImage = My.Resources.minimizehover
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles MinimizeButton.MouseLeave
        MinimizeButton.Location = New Point(61 + 2, 18 + 2)
        MinimizeButton.Size = New Size(16, 16)
        MinimizeButton.BackgroundImage = My.Resources.minimize
    End Sub

    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles MaximizeButton.MouseHover
        MaximizeButton.Location = New Point(91, 18)
        MaximizeButton.Size = New Size(20, 20)
        MaximizeButton.BackgroundImage = My.Resources.FullScreenhover
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles MaximizeButton.MouseLeave
        MaximizeButton.Location = New Point(91 + 2, 18 + 2)
        MaximizeButton.Size = New Size(16, 16)
        MaximizeButton.BackgroundImage = My.Resources.FullScreen
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles MaximizeButton.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Panel3_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles UpR.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(Me.Size.Width, Me.Size.Height + (Me.Location.Y - MousePosition.Y))
            Me.Location = New Point(Me.Location.X, MousePosition.Y)
        End If
    End Sub

    Private Sub Panel5_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DownR.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(Me.Size.Width, MousePosition.Y - Me.Location.Y)
        End If
    End Sub

    Private Sub Panel2_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LeftR.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(Me.Size.Width + (Me.Location.X - MousePosition.X), Me.Size.Height)
            Me.Location = New Point(MousePosition.X, Me.Location.Y)
        End If
    End Sub

    Private Sub Panel4_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RightR.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(MousePosition.X - Me.Location.X, Me.Size.Height)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CustomFont As New PrivateFontCollection
        CustomFont.AddFontFile(Application.StartupPath & "/data/Font.ttf")
        TrackTitle.Font = New Font(CustomFont.Families(0), 8)
        ArtistSubtitle.Font = New Font(CustomFont.Families(0), 8)
        Me.Font = New Font(CustomFont.Families(0), 8)
        ItemSongs.PerformClick()
        AxVLCPlugin21.playlist.add("file:///C:/Users/Sarp/Music/1.mp3")
        AxVLCPlugin21.playlist.play()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ItemSongs.Click
        ItemSongs.BackColor = Color.FromArgb(243, 156, 18)
        ItemSongs.ForeColor = Color.White
        ItemMovie.BackColor = Color.Transparent
        ItemMovie.ForeColor = Color.Black
        ItemRadio.BackColor = Color.Transparent
        ItemRadio.ForeColor = Color.Black
        ItemStore.BackColor = Color.Transparent
        ItemStore.ForeColor = Color.Black
        ItemLTV.BackColor = Color.Transparent
        ItemLTV.ForeColor = Color.Black
        ItemCUTV.BackColor = Color.Transparent
        ItemCUTV.ForeColor = Color.Black
        Itemweb.BackColor = Color.Transparent
        Itemweb.ForeColor = Color.Black
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ItemMovie.Click
        ItemSongs.BackColor = Color.Transparent
        ItemSongs.ForeColor = Color.Black
        ItemMovie.BackColor = Color.FromArgb(231, 76, 60)
        ItemMovie.ForeColor = Color.White
        ItemRadio.BackColor = Color.Transparent
        ItemRadio.ForeColor = Color.Black
        ItemStore.BackColor = Color.Transparent
        ItemStore.ForeColor = Color.Black
        ItemLTV.BackColor = Color.Transparent
        ItemLTV.ForeColor = Color.Black
        ItemCUTV.BackColor = Color.Transparent
        ItemCUTV.ForeColor = Color.Black
        Itemweb.BackColor = Color.Transparent
        Itemweb.ForeColor = Color.Black
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles ItemRadio.Click
        ItemSongs.BackColor = Color.Transparent
        ItemSongs.ForeColor = Color.Black
        ItemMovie.BackColor = Color.Transparent
        ItemMovie.ForeColor = Color.Black
        ItemRadio.BackColor = Color.FromArgb(211, 84, 0)
        ItemRadio.ForeColor = Color.White
        ItemStore.BackColor = Color.Transparent
        ItemStore.ForeColor = Color.Black
        ItemLTV.BackColor = Color.Transparent
        ItemLTV.ForeColor = Color.Black
        ItemCUTV.BackColor = Color.Transparent
        ItemCUTV.ForeColor = Color.Black
        Itemweb.BackColor = Color.Transparent
        Itemweb.ForeColor = Color.Black
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles ItemStore.Click
        ItemSongs.BackColor = Color.Transparent
        ItemSongs.ForeColor = Color.Black
        ItemMovie.BackColor = Color.Transparent
        ItemMovie.ForeColor = Color.Black
        ItemRadio.BackColor = Color.Transparent
        ItemRadio.ForeColor = Color.Black
        ItemStore.BackColor = Color.FromArgb(52, 152, 219)
        ItemStore.ForeColor = Color.White
        ItemLTV.BackColor = Color.Transparent
        ItemLTV.ForeColor = Color.Black
        ItemCUTV.BackColor = Color.Transparent
        ItemCUTV.ForeColor = Color.Black
        Itemweb.BackColor = Color.Transparent
        Itemweb.ForeColor = Color.Black
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles ItemLTV.Click
        ItemSongs.BackColor = Color.Transparent
        ItemSongs.ForeColor = Color.Black
        ItemMovie.BackColor = Color.Transparent
        ItemMovie.ForeColor = Color.Black
        ItemRadio.BackColor = Color.Transparent
        ItemRadio.ForeColor = Color.Black
        ItemStore.BackColor = Color.Transparent
        ItemStore.ForeColor = Color.Black
        ItemLTV.BackColor = Color.FromArgb(46, 179, 152)
        ItemLTV.ForeColor = Color.White
        ItemCUTV.BackColor = Color.Transparent
        ItemCUTV.ForeColor = Color.Black
        Itemweb.BackColor = Color.Transparent
        Itemweb.ForeColor = Color.Black
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles ItemCUTV.Click
        ItemSongs.BackColor = Color.Transparent
        ItemSongs.ForeColor = Color.Black
        ItemMovie.BackColor = Color.Transparent
        ItemMovie.ForeColor = Color.Black
        ItemRadio.BackColor = Color.Transparent
        ItemRadio.ForeColor = Color.Black
        ItemStore.BackColor = Color.Transparent
        ItemStore.ForeColor = Color.Black
        ItemLTV.BackColor = Color.Transparent
        ItemLTV.ForeColor = Color.Black
        ItemCUTV.BackColor = Color.FromArgb(155, 89, 182)
        ItemCUTV.ForeColor = Color.White
        Itemweb.BackColor = Color.Transparent
        Itemweb.ForeColor = Color.Black
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Itemweb.Click
        ItemSongs.BackColor = Color.Transparent
        ItemSongs.ForeColor = Color.Black
        ItemMovie.BackColor = Color.Transparent
        ItemMovie.ForeColor = Color.Black
        ItemRadio.BackColor = Color.Transparent
        ItemRadio.ForeColor = Color.Black
        ItemStore.BackColor = Color.Transparent
        ItemStore.ForeColor = Color.Black
        ItemLTV.BackColor = Color.Transparent
        ItemLTV.ForeColor = Color.Black
        ItemCUTV.BackColor = Color.Transparent
        ItemCUTV.ForeColor = Color.Black
        Itemweb.BackColor = Color.FromArgb(41, 128, 185)
        Itemweb.ForeColor = Color.White
    End Sub

    Private Sub SoundTrackBar_ValueChanged(sender As Object, e As EventArgs) Handles SoundTrackBar.ValueChanged
        Try
            AxVLCPlugin21.volume = SoundTrackBar.Value
            If AxVLCPlugin21.volume > 75 Then
                fullvol.BackgroundImage = My.Resources.volume_up_black_192x192
                silent.BackgroundImage = My.Resources.volume_off_grey_192x192
            ElseIf AxVLCPlugin21.volume < 25 Then
                fullvol.BackgroundImage = My.Resources.volume_up_grey_192x192
                silent.BackgroundImage = My.Resources.volume_off_black_192x192
            Else
                fullvol.BackgroundImage = My.Resources.volume_up_grey_192x192
                silent.BackgroundImage = My.Resources.volume_off_grey_192x192
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub silent_Click(sender As Object, e As EventArgs) Handles silent.Click
        SoundTrackBar.Value = 0
    End Sub

    Private Sub fullvol_Click(sender As Object, e As EventArgs) Handles fullvol.Click
        SoundTrackBar.Value = 100
    End Sub

    Private Sub AxVLCPlugin21_MediaPlayerPaused(sender As Object, e As EventArgs) Handles AxVLCPlugin21.MediaPlayerPaused
        PlayPause.BackgroundImage = My.Resources.play_arrow_black_192x192
    End Sub

    Private Sub AxVLCPlugin21_MediaPlayerPlaying(sender As Object, e As EventArgs) Handles AxVLCPlugin21.MediaPlayerPlaying
        PlayPause.BackgroundImage = My.Resources.pause_black_192x192
        Dim a As Double = AxVLCPlugin21.input.length
        Seekbar.MaxValue = CInt(a)
    End Sub

    Private Sub PlayPause_Click(sender As Object, e As EventArgs) Handles PlayPause.Click
        If AxVLCPlugin21.playlist.isPlaying = True Then
            AxVLCPlugin21.playlist.pause()
        Else
            AxVLCPlugin21.playlist.play()
        End If
    End Sub

    Private Sub AxVLCPlugin21_MediaPlayerMediaChanged(sender As Object, e As EventArgs) Handles AxVLCPlugin21.MediaPlayerMediaChanged
        'TrackTitle.Text = ListView1.SelectedItem(0).Text
        'ArtisitSubtitle.Text = ListView1.SelectedItem(0).SubItems(1).Text
    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click, TrackTitle.Click, ArtistSubtitle.Click
        Panel2.Visible = False
        Seekbar.Visible = True
        Seekbar.Focus()
    End Sub

    Private Sub SeekBar_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Seekbar.MouseMove
        If tbd Then
            AxVLCPlugin21.input.time = CDbl(Seekbar.Value)
        End If
    End Sub

    Private Sub SeekBar_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Seekbar.MouseDown
        tbd = True
        AxVLCPlugin21.playlist.pause()
    End Sub

    Private Sub SeekBar_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Seekbar.MouseUp
        tbd = False
        AxVLCPlugin21.playlist.play()
    End Sub

    Private Sub AxVLCPlugin21_MediaPlayerTimeChanged(sender As Object, e As AxAXVLC.DVLCEvents_MediaPlayerTimeChangedEvent) Handles AxVLCPlugin21.MediaPlayerTimeChanged
        Seekbar.Value = AxVLCPlugin21.input.time
    End Sub

    Private Sub Seekbar_LostFocus(sender As Object, e As EventArgs) Handles Seekbar.LostFocus
        Panel2.Visible = True
        Seekbar.Visible = False
    End Sub
End Class
