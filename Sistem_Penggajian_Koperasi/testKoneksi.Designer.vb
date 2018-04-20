<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class testKoneksi
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
        Me.btnKonek = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnKonek
        '
        Me.btnKonek.Location = New System.Drawing.Point(80, 104)
        Me.btnKonek.Name = "btnKonek"
        Me.btnKonek.Size = New System.Drawing.Size(131, 71)
        Me.btnKonek.TabIndex = 0
        Me.btnKonek.Text = "Test Koneksi"
        Me.btnKonek.UseVisualStyleBackColor = True
        '
        'testKoneksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnKonek)
        Me.Name = "testKoneksi"
        Me.Text = "testKoneksi"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnKonek As Button
End Class
