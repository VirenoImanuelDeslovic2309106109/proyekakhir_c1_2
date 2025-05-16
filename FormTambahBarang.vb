Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class FormTambahBarang
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim namabarang As String = txtNama.Text.Trim()
        Dim jenisbarang As String = txtJenis.Text.Trim()
        Dim merekbarang As String = txtMerek.Text.Trim()
        ' erro handling
        If Not Regex.IsMatch(namabarang, "^[a-zA-Z0-9 ]+$") Then
            Try
                My.Computer.Audio.Play("gagal.wav", AudioPlayMode.Background)
                MessageBox.Show("Nama barang hanya boleh berisi huruf, angka, dan spasi.", "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Catch ex As Exception
                MsgBox("Gagal Memutar suara")
            End Try
            Exit Sub
        End If

        If Not Regex.IsMatch(jenisbarang, "^[a-zA-Z0-9 ]+$") Then
            Try
                My.Computer.Audio.Play("gagal.wav", AudioPlayMode.Background)
                MessageBox.Show("Jenis barang hanya boleh berisi huruf, angka, dan spasi.", "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Catch ex As Exception
                MsgBox("Gagal Memutar suara")
            End Try
            Exit Sub
        End If
        If Not Regex.IsMatch(merekbarang, "^[a-zA-Z0-9 ]+$") Then
            Try
                My.Computer.Audio.Play("gagal.wav", AudioPlayMode.Background)
                MessageBox.Show("Merek barang hanya boleh berisi huruf, angka, dan spasi.", "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Catch ex As Exception
                MsgBox("Gagal Memutar suara")
            End Try
            Exit Sub
        End If
        If cmbKategori.SelectedIndex = -1 Then
            Try
                My.Computer.Audio.Play("gagal.wav", AudioPlayMode.Background)
                MessageBox.Show("Silakan pilih kategori barang terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Catch ex As Exception
                MsgBox("Gagal Memutar suara")
            End Try
            Exit Sub
        End If
        ' tidak boleh 0
        If nudHarga.Value <= 0 Then
            Try
                My.Computer.Audio.Play("gagal.wav", AudioPlayMode.Background)
                MessageBox.Show("Harga tidak boleh 0 atau kurang.", "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Catch ex As Exception
                MsgBox("Gagal Memutar suara")
            End Try
            Exit Sub
        End If
        If nudStok.Value <= 0 Then
            Try
                My.Computer.Audio.Play("gagal.wav", AudioPlayMode.Background)
                MessageBox.Show("Stok tidak boleh 0 atau kurang.", "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Catch ex As Exception
                MsgBox("Gagal Memutar suara")
            End Try
            Exit Sub
        End If
        If nudStokMin.Value <= 0 Then
            Try
                My.Computer.Audio.Play("gagal.wav", AudioPlayMode.Background)
                MessageBox.Show("Stok minimum tidak boleh 0 atau kurang.", "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Catch ex As Exception
                MsgBox("Gagal Memutar suara")
            End Try
            Exit Sub
        End If

        BukaKoneksi()
        Dim SQL As String = "INSERT INTO tabel_barang (nama_barang, harga_barang, stok, stok_minimum, jenis_material, merek, kategori) " &
"VALUES (@nama, @harga, @stok, @stokMin, @jenis, @merek, @kategori)"
        Dim CMD As New MySqlCommand(SQL, CONN)

        CMD.Parameters.AddWithValue("@nama", txtNama.Text)
        CMD.Parameters.AddWithValue("@harga", nudHarga.Value)
        CMD.Parameters.AddWithValue("@stok", nudStok.Value)
        CMD.Parameters.AddWithValue("@stokMin", nudStokMin.Value)
        CMD.Parameters.AddWithValue("@jenis", txtJenis.Text)
        CMD.Parameters.AddWithValue("@merek", txtMerek.Text)
        CMD.Parameters.AddWithValue("@kategori", cmbKategori.Text)

        CMD.ExecuteNonQuery()
        MessageBox.Show("Barang berhasil disimpan!")
        CONN.Close()
    End Sub

    Private Sub brnKeluar_Click(sender As Object, e As EventArgs) Handles brnKeluar.Click
        FormUtamaPemilik.Show()
        Me.Close()
    End Sub

    Private Sub FormTambahBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
End Class
