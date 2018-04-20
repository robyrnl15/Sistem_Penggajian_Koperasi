Imports System.Data.SqlClient
Imports System.Xml

Public Class frmProfile
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If txtCari.Text = "" Then
            MsgBox("Masukkan Nomor KK Terlebih Dahulu", MsgBoxStyle.Exclamation, "Perhatian")

        Else

            cmd = New SqlCommand("select * from Anggota where no_kk ='" & txtCari.Text & "'", conn)

            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows Then
                lblKK.Text = rd.Item("no_kk")
                lblNama.Text = rd.Item("namakk")
                lblKelamin.Text = rd.Item("jk")
                lblGol.Text = rd.Item("tahap")

                rd.Close()
            Else
                rd.Close()
                MsgBox("Data Tidak Ditemukan", MsgBoxStyle.Exclamation, "Perhatian")
                txtCari.Text = ""
                lblKK.Text = "-"
                lblNama.Text = "-"
                lblKelamin.Text = "-"
                lblGol.Text = "-"
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub frmProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ambilkoneksi()
    End Sub
End Class