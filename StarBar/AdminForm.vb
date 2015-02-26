Public Class AdminForm

    Dim db As New DataBase

    Private Sub ShtoUser_b_Click(sender As Object, e As EventArgs) Handles ShtoUser_b.Click

        ShtoPerdorues.Show()

    End Sub

    Private Sub AdminForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        login.Show()
    End Sub
End Class