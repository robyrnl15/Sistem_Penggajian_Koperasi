Imports System.Data.SqlClient
Imports System.Xml

Public Class frmLprnBulanan
    Sub cariData()
        Try
            ambilkoneksi()
            If txtBulan.Text = "" Then
                cmd = New SqlCommand("select * from Gaji", conn)
            Else
                cmd = New SqlCommand("select * from Gaji where Id_gaji = 'GJ/" & txtBulan.Text & "'", conn)
            End If

            adapter = New SqlDataAdapter
            adapter.SelectCommand = cmd
            ds = New DataSet
            adapter.Fill(ds, "Gaji")

            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "Gaji"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Private Sub frmLprnBulanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PenggajianDataSet1.Gaji' table. You can move, or remove it, as needed.
        Me.GajiTableAdapter.Fill(Me.PenggajianDataSet1.Gaji)

    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        cariData()
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        If DataGridView1.RowCount > 0 Then
            'Deklarasi Object
            Dim ApExcel As Object

            'Set sebagai excel  object
            ApExcel = CreateObject("Excel.application")

            'Menyembunyikan proses excel
            ApExcel.Visible = False

            'Membuat/menambah workbook baru
            ApExcel.Workbooks.Add()

            'Lebar Kolom
            ApExcel.Columns(1).ColumnWidth = 15
            ApExcel.Columns(2).ColumnWidth = 20

            'Tulis nama kolom ke excel
            For i As Integer = 1 To DataGridView1.Columns.Count
                ApExcel.Cells(1, i).Value = DataGridView1.Columns(i - 1).Name
            Next

            'Tulis data ke excel
            For r = 0 To DataGridView1.RowCount - 1
                For i As Integer = 1 To DataGridView1.Columns.Count
                    ApExcel.Cells(r + 2, i).Value = DataGridView1.Rows(r).Cells(i - 1).Value
                Next
            Next

            'Membuat Font Bold
            ApExcel.Range("A1:C1").Font.Bold = True

            'Memberi warna backgound
            ApExcel.Range("A1:C1").interior.colorindex = 36

            'Agar nilai cell yang panjang menjadi beberapa baris
            ApExcel.Range("A2:C" & DataGridView1.RowCount + 1).WrapText = True

            'Membuat border hitam
            ApExcel.Range("A1:C" & DataGridView1.RowCount + 1).Borders.Color = RGB(0, 0, 0)

            ApExcel.Visible = True

            ApExcel = Nothing
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class