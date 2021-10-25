<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTmbhAnggota
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTmbhAnggota))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIdAnggota = New System.Windows.Forms.TextBox()
        Me.txtNamaKK = New System.Windows.Forms.TextBox()
        Me.txtGolongan = New System.Windows.Forms.TextBox()
        Me.cmbJK = New System.Windows.Forms.ComboBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.txtNoKK = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(195, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FORM TAMBAH ANGGOTA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NO ANGGOTA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NAMA KEPALA KELUARGA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "JENIS KELAMIN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "GOLONGAN TAHAP"
        '
        'txtIdAnggota
        '
        Me.txtIdAnggota.Cursor = System.Windows.Forms.Cursors.No
        Me.txtIdAnggota.Location = New System.Drawing.Point(231, 77)
        Me.txtIdAnggota.Name = "txtIdAnggota"
        Me.txtIdAnggota.ReadOnly = True
        Me.txtIdAnggota.Size = New System.Drawing.Size(128, 20)
        Me.txtIdAnggota.TabIndex = 5
        '
        'txtNamaKK
        '
        Me.txtNamaKK.Location = New System.Drawing.Point(231, 140)
        Me.txtNamaKK.Name = "txtNamaKK"
        Me.txtNamaKK.Size = New System.Drawing.Size(312, 20)
        Me.txtNamaKK.TabIndex = 6
        '
        'txtGolongan
        '
        Me.txtGolongan.Location = New System.Drawing.Point(231, 206)
        Me.txtGolongan.Name = "txtGolongan"
        Me.txtGolongan.Size = New System.Drawing.Size(100, 20)
        Me.txtGolongan.TabIndex = 8
        '
        'cmbJK
        '
        Me.cmbJK.FormattingEnabled = True
        Me.cmbJK.Items.AddRange(New Object() {"Laki - Laki", "Perempuan"})
        Me.cmbJK.Location = New System.Drawing.Point(231, 173)
        Me.cmbJK.Name = "cmbJK"
        Me.cmbJK.Size = New System.Drawing.Size(121, 21)
        Me.cmbJK.TabIndex = 9
        '
        'btnSimpan
        '
        Me.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpan.Location = New System.Drawing.Point(376, 274)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(98, 42)
        Me.btnSimpan.TabIndex = 10
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBatal.Location = New System.Drawing.Point(498, 274)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(98, 42)
        Me.btnBatal.TabIndex = 11
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'txtNoKK
        '
        Me.txtNoKK.Location = New System.Drawing.Point(231, 108)
        Me.txtNoKK.Name = "txtNoKK"
        Me.txtNoKK.Size = New System.Drawing.Size(221, 20)
        Me.txtNoKK.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "NOMOR KK"
        '
        'frmTmbhAnggota
        '
        Me.AcceptButton = Me.btnSimpan
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.btnBatal
        Me.ClientSize = New System.Drawing.Size(624, 359)
        Me.Controls.Add(Me.txtNoKK)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.cmbJK)
        Me.Controls.Add(Me.txtGolongan)
        Me.Controls.Add(Me.txtNamaKK)
        Me.Controls.Add(Me.txtIdAnggota)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTmbhAnggota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Tambah Anggota"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtIdAnggota As TextBox
    Friend WithEvents txtNamaKK As TextBox
    Friend WithEvents txtGolongan As TextBox
    Friend WithEvents cmbJK As ComboBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents txtNoKK As TextBox
    Friend WithEvents Label6 As Label
End Class
