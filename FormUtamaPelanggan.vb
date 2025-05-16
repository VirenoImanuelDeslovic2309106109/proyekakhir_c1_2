Public Class FormUtamaPelanggan
    Private Sub btnBeliBarang_Click(sender As Object, e As EventArgs) Handles btnBeliBarang.Click
        FormBeliBarang.Show()
        Me.Hide()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        FormLogin.Show()
        Me.Close()
    End Sub
End Class
