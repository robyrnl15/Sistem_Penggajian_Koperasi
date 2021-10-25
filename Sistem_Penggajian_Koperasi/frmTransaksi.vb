Imports System.Data.SqlClient
Imports System.Xml

Public Class frmTransaksi
    Sub HitungSelesai()
        txtJmlhPotongan.ReadOnly = True
        txtNamaAnggota.ReadOnly = True
        txtNamaPotongan.ReadOnly = True
        txtGajiKotor.ReadOnly = True
        cmbAdmin.Enabled = False
        cmbKodePotongan.Enabled = False
        cmbNoAnggota.Enabled = False
        cmbKodeGaji.Enabled = False
        ListView1.Enabled = False
        btnCancel.Enabled = False
        btnHapus.Enabled = False

        btnTambahPotongan.Enabled = False
        btnSelesai.Enabled = True

    End Sub
    Sub simpan()
        ambilkoneksi()
        If txtGajiBersih.Text = "" And cmbNoAnggota.Text = "" And cmbAdmin.Text = "" Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.Information, "Informasi")
        Else
            cmd = New SqlCommand("insert into Penggajian (id_transaksi,Id_anggota,Id_admin,tgl_gajian,Id_gaji,gaji_bersih) values('" & txtNotransaksi.Text & "','" & cmbNoAnggota.Text & "','" & cmbAdmin.Text & "','" & dtpGajianTransaksi.Value & "','" & cmbKodeGaji.Text & "','" & txtGajiBersih.Text & "')", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Ditambah", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub
    'menampilkan no transaksi secara otomatis
    Sub noTransaksi()
        Dim urtan As String
        Dim hitung, cari As Long

        ambilkoneksi()
        cmd = New SqlCommand("select * from Penggajian where id_transaksi in " & "(select max(id_transaksi)from Penggajian)", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            urtan = "KSU/" & Date.Now.Year & "/" & "0000000001"
        Else
            cari = Microsoft.VisualBasic.Right(rd.GetString(0), 10)
            If Microsoft.VisualBasic.Left(rd.GetString(0), 9) <> "KSU/" & Date.Now.Year & "/" Then
                urtan = "KSU/" & Date.Now.Year & "/" & "0000000001"
            Else
                hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 10) + 1
                urtan = "KSU/" & Date.Now.Year & "/" & Microsoft.VisualBasic.Right("0000000000" & hitung, 10)
            End If
        End If
        rd.Close()
        txtNotransaksi.Text = urtan
    End Sub
    'menampilkan kode admin
    Sub tampilKodeAdmin()
        Call ambilkoneksi()
        cmd = New SqlClient.SqlCommand("select * from Admin", conn)
        rd = cmd.ExecuteReader()
        If rd.HasRows Then
            While rd.Read()
                cmbAdmin.Items.Add(rd.Item("Id_admin"))
            End While
            rd.Close()
        End If
    End Sub
    'fungsi menampilkan kode gaji ke combobox
    Sub tampilKodeGajiCmb()
        Call ambilkoneksi()
        cmd = New SqlClient.SqlCommand("select * from Gaji", conn)
        rd = cmd.ExecuteReader()
        If rd.HasRows Then
            While rd.Read()
                cmbKodeGaji.Items.Add(rd.Item("Id_gaji"))
            End While
            rd.Close()
        End If
    End Sub
    Sub totalPotongan()
        Dim total, hasil As Integer

        For i As Integer = 0 To ListView1.Items.Count - 1
            total = total + ListView1.Items(i).SubItems(3).Text
        Next
        txtTTLPotongan.Text = total
        hasil = txtGajiKotor.Text - txtTTLPotongan.Text

        'Dim hasil As String
        'Call ambilkoneksi()
        'cmd = New SqlCommand("SELECT SUM(jumlah) as jumlah_potongan FROM detail_potongan WHERE id_transaksi = '" & txtNotransaksi.Text & "'", conn)
        'rd = cmd.ExecuteReader
        'rd.Read()
        'If rd.HasRows Then
        '    txtTTLPotongan.Text = rd.Item("jumlah_potongan")
        '    rd.Close()
        '    hasil = txtGajiKotor.Text - txtTTLPotongan.Text
        If hasil < 0 Then
            txtGajiBersih.Text = "0"
        Else
            txtGajiBersih.Text = hasil
        End If
        btnCtkSimpan.Enabled = True
        'End If

    End Sub
    'menampilkan gaji ke text box
    Sub tampilGaji()
        Call ambilkoneksi()
        cmd = New SqlClient.SqlCommand("select * from Gaji where Id_gaji ='" & cmbKodeGaji.Text & "'", conn)
        rd = cmd.ExecuteReader()
        rd.Read()
        If rd.HasRows Then
            txtGajiKotor.Text = rd.Item("jlh_Gaji")
        End If
        rd.Close()
    End Sub
    'prosedur untuk menampilkan kode anggota pada combobox
    Sub tampilKodeAnggota()
        Call ambilkoneksi()
        cmd = New SqlClient.SqlCommand("select * from Anggota", conn)
        rd = cmd.ExecuteReader()
        If rd.HasRows Then
            While rd.Read()
                cmbNoAnggota.Items.Add(rd.Item("Id_anggota"))
            End While
            rd.Close()

        End If
    End Sub
    'prosedur untuk menampilkan nama anggota pada textbox
    Sub tampilNama()
        Call ambilkoneksi()
        cmd = New SqlClient.SqlCommand("select * from Anggota where Id_anggota = '" & cmbNoAnggota.Text & "'", conn)
        rd = cmd.ExecuteReader()
        rd.Read()
        If rd.HasRows Then
            txtNamaAnggota.Text = rd.Item("namakk")
        End If
        rd.Close()
    End Sub
    Sub tampilCmbKodePotongan()
        Call ambilkoneksi()
        cmd = New SqlClient.SqlCommand("select * from Potongan", conn)
        rd = cmd.ExecuteReader()
        If rd.HasRows Then
            While rd.Read()
                cmbKodePotongan.Items.Add(rd.Item("Id_potongan"))
            End While
            rd.Close()
        End If
    End Sub
    Private Sub frmTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilKodeGajiCmb()
        Call tampilKodeAnggota()
        Call tampilCmbKodePotongan()
        Call noTransaksi()
        Call tampilKodeAdmin()
        txtJmlhPotongan.Enabled = True
        txtNamaPotongan.Enabled = True
        cmbKodePotongan.Enabled = True

        btnSelesai.Enabled = False

    End Sub

    Private Sub cmbNoAnggota_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNoAnggota.SelectedIndexChanged
        Call tampilNama()
    End Sub

    Private Sub cmbKodeGaji_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKodeGaji.SelectedIndexChanged
        Call tampilGaji()
    End Sub
    'button cancel
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub cmbKodePotongan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKodePotongan.SelectedIndexChanged
        'Call tampilNamadanJlhpotongan()
        Call ambilkoneksi()
        cmd = New SqlCommand("select * from Potongan where Id_potongan = '" & cmbKodePotongan.Text & "'", conn)
        rd = cmd.ExecuteReader()
        rd.Read()
        If rd.HasRows Then
            txtNamaPotongan.Text = rd.Item("nama_potongan")
            txtJmlhPotongan.Text = rd.Item("jlh_potongan")
        End If
        rd.Close()
    End Sub
    'fungsi untuk memasukkan kedalam lsitview
    Private Sub btnTambahPotongan_Click(sender As Object, e As EventArgs) Handles btnTambahPotongan.Click
        Dim lvi As ListViewItem
        lvi = ListView1.Items.Add(cmbKodePotongan.Text)
        lvi.SubItems.Add(txtNotransaksi.Text)
        lvi.SubItems.Add(txtNamaPotongan.Text)
        lvi.SubItems.Add(txtJmlhPotongan.Text)

        cmbKodePotongan.ResetText()
        txtNamaPotongan.Clear()
        txtJmlhPotongan.Clear()
        btnSelesai.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If ListView1.Items.Count <> 0 Then
            ListView1.Items.Remove(ListView1.SelectedItems(0))
        Else
            MsgBox("Mohon Pilih Data yang Akan Dihapus")
        End If
        'ListView1.Items.Remove()
    End Sub

    'Private Sub btnHitungPotongan_Click(sender As Object, e As EventArgs) Handles btnHitungPotongan.Click
    '    Call totalPotongan()
    '    Call HitungSelesai()
    'End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        If txtNamaAnggota.Text = "" Or cmbNoAnggota.Text = "" Or cmbAdmin.Text = "" Then
            MsgBox("Pastikan Data Sudah Lengkap", MsgBoxStyle.Exclamation, "Perhatian")
        Else
            Dim result As DialogResult = MessageBox.Show("Apakah Data sudah Benar?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Try
                    ambilkoneksi()
                    totalPotongan()
                    trc = conn.BeginTransaction()

                    For i As Integer = 0 To ListView1.Items.Count - 1
                        With cmd
                            .Parameters.Clear()
                            .Parameters.AddWithValue("@kode_potongan", ListView1.Items(i).Text)
                            .Parameters.AddWithValue("@no_transaksi", ListView1.Items(i).SubItems(1).Text)
                            .Parameters.AddWithValue("@nama_potongan", ListView1.Items(i).SubItems(2).Text)
                            .Parameters.AddWithValue("@jlh_potongan", ListView1.Items(i).SubItems(3).Text)
                            cmd.CommandText = "INSERT INTO detail_potongan VALUES(@kode_potongan,@no_transaksi," & txtTTLPotongan.Text & ")"
                            cmd.ExecuteNonQuery()
                        End With
                    Next
                    trc.Commit()
                Catch ex As Exception
                    trc.Rollback()
                    MsgBox(ex.Message)
                End Try
                HitungSelesai()
                btnSelesai.Enabled = False
            Else
                MsgBox("Perhatikan Data yang Masih Kosong", MsgBoxStyle.Information, "Perhatian")
            End If
        End If
    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
    '    Dim result As DialogResult = MessageBox.Show("Apakah Data sudah Benar?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    '    If result = DialogResult.Yes And txtNamaAnggota.Text <> "" Or cmbAdmin.Text <> "" Or txtGajiKotor.Text <> "" Then
    '        Try
    '            ambilkoneksi()
    '            totalPotongan()
    '            trc = conn.BeginTransaction()

    '            For i As Integer = 0 To ListView1.Items.Count - 1
    '                With cmd
    '                    .Parameters.Clear()
    '                    .Parameters.AddWithValue("@kode_potongan", ListView1.Items(i).Text)
    '                    .Parameters.AddWithValue("@no_transaksi", ListView1.Items(i).SubItems(1).Text)
    '                    .Parameters.AddWithValue("@nama_potongan", ListView1.Items(i).SubItems(2).Text)
    '                    .Parameters.AddWithValue("@jlh_potongan", ListView1.Items(i).SubItems(3).Text)
    '                    cmd.CommandText = "INSERT INTO detail_potongan VALUES(@kode_potongan,@no_transaksi," & txtTTLPotongan.Text & ")"
    '                    cmd.ExecuteNonQuery()
    '                End With
    '            Next
    '            trc.Commit()
    '        Catch ex As Exception
    '            trc.Rollback()
    '            MsgBox(ex.Message)
    '        End Try
    '        HitungSelesai()
    '        btnSelesai.Enabled = False
    '    Else
    '        MsgBox("Perhatikan Data yang Masih Kosong", MsgBoxStyle.Information, "Perhatian")
    '    End If
    'End Sub

    Private Sub btnCtkSimpan_Click(sender As Object, e As EventArgs) Handles btnCtkSimpan.Click
        If txtGajiBersih.Text = "" And txtNamaAnggota.Text = "" Then
            MsgBox("Perhatikan Data yang Belum Terisi", MsgBoxStyle.Exclamation, "Perhatian")
        Else
            simpan()
            report.crReport.RefreshReport()
            'report.crReport.Refresh()
            report.Show()
            btnCancel.Enabled = False
            Me.Close()
        End If
    End Sub

    Private Sub txtNamaAnggota_TextChanged(sender As Object, e As EventArgs) Handles txtNamaAnggota.TextChanged

    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    Call totalPotongan()
    'End Sub
End Class