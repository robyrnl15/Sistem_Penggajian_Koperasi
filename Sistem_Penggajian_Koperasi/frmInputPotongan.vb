Imports System.Data.SqlClient
Imports System.Xml

Public Class frmInputPotongan
    Sub noPotongan()
        Dim Urutan As String
        Dim Hitung, Cari As Long
        ambilkoneksi()
        cmd = New SqlCommand("select * from Potongan where Id_potongan in" & "(select max(Id_potongan) from Potongan)", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            Urutan = "000001"
        Else
            Cari = rd.GetString(0)
            Hitung = rd.GetValue(0) + 1
            Urutan = Format(Hitung, "000000")
        End If
        rd.Close()
        txtKode.Text = Urutan
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtNama.Text = "" Then
            MsgBox("Pastikan Nama Potongan Sudah Terisi", MsgBoxStyle.Exclamation, "Perhatian")
        Else
            Dim result As DialogResult = MessageBox.Show("Apakah Data Sudah Benar?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Try
                    ambilkoneksi()
                    cmd = New SqlCommand("insert into Potongan values('" & txtKode.Text & "','" & txtNama.Text & "','" & txtJumlah.Text & "')", conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil Ditambah", MsgBoxStyle.Information, "Informasi")
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show("Data Sudah Ada")
                End Try
            End If
        End If
    End Sub

    Private Sub frmInputPotongan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call noPotongan()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub
End Class