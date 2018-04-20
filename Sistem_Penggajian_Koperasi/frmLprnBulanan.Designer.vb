<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLprnBulanan
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GajiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PenggajianDataSet1 = New Sistem_Penggajian_Koperasi.penggajianDataSet1()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.txtBulan = New System.Windows.Forms.TextBox()
        Me.GajiTableAdapter = New Sistem_Penggajian_Koperasi.penggajianDataSet1TableAdapters.GajiTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.KodeGaji = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggalGajian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahGaji = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GajiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenggajianDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(140, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LAPORAN GAJI PERBULAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Masukkan Kode :"
        '
        'btnCari
        '
        Me.btnCari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCari.Location = New System.Drawing.Point(390, 66)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 23)
        Me.btnCari.TabIndex = 3
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeGaji, Me.TanggalGajian, Me.JumlahGaji})
        Me.DataGridView1.DataSource = Me.GajiBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(56, 114)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(423, 162)
        Me.DataGridView1.TabIndex = 4
        '
        'GajiBindingSource
        '
        Me.GajiBindingSource.DataMember = "Gaji"
        Me.GajiBindingSource.DataSource = Me.PenggajianDataSet1
        '
        'PenggajianDataSet1
        '
        Me.PenggajianDataSet1.DataSetName = "penggajianDataSet1"
        Me.PenggajianDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnTutup
        '
        Me.btnTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTutup.Location = New System.Drawing.Point(401, 298)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(93, 27)
        Me.btnTutup.TabIndex = 6
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'txtBulan
        '
        Me.txtBulan.Location = New System.Drawing.Point(185, 68)
        Me.txtBulan.Name = "txtBulan"
        Me.txtBulan.Size = New System.Drawing.Size(182, 20)
        Me.txtBulan.TabIndex = 7
        '
        'GajiTableAdapter
        '
        Me.GajiTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(157, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "GJ/"
        '
        'btnConvert
        '
        Me.btnConvert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConvert.Location = New System.Drawing.Point(274, 298)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(93, 27)
        Me.btnConvert.TabIndex = 9
        Me.btnConvert.Text = "Export ke Excel"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'KodeGaji
        '
        Me.KodeGaji.DataPropertyName = "Id_gaji"
        Me.KodeGaji.HeaderText = "Kode Gaji"
        Me.KodeGaji.Name = "KodeGaji"
        Me.KodeGaji.ReadOnly = True
        '
        'TanggalGajian
        '
        Me.TanggalGajian.DataPropertyName = "tglGajian"
        Me.TanggalGajian.HeaderText = "Tanggal Gajian"
        Me.TanggalGajian.Name = "TanggalGajian"
        Me.TanggalGajian.ReadOnly = True
        Me.TanggalGajian.Width = 140
        '
        'JumlahGaji
        '
        Me.JumlahGaji.DataPropertyName = "jlh_Gaji"
        Me.JumlahGaji.HeaderText = "Jumlah Gaji"
        Me.JumlahGaji.Name = "JumlahGaji"
        Me.JumlahGaji.ReadOnly = True
        Me.JumlahGaji.Width = 140
        '
        'Timer1
        '
        '
        'frmLprnBulanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 337)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBulan)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLprnBulanan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORM LAPORAN GAJI PERBULANAN"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GajiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenggajianDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCari As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnTutup As Button
    Friend WithEvents txtBulan As TextBox
    Friend WithEvents PenggajianDataSet1 As penggajianDataSet1
    Friend WithEvents GajiBindingSource As BindingSource
    Friend WithEvents GajiTableAdapter As penggajianDataSet1TableAdapters.GajiTableAdapter
    Friend WithEvents Label3 As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents KodeGaji As DataGridViewTextBoxColumn
    Friend WithEvents TanggalGajian As DataGridViewTextBoxColumn
    Friend WithEvents JumlahGaji As DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As Timer
End Class
