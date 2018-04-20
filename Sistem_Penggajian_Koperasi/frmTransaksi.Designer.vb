<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTransaksi
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNotransaksi = New System.Windows.Forms.TextBox()
        Me.cmbKodeGaji = New System.Windows.Forms.ComboBox()
        Me.dtpGajianTransaksi = New System.Windows.Forms.DateTimePicker()
        Me.cmbNoAnggota = New System.Windows.Forms.ComboBox()
        Me.txtNamaAnggota = New System.Windows.Forms.TextBox()
        Me.txtGajiKotor = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNamaPotongan = New System.Windows.Forms.TextBox()
        Me.cmbKodePotongan = New System.Windows.Forms.ComboBox()
        Me.btnTambahPotongan = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTTLPotongan = New System.Windows.Forms.TextBox()
        Me.txtGajiBersih = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnCtkSimpan = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtJmlhPotongan = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.kode_potongan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.no_transaksi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nama_potongan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.jlh_potongan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.cmbAdmin = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnSelesai = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(401, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FORM AMPRAH GAJI ANGGOTA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No Transaksi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tanggal Gajian"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(696, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "No Anggota"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(696, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nama Anggota"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(58, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Kode Gaji"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(58, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Gaji Kotor"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(58, 225)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Kode Potongan"
        '
        'txtNotransaksi
        '
        Me.txtNotransaksi.Cursor = System.Windows.Forms.Cursors.No
        Me.txtNotransaksi.Location = New System.Drawing.Point(171, 72)
        Me.txtNotransaksi.Name = "txtNotransaksi"
        Me.txtNotransaksi.ReadOnly = True
        Me.txtNotransaksi.Size = New System.Drawing.Size(158, 20)
        Me.txtNotransaksi.TabIndex = 8
        '
        'cmbKodeGaji
        '
        Me.cmbKodeGaji.FormattingEnabled = True
        Me.cmbKodeGaji.Location = New System.Drawing.Point(171, 133)
        Me.cmbKodeGaji.Name = "cmbKodeGaji"
        Me.cmbKodeGaji.Size = New System.Drawing.Size(158, 21)
        Me.cmbKodeGaji.TabIndex = 9
        '
        'dtpGajianTransaksi
        '
        Me.dtpGajianTransaksi.CustomFormat = "dd MMMM yyyy"
        Me.dtpGajianTransaksi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpGajianTransaksi.Location = New System.Drawing.Point(171, 104)
        Me.dtpGajianTransaksi.Name = "dtpGajianTransaksi"
        Me.dtpGajianTransaksi.Size = New System.Drawing.Size(158, 20)
        Me.dtpGajianTransaksi.TabIndex = 10
        '
        'cmbNoAnggota
        '
        Me.cmbNoAnggota.FormattingEnabled = True
        Me.cmbNoAnggota.Location = New System.Drawing.Point(812, 98)
        Me.cmbNoAnggota.Name = "cmbNoAnggota"
        Me.cmbNoAnggota.Size = New System.Drawing.Size(121, 21)
        Me.cmbNoAnggota.TabIndex = 11
        '
        'txtNamaAnggota
        '
        Me.txtNamaAnggota.Location = New System.Drawing.Point(812, 129)
        Me.txtNamaAnggota.Name = "txtNamaAnggota"
        Me.txtNamaAnggota.Size = New System.Drawing.Size(231, 20)
        Me.txtNamaAnggota.TabIndex = 12
        '
        'txtGajiKotor
        '
        Me.txtGajiKotor.Location = New System.Drawing.Point(171, 191)
        Me.txtGajiKotor.Name = "txtGajiKotor"
        Me.txtGajiKotor.Size = New System.Drawing.Size(158, 20)
        Me.txtGajiKotor.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(58, 255)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Nama Potongan"
        '
        'txtNamaPotongan
        '
        Me.txtNamaPotongan.Location = New System.Drawing.Point(171, 252)
        Me.txtNamaPotongan.Name = "txtNamaPotongan"
        Me.txtNamaPotongan.Size = New System.Drawing.Size(158, 20)
        Me.txtNamaPotongan.TabIndex = 17
        '
        'cmbKodePotongan
        '
        Me.cmbKodePotongan.FormattingEnabled = True
        Me.cmbKodePotongan.Location = New System.Drawing.Point(171, 222)
        Me.cmbKodePotongan.Name = "cmbKodePotongan"
        Me.cmbKodePotongan.Size = New System.Drawing.Size(158, 21)
        Me.cmbKodePotongan.TabIndex = 18
        '
        'btnTambahPotongan
        '
        Me.btnTambahPotongan.Location = New System.Drawing.Point(171, 317)
        Me.btnTambahPotongan.Name = "btnTambahPotongan"
        Me.btnTambahPotongan.Size = New System.Drawing.Size(78, 44)
        Me.btnTambahPotongan.TabIndex = 19
        Me.btnTambahPotongan.Text = "Tambahkan Potongan"
        Me.btnTambahPotongan.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(604, 446)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Total Potongan"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(604, 481)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Gaji Bersih"
        '
        'txtTTLPotongan
        '
        Me.txtTTLPotongan.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtTTLPotongan.Location = New System.Drawing.Point(736, 443)
        Me.txtTTLPotongan.Name = "txtTTLPotongan"
        Me.txtTTLPotongan.ReadOnly = True
        Me.txtTTLPotongan.Size = New System.Drawing.Size(210, 20)
        Me.txtTTLPotongan.TabIndex = 23
        '
        'txtGajiBersih
        '
        Me.txtGajiBersih.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtGajiBersih.Location = New System.Drawing.Point(736, 478)
        Me.txtGajiBersih.Name = "txtGajiBersih"
        Me.txtGajiBersih.ReadOnly = True
        Me.txtGajiBersih.Size = New System.Drawing.Size(210, 20)
        Me.txtGajiBersih.TabIndex = 24
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(963, 543)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 44)
        Me.btnCancel.TabIndex = 25
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnCtkSimpan
        '
        Me.btnCtkSimpan.Location = New System.Drawing.Point(866, 543)
        Me.btnCtkSimpan.Name = "btnCtkSimpan"
        Me.btnCtkSimpan.Size = New System.Drawing.Size(80, 44)
        Me.btnCtkSimpan.TabIndex = 27
        Me.btnCtkSimpan.Text = "Cetak dan " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Simpan"
        Me.btnCtkSimpan.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(58, 286)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Jumlah Potongan"
        '
        'txtJmlhPotongan
        '
        Me.txtJmlhPotongan.Location = New System.Drawing.Point(171, 283)
        Me.txtJmlhPotongan.Name = "txtJmlhPotongan"
        Me.txtJmlhPotongan.Size = New System.Drawing.Size(158, 20)
        Me.txtJmlhPotongan.TabIndex = 29
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.kode_potongan, Me.no_transaksi, Me.nama_potongan, Me.jlh_potongan})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(347, 191)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(696, 172)
        Me.ListView1.TabIndex = 30
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'kode_potongan
        '
        Me.kode_potongan.Text = "Kode Potongan"
        Me.kode_potongan.Width = 115
        '
        'no_transaksi
        '
        Me.no_transaksi.Text = "No Transaksi"
        Me.no_transaksi.Width = 179
        '
        'nama_potongan
        '
        Me.nama_potongan.Text = "Nama Potongan"
        Me.nama_potongan.Width = 222
        '
        'jlh_potongan
        '
        Me.jlh_potongan.Text = "Jumlah Potongan"
        Me.jlh_potongan.Width = 176
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(258, 317)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(71, 44)
        Me.btnHapus.TabIndex = 31
        Me.btnHapus.Text = "Hapus Potongan"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'cmbAdmin
        '
        Me.cmbAdmin.FormattingEnabled = True
        Me.cmbAdmin.Location = New System.Drawing.Point(812, 69)
        Me.cmbAdmin.Name = "cmbAdmin"
        Me.cmbAdmin.Size = New System.Drawing.Size(121, 21)
        Me.cmbAdmin.TabIndex = 33
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(696, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Kode Admin"
        '
        'btnSelesai
        '
        Me.btnSelesai.Location = New System.Drawing.Point(963, 369)
        Me.btnSelesai.Name = "btnSelesai"
        Me.btnSelesai.Size = New System.Drawing.Size(80, 44)
        Me.btnSelesai.TabIndex = 34
        Me.btnSelesai.Text = "Selesai"
        Me.btnSelesai.UseVisualStyleBackColor = True
        '
        'frmTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1090, 617)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSelesai)
        Me.Controls.Add(Me.cmbAdmin)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.txtJmlhPotongan)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnCtkSimpan)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtGajiBersih)
        Me.Controls.Add(Me.txtTTLPotongan)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnTambahPotongan)
        Me.Controls.Add(Me.cmbKodePotongan)
        Me.Controls.Add(Me.txtNamaPotongan)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtGajiKotor)
        Me.Controls.Add(Me.txtNamaAnggota)
        Me.Controls.Add(Me.cmbNoAnggota)
        Me.Controls.Add(Me.dtpGajianTransaksi)
        Me.Controls.Add(Me.cmbKodeGaji)
        Me.Controls.Add(Me.txtNotransaksi)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmTransaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Transaksi Penggajian"
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
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNotransaksi As TextBox
    Friend WithEvents cmbKodeGaji As ComboBox
    Friend WithEvents dtpGajianTransaksi As DateTimePicker
    Friend WithEvents cmbNoAnggota As ComboBox
    Friend WithEvents txtNamaAnggota As TextBox
    Friend WithEvents txtGajiKotor As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNamaPotongan As TextBox
    Friend WithEvents cmbKodePotongan As ComboBox
    Friend WithEvents btnTambahPotongan As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTTLPotongan As TextBox
    Friend WithEvents txtGajiBersih As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnCtkSimpan As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txtJmlhPotongan As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents kode_potongan As ColumnHeader
    Friend WithEvents no_transaksi As ColumnHeader
    Friend WithEvents nama_potongan As ColumnHeader
    Friend WithEvents jlh_potongan As ColumnHeader
    Friend WithEvents btnHapus As Button
    Friend WithEvents cmbAdmin As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnSelesai As Button
End Class
