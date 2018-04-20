Imports System.Data.SqlClient

Public Class testcrytal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'report.CrystalReportViewer1.SelectionFormula = "{Penggajian.id_transaksi}='" & txtCari.Text & "'"
        report.crReport.RefreshReport()
        report.Show()
    End Sub
End Class