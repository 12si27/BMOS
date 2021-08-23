Imports System.Speech
Imports System.Speech.Recognition
Imports System.Threading
Imports System.Globalization
Imports System.Runtime.InteropServices
Imports System.IO

Public Class Form1

    Dim Listening As Boolean = False
    Dim resStr As String = Nothing
    Dim Filez As String = My.Application.Info.DirectoryPath & "\tmp.wav"

    Dim WithEvents reco As New Recognition.SpeechRecognitionEngine

    <DllImport("winmm.dll")>
    Private Shared Function mciSendString(ByVal command As String, ByVal buffer As String, ByVal bufferSize As Integer, ByVal hwndCallback As IntPtr) As Integer
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US")

        Dim gram As New Recognition.SrgsGrammar.SrgsDocument
        Dim mhRule As New Recognition.SrgsGrammar.SrgsRule("call")
        Dim mhList As New Recognition.SrgsGrammar.SrgsOneOf("ok bmo", "hey bmo", "ya bmo")

        reco.SetInputToDefaultAudioDevice()

        mhRule.Add(mhList)

        gram.Rules.Add(mhRule)

        gram.Root = mhRule

        reco.LoadGrammar(New Recognition.Grammar(gram))

        reco.RecognizeAsync()

        Try
            mciSendString("open new type waveaudio alias capture", Nothing, 0, 0)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub reco_RecognizeCompleted(sender As Object, e As RecognizeCompletedEventArgs) Handles reco.RecognizeCompleted

        'Select Case resStr
        '    Case "maximize"
        '        WindowState = FormWindowState.Maximized

        '    Case "minimize"
        '        WindowState = FormWindowState.Minimized

        '    Case "restore"
        '        WindowState = FormWindowState.Normal

        '    Case "close"

        'End Select

        'If resStr = "close" Then
        '    Close()
        'Else
        '    reco.RecognizeAsync()
        'End If

        '듣고 있는 중인데 일단 인식 끝났다 판단시
        If Listening Then
            WaitTimer.Stop()
            WaitTimer.Start()
            reco.RecognizeAsync()
        Else
            If resStr = Nothing Then

                reco.RecognizeAsync()
                Label1.Text = "Failed to recognize"

            Else
                If resStr = "ok bmo" Or resStr = "hey bmo" Or resStr = "ya bmo" Then
                    Label1.Text = resStr
                    My.Computer.Audio.Play(My.Resources.plug, AudioPlayMode.Background)
                    Listening = True
                    reco.RecognizeAsync()

                    mciSendString("open new type waveaudio alias capture", Nothing, 0, 0)
                    mciSendString("set time format ms", "", 0, 0)
                    mciSendString("set capture channels 1", "", 0, 0)
                    mciSendString("set capture samplespersec 16000", "", 0, 0)
                    mciSendString("record capture", Nothing, 0, 0)

                End If
            End If
        End If

        resStr = Nothing

    End Sub

    Private Sub reco_SpeechRecognized(sender As Object, e As SpeechRecognizedEventArgs) Handles reco.SpeechRecognized
        resStr = e.Result.Text
    End Sub

    Private Sub reco_SpeechDetected(sender As Object, e As SpeechDetectedEventArgs) Handles reco.SpeechDetected
        Label1.Text = "!"
    End Sub

    Private Sub reco_AudioLevelUpdated(sender As Object, e As AudioLevelUpdatedEventArgs) Handles reco.AudioLevelUpdated
        Text = e.AudioLevel.ToString + "%"
    End Sub

    Private Sub WaitTimer_Tick(sender As Object, e As EventArgs) Handles WaitTimer.Tick
        My.Computer.Audio.Play(My.Resources.full, AudioPlayMode.Background)
        Listening = False
        Label1.Text = "Done"
        WaitTimer.Stop()

        Try
            Dim i As Integer
            i = mciSendString("save capture " & Filez, Nothing, 0, 0)
            i = mciSendString("close capture", Nothing, 0, 0)
            Me.Label1.Text = "Idle"
            Dim pi = New ProcessStartInfo()
            pi.WorkingDirectory = Path.GetDirectoryName(Application.ExecutablePath)
            pi.FileName = "ffmpeg.exe"
            pi.Arguments = "-y -i tmp.wav -sample_fmt s16 new.wav"
            Process.Start(pi)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try


        Process.Start(My.Application.Info.DirectoryPath & "\run.py")

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
