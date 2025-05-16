Public Class FormUtamaPemilik
    Private Sub TambahBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahBarangToolStripMenuItem.Click
        FormTambahBarang.Show()
        Me.Hide()
    End Sub

    Private Sub LihatStokBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatStokBarangToolStripMenuItem.Click
        FormLihatStok.Show()
        Me.Hide()
    End Sub

    Private Sub LihatLaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatLaporanToolStripMenuItem.Click
        FormLaporan.Show()
        Me.Hide()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        FormLogin.Show()
        Me.Close()
    End Sub
End Class
