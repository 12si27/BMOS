Public Class ShutdownForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Shell("shutdown -s -t 0")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Shell("shutdown -r -t 0")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BackCover.Close()
        Close()
    End Sub
End Class