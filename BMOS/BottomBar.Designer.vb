<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BottomBar
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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.AppNameLabel = New System.Windows.Forms.Label()
        Me.ClockBT = New System.Windows.Forms.Button()
        Me.MainMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TabKeyMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolumeMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainBT = New System.Windows.Forms.Button()
        Me.ClockTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MainMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("NeoDunggeunmo", 27.0!)
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(0, 0)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(150, 50)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "X"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'AppNameLabel
        '
        Me.AppNameLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AppNameLabel.Font = New System.Drawing.Font("NeoDunggeunmo", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.AppNameLabel.ForeColor = System.Drawing.Color.White
        Me.AppNameLabel.Location = New System.Drawing.Point(150, 0)
        Me.AppNameLabel.Name = "AppNameLabel"
        Me.AppNameLabel.Size = New System.Drawing.Size(629, 50)
        Me.AppNameLabel.TabIndex = 6
        Me.AppNameLabel.Text = "AppName"
        Me.AppNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ClockBT
        '
        Me.ClockBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.ClockBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClockBT.Dock = System.Windows.Forms.DockStyle.Right
        Me.ClockBT.FlatAppearance.BorderSize = 0
        Me.ClockBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClockBT.Font = New System.Drawing.Font("NeoDunggeunmo", 18.0!, System.Drawing.FontStyle.Bold)
        Me.ClockBT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ClockBT.Location = New System.Drawing.Point(779, 0)
        Me.ClockBT.Margin = New System.Windows.Forms.Padding(4)
        Me.ClockBT.Name = "ClockBT"
        Me.ClockBT.Size = New System.Drawing.Size(110, 50)
        Me.ClockBT.TabIndex = 7
        Me.ClockBT.Text = "12:27"
        Me.ClockBT.UseVisualStyleBackColor = False
        '
        'MainMenu
        '
        Me.MainMenu.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MainMenu.Font = New System.Drawing.Font("NeoDunggeunmo", 29.0!)
        Me.MainMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TabKeyMenu, Me.VolumeMenu})
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MainMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MainMenu.ShowImageMargin = False
        Me.MainMenu.Size = New System.Drawing.Size(405, 172)
        '
        'TabKeyMenu
        '
        Me.TabKeyMenu.Margin = New System.Windows.Forms.Padding(0, 15, 0, 15)
        Me.TabKeyMenu.Name = "TabKeyMenu"
        Me.TabKeyMenu.Size = New System.Drawing.Size(404, 54)
        Me.TabKeyMenu.Text = "터치 키보드 "
        '
        'VolumeMenu
        '
        Me.VolumeMenu.Margin = New System.Windows.Forms.Padding(0, 15, 0, 15)
        Me.VolumeMenu.Name = "VolumeMenu"
        Me.VolumeMenu.Size = New System.Drawing.Size(404, 54)
        Me.VolumeMenu.Text = "음량 조절 "
        '
        'MainBT
        '
        Me.MainBT.BackColor = System.Drawing.Color.White
        Me.MainBT.BackgroundImage = Global.BMOS.My.Resources.Resources.logo
        Me.MainBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MainBT.Dock = System.Windows.Forms.DockStyle.Right
        Me.MainBT.FlatAppearance.BorderSize = 0
        Me.MainBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainBT.Location = New System.Drawing.Point(889, 0)
        Me.MainBT.Margin = New System.Windows.Forms.Padding(4)
        Me.MainBT.Name = "MainBT"
        Me.MainBT.Size = New System.Drawing.Size(60, 50)
        Me.MainBT.TabIndex = 8
        Me.MainBT.UseVisualStyleBackColor = False
        '
        'ClockTimer
        '
        Me.ClockTimer.Enabled = True
        Me.ClockTimer.Interval = 1000
        '
        'BottomBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(949, 50)
        Me.Controls.Add(Me.AppNameLabel)
        Me.Controls.Add(Me.ClockBT)
        Me.Controls.Add(Me.MainBT)
        Me.Controls.Add(Me.Button4)
        Me.Font = New System.Drawing.Font("NeoDunggeunmo", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BottomBar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "BottomBar"
        Me.MainMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents AppNameLabel As Label
    Friend WithEvents ClockBT As Button
    Friend WithEvents MainBT As Button
    Friend WithEvents MainMenu As ContextMenuStrip
    Friend WithEvents TabKeyMenu As ToolStripMenuItem
    Friend WithEvents VolumeMenu As ToolStripMenuItem
    Friend WithEvents ClockTimer As Timer
End Class
