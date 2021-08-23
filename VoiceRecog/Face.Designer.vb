<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Face
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.WaitTimer = New System.Windows.Forms.Timer()
        Me.ReturnTimer = New System.Windows.Forms.Timer()
        Me.SpeechTimeout = New System.Windows.Forms.Timer()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.FaceImg = New System.Windows.Forms.PictureBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon()
        Me.TTSWorker = New System.ComponentModel.BackgroundWorker()
        Me.DebugLabel = New System.Windows.Forms.Label()
        CType(Me.FaceImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WaitTimer
        '
        Me.WaitTimer.Interval = 2000
        '
        'ReturnTimer
        '
        Me.ReturnTimer.Interval = 5000
        '
        'SpeechTimeout
        '
        Me.SpeechTimeout.Interval = 13000
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.BackColor = System.Drawing.Color.Transparent
        Me.StateLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StateLabel.Font = New System.Drawing.Font("NeoDunggeunmo", 22.0!)
        Me.StateLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StateLabel.Location = New System.Drawing.Point(0, 321)
        Me.StateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Padding = New System.Windows.Forms.Padding(20, 0, 0, 20)
        Me.StateLabel.Size = New System.Drawing.Size(20, 57)
        Me.StateLabel.TabIndex = 0
        Me.StateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FaceImg
        '
        Me.FaceImg.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.FaceImg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FaceImg.Image = Global.VoiceRecog.My.Resources.Resources.idle
        Me.FaceImg.Location = New System.Drawing.Point(0, 0)
        Me.FaceImg.Margin = New System.Windows.Forms.Padding(4)
        Me.FaceImg.Name = "FaceImg"
        Me.FaceImg.Size = New System.Drawing.Size(576, 378)
        Me.FaceImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FaceImg.TabIndex = 0
        Me.FaceImg.TabStop = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'TTSWorker
        '
        '
        'DebugLabel
        '
        Me.DebugLabel.AutoSize = True
        Me.DebugLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DebugLabel.Location = New System.Drawing.Point(13, 9)
        Me.DebugLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DebugLabel.Name = "DebugLabel"
        Me.DebugLabel.Size = New System.Drawing.Size(91, 20)
        Me.DebugLabel.TabIndex = 1
        Me.DebugLabel.Text = "DebugLabel"
        Me.DebugLabel.Visible = False
        '
        'Face
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(576, 378)
        Me.Controls.Add(Me.DebugLabel)
        Me.Controls.Add(Me.StateLabel)
        Me.Controls.Add(Me.FaceImg)
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Face"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Face"
        Me.TopMost = True
        CType(Me.FaceImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WaitTimer As Timer
    Friend WithEvents FaceImg As PictureBox
    Friend WithEvents ReturnTimer As Timer
    Friend WithEvents SpeechTimeout As Timer
    Friend WithEvents StateLabel As Label
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents TTSWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents DebugLabel As Label
End Class
