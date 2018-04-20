Imports System.Data.SqlClient
Imports System.Xml

Public Class frmTambahUser
    Sub kodeUser()
        Dim urtan As String
        Dim hitung, cari As Long

        ambilkoneksi()
        cmd = New SqlCommand("select * from Admin where Id_admin in " & "(select max(Id_admin)from Admin)", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            urtan = "USER/" & "00001"
        Else
            cari = Microsoft.VisualBasic.Right(rd.GetString(0), 5)
            If Microsoft.VisualBasic.Left(rd.GetString(0), 5) <> "USER/" Then
                urtan = "USER/" & "00001"
            Else
                hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 5) + 1
                urtan = "USER/" & Microsoft.VisualBasic.Right("00000" & hitung, 5)
            End If
        End If
        rd.Close()
        txtId.Text = urtan
    End Sub
    Private Sub frmTambahUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ambilkoneksi()
        kodeUser()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Data Sudah Benar?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If txtNama.Text = "" Or txtNoHp.Text = "" Or txtKodeBlok.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Or cmbStatus.Text = "" Then
            MsgBox("Pastikan Semua Data Sudah Terisi dengan Benar", MsgBoxStyle.Exclamation, "Perhatian")
        Else
            cmd = New SqlCommand("select * from Admin where Id_admin = '" & txtId.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                MsgBox("Data Sudah Ada", MsgBoxStyle.Exclamation, "Informasi")
                rd.Close()
            Else
                rd.Close()
                If result = DialogResult.Yes Then
                    cmd = New SqlCommand("insert into Admin values('" & txtId.Text & "','" & txtUsername.Text & "','" & txtPassword.Text & "','" & txtNamaKoperasi.Text & "','" & txtNama.Text & "','" & txtKodeBlok.Text & "','" & txtNoHp.Text & "','" & cmbStatus.SelectedItem & "')", conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil Ditambahkan", MsgBoxStyle.Information, "Informasi")
                    'Me.Close()
                    txtId.ResetText()
                    Me.Close()
                End If
            End If
            End If
    End Sub


End Class