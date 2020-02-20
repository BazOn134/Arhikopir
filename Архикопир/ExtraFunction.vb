Module ExtraFunction
    Sub PopupVBS(Optional sMsg As String = "Выполнено", Optional iTime As Integer = 1, Optional sTitle As String = "Информация", Optional iIcon As Integer = 64)
        Dim FSO = CreateObject("Scripting.FileSystemObject")
        Dim sPath As String = Environ("temp") & "\" & Format(Now, "HHmmss ddMMyyyy") & ".vbs"
        Dim oFile = FSO.CreateTextFile(sPath)
        oFile.WriteLine("sMsg = " & Chr(34) & sMsg & Chr(34))
        oFile.WriteLine("iTime = " & iTime)
        oFile.WriteLine("sTitle = """ & sTitle & """")
        oFile.WriteLine("iIcon = " & iIcon)
        oFile.WriteLine("")
        oFile.WriteLine("CreateObject(""WScript.Shell"").Popup sMsg, iTime, sTitle, iIcon")
        oFile.WriteLine("")
        oFile.Close
        Process.Start(sPath)
    End Sub
End Module
