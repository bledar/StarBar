Public Class ShtoPerdorues

    Private Sub RuajPerdorues_b_Click(sender As Object, e As EventArgs) Handles RuajPerdorues_b.Click
        If (RuajEmrin_t.Text.Length < 3) Then
            MsgBox("Emri i perdoruesit shume i shkurter!", MsgBoxStyle.Information)

        ElseIf (RuajKodin_t.Text.Length < 6) Then
            MsgBox("Fjalekalimi  shume i shkurter!", MsgBoxStyle.Information)
        Else
            Dim adm As Integer = 0
            If (Admin_cb.Checked) Then
                adm = 1
            End If

            'MsgBox("Emri: " + RuajEmrin_t.Text + "  kodi: " + RuajKodin_t.Text + "Admin: " + adm.ToString, MsgBoxStyle.Information)
            Dim db = New DataBase
            db.shtoUser(RuajEmrin_t.Text, RuajKodin_t.Text, adm.ToString)
        End If


    End Sub
End Class