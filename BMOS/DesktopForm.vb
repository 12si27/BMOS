Public Class DesktopForm
    '가로 폭 918px!!!
    'rightpadding: 77

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreMenuItem.Click
        If Not (GetINI("VBMO", "killexp") = "False") Then
            Process.Start("C:\Windows\explorer.exe")
            Shell("taskkill /f /im DesktopCoral.exe")
        Else
            Dim pcProcess() As Process = Process.GetProcessesByName("explorer")
            If pcProcess.Length < 1 Then Process.Start("C:\Windows\explorer.exe")
        End If

        If Not (GetINI("VBMO", "dcautostart") = "False") Then
            Shell("cmd /c ""timeout 5 /nobreak && start """" ""C:\Program Files (x86)\DesktopCoral\DesktopCoral.exe""""")
        End If

        Application.Exit()
    End Sub

    Private Sub MainBT_Click(sender As Object, e As EventArgs) Handles MainBT.Click
        MainMenu.Show(Cursor.Position)
    End Sub

    Private Sub AppBT_Click(sender As Object, e As EventArgs) Handles AppBT.Click
        AppMenu.Show(Cursor.Position)
    End Sub

    Private Sub ViewBT_Click(sender As Object, e As EventArgs) Handles ViewBT.Click
        ViewMenu.Show(Cursor.Position)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not (GetINI("VBMO", "killexp") = "False") Then
            Shell("taskkill /f /im explorer.exe")
        End If

        Height = My.Computer.Screen.Bounds.Size.Height
        Width = My.Computer.Screen.WorkingArea.Width

        TopMost = (GetINI("VBMO", "topmost") = "True")
        DoubleBuffered = Not (GetINI("VBMO", "disabledbuffer") = "True")

        Me.Location = New Point(0, 0)
        ClockBT.Text = Now.ToString("HH:mm:ss")
        UpdateBackTheme()
    End Sub


    Public Sub UpdateBackTheme()

        Try
            If Not GetINI("VBMO", "bgColor") = "" Then
                Panel3.BackColor = ColorTranslator.FromHtml(GetINI("VBMO", "bgColor"))
            Else
                Panel3.BackColor = Color.FromArgb(209, 253, 213)
            End If

            If My.Computer.FileSystem.FileExists(GetINI("VBMO", "bgImage")) Then
                Panel3.BackgroundImage = Image.FromFile(GetINI("VBMO", "bgImage"))
            Else
                Panel3.BackgroundImage = Nothing
            End If

            If GetINI("VBMO", "FillBackImg") = "True" Then
                Panel3.BackgroundImageLayout = ImageLayout.Stretch
            Else
                Panel3.BackgroundImageLayout = ImageLayout.Zoom
            End If
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try

    End Sub

    Private Sub VOLUMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolMenuItem.Click
        VolumeSetForm.SetDesktopLocation(0, TopMenuPanel.Height)
        VolumeSetForm.Show(Me)
    End Sub

    Private Sub ClockTimer_Tick(sender As Object, e As EventArgs) Handles ClockTimer.Tick
        ClockBT.Text = Now.ToString("HH:mm:ss")
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles WebBrowserAppItem.Click
        AppLoad("웹 브라우저", "C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", "--start-maximized")
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles CalcAppItem.Click
        AppLoad("계산기", "bmoscalc.exe", "")
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles TerminalAppItem.Click
        AppLoad("터미널", "cmd", "")
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles FileExplorerAppItem.Click
        AppLoad("파일 탐색기", "explorer", "")
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles VLCAppItem.Click
        AppLoad("VLC 플레이어", "vlc.exe", "")
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles NotepadAppItem.Click
        AppLoad("메모장", "notepad", "")
    End Sub

    Private Sub VRecgBT_Click(sender As Object, e As EventArgs) Handles VRecgBT.Click
        AppLoad("음성 명령", "VoiceRecog.exe", "")
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles SystemSettingItem.Click
        Shell("control.exe")
    End Sub

    Private Sub EditBT_Click(sender As Object, e As EventArgs) Handles EditBT.Click
        EditMenu.Show(Cursor.Position)
    End Sub

    Private Sub BgSettingItem_Click(sender As Object, e As EventArgs) Handles BgSettingItem.Click
        BackgroundSetForm.Show()

    End Sub

    Private Sub OSSettingItem_Click(sender As Object, e As EventArgs) Handles OSSettingItem.Click
        OSSettingForm.Show()
    End Sub

    Private Sub SysShutdownItem_Click(sender As Object, e As EventArgs) Handles SysShutdownItem.Click
        BackCover.Show()
        ShutdownForm.Show()
    End Sub

    Private Sub OSInfoItem_Click(sender As Object, e As EventArgs) Handles OSInfoItem.Click
        BackCover.Show()
        InfoForm.Show()
    End Sub
End Class
