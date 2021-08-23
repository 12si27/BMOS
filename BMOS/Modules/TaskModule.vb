Module TaskModule

    Public Sub AppLoad(appname As String, processname As String, args As String)

        Dim bbar As New BottomBar
        bbar.CurrentTaskName = appname
        bbar.CurrentProcessName = processname

        bbar.Show()

        Dim inStartInfo As New ProcessStartInfo
        inStartInfo.WindowStyle = ProcessWindowStyle.Maximized
        inStartInfo.FileName = processname
        inStartInfo.Arguments = args

        Process.Start(inStartInfo)

    End Sub
End Module
