Imports System.Speech
Imports System.Speech.Recognition
Imports System.Threading
Imports System.Globalization
Imports System.Runtime.InteropServices
Imports System.IO

Public Class Face

    Dim Listening As Boolean = False
    Dim resStr As String = Nothing
    Dim resConf As Single = 0
    Dim Filez As String = My.Application.Info.DirectoryPath & "\tmp.wav"
    Dim DebugMode As Boolean = False

    Dim FaceShown = False
    Dim msg As String = ""

    Dim CloseAfterDone As Boolean = False
    Dim HideAfterDone As Boolean = False

    '처음 시작하자마자 바로 리스닝
    Dim forceListenAtStart As Boolean = True

    '상단바 보존시 95 -> 걍 0으로 가자
    ReadOnly UpMarign As Integer = 0

    Dim WithEvents reco As New Recognition.SpeechRecognitionEngine

    <DllImport("winmm.dll")>
    Private Shared Function mciSendString(ByVal command As String, ByVal buffer As String, ByVal bufferSize As Integer, ByVal hwndCallback As IntPtr) As Integer
    End Function

    Sub ShowFace()
        If Not FaceShown Then Opacity = 0
        TopMost = True

        WindowState = FormWindowState.Normal
        'WindowState = FormWindowState.Maximized

        If Not FaceShown Then
            FaceShown = True
            Me.Refresh()
            FadeIn(Me, 1)
        End If
    End Sub

    Sub HideFace()
        FaceShown = False
        Refresh()
        FadeOut(Me)
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.None
        'Me.Bounds = Screen.GetWorkingArea(Me)
        'TopMost = True


        Opacity = 0
        Dim mouseloc As New Point(Cursor.Position.X, Cursor.Position.Y)

        Me.SetDesktopLocation(0, UpMarign)
        Width = My.Computer.Screen.WorkingArea.Width
        Height = My.Computer.Screen.WorkingArea.Height - UpMarign
        'Dim showx = Screen.GetWorkingArea(mouseloc).Width - Width - dpicalc(Me, 50)
        'Dim showy = Screen.GetWorkingArea(mouseloc).Height - Height - dpicalc(Me, 5)
        'SetDesktopLocation(showx, showy)

        'Width = Screen.GetWorkingArea(mouseloc).Width
        'Height = Screen.GetWorkingArea(mouseloc).Height

        ShowFace()
        idleEvent()

        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US")

        '트리거 문법 지정&불러오기
        Dim gram As New Recognition.SrgsGrammar.SrgsDocument
        Dim spkRule As New Recognition.SrgsGrammar.SrgsRule("call")
        'Dim spkList As New Recognition.SrgsGrammar.SrgsOneOf("hey computer", "ya computer", "ya com pu ter")
        Dim spkList As New Recognition.SrgsGrammar.SrgsOneOf("hey bee mo", "hey beemo", "hey be more")

        reco.SetInputToDefaultAudioDevice()

        spkRule.Add(spkList)
        gram.Rules.Add(spkRule)
        gram.Root = spkRule

        reco.LoadGrammar(New Recognition.Grammar(gram))
        reco.RecognizeAsync()

        Try
            mciSendString("open new type waveaudio alias capture", Nothing, 0, 0)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try


    End Sub


    Private Sub Face_Shown(sender As Object, e As EventArgs) Handles Me.Shown


        If forceListenAtStart Then

            SpeechTimeout.Start()
            FaceImg.Image = My.Resources.wait
            ReturnTimer.Stop()
            listeningEvent()

            Listening = True

            My.Computer.Audio.Play(My.Resources.plug, AudioPlayMode.Background)

            mciSendString("open new type waveaudio alias capture", Nothing, 0, 0)
            mciSendString("set time format ms", "", 0, 0)
            mciSendString("set capture channels 1", "", 0, 0)
            mciSendString("set capture samplespersec 16000", "", 0, 0)
            mciSendString("record capture", Nothing, 0, 0)

            resStr = ""

        End If

    End Sub


    Private Sub reco_RecognizeCompleted(sender As Object, e As RecognizeCompletedEventArgs) Handles reco.RecognizeCompleted

        Text = "comp"

        '듣고 있는 중인데 일단 인식 끝났다 판단시
        If Listening And Not DoingTasks Then
            '대기 타이머 업데이트
            WaitTimer.Stop()
            WaitTimer.Start()
            SpeechTimeout.Stop()
        Else
            If resStr = Nothing Then

                FaceImg.Image = My.Resources.idle

            Else

                If Not DoingTasks Then

                    '확신성(Confidence)이 80% 이상일 시에만 인식판단
                    If resConf > 0.8 Then
                        '트리거 키워드 인식시
                        If resStr = "hey bee mo" Or resStr = "hey beemo" Or resStr = "hey be more" Then


                            SpeechTimeout.Start()
                            FaceImg.Image = My.Resources.wait
                            ReturnTimer.Stop()
                            listeningEvent()

                            Listening = True

                            My.Computer.Audio.Play(My.Resources.plug, AudioPlayMode.Background)

                            mciSendString("open new type waveaudio alias capture", Nothing, 0, 0)
                            mciSendString("set time format ms", "", 0, 0)
                            mciSendString("set capture channels 1", "", 0, 0)
                            mciSendString("set capture samplespersec 16000", "", 0, 0)
                            mciSendString("record capture", Nothing, 0, 0)

                            resStr = ""

                        End If
                    Else
                        TryAgainEvent()

                    End If
                End If


            End If

        End If

        reco.RecognizeAsync()

        resStr = Nothing

    End Sub

    Sub DebugWrite(str As String)
        If DebugMode Then
            DebugLabel.Visible = True
            DebugLabel.Text = str
        Else
            DebugLabel.Visible = False
        End If
    End Sub

    Private Sub reco_SpeechRecognized(sender As Object, e As SpeechRecognizedEventArgs) Handles reco.SpeechRecognized
        resStr = e.Result.Text
        resConf = e.Result.Confidence
        DebugWrite("(인식 커맨드:" + resStr + " 확신도:" + resConf.ToString + ")")
    End Sub

    Private Sub reco_SpeechDetected(sender As Object, e As SpeechDetectedEventArgs) Handles reco.SpeechDetected
        Text = "detected"
        DebugWrite("인식 중...")
    End Sub

    Private Sub reco_SpeechRejected(sender As Object, e As SpeechRecognitionRejectedEventArgs) Handles reco.SpeechRecognitionRejected
        DebugWrite("인식 실패")
    End Sub

    Private Sub reco_AudioLevelUpdated(sender As Object, e As AudioLevelUpdatedEventArgs) Handles reco.AudioLevelUpdated
        'Text = e.AudioLevel.ToString + "%"
    End Sub

    Sub idleEvent()
        StateLabel.Text = "'헤이 비모'라고 말해 보세요."
        NotifyIcon1.Icon = My.Resources.bmo_idlle
    End Sub

    Sub listeningEvent()
        ShowFace()
        StateLabel.Text = "듣고 있습니다..."
        NotifyIcon1.Icon = My.Resources.bmo_active
    End Sub

    Sub TryAgainEvent()
        StateLabel.Text = "다시 한번 말해 주세요."
    End Sub

    Private Sub WaitTimer_Tick(sender As Object, e As EventArgs) Handles WaitTimer.Tick

        CloseAfterDone = True
        HideAfterDone = True

        FaceImg.Image = My.Resources.thinking
        DoingTasks = True
        StateLabel.Text = "생각 중..."
        Me.Refresh()

        WaitTimer.Stop()

        Try
            Dim i As Integer
            i = mciSendString("save capture " & Filez, Nothing, 0, 0)
            i = mciSendString("close capture", Nothing, 0, 0)
            'Me.Label1.Text = "Idle"
            Dim pi = New ProcessStartInfo()
            pi.WorkingDirectory = Path.GetDirectoryName(Application.ExecutablePath)
            pi.FileName = "ffmpeg.exe"
            pi.Arguments = "-y -i tmp.wav -sample_fmt s16 new.wav"
            pi.WindowStyle = ProcessWindowStyle.Hidden
            Process.Start(pi)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Dim startInfo As New ProcessStartInfo("pythonw.exe", My.Application.Info.DirectoryPath & "\run.py")
        startInfo.WindowStyle = ProcessWindowStyle.Hidden
        startInfo.RedirectStandardOutput = True
        startInfo.UseShellExecute = False
        Dim proc = Process.Start(startInfo)

        msg = ""

        While (Not proc.StandardOutput.EndOfStream)
            msg = proc.StandardOutput.ReadToEnd
        End While

        '성공적으로 명령을 알아먹었을때
        If msg.Contains("<return>0</return>") Then

            My.Computer.Audio.Play(My.Resources.full, AudioPlayMode.Background)
            FaceImg.Image = My.Resources.ok
            ReturnTimer.Start()
            Refresh()

            If msg.Contains("</res>") Then
                StateLabel.Text = """" + getData(msg, "res") + """"
            End If

            If msg.Contains("</shell>") Then
                SearchTask(getData(msg, "shell"))
            End If

            If msg.Contains("</browse>") Then
                Process.Start("msedge.exe", "--app=" + midReturn("<browse>", "</browse>", msg) + " --start-maximized")
                'Shell("""C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe"" ""--app=" + midReturn("<browse>", "</browse>", msg) + " --start-maximized""")
            End If

            StateLabel.Text = midReturn("<tts>", "</tts>", msg).Replace("<br>", vbCr)

            Clipboard.SetText(midReturn("<tts>", "</tts>", msg).Replace("<br>", ""))
            TTSWorker.RunWorkerAsync()

        Else
            CloseAfterDone = False
            HideAfterDone = False

            DoingTasks = False
            My.Computer.Audio.Play(My.Resources.fail, AudioPlayMode.Background)
            FaceImg.Image = My.Resources.idle
            If msg.Contains("</res>") Then
                StateLabel.Text = """" + getData(msg, "res") + """ ??"
            End If
            ReturnTimer.Start()
            Listening = False
        End If

    End Sub

    Private Sub ReturnTimer_Tick(sender As Object, e As EventArgs) Handles ReturnTimer.Tick
        
        ReturnTimer.Stop()
        FaceImg.Image = My.Resources.idle
        Refresh()

    End Sub

    '중간의 문자열을 리턴하는 함수
    Public Function midReturn(ByVal first As String, ByVal last As String, ByVal total As String) As String
        If last.Length < 1 Then
            midReturn = total.Substring(total.IndexOf(first))
        End If
        If first.Length < 1 Then
            midReturn = total.Substring(0, (total.IndexOf(last)))
        End If

        midReturn = ((total.Substring(total.IndexOf(first), (total.IndexOf(last) - total.IndexOf(first)))).Replace(first, "")).Replace(last, "")
    End Function

    Private Sub SpeechTimeout_Tick(sender As Object, e As EventArgs) Handles SpeechTimeout.Tick
        Text = "timeover"
        mciSendString("close capture", Nothing, 0, 0)
        Listening = False
        My.Computer.Audio.Play(My.Resources.fail, AudioPlayMode.Background)
        FaceImg.Image = My.Resources.idle
        idleEvent()
        WaitTimer.Stop()
        SpeechTimeout.Stop()
    End Sub

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick

        If Not FaceShown Then
            Opacity = 0
            WindowState = FormWindowState.Normal
            Dim mouseloc As New Point(Cursor.Position.X, Cursor.Position.Y)
            Dim showx = mouseloc.X - Width + dpicalc(Me, 204)
            Dim showy = Screen.GetWorkingArea(mouseloc).Height - Height - dpicalc(Me, 5)
            SetDesktopLocation(showx, showy)

            ShowFace()
        Else
            HideFace()
        End If

    End Sub

    Private Sub TTSWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles TTSWorker.DoWork
        If msg.Contains("</tts>") Then
            Dim txt = midReturn("<tts>", "</tts>", msg).Replace("<br>", "")
            msg = ""

            Dim TTSpy As New ProcessStartInfo("pythonw.exe", My.Application.Info.DirectoryPath & "\tts.py -q """ + txt + """")
            TTSpy.WindowStyle = ProcessWindowStyle.Hidden
            TTSpy.RedirectStandardOutput = True
            TTSpy.UseShellExecute = False
            Dim proc2 = Process.Start(TTSpy)

            While (Not proc2.HasExited)
                Threading.Thread.Sleep(100)
            End While

            Threading.Thread.Sleep(100)
        End If
    End Sub

    Private Sub TTSWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles TTSWorker.RunWorkerCompleted
        Listening = False
        DoingTasks = False

        idleEvent()
        '종결 대답일 경우에만 하도록!
        If HideAfterDone Then HideFace()
        If CloseAfterDone Then Application.Exit()
    End Sub

    Private Sub FaceImg_Click(sender As Object, e As EventArgs) Handles FaceImg.Click
        DebugMode = Not DebugMode

        If DebugMode Then
            DebugWrite("디버깅 모드 활성화")
        Else
            DebugWrite("")
        End If
    End Sub

End Class
