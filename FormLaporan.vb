Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class FormLaporan
    ' Variabel untuk menyimpan laporan yang akan dicetak
    Private laporan As DataTable
    Private printDocument As New PrintDocument()
    Private printPreviewDialog As New PrintPreviewDialog()

    ' Fungsi untuk memuat laporan penjualan
    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup print document
        AddHandler printDocument.PrintPage, AddressOf PrintDocument_PrintPage

        ' Setup print preview dialog
        printPreviewDialog.Document = printDocument
        printPreviewDialog.WindowState = FormWindowState.Maximized

        ' Ambil laporan penjualan dari database
        LoadLaporan()
    End Sub

    Private Sub LoadLaporan()
        Try
            BukaKoneksi()
            Dim query As String = "SELECT p.id_penjualan, b.nama_barang, p.jumlah, p.total, " &
                                 "b.harga_barang, (p.jumlah * b.harga_barang) as subtotal " &
                                 "FROM tabel_penjualan p " &
                                 "JOIN tabel_barang b ON p.id_barang = b.id_barang"

            Dim DA As New MySqlDataAdapter(query, CONN)
            laporan = New DataTable()
            DA.Fill(laporan)

            ' Tampilkan laporan di DataGridView
            dgvLaporan.DataSource = laporan
            CONN.Close()
        Catch ex As Exception
            MessageBox.Show("Error saat memuat laporan: " & ex.Message)
            If CONN.State = ConnectionState.Open Then CONN.Close()
        End Try
    End Sub

    ' Fungsi untuk mencetak laporan
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If laporan Is Nothing OrElse laporan.Rows.Count = 0 Then
            MessageBox.Show("Tidak ada data laporan untuk dicetak.")
            Return
        End If

        printPreviewDialog.ShowDialog()
    End Sub

    ' Fungsi untuk menangani pencetakan
    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim fontHeader As New Font("Arial", 16, FontStyle.Bold)
        Dim fontSubHeader As New Font("Arial", 12, FontStyle.Bold)
        Dim fontBody As New Font("Arial", 10)
        Dim fontFooter As New Font("Arial", 8, FontStyle.Italic)

        Dim marginLeft As Integer = 50
        Dim marginTop As Integer = 50
        Dim lineHeight As Integer = 20
        Dim currentY As Integer = marginTop

        ' Judul Laporan
        e.Graphics.DrawString("LAPORAN PENJUALAN", fontHeader, Brushes.Black, marginLeft, currentY)
        currentY += lineHeight + 10

        ' Tanggal Cetak
        e.Graphics.DrawString("Tanggal: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fontBody, Brushes.Black, marginLeft, currentY)
        currentY += lineHeight + 20

        ' Header Kolom
        Dim headerX As Integer = marginLeft
        e.Graphics.DrawString("No", fontSubHeader, Brushes.Black, headerX, currentY)
        headerX += 40
        e.Graphics.DrawString("Nama Barang", fontSubHeader, Brushes.Black, headerX, currentY)
        headerX += 200
        e.Graphics.DrawString("Jumlah", fontSubHeader, Brushes.Black, headerX, currentY)
        headerX += 80
        e.Graphics.DrawString("Harga", fontSubHeader, Brushes.Black, headerX, currentY)
        headerX += 100
        e.Graphics.DrawString("Subtotal", fontSubHeader, Brushes.Black, headerX, currentY)
        currentY += lineHeight

        ' Garis pembatas
        e.Graphics.DrawLine(Pens.Black, marginLeft, currentY, marginLeft + 500, currentY)
        currentY += 5

        ' Isi Laporan
        Dim rowNum As Integer = 1
        Dim grandTotal As Decimal = 0

        For Each row As DataRow In laporan.Rows
            Dim cellX As Integer = marginLeft

            ' Nomor
            e.Graphics.DrawString(rowNum.ToString(), fontBody, Brushes.Black, cellX, currentY)
            cellX += 40

            ' Nama Barang
            e.Graphics.DrawString(row("nama_barang").ToString(), fontBody, Brushes.Black, cellX, currentY)
            cellX += 200

            ' Jumlah
            e.Graphics.DrawString(row("jumlah").ToString(), fontBody, Brushes.Black, cellX, currentY)
            cellX += 80

            ' Harga
            e.Graphics.DrawString(Decimal.Parse(row("harga_barang")).ToString("N0"), fontBody, Brushes.Black, cellX, currentY)
            cellX += 100

            ' Subtotal
            Dim subtotal As Decimal = Decimal.Parse(row("subtotal"))
            e.Graphics.DrawString(subtotal.ToString("N0"), fontBody, Brushes.Black, cellX, currentY)

            grandTotal += subtotal
            rowNum += 1
            currentY += lineHeight

            ' Cek apakah perlu halaman baru
            If currentY > e.MarginBounds.Height - 100 Then
                e.HasMorePages = True
                Return
            End If
        Next

        ' Garis pembatas footer
        currentY += 10
        e.Graphics.DrawLine(Pens.Black, marginLeft, currentY, marginLeft + 500, currentY)
        currentY += 15

        ' Grand Total
        e.Graphics.DrawString("TOTAL PENJUALAN:", fontSubHeader, Brushes.Black, marginLeft + 300, currentY)
        e.Graphics.DrawString(grandTotal.ToString("N0"), fontSubHeader, Brushes.Black, marginLeft + 475, currentY)
        currentY += lineHeight

        ' Footer
        currentY += 20
        e.Graphics.DrawString("Dicetak oleh sistem Reno Building", fontFooter, Brushes.Black, marginLeft, currentY)
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        FormUtamaPemilik.Show()
        Me.Close()
    End Sub
End Class