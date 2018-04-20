Imports System.Data.SqlClient
Imports System.Xml

Public Class frmHapusAnggota
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If txtCari.Text = "" Then
            MsgBox("Perhatikan Data yang Belum Terisi", MsgBoxStyle.Exclamation, "Perhatian")
        Else
            Try
                cmd = New SqlCommand("select * from Anggota where Id_anggota = 'AGT/" & txtCari.Text & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()

                If rd.HasRows Then
                    lblNoKK.Text = rd.Item("no_kk")
                    lblNamaKK.Text = rd.Item("namakk")
                    lblGolongan.Text = rd.Item("tahap")
                    rd.Close()
                Else
                    rd.Close()
                    MsgBox("Data Tidak Ditemukan", MsgBoxStyle.Exclamation, "Perhatian")
                    lblGolongan.Text = "-"
                    lblNamaKK.Text = "-"
                    lblNoKK.Text = "-"
                    txtCari.Text = ""
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Me.Close()
            End Try
        End If


    End Sub

    Private Sub frmHapusAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ambilkoneksi()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim result As DialogResult = MessageBox.Show("Anda Yakin Ingin Menghapus " & lblNamaKK.Text & "?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            cmd = New SqlCommand("delete from Anggota where no_kk = '" & lblNoKK.Text & "'", conn)
        cmd.ExecuteNonQuery()

            MsgBox("Data Berhasil Dihapus", MsgBoxStyle.Information, "Informasi")
            txtCari.Text = ""
            lblGolongan.Text = "-"
            lblNamaKK.Text = "-"
            lblNoKK.Text = "-"
        End If
    End Sub
End Class