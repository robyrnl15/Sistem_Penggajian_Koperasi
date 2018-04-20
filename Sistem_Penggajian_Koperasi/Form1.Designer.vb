<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PenggajianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnggotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileAngootaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahAggotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HapusAnggotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembayaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputGajiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPenggajianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GajiBulananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pict1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pict1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenggajianToolStripMenuItem, Me.AnggotaToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1172, 35)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PenggajianToolStripMenuItem
        '
        Me.PenggajianToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PembayaranToolStripMenuItem, Me.InputGajiToolStripMenuItem})
        Me.PenggajianToolStripMenuItem.Name = "PenggajianToolStripMenuItem"
        Me.PenggajianToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.PenggajianToolStripMenuItem.Text = "&Penggajian"
        '
        'AnggotaToolStripMenuItem
        '
        Me.AnggotaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfileAngootaToolStripMenuItem, Me.TambahAggotaToolStripMenuItem, Me.HapusAnggotaToolStripMenuItem})
        Me.AnggotaToolStripMenuItem.Name = "AnggotaToolStripMenuItem"
        Me.AnggotaToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.AnggotaToolStripMenuItem.Text = "&Anggota"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanPenggajianToolStripMenuItem, Me.GajiBulananToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "&Laporan"
        '
        'ProfileAngootaToolStripMenuItem
        '
        Me.ProfileAngootaToolStripMenuItem.Name = "ProfileAngootaToolStripMenuItem"
        Me.ProfileAngootaToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ProfileAngootaToolStripMenuItem.Text = "Profile Angoota"
        '
        'TambahAggotaToolStripMenuItem
        '
        Me.TambahAggotaToolStripMenuItem.Name = "TambahAggotaToolStripMenuItem"
        Me.TambahAggotaToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.TambahAggotaToolStripMenuItem.Text = "Tambah Aggota"
        '
        'HapusAnggotaToolStripMenuItem
        '
        Me.HapusAnggotaToolStripMenuItem.Name = "HapusAnggotaToolStripMenuItem"
        Me.HapusAnggotaToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.HapusAnggotaToolStripMenuItem.Text = "Hapus Anggota"
        '
        'PembayaranToolStripMenuItem
        '
        Me.PembayaranToolStripMenuItem.Name = "PembayaranToolStripMenuItem"
        Me.PembayaranToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PembayaranToolStripMenuItem.Text = "Pembayaran"
        '
        'InputGajiToolStripMenuItem
        '
        Me.InputGajiToolStripMenuItem.Name = "InputGajiToolStripMenuItem"
        Me.InputGajiToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.InputGajiToolStripMenuItem.Text = "Input Gaji"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.KeluarToolStripMenuItem.Text = "&Logout"
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
        Me.GajiBulananToolStripMenuItem.Text = "Gaji Bulanan"
        '
        'pict1
        '
        Me.pict1.Image = Global.Sistem_Penggajian_Koperasi.My.Resources.Resources.DSC_0163_2
        Me.pict1.Location = New System.Drawing.Point(82, 72)
        Me.pict1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pict1.Name = "pict1"
        Me.pict1.Size = New System.Drawing.Size(126, 77)
        Me.pict1.TabIndex = 1
        Me.pict1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 154)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Input Gaji"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1172, 503)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pict1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistem Penggajian Koperasi"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pict1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PenggajianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PembayaranToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InputGajiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnggotaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfileAngootaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahAggotaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HapusAnggotaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanPenggajianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GajiBulananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pict1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
