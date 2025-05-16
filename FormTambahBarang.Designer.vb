<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTambahBarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtJenis = New System.Windows.Forms.TextBox()
        Me.txtMerek = New System.Windows.Forms.TextBox()
        Me.nudHarga = New System.Windows.Forms.NumericUpDown()
        Me.nudStok = New System.Windows.Forms.NumericUpDown()
        Me.nudStokMin = New System.Windows.Forms.NumericUpDown()
        Me.cmbKategori = New System.Windows.Forms.ComboBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.brnKeluar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.nudHarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStokMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(141, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Barang:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(455, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Harga:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(455, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Stok:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(455, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Stok Minimal:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(141, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jenis:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(141, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Merek:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(455, 282)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Kategori:"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(243, 132)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(179, 20)
        Me.txtNama.TabIndex = 7
        '
        'txtJenis
        '
        Me.txtJenis.Location = New System.Drawing.Point(243, 232)
        Me.txtJenis.Name = "txtJenis"
        Me.txtJenis.Size = New System.Drawing.Size(179, 20)
        Me.txtJenis.TabIndex = 8
        '
        'txtMerek
        '
        Me.txtMerek.Location = New System.Drawing.Point(243, 182)
        Me.txtMerek.Name = "txtMerek"
        Me.txtMerek.Size = New System.Drawing.Size(179, 20)
        Me.txtMerek.TabIndex = 9
        '
        'nudHarga
        '
        Me.nudHarga.Location = New System.Drawing.Point(552, 132)
        Me.nudHarga.Name = "nudHarga"
        Me.nudHarga.Size = New System.Drawing.Size(179, 20)
        Me.nudHarga.TabIndex = 10
        '
        'nudStok
        '
        Me.nudStok.Location = New System.Drawing.Point(552, 182)
        Me.nudStok.Name = "nudStok"
        Me.nudStok.Size = New System.Drawing.Size(179, 20)
        Me.nudStok.TabIndex = 11
        '
        'nudStokMin
        '
        Me.nudStokMin.Location = New System.Drawing.Point(552, 232)
        Me.nudStokMin.Name = "nudStokMin"
        Me.nudStokMin.Size = New System.Drawing.Size(179, 20)
        Me.nudStokMin.TabIndex = 12
        '
        'cmbKategori
        '
        Me.cmbKategori.FormattingEnabled = True
        Me.cmbKategori.Items.AddRange(New Object() {"Bangunan", "Peralatan", "Pipa", "Listrik"})
        Me.cmbKategori.Location = New System.Drawing.Point(552, 281)
        Me.cmbKategori.Name = "cmbKategori"
        Me.cmbKategori.Size = New System.Drawing.Size(179, 21)
        Me.cmbKategori.TabIndex = 13
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.GreenYellow
        Me.btnSimpan.Location = New System.Drawing.Point(214, 339)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(157, 51)
        Me.btnSimpan.TabIndex = 14
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'brnKeluar
        '
        Me.brnKeluar.BackColor = System.Drawing.Color.DarkOrange
        Me.brnKeluar.Location = New System.Drawing.Point(477, 340)
        Me.brnKeluar.Name = "brnKeluar"
        Me.brnKeluar.Size = New System.Drawing.Size(160, 51)
        Me.brnKeluar.TabIndex = 15
        Me.brnKeluar.Text = "Keluar"
        Me.brnKeluar.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(255, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(343, 29)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Tambah Barang Reno Building"
        '
        'FormTambahBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PA_AKHIR.My.Resources.Resources.tambahbarang
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(850, 493)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.brnKeluar)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.cmbKategori)
        Me.Controls.Add(Me.nudStokMin)
        Me.Controls.Add(Me.nudStok)
        Me.Controls.Add(Me.nudHarga)
        Me.Controls.Add(Me.txtMerek)
        Me.Controls.Add(Me.txtJenis)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "FormTambahBarang"
        Me.Text = "FormTambahBarang"
        CType(Me.nudHarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStokMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtJenis As TextBox
    Friend WithEvents txtMerek As TextBox
    Friend WithEvents nudHarga As NumericUpDown
    Friend WithEvents nudStok As NumericUpDown
    Friend WithEvents nudStokMin As NumericUpDown
    Friend WithEvents cmbKategori As ComboBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents brnKeluar As Button
    Friend WithEvents Label8 As Label
End Class
