<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class report
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.crReport = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CrystalReport21 = New Sistem_Penggajian_Koperasi.CrystalReport2()
        Me.SuspendLayout()
        '
        'crReport
        '
        Me.crReport.ActiveViewIndex = 0
        Me.crReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crReport.Cursor = System.Windows.Forms.Cursors.Default
        Me.crReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crReport.Location = New System.Drawing.Point(0, 0)
        Me.crReport.Name = "crReport"
        Me.crReport.ReportSource = Me.CrystalReport21
        Me.crReport.Size = New System.Drawing.Size(939, 429)
        Me.crReport.TabIndex = 0
        '
        'report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 429)
        Me.Controls.Add(Me.crReport)
        Me.Name = "report"
        Me.Text = "Bukti Pembayaran Gaji"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crReport As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReport21 As CrystalReport2
End Class
