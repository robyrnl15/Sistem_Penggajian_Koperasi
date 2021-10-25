<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTambahGaji
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTambahGaji))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpGaji = New System.Windows.Forms.DateTimePicker()
        Me.txtGaji = New System.Windows.Forms.TextBox()
        Me.btnTambahGaji = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKodeGaji = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tanggal Gajian"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jumlah Gaji"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(132, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "FORM INPUT GAJI"
        '
        'dtpGaji
        '
        Me.dtpGaji.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpGaji.Location = New System.Drawing.Point(156, 99)
        Me.dtpGaji.Name = "dtpGaji"
        Me.dtpGaji.Size = New System.Drawing.Size(230, 20)
        Me.dtpGaji.TabIndex = 4
        '
        'txtGaji
        '
        Me.txtGaji.Location = New System.Drawing.Point(156, 132)
        Me.txtGaji.Name = "txtGaji"
        Me.txtGaji.Size = New System.Drawing.Size(230, 20)
        Me.txtGaji.TabIndex = 5
        '
        'btnTambahGaji
        '
        Me.btnTambahGaji.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTambahGaji.Location = New System.Drawing.Point(185, 230)
        Me.btnTambahGaji.Name = "btnTambahGaji"
        Me.btnTambahGaji.Size = New System.Drawing.Size(92, 29)
        Me.btnTambahGaji.TabIndex = 6
        Me.btnTambahGaji.Text = "Tambah"
        Me.btnTambahGaji.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBatal.Location = New System.Drawing.Point(294, 230)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(92, 29)
        Me.btnBatal.TabIndex = 7
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Kode Gaji"
        '
        'txtKodeGaji
        '
        Me.txtKodeGaji.Cursor = System.Windows.Forms.Cursors.No
        Me.txtKodeGaji.Location = New System.Drawing.Point(156, 59)
        Me.txtKodeGaji.Name = "txtKodeGaji"
        Me.txtKodeGaji.ReadOnly = True
        Me.txtKodeGaji.Size = New System.Drawing.Size(230, 20)
        Me.txtKodeGaji.TabIndex = 10
        '
        'frmTambahGaji
        '
        Me.AcceptButton = Me.btnTambahGaji
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBatal
        Me.ClientSize = New System.Drawing.Size(442, 282)
        Me.Controls.Add(Me.txtKodeGaji)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnTambahGaji)
        Me.Controls.Add(Me.txtGaji)
        Me.Controls.Add(Me.dtpGaji)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmTambahGaji"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Tambah Gaji"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpGaji As DateTimePicker
    Friend WithEvents txtGaji As TextBox
    Friend WithEvents btnTambahGaji As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtKodeGaji As TextBox
End Class
