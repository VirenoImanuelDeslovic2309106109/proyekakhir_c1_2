Imports MySql.Data.MySqlClient

Module ModuleLaporan
    ' Fungsi untuk mendapatkan laporan penjualan
    Public Function AmbilLaporanPenjualan() As DataTable
        Dim dt As New DataTable()
        Try
            ' Membuka koneksi ke database
            BukaKoneksi()

            ' Query untuk mengambil data penjualan
            Dim SQL As String = "SELECT nama_barang, SUM(jumlah) AS total_terjual, SUM(total) AS total_pendapatan " &
                                "FROM tabel_penjualan " &
                                "JOIN tabel_barang ON tabel_penjualan.id_barang = tabel_barang.id_barang " &
                                "GROUP BY nama_barang " &
                                "ORDER BY total_terjual DESC"

            ' Menjalankan query
            Dim CMD As New MySqlCommand(SQL, CONN)
            Dim reader As MySqlDataReader = CMD.ExecuteReader()

            ' Memuat data ke DataTable
            dt.Load(reader)
            CONN.Close()

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan dalam mengambil laporan: " & ex.Message)
        End Try
        Return dt
    End Function
End Module
