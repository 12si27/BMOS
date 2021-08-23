Public Class BackCover
    Private Sub BackCover_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TopMost = (GetINI("VBMO", "topmost") = "True")
        Height = My.Computer.Screen.Bounds.Size.Height
        Width = My.Computer.Screen.WorkingArea.Width
        Me.Location = New Point(0, 0)
    End Sub
End Class