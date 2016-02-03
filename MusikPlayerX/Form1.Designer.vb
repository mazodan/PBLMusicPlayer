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
        Me.components = New System.ComponentModel.Container
        Me.btnPlay = New System.Windows.Forms.Button
        Me.OFDprime = New System.Windows.Forms.OpenFileDialog
        Me.btnLoad = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.pbarLeft = New System.Windows.Forms.ProgressBar
        Me.pbarRight = New System.Windows.Forms.ProgressBar
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnBPM = New System.Windows.Forms.Button
        Me.lblBPM = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.pbarSeek = New System.Windows.Forms.ProgressBar
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.chkEcho = New System.Windows.Forms.CheckBox
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar
        Me.VScrollBar2 = New System.Windows.Forms.VScrollBar
        Me.VScrollBar3 = New System.Windows.Forms.VScrollBar
        Me.VScrollBar4 = New System.Windows.Forms.VScrollBar
        Me.VScrollBar5 = New System.Windows.Forms.VScrollBar
        Me.VScrollBar6 = New System.Windows.Forms.VScrollBar
        Me.VScrollBar7 = New System.Windows.Forms.VScrollBar
        Me.VScrollBar8 = New System.Windows.Forms.VScrollBar
        Me.VScrollBar9 = New System.Windows.Forms.VScrollBar
        Me.VScrollBar10 = New System.Windows.Forms.VScrollBar
        Me.chkEQ = New System.Windows.Forms.CheckBox
        Me.btnEQAC = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.tbVol = New System.Windows.Forms.TrackBar
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblPOS = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.tbarRate = New System.Windows.Forms.TrackBar
        Me.Label8 = New System.Windows.Forms.Label
        Me.tbPitch = New System.Windows.Forms.TrackBar
        Me.Label9 = New System.Windows.Forms.Label
        Me.tbarTempo = New System.Windows.Forms.TrackBar
        Me.lblTitle = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbVol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbarRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbPitch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbarTempo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(420, 118)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(208, 23)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "Play -FOR DEBUGGIN ONLY"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'OFDprime
        '
        Me.OFDprime.Filter = "MP3 files (*.mp3)|*.mp3"
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(475, 213)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 32)
        Me.btnLoad.TabIndex = 1
        Me.btnLoad.Text = "Load MP3"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(510, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "VU METER"
        '
        'pbarLeft
        '
        Me.pbarLeft.Location = New System.Drawing.Point(513, 43)
        Me.pbarLeft.Name = "pbarLeft"
        Me.pbarLeft.Size = New System.Drawing.Size(180, 23)
        Me.pbarLeft.TabIndex = 3
        '
        'pbarRight
        '
        Me.pbarRight.Location = New System.Drawing.Point(513, 72)
        Me.pbarRight.Name = "pbarRight"
        Me.pbarRight.Size = New System.Drawing.Size(180, 23)
        Me.pbarRight.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(494, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "L"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(494, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "R"
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'btnBPM
        '
        Me.btnBPM.Location = New System.Drawing.Point(412, 72)
        Me.btnBPM.Name = "btnBPM"
        Me.btnBPM.Size = New System.Drawing.Size(75, 23)
        Me.btnBPM.TabIndex = 7
        Me.btnBPM.Text = "Detect BPM"
        Me.btnBPM.UseVisualStyleBackColor = True
        '
        'lblBPM
        '
        Me.lblBPM.AutoSize = True
        Me.lblBPM.Location = New System.Drawing.Point(427, 102)
        Me.lblBPM.Name = "lblBPM"
        Me.lblBPM.Size = New System.Drawing.Size(34, 13)
        Me.lblBPM.TabIndex = 8
        Me.lblBPM.Text = "Beats"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(270, 333)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(365, 156)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(417, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Seek Testing"
        '
        'pbarSeek
        '
        Me.pbarSeek.Location = New System.Drawing.Point(12, 53)
        Me.pbarSeek.Name = "pbarSeek"
        Me.pbarSeek.Size = New System.Drawing.Size(357, 23)
        Me.pbarSeek.TabIndex = 11
        '
        'Timer2
        '
        Me.Timer2.Interval = 200
        '
        'chkEcho
        '
        Me.chkEcho.AutoSize = True
        Me.chkEcho.Location = New System.Drawing.Point(591, 16)
        Me.chkEcho.Name = "chkEcho"
        Me.chkEcho.Size = New System.Drawing.Size(51, 17)
        Me.chkEcho.TabIndex = 12
        Me.chkEcho.Text = "Echo"
        Me.chkEcho.UseVisualStyleBackColor = True
        '
        'VScrollBar1
        '
        Me.VScrollBar1.LargeChange = 1
        Me.VScrollBar1.Location = New System.Drawing.Point(688, 335)
        Me.VScrollBar1.Maximum = 40
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(17, 156)
        Me.VScrollBar1.TabIndex = 1
        Me.VScrollBar1.Value = 20
        '
        'VScrollBar2
        '
        Me.VScrollBar2.LargeChange = 1
        Me.VScrollBar2.Location = New System.Drawing.Point(716, 335)
        Me.VScrollBar2.Maximum = 40
        Me.VScrollBar2.Name = "VScrollBar2"
        Me.VScrollBar2.Size = New System.Drawing.Size(17, 156)
        Me.VScrollBar2.TabIndex = 2
        Me.VScrollBar2.Value = 20
        '
        'VScrollBar3
        '
        Me.VScrollBar3.LargeChange = 1
        Me.VScrollBar3.Location = New System.Drawing.Point(740, 335)
        Me.VScrollBar3.Maximum = 40
        Me.VScrollBar3.Name = "VScrollBar3"
        Me.VScrollBar3.Size = New System.Drawing.Size(17, 156)
        Me.VScrollBar3.TabIndex = 13
        Me.VScrollBar3.Value = 20
        '
        'VScrollBar4
        '
        Me.VScrollBar4.LargeChange = 1
        Me.VScrollBar4.Location = New System.Drawing.Point(767, 335)
        Me.VScrollBar4.Maximum = 40
        Me.VScrollBar4.Name = "VScrollBar4"
        Me.VScrollBar4.Size = New System.Drawing.Size(17, 156)
        Me.VScrollBar4.TabIndex = 14
        Me.VScrollBar4.Value = 20
        '
        'VScrollBar5
        '
        Me.VScrollBar5.LargeChange = 1
        Me.VScrollBar5.Location = New System.Drawing.Point(794, 335)
        Me.VScrollBar5.Maximum = 40
        Me.VScrollBar5.Name = "VScrollBar5"
        Me.VScrollBar5.Size = New System.Drawing.Size(17, 156)
        Me.VScrollBar5.TabIndex = 15
        Me.VScrollBar5.Value = 20
        '
        'VScrollBar6
        '
        Me.VScrollBar6.LargeChange = 1
        Me.VScrollBar6.Location = New System.Drawing.Point(926, 335)
        Me.VScrollBar6.Maximum = 40
        Me.VScrollBar6.Name = "VScrollBar6"
        Me.VScrollBar6.Size = New System.Drawing.Size(17, 156)
        Me.VScrollBar6.TabIndex = 20
        Me.VScrollBar6.Value = 20
        '
        'VScrollBar7
        '
        Me.VScrollBar7.LargeChange = 1
        Me.VScrollBar7.Location = New System.Drawing.Point(899, 335)
        Me.VScrollBar7.Maximum = 40
        Me.VScrollBar7.Name = "VScrollBar7"
        Me.VScrollBar7.Size = New System.Drawing.Size(17, 156)
        Me.VScrollBar7.TabIndex = 19
        Me.VScrollBar7.Value = 20
        '
        'VScrollBar8
        '
        Me.VScrollBar8.LargeChange = 1
        Me.VScrollBar8.Location = New System.Drawing.Point(872, 335)
        Me.VScrollBar8.Maximum = 40
        Me.VScrollBar8.Name = "VScrollBar8"
        Me.VScrollBar8.Size = New System.Drawing.Size(17, 156)
        Me.VScrollBar8.TabIndex = 18
        Me.VScrollBar8.Value = 20
        '
        'VScrollBar9
        '
        Me.VScrollBar9.LargeChange = 1
        Me.VScrollBar9.Location = New System.Drawing.Point(848, 335)
        Me.VScrollBar9.Maximum = 40
        Me.VScrollBar9.Name = "VScrollBar9"
        Me.VScrollBar9.Size = New System.Drawing.Size(17, 156)
        Me.VScrollBar9.TabIndex = 17
        Me.VScrollBar9.Value = 20
        '
        'VScrollBar10
        '
        Me.VScrollBar10.LargeChange = 1
        Me.VScrollBar10.Location = New System.Drawing.Point(820, 335)
        Me.VScrollBar10.Maximum = 40
        Me.VScrollBar10.Name = "VScrollBar10"
        Me.VScrollBar10.Size = New System.Drawing.Size(17, 156)
        Me.VScrollBar10.TabIndex = 16
        Me.VScrollBar10.Value = 20
        '
        'chkEQ
        '
        Me.chkEQ.AutoSize = True
        Me.chkEQ.Location = New System.Drawing.Point(688, 303)
        Me.chkEQ.Name = "chkEQ"
        Me.chkEQ.Size = New System.Drawing.Size(51, 17)
        Me.chkEQ.TabIndex = 21
        Me.chkEQ.Text = "Echo"
        Me.chkEQ.UseVisualStyleBackColor = True
        '
        'btnEQAC
        '
        Me.btnEQAC.Location = New System.Drawing.Point(278, 297)
        Me.btnEQAC.Name = "btnEQAC"
        Me.btnEQAC.Size = New System.Drawing.Size(75, 23)
        Me.btnEQAC.TabIndex = 22
        Me.btnEQAC.Text = "Acoustic"
        Me.btnEQAC.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(360, 296)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Bass Booster"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(633, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "BitRate"
        '
        'tbVol
        '
        Me.tbVol.Location = New System.Drawing.Point(718, 40)
        Me.tbVol.Maximum = 100
        Me.tbVol.Name = "tbVol"
        Me.tbVol.Size = New System.Drawing.Size(278, 45)
        Me.tbVol.TabIndex = 25
        Me.tbVol.TickFrequency = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(727, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Volume"
        '
        'lblPOS
        '
        Me.lblPOS.AutoSize = True
        Me.lblPOS.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPOS.ForeColor = System.Drawing.Color.Teal
        Me.lblPOS.Location = New System.Drawing.Point(13, 85)
        Me.lblPOS.Name = "lblPOS"
        Me.lblPOS.Size = New System.Drawing.Size(0, 30)
        Me.lblPOS.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(723, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Rate"
        '
        'tbarRate
        '
        Me.tbarRate.Location = New System.Drawing.Point(718, 111)
        Me.tbarRate.Maximum = 150
        Me.tbarRate.Minimum = 50
        Me.tbarRate.Name = "tbarRate"
        Me.tbarRate.Size = New System.Drawing.Size(278, 45)
        Me.tbarRate.TabIndex = 29
        Me.tbarRate.TickFrequency = 5
        Me.tbarRate.Value = 100
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(77, 375)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "pitch"
        '
        'tbPitch
        '
        Me.tbPitch.Location = New System.Drawing.Point(80, 402)
        Me.tbPitch.Maximum = 150
        Me.tbPitch.Minimum = 50
        Me.tbPitch.Name = "tbPitch"
        Me.tbPitch.Size = New System.Drawing.Size(278, 45)
        Me.tbPitch.TabIndex = 31
        Me.tbPitch.TickFrequency = 5
        Me.tbPitch.Value = 100
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(809, 173)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Tempo"
        '
        'tbarTempo
        '
        Me.tbarTempo.Location = New System.Drawing.Point(812, 200)
        Me.tbarTempo.Maximum = 150
        Me.tbarTempo.Minimum = 50
        Me.tbarTempo.Name = "tbarTempo"
        Me.tbarTempo.Size = New System.Drawing.Size(278, 45)
        Me.tbarTempo.TabIndex = 33
        Me.tbarTempo.TickFrequency = 5
        Me.tbarTempo.Value = 100
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(0, 25)
        Me.lblTitle.TabIndex = 34
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1208, 494)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.tbarTempo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbPitch)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbarRate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblPOS)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbVol)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEQAC)
        Me.Controls.Add(Me.chkEQ)
        Me.Controls.Add(Me.VScrollBar6)
        Me.Controls.Add(Me.VScrollBar7)
        Me.Controls.Add(Me.VScrollBar8)
        Me.Controls.Add(Me.VScrollBar9)
        Me.Controls.Add(Me.VScrollBar10)
        Me.Controls.Add(Me.VScrollBar5)
        Me.Controls.Add(Me.VScrollBar4)
        Me.Controls.Add(Me.VScrollBar3)
        Me.Controls.Add(Me.VScrollBar2)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.chkEcho)
        Me.Controls.Add(Me.pbarSeek)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblBPM)
        Me.Controls.Add(Me.btnBPM)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pbarRight)
        Me.Controls.Add(Me.pbarLeft)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnPlay)
        Me.Name = "Form1"
        Me.Text = "PBL mp3 player DEBUG ONLY"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbVol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbarRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbPitch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbarTempo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents OFDprime As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pbarLeft As System.Windows.Forms.ProgressBar
    Friend WithEvents pbarRight As System.Windows.Forms.ProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnBPM As System.Windows.Forms.Button
    Friend WithEvents lblBPM As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pbarSeek As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents chkEcho As System.Windows.Forms.CheckBox
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
    Friend WithEvents VScrollBar2 As System.Windows.Forms.VScrollBar
    Friend WithEvents VScrollBar3 As System.Windows.Forms.VScrollBar
    Friend WithEvents VScrollBar4 As System.Windows.Forms.VScrollBar
    Friend WithEvents VScrollBar5 As System.Windows.Forms.VScrollBar
    Friend WithEvents VScrollBar6 As System.Windows.Forms.VScrollBar
    Friend WithEvents VScrollBar7 As System.Windows.Forms.VScrollBar
    Friend WithEvents VScrollBar8 As System.Windows.Forms.VScrollBar
    Friend WithEvents VScrollBar9 As System.Windows.Forms.VScrollBar
    Friend WithEvents VScrollBar10 As System.Windows.Forms.VScrollBar
    Friend WithEvents chkEQ As System.Windows.Forms.CheckBox
    Friend WithEvents btnEQAC As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbVol As System.Windows.Forms.TrackBar
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblPOS As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbarRate As System.Windows.Forms.TrackBar
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbPitch As System.Windows.Forms.TrackBar
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbarTempo As System.Windows.Forms.TrackBar
    Friend WithEvents lblTitle As System.Windows.Forms.Label

End Class
