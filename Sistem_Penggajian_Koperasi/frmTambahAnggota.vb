Imports System.Data.SqlClient
Imports System.Xml

Public Class frmTmbhAnggota
    Sub noAnggotaOtomatis()
        Dim urtan As String
        Dim hitung, cari As Long

        ambilkoneksi()
        cmd = New SqlCommand("select * from Anggota where Id_anggota in " & "(select max(Id_anggota)from Anggota)", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            urtan = "AGT/" & "00001"
        Else
            cari = Microsoft.VisualBasic.Right(rd.GetString(0), 5)
            If Microsoft.VisualBasic.Left(rd.GetString(0), 4) <> "AGT/" Then
                urtan = "AGT/" & "00001"
            Else
                hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 5) + 1
                urtan = "AGT/" & Microsoft.VisualBasic.Right("00000" & hitung, 5)
            End If
        End If
        rd.Close()
        txtIdAnggota.Text = urtan
        txtIdAnggota.ReadOnly = True
    End Sub
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        cmd = New SqlCommand("select * from Anggota where no_kk = '" & txtNoKK.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            MsgBox("Data Sudah Ada", MsgBoxStyle.Exclamation, "Informasi")
            rd.Close()
            txtIdAnggota.Refresh()
        Else
            rd.Close()
            Try
                If txtGolongan.Text = "" Or txtNamaKK.Text = "" Or txtNoKK.Text = "" Then
                    MsgBox("Pastikan Data yang Belum Terisi", MsgBoxStyle.Exclamation, "Perhatian")
                Else
                    cmd = New SqlCommand("insert into Anggota values('" & txtIdAnggota.Text & "','" & txtNoKK.Text & "','" & txtNamaKK.Text & "','" & cmbJK.Text & "','" & txtGolongan.Text & "')", conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil Ditambah", MsgBoxStyle.Information, "Informasi")
                    'membersihkan isi textBox sebelumnya
                    txtGolongan.Text = ""
                    txtNamaKK.Text = ""
                    txtNoKK.Text = ""
                    cmbJK.Text = ""
                    Me.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub

    Private Sub frmTmbhAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ambilkoneksi()
        noAnggotaOtomatis()
    End Sub
End Class