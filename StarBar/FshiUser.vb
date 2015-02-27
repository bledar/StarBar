Public Class FshiUser

    Dim db = New DataBase

    Private Sub FshiUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MerrPerdorusit()

    End Sub


    Private Sub MerrPerdorusit()

        If db.SQLDS IsNot Nothing Then
            db.SQLDS.Clear()
        End If

        Dim query As String = "SELECT Emri " & _
                                "FROM Perdorues "
        db.ExeQuer(query)

        FshiPerdoruesin_cb.Items.Clear()

        If (db.Numruesi > 0) Then

            For Each r As DataRow In db.SQLDS.Tables(0).Rows
                FshiPerdoruesin_cb.Items.Add(r("Emri"))
            Next
        Else
            MsgBox("Ska asnje perdorues! " & vbCrLf & "Ju lutem Shtoni nje perdorues te ri!")
        End If

    End Sub

    Private Sub FshijPerdorus(Emri As String)
        Dim query As String = "DELETE  FROM Perdorues WHERE Emri= '" & Emri & "'"
        db.ExeQuer(query)
        MsgBox(" Perdoruesi '" & Emri & "' u fshi nga databaza", MsgBoxStyle.Information)
        Me.Close()
    End Sub


    
    Private Sub FshiPerdorues_b_Click(sender As Object, e As EventArgs) Handles FshiPerdorues_b.Click
        Dim EmriFshire As String = FshiPerdoruesin_cb.SelectedItem.ToString
        FshijPerdorus(EmriFshire)
        MerrPerdorusit()
    End Sub
End Class