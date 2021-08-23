Public Class Form1
    '1=더하기 2=빼기 3=곱하기 4=나누기
    Dim calcMode As Integer = 0
    Dim prevVal As String = ""
    Dim calcDone As Boolean = False
    Dim flushLog As Boolean = False '계산 작업 후 기록 지우기위해

    Private Sub NumberButtons_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click,
            Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click,
            Button11.Click
        addValue(sender.Text)
    End Sub

    Private Sub calcButtons_Click(sender As Object, e As EventArgs) Handles addBT.Click, subBT.Click, mulBT.Click, divBT.Click
        '계산 모드가 지정되어 있고 이전값이 존재할시
        If Not calcMode = 0 And Not prevVal = "" Then runCalc(False)

        Select Case sender.Name
            Case addBT.Name
                setCalcMode(1)
            Case subBT.Name
                setCalcMode(2)
            Case mulBT.Name
                setCalcMode(3)
            Case divBT.Name
                setCalcMode(4)
        End Select
    End Sub

    Private Sub setCalcMode(mode As Integer)
        calcMode = mode

        addBT.ForeColor = Color.FromArgb(64, 64, 64)
        subBT.ForeColor = Color.FromArgb(64, 64, 64)
        mulBT.ForeColor = Color.FromArgb(64, 64, 64)
        divBT.ForeColor = Color.FromArgb(64, 64, 64)

        Select Case mode
            Case 1
                addBT.ForeColor = Color.DodgerBlue
            Case 2
                subBT.ForeColor = Color.DodgerBlue
            Case 3
                mulBT.ForeColor = Color.DodgerBlue
            Case 4
                divBT.ForeColor = Color.DodgerBlue
        End Select
    End Sub

    Private Sub calcBT_Click(sender As Object, e As EventArgs) Handles calcBT.Click
        runCalc(True)
    End Sub

    Private Function doCalc(num1 As String, num2 As String)
        Dim tmp1 As Double = Convert.ToDouble(num1)
        Dim tmp2 As Double = Convert.ToDouble(num2)

        Select Case calcMode
            Case 1
                Return tmp1 + tmp2
            Case 2
                Return tmp1 - tmp2
            Case 3
                Return tmp1 * tmp2
            Case 4
                Return tmp1 / tmp2
        End Select
    End Function

    Private Sub runCalc(finished As Boolean)
        If prevVal = "" Then Exit Sub

        Try
            If fmTB.Text = "" Then updateLog(prevVal, True)
            updateLog(AnsTB.Text, False)
            AnsTB.Text = doCalc(prevVal, AnsTB.Text)

            If finished Then
                flushLog = True
                fmTB.Text += " ="
            End If
        Catch ex As Exception
            AnsTB.Text = "오류"
        End Try

        '계산 성공했으므로 초기화
        resetCalc()
    End Sub

    Private Sub updateLog(addval As String, numOnly As Boolean)
        If Not numOnly Then
            Select Case calcMode
                Case 1
                    fmTB.Text += " + "
                Case 2
                    fmTB.Text += " - "
                Case 3
                    fmTB.Text += " × "
                Case 4
                    fmTB.Text += " ÷ "
            End Select

        End If

        fmTB.Text += addval
    End Sub

    Private Sub resetCalc()
        setCalcMode(0)
        prevVal = ""
        calcDone = True
    End Sub

    Private Sub addValue(value As String)
        '계산 모드가 지정되었다면
        If Not calcMode = 0 Then
            '이전 계산값이 없는 경우라면
            If prevVal = "" Then
                prevVal = AnsTB.Text
                AnsTB.Text = ""
            End If
        End If

        If calcDone Then
            AnsTB.Text = ""
            calcDone = False
        End If

        If flushLog Then
            fmTB.Text = ""
            flushLog = False
        End If

        AnsTB.Text += value
    End Sub

    Private Sub clearBT_Click(sender As Object, e As EventArgs) Handles clearBT.Click
        AnsTB.Text = ""
    End Sub

    Private Sub resetBT_Click(sender As Object, e As EventArgs) Handles resetBT.Click
        resetCalc()
        AnsTB.Text = ""
        fmTB.Text = ""
    End Sub

    Private Sub copyBT_Click(sender As Object, e As EventArgs) Handles copyBT.Click
        Clipboard.SetText(AnsTB.Text)
    End Sub

    Private Sub pmBT_Click(sender As Object, e As EventArgs) Handles pmBT.Click
        '유효한 숫자 값일때
        If IsNumeric(AnsTB.Text) Then AnsTB.Text = (Convert.ToDouble(AnsTB.Text) * -1).ToString
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        calcBT.Focus() '기존에 클릭한 버튼에 포커스를 잃도록 -> 안하면 엔터쳤을때 눌려버림

        Select Case e.KeyCode
            Case Keys.D1, Keys.NumPad1
                addValue("1")
            Case Keys.D2, Keys.NumPad2
                addValue("2")
            Case Keys.D3, Keys.NumPad3
                addValue("3")
            Case Keys.D4, Keys.NumPad4
                addValue("4")
            Case Keys.D5, Keys.NumPad5
                addValue("5")
            Case Keys.D6, Keys.NumPad6
                addValue("6")
            Case Keys.D7, Keys.NumPad7
                addValue("7")
            Case Keys.D8, Keys.NumPad8
                addValue("8")
            Case Keys.D9, Keys.NumPad9
                addValue("9")
            Case Keys.D0, Keys.NumPad0
                addValue("0")
            Case Keys.Decimal, Keys.OemPeriod
                addValue(".")
            Case Keys.Enter
                runCalc(True)
            Case Keys.Back
                AnsTB.Text = Mid(AnsTB.Text, 1, AnsTB.Text.Length - 1)
            Case Keys.Add, Keys.OemMinus, Keys.Subtract, Keys.Multiply, Keys.Divide
                If Not calcMode = 0 And Not prevVal = "" Then runCalc(False)

                Select Case e.KeyCode
                    Case Keys.Add
                        setCalcMode(1)
                    Case Keys.OemMinus, Keys.Subtract
                        setCalcMode(2)
                    Case Keys.Multiply
                        setCalcMode(3)
                    Case Keys.Divide
                        setCalcMode(4)
                End Select
            Case Keys.Escape
                resetCalc()
                AnsTB.Text = ""
                fmTB.Text = ""
            Case Keys.Delete
                AnsTB.Text = ""
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        fmTB.Text = ""
        AnsTB.Text = ""

        Width = My.Computer.Screen.WorkingArea.Width
        Height = My.Computer.Screen.WorkingArea.Height
        SetDesktopLocation(0, 0)
    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles ClockTimer.Tick
        ClockBT.Text = Now.ToString("HH:mm:ss")
    End Sub
End Class
