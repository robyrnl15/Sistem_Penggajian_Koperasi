<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLaporanGaji
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNoTransaksi = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.VwLprnPenggajianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LprnPenggajianDataset = New Sistem_Penggajian_Koperasi.lprnPenggajianDataset()
        Me.GajiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PenggajianDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PenggajianDataSet1 = New Sistem_Penggajian_Koperasi.penggajianDataSet1()
        Me.GajiTableAdapter = New Sistem_Penggajian_Koperasi.penggajianDataSet1TableAdapters.GajiTableAdapter()
        Me.VwLprnPenggajianTableAdapter = New Sistem_Penggajian_Koperasi.lprnPenggajianDatasetTableAdapters.vwLprnPenggajianTableAdapter()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.Kode_Transaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nama_Anggota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gaji_Kotor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tanggal_Penggajian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gaji_Bersih = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nama_Karyawan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwLprnPenggajianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LprnPenggajianDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GajiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenggajianDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenggajianDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(246, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LAPORAN PENGGAJIAN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BERDASARKAN TRANSAKSI"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(207, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "No Transaksi"
        '
        'txtNoTransaksi
        '
        Me.txtNoTransaksi.Location = New System.Drawing.Point(318, 101)
        Me.txtNoTransaksi.Name = "txtNoTransaksi"
        Me.txtNoTransaksi.Size = New System.Drawing.Size(147, 20)
        Me.txtNoTransaksi.TabIndex = 3
        '
        'btnCari
        '
        Me.btnCari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCari.Location = New System.Drawing.Point(507, 99)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 23)
        Me.btnCari.TabIndex = 4
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'btnTutup
        '
        Me.btnTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTutup.Location = New System.Drawing.Point(613, 314)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(80, 31)
        Me.btnTutup.TabIndex = 5
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Kode_Transaksi, Me.Nama_Anggota, Me.Gaji_Kotor, Me.Tanggal_Penggajian, Me.Gaji_Bersih, Me.Nama_Karyawan})
        Me.DataGridView1.DataSource = Me.VwLprnPenggajianBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(50, 146)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(643, 150)
        Me.DataGridView1.TabIndex = 6
        '
        'VwLprnPenggajianBindingSource
        '
        Me.VwLprnPenggajianBindingSource.DataMember = "vwLprnPenggajian"
        Me.VwLprnPenggajianBindingSource.DataSource = Me.LprnPenggajianDataset
        '
        'LprnPenggajianDataset
        '
        Me.LprnPenggajianDataset.DataSetName = "lprnPenggajianDataset"
        Me.LprnPenggajianDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GajiBindingSource
        '
        Me.GajiBindingSource.DataMember = "Gaji"
        Me.GajiBindingSource.DataSource = Me.PenggajianDataSet1BindingSource
        '
        'PenggajianDataSet1BindingSource
        '
        Me.PenggajianDataSet1BindingSource.DataSource = Me.PenggajianDataSet1
        Me.PenggajianDataSet1BindingSource.Position = 0
        '
        'PenggajianDataSet1
        '
        Me.PenggajianDataSet1.DataSetName = "penggajianDataSet1"
        Me.PenggajianDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GajiTableAdapter
        '
        Me.GajiTableAdapter.ClearBeforeFill = True
        '
        'VwLprnPenggajianTableAdapter
        '
        Me.VwLprnPenggajianTableAdapter.ClearBeforeFill = True
        '
        'btnConvert
        '
        Me.btnConvert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConvert.Location = New System.Drawing.Point(495, 314)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(101, 31)
        Me.btnConvert.TabIndex = 7
        Me.btnConvert.Text = "Convert To Excel"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'Kode_Transaksi
        '
        Me.Kode_Transaksi.DataPropertyName = "id_transaksi"
        Me.Kode_Transaksi.HeaderText = "Kode Transaksi"
        Me.Kode_Transaksi.Name = "Kode_Transaksi"
        Me.Kode_Transaksi.ReadOnly = True
        '
        'Nama_Anggota
        '
        Me.Nama_Anggota.DataPropertyName = "namakk"
        Me.Nama_Anggota.HeaderText = "Nama Anggota"
        Me.Nama_Anggota.Name = "Nama_Anggota"
        Me.Nama_Anggota.ReadOnly = True
        '
        'Gaji_Kotor
        '
        Me.Gaji_Kotor.DataPropertyName = "jlh_Gaji"
        Me.Gaji_Kotor.HeaderText = "Gaji Kotor"
        Me.Gaji_Kotor.Name = "Gaji_Kotor"
        Me.Gaji_Kotor.ReadOnly = True
        '
        'Tanggal_Penggajian
        '
        Me.Tanggal_Penggajian.DataPropertyName = "tgl_gajian"
        Me.Tanggal_Penggajian.HeaderText = "Tanggal Penggajian"
        Me.Tanggal_Penggajian.Name = "Tanggal_Penggajian"
        Me.Tanggal_Penggajian.ReadOnly = True
        '
        'Gaji_Bersih
        '
        Me.Gaji_Bersih.DataPropertyName = "gaji_bersih"
        Me.Gaji_Bersih.HeaderText = "Gaji Bersih"
        Me.Gaji_Bersih.Name = "Gaji_Bersih"
        Me.Gaji_Bersih.ReadOnly = True
        '
        'Nama_Karyawan
        '
        Me.Nama_Karyawan.DataPropertyName = "nama"
        Me.Nama_Karyawan.HeaderText = "Nama Karyawan"
        Me.Nama_Karyawan.Name = "Nama_Karyawan"
        Me.Nama_Karyawan.ReadOnly = True
        '
        'frmLaporanGaji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 359)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.txtNoTransaksi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLaporanGaji"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Laporan Transaksi Penggajian"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwLprnPenggajianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LprnPenggajianDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GajiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenggajianDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenggajianDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNoTransaksi As TextBox
    Friend WithEvents btnCari As Button
    Friend WithEvents btnTutup As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PenggajianDataSet1BindingSource As BindingSource
    Friend WithEvents PenggajianDataSet1 As penggajianDataSet1
    Friend WithEvents GajiBindingSource As BindingSource
    Friend WithEvents GajiTableAdapter As penggajianDataSet1TableAdapters.GajiTableAdapter
    Friend WithEvents LprnPenggajianDataset As lprnPenggajianDataset
    Friend WithEvents VwLprnPenggajianBindingSource As BindingSource
    Friend WithEvents VwLprnPenggajianTableAdapter As lprnPenggajianDatasetTableAdapters.vwLprnPenggajianTableAdapter
    Friend WithEvents btnConvert As Button
    Friend WithEvents Kode_Transaksi As DataGridViewTextBoxColumn
    Friend WithEvents Nama_Anggota As DataGridViewTextBoxColumn
    Friend WithEvents Gaji_Kotor As DataGridViewTextBoxColumn
    Friend WithEvents Tanggal_Penggajian As DataGridViewTextBoxColumn
    Friend WithEvents Gaji_Bersih As DataGridViewTextBoxColumn
    Friend WithEvents Nama_Karyawan As DataGridViewTextBoxColumn
End Class
