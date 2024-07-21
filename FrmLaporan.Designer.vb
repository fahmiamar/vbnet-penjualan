<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLaporan
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
        Me.RB2 = New System.Windows.Forms.RadioButton()
        Me.sd = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dr = New System.Windows.Forms.DateTimePicker()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Lbkeluar = New System.Windows.Forms.Label()
        Me.LbEdit = New System.Windows.Forms.Label()
        Me.RB1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RB3 = New System.Windows.Forms.RadioButton()
        Me.RB4 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'RB2
        '
        Me.RB2.AutoSize = True
        Me.RB2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB2.Location = New System.Drawing.Point(109, 297)
        Me.RB2.Name = "RB2"
        Me.RB2.Size = New System.Drawing.Size(386, 34)
        Me.RB2.TabIndex = 762
        Me.RB2.TabStop = True
        Me.RB2.Text = "Laporan Pembelian berdasarkan Barang"
        Me.RB2.UseVisualStyleBackColor = True
        '
        'sd
        '
        Me.sd.CalendarMonthBackground = System.Drawing.Color.Transparent
        Me.sd.CalendarTitleBackColor = System.Drawing.Color.Transparent
        Me.sd.CustomFormat = "dd-MMM-yyyy"
        Me.sd.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.sd.Location = New System.Drawing.Point(482, 122)
        Me.sd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.sd.Name = "sd"
        Me.sd.Size = New System.Drawing.Size(198, 34)
        Me.sd.TabIndex = 761
        Me.sd.Value = New Date(2018, 10, 16, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(421, 122)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 30)
        Me.Label2.TabIndex = 760
        Me.Label2.Text = "s/d"
        '
        'dr
        '
        Me.dr.CalendarMonthBackground = System.Drawing.Color.Transparent
        Me.dr.CalendarTitleBackColor = System.Drawing.Color.Transparent
        Me.dr.CustomFormat = "dd-MMM-yyyy"
        Me.dr.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dr.Location = New System.Drawing.Point(201, 122)
        Me.dr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dr.Name = "dr"
        Me.dr.Size = New System.Drawing.Size(198, 34)
        Me.dr.TabIndex = 759
        Me.dr.Value = New Date(2018, 10, 16, 0, 0, 0, 0)
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(17, 122)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(168, 30)
        Me.Label24.TabIndex = 758
        Me.Label24.Text = "Tanggal Laporan :"
        '
        'Lbkeluar
        '
        Me.Lbkeluar.BackColor = System.Drawing.Color.White
        Me.Lbkeluar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbkeluar.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbkeluar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Lbkeluar.Location = New System.Drawing.Point(938, 124)
        Me.Lbkeluar.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Lbkeluar.Name = "Lbkeluar"
        Me.Lbkeluar.Size = New System.Drawing.Size(120, 34)
        Me.Lbkeluar.TabIndex = 757
        Me.Lbkeluar.Text = "Keluar"
        Me.Lbkeluar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbEdit
        '
        Me.LbEdit.BackColor = System.Drawing.Color.White
        Me.LbEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbEdit.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEdit.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LbEdit.Location = New System.Drawing.Point(745, 124)
        Me.LbEdit.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LbEdit.Name = "LbEdit"
        Me.LbEdit.Size = New System.Drawing.Size(114, 34)
        Me.LbEdit.TabIndex = 756
        Me.LbEdit.Text = "OK"
        Me.LbEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RB1
        '
        Me.RB1.AutoSize = True
        Me.RB1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB1.Location = New System.Drawing.Point(109, 252)
        Me.RB1.Name = "RB1"
        Me.RB1.Size = New System.Drawing.Size(403, 34)
        Me.RB1.TabIndex = 755
        Me.RB1.TabStop = True
        Me.RB1.Text = "Laporan Pembelian berdasarkan Pemasok"
        Me.RB1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 30)
        Me.Label1.TabIndex = 754
        Me.Label1.Text = "Jenis Laporan :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 25.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(640, 53)
        Me.Label9.TabIndex = 753
        Me.Label9.Text = "Laporan Pembelian dan Penjualan"
        '
        'RB3
        '
        Me.RB3.AutoSize = True
        Me.RB3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB3.Location = New System.Drawing.Point(109, 347)
        Me.RB3.Name = "RB3"
        Me.RB3.Size = New System.Drawing.Size(410, 34)
        Me.RB3.TabIndex = 763
        Me.RB3.TabStop = True
        Me.RB3.Text = "Laporan Penjualan berdasarkan Pelanggan"
        Me.RB3.UseVisualStyleBackColor = True
        '
        'RB4
        '
        Me.RB4.AutoSize = True
        Me.RB4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB4.Location = New System.Drawing.Point(109, 396)
        Me.RB4.Name = "RB4"
        Me.RB4.Size = New System.Drawing.Size(380, 34)
        Me.RB4.TabIndex = 764
        Me.RB4.TabStop = True
        Me.RB4.Text = "Laporan Penjualan berdasarkan Barang"
        Me.RB4.UseVisualStyleBackColor = True
        '
        'FrmLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1089, 546)
        Me.Controls.Add(Me.RB4)
        Me.Controls.Add(Me.RB3)
        Me.Controls.Add(Me.RB2)
        Me.Controls.Add(Me.sd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dr)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Lbkeluar)
        Me.Controls.Add(Me.LbEdit)
        Me.Controls.Add(Me.RB1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Name = "FrmLaporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmLaporan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RB2 As RadioButton
    Friend WithEvents sd As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dr As DateTimePicker
    Friend WithEvents Label24 As Label
    Friend WithEvents Lbkeluar As Label
    Friend WithEvents LbEdit As Label
    Friend WithEvents RB1 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents RB3 As RadioButton
    Friend WithEvents RB4 As RadioButton
End Class
