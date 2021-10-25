<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class report
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(report))
        Me.crReport = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crReport
        '
        Me.crReport.ActiveViewIndex = -1
        Me.crReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crReport.Cursor = System.Windows.Forms.Cursors.Default
        Me.crReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crReport.Location = New System.Drawing.Point(0, 0)
        Me.crReport.Name = "crReport"
        Me.crReport.Size = New System.Drawing.Size(939, 429)
        Me.crReport.TabIndex = 0
        Me.crReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 429)
        Me.ControlBox = False
        Me.Controls.Add(Me.crReport)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "report"
        Me.Text = "Bukti Pembayaran Gaji"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crReport As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
