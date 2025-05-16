<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtamaPemilik
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ManajemenBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LihatStokBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LihatLaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(321, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RenoBuilding"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManajemenBarangToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ManajemenBarangToolStripMenuItem
        '
        Me.ManajemenBarangToolStripMenuItem.BackColor = System.Drawing.Color.GreenYellow
        Me.ManajemenBarangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahBarangToolStripMenuItem, Me.LihatStokBarangToolStripMenuItem})
        Me.ManajemenBarangToolStripMenuItem.Name = "ManajemenBarangToolStripMenuItem"
        Me.ManajemenBarangToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.ManajemenBarangToolStripMenuItem.Text = "Manajemen Barang"
        '
        'TambahBarangToolStripMenuItem
        '
        Me.TambahBarangToolStripMenuItem.BackColor = System.Drawing.Color.GreenYellow
        Me.TambahBarangToolStripMenuItem.Name = "TambahBarangToolStripMenuItem"
        Me.TambahBarangToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.TambahBarangToolStripMenuItem.Text = "Tambah Barang"
        '
        'LihatStokBarangToolStripMenuItem
        '
        Me.LihatStokBarangToolStripMenuItem.BackColor = System.Drawing.Color.GreenYellow
        Me.LihatStokBarangToolStripMenuItem.Name = "LihatStokBarangToolStripMenuItem"
        Me.LihatStokBarangToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.LihatStokBarangToolStripMenuItem.Text = "Lihat Stok Barang"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.BackColor = System.Drawing.Color.GreenYellow
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LihatLaporanToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LihatLaporanToolStripMenuItem
        '
        Me.LihatLaporanToolStripMenuItem.BackColor = System.Drawing.Color.GreenYellow
        Me.LihatLaporanToolStripMenuItem.Name = "LihatLaporanToolStripMenuItem"
        Me.LihatLaporanToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.LihatLaporanToolStripMenuItem.Text = "Lihat Laporan"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.BackColor = System.Drawing.Color.DarkOrange
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(284, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(231, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Selamat Datang Admin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(210, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(374, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Silahkan Pilih Menu Pojok Di Kiri Atas"
        '
        'FormUtamaPemilik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PA_AKHIR.My.Resources.Resources.utamapemilik
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormUtamaPemilik"
        Me.Text = "FormUtamaPemilik"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ManajemenBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatStokBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatLaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
