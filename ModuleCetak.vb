Imports System.Drawing.Printing

Module ModuleCetak
    Public Sub CetakLaporan(laporan As DataTable)
        ' Membuat objek PrintDocument
        Dim pd As New PrintDocument()

        ' Menentukan handler untuk event PrintPage
        AddHandler pd.PrintPage, Sub(sender As Object, e As PrintPageEventArgs)
                                     ' Menyiapkan font untuk laporan
                                     Dim font As New Font("Arial", 10)

                                     ' Menentukan posisi untuk mulai mencetak
                                     Dim yPos As Integer = 50
                                     e.Graphics.DrawString("Laporan Penjualan", font, Brushes.Black, 100, yPos)
                                     yPos += 30

                                     ' Menampilkan header tabel
                                     e.Graphics.DrawString("Nama Barang", font, Brushes.Black, 100, yPos)
                                     e.Graphics.DrawString("Jumlah Terjual", font, Brushes.Black, 300, yPos)
                                     e.Graphics.DrawString("Total Pendapatan", font, Brushes.Black, 500, yPos)
                                     yPos += 20

                                     ' Menampilkan data laporan
                                     For Each row As DataRow In laporan.Rows
                                         e.Graphics.DrawString(row("nama_barang").ToString(), font, Brushes.Black, 100, yPos)
                                         e.Graphics.DrawString(row("total_terjual").ToString(), font, Brushes.Black, 300, yPos)
                                         e.Graphics.DrawString(row("total_pendapatan").ToString(), font, Brushes.Black, 500, yPos)
                                         yPos += 20
                                     Next
                                 End Sub

        ' Menyuruh PrintDocument untuk mencetak
        pd.Print()
    End Sub
End Module
