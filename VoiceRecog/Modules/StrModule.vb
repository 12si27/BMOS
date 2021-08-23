Module StrModule

    'xml형식 파일을 전체값에서 따로 추출하는 함수
    Public Function getData(datastr As String, name As String)

        Return midReturn("<" + name + ">", "</" + name + ">", datastr)

    End Function

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
End Module
