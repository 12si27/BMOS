<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoForm
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
        Me.AppBT = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TopMenuPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TopMenuPanel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AppBT
        '
        Me.AppBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AppBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AppBT.FlatAppearance.BorderSize = 0
        Me.AppBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AppBT.Font = New System.Drawing.Font("NeoDunggeunmo", 20.0!)
        Me.AppBT.Location = New System.Drawing.Point(0, 0)
        Me.AppBT.Margin = New System.Windows.Forms.Padding(4)
        Me.AppBT.Name = "AppBT"
        Me.AppBT.Size = New System.Drawing.Size(706, 62)
        Me.AppBT.TabIndex = 2
        Me.AppBT.Text = "BMOS 정보"
        Me.AppBT.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 62)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(706, 9)
        Me.Panel2.TabIndex = 0
        '
        'TopMenuPanel
        '
        Me.TopMenuPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TopMenuPanel.Controls.Add(Me.AppBT)
        Me.TopMenuPanel.Controls.Add(Me.Panel2)
        Me.TopMenuPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopMenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.TopMenuPanel.Name = "TopMenuPanel"
        Me.TopMenuPanel.Size = New System.Drawing.Size(706, 71)
        Me.TopMenuPanel.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Location = New System.Drawing.Point(39, 336)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(623, 2)
        Me.Panel1.TabIndex = 10
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button3.BackColor = System.Drawing.Color.LightGray
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("NeoDunggeunmo", 20.0!)
        Me.Button3.Location = New System.Drawing.Point(252, 355)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(192, 55)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "닫기"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.RichTextBox1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(706, 433)
        Me.Panel3.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("NeoDunggeunmo", 35.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(178, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 59)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "BMOS v1.0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("NeoDunggeunmo", 18.0!)
        Me.Label2.Location = New System.Drawing.Point(182, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(344, 31)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "BMO-PC 전용 소프트웨어"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("NeoDunggeunmo", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(188, 207)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(474, 107)
        Me.RichTextBox1.TabIndex = 14
        Me.RichTextBox1.Text = "https://github.com/12si27/bmos" & Global.Microsoft.VisualBasic.ChrW(10) & "BMOS by 1227" & Global.Microsoft.VisualBasic.ChrW(10) & "마지막 빌드: 20210823" & Global.Microsoft.VisualBasic.ChrW(10) & "This software uses l" &
    "ibraries from the FFmpeg project under the LGPLv2.1" & Global.Microsoft.VisualBasic.ChrW(10) & "This software released under" &
    " GNU General Public License v3.0" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BMOS.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(43, 98)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'InfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(706, 433)
        Me.Controls.Add(Me.TopMenuPanel)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("NeoDunggeunmo", 20.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InfoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InfoForm"
        Me.TopMost = True
        Me.TopMenuPanel.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AppBT As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TopMenuPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
