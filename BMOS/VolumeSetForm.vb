Imports CoreAudioApi
Public Class VolumeSetForm
    Dim DevEnum As New MMDeviceEnumerator
    Dim device As MMDevice = DevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia)
    Dim Svol As Integer = 0
    Dim touched As Boolean = False

    'FUNCTION SET VOLUME
    Private Sub SetVol()
        device.AudioEndpointVolume.MasterVolumeLevelScalar = Svol / 100.0F
    End Sub

    'FUNCTION GET VOLUME
    Private Function GetVol() As Integer
        Dim MasterMin As Integer = 0
        Dim Vol As Integer = 0
        With device.AudioEndpointVolume
            Vol = CInt(.MasterVolumeLevelScalar * 100)
            If Vol < MasterMin Then
                Vol = MasterMin / 100
            End If
        End With
        Return Vol
    End Function

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateVolVal()
        TopMost = True
        If device.AudioEndpointVolume.Mute Then
            MuteBT.BackgroundImage = My.Resources.spk_mute
        Else
            MuteBT.BackgroundImage = My.Resources.spk_active
        End If
    End Sub

    Private Sub DownBT_Click(sender As Object, e As EventArgs)
        device.AudioEndpointVolume.VolumeStepDown()
        updateVolVal()
    End Sub

    Private Sub UpBT_Click(sender As Object, e As EventArgs)
        device.AudioEndpointVolume.VolumeStepUp()
        updateVolVal()
    End Sub

    Private Sub MuteBT_Click(sender As Object, e As EventArgs) Handles MuteBT.Click
        device.AudioEndpointVolume.Mute = Not device.AudioEndpointVolume.Mute
        updateVolVal()
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles VolPanel.MouseMove, VolAccentPanel.MouseMove
        If touched Then
            updateVolSet(e)
        End If
    End Sub

    Sub updateVolVal()
        Dim val = GetVol()
        VolAccentPanel.Width = VolPanel.Width * (val / 100)
        Label1.Text = val.ToString
        If device.AudioEndpointVolume.Mute Then
            MuteBT.BackgroundImage = My.Resources.spk_mute
            VolAccentPanel.BackColor = Color.Gray
        Else
            MuteBT.BackgroundImage = My.Resources.spk_active
            VolAccentPanel.BackColor = Color.FromArgb(99, 176, 150)
        End If
    End Sub

    Sub updateVolSet(e As MouseEventArgs)
        Dim val As Integer = Convert.ToInt32(Math.Round((e.X / (VolPanel.Width)) * 100))

        If val <= 100 And val >= 0 Then

            If val < 5 Then
                val = 0
            ElseIf val > 95 Then
                val = 100
            End If

            Svol = val
            Label1.Text = Svol.ToString
            VolAccentPanel.Width = VolPanel.Width * (val / 100)

            SetVol()
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles VolPanel.MouseUp, VolAccentPanel.MouseUp
        touched = False
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles VolPanel.MouseDown, VolAccentPanel.MouseDown
        touched = True
        updateVolSet(e)
    End Sub

    Private Sub VolumeSetForm_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        Close()
    End Sub
End Class