'Imports the libZPlay Namespace
'libZPlay is a free Audio library, A library is a collection of classes, stored in DLLs
'While libZPlay can be exported into a dll and access it's functions, you can import from the
'source itself

'note, only available on x86 (32-bit)  always target to x86
Imports MusikPlayerX.libZPlay
Public Class Form1
    Dim player As New ZPlay
    Dim func As New Functionality()
    Dim Fnameonly As String
    Dim leftVolume As Integer
    Dim rightVolume As Integer
    Dim rate As Integer
    Dim pitch As Integer
    Dim tempo As Integer
    Dim pLoop As Boolean = False
    Dim reverse As Boolean = False


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'echo

        Dim effect(2) As TEchoEffect
        effect(0).nLeftDelay = 2000
        effect(0).nLeftDelay = 2000
        effect(0).nLeftSrcVolume = 50
        effect(0).nLeftEchoVolume = 30
        effect(0).nRightDelay = 2000
        effect(0).nRightSrcVolume = 50
        effect(0).nRightEchoVolume = 30

        effect(1).nLeftDelay = 30
        effect(1).nLeftSrcVolume = 50
        effect(1).nLeftEchoVolume = 30
        effect(1).nRightDelay = 30
        effect(1).nRightSrcVolume = 50
        effect(1).nRightEchoVolume = 30

        player.SetEchoParam(effect, 2)

        'EQ Frequencies
        Dim EqPoints() As Integer = {32, 64, 125, 250, 500, 1000, 2000, 4000, 8000, 16000}
        player.SetEqualizerPoints(EqPoints, 10)

        'get Internal Volume
        player.GetPlayerVolume(leftVolume, rightVolume)
        tbVol.Value = leftVolume

        'set rate
        tbarRate.Value = player.GetRate()

        'set pitch
        tbPitch.Value = player.GetPitch()

        'set tempo
        tbarTempo.Value = player.GetTempo()

    End Sub

    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        Dim status As New TStreamStatus()
        player.GetStatus(status)

        If status.fPause = True Then
            player.ResumePlayback()
        Else
            func.load(player, OFDprime.FileName)
        End If


    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        If OFDprime.ShowDialog = Windows.Forms.DialogResult.OK Then
            func.load(player, OFDprime.FileName)
            Fnameonly = OFDprime.SafeFileName
        End If
        ShowInfo()
        Timer1.Start()
        Timer2.Start()
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        func.VU(player, pbarLeft, pbarRight)
        PictureBox1.Refresh()
    End Sub

    Private Sub btnBPM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBPM.Click
        lblBPM.Text = player.DetectBPM(TBPMDetectionMethod.dmAutoCorrelation).ToString() + " BPM"
        player.StartPlayback()
        Timer1.Start()
        Timer2.Start()
    End Sub


    Private Sub PictureBox1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint
        Dim deviceContext As IntPtr = e.Graphics.GetHdc()
        player.DrawFFTGraphOnHDC(deviceContext, 0, 0, PictureBox1.Width, PictureBox1.Height)
        e.Graphics.ReleaseHdc(deviceContext)
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim pos As New TStreamTime
        player.GetPosition(pos)
        Dim streamInfo As New TStreamInfo()
        player.GetStreamInfo(streamInfo)

        pbarSeek.Maximum = CInt(Fix(streamInfo.Length.sec))

        If pbarSeek.Maximum > CInt(Fix(pos.sec)) Then
            pbarSeek.Value = CInt(Fix(pos.sec))
        End If

        Label5.Text = player.GetBitrate(True).ToString() + " kbps"
        lblPOS.Text = Format(pos.hms.hour, "00") & ":" & Format(pos.hms.minute, "00") & ":" & Format(pos.hms.second, "00")
    End Sub



    Private Sub pbarSeek_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbarSeek.MouseClick
        Dim newpos As New TStreamTime()
        Dim streamInfo As New TStreamInfo()
        player.GetStreamInfo(streamInfo)
        newpos.sec = CUInt(e.X * streamInfo.Length.sec / CDbl((CType(sender, ProgressBar)).Size.Width))
        player.Seek(TTimeFormat.tfSecond, newpos, TSeekMethod.smFromBeginning)
    End Sub

    Private Sub chkEcho_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEcho.CheckedChanged
        If chkEcho.Checked = True Then
            player.EnableEcho(True)
        Else
            player.EnableEcho(False)
        End If
    End Sub





    Private Sub chkEQ_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEQ.CheckedChanged
        If chkEQ.Checked = True Then
            player.EnableEqualizer(True)
        Else
            player.EnableEqualizer(False)
        End If
    End Sub


    Private Sub tbVol_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbVol.Scroll
        player.SetPlayerVolume(tbVol.Value, tbVol.Value)
        lblVol.Text = tbVol.Value
    End Sub

    Private Sub tbarRate_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbarRate.Scroll
        player.SetRate(tbarRate.Value)
        lblRate.Text = tbarRate.Value
    End Sub

    Private Sub tbPitch_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbPitch.Scroll
        player.SetPitch(tbPitch.Value)
        lblPitch.Text = tbPitch.Value
    End Sub

    Private Sub tbarTempo_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbarTempo.Scroll
        player.SetTempo(tbarTempo.Value)
        lblTpo.Text = tbarTempo.Value
    End Sub

    Public Sub ShowInfo()
        Dim info As New TID3InfoEx()
        lblTitle.Text = ""

        If player.LoadID3Ex(info, True) Then
            If info.Title = "" Then
                lblTitle.Text = Fnameonly
            Else
                lblTitle.Text = info.Title
            End If
        End If
    End Sub


    Private Sub btnPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPause.Click
        Dim status As New TStreamStatus()
        player.GetStatus(status)

        If Convert.ToString(status.fPause) = False Then
            player.PausePlayback()
        End If
    End Sub

    Private Sub btnLoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoop.Click
        Dim status As New TStreamStatus()
        player.GetStatus(status)

        If Convert.ToString(status.fPlay) = True Then
            Dim sec, loopTimes As Integer
            Dim startpos As New TStreamTime()
            Dim endpos As New TStreamTime()
            player.GetPosition(startpos)
            sec = Val(InputBox("How many seconds until Loop from your current position", "Seconds", "1"))
            loopTimes = Val(InputBox("How many times does the loop execute", "Seconds", "3"))
            endpos.sec = CType(startpos.sec + sec, UInteger)
            player.PlayLoop(TTimeFormat.tfSecond, startpos, TTimeFormat.tfSecond, endpos, loopTimes, True)
        End If

    End Sub

    Private Sub btnRev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRev.Click
        Dim status As New TStreamStatus()
        player.GetStatus(status)

        If Convert.ToString(status.fPlay) = True Then
            If reverse = False Then
                player.ReverseMode(True)
                reverse = True
            Else
                player.ReverseMode(False)
                reverse = False
            End If
        End If
    End Sub

    'for manual EQ
    Private Sub t32_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t32.ValueChanged
        If player IsNot Nothing Then
            player.SetEqualizerBandGain(0, 12000 - (func.invert(t32.Value) * 1000))
        End If
    End Sub

    Private Sub t64_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t64.ValueChanged
        If player IsNot Nothing Then
            player.SetEqualizerBandGain(1, 12000 - (func.invert(t64.Value) * 1000))
        End If
    End Sub

    Private Sub t125_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t125.ValueChanged
        If player IsNot Nothing Then
            player.SetEqualizerBandGain(2, 12000 - (func.invert(t125.Value) * 1000))
        End If
    End Sub

    Private Sub t250_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t250.ValueChanged
        If player IsNot Nothing Then
            player.SetEqualizerBandGain(3, 12000 - (func.invert(t250.Value) * 1000))
        End If
    End Sub

    Private Sub t500_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t500.ValueChanged
        If player IsNot Nothing Then
            player.SetEqualizerBandGain(4, 12000 - (func.invert(t500.Value) * 1000))
        End If
    End Sub

    Private Sub t1000_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t1000.ValueChanged
        If player IsNot Nothing Then
            player.SetEqualizerBandGain(5, 12000 - (func.invert(t1000.Value) * 1000))
        End If
    End Sub

    Private Sub t2000_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t2000.ValueChanged
        If player IsNot Nothing Then
            player.SetEqualizerBandGain(6, 12000 - (func.invert(t2000.Value) * 1000))
        End If
    End Sub

    Private Sub t4000_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t4000.ValueChanged
        If player IsNot Nothing Then
            player.SetEqualizerBandGain(7, 12000 - (func.invert(t4000.Value) * 1000))
        End If
    End Sub

    Private Sub t8000_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t8000.ValueChanged
        If player IsNot Nothing Then
            player.SetEqualizerBandGain(8, 12000 - (func.invert(t8000.Value) * 1000))
        End If
    End Sub

    Private Sub t16000_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t16000.ValueChanged
        If player IsNot Nothing Then
            player.SetEqualizerBandGain(9, 12000 - (func.invert(t16000.Value) * 1000))
        End If
    End Sub

    'EQ presets straight from the Itunes (only an approximation tho)
    Private Sub cmbEQ_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEQ.SelectedValueChanged
        If cmbEQ.SelectedItem.ToString() = "Flat" Then
            func.EQband(t32, 12, t64, 12, t125, 12, t250, 12, t500, 12, t1000, 12, t2000, 12, t4000, 12, t8000, 12, t16000, 12)
        ElseIf cmbEQ.SelectedItem.ToString() = "Acoustics" Then
            func.EQband(t32, 17, t64, 17, t125, 16, t250, 13, t500, 14, t1000, 13, t2000, 16, t4000, 17, t8000, 16, t16000, 14)
        ElseIf cmbEQ.SelectedItem.ToString() = "Bass Booster" Then
            func.EQband(t32, 17, t64, 16, t125, 16, t250, 14, t500, 13, t1000, 12, t2000, 12, t4000, 12, t8000, 12, t16000, 12)
        ElseIf cmbEQ.SelectedItem.ToString() = "Bass Reducer" Then
            func.EQband(t32, 7, t64, 8, t125, 8, t250, 10, t500, 11, t1000, 12, t2000, 12, t4000, 12, t8000, 12, t16000, 12)
        ElseIf cmbEQ.SelectedItem.ToString() = "Classical" Then
            func.EQband(t32, 16, t64, 16, t125, 15, t250, 14, t500, 11, t1000, 11, t2000, 12, t4000, 14, t8000, 15, t16000, 16)
        ElseIf cmbEQ.SelectedItem.ToString() = "Dance" Then
            func.EQband(t32, 16, t64, 19, t125, 17, t250, 12, t500, 14, t1000, 16, t2000, 17, t4000, 16, t8000, 16, t16000, 12)
        ElseIf cmbEQ.SelectedItem.ToString() = "Deep" Then
            func.EQband(t32, 17, t64, 16, t125, 14, t250, 13, t500, 15, t1000, 14, t2000, 13, t4000, 10, t8000, 8, t16000, 7)
        ElseIf cmbEQ.SelectedItem.ToString() = "Electronic" Then
            func.EQband(t32, 16, t64, 16, t125, 13, t250, 12, t500, 10, t1000, 14, t2000, 13, t4000, 13, t8000, 16, t16000, 17)
        ElseIf cmbEQ.SelectedItem.ToString() = "Hip-Hop" Then
            func.EQband(t32, 17, t64, 16, t125, 13, t250, 15, t500, 11, t1000, 11, t2000, 13, t4000, 11, t8000, 14, t16000, 15)
        ElseIf cmbEQ.SelectedItem.ToString() = "Jazz" Then
            func.EQband(t32, 16, t64, 15, t125, 14, t250, 15, t500, 11, t1000, 11, t2000, 12, t4000, 13, t8000, 15, t16000, 16)
        ElseIf cmbEQ.SelectedItem.ToString() = "Latin" Then
            func.EQband(t32, 16, t64, 15, t125, 12, t250, 12, t500, 11, t1000, 11, t2000, 11, t4000, 12, t8000, 15, t16000, 16)
        ElseIf cmbEQ.SelectedItem.ToString() = "Loudness" Then
            func.EQband(t32, 18, t64, 16, t125, 12, t250, 12, t500, 10, t1000, 12, t2000, 11, t4000, 7, t8000, 17, t16000, 13)
        ElseIf cmbEQ.SelectedItem.ToString() = "Lounge" Then
            func.EQband(t32, 9, t64, 10, t125, 11, t250, 13, t500, 16, t1000, 14, t2000, 13, t4000, 11, t8000, 14, t16000, 13)
        ElseIf cmbEQ.SelectedItem.ToString() = "Piano" Then
            func.EQband(t32, 15, t64, 14, t125, 12, t250, 14, t500, 15, t1000, 13, t2000, 16, t4000, 17, t8000, 14, t16000, 15)
        ElseIf cmbEQ.SelectedItem.ToString() = "R&B" Then
            func.EQband(t32, 14, t64, 19, t125, 18, t250, 13, t500, 10, t1000, 11, t2000, 14, t4000, 15, t8000, 15, t16000, 16)
        ElseIf cmbEQ.SelectedItem.ToString() = "R&B" Then
            func.EQband(t32, 14, t64, 19, t125, 18, t250, 13, t500, 10, t1000, 11, t2000, 14, t4000, 15, t8000, 15, t16000, 16)
        ElseIf cmbEQ.SelectedItem.ToString() = "Rock" Then
            func.EQband(t32, 17, t64, 16, t125, 15, t250, 13, t500, 11, t1000, 11, t2000, 13, t4000, 14, t8000, 15, t16000, 16)
        ElseIf cmbEQ.SelectedItem.ToString() = "Small Speakers" Then
            func.EQband(t32, 17, t64, 16, t125, 15, t250, 14, t500, 13, t1000, 12, t2000, 11, t4000, 10, t8000, 8, t16000, 7)
        ElseIf cmbEQ.SelectedItem.ToString() = "Spoken Word" Then
            func.EQband(t32, 9, t64, 11, t125, 12, t250, 13, t500, 16, t1000, 17, t2000, 17, t4000, 16, t8000, 14, t16000, 12)
        ElseIf cmbEQ.SelectedItem.ToString() = "Treble Booster" Then
            func.EQband(t32, 12, t64, 12, t125, 12, t250, 12, t500, 12, t1000, 13, t2000, 14, t4000, 15, t8000, 16, t16000, 17)
        ElseIf cmbEQ.SelectedItem.ToString() = "Treble Reducer" Then
            func.EQband(t32, 12, t64, 12, t125, 12, t250, 12, t500, 12, t1000, 11, t2000, 10, t4000, 8, t8000, 7, t16000, 6)
        ElseIf cmbEQ.SelectedItem.ToString() = "Vocal Booster" Then
            func.EQband(t32, 11, t64, 9, t125, 9, t250, 14, t500, 16, t1000, 16, t2000, 15, t4000, 13, t8000, 12, t16000, 11)
        End If 
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        player.StopPlayback()
    End Sub

    Private Sub chkPLS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPLS.CheckedChanged
        If chkPLS.Checked = True Then
            btnPLSadd.Enabled = True
            btnPLSdel.Enabled = True
            lbPlayLst.Enabled = True
            btnLoad.Enabled = False
        Else
            btnPLSadd.Enabled = False
            btnPLSdel.Enabled = False
            lbPlayLst.Enabled = False
            btnLoad.Enabled = True
        End If
    End Sub

    Private Sub btnPLSadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPLSadd.Click
        If OFDpls.ShowDialog = Windows.Forms.DialogResult.OK Then

            playlistTitleINIT = OFDpls.SafeFileNames.ToList
            playlistLocINIT = OFDpls.FileNames.ToList
            For i As Integer = 0 To playlistTitleINIT.Count - 1
                If playlistTitle.IndexOf(playlistTitleINIT.Item(i)) = -1 Then
                    'insert playlist in listbox
                    playlistTitle.Add(playlistTitleINIT.Item(i))
                    playlistLoc.Add(playlistLocINIT(i))
                    lbPlayLst.Items.Add(playlistTitleINIT.Item(i))
                End If
            Next
        End If
    End Sub

    Private Sub btnPLSdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPLSdel.Click
        Dim index As Integer = playlistTitle.IndexOf(lbPlayLst.SelectedItem.ToString)
        If index = -1 Then
            MessageBox.Show("Select a song", "Playlist Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            playlistTitle.RemoveAt(index)
            playlistLoc.RemoveAt(index)
            lbPlayLst.Items.RemoveAt(index)
        End If
    End Sub

    Private Sub btnLegal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLegal.Click
        Licenses.ShowDialog()
    End Sub


    
    Private Sub lbPlayLst_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbPlayLst.DoubleClick
        Dim index As Integer = playlistTitle.IndexOf(lbPlayLst.SelectedItem.ToString)
        func.load(player, playlistLoc.Item(index))
        ShowInfo()
        Timer1.Start()
        Timer2.Start()
        If lblTitle.Text = "" Then
            lblTitle.Text = playlistTitle.Item(index)
        End If
    End Sub
End Class
