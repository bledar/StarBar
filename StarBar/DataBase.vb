Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class DataBase

    Private sConnectionString As String _
    = "Data Source=BLEDI-PC;Initial Catalog=StarBar;User ID=AdminStarBar;Password=StarBar123"
    Private objConn As New SqlConnection(sConnectionString)
    Public SQLDA As SqlDataAdapter
    Public SQLDS As DataSet
    Private SQLCmd As SqlCommand
    Private niv_perdorusit As Integer = 0

    Public Numruesi As Integer

    Sub hapLidhjen()
        Try
            objConn.Open()
        Catch ex As Exception
            MsgBox("Gabim ne hapjen e lidhjes me Databazen!" + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub ExeQuer(query As String)
        Try
            objConn.Open()

            SQLCmd = New SqlCommand(query, objConn)

            SQLDA = New SqlDataAdapter(SQLCmd)
            SQLDS = New DataSet
            Numruesi = SQLDA.Fill(SQLDS)
            objConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

            If objConn.State = ConnectionState.Open Then
                objConn.Close()
            End If


        End Try

    End Sub

    Function banLogin(emri, kodi)
        Dim qyery As New SqlCommand
        qyery.CommandText = "SELECT * FROM Perdorues WHERE Emri like '" + emri + "' AND Kodi like '" + kodi + "' COLLATE SQL_Latin1_General_CP1_CS_AS ;"
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

    Function KaLidhje() As Boolean
        Try
            objConn.Open()
            objConn.Close()
            Return True
        Catch ex As Exception
            MsgBox("Gabim ne DataBase: " + ex.Message)
            Return False
        End Try
    End Function


End Class
