Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class FormRegis
    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim role As String = "pelanggan"

        ' erro handling
        If Not System.Text.RegularExpressions.Regex.IsMatch(username, "^[a-zA-Z0-9]+$") Then
            Try
                My.Computer.Audio.Play("gagal.wav", AudioPlayMode.Background)
                MessageBox.Show("Username hanya boleh huruf dan angka tanpa spasi atau simbol.", "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Catch ex As Exception
                MsgBox("Gagal Memutar suara")
            End Try
            Exit Sub
        End If


        ' Validasi input
        If username = "" OrElse password = "" Then
            Try
                My.Computer.Audio.Play("gagal.wav", AudioPlayMode.Background)
                MessageBox.Show("Username dan password harus diisi.", "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Catch ex As Exception
                MsgBox("Gagal Memutar suara")
            End Try
            Exit Sub
        End If

        ' batasi nama saat regis
        If username.Length > 18 Then
            Try
                My.Computer.Audio.Play("gagal.wav", AudioPlayMode.Background)
                MessageBox.Show("username hanya 25 karakter saja", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Catch ex As Exception
                MsgBox("Gagal Memutar suara")
            End Try
            Exit Sub
        End If

        ' Membuka koneksi
        BukaKoneksi()

        ' Cek apakah username sudah terdaftar
        Dim cekUserSQL As String = "SELECT * FROM tabel_user WHERE username = @username"
        Dim cekCmd As New MySqlCommand(cekUserSQL, CONN)
        cekCmd.Parameters.AddWithValue("@username", username)
        Dim reader As MySqlDataReader = cekCmd.ExecuteReader()

        If reader.HasRows Then
            MessageBox.Show("Username sudah terdaftar.")
            reader.Close()
            CONN.Close()
            Exit Sub
        End If
        reader.Close()

        ' Menyimpan data ke database
        Dim insertSQL As String = "INSERT INTO tabel_user (username, password, role) VALUES (@username, @password, @role)"
        Dim cmd As New MySqlCommand(insertSQL, CONN)
        cmd.Parameters.AddWithValue("@username", username)
        cmd.Parameters.AddWithValue("@password", password)
        cmd.Parameters.AddWithValue("@role", role)

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Registrasi berhasil. Silakan login.")
            FormLogin.Show()
            Me.Close() ' Tutup form registrasi
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat registrasi: " & ex.Message)
        Finally
            CONN.Close()
        End Try
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        FormLogin.Show()
        Me.Close()
    End Sub
End Class