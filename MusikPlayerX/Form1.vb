'Imports the libZPlay Namespace
'libZPlay is a free Audio library, A library is a collection of classes, stored in DLLs
'While libZPlay can be exported into a dll and access it's functions, you can import from the
'source itself

'note, only available on x86 (32-bit)  always target to x86
Imports MusikPlayerX.libZPlay
Public Class Form1
    Dim player As New ZPlay
    Dim filename As String

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


    End Sub

    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        player.OpenFile("C:\Users\danma\Downloads\Blood Moon Waltz.mp3", TStreamFormat.sfMp3)
        player.StartPlayback()
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        If OFDprime.ShowDialog = Windows.Forms.DialogResult.OK Then
            filename = OFDprime.FileName
            player.OpenFile(filename, TStreamFormat.sfMp3)
            player.StartPlayback()

            Timer1.Start()
            Timer2.Start()
        End If
    End Sub

    Dim leftvux As Integer = 0         'for the VU testing
    Dim rightvux As Integer = 0

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        player.GetVUData(leftvux, rightvux)
        pbarLeft.Value = leftvux
        pbarRight.Value = rightvux
        PictureBox1.Refresh()

    End Sub

    Private Sub btnBPM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBPM.Click
        lblBPM.Text = player.DetectBPM(TBPMDetectionMethod.dmAutoCorrelation)
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


    Private Sub VScrollBar1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VScrollBar1.ValueChanged
        If player IsNot Nothing Then
            player.SetEqualizerBandGain(0, 12000 - (CType(sender, VScrollBar)).Value * 1000)
        End If
    End Sub

    Private Sub chkEQ_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEQ.CheckedChanged
        If chkEQ.Checked = True Then
            player.EnableEqualizer(True)
        Else
            player.EnableEqualizer(False)
        End If
    End Sub

    Private Sub VScrollBar2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VScrollBar2.ValueChanged
        If player IsNot Nothing Then
            player.SetEqualizerBandGain(1, 12000 - (CType(sender, VScrollBar)).Value * 1000)
        End If
    End Sub

    Private Sub VScrollBar3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VScrollBar3.ValueChanged
        If player IsNot Nothing Then
            player.SetEqualizerBandGain(2, 12000 - (CType(sender, VScrollBar)).Value * 1000)
        End If
    End Sub

    Private Sub VScrollBar4_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VScrollBar4.ValueChanged
        If player IsNot Nothing Then
            player.SetEqualizerBandGain(3, 12000 - (CType(sender, VScrollBar)).Value * 1000)
        End If
    End Sub

    Private Sub VScrollBar5_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VScrollBar5.ValueChanged
        If player IsNot Nothing Then
            player.SetEqualizerBandGain(4, 12000 - (CType(sender, VScrollBar)).Value * 1000)
        End If
    End Sub

    Private Sub VScrollBar10_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VScrollBar10.ValueChanged
        If player IsNot Nothing Then
            player.SetEqualizerBandGain(5, 12000 - (CType(sender, VScrollBar)).Value * 1000)
        End If
    End Sub

    Private Sub VScrollBar9_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VScrollBar9.ValueChanged
        If player IsNot Nothing Then
            player.SetEqualizerBandGain(6, 12000 - (CType(sender, VScrollBar)).Value * 1000)
        End If
    End Sub

    Private Sub VScrollBar8_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VScrollBar8.ValueChanged
        If player IsNot Nothing Then
            player.SetEqualizerBandGain(7, 12000 - (CType(sender, VScrollBar)).Value * 1000)
        End If
    End Sub

    Private Sub VScrollBar7_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VScrollBar7.ValueChanged
        If player IsNot Nothing Then
            player.SetEqualizerBandGain(8, 12000 - (CType(sender, VScrollBar)).Value * 1000)
        End If
    End Sub

    Private Sub VScrollBar6_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VScrollBar6.ValueChanged
        If player IsNot Nothing Then
            player.SetEqualizerBandGain(9, 12000 - (CType(sender, VScrollBar)).Value * 1000)
        End If
    End Sub

    Private Sub btnEQAC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEQAC.Click
        VScrollBar1.Value = 12
        VScrollBar2.Value = 13
        VScrollBar3.Value = 14
        VScrollBar4.Value = 18
        VScrollBar5.Value = 13
        VScrollBar10.Value = 12
        VScrollBar9.Value = 16
        VScrollBar8.Value = 13
        VScrollBar7.Value = 12
        VScrollBar6.Value = 16

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        VScrollBar1.Value = 11
        VScrollBar2.Value = 13
        VScrollBar3.Value = 14
        VScrollBar4.Value = 16
        VScrollBar5.Value = 18
        VScrollBar10.Value = 20
        VScrollBar9.Value = 20
        VScrollBar8.Value = 20
        VScrollBar7.Value = 20
        VScrollBar6.Value = 20
    End Sub
End Class
