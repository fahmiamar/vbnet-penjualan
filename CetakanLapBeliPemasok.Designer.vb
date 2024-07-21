<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CetakanLapBeliPemasok
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DSPembelian = New warung_contoh.DSPembelian()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable1TableAdapter = New warung_contoh.DSPembelianTableAdapters.DataTable1TableAdapter()
        Me.DataTable2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable2TableAdapter = New warung_contoh.DSPembelianTableAdapters.DataTable2TableAdapter()
        CType(Me.DSPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DataTable1BindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.DataTable2BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "warung_contoh.LapBeliPemasok.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'DSPembelian
        '
        Me.DSPembelian.DataSetName = "DSPembelian"
        Me.DSPembelian.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.DSPembelian
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'DataTable2BindingSource
        '
        Me.DataTable2BindingSource.DataMember = "DataTable2"
        Me.DataTable2BindingSource.DataSource = Me.DSPembelian
        '
        'DataTable2TableAdapter
        '
        Me.DataTable2TableAdapter.ClearBeforeFill = True
        '
        'CetakanLapBeliPemasok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "CetakanLapBeliPemasok"
        Me.Text = "CetakanLapBeliPemasok"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DSPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents DSPembelian As DSPembelian
    Friend WithEvents DataTable2BindingSource As BindingSource
    Friend WithEvents DataTable1TableAdapter As DSPembelianTableAdapters.DataTable1TableAdapter
    Friend WithEvents DataTable2TableAdapter As DSPembelianTableAdapters.DataTable2TableAdapter
End Class
