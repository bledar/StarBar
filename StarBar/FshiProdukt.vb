Public Class FshiProdukt
    Dim db = New DataBase
    Private Sub FshiProdukt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MerrProduktin()
    End Sub


    Private Sub MerrProduktin()

        If db.SQLDS IsNot Nothing Then
            db.SQLDS.Clear()
        End If

        Dim query As String = "SELECT EmriP " & _
                                "FROM Produkte "
        db.ExeQuer(query)

        FshiProduktin_cb.Items.Clear()

        If (db.Numruesi > 0) Then

            For Each r As DataRow In db.SQLDS.Tables(0).Rows
                FshiProduktin_cb.Items.Add(r("EmriP"))
            Next
        Else
            MsgBox("Ska asnje Produkt! " & vbCrLf & "Ju lutem Shtoni nje Produkt te ri!")
        End If

    End Sub

    Private Sub FshijProduktin(EmriP As String)
        Dim query As String = "DELETE  FROM Produkte WHERE EmriP= '" & EmriP & "'"
        db.ExeQuer(query)
        MsgBox(" Produkti '" & EmriP & "' u fshi nga databaza", MsgBoxStyle.Information)
        Me.Close()
    End Sub

    Private Sub FshijP_b_Click(sender As Object, e As EventArgs) Handles FshijP_b.Click
        Dim EmriFshire As String = FshiProduktin_cb.SelectedItem.ToString
        FshijProduktin(EmriFshire)
        MerrProduktin()
    End Sub

End Class