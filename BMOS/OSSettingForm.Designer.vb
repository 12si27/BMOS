<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OSSettingForm
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.KillexpLabel = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DbufferLabel = New System.Windows.Forms.Label()
        Me.AutostartLabel = New System.Windows.Forms.Label()
        Me.DcautostartLabel = New System.Windows.Forms.Label()
        Me.TopmostLabel = New System.Windows.Forms.Label()
        Me.ClockBT = New System.Windows.Forms.Button()
        Me.AppBT = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClockTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TopMenuPanel = New System.Windows.Forms.Panel()
        Me.KillexpChk = New System.Windows.Forms.PictureBox()
        Me.AutostartChk = New System.Windows.Forms.PictureBox()
        Me.DbufferChk = New System.Windows.Forms.PictureBox()
        Me.TopmostChk = New System.Windows.Forms.PictureBox()
        Me.DcautostartChk = New System.Windows.Forms.PictureBox()
        Me.MainBT = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.ContextMenuStrip3.SuspendLayout()
        Me.TopMenuPanel.SuspendLayout()
        CType(Me.KillexpChk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutostartChk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbufferChk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopmostChk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DcautostartChk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Location = New System.Drawing.Point(49, 607)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(870, 5)
        Me.Panel1.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 95)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(970, 762)
        Me.Panel3.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("NeoDunggeunmo", 20.0!)
        Me.Button1.Location = New System.Drawing.Point(527, 638)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(192, 82)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "취소"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.Silver
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("NeoDunggeunmo", 20.0!)
        Me.Button4.Location = New System.Drawing.Point(49, 638)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(189, 82)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "초기화"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Silver
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("NeoDunggeunmo", 20.0!)
        Me.Button3.Location = New System.Drawing.Point(727, 638)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(192, 82)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "적용"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.AutoScroll = True
        Me.Panel4.Controls.Add(Me.KillexpLabel)
        Me.Panel4.Controls.Add(Me.KillexpChk)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.DbufferLabel)
        Me.Panel4.Controls.Add(Me.AutostartChk)
        Me.Panel4.Controls.Add(Me.DbufferChk)
        Me.Panel4.Controls.Add(Me.AutostartLabel)
        Me.Panel4.Controls.Add(Me.DcautostartLabel)
        Me.Panel4.Controls.Add(Me.TopmostChk)
        Me.Panel4.Controls.Add(Me.DcautostartChk)
        Me.Panel4.Controls.Add(Me.TopmostLabel)
        Me.Panel4.Location = New System.Drawing.Point(49, 27)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(870, 574)
        Me.Panel4.TabIndex = 19
        '
        'KillexpLabel
        '
        Me.KillexpLabel.AutoSize = True
        Me.KillexpLabel.Location = New System.Drawing.Point(76, 436)
        Me.KillexpLabel.Name = "KillexpLabel"
        Me.KillexpLabel.Size = New System.Drawing.Size(559, 70)
        Me.KillexpLabel.TabIndex = 21
        Me.KillexpLabel.Text = "BMOS 실행시 Windows 데스크톱 GUI" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Explorer) 비활성화 (권장)"
        '
        'Panel5
        '
        Me.Panel5.Location = New System.Drawing.Point(7, 509)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(287, 10)
        Me.Panel5.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 301)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 35)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "기타 설정"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 35)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "기본 설정"
        '
        'DbufferLabel
        '
        Me.DbufferLabel.AutoSize = True
        Me.DbufferLabel.Location = New System.Drawing.Point(76, 366)
        Me.DbufferLabel.Name = "DbufferLabel"
        Me.DbufferLabel.Size = New System.Drawing.Size(440, 35)
        Me.DbufferLabel.TabIndex = 17
        Me.DbufferLabel.Text = "컨트롤 이중 버퍼 비활성화"
        '
        'AutostartLabel
        '
        Me.AutostartLabel.AutoSize = True
        Me.AutostartLabel.Location = New System.Drawing.Point(75, 68)
        Me.AutostartLabel.Name = "AutostartLabel"
        Me.AutostartLabel.Size = New System.Drawing.Size(491, 35)
        Me.AutostartLabel.TabIndex = 6
        Me.AutostartLabel.Text = "Windows 시작시 자동으로 시작"
        '
        'DcautostartLabel
        '
        Me.DcautostartLabel.AutoSize = True
        Me.DcautostartLabel.Location = New System.Drawing.Point(75, 208)
        Me.DcautostartLabel.Name = "DcautostartLabel"
        Me.DcautostartLabel.Size = New System.Drawing.Size(423, 70)
        Me.DcautostartLabel.TabIndex = 15
        Me.DcautostartLabel.Text = "BMOS 종료 후 자동으로" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DesktopCoral 실행 (권장)"
        '
        'TopmostLabel
        '
        Me.TopmostLabel.AutoSize = True
        Me.TopmostLabel.Location = New System.Drawing.Point(75, 138)
        Me.TopmostLabel.Name = "TopmostLabel"
        Me.TopmostLabel.Size = New System.Drawing.Size(491, 35)
        Me.TopmostLabel.TabIndex = 13
        Me.TopmostLabel.Text = "항상 위 표시 (권장하지 않음)"
        '
        'ClockBT
        '
        Me.ClockBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClockBT.Dock = System.Windows.Forms.DockStyle.Right
        Me.ClockBT.FlatAppearance.BorderSize = 0
        Me.ClockBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClockBT.Font = New System.Drawing.Font("NeoDunggeunmo", 30.0!, System.Drawing.FontStyle.Bold)
        Me.ClockBT.ForeColor = System.Drawing.Color.Gray
        Me.ClockBT.Location = New System.Drawing.Point(727, 0)
        Me.ClockBT.Margin = New System.Windows.Forms.Padding(4)
        Me.ClockBT.Name = "ClockBT"
        Me.ClockBT.Size = New System.Drawing.Size(243, 86)
        Me.ClockBT.TabIndex = 6
        Me.ClockBT.Text = "12:27:00"
        Me.ClockBT.UseVisualStyleBackColor = True
        '
        'AppBT
        '
        Me.AppBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AppBT.Dock = System.Windows.Forms.DockStyle.Left
        Me.AppBT.FlatAppearance.BorderSize = 0
        Me.AppBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AppBT.Font = New System.Drawing.Font("NeoDunggeunmo", 27.0!)
        Me.AppBT.Location = New System.Drawing.Point(133, 0)
        Me.AppBT.Margin = New System.Windows.Forms.Padding(4)
        Me.AppBT.Name = "AppBT"
        Me.AppBT.Size = New System.Drawing.Size(315, 86)
        Me.AppBT.TabIndex = 2
        Me.AppBT.Text = "BMOS 설정"
        Me.AppBT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AppBT.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 86)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(970, 9)
        Me.Panel2.TabIndex = 0
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Margin = New System.Windows.Forms.Padding(0, 15, 0, 15)
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(429, 54)
        Me.ToolStripMenuItem10.Text = " BMOS 정보"
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ContextMenuStrip3.Font = New System.Drawing.Font("NeoDunggeunmo", 29.0!)
        Me.ContextMenuStrip3.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem9, Me.ToolStripMenuItem10})
        Me.ContextMenuStrip3.Name = "MainMenu"
        Me.ContextMenuStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ContextMenuStrip3.ShowImageMargin = False
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(430, 172)
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Margin = New System.Windows.Forms.Padding(0, 15, 0, 15)
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(429, 54)
        Me.ToolStripMenuItem9.Text = " 배경 설정..."
        '
        'ClockTimer
        '
        Me.ClockTimer.Enabled = True
        Me.ClockTimer.Interval = 1000
        '
        'TopMenuPanel
        '
        Me.TopMenuPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TopMenuPanel.Controls.Add(Me.ClockBT)
        Me.TopMenuPanel.Controls.Add(Me.AppBT)
        Me.TopMenuPanel.Controls.Add(Me.MainBT)
        Me.TopMenuPanel.Controls.Add(Me.Panel2)
        Me.TopMenuPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopMenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.TopMenuPanel.Name = "TopMenuPanel"
        Me.TopMenuPanel.Size = New System.Drawing.Size(970, 95)
        Me.TopMenuPanel.TabIndex = 6
        '
        'KillexpChk
        '
        Me.KillexpChk.Image = Global.BMOS.My.Resources.Resources.chk_0
        Me.KillexpChk.Location = New System.Drawing.Point(8, 426)
        Me.KillexpChk.Name = "KillexpChk"
        Me.KillexpChk.Size = New System.Drawing.Size(57, 54)
        Me.KillexpChk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.KillexpChk.TabIndex = 20
        Me.KillexpChk.TabStop = False
        '
        'AutostartChk
        '
        Me.AutostartChk.Image = Global.BMOS.My.Resources.Resources.chk_0
        Me.AutostartChk.Location = New System.Drawing.Point(7, 58)
        Me.AutostartChk.Name = "AutostartChk"
        Me.AutostartChk.Size = New System.Drawing.Size(57, 54)
        Me.AutostartChk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AutostartChk.TabIndex = 5
        Me.AutostartChk.TabStop = False
        '
        'DbufferChk
        '
        Me.DbufferChk.Image = Global.BMOS.My.Resources.Resources.chk_0
        Me.DbufferChk.Location = New System.Drawing.Point(8, 356)
        Me.DbufferChk.Name = "DbufferChk"
        Me.DbufferChk.Size = New System.Drawing.Size(57, 54)
        Me.DbufferChk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DbufferChk.TabIndex = 16
        Me.DbufferChk.TabStop = False
        '
        'TopmostChk
        '
        Me.TopmostChk.Image = Global.BMOS.My.Resources.Resources.chk_0
        Me.TopmostChk.Location = New System.Drawing.Point(7, 128)
        Me.TopmostChk.Name = "TopmostChk"
        Me.TopmostChk.Size = New System.Drawing.Size(57, 54)
        Me.TopmostChk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.TopmostChk.TabIndex = 12
        Me.TopmostChk.TabStop = False
        '
        'DcautostartChk
        '
        Me.DcautostartChk.Image = Global.BMOS.My.Resources.Resources.chk_0
        Me.DcautostartChk.Location = New System.Drawing.Point(7, 198)
        Me.DcautostartChk.Name = "DcautostartChk"
        Me.DcautostartChk.Size = New System.Drawing.Size(57, 54)
        Me.DcautostartChk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DcautostartChk.TabIndex = 14
        Me.DcautostartChk.TabStop = False
        '
        'MainBT
        '
        Me.MainBT.BackgroundImage = Global.BMOS.My.Resources.Resources.setting
        Me.MainBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MainBT.Dock = System.Windows.Forms.DockStyle.Left
        Me.MainBT.FlatAppearance.BorderSize = 0
        Me.MainBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainBT.Location = New System.Drawing.Point(0, 0)
        Me.MainBT.Margin = New System.Windows.Forms.Padding(4)
        Me.MainBT.Name = "MainBT"
        Me.MainBT.Size = New System.Drawing.Size(133, 86)
        Me.MainBT.TabIndex = 1
        Me.MainBT.UseVisualStyleBackColor = True
        '
        'OSSettingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(970, 857)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TopMenuPanel)
        Me.Font = New System.Drawing.Font("NeoDunggeunmo", 20.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "OSSettingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "OSSettingForm"
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ContextMenuStrip3.ResumeLayout(False)
        Me.TopMenuPanel.ResumeLayout(False)
        CType(Me.KillexpChk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutostartChk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbufferChk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopmostChk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DcautostartChk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents AutostartLabel As Label
    Friend WithEvents AutostartChk As PictureBox
    Friend WithEvents MainBT As Button
    Friend WithEvents ClockBT As Button
    Friend WithEvents AppBT As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ToolStripMenuItem10 As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip3 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
    Friend WithEvents ClockTimer As Timer
    Friend WithEvents TopMenuPanel As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents DbufferLabel As Label
    Friend WithEvents DbufferChk As PictureBox
    Friend WithEvents DcautostartLabel As Label
    Friend WithEvents DcautostartChk As PictureBox
    Friend WithEvents TopmostLabel As Label
    Friend WithEvents TopmostChk As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents KillexpLabel As Label
    Friend WithEvents KillexpChk As PictureBox
End Class
