Public Class BottomBar
    Public CurrentTaskName As String = ""
    Public CurrentProcessName As String = ""
    Declare Function Wow64DisableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Declare Function Wow64EnableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Private osk As String = "C:\Windows\System32\osk.exe"

    Private Sub BottomBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Width = My.Computer.Screen.WorkingArea.Width
        Me.Location = New Point(0, My.Computer.Screen.WorkingArea.Height)
        DesktopForm.TopMost = False
        TopMost = True
        AppNameLabel.Text = CurrentTaskName
        ClockBT.Text = Now.Hour & ":" & Now.Minute
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim pcProcess() As Process


        If CurrentProcessName.Contains("\") Then
            pcProcess = Process.GetProcessesByName(CurrentProcessName.Split("\").Last.Replace(".exe", ""))
        ElseIf CurrentProcessName.Contains(".exe") Then
            pcProcess = Process.GetProcessesByName(CurrentProcessName.Replace(".exe", ""))
        Else
            pcProcess = Process.GetProcessesByName(CurrentProcessName)
        End If

        'MsgBox(pcProcess.Length)

        For Each p In pcProcess
            p.Kill()
        Next

        If CurrentProcessName = "VoiceRecog.exe" Then
            pcProcess = Process.GetProcessesByName("msedge")
            For Each p In pcProcess
                p.CloseMainWindow()
            Next
        End If

        Close()
    End Sub

    Private Sub TabKeyMenu_Click(sender As Object, e As EventArgs) Handles TabKeyMenu.Click
        Dim old As Long
        If Environment.Is64BitOperatingSystem Then
            If Wow64DisableWow64FsRedirection(old) Then
                Process.Start(osk)
                Wow64EnableWow64FsRedirection(old)
            End If
        Else
            Process.Start(osk)
        End If
    End Sub

    Private Sub VolumeMenu_Click(sender As Object, e As EventArgs) Handles VolumeMenu.Click
        VolumeSetForm.Close()
        VolumeSetForm.SetDesktopLocation(My.Computer.Screen.WorkingArea.Width - VolumeSetForm.Width,
                                         My.Computer.Screen.WorkingArea.Height - VolumeSetForm.Height)
        VolumeSetForm.Show()
    End Sub

    Private Sub MainBT_Click(sender As Object, e As EventArgs) Handles MainBT.Click
        MainMenu.Show(Cursor.Position)
    End Sub

    Private Sub ClockTimer_Tick(sender As Object, e As EventArgs) Handles ClockTimer.Tick
        ClockBT.Text = Now.ToString("HH:mm")
    End Sub
End Class