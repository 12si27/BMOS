<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TopMenuPanel = New System.Windows.Forms.Panel()
        Me.ClockBT = New System.Windows.Forms.Button()
        Me.VRecgBT = New System.Windows.Forms.Button()
        Me.AppBT = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.AnsTB = New System.Windows.Forms.TextBox()
        Me.fmTB = New System.Windows.Forms.TextBox()
        Me.pmBT = New System.Windows.Forms.Button()
        Me.addBT = New System.Windows.Forms.Button()
        Me.copyBT = New System.Windows.Forms.Button()
        Me.resetBT = New System.Windows.Forms.Button()
        Me.clearBT = New System.Windows.Forms.Button()
        Me.calcBT = New System.Windows.Forms.Button()
        Me.divBT = New System.Windows.Forms.Button()
        Me.mulBT = New System.Windows.Forms.Button()
        Me.subBT = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ClockTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MainBT = New System.Windows.Forms.Button()
        Me.TopMenuPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopMenuPanel
        '
        Me.TopMenuPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TopMenuPanel.Controls.Add(Me.ClockBT)
        Me.TopMenuPanel.Controls.Add(Me.VRecgBT)
        Me.TopMenuPanel.Controls.Add(Me.AppBT)
        Me.TopMenuPanel.Controls.Add(Me.MainBT)
        Me.TopMenuPanel.Controls.Add(Me.Panel2)
        Me.TopMenuPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopMenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.TopMenuPanel.Name = "TopMenuPanel"
        Me.TopMenuPanel.Size = New System.Drawing.Size(891, 95)
        Me.TopMenuPanel.TabIndex = 1
        '
        'ClockBT
        '
        Me.ClockBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClockBT.Dock = System.Windows.Forms.DockStyle.Right
        Me.ClockBT.FlatAppearance.BorderSize = 0
        Me.ClockBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClockBT.Font = New System.Drawing.Font("NeoDunggeunmo", 30.0!, System.Drawing.FontStyle.Bold)
        Me.ClockBT.ForeColor = System.Drawing.Color.Gray
        Me.ClockBT.Location = New System.Drawing.Point(648, 0)
        Me.ClockBT.Margin = New System.Windows.Forms.Padding(4)
        Me.ClockBT.Name = "ClockBT"
        Me.ClockBT.Size = New System.Drawing.Size(243, 86)
        Me.ClockBT.TabIndex = 6
        Me.ClockBT.Text = "12:27:00"
        Me.ClockBT.UseVisualStyleBackColor = True
        '
        'VRecgBT
        '
        Me.VRecgBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.VRecgBT.Dock = System.Windows.Forms.DockStyle.Left
        Me.VRecgBT.FlatAppearance.BorderSize = 0
        Me.VRecgBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VRecgBT.Font = New System.Drawing.Font("NeoDunggeunmo", 27.0!)
        Me.VRecgBT.Location = New System.Drawing.Point(371, 0)
        Me.VRecgBT.Margin = New System.Windows.Forms.Padding(4)
        Me.VRecgBT.Name = "VRecgBT"
        Me.VRecgBT.Size = New System.Drawing.Size(138, 86)
        Me.VRecgBT.TabIndex = 5
        Me.VRecgBT.UseVisualStyleBackColor = True
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
        Me.AppBT.Size = New System.Drawing.Size(238, 86)
        Me.AppBT.TabIndex = 2
        Me.AppBT.Text = "계산기"
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
        Me.Panel2.Size = New System.Drawing.Size(891, 9)
        Me.Panel2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(15, 15, 15, 0)
        Me.Panel1.Size = New System.Drawing.Size(386, 479)
        Me.Panel1.TabIndex = 23
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.AnsTB, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.fmTB, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(15, 15)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(356, 464)
        Me.TableLayoutPanel2.TabIndex = 21
        '
        'AnsTB
        '
        Me.AnsTB.BackColor = System.Drawing.Color.Gainsboro
        Me.AnsTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AnsTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnsTB.Font = New System.Drawing.Font("NeoDunggeunmo", 50.0!, System.Drawing.FontStyle.Bold)
        Me.AnsTB.ForeColor = System.Drawing.Color.Black
        Me.AnsTB.Location = New System.Drawing.Point(3, 235)
        Me.AnsTB.Multiline = True
        Me.AnsTB.Name = "AnsTB"
        Me.AnsTB.ReadOnly = True
        Me.AnsTB.Size = New System.Drawing.Size(350, 226)
        Me.AnsTB.TabIndex = 0
        Me.AnsTB.Text = "12227"
        '
        'fmTB
        '
        Me.fmTB.BackColor = System.Drawing.Color.Gainsboro
        Me.fmTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.fmTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fmTB.Font = New System.Drawing.Font("NeoDunggeunmo", 30.0!)
        Me.fmTB.ForeColor = System.Drawing.Color.Gray
        Me.fmTB.Location = New System.Drawing.Point(3, 3)
        Me.fmTB.Multiline = True
        Me.fmTB.Name = "fmTB"
        Me.fmTB.ReadOnly = True
        Me.fmTB.Size = New System.Drawing.Size(350, 226)
        Me.fmTB.TabIndex = 20
        Me.fmTB.Text = "1+2+3+4+5+6"
        '
        'pmBT
        '
        Me.pmBT.BackColor = System.Drawing.Color.White
        Me.pmBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pmBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pmBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pmBT.Font = New System.Drawing.Font("NeoDunggeunmo", 25.0!)
        Me.pmBT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pmBT.Location = New System.Drawing.Point(15, 379)
        Me.pmBT.Margin = New System.Windows.Forms.Padding(5)
        Me.pmBT.Name = "pmBT"
        Me.pmBT.Size = New System.Drawing.Size(108, 85)
        Me.pmBT.TabIndex = 43
        Me.pmBT.Text = "-/+"
        Me.pmBT.UseVisualStyleBackColor = False
        '
        'addBT
        '
        Me.addBT.BackColor = System.Drawing.Color.White
        Me.addBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.addBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addBT.Font = New System.Drawing.Font("NeoDunggeunmo", 50.0!)
        Me.addBT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.addBT.Location = New System.Drawing.Point(369, 15)
        Me.addBT.Margin = New System.Windows.Forms.Padding(5)
        Me.addBT.Name = "addBT"
        Me.addBT.Size = New System.Drawing.Size(109, 81)
        Me.addBT.TabIndex = 42
        Me.addBT.Text = "+"
        Me.addBT.UseVisualStyleBackColor = False
        '
        'copyBT
        '
        Me.copyBT.BackColor = System.Drawing.Color.White
        Me.copyBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.copyBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.copyBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.copyBT.Font = New System.Drawing.Font("NeoDunggeunmo", 15.0!)
        Me.copyBT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.copyBT.Location = New System.Drawing.Point(251, 15)
        Me.copyBT.Margin = New System.Windows.Forms.Padding(5)
        Me.copyBT.Name = "copyBT"
        Me.copyBT.Size = New System.Drawing.Size(108, 81)
        Me.copyBT.TabIndex = 41
        Me.copyBT.Text = "복사" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "하기"
        Me.copyBT.UseVisualStyleBackColor = False
        '
        'resetBT
        '
        Me.resetBT.BackColor = System.Drawing.Color.White
        Me.resetBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.resetBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.resetBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.resetBT.Font = New System.Drawing.Font("NeoDunggeunmo", 15.0!)
        Me.resetBT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.resetBT.Location = New System.Drawing.Point(133, 15)
        Me.resetBT.Margin = New System.Windows.Forms.Padding(5)
        Me.resetBT.Name = "resetBT"
        Me.resetBT.Size = New System.Drawing.Size(108, 81)
        Me.resetBT.TabIndex = 40
        Me.resetBT.Text = "초기화"
        Me.resetBT.UseVisualStyleBackColor = False
        '
        'clearBT
        '
        Me.clearBT.BackColor = System.Drawing.Color.White
        Me.clearBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clearBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.clearBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearBT.Font = New System.Drawing.Font("NeoDunggeunmo", 15.0!)
        Me.clearBT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.clearBT.Location = New System.Drawing.Point(15, 15)
        Me.clearBT.Margin = New System.Windows.Forms.Padding(5)
        Me.clearBT.Name = "clearBT"
        Me.clearBT.Size = New System.Drawing.Size(108, 81)
        Me.clearBT.TabIndex = 39
        Me.clearBT.Text = "지우기"
        Me.clearBT.UseVisualStyleBackColor = False
        '
        'calcBT
        '
        Me.calcBT.BackColor = System.Drawing.Color.White
        Me.calcBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.calcBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.calcBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calcBT.Font = New System.Drawing.Font("NeoDunggeunmo", 50.0!)
        Me.calcBT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.calcBT.Location = New System.Drawing.Point(369, 379)
        Me.calcBT.Margin = New System.Windows.Forms.Padding(5)
        Me.calcBT.Name = "calcBT"
        Me.calcBT.Size = New System.Drawing.Size(109, 85)
        Me.calcBT.TabIndex = 38
        Me.calcBT.Text = "="
        Me.calcBT.UseVisualStyleBackColor = False
        '
        'divBT
        '
        Me.divBT.BackColor = System.Drawing.Color.White
        Me.divBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.divBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.divBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.divBT.Font = New System.Drawing.Font("NeoDunggeunmo", 50.0!)
        Me.divBT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.divBT.Location = New System.Drawing.Point(369, 288)
        Me.divBT.Margin = New System.Windows.Forms.Padding(5)
        Me.divBT.Name = "divBT"
        Me.divBT.Size = New System.Drawing.Size(109, 81)
        Me.divBT.TabIndex = 37
        Me.divBT.Text = "÷"
        Me.divBT.UseVisualStyleBackColor = False
        '
        'mulBT
        '
        Me.mulBT.BackColor = System.Drawing.Color.White
        Me.mulBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mulBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.mulBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mulBT.Font = New System.Drawing.Font("NeoDunggeunmo", 50.0!)
        Me.mulBT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mulBT.Location = New System.Drawing.Point(369, 197)
        Me.mulBT.Margin = New System.Windows.Forms.Padding(5)
        Me.mulBT.Name = "mulBT"
        Me.mulBT.Size = New System.Drawing.Size(109, 81)
        Me.mulBT.TabIndex = 36
        Me.mulBT.Text = "×"
        Me.mulBT.UseVisualStyleBackColor = False
        '
        'subBT
        '
        Me.subBT.BackColor = System.Drawing.Color.White
        Me.subBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.subBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.subBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subBT.Font = New System.Drawing.Font("NeoDunggeunmo", 50.0!)
        Me.subBT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.subBT.Location = New System.Drawing.Point(369, 106)
        Me.subBT.Margin = New System.Windows.Forms.Padding(5)
        Me.subBT.Name = "subBT"
        Me.subBT.Size = New System.Drawing.Size(109, 81)
        Me.subBT.TabIndex = 35
        Me.subBT.Text = "-"
        Me.subBT.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.White
        Me.Button11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("NeoDunggeunmo", 40.0!)
        Me.Button11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button11.Location = New System.Drawing.Point(251, 379)
        Me.Button11.Margin = New System.Windows.Forms.Padding(5)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(108, 85)
        Me.Button11.TabIndex = 34
        Me.Button11.Text = "."
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.White
        Me.Button10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("NeoDunggeunmo", 30.0!)
        Me.Button10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button10.Location = New System.Drawing.Point(133, 379)
        Me.Button10.Margin = New System.Windows.Forms.Padding(5)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(108, 85)
        Me.Button10.TabIndex = 33
        Me.Button10.Text = "0"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.White
        Me.Button9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("NeoDunggeunmo", 30.0!)
        Me.Button9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button9.Location = New System.Drawing.Point(251, 288)
        Me.Button9.Margin = New System.Windows.Forms.Padding(5)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(108, 81)
        Me.Button9.TabIndex = 32
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.White
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("NeoDunggeunmo", 30.0!)
        Me.Button8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button8.Location = New System.Drawing.Point(133, 288)
        Me.Button8.Margin = New System.Windows.Forms.Padding(5)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(108, 81)
        Me.Button8.TabIndex = 31
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("NeoDunggeunmo", 30.0!)
        Me.Button7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button7.Location = New System.Drawing.Point(15, 288)
        Me.Button7.Margin = New System.Windows.Forms.Padding(5)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(108, 81)
        Me.Button7.TabIndex = 30
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("NeoDunggeunmo", 30.0!)
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(251, 197)
        Me.Button6.Margin = New System.Windows.Forms.Padding(5)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(108, 81)
        Me.Button6.TabIndex = 29
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("NeoDunggeunmo", 30.0!)
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(133, 197)
        Me.Button5.Margin = New System.Windows.Forms.Padding(5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(108, 81)
        Me.Button5.TabIndex = 28
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("NeoDunggeunmo", 30.0!)
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(15, 197)
        Me.Button4.Margin = New System.Windows.Forms.Padding(5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(108, 81)
        Me.Button4.TabIndex = 27
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("NeoDunggeunmo", 30.0!)
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(251, 106)
        Me.Button3.Margin = New System.Windows.Forms.Padding(5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 81)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("NeoDunggeunmo", 30.0!)
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(133, 106)
        Me.Button2.Margin = New System.Windows.Forms.Padding(5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 81)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("NeoDunggeunmo", 30.0!)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(15, 106)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 81)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.clearBT, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.calcBT, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.pmBT, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Button11, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button10, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.addBT, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.divBT, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.mulBT, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.copyBT, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.subBT, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.resetBT, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Button5, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Button6, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Button7, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Button8, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Button9, 2, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(395, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(493, 479)
        Me.TableLayoutPanel1.TabIndex = 44
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.10774!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.89226!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 95)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(891, 485)
        Me.TableLayoutPanel3.TabIndex = 22
        '
        'ClockTimer
        '
        Me.ClockTimer.Enabled = True
        Me.ClockTimer.Interval = 1000
        '
        'MainBT
        '
        Me.MainBT.BackgroundImage = Global.bmoscalc.My.Resources.Resources.calc
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(891, 580)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TopMenuPanel)
        Me.Font = New System.Drawing.Font("NeoDunggeunmo", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TopMenuPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopMenuPanel As Panel
    Friend WithEvents ClockBT As Button
    Friend WithEvents VRecgBT As Button
    Friend WithEvents AppBT As Button
    Friend WithEvents MainBT As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AnsTB As TextBox
    Friend WithEvents fmTB As TextBox
    Friend WithEvents pmBT As Button
    Friend WithEvents addBT As Button
    Friend WithEvents copyBT As Button
    Friend WithEvents resetBT As Button
    Friend WithEvents clearBT As Button
    Friend WithEvents calcBT As Button
    Friend WithEvents divBT As Button
    Friend WithEvents mulBT As Button
    Friend WithEvents subBT As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents ClockTimer As Timer
End Class
