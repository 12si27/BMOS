<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VolumeSetForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VolPanel = New System.Windows.Forms.Panel()
        Me.VolAccentPanel = New System.Windows.Forms.Panel()
        Me.MuteBT = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.VolPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("NeoDunggeunmo", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(499, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 65)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "100"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VolPanel
        '
        Me.VolPanel.Controls.Add(Me.VolAccentPanel)
        Me.VolPanel.Location = New System.Drawing.Point(96, 24)
        Me.VolPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.VolPanel.Name = "VolPanel"
        Me.VolPanel.Size = New System.Drawing.Size(395, 65)
        Me.VolPanel.TabIndex = 4
        '
        'VolAccentPanel
        '
        Me.VolAccentPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.VolAccentPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.VolAccentPanel.Location = New System.Drawing.Point(0, 0)
        Me.VolAccentPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.VolAccentPanel.Name = "VolAccentPanel"
        Me.VolAccentPanel.Size = New System.Drawing.Size(218, 65)
        Me.VolAccentPanel.TabIndex = 0
        '
        'MuteBT
        '
        Me.MuteBT.BackgroundImage = Global.BMOS.My.Resources.Resources.spk_active
        Me.MuteBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MuteBT.FlatAppearance.BorderSize = 0
        Me.MuteBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MuteBT.Font = New System.Drawing.Font("NeoDunggeunmo", 30.0!)
        Me.MuteBT.Location = New System.Drawing.Point(18, 24)
        Me.MuteBT.Margin = New System.Windows.Forms.Padding(4)
        Me.MuteBT.Name = "MuteBT"
        Me.MuteBT.Size = New System.Drawing.Size(70, 65)
        Me.MuteBT.TabIndex = 0
        Me.MuteBT.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MuteBT)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.VolPanel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(592, 117)
        Me.Panel1.TabIndex = 5
        '
        'VolumeSetForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(602, 127)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("NeoDunggeunmo", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "VolumeSetForm"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "음량 조절"
        Me.VolPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MuteBT As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents VolPanel As Panel
    Friend WithEvents VolAccentPanel As Panel
    Friend WithEvents Panel1 As Panel
End Class
