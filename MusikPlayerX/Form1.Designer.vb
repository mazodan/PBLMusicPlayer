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
        Me.OFDprime = New System.Windows.Forms.OpenFileDialog
        Me.Label1 = New System.Windows.Forms.Label
        Me.pbarLeft = New System.Windows.Forms.ProgressBar
        Me.pbarRight = New System.Windows.Forms.ProgressBar
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnBPM = New System.Windows.Forms.Button
        Me.lblBPM = New System.Windows.Forms.Label
        Me.pbarSeek = New System.Windows.Forms.ProgressBar
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.chkEcho = New System.Windows.Forms.CheckBox
        Me.chkEQ = New System.Windows.Forms.CheckBox
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
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblVol = New System.Windows.Forms.Label
        Me.lblRate = New System.Windows.Forms.Label
        Me.lblPitch = New System.Windows.Forms.Label
        Me.lblTpo = New System.Windows.Forms.Label
        Me.t32 = New System.Windows.Forms.TrackBar
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.t64 = New System.Windows.Forms.TrackBar
        Me.Label12 = New System.Windows.Forms.Label
        Me.t250 = New System.Windows.Forms.TrackBar
        Me.Label13 = New System.Windows.Forms.Label
        Me.t125 = New System.Windows.Forms.TrackBar
        Me.Label14 = New System.Windows.Forms.Label
        Me.t4000 = New System.Windows.Forms.TrackBar
        Me.Label15 = New System.Windows.Forms.Label
        Me.t2000 = New System.Windows.Forms.TrackBar
        Me.Label16 = New System.Windows.Forms.Label
        Me.t1000 = New System.Windows.Forms.TrackBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.t500 = New System.Windows.Forms.TrackBar
        Me.t16000 = New System.Windows.Forms.TrackBar
        Me.t8000 = New System.Windows.Forms.TrackBar
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.cmbEQ = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.btnStop = New System.Windows.Forms.Button
        Me.btnRev = New System.Windows.Forms.Button
        Me.btnLoop = New System.Windows.Forms.Button
        Me.btnPause = New System.Windows.Forms.Button
        Me.btnPlay = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnLoad = New System.Windows.Forms.Button
        CType(Me.tbVol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbarRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbPitch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbarTempo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t64, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t250, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t125, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t4000, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t2000, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t1000, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t500, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t16000, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t8000, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OFDprime
        '
        Me.OFDprime.Filter = "MP3 files (*.mp3)|*.mp3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(455, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "VU METER"
        '
        'pbarLeft
        '
        Me.pbarLeft.Location = New System.Drawing.Point(458, 79)
        Me.pbarLeft.Name = "pbarLeft"
        Me.pbarLeft.Size = New System.Drawing.Size(252, 23)
        Me.pbarLeft.TabIndex = 3
        '
        'pbarRight
        '
        Me.pbarRight.Location = New System.Drawing.Point(458, 108)
        Me.pbarRight.Name = "pbarRight"
        Me.pbarRight.Size = New System.Drawing.Size(252, 23)
        Me.pbarRight.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(439, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "L"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(439, 118)
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
        Me.btnBPM.Location = New System.Drawing.Point(12, 133)
        Me.btnBPM.Name = "btnBPM"
        Me.btnBPM.Size = New System.Drawing.Size(75, 23)
        Me.btnBPM.TabIndex = 7
        Me.btnBPM.Text = "Detect BPM"
        Me.btnBPM.UseVisualStyleBackColor = True
        '
        'lblBPM
        '
        Me.lblBPM.AutoSize = True
        Me.lblBPM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBPM.ForeColor = System.Drawing.Color.Purple
        Me.lblBPM.Location = New System.Drawing.Point(132, 136)
        Me.lblBPM.Name = "lblBPM"
        Me.lblBPM.Size = New System.Drawing.Size(48, 16)
        Me.lblBPM.TabIndex = 8
        Me.lblBPM.Text = "BPM?"
        '
        'pbarSeek
        '
        Me.pbarSeek.BackColor = System.Drawing.SystemColors.Control
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
        Me.chkEcho.Location = New System.Drawing.Point(201, 136)
        Me.chkEcho.Name = "chkEcho"
        Me.chkEcho.Size = New System.Drawing.Size(51, 17)
        Me.chkEcho.TabIndex = 12
        Me.chkEcho.Text = "Echo"
        Me.chkEcho.UseVisualStyleBackColor = True
        '
        'chkEQ
        '
        Me.chkEQ.AutoSize = True
        Me.chkEQ.Location = New System.Drawing.Point(666, 278)
        Me.chkEQ.Name = "chkEQ"
        Me.chkEQ.Size = New System.Drawing.Size(41, 17)
        Me.chkEQ.TabIndex = 21
        Me.chkEQ.Text = "EQ"
        Me.chkEQ.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(354, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 21)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "BitRate"
        '
        'tbVol
        '
        Me.tbVol.Location = New System.Drawing.Point(12, 202)
        Me.tbVol.Maximum = 100
        Me.tbVol.Name = "tbVol"
        Me.tbVol.Size = New System.Drawing.Size(278, 45)
        Me.tbVol.TabIndex = 25
        Me.tbVol.TickFrequency = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 173)
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
        Me.Label7.Location = New System.Drawing.Point(17, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Audio Speed"
        '
        'tbarRate
        '
        Me.tbarRate.Location = New System.Drawing.Point(12, 275)
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
        Me.Label8.Location = New System.Drawing.Point(329, 173)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Pitch"
        '
        'tbPitch
        '
        Me.tbPitch.Location = New System.Drawing.Point(338, 202)
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
        Me.Label9.Location = New System.Drawing.Point(329, 249)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Tempo"
        '
        'tbarTempo
        '
        Me.tbarTempo.Location = New System.Drawing.Point(338, 265)
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
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblTitle.Location = New System.Drawing.Point(14, 16)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(44, 21)
        Me.lblTitle.TabIndex = 31
        Me.lblTitle.Text = "Title"
        '
        'Timer3
        '
        Me.Timer3.Interval = 50
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(93, 138)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "BPM:"
        '
        'lblVol
        '
        Me.lblVol.AutoSize = True
        Me.lblVol.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblVol.Location = New System.Drawing.Point(296, 202)
        Me.lblVol.Name = "lblVol"
        Me.lblVol.Size = New System.Drawing.Size(36, 19)
        Me.lblVol.TabIndex = 38
        Me.lblVol.Text = "100"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRate.ForeColor = System.Drawing.Color.Olive
        Me.lblRate.Location = New System.Drawing.Point(296, 275)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(36, 19)
        Me.lblRate.TabIndex = 39
        Me.lblRate.Text = "100"
        '
        'lblPitch
        '
        Me.lblPitch.AutoSize = True
        Me.lblPitch.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPitch.ForeColor = System.Drawing.Color.Purple
        Me.lblPitch.Location = New System.Drawing.Point(622, 202)
        Me.lblPitch.Name = "lblPitch"
        Me.lblPitch.Size = New System.Drawing.Size(36, 19)
        Me.lblPitch.TabIndex = 41
        Me.lblPitch.Text = "100"
        '
        'lblTpo
        '
        Me.lblTpo.AutoSize = True
        Me.lblTpo.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTpo.ForeColor = System.Drawing.Color.Purple
        Me.lblTpo.Location = New System.Drawing.Point(622, 275)
        Me.lblTpo.Name = "lblTpo"
        Me.lblTpo.Size = New System.Drawing.Size(36, 19)
        Me.lblTpo.TabIndex = 42
        Me.lblTpo.Text = "100"
        '
        't32
        '
        Me.t32.Location = New System.Drawing.Point(613, 316)
        Me.t32.Maximum = 24
        Me.t32.Name = "t32"
        Me.t32.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.t32.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.t32.Size = New System.Drawing.Size(45, 153)
        Me.t32.TabIndex = 43
        Me.t32.TickFrequency = 3
        Me.t32.Value = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(619, 472)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "32"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(656, 472)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 13)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "64"
        '
        't64
        '
        Me.t64.Location = New System.Drawing.Point(649, 316)
        Me.t64.Maximum = 24
        Me.t64.Name = "t64"
        Me.t64.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.t64.Size = New System.Drawing.Size(45, 153)
        Me.t64.TabIndex = 45
        Me.t64.TickFrequency = 3
        Me.t64.Value = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(720, 472)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 13)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "250"
        '
        't250
        '
        Me.t250.Location = New System.Drawing.Point(723, 316)
        Me.t250.Maximum = 24
        Me.t250.Name = "t250"
        Me.t250.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.t250.Size = New System.Drawing.Size(45, 153)
        Me.t250.TabIndex = 49
        Me.t250.TickFrequency = 3
        Me.t250.Value = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(683, 472)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 13)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "125"
        '
        't125
        '
        Me.t125.Location = New System.Drawing.Point(686, 316)
        Me.t125.Maximum = 24
        Me.t125.Name = "t125"
        Me.t125.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.t125.Size = New System.Drawing.Size(45, 153)
        Me.t125.TabIndex = 47
        Me.t125.TickFrequency = 3
        Me.t125.Value = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(867, 472)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(20, 13)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "4K"
        '
        't4000
        '
        Me.t4000.Location = New System.Drawing.Point(870, 316)
        Me.t4000.Maximum = 24
        Me.t4000.Name = "t4000"
        Me.t4000.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.t4000.Size = New System.Drawing.Size(45, 153)
        Me.t4000.TabIndex = 57
        Me.t4000.TickFrequency = 3
        Me.t4000.Value = 12
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(830, 472)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(20, 13)
        Me.Label15.TabIndex = 56
        Me.Label15.Text = "2K"
        '
        't2000
        '
        Me.t2000.Location = New System.Drawing.Point(833, 316)
        Me.t2000.Maximum = 24
        Me.t2000.Name = "t2000"
        Me.t2000.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.t2000.Size = New System.Drawing.Size(45, 153)
        Me.t2000.TabIndex = 55
        Me.t2000.TickFrequency = 3
        Me.t2000.Value = 12
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(793, 472)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(20, 13)
        Me.Label16.TabIndex = 54
        Me.Label16.Text = "1K"
        '
        't1000
        '
        Me.t1000.Location = New System.Drawing.Point(796, 316)
        Me.t1000.Maximum = 24
        Me.t1000.Name = "t1000"
        Me.t1000.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.t1000.Size = New System.Drawing.Size(45, 153)
        Me.t1000.TabIndex = 53
        Me.t1000.TickFrequency = 3
        Me.t1000.Value = 12
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(757, 472)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(25, 13)
        Me.Label17.TabIndex = 52
        Me.Label17.Text = "500"
        '
        't500
        '
        Me.t500.Location = New System.Drawing.Point(760, 316)
        Me.t500.Maximum = 24
        Me.t500.Name = "t500"
        Me.t500.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.t500.Size = New System.Drawing.Size(45, 153)
        Me.t500.TabIndex = 51
        Me.t500.TickFrequency = 3
        Me.t500.Value = 12
        '
        't16000
        '
        Me.t16000.Location = New System.Drawing.Point(941, 316)
        Me.t16000.Maximum = 24
        Me.t16000.Name = "t16000"
        Me.t16000.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.t16000.Size = New System.Drawing.Size(45, 153)
        Me.t16000.TabIndex = 60
        Me.t16000.TickFrequency = 3
        Me.t16000.Value = 12
        '
        't8000
        '
        Me.t8000.Location = New System.Drawing.Point(904, 316)
        Me.t8000.Maximum = 24
        Me.t8000.Name = "t8000"
        Me.t8000.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.t8000.Size = New System.Drawing.Size(45, 153)
        Me.t8000.TabIndex = 59
        Me.t8000.TickFrequency = 3
        Me.t8000.Value = 12
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(901, 472)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(20, 13)
        Me.Label18.TabIndex = 61
        Me.Label18.Text = "8K"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(938, 472)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(26, 13)
        Me.Label19.TabIndex = 62
        Me.Label19.Text = "16K"
        '
        'cmbEQ
        '
        Me.cmbEQ.FormattingEnabled = True
        Me.cmbEQ.Items.AddRange(New Object() {"Flat", "Acoustics", "Bass Booster", "Bass Reducer", "Classical", "Dance", "Deep", "Electronic", "Hip-Hop", "Jazz", "Latin", "Loudness", "Lounge", "Piano", "R&B", "Rock", "Small Speakers", "Spoken Word", "Treble Booster", "Treble Reducer", "Vocal Booster"})
        Me.cmbEQ.Location = New System.Drawing.Point(796, 276)
        Me.cmbEQ.Name = "cmbEQ"
        Me.cmbEQ.Size = New System.Drawing.Size(121, 21)
        Me.cmbEQ.TabIndex = 63
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(728, 279)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 13)
        Me.Label20.TabIndex = 64
        Me.Label20.Text = "EQ Presets"
        '
        'btnStop
        '
        Me.btnStop.BackgroundImage = Global.MusikPlayerX.My.Resources.Resources._stop
        Me.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStop.Location = New System.Drawing.Point(186, 82)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(30, 30)
        Me.btnStop.TabIndex = 65
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnRev
        '
        Me.btnRev.BackgroundImage = Global.MusikPlayerX.My.Resources.Resources.rangiticonmi9
        Me.btnRev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRev.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRev.Location = New System.Drawing.Point(294, 82)
        Me.btnRev.Name = "btnRev"
        Me.btnRev.Size = New System.Drawing.Size(30, 30)
        Me.btnRev.TabIndex = 40
        Me.btnRev.UseVisualStyleBackColor = True
        '
        'btnLoop
        '
        Me.btnLoop.BackgroundImage = Global.MusikPlayerX.My.Resources.Resources.backup_restore
        Me.btnLoop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLoop.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLoop.Location = New System.Drawing.Point(258, 82)
        Me.btnLoop.Name = "btnLoop"
        Me.btnLoop.Size = New System.Drawing.Size(30, 30)
        Me.btnLoop.TabIndex = 36
        Me.btnLoop.UseVisualStyleBackColor = True
        '
        'btnPause
        '
        Me.btnPause.BackgroundImage = Global.MusikPlayerX.My.Resources.Resources.pause
        Me.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPause.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPause.Location = New System.Drawing.Point(222, 82)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(30, 30)
        Me.btnPause.TabIndex = 35
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'btnPlay
        '
        Me.btnPlay.BackgroundImage = Global.MusikPlayerX.My.Resources.Resources.arrow_right_drop_circle
        Me.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPlay.Location = New System.Drawing.Point(150, 82)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(30, 30)
        Me.btnPlay.TabIndex = 34
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(12, 326)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(557, 156)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'btnLoad
        '
        Me.btnLoad.BackgroundImage = Global.MusikPlayerX.My.Resources.Resources.album
        Me.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLoad.Location = New System.Drawing.Point(114, 82)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(30, 30)
        Me.btnLoad.TabIndex = 1
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 494)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cmbEQ)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.t16000)
        Me.Controls.Add(Me.t8000)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.t4000)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.t2000)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.t1000)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.t500)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.t250)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.t125)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.t64)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.t32)
        Me.Controls.Add(Me.lblTpo)
        Me.Controls.Add(Me.lblPitch)
        Me.Controls.Add(Me.btnRev)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.lblVol)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnLoop)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.btnPlay)
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
        Me.Controls.Add(Me.chkEQ)
        Me.Controls.Add(Me.chkEcho)
        Me.Controls.Add(Me.pbarSeek)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblBPM)
        Me.Controls.Add(Me.btnBPM)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pbarRight)
        Me.Controls.Add(Me.pbarLeft)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLoad)
        Me.Name = "Form1"
        Me.Text = "PBL mp3 player DEBUG ONLY"
        CType(Me.tbVol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbarRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbPitch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbarTempo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t64, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t250, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t125, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t4000, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t2000, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t1000, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t500, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t16000, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t8000, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents pbarSeek As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents chkEcho As System.Windows.Forms.CheckBox
    Friend WithEvents chkEQ As System.Windows.Forms.CheckBox
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
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnPause As System.Windows.Forms.Button
    Friend WithEvents btnLoop As System.Windows.Forms.Button
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblVol As System.Windows.Forms.Label
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents btnRev As System.Windows.Forms.Button
    Friend WithEvents lblPitch As System.Windows.Forms.Label
    Friend WithEvents lblTpo As System.Windows.Forms.Label
    Friend WithEvents t32 As System.Windows.Forms.TrackBar
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents t64 As System.Windows.Forms.TrackBar
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents t250 As System.Windows.Forms.TrackBar
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents t125 As System.Windows.Forms.TrackBar
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents t4000 As System.Windows.Forms.TrackBar
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents t2000 As System.Windows.Forms.TrackBar
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents t1000 As System.Windows.Forms.TrackBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents t500 As System.Windows.Forms.TrackBar
    Friend WithEvents t16000 As System.Windows.Forms.TrackBar
    Friend WithEvents t8000 As System.Windows.Forms.TrackBar
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmbEQ As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btnStop As System.Windows.Forms.Button

End Class
