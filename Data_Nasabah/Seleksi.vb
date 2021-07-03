Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Seleksi

    Public Sub Bersih()
        t_nik.Clear()
        t_nama.Clear()
        t_adm.Clear()
        t_agunan.Clear()
        t_pekerjaan.Clear()
        t_penghasilan.Clear()
        t_kredit.Clear()
        t_pinjaman.Clear()
        t_keputusan.Clear()
        t_keterangan.Clear()
        t_nik.Focus()

    End Sub

    Public Sub Nasabah()
        Call Koneksi()
        cmd = New OdbcCommand("SELECT * FROM seleksi_nasabah WHERE NIK ='" & t_nik.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            t_nama.Text = dr.Item("Nama")
            t_pekerjaan.Text = dr.Item("Pekerjaan")
            t_penghasilan.Text = dr.Item("Penghasilan")
            t_adm.Text = dr.Item("Syarat_adm")
            t_agunan.Text = dr.Item("Agunan")
            t_kredit.Text = dr.Item("Jenis_Kredit")
            t_pinjaman.Text = dr.Item("Jumlah_Pinjaman")
            t_keputusan.Text = dr.Item("Keputusan")
            t_keterangan.Text = dr.Item("Keterangan")

        End If
    End Sub

    Public Sub Laporan()
        Call Koneksi()
        Dim Laporan As String
        Laporan = "INSERT INTO laporan (NIK, Nama, Pekerjaan, Penghasilan, Syarat_adm, Agunan, Jenis_Kredit, Jumlah_Pinjaman, Keputusan) VALUES " & _
            "('" & t_nik.Text & "','" & t_nama.Text & "','" & t_pekerjaan.Text & "','" & t_penghasilan.Text & "','" & t_adm.Text & "','" & t_agunan.Text & "','" & t_kredit.Text & "','" & t_pinjaman.Text & "','" & t_keputusan.Text & "')"
        Dim dc As New OdbcCommand(Laporan, conn)
        dc.ExecuteNonQuery()
    End Sub

    Public Sub Rules()
        If t_adm.Text = "Tidak Lengkap" Then
            t_keputusan.Text = "TIDAK LAYAK"
            t_keterangan.Text = "Lengkapi Berkas !!!"
        ElseIf t_adm.Text = "Lengkap" And
            t_agunan.Text = "BPKB Sepeda MotXor" Xor t_agunan.Text = "BPKB Mobil" Xor t_agunan.Text = "Surat Tanah" Xor t_agunan.Text = "Sertifikit Rumah" And
            t_pekerjaan.Text = "PNS" Xor t_pekerjaan.Text = "Pegawai Bank" Xor t_pekerjaan.Text = "Karyawan" Xor t_pekerjaan.Text = "TNI" Xor t_pekerjaan.Text = "POLRI" And
            t_penghasilan.Text <= 2000000 Xor t_penghasilan.Text <= 4000000 Xor t_penghasilan.Text <= 5000000 Xor t_penghasilan.Text >= 7000000 And
            t_kredit.Text = "Konsumtif" Xor t_kredit.Text = "Modal Kerja " And t_pinjaman.Text = 10000000 Then
            t_keputusan.Text = "LAYAK"
        ElseIf t_adm.Text = "Lengkap" And
            t_agunan.Text = "BPKB Sepeda MotXor" Xor t_agunan.Text = "BPKB Mobil" Xor t_agunan.Text = "Surat Tanah" Xor t_agunan.Text = "Sertifikat Rumah" And
            t_pekerjaan.Text = "PNS" Xor t_pekerjaan.Text = "Pegawai Bank" Xor t_pekerjaan.Text = "Karyawan" Xor t_pekerjaan.Text = "TNI" Xor t_pekerjaan.Text = "POLRI" And
            t_penghasilan.Text <= 4000000 Xor t_penghasilan.Text <= 5000000 Xor t_penghasilan.Text >= 7000000 Xor
            t_kredit.Text = "Investasi" Xor t_kredit.Text = "Modal kerja" And
            t_pinjaman.Text = 10000000 Then
            t_keputusan.Text = "LAYAK"
        ElseIf t_adm.Text = "Lengkap" And
            t_agunan.Text = "BPKB Sepeda Motor" And
            t_pekerjaan.Text = "PNS" Xor t_pekerjaan.Text = "Pegawai Bank" Xor t_pekerjaan.Text = "Karyawan" Xor t_pekerjaan.Text = "TNI" Xor t_pekerjaan.Text = "POLRi" And
            t_penghasilan.Text <= 2000000 Xor t_penghasilan.Text <= 4000000 Xor t_penghasilan.Text <= 5000000 Xor t_penghasilan.Text >= 7000000 And
            t_kredit.Text = "Konsumtif" Xor t_kredit.Text = "Investasi" Xor t_kredit.Text = "Modal kerja" And
            t_pinjaman.Text = 20000000 Xor t_pinjaman.Text = 25000000 Xor t_pinjaman.Text = 50000000 Xor t_pinjaman.Text = 100000000 Then
            t_keputusan.Text = "TIDAK LAYAK"
            t_keterangan.Text = "Agunan Harus Diatas " & t_agunan.Text & ""
        ElseIf t_adm.Text = "Lengkap" And
            t_agunan.Text = "BPKB Sepeda Motor" Xor t_agunan.Text = "BPKB Mobil" And
            t_pekerjaan.Text = "PNS" Xor t_pekerjaan.Text = "Pegawai Bank" Xor t_pekerjaan.Text = "Karyawan" Xor t_pekerjaan.Text = "TNI" Xor t_pekerjaan.Text = "POLRi" And
            t_penghasilan.Text <= 2000000 And
            t_kredit.Text = "Konsumtif" Xor t_kredit.Text = "Investasi" Xor t_kredit.Text = "Modal kerja" And
            t_pinjaman.Text = 20000000 Xor t_pinjaman.Text = 25000000 Xor t_pinjaman.Text = 50000000 Xor t_pinjaman.Text = 100000000 Then
            t_keputusan.Text = "TIDAK LAYAK"
            t_keterangan.Text = "Penghasilan Harus Diatas " & t_penghasilan.Text & ""
        ElseIf t_adm.Text = "Lengkap" And
            t_agunan.Text = "BPKB Mobil" Xor t_agunan.Text = "Surat Tanah" Xor t_agunan.Text = "Sertifikat Rumah" And
            t_pekerjaan.Text = "PNS" Xor t_pekerjaan.Text = "Pegawai Bank" Xor t_pekerjaan.Text = "Karyawan" Xor t_pekerjaan.Text = "TNI" Xor t_pekerjaan.Text = "POLRi" And
            t_penghasilan.Text <= 4000000 Xor t_penghasilan.Text <= 5000000 Xor t_penghasilan.Text >= 7000000 And
            t_kredit.Text = "Konsumtif" Xor t_kredit.Text = "Modal kerja" And
            t_pinjaman.Text = 10000000 Xor t_pinjaman.Text = 20000000 Then
            t_keputusan.Text = "LAYAK"
        ElseIf t_adm.Text = "Lengkap" And
            t_agunan.Text = "BPKB Mobil" Xor t_agunan.Text = "Surat Tanah" Xor t_agunan.Text = "Sertifikat Rumah" And
            t_pekerjaan.Text = "PNS" Xor t_pekerjaan.Text = "Pegawai Bank" Xor t_pekerjaan.Text = "Karyawan" Xor t_pekerjaan.Text = "TNI" Xor t_pekerjaan.Text = "POLRi" And
            t_penghasilan.Text <= 5000000 Xor t_penghasilan.Text >= 7000000 And
            t_kredit.Text = "Konsumtif" Xor t_kredit.Text = "Modal kerja" And
            t_pinjaman.Text = 10000000 Xor t_pinjaman.Text = 20000000 Xor t_pinjaman.Text = 25000000 Then
            t_keputusan.Text = "LAYAK"
        ElseIf t_adm.Text = "Lengkap" And
            t_agunan.Text = "Surat Tanah" And
            t_pekerjaan.Text = "PNS" Xor t_pekerjaan.Text = "Pegawai Bank" Xor t_pekerjaan.Text = "Karyawan" Xor t_pekerjaan.Text = "TNI" Xor t_pekerjaan.Text = "POLRi" And
            t_penghasilan.Text <= 2000000 Xor t_penghasilan.Text <= 4000000 Xor t_penghasilan.Text <= 5000000 And
            t_kredit.Text = "Konsumtif" Xor t_kredit.Text = "Investasi" Xor t_kredit.Text = "Modal kerja" And
            t_pinjaman.Text = 50000000 Then
            t_keputusan.Text = "TIDAK LAYAK"
            t_keterangan.Text = "Penghasilan Harus Diatas " & t_penghasilan.Text & ""
        ElseIf t_adm.Text = "Lengkap" And
            t_agunan.Text = "Surat Tanah" Xor t_agunan.Text = "Sertifikat Rumah" And
            t_pekerjaan.Text = "PNS" Xor t_pekerjaan.Text = "Pegawai Bank" Xor t_pekerjaan.Text = "Karyawan" Xor t_pekerjaan.Text = "TNI" Xor t_pekerjaan.Text = "POLRi" And
            t_penghasilan.Text <= 5000000 Xor t_penghasilan.Text >= 7000000 And
            t_kredit.Text = "Konsumtif" Xor t_kredit.Text = "Investasi" Xor t_kredit.Text = "Modal kerja" And
            t_pinjaman.Text = 50000000 Xor t_pinjaman.Text = 100000000 Then
            t_keputusan.Text = "LAYAK"
        ElseIf t_adm.Text = "Lengkap" And
            t_agunan.Text = "Surat Tanah" Xor t_agunan.Text = "Sertifikat Rumah" And
            t_pekerjaan.Text = "PNS" Xor t_pekerjaan.Text = "Pegawai Bank" Xor t_pekerjaan.Text = "Karyawan" Xor t_pekerjaan.Text = "TNI" Xor t_pekerjaan.Text = "POLRi" And
            t_penghasilan.Text >= 7000000 And
            t_kredit.Text = "Konsumtif" Xor t_kredit.Text = "Investasi" Xor t_kredit.Text = "Modal kerja" And
            t_pinjaman.Text = 10000000 Xor t_pinjaman.Text = 20000000 Xor t_pinjaman.Text = 25000000 Xor t_pinjaman.Text = 50000000 Xor t_pinjaman.Text = 100000000 Then
            t_keputusan.Text = "LAYAK"
        ElseIf t_adm.Text = "Lengkap" Then
        Else
            t_keputusan.Text = "Rules Tidak Ada"
            t_keterangan.Text = "Perbaiki Rules"
        End If
    End Sub

    Private Sub t_nik_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles t_nik.KeyPress
        Call Nasabah()
    End Sub

    Private Sub t_proses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t_proses.Click
        Call Rules()

    End Sub

    Private Sub btn_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_batal.Click
        Dim Keluar As String
        Keluar = MessageBox.Show("Keluar?", "DATA NASABAH", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If vbYes Then
            Menu_Utama.Enabled = True
            Me.Hide()
        End If
    End Sub

    Private Sub btn_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan.Click
        Call Koneksi()
        Dim Simpan As String
        Simpan = "UPDATE seleksi_nasabah SET Nama='" & t_nama.Text & "', Pekerjaan='" & t_pekerjaan.Text & "', Penghasilan='" & t_penghasilan.Text & "'," & _
            "Syarat_adm='" & t_adm.Text & "', Agunan='" & t_agunan.Text & "', Jenis_Kredit='" & t_kredit.Text & "', Jumlah_Pinjaman='" & t_pinjaman.Text & "',Keputusan='" & t_keputusan.Text & "', Keterangan='" & t_keterangan.Text & "' WHERE NIK='" & t_nik.Text & "'"
        Dim dc As New OdbcCommand(Simpan, conn)
        dc.ExecuteNonQuery()
        MsgBox("Data Telah Disimpan", MsgBoxStyle.Information, "SELEKSI NASABAH")
        Call Laporan()

        Call Bersih()

    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        Call Koneksi()
        Dim Edit As String
        Edit = "UPDATE seleksi_nasabah SET Nama='" & t_nama.Text & "', Pekerjaan='" & t_pekerjaan.Text & "', Penghasilan='" & t_penghasilan.Text & "'," & _
            "Syarat_adm='" & t_adm.Text & "', Agunan='" & t_agunan.Text & "', Jenis_Kredit='" & t_kredit.Text & "', Jumlah_Pinjaman='" & t_pinjaman.Text & "', Keterangan='" & t_keterangan.Text & "' WHERE NIK='" & t_nik.Text & "'"
        Dim dc As New OdbcCommand(Edit, conn)
        dc.ExecuteNonQuery()
        MsgBox("Data Telah Disimpan", MsgBoxStyle.Information, "SELEKSI NASABAH")

        Call Bersih()
    End Sub

    Private Sub btn_hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_hapus.Click
        Call Koneksi()
        Dim Hapus As String
        Hapus = "DELETE FROM seleksi_nasabah WHERE NIK='" & t_nik.Text & "'"
        MessageBox.Show("Hapus Data Dengan NIK " & t_nik.Text & "", "SELEKSI NASABAH", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If MsgBoxResult.Yes Then
            Dim dc As New OdbcCommand(Hapus, conn)
            dc.ExecuteNonQuery()
        End If
        MsgBox("Data Telah Terhapus", MsgBoxStyle.Information, "SELEKSI NASABAH")

        Call Bersih()
    End Sub

End Class