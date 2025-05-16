Imports MySql.Data.MySqlClient

Public Class FormLihatStok
    Private Sub TampilStok()
        Try
            BukaKoneksi()
            Dim DA As New MySqlDataAdapter("SELECT * FROM tabel_barang", CONN)
            Dim DT As New DataTable
            DA.Fill(DT)
            DataGridView1.DataSource = DT
            CONN.Close()
        Catch ex As Exception
            MessageBox.Show("Error saat menampilkan stok: " & ex.Message)
            CONN.Close()
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        ' Validasi apakah ada baris yang dipilih
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih barang yang ingin dihapus.")
            Return
        End If

        ' Konfirmasi sebelum menghapus
        Dim namaBarang As String = DataGridView1.CurrentRow.Cells("nama_barang").Value.ToString()
        If MessageBox.Show($"Apakah Anda yakin ingin menghapus {namaBarang}?", "Konfirmasi Hapus",
                          MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Try
            ' Hapus barang berdasarkan ID yang dipilih
            Dim idBarang As Integer = DataGridView1.CurrentRow.Cells("id_barang").Value
            BukaKoneksi()

            Dim SQL As String = "DELETE FROM tabel_barang WHERE id_barang = @id"
            Dim CMD As New MySqlCommand(SQL, CONN)
            CMD.Parameters.AddWithValue("@id", idBarang)
            CMD.ExecuteNonQuery()

            MessageBox.Show("Barang berhasil dihapus!")
            CONN.Close()

            ' Refresh data setelah menghapus
            TampilStok()
        Catch ex As Exception
            MessageBox.Show("Error saat menghapus barang: " & ex.Message)
            CONN.Close()
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Try
                Dim idBarang As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("id_barang").Value)
                Dim editForm As New FormEditBarang()
                editForm.id_barang = idBarang
                editForm.ShowDialog()
                ' Refresh data setelah diedit
                TampilStok()
            Catch ex As Exception
                MessageBox.Show("Error saat membuka form edit: " & ex.Message)
            End Try
        Else
            Try
                My.Computer.Audio.Play("gagal.wav", AudioPlayMode.Background)
                MessageBox.Show("Pilih barang yang ingin diedit.")
            Catch ex As Exception
                MsgBox("Gagal Memutar suara")
            End Try
        End If
    End Sub

    Private Sub FormLihatStok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Panggil fungsi untuk menampilkan stok saat form dimuat
        TampilStok()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormUtamaPemilik.Show()
        Me.Close()
    End Sub
End Class