Public Class BackgroundSetForm
    Dim SetColor As New Color
    Dim SetImage As String

    Dim colorChanged As Boolean = False
    Dim imageChanged As Boolean = False

    Dim fillimg As Boolean = False


    Private Sub SetColorBT_Click(sender As Object, e As EventArgs) Handles SetColorBT.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            'SetINI("VBMO", "bgColor", ColorTranslator.ToHtml(ColorDialog1.Color))
            PrevBox.BackColor = ColorDialog1.Color
            SetColor = ColorDialog1.Color
            colorChanged = True
        End If
    End Sub

    Private Sub SetImageBT_Click(sender As Object, e As EventArgs) Handles SetImageBT.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            'SetINI("VBMO", "bgImage", OpenFileDialog1.FileName)
            Try
                PrevBox.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
                SetImage = OpenFileDialog1.FileName
                imageChanged = True
            Catch ex As Exception
                imageChanged = False
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Height = My.Computer.Screen.Bounds.Size.Height
        Width = My.Computer.Screen.WorkingArea.Width
        Me.Location = New Point(0, 0)
        ClockBT.Text = Now.ToString("HH:mm:ss")

        If Not GetINI("VBMO", "bgColor") = "" Then
            PrevBox.BackColor = ColorTranslator.FromHtml(GetINI("VBMO", "bgColor"))
        Else
            PrevBox.BackColor = Color.FromArgb(209, 253, 213)
        End If

        If My.Computer.FileSystem.FileExists(GetINI("VBMO", "bgImage")) Then
            PrevBox.BackgroundImage = Image.FromFile(GetINI("VBMO", "bgImage"))
        Else
            PrevBox.BackgroundImage = Nothing
        End If

        fillimg = (GetINI("VBMO", "FillBackImg") = "True")
        FillImgChkUpdate()

        TopMost = (GetINI("VBMO", "topmost") = "True")

    End Sub

    Private Sub FillImgChkUpdate()
        If fillimg Then
            FillImgChk.Image = My.Resources.chk_1
            PrevBox.BackgroundImageLayout = ImageLayout.Stretch
        Else
            FillImgChk.Image = My.Resources.chk_0
            PrevBox.BackgroundImageLayout = ImageLayout.Zoom
        End If
    End Sub

    Private Sub ClockTimer_Tick(sender As Object, e As EventArgs) Handles ClockTimer.Tick
        ClockBT.Text = Now.ToString("HH:mm:ss")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If imageChanged Then SetINI("VBMO", "bgImage", """" + OpenFileDialog1.FileName + """")
        If colorChanged Then SetINI("VBMO", "bgColor", ColorTranslator.ToHtml(ColorDialog1.Color))
        SetINI("VBMO", "FillBackImg", fillimg.ToString)
        DesktopForm.UpdateBackTheme()
        Close()
    End Sub

    Private Sub FillImgChk_Click(sender As Object, e As EventArgs) Handles FillImgChk.Click, FillImgLabel.Click
        fillimg = Not fillimg
        FillImgChkUpdate()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SetINI("VBMO", "bgImage", "")
        SetINI("VBMO", "bgColor", "")
        SetINI("VBMO", "FillBackImg", "")
        DesktopForm.UpdateBackTheme()
        Close()
    End Sub
End Class