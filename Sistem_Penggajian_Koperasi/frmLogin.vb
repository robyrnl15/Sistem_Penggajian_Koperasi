Imports System.Data.SqlClient
Imports System.Xml

Public Class frmLogin
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        End
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Perhatikan Data yang Belum Terisi", MsgBoxStyle.Exclamation, "Perhatian")
        Else
            cmd = New SqlCommand("select * from Admin where username = '" & txtUsername.Text & "' and pas = '" & txtPassword.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows Then
                If rd.Item("status").ToString = "Admin" Or rd.Item("status").ToString = "Kepala" Then
                    frmUtama.Show()
                    Me.Hide()
                    rd.Close()
                ElseIf rd.Item("status").ToString = "Karyawan" Then
                    frmUtamaKaryawan.Show()
                    Me.Hide()
                    rd.Close()
                End If
            Else
                rd.Close()
                MsgBox("Username atau Password Tidak Benar", MsgBoxStyle.Exclamation, "Perhatian")
            End If
            txtUsername.Text = ""
            txtPassword.Text = ""


        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ambilkoneksi()
    End Sub


End Class