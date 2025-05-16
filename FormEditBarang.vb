Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class FormEditBarang
    Public id_barang As Integer

    Private Sub FormEditBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ambil data barang dari database
        BukaKoneksi()
        Dim CMD As New MySqlCommand("SELECT * FROM tabel_barang WHERE id_barang = @id", CONN)
        CMD.Parameters.AddWithValue("@id", id_barang)
        Dim RD As MySqlDataReader = CMD.ExecuteReader()
        If RD.Read() Then
            txtNama.Text = RD("nama_barang")
            nudHarga.Value = RD("harga_barang")
            nudStok.Value = RD("stok")
            nudStokMin.Value = RD("stok_minimum")
            txtJenis.Text = RD("jenis_material")
            txtMerek.Text = RD("merek")
            cmbKategori.Text = RD("kategori")
        End If
        CONN.Close()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' Validasi input sebelum simpan
        If String.IsNullOrWhiteSpace(txtNama.Text) OrElse
           String.IsNullOrWhiteSpace(txtJenis.Text) OrElse
           String.IsNullOrWhiteSpace(txtMerek.Text) OrElse
           String.IsNullOrWhiteSpace(cmbKategori.Text) OrElse
           nudHarga.Value <= 0 OrElse
           nudStok.Value < 0 OrElse
           nudStokMin.Value < 0 Then
            Try
                My.Computer.Audio.Play("gagal.wav", AudioPlayMode.Background)
                MessageBox.Show("Tidak boleh ada yang kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Catch ex As Exception
                MsgBox("Gagal Memutar suara")
            End Try
            Exit Sub
        End If
        Dim nama As String = txtNama.Text.Trim()
        Dim jenis As String = txtJenis.Text.Trim()
        Dim merek As String = txtMerek.Text.Trim()
        Dim kategori As String = cmbKategori.Text.Trim()

        If Not System.Text.RegularExpressions.Regex.IsMatch(nama, "^[a-zA-Z0-9 ]+$") Then
            Try
                My.Computer.Audio.Play("gagal.wav", AudioPlayMode.Background)
                MessageBox.Show("Nama Barang hanya boleh huruf dan angka tanpa spasi atau simbol.", "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Catch ex As Exception
                MsgBox("Gagal Memutar suara")
            End Try
            Exit Sub
        End If

        If Not System.Text.RegularExpressions.Regex.IsMatch(jenis, "^[a-zA-Z0-9 ]+$") Then
            Try
                My.Computer.Audio.Play("gagal.wav", AudioPlayMode.Background)
                MessageBox.Show("Jenis Barang hanya boleh huruf dan angka tanpa spasi atau simbol.", "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Catch ex As Exception
                MsgBox("Gagal Memutar suara")
            End Try
            Exit Sub
        End If

        If Not System.Text.RegularExpressions.Regex.IsMatch(merek, "^[a-zA-Z0-9]+$") Then
            Try
                My.Computer.Audio.Play("gagal.wav", AudioPlayMode.Background)
                MessageBox.Show("Merek Barang hanya boleh huruf dan angka tanpa spasi atau simbol.", "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Catch ex As Exception
                MsgBox("Gagal Memutar suara")
            End Try
            Exit Sub
        End If

        If cmbKategori.SelectedIndex = -1 Then
            Try
                My.Computer.Audio.Play("gagal.wav", AudioPlayMode.Background)
                MessageBox.Show("Silakan pilih barang terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Catch ex As Exception
                MsgBox("Gagal Memutar suara")
            End Try
            Exit Sub
        End If

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
                MessageBox.Show("Stok tidak boleh 0 atau kurang.", "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Catch ex As Exception
                MsgBox("Gagal Memutar suara")
            End Try
            Exit Sub
        End If


        BukaKoneksi()
        Dim SQL As String = "UPDATE tabel_barang SET nama_barang=@nama, harga_barang=@harga, stok=@stok, stok_minimum=@stokMin, jenis_material=@jenis, merek=@merek, kategori=@kategori WHERE id_barang=@id"
        Dim CMD As New MySqlCommand(SQL, CONN)
        CMD.Parameters.AddWithValue("@nama", txtNama.Text)
        CMD.Parameters.AddWithValue("@harga", nudHarga.Value)
        CMD.Parameters.AddWithValue("@stok", nudStok.Value)
        CMD.Parameters.AddWithValue("@stokMin", nudStokMin.Value)
        CMD.Parameters.AddWithValue("@jenis", txtJenis.Text)
        CMD.Parameters.AddWithValue("@merek", txtMerek.Text)
        CMD.Parameters.AddWithValue("@kategori", cmbKategori.Text)
        CMD.Parameters.AddWithValue("@id", id_barang)
        CMD.ExecuteNonQuery()
        CONN.Close()
        MessageBox.Show("Data barang berhasil diperbarui!")
        Me.Close()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        FormLihatStok.Show()
        Me.Close()
    End Sub
End Class
