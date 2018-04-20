<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUtama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PenggajianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembayaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputGajiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputPotonganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnggotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileAngootaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStrpTambahAnggota = New System.Windows.Forms.ToolStripMenuItem()
        Me.HapusAnggotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPenggajianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GajiBulananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenggajianToolStripMenuItem, Me.AnggotaToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PenggajianToolStripMenuItem
        '
        Me.PenggajianToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PembayaranToolStripMenuItem, Me.InputGajiToolStripMenuItem, Me.InputPotonganToolStripMenuItem})
        Me.PenggajianToolStripMenuItem.Name = "PenggajianToolStripMenuItem"
        Me.PenggajianToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.PenggajianToolStripMenuItem.Text = "&Penggajian"
        '
        'PembayaranToolStripMenuItem
        '
        Me.PembayaranToolStripMenuItem.Name = "PembayaranToolStripMenuItem"
        Me.PembayaranToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.PembayaranToolStripMenuItem.Text = "Pembayaran"
        '
        'InputGajiToolStripMenuItem
        '
        Me.InputGajiToolStripMenuItem.Name = "InputGajiToolStripMenuItem"
        Me.InputGajiToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.InputGajiToolStripMenuItem.Text = "Input Gaji"
        '
        'InputPotonganToolStripMenuItem
        '
        Me.InputPotonganToolStripMenuItem.Name = "InputPotonganToolStripMenuItem"
        Me.InputPotonganToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.InputPotonganToolStripMenuItem.Text = "Input Potongan"
        '
        'AnggotaToolStripMenuItem
        '
        Me.AnggotaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfileAngootaToolStripMenuItem, Me.menuStrpTambahAnggota, Me.HapusAnggotaToolStripMenuItem})
        Me.AnggotaToolStripMenuItem.Name = "AnggotaToolStripMenuItem"
        Me.AnggotaToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.AnggotaToolStripMenuItem.Text = "&Anggota"
        '
        'ProfileAngootaToolStripMenuItem
        '
        Me.ProfileAngootaToolStripMenuItem.Name = "ProfileAngootaToolStripMenuItem"
        Me.ProfileAngootaToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ProfileAngootaToolStripMenuItem.Text = "Profile Angoota"
        '
        'menuStrpTambahAnggota
        '
        Me.menuStrpTambahAnggota.Name = "menuStrpTambahAnggota"
        Me.menuStrpTambahAnggota.Size = New System.Drawing.Size(159, 22)
        Me.menuStrpTambahAnggota.Text = "Tambah Aggota"
        '
        'HapusAnggotaToolStripMenuItem
        '
        Me.HapusAnggotaToolStripMenuItem.Name = "HapusAnggotaToolStripMenuItem"
        Me.HapusAnggotaToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.HapusAnggotaToolStripMenuItem.Text = "Hapus Anggota"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanPenggajianToolStripMenuItem, Me.GajiBulananToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "&Laporan"
        '
        'LaporanPenggajianToolStripMenuItem
        '
        Me.LaporanPenggajianToolStripMenuItem.Name = "LaporanPenggajianToolStripMenuItem"
        Me.LaporanPenggajianToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.LaporanPenggajianToolStripMenuItem.Text = "Pembayaran Gaji"
        '
        'GajiBulananToolStripMenuItem
        '
        Me.GajiBulananToolStripMenuItem.Name = "GajiBulananToolStripMenuItem"
        Me.GajiBulananToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.GajiBulananToolStripMenuItem.Text = "Gaji Perbulan"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahUserToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.KeluarToolStripMenuItem.Text = "&Akun"
        '
        'TambahUserToolStripMenuItem
        '
        Me.TambahUserToolStripMenuItem.Name = "TambahUserToolStripMenuItem"
        Me.TambahUserToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TambahUserToolStripMenuItem.Text = "Tambah User"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'Button7
        '
        Me.Button7.Image = Global.Sistem_Penggajian_Koperasi.My.Resources.Resources.add_user
        Me.Button7.Location = New System.Drawing.Point(585, 524)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(199, 156)
        Me.Button7.TabIndex = 9
        Me.Button7.Text = "Tambah User"
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Image = Global.Sistem_Penggajian_Koperasi.My.Resources.Resources.user
        Me.Button6.Location = New System.Drawing.Point(962, 289)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(199, 156)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Tambah Anggota"
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = Global.Sistem_Penggajian_Koperasi.My.Resources.Resources.analytics
        Me.Button5.Location = New System.Drawing.Point(585, 289)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(199, 156)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Laporan Gaji Perbulan"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = Global.Sistem_Penggajian_Koperasi.My.Resources.Resources.bill1
        Me.Button4.Location = New System.Drawing.Point(187, 289)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(199, 156)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Laporan Pembayaran Gaji"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.Sistem_Penggajian_Koperasi.My.Resources.Resources.tax
        Me.Button3.Location = New System.Drawing.Point(962, 83)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(199, 156)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Input Potongan"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.Sistem_Penggajian_Koperasi.My.Resources.Resources.insert_coin
        Me.Button2.Location = New System.Drawing.Point(585, 83)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(199, 156)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Input Gaji"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.Sistem_Penggajian_Koperasi.My.Resources.Resources.receipt
        Me.Button1.Location = New System.Drawing.Point(187, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(199, 156)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Pembayaran Gaji"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistem Penggajian Koperasi"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PenggajianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PembayaranToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InputGajiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnggotaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfileAngootaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuStrpTambahAnggota As ToolStripMenuItem
    Friend WithEvents HapusAnggotaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanPenggajianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GajiBulananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents InputPotonganToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
End Class
