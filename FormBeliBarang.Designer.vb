<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBeliBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBeliBarang))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnBeli = New System.Windows.Forms.Button()
        Me.cmbBarang = New System.Windows.Forms.ComboBox()
        Me.nudJumlah = New System.Windows.Forms.NumericUpDown()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.nudJumlah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(284, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Barang:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(284, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jumlah:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(284, 198)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(41, 16)
        Me.lblTotal.TabIndex = 2
        Me.lblTotal.Text = "Total:"
        '
        'btnBeli
        '
        Me.btnBeli.BackColor = System.Drawing.Color.LawnGreen
        Me.btnBeli.Location = New System.Drawing.Point(340, 235)
        Me.btnBeli.Name = "btnBeli"
        Me.btnBeli.Size = New System.Drawing.Size(125, 36)
        Me.btnBeli.TabIndex = 3
        Me.btnBeli.Text = "Beli"
        Me.btnBeli.UseVisualStyleBackColor = False
        '
        'cmbBarang
        '
        Me.cmbBarang.FormattingEnabled = True
        Me.cmbBarang.Location = New System.Drawing.Point(344, 129)
        Me.cmbBarang.Name = "cmbBarang"
        Me.cmbBarang.Size = New System.Drawing.Size(208, 21)
        Me.cmbBarang.TabIndex = 4
        '
        'nudJumlah
        '
        Me.nudJumlah.Location = New System.Drawing.Point(344, 164)
        Me.nudJumlah.Name = "nudJumlah"
        Me.nudJumlah.Size = New System.Drawing.Size(208, 20)
        Me.nudJumlah.TabIndex = 5
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.DarkOrange
        Me.btnKeluar.Location = New System.Drawing.Point(340, 296)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(125, 36)
        Me.btnKeluar.TabIndex = 6
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(335, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Beli Barang"
        '
        'FormBeliBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PA_AKHIR.My.Resources.Resources.belibarang1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.nudJumlah)
        Me.Controls.Add(Me.cmbBarang)
        Me.Controls.Add(Me.btnBeli)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "FormBeliBarang"
        Me.Text = "FormBeliBarang"
        CType(Me.nudJumlah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnBeli As Button
    Friend WithEvents cmbBarang As ComboBox
    Friend WithEvents nudJumlah As NumericUpDown
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents btnKeluar As Button
    Friend WithEvents Label3 As Label
End Class
