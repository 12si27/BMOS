<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DesktopForm
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
        Me.components = New System.ComponentModel.Container()
        Me.TopMenuPanel = New System.Windows.Forms.Panel()
        Me.ClockBT = New System.Windows.Forms.Button()
        Me.VRecgBT = New System.Windows.Forms.Button()
        Me.ViewBT = New System.Windows.Forms.Button()
        Me.EditBT = New System.Windows.Forms.Button()
        Me.AppBT = New System.Windows.Forms.Button()
        Me.MainBT = New System.Windows.Forms.Button()
        Me.MainMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VolMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SysShutdownItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.AppMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NotepadAppItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalcAppItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TerminalAppItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebBrowserAppItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileExplorerAppItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VLCAppItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OSSettingItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemSettingItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BgSettingItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClockTimer = New System.Windows.Forms.Timer(Me.components)
        Me.OSInfoItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TopMenuPanel.SuspendLayout()
        Me.MainMenu.SuspendLayout()
        Me.AppMenu.SuspendLayout()
        Me.EditMenu.SuspendLayout()
        Me.ViewMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopMenuPanel
        '
        Me.TopMenuPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TopMenuPanel.Controls.Add(Me.ClockBT)
        Me.TopMenuPanel.Controls.Add(Me.VRecgBT)
        Me.TopMenuPanel.Controls.Add(Me.ViewBT)
        Me.TopMenuPanel.Controls.Add(Me.EditBT)
        Me.TopMenuPanel.Controls.Add(Me.AppBT)
        Me.TopMenuPanel.Controls.Add(Me.MainBT)
        Me.TopMenuPanel.Controls.Add(Me.Panel2)
        Me.TopMenuPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopMenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.TopMenuPanel.Name = "TopMenuPanel"
        Me.TopMenuPanel.Size = New System.Drawing.Size(918, 95)
        Me.TopMenuPanel.TabIndex = 0
        '
        'ClockBT
        '
        Me.ClockBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClockBT.Dock = System.Windows.Forms.DockStyle.Right
        Me.ClockBT.FlatAppearance.BorderSize = 0
        Me.ClockBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClockBT.Font = New System.Drawing.Font("NeoDunggeunmo", 30.0!, System.Drawing.FontStyle.Bold)
        Me.ClockBT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ClockBT.Location = New System.Drawing.Point(675, 0)
        Me.ClockBT.Margin = New System.Windows.Forms.Padding(4)
        Me.ClockBT.Name = "ClockBT"
        Me.ClockBT.Size = New System.Drawing.Size(243, 86)
        Me.ClockBT.TabIndex = 6
        Me.ClockBT.Text = "12:27:00"
        Me.ClockBT.UseVisualStyleBackColor = True
        '
        'VRecgBT
        '
        Me.VRecgBT.BackgroundImage = Global.BMOS.My.Resources.Resources.micicon
        Me.VRecgBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.VRecgBT.Dock = System.Windows.Forms.DockStyle.Left
        Me.VRecgBT.FlatAppearance.BorderSize = 0
        Me.VRecgBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VRecgBT.Font = New System.Drawing.Font("NeoDunggeunmo", 27.0!)
        Me.VRecgBT.Location = New System.Drawing.Point(547, 0)
        Me.VRecgBT.Margin = New System.Windows.Forms.Padding(4)
        Me.VRecgBT.Name = "VRecgBT"
        Me.VRecgBT.Size = New System.Drawing.Size(138, 86)
        Me.VRecgBT.TabIndex = 5
        Me.VRecgBT.UseVisualStyleBackColor = True
        '
        'ViewBT
        '
        Me.ViewBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ViewBT.Dock = System.Windows.Forms.DockStyle.Left
        Me.ViewBT.FlatAppearance.BorderSize = 0
        Me.ViewBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewBT.Font = New System.Drawing.Font("NeoDunggeunmo", 27.0!)
        Me.ViewBT.Location = New System.Drawing.Point(409, 0)
        Me.ViewBT.Margin = New System.Windows.Forms.Padding(4)
        Me.ViewBT.Name = "ViewBT"
        Me.ViewBT.Size = New System.Drawing.Size(138, 86)
        Me.ViewBT.TabIndex = 4
        Me.ViewBT.Text = "보기"
        Me.ViewBT.UseVisualStyleBackColor = True
        '
        'EditBT
        '
        Me.EditBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.EditBT.Dock = System.Windows.Forms.DockStyle.Left
        Me.EditBT.FlatAppearance.BorderSize = 0
        Me.EditBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditBT.Font = New System.Drawing.Font("NeoDunggeunmo", 27.0!)
        Me.EditBT.Location = New System.Drawing.Point(271, 0)
        Me.EditBT.Margin = New System.Windows.Forms.Padding(4)
        Me.EditBT.Name = "EditBT"
        Me.EditBT.Size = New System.Drawing.Size(138, 86)
        Me.EditBT.TabIndex = 3
        Me.EditBT.Text = "편집"
        Me.EditBT.UseVisualStyleBackColor = True
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
        Me.AppBT.Size = New System.Drawing.Size(138, 86)
        Me.AppBT.TabIndex = 2
        Me.AppBT.Text = "앱"
        Me.AppBT.UseVisualStyleBackColor = True
        '
        'MainBT
        '
        Me.MainBT.BackgroundImage = Global.BMOS.My.Resources.Resources.logo
        Me.MainBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MainBT.ContextMenuStrip = Me.MainMenu
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
        'MainMenu
        '
        Me.MainMenu.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MainMenu.Font = New System.Drawing.Font("NeoDunggeunmo", 29.0!)
        Me.MainMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolMenuItem, Me.RestoreMenuItem, Me.SysShutdownItem})
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MainMenu.ShowImageMargin = False
        Me.MainMenu.Size = New System.Drawing.Size(455, 256)
        '
        'VolMenuItem
        '
        Me.VolMenuItem.Margin = New System.Windows.Forms.Padding(0, 15, 0, 15)
        Me.VolMenuItem.Name = "VolMenuItem"
        Me.VolMenuItem.Size = New System.Drawing.Size(454, 54)
        Me.VolMenuItem.Text = " 음량 조절"
        '
        'RestoreMenuItem
        '
        Me.RestoreMenuItem.Margin = New System.Windows.Forms.Padding(0, 15, 0, 15)
        Me.RestoreMenuItem.Name = "RestoreMenuItem"
        Me.RestoreMenuItem.Size = New System.Drawing.Size(454, 54)
        Me.RestoreMenuItem.Text = " 윈도우로 복구"
        '
        'SysShutdownItem
        '
        Me.SysShutdownItem.Margin = New System.Windows.Forms.Padding(0, 15, 0, 15)
        Me.SysShutdownItem.Name = "SysShutdownItem"
        Me.SysShutdownItem.Size = New System.Drawing.Size(454, 54)
        Me.SysShutdownItem.Text = " 시스템 종료"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 86)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(918, 9)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 95)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(918, 655)
        Me.Panel3.TabIndex = 1
        '
        'AppMenu
        '
        Me.AppMenu.BackColor = System.Drawing.Color.WhiteSmoke
        Me.AppMenu.Font = New System.Drawing.Font("NeoDunggeunmo", 29.0!)
        Me.AppMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.AppMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NotepadAppItem, Me.CalcAppItem, Me.TerminalAppItem, Me.WebBrowserAppItem, Me.FileExplorerAppItem, Me.VLCAppItem})
        Me.AppMenu.Name = "MainMenu"
        Me.AppMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.AppMenu.ShowImageMargin = False
        Me.AppMenu.Size = New System.Drawing.Size(405, 508)
        '
        'NotepadAppItem
        '
        Me.NotepadAppItem.Margin = New System.Windows.Forms.Padding(0, 15, 0, 15)
        Me.NotepadAppItem.Name = "NotepadAppItem"
        Me.NotepadAppItem.Size = New System.Drawing.Size(404, 54)
        Me.NotepadAppItem.Text = " 메모장"
        '
        'CalcAppItem
        '
        Me.CalcAppItem.Margin = New System.Windows.Forms.Padding(0, 15, 0, 15)
        Me.CalcAppItem.Name = "CalcAppItem"
        Me.CalcAppItem.Size = New System.Drawing.Size(404, 54)
        Me.CalcAppItem.Text = " 계산기"
        '
        'TerminalAppItem
        '
        Me.TerminalAppItem.Margin = New System.Windows.Forms.Padding(0, 15, 0, 15)
        Me.TerminalAppItem.Name = "TerminalAppItem"
        Me.TerminalAppItem.Size = New System.Drawing.Size(404, 54)
        Me.TerminalAppItem.Text = " 터미널"
        '
        'WebBrowserAppItem
        '
        Me.WebBrowserAppItem.Margin = New System.Windows.Forms.Padding(0, 15, 0, 15)
        Me.WebBrowserAppItem.Name = "WebBrowserAppItem"
        Me.WebBrowserAppItem.Size = New System.Drawing.Size(404, 54)
        Me.WebBrowserAppItem.Text = " 웹 브라우저"
        '
        'FileExplorerAppItem
        '
        Me.FileExplorerAppItem.Margin = New System.Windows.Forms.Padding(0, 15, 0, 15)
        Me.FileExplorerAppItem.Name = "FileExplorerAppItem"
        Me.FileExplorerAppItem.Size = New System.Drawing.Size(404, 54)
        Me.FileExplorerAppItem.Text = " 파일 탐색기"
        '
        'VLCAppItem
        '
        Me.VLCAppItem.Margin = New System.Windows.Forms.Padding(0, 15, 0, 15)
        Me.VLCAppItem.Name = "VLCAppItem"
        Me.VLCAppItem.Size = New System.Drawing.Size(404, 54)
        Me.VLCAppItem.Text = " VLC"
        '
        'EditMenu
        '
        Me.EditMenu.BackColor = System.Drawing.Color.WhiteSmoke
        Me.EditMenu.Font = New System.Drawing.Font("NeoDunggeunmo", 29.0!)
        Me.EditMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.EditMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SystemSettingItem, Me.OSSettingItem, Me.OSInfoItem})
        Me.EditMenu.Name = "MainMenu"
        Me.EditMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.EditMenu.ShowImageMargin = False
        Me.EditMenu.Size = New System.Drawing.Size(405, 284)
        '
        'OSSettingItem
        '
        Me.OSSettingItem.Margin = New System.Windows.Forms.Padding(0, 15, 0, 15)
        Me.OSSettingItem.Name = "OSSettingItem"
        Me.OSSettingItem.Size = New System.Drawing.Size(404, 54)
        Me.OSSettingItem.Text = " BMOS 설정"
        '
        'SystemSettingItem
        '
        Me.SystemSettingItem.Margin = New System.Windows.Forms.Padding(0, 15, 0, 15)
        Me.SystemSettingItem.Name = "SystemSettingItem"
        Me.SystemSettingItem.Size = New System.Drawing.Size(404, 54)
        Me.SystemSettingItem.Text = " 시스템 설정"
        '
        'ViewMenu
        '
        Me.ViewMenu.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ViewMenu.Font = New System.Drawing.Font("NeoDunggeunmo", 29.0!)
        Me.ViewMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ViewMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BgSettingItem})
        Me.ViewMenu.Name = "MainMenu"
        Me.ViewMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ViewMenu.ShowImageMargin = False
        Me.ViewMenu.Size = New System.Drawing.Size(430, 88)
        '
        'BgSettingItem
        '
        Me.BgSettingItem.Margin = New System.Windows.Forms.Padding(0, 15, 0, 15)
        Me.BgSettingItem.Name = "BgSettingItem"
        Me.BgSettingItem.Size = New System.Drawing.Size(429, 54)
        Me.BgSettingItem.Text = " 배경 설정..."
        '
        'ClockTimer
        '
        Me.ClockTimer.Enabled = True
        Me.ClockTimer.Interval = 1000
        '
        'OSInfoItem
        '
        Me.OSInfoItem.Margin = New System.Windows.Forms.Padding(0, 15, 0, 15)
        Me.OSInfoItem.Name = "OSInfoItem"
        Me.OSInfoItem.Size = New System.Drawing.Size(404, 54)
        Me.OSInfoItem.Text = " BMOS 정보"
        '
        'DesktopForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(918, 750)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TopMenuPanel)
        Me.Font = New System.Drawing.Font("NeoDunggeunmo", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DesktopForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.TopMenuPanel.ResumeLayout(False)
        Me.MainMenu.ResumeLayout(False)
        Me.AppMenu.ResumeLayout(False)
        Me.EditMenu.ResumeLayout(False)
        Me.ViewMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopMenuPanel As Panel
    Friend WithEvents MainBT As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents VRecgBT As Button
    Friend WithEvents ViewBT As Button
    Friend WithEvents EditBT As Button
    Friend WithEvents AppBT As Button
    Friend WithEvents MainMenu As ContextMenuStrip
    Friend WithEvents RestoreMenuItem As ToolStripMenuItem
    Friend WithEvents VolMenuItem As ToolStripMenuItem
    Friend WithEvents Panel3 As Panel
    Friend WithEvents SysShutdownItem As ToolStripMenuItem
    Friend WithEvents AppMenu As ContextMenuStrip
    Friend WithEvents NotepadAppItem As ToolStripMenuItem
    Friend WithEvents CalcAppItem As ToolStripMenuItem
    Friend WithEvents TerminalAppItem As ToolStripMenuItem
    Friend WithEvents FileExplorerAppItem As ToolStripMenuItem
    Friend WithEvents WebBrowserAppItem As ToolStripMenuItem
    Friend WithEvents EditMenu As ContextMenuStrip
    Friend WithEvents OSSettingItem As ToolStripMenuItem
    Friend WithEvents SystemSettingItem As ToolStripMenuItem
    Friend WithEvents ViewMenu As ContextMenuStrip
    Friend WithEvents ClockBT As Button
    Friend WithEvents ClockTimer As Timer
    Friend WithEvents VLCAppItem As ToolStripMenuItem
    Friend WithEvents BgSettingItem As ToolStripMenuItem
    Friend WithEvents OSInfoItem As ToolStripMenuItem
End Class
