<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUtamaKaryawan
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
        Me.AnggotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileAnggotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembayaranGajiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GajiPerbulanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnLaporanGajiPerbulan = New System.Windows.Forms.Button()
        Me.btnLaporanTransaksi = New System.Windows.Forms.Button()
        Me.btnTransaksi = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenggajianToolStripMenuItem, Me.AnggotaToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PenggajianToolStripMenuItem
        '
        Me.PenggajianToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PembayaranToolStripMenuItem})
        Me.PenggajianToolStripMenuItem.Name = "PenggajianToolStripMenuItem"
        Me.PenggajianToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.PenggajianToolStripMenuItem.Text = "&Penggajian"
        '
        'PembayaranToolStripMenuItem
        '
        Me.PembayaranToolStripMenuItem.Name = "PembayaranToolStripMenuItem"
        Me.PembayaranToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.PembayaranToolStripMenuItem.Text = "Pembayaran"
        '
        'AnggotaToolStripMenuItem
        '
        Me.AnggotaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfileAnggotaToolStripMenuItem})
        Me.AnggotaToolStripMenuItem.Name = "AnggotaToolStripMenuItem"
        Me.AnggotaToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.AnggotaToolStripMenuItem.Text = "&Anggota"
        '
        'ProfileAnggotaToolStripMenuItem
        '
        Me.ProfileAnggotaToolStripMenuItem.Name = "ProfileAnggotaToolStripMenuItem"
        Me.ProfileAnggotaToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ProfileAnggotaToolStripMenuItem.Text = "Profile Anggota"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PembayaranGajiToolStripMenuItem, Me.GajiPerbulanToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "&Laporan"
        '
        'PembayaranGajiToolStripMenuItem
        '
        Me.PembayaranGajiToolStripMenuItem.Name = "PembayaranGajiToolStripMenuItem"
        Me.PembayaranGajiToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.PembayaranGajiToolStripMenuItem.Text = "Pembayaran Gaji"
        '
        'GajiPerbulanToolStripMenuItem
        '
        Me.GajiPerbulanToolStripMenuItem.Name = "GajiPerbulanToolStripMenuItem"
        Me.GajiPerbulanToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.GajiPerbulanToolStripMenuItem.Text = "Gaji Perbulan"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'btnProfile
        '
        Me.btnProfile.Image = Global.Sistem_Penggajian_Koperasi.My.Resources.Resources.user__1_
        Me.btnProfile.Location = New System.Drawing.Point(784, 463)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(199, 156)
        Me.btnProfile.TabIndex = 11
        Me.btnProfile.Text = "Profile Anggota"
        Me.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnProfile.UseVisualStyleBackColor = True
        '
        'btnLaporanGajiPerbulan
        '
        Me.btnLaporanGajiPerbulan.Image = Global.Sistem_Penggajian_Koperasi.My.Resources.Resources.analytics
        Me.btnLaporanGajiPerbulan.Location = New System.Drawing.Point(784, 193)
        Me.btnLaporanGajiPerbulan.Name = "btnLaporanGajiPerbulan"
        Me.btnLaporanGajiPerbulan.Size = New System.Drawing.Size(199, 156)
        Me.btnLaporanGajiPerbulan.TabIndex = 10
        Me.btnLaporanGajiPerbulan.Text = "Laporan Gaji Perbulan"
        Me.btnLaporanGajiPerbulan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLaporanGajiPerbulan.UseVisualStyleBackColor = True
        '
        'btnLaporanTransaksi
        '
        Me.btnLaporanTransaksi.Image = Global.Sistem_Penggajian_Koperasi.My.Resources.Resources.bill1
        Me.btnLaporanTransaksi.Location = New System.Drawing.Point(387, 463)
        Me.btnLaporanTransaksi.Name = "btnLaporanTransaksi"
        Me.btnLaporanTransaksi.Size = New System.Drawing.Size(199, 156)
        Me.btnLaporanTransaksi.TabIndex = 9
        Me.btnLaporanTransaksi.Text = "Laporan Pembayaran Gaji"
        Me.btnLaporanTransaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLaporanTransaksi.UseVisualStyleBackColor = True
        '
        'btnTransaksi
        '
        Me.btnTransaksi.Image = Global.Sistem_Penggajian_Koperasi.My.Resources.Resources.receipt
        Me.btnTransaksi.Location = New System.Drawing.Point(387, 193)
        Me.btnTransaksi.Name = "btnTransaksi"
        Me.btnTransaksi.Size = New System.Drawing.Size(199, 156)
        Me.btnTransaksi.TabIndex = 8
        Me.btnTransaksi.Text = "Pembayaran Gaji"
        Me.btnTransaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnTransaksi.UseVisualStyleBackColor = True
        '
        'frmUtamaKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.btnProfile)
        Me.Controls.Add(Me.btnLaporanGajiPerbulan)
        Me.Controls.Add(Me.btnLaporanTransaksi)
        Me.Controls.Add(Me.btnTransaksi)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmUtamaKaryawan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmUtamaKaryawan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PenggajianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PembayaranToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnggotaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfileAnggotaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PembayaranGajiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GajiPerbulanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnLaporanGajiPerbulan As Button
    Friend WithEvents btnLaporanTransaksi As Button
    Friend WithEvents btnTransaksi As Button
    Friend WithEvents btnProfile As Button
End Class
