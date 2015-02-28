Public Class NdryshoProduktin

    Private Sub NdryshoProduktin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StarBarDataSet1.Produkte' table. You can move, or remove it, as needed.
        Me.ProdukteTableAdapter.Fill(Me.StarBarDataSet1.Produkte)

    End Sub

    Private Sub RuajProduktin_b_Click(sender As Object, e As EventArgs) Handles RuajProduktin_b.Click
        Me.ProdukteTableAdapter.Update(Me.StarBarDataSet1.Produkte)
        MsgBox("Produkti u ruajt!", MsgBoxStyle.Information)
        Me.Close()
    End Sub
End Class