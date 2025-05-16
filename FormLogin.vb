Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class FormLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim role As String = ""

        ' Membuka koneksi ke database
        BukaKoneksi()

        ' Query untuk mendapatkan role user berdasarkan username dan password
        Dim SQL As String = "SELECT role FROM tabel_user WHERE username = @username AND password = @password"
        Dim CMD As New MySqlCommand(SQL, CONN)
        CMD.Parameters.AddWithValue("@username", username)
        CMD.Parameters.AddWithValue("@password", password)

        ' Menjalankan query
        Dim reader As MySqlDataReader = CMD.ExecuteReader()
        If reader.HasRows Then
            reader.Read()
            role = reader("role").ToString()
        End If
        CONN.Close()

        ' Menentukan form yang akan ditampilkan sesuai role
        If role = "pemilik" Then
            FormUtamaPemilik.Show()
            Me.Hide()
        ElseIf role = "pelanggan" Then
            FormUtamaPelanggan.lblNama.Text = txtUsername.Text
            FormUtamaPelanggan.Show()
            Me.Hide()
        Else
            Try
                My.Computer.Audio.Play("gagal.wav", AudioPlayMode.Background)
                MessageBox.Show("Username atau password salah.", "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Catch ex As Exception
                MsgBox("Gagal Memutar suara")
            End Try
        End If
    End Sub

    Private Sub btnRegis_Click(sender As Object, e As EventArgs) Handles btnRegis.Click
        FormRegis.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            My.Computer.Audio.Play("getout.wav", AudioPlayMode.WaitToComplete)
        Catch ex As Exception
            MsgBox("Gagal Memutar suara")
        End Try
        Application.Exit()
    End Sub
End Class
