Public Class frmUtama
    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click

    End Sub

    Private Sub LaporanPenggajianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPenggajianToolStripMenuItem.Click
        frmLaporanGaji.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub InputGajiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputGajiToolStripMenuItem.Click
        frmTambahGaji.Show()
    End Sub

    Private Sub GajiBulananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GajiBulananToolStripMenuItem.Click
        frmLprnBulanan.Show()
    End Sub

    Private Sub ProfileAngootaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfileAngootaToolStripMenuItem.Click
        frmProfile.Show()
    End Sub

    Private Sub TambahAggotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuStrpTambahAnggota.Click
        frmTmbhAnggota.Show()
    End Sub

    Private Sub HapusAnggotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HapusAnggotaToolStripMenuItem.Click
        frmHapusAnggota.Show()
    End Sub

    Private Sub InputPotonganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputPotonganToolStripMenuItem.Click
        frmInputPotongan.Show()
    End Sub

    Private Sub PembayaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembayaranToolStripMenuItem.Click
        frmTransaksi.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmTransaksi.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmTambahGaji.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmInputPotongan.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmLaporanGaji.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        frmLprnBulanan.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        frmTmbhAnggota.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        frmTambahUser.Show()
    End Sub

    Private Sub TambahUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahUserToolStripMenuItem.Click
        frmTambahUser.Show()
    End Sub
End Class
