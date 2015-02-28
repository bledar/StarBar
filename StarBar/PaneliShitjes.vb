Public Class PaneliShitjes
    Dim db = New DataBase
    Dim TabErmri(100) As String
    Dim TabSasia(100) As Integer
    Dim TabCmimi(100) As String
    Dim nr As Integer = 1
    Dim totali As Integer = 0


    Private Sub PaneliShitjes_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        login.Show()
    End Sub

    Private Sub PaneliShitjes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StarBarDataSet2.Produkte' table. You can move, or remove it, as needed.
        Me.ProdukteTableAdapter.Fill(Me.StarBarDataSet2.Produkte)
        mbushTabelat()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If (ekziston(TabErmri(e.RowIndex)) > -1) Then
            Dim s As Integer = CInt(Sasia_l.Items.Item(ekziston(TabErmri(e.RowIndex))))
            s += 1
            Sasia_l.Items.Item(ekziston(TabErmri(e.RowIndex))) = s
            Totali_l.Items.Item(ekziston(TabErmri(e.RowIndex))) = TabCmimi(e.RowIndex) * s


        Else
            Numri_l.Items.Add(nr)
            Emri_l.Items.Add(TabErmri(e.RowIndex))
            Cmimi_l.Items.Add(TabCmimi(e.RowIndex))
            Totali_l.Items.Add(TabCmimi(e.RowIndex))
            Sasia_l.Items.Add(1)
            nr += 1

        End If

        

        For Each r As String In Totali_l.Items
            totali = totali + CInt(r)
        Next
        ShumaTotale.Text = totali.ToString

    End Sub





    Sub mbushTabelat()

        If db.SQLDS IsNot Nothing Then
            db.SQLDS.Clear()
        End If
        Dim i As Integer = 0
        Dim query As String = "SELECT EmriP , CmimiP " & _
                                "FROM Produkte "
        db.ExeQuer(query)

        If (db.Numruesi > 0) Then

            For Each r As DataRow In db.SQLDS.Tables(0).Rows
                TabErmri(i) = (r("EmriP"))
                TabCmimi(i) = (r("CmimiP"))
                i += 1
            Next
        Else
            MsgBox("Ska asnje perdorues! " & vbCrLf & "Ju lutem Shtoni nje perdorues te ri!")
        End If

    End Sub

    Function ekziston(EmriP As String)
        Dim i As Integer = -1

        For Each r As String In Emri_l.Items
            i += 1
            If (r = EmriP) Then
                Return i
            End If
        Next
        Return -1
    End Function



End Class