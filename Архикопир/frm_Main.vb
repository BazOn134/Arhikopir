Imports System.IO
'Imports Microsoft.VisualBasic.Logging

Public Class Globall
    '#Region'#End Region
    Dim sTXTPath As String = Application.StartupPath() & "\ActivePath.txt"
    Dim sFoldIst As String, sFoldPol As String
    Public bOtv As Boolean
    Public sOtv As String

    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.LogFilePath = "" Then My.Settings.LogFilePath = Application.StartupPath() & "\LogProg.txt"
        If Not My.Settings.LogFilePath = Application.StartupPath() & "\LogProg.txt" Then MessageBox.Show("Лог-файл хранится не в стандартном расположении")
        If Not File.Exists(sTXTPath) Then File.WriteAllText(sTXTPath, "Нет информации", System.Text.Encoding.UTF8)
        lbx_Data.Items.AddRange(File.ReadAllLines(sTXTPath, System.Text.Encoding.UTF8))
        Loger.LogProg("   --- Запуск программы ---")
        ToolStripStatusLabel1.Text = "Выберите строку"
        ToolStripStatusLabel2.Text = ""
    End Sub

    Private Sub Globall_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Loger.LogProg("   --- Закрытие программы ---")
    End Sub

#Region "Неиспользуемые функции обновления"
    Sub Renew(sFoldIst As String, sFoldPol As String)
        If Not Directory.Exists(sFoldIst) Then MessageBox.Show("Папка-источник выбрана не верно (папка не существует)", "Ошибка") : Loger.LogProg("Обновить выделенное: ОШИБКА - папка источник не существует:  =" & sFoldIst & "=") : Exit Sub
        If Not Directory.Exists(sFoldPol) Then IO.Directory.CreateDirectory(sFoldPol) : Loger.LogProg("Обновить выделенное: ОШИБКА - папка-получатель создана:  =" & sFoldIst & "=")

        'oLog.sPathLogFold = sFoldPol & "\Logs.log"
        Loger.LogProg("***   ЗАПУСК ОБНОВЛЕНИЯ: ***   " & sFoldIst & " = " & sFoldPol & "   ***")

        Dim mFoldsIst() As String = Directory.GetDirectories(sFoldIst, "*", SearchOption.AllDirectories)
        Dim mFoldsPol() As String = Directory.GetDirectories(sFoldPol, "*", SearchOption.AllDirectories)
        Dim mFilesIst() As String = Directory.GetFiles(sFoldIst, "*", SearchOption.AllDirectories)
        Dim mFilesPol() As String = Directory.GetFiles(sFoldPol, "*", SearchOption.AllDirectories)
        'Stop
        If mFoldsPol.Length = 0 Or mFilesPol.Length = 0 Then ПервоеКопирование(sFoldIst, sFoldPol, mFoldsIst, mFilesIst) Else СравнениеПапок(sFoldIst, sFoldPol, mFoldsIst, mFoldsPol, mFilesIst, mFilesPol)

    End Sub

    Private Sub ПервоеКопирование(sFoldIst As String, sFoldPol As String, mFoldsIst() As String, mFilesIst() As String) ' прямое копирование
        'ТОДО определять максимальную длину пути
        My.Computer.FileSystem.CopyDirectory(sFoldIst, sFoldPol, True)
        '"\\Localserver\документы отделов\Коммерческая служба\Отдел сбыта\work13_07_06\doc\Работа\Кузьмин\ОП\Молодчикова\Договора 2018\ООО ТЛК-Центр\Отгрузки\На 29.06.18 Рязань"
        Dim sText As String
        For lIND As Long = 0 To mFoldsIst.Length - 1
            sText = Replace(mFoldsIst(lIND), sFoldIst, sFoldPol)
            'My.Computer.FileSystem.CopyDirectory(mFoldsIst(lIND), sText, True)
            Loger.LogProg("Скопирована папка: " & mFoldsIst(lIND) & " >>> " & sText)
        Next
        For lIND As Long = 0 To mFilesIst.Length - 1
            sText = Replace(mFilesIst(lIND), sFoldIst, sFoldPol)
            'My.Computer.FileSystem.CopyFile(mFilesIst(lIND), sText, True)
            Loger.LogProg("Скопирован файл:   " & mFilesIst(lIND) & " >>> " & sText)
        Next
    End Sub

    Private Sub СравнениеПапок(sFoldIst As String, sFoldPol As String, mFoldsIst() As String, mFoldsPol() As String, mFilesIst() As String, mFilesPol() As String)
        Dim w1, w2, w3
        'System.Array.IndexOf(a, "b")
        'Dim mFolds As New ArrayList()
        Dim mFolds As New SortedList()
        'ПЕРЕБОР ПАПОК ИСТ >>> ПОЛ {Добавлен, Сущесвует}
        Loger.LogProg("=== НАЧАТ ПЕРЕБОР ПАПКИ-ИСТОЧНИКА ===")
        For li As Long = 0 To mFoldsIst.Length - 1
            'w1 = Replace(mFoldsIst(li), sFoldIst, sFoldPol)
            'w2 = mFoldsIst(li)
            'w3 = Array.IndexOf(mFoldsPol, w1)
            If Array.IndexOf(mFoldsPol, Replace(mFoldsIst(li), sFoldIst, sFoldPol)) >= 0 Then 'exists
                mFolds.Add(mFoldsIst(li), "Сущесвует")
                Loger.LogProg("Папка существует: " & mFoldsIst(li))
            Else 'not exists
                w1 = mFoldsIst(li)
                w2 = Replace(mFoldsIst(li), sFoldIst, sFoldPol)
                My.Computer.FileSystem.CopyDirectory(mFoldsIst(li), Replace(mFoldsIst(li), sFoldIst, sFoldPol), True)
                mFolds.Add(mFoldsIst(li), "Добавлен")
                Loger.LogProg("Папка добавлена:  " & mFoldsIst(li))
            End If
        Next 'li
        'ПЕРЕБОР ПАПОК ПОЛ >>> ИСТ {Удален}
        Loger.LogProg("=== НАЧАТ ПЕРЕБОР ПАПКИ-ПОЛУЧАТЕЛЯ ===")
        For li As Long = 0 To mFoldsPol.Length - 1
            'Stop
            w1 = mFoldsPol(li)
            w2 = Replace(mFoldsPol(li), sFoldPol, sFoldIst)
            w3 = Array.IndexOf(mFoldsIst, Replace(mFoldsPol(li), sFoldPol, sFoldIst))
            If Array.IndexOf(mFoldsIst, Replace(mFoldsPol(li), sFoldPol, sFoldIst)) < 0 Then 'exists
                mFolds.Add(mFoldsPol(li), "Удален")
                Loger.LogProg("Папка удалена:    " & mFoldsPol(li))
            End If
        Next 'li

        '=====================================================================
        'My.Computer.FileSystem.CopyDirectory("C:\Setup", "F:\Setup", True)  'True - перезапись
        'IO.Directory.Move("C:\Dir", "C:\Dir2")
        'If IO.Directory.Exists("C:\Dir") Then
        'IO.Directory.Delete("C:\Dir", True)
        'Dim sTextVrem As String = Join(mFoldsIst, "===") & "===" & Join(mFoldsIst, "===")
        'Dim mFolds As ArrayList = New ArrayList(Split(sTextVrem, "==="))    
    End Sub
#End Region

#Region "Кнопки обновления"
    Private Sub btn_RefOne_Click(sender As Object, e As EventArgs) Handles btn_RefOne.Click 'Обновить выделенное
        If lbx_Data.SelectedIndex = -1 Then MessageBox.Show("Необходимо выделить строку", "Ошибка") : Loger.LogProg("Обновить выделенное: ОШИБКА - ничего не выделено") : Exit Sub
        Dim sStr = lbx_Data.Items(lbx_Data.SelectedIndex)
        Loger.LogProg("Обновить выделенное: " & sStr)
        Loger.SessionOpen()
        'Renew(Split(sStr, " = ")(0), Split(sStr, " = ")(1))
        Loger.sPathLogActive = Split(sStr, " = ")(1) & "\Log.log"
        Loger.SessionOpen(False)
        Loger.Log("Обновить выделенное: " & sStr)
        sFoldIst = Split(sStr, " = ")(0)
        sFoldPol = Split(sStr, " = ")(1)
        updateOne()
        Loger.SessionClose()
        ToolStripStatusLabel1.Text = "Обновление завершено"
        MessageBox.Show("Обновление завершено")
    End Sub

    Private Sub btn_RefAll_Click(sender As Object, e As EventArgs) Handles btn_RefAll.Click
        Loger.LogProg("Обновить все  (Не фуциклирует)")
        MessageBox.Show("Не фуциклирует")
    End Sub
#End Region

#Region "Кнопки изменения"
    Private Sub btn_Copy_Click(sender As Object, e As EventArgs) Handles btn_Copy.Click
        If lbx_Data.SelectedIndex = -1 Then MessageBox.Show("Необходимо выделить строку", "Ошибка") : Exit Sub
        sOtv = lbx_Data.Items(lbx_Data.SelectedIndex)
        bOtv = False
        frm_Add.ShowDialog()
        ВнестиВСписок()
    End Sub

    Private Sub btn_Conv_Click(sender As Object, e As EventArgs) Handles btn_Conv.Click
        If lbx_Data.SelectedIndex = -1 Then MessageBox.Show("Необходимо выделить строку", "Ошибка") : Exit Sub
        sOtv = lbx_Data.Items(lbx_Data.SelectedIndex)
        bOtv = False
        frm_Add.ShowDialog()
        ВнестиВСписок(False)
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        sOtv = ""
        bOtv = False
        frm_Add.ShowDialog()
        ВнестиВСписок()
    End Sub

    Private Sub btn_Del_Click(sender As Object, e As EventArgs) Handles btn_Del.Click
        If lbx_Data.SelectedIndex = -1 Then MessageBox.Show("Необходимо выделить строку", "Ошибка") : Exit Sub
        Do Until lbx_Data.SelectedItems.Count = 0
            'lbx_Data.Items.Add(lbx_Data.SelectedItems(0)) '
            lbx_Data.Items.Remove(lbx_Data.SelectedItems(0))
        Loop
    End Sub

    Private Sub ВнестиВСписок(Optional bCopy As Boolean = True)
        If Globalls.bOtv Then If bCopy Then lbx_Data.Items.Add(Globalls.sOtv) Else lbx_Data.Items(lbx_Data.SelectedIndex) = Globalls.sOtv
    End Sub
#End Region

#Region "Кнопки обновления и закрытия"
    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Application.Exit() 'End 'Me.Close()
    End Sub

    Private Sub ВыйтиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВыйтиToolStripMenuItem.Click
        Me.btn_Exit_Click(sender, e)
    End Sub
#End Region

#Region "Кнопки меню"
    Private Sub СохранитьПутиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СохранитьПутиToolStripMenuItem.Click
        File.WriteAllLines(sTXTPath, (From p As String In lbx_Data.Items Select p).ToArray, System.Text.Encoding.UTF8)
    End Sub

    Private Sub ОткрытьФайлПутейToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОткрытьФайлПутейToolStripMenuItem.Click
        Process.Start(sTXTPath)
    End Sub

    Private Sub ПерезагрузитьПутиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПерезагрузитьПутиToolStripMenuItem.Click
        lbx_Data.Items.Clear()
        lbx_Data.Items.AddRange(File.ReadAllLines(sTXTPath, System.Text.Encoding.UTF8))
    End Sub

    Private Sub ОткрытьВыделенныеПапкиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОткрытьВыделенныеПапкиToolStripMenuItem.Click
        Dim w1, w2 ', w3
        If lbx_Data.SelectedIndex = -1 Then MessageBox.Show("Необходимо выделить строку", "Ошибка") : Exit Sub
        w1 = Split(lbx_Data.SelectedItem, " = ")(0)
        w2 = Split(lbx_Data.SelectedItem, " = ")(1)
        If Not Directory.Exists(Split(lbx_Data.SelectedItem, " = ")(0)) Then MessageBox.Show("Folder " & Mid(Split(lbx_Data.SelectedItem, " = ")(0), InStrRev(Split(lbx_Data.SelectedItem, " = ")(0), "\")) & " is not exists") : Exit Sub
        If Not Directory.Exists(Split(lbx_Data.SelectedItem, " = ")(1)) Then MessageBox.Show("Folder " & Mid(Split(lbx_Data.SelectedItem, " = ")(1), InStrRev(Split(lbx_Data.SelectedItem, " = ")(1), "\")) & " is not exists") : Exit Sub
        Process.Start(Split(lbx_Data.SelectedItem, " = ")(0))
        Process.Start(Split(lbx_Data.SelectedItem, " = ")(1))
    End Sub
#End Region

#Region "Логирование"
    Private Sub ОткрытьЛогВыделенногоToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОткрытьЛогВыделенногоToolStripMenuItem.Click
        'Открыть лог выделенного
        If lbx_Data.SelectedIndex = -1 Then MessageBox.Show("Необходимо выделить строку", "Ошибка") : Loger.LogProg("Обновить выделенное: ОШИБКА - ничего не выделено") : Exit Sub
        If sTXTPath = "" Then
            If File.Exists(Split(lbx_Data.Items(lbx_Data.SelectedIndex), " = ")(1) & "\Logs.log") Then
                Process.Start(Split(lbx_Data.Items(lbx_Data.SelectedIndex), " = ")(1) & "\Logs.log")
            Else
                MessageBox.Show("Лог не существует")
            End If
        Else
            Process.Start(sTXTPath)
        End If
    End Sub

    Private Sub ОткрытьЛогПрограммыToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОткрытьЛогПрограммыToolStripMenuItem.Click 'Открыть лог программы
        Process.Start(My.Settings.LogFilePath)
    End Sub

    'Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click 'Очистить лог программы
    '    Loger.Clear()
    'End Sub

    Private Sub УдалитьЛогПрограммыToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles УдалитьЛогПрограммыToolStripMenuItem.Click
        Loger.Del()
    End Sub

    Private Sub УстановитьСтандартныйToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles УстановитьСтандартныйToolStripMenuItem.Click
        My.Settings.LogFilePath = Application.StartupPath() & "\LogProg.txt"
    End Sub

    Private Sub ВвестиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВвестиToolStripMenuItem.Click
        Dim sTxt As String = InputBox("Введите полное имя файла (с расширением)")
        If Not sTxt = "" AndAlso File.Exists(sTxt) Then My.Settings.LogFilePath = sTxt
    End Sub
#End Region

#Region "Дополнительные функции и методы"
#End Region

#Region "updateOne"

    Private Sub updateOne()
        'Dim w1, w2, w3, w4
        Dim mMassNEW() As String, mMassDEL() As String, mMassUPD() As String, sVrem As String ', bEx As Boolean, mMassOLD() As String
        Dim mMassIst = Directory.GetDirectories(sFoldIst, "*", SearchOption.AllDirectories).Concat(Directory.GetFiles(sFoldIst, "*", SearchOption.AllDirectories)).ToArray() ' 1=AllDirectories, 0=TopDirectoryOnly
        If Not Directory.Exists(sFoldPol) Then Directory.CreateDirectory(sFoldPol)
        Dim mMassPol = Directory.GetFileSystemEntries(sFoldPol)
        'mMassIst => mMassPol
        For Each itemMI As String In mMassIst
            sVrem = Replace(itemMI, sFoldIst, sFoldPol)
            If File.Exists(sVrem) Then
                'проверка даты изменения
                'w3 = File.GetLastWriteTime(itemMI)
                'w4 = File.GetLastWriteTime(sVrem)
                If File.GetLastWriteTime(itemMI) <> File.GetLastWriteTime(sVrem) Then
                    If mMassUPD Is Nothing Then ReDim mMassUPD(0) Else ReDim Preserve mMassUPD(UBound(mMassUPD) + 1)
                    mMassUPD(UBound(mMassUPD)) = sVrem
                End If
            Else
                If Not Directory.Exists(sVrem) Then
                    If mMassNEW Is Nothing Then ReDim mMassNEW(0) Else ReDim Preserve mMassNEW(UBound(mMassNEW) + 1)
                    mMassNEW(UBound(mMassNEW)) = itemMI
                End If
            End If
        Next

        'mMassPol => mMassIst
        For Each itemMP In mMassPol
            sVrem = Replace(itemMP, sFoldPol, sFoldIst)
            'w1 = File.Exists(sVrem)
            'w2 = Directory.Exists(sVrem)
            'w3 = Not Directory.Exists(sVrem) And Not File.Exists(sVrem)
            'w4 = Directory.Exists(sVrem) Or File.Exists(sVrem)
            If Not Directory.Exists(sVrem) And Not File.Exists(sVrem) Then
                If mMassDEL Is Nothing Then ReDim mMassDEL(0) Else ReDim Preserve mMassDEL(UBound(mMassDEL) + 1)
                mMassDEL(UBound(mMassDEL)) = itemMP
            End If
        Next

        'Dim w1 = ЧтениеТХТВМассив("C:\mMassUPD.txt")
        'ВыводМассиваТХТ(mMassIst, "mMassIst")
        If Not mMassNEW Is Nothing Then Копирование(mMassNEW, "НАЧАТА ЗАПИСЬ НОВЫХ", "НОВЫЙ:    ") : ВыводМассиваТХТ(mMassNEW, "mMassNEW")
        'If Not mMassNEW Is Nothing Then ЗаписьНовых(mMassNEW, "mMassNEW")
        If Not mMassUPD Is Nothing Then Обновление(mMassUPD, "НАЧАТА ЗАПИСЬ ОБНОВЛЕННЫХ", "ОБНОВЛЕН: ") : ВыводМассиваТХТ(mMassUPD, "mMassUPD")
        If Not mMassDEL Is Nothing Then Удаление(mMassDEL, "НАЧАТА ЗАПИСЬ УДАЛЕННЫХ", "УДАЛЕН:   ") : ВыводМассиваТХТ(mMassDEL, "mMassDEL")
    End Sub

    Private Sub Удаление(mMass() As String, sTextBegin As String, sTextLog As String)
        'sFoldIst As String, sFoldPol As String
        'Stop
        Dim sPath As String, sArch As String
        Dim sPathArch As String = "D:\АрхивСети\Архивированное\"
        Loger.LogProg(sTextBegin & " " & Now)
        Loger.Log("=== " & sTextBegin & " ===")
        For Each sMas In mMass
            'Stop
            'MsgBox(Path.GetFileName(sMas), , "GetFileName")
            If Not Path.GetFileName(sMas) = "Log.log" Then
                'sPath = Replace(sMas, sFoldPol, sFoldIst)
                sArch = sPathArch & Path.GetFileNameWithoutExtension(sMas) & "  DEL=" & Format(Now, "yyyy-MM-dd") & Path.GetExtension(sMas)
                If File.Exists(sArch) Then sArch = sPathArch & Path.GetFileNameWithoutExtension(sMas) & "  DEL=" & Format(Now, "yyyy-MM-dd_hhmmss") & Path.GetExtension(sMas)
                'Копирование устаревшего файла
                Try
                    File.Copy(sMas, sArch, True)
                Catch
                    Loger.Log("Ошибка архивирования: " & sMas)
                End Try
                Try
                    File.Delete(sMas) '.Copy(sPath, sMas, True)
                    Loger.Log(sTextLog & sMas)
                Catch
                    Loger.Log("Ошибка удаления: " & sPath)
                End Try
            End If
        Next
    End Sub

    Private Sub Обновление(mMass() As String, sTextBegin As String, sTextLog As String)
        'sFoldIst As String, sFoldPol As String
        Dim sPath As String, sArch As String
        Dim sPathArch As String = "D:\АрхивСети\Архивированное\"
        Loger.LogProg(sTextBegin & " " & Now)
        Loger.Log("=== " & sTextBegin & " ===")
        For Each sMas In mMass
            'Stop
            sPath = Replace(sMas, sFoldPol, sFoldIst)
            sArch = sPathArch & Path.GetFileNameWithoutExtension(sMas) & "  UPD=" & Format(Now, "yyyy-MM-dd") & Path.GetExtension(sMas)
            If File.Exists(sArch) Then sArch = sPathArch & Path.GetFileNameWithoutExtension(sMas) & "  UPD=" & Format(Now, "yyyy-MM-dd_hhmmss") & Path.GetExtension(sMas)
            'Копирование устаревшего файла
            Try
                File.Copy(sMas, sArch, True)
            Catch
                Loger.Log("Ошибка архивирования: " & sMas)
            End Try
            Try
                File.Copy(sPath, sMas, True)
                Loger.Log(sTextLog & sPath)
            Catch
                Loger.Log("Ошибка обновления: " & sPath)
            End Try
        Next
    End Sub

    Private Sub Копирование(mMass() As String, sTextBegin As String, sTextLog As String)
        'sFoldIst As String, sFoldPol As String
        On Error Resume Next
        Dim sPath As String
        Loger.LogProg(sTextBegin & " " & Now)
        Loger.Log("=== " & sTextBegin & " ===")
        For Each sMas In mMass
            'Stop
            sPath = Replace(sMas, sFoldIst, sFoldPol)
            If File.Exists(sMas) Then
                File.Copy(sMas, sPath)
            Else
                If Not Directory.Exists(sPath) Then Directory.CreateDirectory(sPath)
            End If
            If Err.Number > 0 Then
                Loger.Log("Ошибка копирования: " & sPath)
            Else
                Loger.Log(sTextLog & sPath)
                'Запись норм
            End If
            Err.Clear()
        Next
    End Sub

    Private Sub ЗаписьУдаленных(mMass, sName)
        'ТОДО доработать запись удаленных
        ВыводМассиваТХТ(mMass, sName)
        'копировать файл с переименованием в "Архивированное"
        'удалить на старом месте
        'проверить папку на пустоту
        'если пустая, то проверить наличие пустой папки в исходнике. при необходимости - удалить
    End Sub

    'Private Sub ЗаписьНовых(mMass, sName)
    '    ВыводМассиваТХТ(mMass, sName)
    '    Копирование(mMass, "НАЧАТА ЗАПИСЬ НОВЫХ", "НОВЫЙ:    ")
    'End Sub

    'Private Sub Обновление(mMass() As String)
    '    'ТОДО ПРОДОЛЖЕНИЕ-ПРОДОЛЖЕНИЕ-ПРОДОЛЖЕНИЕ
    'End Sub

    Private Sub ВыводМассиваТХТ(mMass, sName)
        File.WriteAllLines("C:\" & sName & ".txt", mMass, System.Text.Encoding.UTF8)
    End Sub

    Private Function ЧтениеТХТВМассив(sPath As String)
        If File.Exists(sPath) Then ЧтениеТХТВМассив = File.ReadAllLines(sPath, System.Text.Encoding.UTF8) Else ЧтениеТХТВМассив = ""
    End Function

#End Region
    ' информация http://www.cyberforum.ru/post1942265.html
End Class
