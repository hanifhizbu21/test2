Imports MySql.Data.MySqlClient
Module view
    Public DataB() As String = {"B13", "B14", "B15", "B16", "B17", "B18", "B19", "B20", "B21"}
    Public DataC() As String = {"C13", "C14", "C15", "C16", "C17", "C18", "C19", "C20", "C21"}
    Public Vb(9) As String
    Public Vc(9) As String
    Sub Viewb()
        For i = 0 To 8
            Dim b As String
            Try
                Call koneksiX()
                Dim lgn As String
                lgn = "SELECT * FROM live_data WHERE Nama_pintu='" & DataB(i) & "'"
                cmd = New MySqlCommand(lgn, CONN)
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    Do While dr.Read
                        b = dr.Item("Status_M")
                    Loop
                End If
            Catch ex As Exception

            Finally
                Vb(i) = b
                CONN.Close()
            End Try
        Next
        indgv1()
    End Sub

    Sub indgv1()
        For i = 0 To 8
            Form1.DataGridView1.Rows(0).Cells(i).Value = Vb(i)
        Next
    End Sub


    Sub ViewC()
        For i = 0 To 8
            Dim c As String
            Try
                Call koneksiX()
                Dim lgn As String
                lgn = "SELECT * FROM live_data WHERE Nama_pintu='" & DataC(i) & "'"
                cmd = New MySqlCommand(lgn, CONN)
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    Do While dr.Read
                        c = dr.Item("Status_M")
                    Loop
                End If
            Catch ex As Exception

            Finally
                Vc(i) = c
                CONN.Close()
            End Try
        Next
        indgv2()
    End Sub
    Sub indgv2()
        For i = 0 To 8
            Form1.DataGridView2.Rows(0).Cells(i).Value = Vc(i)
        Next
    End Sub
End Module
