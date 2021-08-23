Module TaskModule
    Private Declare Sub keybd_event Lib "user32.dll" (ByVal bVk As IntPtr, ByVal bScan As IntPtr, ByVal dwFlags As IntPtr, ByVal dwExtraInfo As IntPtr)

    Private Const VK_STARTKEY = &H5B
    Private Const KEYEVENTF_KEYUP = &H2
    Private Const KEYEVENTF_KEYDOWN = &H0

    Public DoingTasks As Boolean = False

    Sub SearchTask(keyword As String)
        DoingTasks = True
        Call keybd_event(VK_STARTKEY, 0, KEYEVENTF_KEYDOWN, 0)
        Call keybd_event(VK_STARTKEY, 0, KEYEVENTF_KEYUP, 0)

        Threading.Thread.Sleep(500)

        Dim altkw = AlterKeyword(keyword)
        SendKeys.Send(altkw)

        Threading.Thread.Sleep(1000)
        SendKeys.Send("{ENTER}")
        DoingTasks = False
    End Sub

    Public Function AlterKeyword(keyword As String)

        If My.Computer.FileSystem.FileExists("alterKeyList.txt") Then

            Dim values = My.Computer.FileSystem.ReadAllText("alterKeyList.txt", System.Text.Encoding.GetEncoding(949))
            Dim lines As New List(Of String)

            For Each line As String In values.Split(vbCr)
                If Not line = Nothing And line.Contains(vbTab) And Not line.Contains("#") Then lines.Add(line.Replace(vbCr, "").Replace(vbLf, ""))
            Next

            Dim keyfound As Boolean = False

            For Each s In lines

                Dim keys() = s.Split(vbTab)

                For Each key In keys
                    If Not key = Nothing Then
                        If keyword.Contains(key) Then
                            Return keys(0)
                            Exit Function
                        End If
                    End If
                Next
            Next

            Return keyword

        Else

            Return keyword
        End If
    End Function
End Module