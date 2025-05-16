<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLaporan))
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.dgvLaporan = New System.Windows.Forms.DataGridView()
        CType(Me.dgvLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCetak
        '
        Me.btnCetak.BackColor = System.Drawing.Color.GreenYellow
        Me.btnCetak.Location = New System.Drawing.Point(213, 88)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(85, 35)
        Me.btnCetak.TabIndex = 1
        Me.btnCetak.Text = "Cetak"
        Me.btnCetak.UseVisualStyleBackColor = False
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(306, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Laporan"
        '
        'btnkeluar
        '
        Me.btnkeluar.BackColor = System.Drawing.Color.DarkOrange
        Me.btnkeluar.Location = New System.Drawing.Point(415, 88)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(87, 35)
        Me.btnkeluar.TabIndex = 3
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = False
        '
        'dgvLaporan
        '
        Me.dgvLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLaporan.Location = New System.Drawing.Point(35, 129)
        Me.dgvLaporan.Name = "dgvLaporan"
        Me.dgvLaporan.ReadOnly = True
        Me.dgvLaporan.Size = New System.Drawing.Size(642, 211)
        Me.dgvLaporan.TabIndex = 0
        '
        'FormLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PA_AKHIR.My.Resources.Resources.liatstokrek
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(712, 412)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.dgvLaporan)
        Me.DoubleBuffered = True
        Me.Name = "FormLaporan"
        Me.Text = "FormLaporan"
        CType(Me.dgvLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCetak As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents btnkeluar As Button
    Friend WithEvents dgvLaporan As DataGridView
End Class
