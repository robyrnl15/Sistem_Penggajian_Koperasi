<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHapusAnggota
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHapusAnggota))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.lblNoKK = New System.Windows.Forms.Label()
        Me.lblGolongan = New System.Windows.Forms.Label()
        Me.lblNamaKK = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(230, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HAPUS ANGGOTA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NO ANGGOTA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NO KK"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "GOLONGAN TAHAP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(67, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "NAMA KEPALA KELUARGA"
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(234, 87)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(139, 20)
        Me.txtCari.TabIndex = 5
        '
        'btnCari
        '
        Me.btnCari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCari.Location = New System.Drawing.Point(407, 87)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 23)
        Me.btnCari.TabIndex = 6
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'lblNoKK
        '
        Me.lblNoKK.AutoSize = True
        Me.lblNoKK.Location = New System.Drawing.Point(231, 160)
        Me.lblNoKK.Name = "lblNoKK"
        Me.lblNoKK.Size = New System.Drawing.Size(10, 13)
        Me.lblNoKK.TabIndex = 7
        Me.lblNoKK.Text = "-"
        '
        'lblGolongan
        '
        Me.lblGolongan.AutoSize = True
        Me.lblGolongan.Location = New System.Drawing.Point(231, 227)
        Me.lblGolongan.Name = "lblGolongan"
        Me.lblGolongan.Size = New System.Drawing.Size(10, 13)
        Me.lblGolongan.TabIndex = 8
        Me.lblGolongan.Text = "-"
        '
        'lblNamaKK
        '
        Me.lblNamaKK.AutoSize = True
        Me.lblNamaKK.Location = New System.Drawing.Point(231, 192)
        Me.lblNamaKK.Name = "lblNamaKK"
        Me.lblNamaKK.Size = New System.Drawing.Size(10, 13)
        Me.lblNamaKK.TabIndex = 9
        Me.lblNamaKK.Text = "-"
        '
        'btnBatal
        '
        Me.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBatal.Location = New System.Drawing.Point(489, 306)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(103, 37)
        Me.btnBatal.TabIndex = 11
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHapus.Location = New System.Drawing.Point(370, 306)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(103, 37)
        Me.btnHapus.TabIndex = 12
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(196, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "AGT/"
        '
        'frmHapusAnggota
        '
        Me.AcceptButton = Me.btnHapus
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBatal
        Me.ClientSize = New System.Drawing.Size(636, 371)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.lblNamaKK)
        Me.Controls.Add(Me.lblGolongan)
        Me.Controls.Add(Me.lblNoKK)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHapusAnggota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Hapus Anggota"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnCari As Button
    Friend WithEvents lblNoKK As Label
    Friend WithEvents lblGolongan As Label
    Friend WithEvents lblNamaKK As Label
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents Label6 As Label
End Class
