Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine

Public Class report
    Private Sub crReport_Load(sender As Object, e As EventArgs) Handles crReport.Load
        'ambilkoneksi()
        Dim laporan As New ReportDocument

        laporan.Load("CrystalReport1.rpt")
        laporan.SetDatabaseLogon("Server Login", "k4m4rku5")
        crReport.ReportSource = laporan
        crReport.Refresh()
        'crReport.PrintReport()
    End Sub


End Class