Imports System.Data.SqlClient
Imports System.Xml

Public Class frmTambahGaji
    'membuatkode gaji otomatis
    Sub kodeGaji()
        Dim urutan As String
        Dim hitung, cari As Long

        ambilkoneksi()
        cmd = New SqlCommand("select * from Gaji where Id_gaji in " & "(select max(Id_gaji)from Gaji)", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            urutan = "GJ/" & Date.Now.Month & "/" & Date.Now.Year
        End If
        rd.Close()
        txtKodeGaji.Text = urutan
    End Sub
    Private Sub btnTambahGaji_Click(sender As Object, e As EventArgs) Handles btnTambahGaji.Click
        cmd = New SqlCommand("select * from Gaji where Id_gaji ='" & txtGaji.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If txtGaji.Text = "" Then
            rd.Close()
            MsgBox("Perhatikan Data yang Belum Terisi", MsgBoxStyle.Exclamation, "Perhatian")
        Else
            rd.Close()
            Try
                cmd = New SqlCommand("insert into Gaji values('" & txtKodeGaji.Text & "','" & dtpGaji.Value & "','" & txtGaji.Text & "')", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Ditambah", MsgBoxStyle.Information, "Informasi")

                Me.Close()

            Catch ex As Exception
                MsgBox("Data Sudah Ada", MsgBoxStyle.Exclamation, "Informasi")
            End Try


        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub frmTambahGaji_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ambilkoneksi()
        Call kodeGaji()
    End Sub

    Private Sub dtpGaji_ValueChanged(sender As Object, e As EventArgs) Handles dtpGaji.ValueChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub
End Class