Imports MySql.Data.MySqlClient

Module ModuleKoneksi
    ' Variabel global untuk koneksi
    Public CONN As MySqlConnection

    ' Fungsi untuk membuka koneksi
    Public Sub BukaKoneksi()
        Try
            If CONN Is Nothing Then
                CONN = New MySqlConnection("server=localhost;uid=root;pwd=;database=renobuilding")
            End If

            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Koneksi ke database gagal: " & ex.Message)
        End Try
    End Sub

    ' Fungsi untuk menutup koneksi
    Public Sub TutupKoneksi()
        If CONN IsNot Nothing Then
            If CONN.State = ConnectionState.Open Then
                CONN.Close()
            End If
        End If
    End Sub
End Module
