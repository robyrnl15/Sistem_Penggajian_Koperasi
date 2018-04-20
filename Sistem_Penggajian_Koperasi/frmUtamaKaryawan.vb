Public Class frmUtamaKaryawan
    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        frmTransaksi.Show()
    End Sub

    Private Sub btnLaporanGajiPerbulan_Click(sender As Object, e As EventArgs) Handles btnLaporanGajiPerbulan.Click
        frmLprnBulanan.Show()
    End Sub

    Private Sub btnLaporanTransaksi_Click(sender As Object, e As EventArgs) Handles btnLaporanTransaksi.Click
        frmLaporanGaji.Show()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        frmProfile.Show()
    End Sub

    Private Sub PembayaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembayaranToolStripMenuItem.Click
        frmTransaksi.Show()
    End Sub

    Private Sub ProfileAnggotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfileAnggotaToolStripMenuItem.Click
        frmProfile.Show()
    End Sub

    Private Sub PembayaranGajiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembayaranGajiToolStripMenuItem.Click
        frmLaporanGaji.Show()
    End Sub

    Private Sub GajiPerbulanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GajiPerbulanToolStripMenuItem.Click
        frmLprnBulanan.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        frmLogin.Show()
        Me.Hide()
    End Sub
End Class