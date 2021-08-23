<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackgroundSetForm
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
        Me.ClockTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ClockBT = New System.Windows.Forms.Button()
        Me.AppBT = New System.Windows.Forms.Button()
        Me.TopMenuPanel = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.FillImgLabel = New System.Windows.Forms.Label()
        Me.SetColorBT = New System.Windows.Forms.Button()
        Me.SetImageBT = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PrevPanel = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.MainBT = New System.Windows.Forms.Button()
        Me.PrevBox = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FillImgChk = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip3.SuspendLayout()
        Me.TopMenuPanel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PrevPanel.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PrevBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FillImgChk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClockTimer
        '
        Me.ClockTimer.Enabled = True
        Me.ClockTimer.Interval = 1000
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Margin = New System.Windows.Forms.Padding(0, 15, 0, 15)
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(429, 54)
        Me.ToolStripMenuItem9.Text = " 배경 설정..."
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
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Margin = New System.Windows.Forms.Padding(0, 15, 0, 15)
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(429, 54)
        Me.ToolStripMenuItem10.Text = " BMOS 정보"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 86)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(890, 9)
        Me.Panel2.TabIndex = 0
        '
        'ClockBT
        '
        Me.ClockBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClockBT.Dock = System.Windows.Forms.DockStyle.Right
        Me.ClockBT.FlatAppearance.BorderSize = 0
        Me.ClockBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClockBT.Font = New System.Drawing.Font("NeoDunggeunmo", 30.0!, System.Drawing.FontStyle.Bold)
        Me.ClockBT.ForeColor = System.Drawing.Color.Gray
        Me.ClockBT.Location = New System.Drawing.Point(647, 0)
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
        Me.AppBT.Size = New System.Drawing.Size(384, 86)
        Me.AppBT.TabIndex = 2
        Me.AppBT.Text = "배경 설정"
        Me.AppBT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AppBT.UseVisualStyleBackColor = True
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
        Me.TopMenuPanel.Size = New System.Drawing.Size(890, 95)
        Me.TopMenuPanel.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.PrevPanel)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.FillImgLabel)
        Me.Panel3.Controls.Add(Me.FillImgChk)
        Me.Panel3.Controls.Add(Me.SetColorBT)
        Me.Panel3.Controls.Add(Me.SetImageBT)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(890, 641)
        Me.Panel3.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Location = New System.Drawing.Point(49, 486)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(790, 5)
        Me.Panel1.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("NeoDunggeunmo", 20.0!)
        Me.Button1.Location = New System.Drawing.Point(447, 517)
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
        Me.Button4.Location = New System.Drawing.Point(49, 517)
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
        Me.Button3.Location = New System.Drawing.Point(647, 517)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(192, 82)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "적용"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'FillImgLabel
        '
        Me.FillImgLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FillImgLabel.AutoSize = True
        Me.FillImgLabel.Location = New System.Drawing.Point(566, 391)
        Me.FillImgLabel.Name = "FillImgLabel"
        Me.FillImgLabel.Size = New System.Drawing.Size(253, 35)
        Me.FillImgLabel.TabIndex = 6
        Me.FillImgLabel.Text = "사진 꽉 채우기"
        '
        'SetColorBT
        '
        Me.SetColorBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SetColorBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SetColorBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SetColorBT.FlatAppearance.BorderSize = 0
        Me.SetColorBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetColorBT.Font = New System.Drawing.Font("NeoDunggeunmo", 20.0!)
        Me.SetColorBT.Location = New System.Drawing.Point(498, 280)
        Me.SetColorBT.Margin = New System.Windows.Forms.Padding(4)
        Me.SetColorBT.Name = "SetColorBT"
        Me.SetColorBT.Size = New System.Drawing.Size(326, 84)
        Me.SetColorBT.TabIndex = 4
        Me.SetColorBT.Text = "배경 색 설정"
        Me.SetColorBT.UseVisualStyleBackColor = False
        '
        'SetImageBT
        '
        Me.SetImageBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SetImageBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SetImageBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SetImageBT.FlatAppearance.BorderSize = 0
        Me.SetImageBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetImageBT.Font = New System.Drawing.Font("NeoDunggeunmo", 20.0!)
        Me.SetImageBT.Location = New System.Drawing.Point(498, 179)
        Me.SetImageBT.Margin = New System.Windows.Forms.Padding(4)
        Me.SetImageBT.Name = "SetImageBT"
        Me.SetImageBT.Size = New System.Drawing.Size(326, 84)
        Me.SetImageBT.TabIndex = 3
        Me.SetImageBT.Text = "배경 사진 설정"
        Me.SetImageBT.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "미리 보기"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PrevPanel
        '
        Me.PrevPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrevPanel.Controls.Add(Me.PrevBox)
        Me.PrevPanel.Controls.Add(Me.Panel4)
        Me.PrevPanel.Location = New System.Drawing.Point(49, 179)
        Me.PrevPanel.Name = "PrevPanel"
        Me.PrevPanel.Size = New System.Drawing.Size(421, 264)
        Me.PrevPanel.TabIndex = 11
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(421, 52)
        Me.Panel4.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Gray
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 45)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(421, 7)
        Me.Panel5.TabIndex = 2
        '
        'MainBT
        '
        Me.MainBT.BackgroundImage = Global.BMOS.My.Resources.Resources.bgset
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
        'PrevBox
        '
        Me.PrevBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.PrevBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PrevBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrevBox.Location = New System.Drawing.Point(0, 52)
        Me.PrevBox.Name = "PrevBox"
        Me.PrevBox.Size = New System.Drawing.Size(421, 212)
        Me.PrevBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PrevBox.TabIndex = 0
        Me.PrevBox.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.BMOS.My.Resources.Resources.logo
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 45)
        Me.Button2.TabIndex = 3
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FillImgChk
        '
        Me.FillImgChk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FillImgChk.Image = Global.BMOS.My.Resources.Resources.chk_0
        Me.FillImgChk.Location = New System.Drawing.Point(498, 381)
        Me.FillImgChk.Name = "FillImgChk"
        Me.FillImgChk.Size = New System.Drawing.Size(57, 54)
        Me.FillImgChk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FillImgChk.TabIndex = 5
        Me.FillImgChk.TabStop = False
        '
        'BackgroundSetForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(890, 641)
        Me.Controls.Add(Me.TopMenuPanel)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("NeoDunggeunmo", 20.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BackgroundSetForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "BackgroundSetForm"
        Me.ContextMenuStrip3.ResumeLayout(False)
        Me.TopMenuPanel.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.PrevPanel.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PrevBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FillImgChk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ClockTimer As Timer
    Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip3 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem10 As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ClockBT As Button
    Friend WithEvents AppBT As Button
    Friend WithEvents MainBT As Button
    Friend WithEvents TopMenuPanel As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PrevBox As PictureBox
    Friend WithEvents FillImgChk As PictureBox
    Friend WithEvents SetColorBT As Button
    Friend WithEvents SetImageBT As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents FillImgLabel As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PrevPanel As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button2 As Button
End Class
