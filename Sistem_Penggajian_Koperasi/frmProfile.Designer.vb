<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProfile))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblKK = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblKelamin = New System.Windows.Forms.Label()
        Me.lblGol = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(194, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PROFILE ANGGOTA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nomor Kartu Keluarga"
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(227, 77)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(122, 20)
        Me.txtCari.TabIndex = 2
        '
        'btnCari
        '
        Me.btnCari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCari.Location = New System.Drawing.Point(372, 75)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 23)
        Me.btnCari.TabIndex = 3
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "NO KK"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "NAMA KEPALA KELUARGA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "JENIS KELAMIN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 295)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "GOLONGAN TAHAP"
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(456, 331)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "OK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblKK
        '
        Me.lblKK.AutoSize = True
        Me.lblKK.Location = New System.Drawing.Point(224, 196)
        Me.lblKK.Name = "lblKK"
        Me.lblKK.Size = New System.Drawing.Size(10, 13)
        Me.lblKK.TabIndex = 10
        Me.lblKK.Text = "-"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(224, 230)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(10, 13)
        Me.lblNama.TabIndex = 11
        Me.lblNama.Text = "-"
        '
        'lblKelamin
        '
        Me.lblKelamin.AutoSize = True
        Me.lblKelamin.Location = New System.Drawing.Point(224, 264)
        Me.lblKelamin.Name = "lblKelamin"
        Me.lblKelamin.Size = New System.Drawing.Size(10, 13)
        Me.lblKelamin.TabIndex = 12
        Me.lblKelamin.Text = "-"
        '
        'lblGol
        '
        Me.lblGol.AutoSize = True
        Me.lblGol.Location = New System.Drawing.Point(224, 295)
        Me.lblGol.Name = "lblGol"
        Me.lblGol.Size = New System.Drawing.Size(10, 13)
        Me.lblGol.TabIndex = 13
        Me.lblGol.Text = "-"
        '
        'frmProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 375)
        Me.Controls.Add(Me.lblGol)
        Me.Controls.Add(Me.lblKelamin)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.lblKK)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profile Anggota"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnCari As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents lblKK As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblKelamin As Label
    Friend WithEvents lblGol As Label
End Class
