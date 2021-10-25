<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTambahUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTambahUser))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNamaKoperasi = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.txtNoHp = New System.Windows.Forms.TextBox()
        Me.txtKodeBlok = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(210, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TAMBAH USER PENGGUNA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Anggota"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "No HP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Kode Blok"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nama"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Status"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNamaKoperasi)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cmbStatus)
        Me.GroupBox1.Controls.Add(Me.txtNoHp)
        Me.GroupBox1.Controls.Add(Me.txtKodeBlok)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNama)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(578, 238)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data User"
        '
        'txtNamaKoperasi
        '
        Me.txtNamaKoperasi.Location = New System.Drawing.Point(137, 97)
        Me.txtNamaKoperasi.Name = "txtNamaKoperasi"
        Me.txtNamaKoperasi.Size = New System.Drawing.Size(176, 20)
        Me.txtNamaKoperasi.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Nama Koperasi"
        '
        'cmbStatus
        '
        Me.cmbStatus.DisplayMember = "3"
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Admin", "Kepala", "Karyawan"})
        Me.cmbStatus.Location = New System.Drawing.Point(137, 197)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(176, 21)
        Me.cmbStatus.TabIndex = 10
        Me.cmbStatus.ValueMember = "3"
        '
        'txtNoHp
        '
        Me.txtNoHp.Location = New System.Drawing.Point(137, 164)
        Me.txtNoHp.Name = "txtNoHp"
        Me.txtNoHp.Size = New System.Drawing.Size(176, 20)
        Me.txtNoHp.TabIndex = 9
        '
        'txtKodeBlok
        '
        Me.txtKodeBlok.Location = New System.Drawing.Point(137, 129)
        Me.txtKodeBlok.Name = "txtKodeBlok"
        Me.txtKodeBlok.Size = New System.Drawing.Size(176, 20)
        Me.txtKodeBlok.TabIndex = 8
        '
        'txtId
        '
        Me.txtId.Cursor = System.Windows.Forms.Cursors.No
        Me.txtId.Location = New System.Drawing.Point(137, 29)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(176, 20)
        Me.txtId.TabIndex = 6
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(137, 65)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(305, 20)
        Me.txtNama.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtPassword)
        Me.GroupBox2.Controls.Add(Me.txtUsername)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(36, 321)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(578, 114)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Akun Login"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(137, 77)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(194, 20)
        Me.txtPassword.TabIndex = 11
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(137, 35)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(194, 20)
        Me.txtUsername.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Password"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Username"
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(419, 455)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(85, 36)
        Me.btnTambah.TabIndex = 8
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(529, 455)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 36)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Batal"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmTambahUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 514)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTambahUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Tambah User"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents txtNoHp As TextBox
    Friend WithEvents txtKodeBlok As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtNamaKoperasi As TextBox
    Friend WithEvents Label9 As Label
End Class
