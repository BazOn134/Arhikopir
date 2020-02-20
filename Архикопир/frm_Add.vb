Public Class frm_Add

    Private Sub frm_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbx_Ist.Text = "" : tbx_Pol.Text = ""
        If Globall.sOtv = "" Then Exit Sub
        tbx_Ist.Text = Split(Globall.sOtv, " = ")(0)
        tbx_Pol.Text = Split(Globall.sOtv, " = ")(1)
    End Sub

    Private Sub btn_Zapis_Click(sender As Object, e As EventArgs) Handles btn_Zapis.Click
        If tbx_Ist.Text = "" Or tbx_Pol.Text = "" Then MessageBox.Show("Данные введены не полностью!" & vbNewLine & "Введите все данные") : Exit Sub
        Globalls.sOtv = Replace(tbx_Ist.Text & " = " & tbx_Pol.Text, Chr(34), "")
        Globalls.bOtv = True
        Me.Close()
    End Sub

    Private Sub btn_AddFoldIst_Click(sender As Object, e As EventArgs) Handles btn_AddFoldIst.Click
        Dim FBD As New FolderBrowserDialog
        If FBD.ShowDialog() = DialogResult.OK Then tbx_Ist.Text = Replace(FBD.SelectedPath, Chr(34), "")
    End Sub

    Private Sub btn_AddFoldPol_Click(sender As Object, e As EventArgs) Handles btn_AddFoldPol.Click
        Dim FBD As New FolderBrowserDialog
        If FBD.ShowDialog() = DialogResult.OK Then tbx_Pol.Text = Replace(FBD.SelectedPath, Chr(34), "")
    End Sub

    Private Sub tbx_Ist_TextChanged(sender As Object, e As EventArgs) Handles tbx_Ist.TextChanged
        If sender.text <> "" Then sender.text = Replace(sender.text, """", "")
    End Sub

    Private Sub tbx_Pol_TextChanged(sender As Object, e As EventArgs) Handles tbx_Pol.TextChanged
        tbx_Pol.Text = Replace(tbx_Pol.Text, Chr(34), "")
    End Sub
End Class