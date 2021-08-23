Public Class OSSettingForm

    Dim S_autostart As Boolean = False
    Dim S_topmost As Boolean = False
    Dim S_dcautostart As Boolean = False
    Dim S_dbuffer As Boolean = False
    Dim S_killexp As Boolean = False

    Dim shortcutname = "\VBMO.lnk"

    Public Function checkStartUp() As Boolean
        Dim destlnk As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup) & shortcutname

        If IO.File.Exists(destlnk) Then
            If GetTargetPath(destlnk) = Application.ExecutablePath Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Sub SetStartup()
        Dim Path As String
        Dim identity = Security.Principal.WindowsIdentity.GetCurrent()
        Dim principal = New Security.Principal.WindowsPrincipal(identity)

        Path = Environment.GetFolderPath(Environment.SpecialFolder.Startup) & shortcutname

        Dim wsh As Object = CreateObject("WScript.Shell")

        Dim MyShortcut
        MyShortcut = wsh.CreateShortcut(Path)
        MyShortcut.TargetPath = wsh.ExpandEnvironmentStrings(Application.ExecutablePath)
        MyShortcut.WindowStyle = 4
        MyShortcut.Save()
    End Sub

    Sub RemoveStartup()
        My.Computer.FileSystem.DeleteFile(Environment.GetFolderPath(Environment.SpecialFolder.Startup) & shortcutname)
    End Sub

    Function GetTargetPath(ByVal FileName As String)
        Dim Obj As Object
        Obj = CreateObject("WScript.Shell")
        Dim Shortcut As Object
        Shortcut = Obj.CreateShortcut(FileName)
        GetTargetPath = Shortcut.TargetPath
    End Function

    Private Sub OSSettingForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        Height = My.Computer.Screen.Bounds.Size.Height
        Width = My.Computer.Screen.WorkingArea.Width
        Me.Location = New Point(0, 0)
        ClockBT.Text = Now.ToString("HH:mm:ss")

        S_autostart = checkStartUp()
        S_topmost = (GetINI("BMOS", "topmost") = "True")
        S_dcautostart = Not (GetINI("BMOS", "dcautostart") = "False")
        S_dbuffer = (GetINI("BMOS", "disabledbuffer") = "True")
        S_killexp = Not (GetINI("BMOS", "killexp") = "False")

        TopMost = (GetINI("BMOS", "topmost") = "True")

        DrawChk()

    End Sub

    Private Sub DrawChk()
        If S_autostart Then
            AutostartChk.Image = My.Resources.chk_1
        Else
            AutostartChk.Image = My.Resources.chk_0
        End If

        If S_topmost Then
            TopmostChk.Image = My.Resources.chk_1
        Else
            TopmostChk.Image = My.Resources.chk_0
        End If

        If S_dcautostart Then
            DcautostartChk.Image = My.Resources.chk_1
        Else
            DcautostartChk.Image = My.Resources.chk_0
        End If

        If S_dbuffer Then
            DbufferChk.Image = My.Resources.chk_1
        Else
            DbufferChk.Image = My.Resources.chk_0
        End If

        If S_killexp Then
            KillexpChk.Image = My.Resources.chk_1
        Else
            KillexpChk.Image = My.Resources.chk_0
        End If
    End Sub

    Private Sub AutostartChk_Click(sender As Object, e As EventArgs) Handles AutostartChk.Click, AutostartLabel.Click
        S_autostart = Not S_autostart
        DrawChk()
    End Sub

    Private Sub TopmostChk_Click(sender As Object, e As EventArgs) Handles TopmostChk.Click, TopmostLabel.Click
        S_topmost = Not S_topmost
        DrawChk()
    End Sub

    Private Sub DcautostartChk_Click(sender As Object, e As EventArgs) Handles DcautostartChk.Click, DcautostartLabel.Click
        S_dcautostart = Not S_dcautostart
        DrawChk()
    End Sub

    Private Sub DbufferChk_Click(sender As Object, e As EventArgs) Handles DbufferChk.Click, DbufferLabel.Click
        S_dbuffer = Not S_dbuffer
        DrawChk()
    End Sub

    Private Sub KillexpChk_Click(sender As Object, e As EventArgs) Handles KillexpChk.Click, KillexpLabel.Click
        S_killexp = Not S_killexp
        DrawChk()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try
            If S_autostart Then
                SetStartup()
            Else
                RemoveStartup()
            End If
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try

        SetINI("BMOS", "topmost", S_topmost.ToString)
        SetINI("BMOS", "dcautostart", S_dcautostart.ToString)
        SetINI("BMOS", "disabledbuffer", S_dbuffer.ToString)
        SetINI("BMOS", "killexp", S_killexp.ToString)
        Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SetINI("BMOS", "topmost", "")
        SetINI("BMOS", "dcautostart", "")
        SetINI("BMOS", "disabledbuffer", "")
        SetINI("BMOS", "killexp", "")
        Close()
    End Sub

    Private Sub ClockTimer_Tick(sender As Object, e As EventArgs) Handles ClockTimer.Tick
        ClockBT.Text = Now.ToString("HH:mm:ss")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class