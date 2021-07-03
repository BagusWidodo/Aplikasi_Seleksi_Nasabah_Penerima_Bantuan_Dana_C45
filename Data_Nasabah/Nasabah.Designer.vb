<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nasabah
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.t_penghasilan = New System.Windows.Forms.TextBox()
        Me.t_usia = New System.Windows.Forms.TextBox()
        Me.t_alamat = New System.Windows.Forms.TextBox()
        Me.t_nama = New System.Windows.Forms.TextBox()
        Me.t_nik = New System.Windows.Forms.TextBox()
        Me.cb_pekerjaan = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.t_hasil = New System.Windows.Forms.TextBox()
        Me.cb_jumlah = New System.Windows.Forms.ComboBox()
        Me.cb_kredit = New System.Windows.Forms.ComboBox()
        Me.cb_agunan = New System.Windows.Forms.ComboBox()
        Me.cb_adm = New System.Windows.Forms.ComboBox()
        Me.cb_kerja = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIK"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.t_penghasilan)
        Me.GroupBox1.Controls.Add(Me.t_usia)
        Me.GroupBox1.Controls.Add(Me.t_alamat)
        Me.GroupBox1.Controls.Add(Me.t_nama)
        Me.GroupBox1.Controls.Add(Me.t_nik)
        Me.GroupBox1.Controls.Add(Me.cb_pekerjaan)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 243)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATA NASABAH"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(189, 211)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(174, 21)
        Me.DateTimePicker1.TabIndex = 5
        '
        't_penghasilan
        '
        Me.t_penghasilan.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_penghasilan.Location = New System.Drawing.Point(189, 183)
        Me.t_penghasilan.Name = "t_penghasilan"
        Me.t_penghasilan.Size = New System.Drawing.Size(174, 22)
        Me.t_penghasilan.TabIndex = 1
        '
        't_usia
        '
        Me.t_usia.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_usia.Location = New System.Drawing.Point(189, 125)
        Me.t_usia.Name = "t_usia"
        Me.t_usia.Size = New System.Drawing.Size(174, 22)
        Me.t_usia.TabIndex = 1
        '
        't_alamat
        '
        Me.t_alamat.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_alamat.Location = New System.Drawing.Point(189, 96)
        Me.t_alamat.Name = "t_alamat"
        Me.t_alamat.Size = New System.Drawing.Size(174, 22)
        Me.t_alamat.TabIndex = 1
        '
        't_nama
        '
        Me.t_nama.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_nama.Location = New System.Drawing.Point(189, 67)
        Me.t_nama.Name = "t_nama"
        Me.t_nama.Size = New System.Drawing.Size(174, 22)
        Me.t_nama.TabIndex = 1
        '
        't_nik
        '
        Me.t_nik.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_nik.Location = New System.Drawing.Point(189, 38)
        Me.t_nik.Name = "t_nik"
        Me.t_nik.Size = New System.Drawing.Size(174, 22)
        Me.t_nik.TabIndex = 1
        '
        'cb_pekerjaan
        '
        Me.cb_pekerjaan.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_pekerjaan.FormattingEnabled = True
        Me.cb_pekerjaan.Items.AddRange(New Object() {"PNS", "Pegawai Bank", "Karyawan", "TNI", "POLRI"})
        Me.cb_pekerjaan.Location = New System.Drawing.Point(189, 154)
        Me.cb_pekerjaan.Name = "cb_pekerjaan"
        Me.cb_pekerjaan.Size = New System.Drawing.Size(174, 22)
        Me.cb_pekerjaan.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(37, 218)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 14)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Tanggal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(37, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 14)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "PENGHASILAN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 14)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "PEKERJAAN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 14)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "USIA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ALAMAT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "NAMA NASABAH"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.t_hasil)
        Me.GroupBox2.Controls.Add(Me.cb_jumlah)
        Me.GroupBox2.Controls.Add(Me.cb_kredit)
        Me.GroupBox2.Controls.Add(Me.cb_agunan)
        Me.GroupBox2.Controls.Add(Me.cb_adm)
        Me.GroupBox2.Controls.Add(Me.cb_kerja)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(442, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(391, 243)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATA SELEKSI"
        '
        't_hasil
        '
        Me.t_hasil.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_hasil.Location = New System.Drawing.Point(209, 70)
        Me.t_hasil.Name = "t_hasil"
        Me.t_hasil.Size = New System.Drawing.Size(165, 22)
        Me.t_hasil.TabIndex = 1
        '
        'cb_jumlah
        '
        Me.cb_jumlah.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_jumlah.FormattingEnabled = True
        Me.cb_jumlah.Items.AddRange(New Object() {"10.000.000,-", "20.000.000,-", "25.000.000,-", "50.000.000,-", "100.000.000,-"})
        Me.cb_jumlah.Location = New System.Drawing.Point(209, 206)
        Me.cb_jumlah.Name = "cb_jumlah"
        Me.cb_jumlah.Size = New System.Drawing.Size(165, 22)
        Me.cb_jumlah.TabIndex = 1
        '
        'cb_kredit
        '
        Me.cb_kredit.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_kredit.FormattingEnabled = True
        Me.cb_kredit.Items.AddRange(New Object() {"Konsumtif", "Investasi", "Modal kerja"})
        Me.cb_kredit.Location = New System.Drawing.Point(209, 169)
        Me.cb_kredit.Name = "cb_kredit"
        Me.cb_kredit.Size = New System.Drawing.Size(165, 22)
        Me.cb_kredit.TabIndex = 1
        '
        'cb_agunan
        '
        Me.cb_agunan.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_agunan.FormattingEnabled = True
        Me.cb_agunan.Items.AddRange(New Object() {"BPKB Sepeda Motor", "BPKB Mobil", "Surat Tanah", "Sertifikat Rumah"})
        Me.cb_agunan.Location = New System.Drawing.Point(209, 133)
        Me.cb_agunan.Name = "cb_agunan"
        Me.cb_agunan.Size = New System.Drawing.Size(165, 22)
        Me.cb_agunan.TabIndex = 1
        '
        'cb_adm
        '
        Me.cb_adm.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_adm.FormattingEnabled = True
        Me.cb_adm.Items.AddRange(New Object() {"Lengkap", "Tidak Lengkap"})
        Me.cb_adm.Location = New System.Drawing.Point(209, 102)
        Me.cb_adm.Name = "cb_adm"
        Me.cb_adm.Size = New System.Drawing.Size(165, 22)
        Me.cb_adm.TabIndex = 1
        '
        'cb_kerja
        '
        Me.cb_kerja.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_kerja.FormattingEnabled = True
        Me.cb_kerja.Items.AddRange(New Object() {"PNS", "Pegawai Bank", "Karyawan", "TNI", "POLRI"})
        Me.cb_kerja.Location = New System.Drawing.Point(209, 38)
        Me.cb_kerja.Name = "cb_kerja"
        Me.cb_kerja.Size = New System.Drawing.Size(165, 22)
        Me.cb_kerja.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(37, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 14)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "JUMLAH PINJAMAN"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(37, 172)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 14)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "JENIS KREDIT"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(37, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 14)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "AGUNAN"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(37, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(143, 14)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "SYARAT ADMINISTRASI"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(37, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 14)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "PENGHASILAN"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(37, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 14)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "PEKERJAAN"
        '
        'btn_simpan
        '
        Me.btn_simpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_simpan.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.Location = New System.Drawing.Point(18, 274)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(81, 29)
        Me.btn_simpan.TabIndex = 3
        Me.btn_simpan.Text = "SIMPAN"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Location = New System.Drawing.Point(121, 274)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(81, 29)
        Me.btn_edit.TabIndex = 3
        Me.btn_edit.Text = "EDIT"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_hapus.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hapus.Location = New System.Drawing.Point(223, 274)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(81, 29)
        Me.btn_hapus.TabIndex = 3
        Me.btn_hapus.Text = "HAPUS"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_batal
        '
        Me.btn_batal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_batal.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_batal.Location = New System.Drawing.Point(328, 274)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(81, 29)
        Me.btn_batal.TabIndex = 3
        Me.btn_batal.Text = "KELUAR"
        Me.btn_batal.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(18, 319)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(815, 196)
        Me.DGV.TabIndex = 4
        '
        'btn_next
        '
        Me.btn_next.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_next.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next.Location = New System.Drawing.Point(752, 274)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(81, 29)
        Me.btn_next.TabIndex = 3
        Me.btn_next.Text = "NEXT "
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'Nasabah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(849, 562)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.btn_batal)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Nasabah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nasabah"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents t_nik As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents t_usia As System.Windows.Forms.TextBox
    Friend WithEvents t_alamat As System.Windows.Forms.TextBox
    Friend WithEvents t_nama As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_jumlah As System.Windows.Forms.ComboBox
    Friend WithEvents cb_kredit As System.Windows.Forms.ComboBox
    Friend WithEvents cb_agunan As System.Windows.Forms.ComboBox
    Friend WithEvents cb_adm As System.Windows.Forms.ComboBox
    Friend WithEvents cb_kerja As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_hapus As System.Windows.Forms.Button
    Friend WithEvents btn_batal As System.Windows.Forms.Button
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents t_hasil As System.Windows.Forms.TextBox
    Friend WithEvents t_penghasilan As System.Windows.Forms.TextBox
    Friend WithEvents cb_pekerjaan As System.Windows.Forms.ComboBox
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
