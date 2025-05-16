<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtamaPelanggan
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
        Me.btnBeliBarang = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(165, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Selamat Datang"
        '
        'btnBeliBarang
        '
        Me.btnBeliBarang.BackColor = System.Drawing.Color.GreenYellow
        Me.btnBeliBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBeliBarang.Location = New System.Drawing.Point(205, 263)
        Me.btnBeliBarang.Name = "btnBeliBarang"
        Me.btnBeliBarang.Size = New System.Drawing.Size(188, 59)
        Me.btnBeliBarang.TabIndex = 1
        Me.btnBeliBarang.Text = "Beli Barang"
        Me.btnBeliBarang.UseVisualStyleBackColor = False
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.DarkOrange
        Me.btnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.Location = New System.Drawing.Point(440, 264)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(188, 59)
        Me.btnKeluar.TabIndex = 2
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.BackColor = System.Drawing.Color.Transparent
        Me.lblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(342, 137)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(86, 29)
        Me.lblNama.TabIndex = 3
        Me.lblNama.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(165, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(505, 29)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "RenoBuilding Menyediakan Barang Bangunan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(165, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Hanya Untuk Anda"
        '
        'FormUtamaPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.PA_AKHIR.My.Resources.Resources.punyapelanggan
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnBeliBarang)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "FormUtamaPelanggan"
        Me.Text = "FormUtamaPelanggan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnBeliBarang As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents lblNama As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
