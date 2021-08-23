Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Text

'Usage
'GetINI("SETTING", "ColorMode")
'SetINI("SETTING", "ColorMode", strvalve)

Module INIModule
    Public ReadOnly ININame As String = "settings.ini"
    Public ReadOnly INIPath As String = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\"))
    Public ReadOnly ININamePath As String = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\")) + "\" + ININame


#Region "INI 관련 함수들"

    <DllImport("kernel32.dll", SetLastError:=True)>
    Public Function GetPrivateProfileString(ByVal lpAppName As String,
                                                    ByVal lpKeyName As String,
                                                    ByVal lpDefault As String,
                                                    ByVal lpReturnedString As StringBuilder,
                                                    ByVal nSize As Integer,
                                                    ByVal lpFileName As String) As Integer
    End Function

    <DllImport("kernel32.dll", SetLastError:=True)>
    Public Function WritePrivateProfileString(ByVal lpAppName As String,
                                                      ByVal lpKeyName As String,
                                                      ByVal lpString As String,
                                                      ByVal lpFileName As String) As Boolean
    End Function

    ''' <summary>
    ''' INI 설정 함수
    ''' </summary>
    ''' <param name="strAppName">AppName 값 (ex:[SETTINGS])</param>
    ''' <param name="strKey">Key 값 (ex:TopMost)</param>
    ''' <param name="strValue">설정 값 (ex:True)</param>
    ''' <returns></returns>
    Public Function SetINI(ByVal strAppName As String,
                            ByVal strKey As String,
                            ByVal strValue As String) As Boolean
        SetINI = WritePrivateProfileString(strAppName, strKey, strValue, ININamePath)
    End Function

    ''' <summary>
    ''' INI 읽기 함수
    ''' </summary>
    ''' <param name="strAppName">AppName 값 (ex:[SETTINGS])</param>
    ''' <param name="strKey">Key 값 (ex:TopMost)</param>
    ''' <returns>설정 값</returns>
    Public Function GetINI(ByVal strAppName As String, ByVal strKey As String) As String
        Dim strbTmp As StringBuilder = New StringBuilder(255)
        GetPrivateProfileString(strAppName, strKey, "", strbTmp, strbTmp.Capacity, ININamePath)
        GetINI = strbTmp.ToString()
    End Function

    Public Function Create_INIFile(ByVal strPath As String, ByVal strFileName As String) As Boolean
        If Dir(strPath & "\" & strFileName) <> "" Then
            Return True
            Exit Function
        End If

        Try
            Using sw As StreamWriter = New StreamWriter(strPath & "\" & strFileName, False)
                sw.WriteLine(vbCrLf)
                sw.Flush()
                sw.Close()
            End Using
        Catch ex As Exception
            Return False
        End Try

        Return True
    End Function

#End Region

End Module
