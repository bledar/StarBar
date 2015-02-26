Public Class login

    Dim db As New DataBase

    Private Sub logohu_b_Click(sender As Object, e As EventArgs) Handles logohu_b.Click
        db.hapLidhjen()
        Dim Emri As String = perdorusi_t.Text.ToString
        Dim Kodi As String = fjalkalimi_t.Text.ToString

        If (db.banLogin(Emri, Kodi)) Then
            AdminForm.Show()
            Me.Hide()
            MsgBox(db.niv_perdorusit.ToString)
        Else
            MsgBox("Gabim ne logim!")

        End If

        db.mbyllLidhjen()

    End Sub


End Class
