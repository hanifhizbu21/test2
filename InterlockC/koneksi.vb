Imports MySql.Data.MySqlClient
Module koneksi
    Public CONN As MySqlConnection
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public dt As DataTable
    Public cmd As MySqlCommand
    Public Str As String

    Sub koneksiX()
        Try
            Str = "Server=127.0.0.1;user=pintu;password=pintu321;database=control_pintu"
            CONN = New MySqlConnection(Str)
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
            MsgBox("koneksi error")
        End Try
    End Sub
End Module
