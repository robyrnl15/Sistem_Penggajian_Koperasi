Imports System.Data.SqlClient
Module ModulKoneksi
    Public conn As SqlConnection
    Public trc As SqlTransaction
    Public cmd As SqlCommand
    Public ds As DataSet
    Public dt As DataTable
    Public adapter As SqlDataAdapter
    Public rd As SqlDataReader
    Public lokasidb As String

    Public Sub ambilkoneksi()
        lokasidb = "Data Source=ROBYRNL\SQLEXPRESS;Initial Catalog=penggajian;Integrated Security=True"
        'lokasidb = "Data Source=192.168.0.1,1433;Initial Catalog=penggajian;Integrated Security=True"
        'lokasidb = "Data Source=192.168.0.1,1433;Initial Catalog=penggajian;User ID='Server Login';Password=k4m4rku5"
        conn = New SqlConnection(lokasidb)

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                'MsgBox("Koneksi biasa", MsgBoxStyle.Information, "Informasi")
            Else
                'MsgBox("Koneksi Gagal", MsgBoxStyle.Exclamation, "Perhatian")
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub
End Module
