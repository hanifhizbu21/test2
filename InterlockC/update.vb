Imports MySql.Data.MySqlClient
Module update
    Public tutupB As String
    Public tutupC As String
    Sub updateB()
        Call koneksiX()
        Dim upttC As String
        Try
            upttC = "UPDATE live_data SET status_pintu= '0' WHERE Nama_pintu = '" & tutupB & "'"
            cmd = New MySqlCommand(upttC, CONN)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Update data gagal dilakukan")
        Finally
            CONN.Close()
        End Try
    End Sub

    Sub updateC()
        Call koneksiX()
        Dim upttC As String
        Try
            upttC = "UPDATE live_data SET status_pintu= '0' WHERE Nama_pintu = '" & tutupC & "'"
            cmd = New MySqlCommand(upttC, CONN)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Update data gagal dilakukan")
        Finally
            CONN.Close()
        End Try
    End Sub
End Module
