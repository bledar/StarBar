Public Class ShtoPerdorues
    Dim db As New DataBase
    Private Sub RuajPerdorues_b_Click(sender As Object, e As EventArgs) Handles RuajPerdorues_b.Click

        If db.SQLDS IsNot Nothing Then
            db.SQLDS.Clear()
        End If

        Dim adm As Integer = 2
        If (Admin_cb.Checked) Then
            adm = 1
        End If

        Dim query As String = "SELECT Emri FROM Perdorues WHERE Emri= '" & RuajEmrin_t.Text & "'"

        db.ExeQuer(query)

        If (db.Numruesi = 1) Then
            MsgBox("KY PERDORUES EKZISTON NUK MUND TE SHTOHET SERISHT !", MsgBoxStyle.Information)
        ElseIf (RuajEmrin_t.Text.Length < 3 And RuajKodin_t.Text.Length < 6) Then
            MsgBox("GABIM NE SHTIMIN E PERDORUESIT! Fjalkalimi ose Emri shume i shkurter !", MsgBoxStyle.Information)

        Else
            shtoUser(RuajEmrin_t.Text, RuajKodin_t.Text, adm.ToString)
        End If


    End Sub

    Sub shtoUser(Emri As String, Kodi As String, Niveli As Integer)


        Dim query As String = "INSERT INTO Perdorues (Emri , Kodi , Niveli)" & _
                              "VALUES( '" & Emri & "', '" & Kodi & "', '" & Niveli & "' )"
        db.ExeQuer(query)

            MsgBox("NJE PERDORUES I RI U SHTUA ME SUKSES !", MsgBoxStyle.Information)
            Me.Close()
    End Sub


End Class