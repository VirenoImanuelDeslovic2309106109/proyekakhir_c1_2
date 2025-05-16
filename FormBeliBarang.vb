Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class FormBeliBarang
    Dim hargaBarang As Decimal

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fontJudul As New Font("Arial", 14, FontStyle.Bold)
        Dim fontIsi As New Font("Arial", 10)
        Dim yPos As Integer = 100

        Dim jumlah As Integer = CInt(nudJumlah.Value)
        Dim harga As Decimal = 0
        Dim total As Decimal = 0

        ' Ambil harga dari database (opsional untuk tampilan cetak)
        BukaKoneksi()
        Dim CMDHarga As New MySqlCommand("SELECT harga_barang FROM tabel_barang WHERE id_barang = @id", CONN)
        CMDHarga.Parameters.AddWithValue("@id", cmbBarang.SelectedValue)
        Dim reader = CMDHarga.ExecuteReader()
        If reader.Read() Then
            harga = reader("harga_barang")
        End If
        reader.Close()
        CONN.Close()

        total = jumlah * harga

        e.Graphics.DrawString("Struk Pembelian", fontJudul, Brushes.Black, 100, yPos)
        yPos += 40

        e.Graphics.DrawString("Nama Barang: " & cmbBarang.Text, fontIsi, Brushes.Black, 100, yPos)
        yPos += 20

        e.Graphics.DrawString("Jumlah: " & jumlah.ToString(), fontIsi, Brushes.Black, 100, yPos)
        yPos += 20

        e.Graphics.DrawString("Harga Satuan: Rp " & harga.ToString("N2"), fontIsi, Brushes.Black, 100, yPos)
        yPos += 20

        e.Graphics.DrawString("Total Harga: Rp " & total.ToString("N2"), fontIsi, Brushes.Black, 100, yPos)
        yPos += 20

        e.Graphics.DrawString("Tanggal: " & Date.Now.ToString("dd/MM/yyyy HH:mm"), fontIsi, Brushes.Black, 100, yPos)
    End Sub



    Private Sub FormBeliBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tampilkan daftar nama barang di ComboBox
        BukaKoneksi()
        Dim CMD As New MySqlCommand("SELECT id_barang, nama_barang FROM tabel_barang", CONN)
        Dim DA As New MySqlDataAdapter(CMD)
        Dim DT As New DataTable
        DA.Fill(DT)

        cmbBarang.DataSource = DT
        cmbBarang.DisplayMember = "nama_barang"
        cmbBarang.ValueMember = "id_barang"
        cmbBarang.SelectedIndex = -1

        CONN.Close()
    End Sub

    Private Sub cmbBarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBarang.SelectedIndexChanged
        cmbBarang.DropDownStyle = ComboBoxStyle.DropDownList ' eror handling agar tidak dapat input
        If cmbBarang.SelectedIndex >= 0 Then
            ' Ambil harga dari database berdasarkan ID barang
            BukaKoneksi()
            Dim CMD As New MySqlCommand("SELECT harga_barang FROM tabel_barang WHERE id_barang=@id", CONN)
            CMD.Parameters.AddWithValue("@id", cmbBarang.SelectedValue)
            Dim RD As MySqlDataReader = CMD.ExecuteReader()
            If RD.Read() Then
                hargaBarang = RD("harga_barang")
            End If
            CONN.Close()
            HitungTotal()
        End If
    End Sub

    Private Sub nudJumlah_ValueChanged(sender As Object, e As EventArgs) Handles nudJumlah.ValueChanged
        HitungTotal()
    End Sub

    Private Sub HitungTotal()
        Dim jumlah As Integer = nudJumlah.Value
        Dim total As Decimal = hargaBarang * jumlah
        If jumlah >= 10 Then
            total *= 0.9 ' Diskon 10%
        End If
        lblTotal.Text = $"Total Harga: Rp{total:N0}"
    End Sub

    Private Sub btnBeli_Click(sender As Object, e As EventArgs) Handles btnBeli.Click
        Try
            ' Ambil nilai jumlah dari input (misalnya NumericUpDown)
            Dim jumlah As Integer = CInt(nudJumlah.Value) ' Ganti dengan kontrolmu
            Dim harga As Decimal = 0
            Dim total As Decimal = 0

            ' Ambil harga_barang dari database
            BukaKoneksi()
            Dim CMDHarga As New MySqlCommand("SELECT harga_barang FROM tabel_barang WHERE id_barang = @id", CONN)
            CMDHarga.Parameters.AddWithValue("@id", cmbBarang.SelectedValue)
            Dim reader = CMDHarga.ExecuteReader()
            If reader.Read() Then
                harga = reader("harga_barang")
            End If
            reader.Close()

            ' Hitung total
            total = jumlah * harga

            ' Simpan transaksi
            Dim CMD As New MySqlCommand("INSERT INTO tabel_penjualan (id_barang, jumlah, total) VALUES (@id, @jumlah, @total)", CONN)
            CMD.Parameters.AddWithValue("@id", cmbBarang.SelectedValue)
            CMD.Parameters.AddWithValue("@jumlah", jumlah)
            CMD.Parameters.AddWithValue("@total", total)
            CMD.ExecuteNonQuery()

            ' Kurangi stok barang
            Dim CMD2 As New MySqlCommand("UPDATE tabel_barang SET stok = stok - @jumlah WHERE id_barang = @id", CONN)
            CMD2.Parameters.AddWithValue("@jumlah", jumlah)
            CMD2.Parameters.AddWithValue("@id", cmbBarang.SelectedValue)
            CMD2.ExecuteNonQuery()

            CONN.Close()

            If cmbBarang.SelectedIndex = -1 Then
                Try
                    My.Computer.Audio.Play("gagal.wav", AudioPlayMode.Background)
                    MessageBox.Show("Silakan pilih barang terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Catch ex As Exception
                    MsgBox("Gagal Memutar suara")
                End Try
                Exit Sub
            End If

            If nudJumlah.Value = 0 Then
                Try
                    My.Computer.Audio.Play("gagal.wav", AudioPlayMode.Background)
                    MessageBox.Show("Jumlah pembelian tidak boleh 0.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Catch ex As Exception
                    MsgBox("Gagal Memutar suara")
                End Try
                Exit Sub
            End If

            Try
                My.Computer.Audio.Play("berhasil.wav", AudioPlayMode.Background)
                MessageBox.Show("Pembelian berhasil!")
            Catch ex As Exception
                MsgBox("Gagal Memutar suara")
            End Try

            ' Cetak dengan print preview
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan")
        End Try
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        FormUtamaPelanggan.Show()
        Me.Close()
    End Sub
End Class
