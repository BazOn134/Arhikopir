Imports System.IO
'My.Settings.LogFilePath - LogFilePath 'String' необходимо добавить в свойства проекта

Public Class Loger
    Const DefaultLogFile As String = "C:\LogFile.txt"
    Public Shared sPathLogActive As String

    Shared Sub SessionOpen(Optional bProg As Boolean = True, Optional ByVal Message As String = "")
        'Stop
        If Message = "" Then Message = "   ===   НАЧАТА НОВАЯ СЕССИЯ   ===   НАЧАТА НОВАЯ СЕССИЯ   ===     " & Now
        Dim objLogFile As StreamWriter, LogFilePath As String

        If bProg Then
            LogFilePath = My.Settings.LogFilePath
        Else
            LogFilePath = sPathLogActive
        End If

        If File.Exists(LogFilePath) Then
            objLogFile = File.AppendText(LogFilePath)
        ElseIf Directory.Exists(Path.GetDirectoryName(LogFilePath)) Then
            objLogFile = File.CreateText(LogFilePath)
        Else
            objLogFile = File.AppendText(DefaultLogFile)
        End If
        objLogFile.WriteLine(Message)
        objLogFile.Flush()
        objLogFile.Close()
    End Sub

    Shared Sub SessionClose(Optional ByVal Message As String = "")
        If Message = "" Then Message = "   ===   СЕССИЯ ЗАКРЫТА   ===   СЕССИЯ ЗАКРЫТА   ===     " & Now
        If File.Exists(My.Settings.LogFilePath) Then Stop 'ТОДО срочно дописать закрытие проги
    End Sub

    Shared Sub Log(ByVal Message As String, Optional ByVal LogFilePath As String = "")
        'Stop
        If sPathLogActive = Nothing Then MessageBox.Show("sPathLogActive в процедуре Loger.Log отсутствует") : End '
        If LogFilePath = "" Then LogFilePath = sPathLogActive
        WriteLog(Message, LogFilePath)
    End Sub

    Shared Sub LogProg(ByVal Message As String, Optional ByVal LogFilePath As String = "")
        'Stop
        If LogFilePath = "" Then LogFilePath = My.Settings.LogFilePath
        WriteLog(Message, LogFilePath)
    End Sub

    Shared Sub Clear(Optional ByVal LogFilePath As String = "")
        Dim objLogFile As StreamWriter
        If LogFilePath = "" Then LogFilePath = Application.StartupPath() & "\LogProg.txt"
        If File.Exists(LogFilePath) Then objLogFile = File.CreateText(LogFilePath) : objLogFile.Close()
    End Sub

    Shared Sub Del(Optional ByVal LogFilePath As String = "")
        If LogFilePath = "" Then LogFilePath = Application.StartupPath() & "\LogProg.txt"
        If File.Exists(LogFilePath) Then Kill(LogFilePath)
    End Sub

    Private Shared Sub WriteLog(ByVal Message As String, Optional ByVal LogFilePath As String = "")
        'Stop
        Dim objLogFile As StreamWriter
        If File.Exists(LogFilePath) Then
            objLogFile = File.AppendText(LogFilePath)
        ElseIf Directory.Exists(Path.GetDirectoryName(LogFilePath)) Then
            objLogFile = File.CreateText(LogFilePath)
        Else
            objLogFile = File.AppendText(DefaultLogFile)
        End If
        objLogFile.WriteLine(Now & vbTab & Message)
        objLogFile.Flush()
        objLogFile.Close()
    End Sub
End Class

'Private LogPath As String
'Public Property LogFilePath() As String
'    Get
'        Return LogPath
'    End Get
'    Set(ByVal value As String)
'        LogPath = value
'    End Set
'End Property