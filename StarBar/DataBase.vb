Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class DataBase

    Private sConnectionString As String _
    = "User ID=AdminStarBar;Password=StarBar123;Initial Catalog=StarBar;Data Source=BLEDI-PC;"
    Private objConn As New SqlConnection(sConnectionString)
    Public niv_perdorusit As Integer = 0
    Sub hapLidhjen()
        Try
            objConn.Open()
        Catch ex As Exception
            MsgBox("Gabim ne hapjen e lidhjes me Databazen!" + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Function banLogin(emri, kodi)
        Dim qyery As New SqlCommand
        qyery.CommandText = "SELECT * FROM Perdorues WHERE Emri like '" + emri + "' AND Kodi like '" + kodi + "';"
        qyery.Connection = objConn
        Dim lexues As SqlDataReader
        lexues = qyery.ExecuteReader
        If lexues.HasRows Then
            lexues.Read()
            niv_perdorusit = lexues.Item("Niveli")
            Return True
        Else
            Return False
        End If
        lexues.Close()
    End Function

    Sub mbyllLidhjen()
        Try
            If (ConnectionState.Open) Then
                objConn.Close()
            End If

        Catch ex As Exception
            MsgBox("Gabim ne mbylljen e lidhjes me Databazen!", MsgBoxStyle.Critical)
        End Try
    End Sub

    Sub shtoUser(Emri As String, Kodi As String, Niveli As Integer)
        Dim query As String = "INSERT INTO Perdorues (Emri , Kodi , Niveli)" & _
                              "VALUES( '" & Emri & "', '" & Kodi & "', '" & Niveli & "' )"

        Try
            Me.hapLidhjen()
            Dim Komanda = New SqlCommand(query, objConn)
            Komanda.ExecuteNonQuery()
            MsgBox("Nje perdorues i ri u shtua me sukses!", MsgBoxStyle.Information)
            Me.mbyllLidhjen()
        Catch ex As Exception
            MsgBox("gabim ne exekutim :" + ex.Message)
        End Try
    End Sub

End Class
