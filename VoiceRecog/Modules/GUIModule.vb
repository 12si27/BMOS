Imports System.Runtime.InteropServices

Module GUIModule

#Region "Aero 그림자 효과 (Vista이상)"
    Structure MARGINS
        Public Left, Right, Top, Bottom As Integer
    End Structure

    <DllImport("dwmapi.dll", PreserveSig:=True)>
    Private Function DwmSetWindowAttribute(hwnd As IntPtr, attr As Integer, ByRef attrValue As Integer, attrSize As Integer) As Integer
    End Function

    <DllImport("dwmapi.dll")>
    Private Function DwmExtendFrameIntoClientArea(hWnd As IntPtr, ByRef pMarInset As MARGINS) As Integer
    End Function

    Public Function CreateDropShadow(form As Form) As Boolean
        Try
            Dim val As Integer = 2
            Dim ret1 As Integer = DwmSetWindowAttribute(form.Handle, 2, val, 4)

            If ret1 = 0 Then
                Dim m As MARGINS = New MARGINS() With {
                        .Left = 0,
                        .Right = 0,
                        .Top = 1,
                        .Bottom = 0
                    }

                Dim ret2 As Integer = DwmExtendFrameIntoClientArea(form.Handle, m)
                Return ret2 = 0
            Else
                Return False
            End If
        Catch ex As Exception
            'dwmapi.dll 없음
            Return False
        End Try
    End Function

#End Region

#Region "DPI 계산 (고해상도 디스플레이용)"
    Public Function dpicalc(targetform As Form, size As Integer)
        Dim g As Graphics = targetform.CreateGraphics
        Dim dpi = g.DpiX.ToString()

        Dim current = dpi / 96
        Dim expand = current * size

        Return expand
    End Function
#End Region

#Region "창 페이드 인/아웃 효과"
    Public Sub FadeIn(Form As Form, goalopacity As Double)

        Do While Form.Opacity < goalopacity - 0.1
            Form.Opacity += 0.1
            Threading.Thread.Sleep(10)
        Loop

        Form.Opacity = goalopacity
    End Sub

    Public Sub FadeOut(Form As Form)

        Do While Not Form.Opacity = 0
            Form.Opacity = Form.Opacity - 0.1
            Threading.Thread.Sleep(10)
        Loop

    End Sub
#End Region


End Module
