Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Nasabah

    Sub EditNasabah()
        Dim Edit As String
        Edit = " UPDATE data_nasabah SET Nama= '" & t_nama.Text & "', Alamat='" & t_alamat.Text & "', Usia='" & t_usia.Text & "', Pekerjaan='" & cb_pekerjaan.Text & "', Penghasilan='" & t_penghasilan.Text & "', Tanggal='" & DateTimePicker1.Text & "' WHERE NIK = '" & t_nik.Text & "' "
        Dim dc As New OdbcCommand(Edit, conn)
        dc.ExecuteNonQuery()
    End Sub

    Sub EditSeleksi()
        Dim Edit As String
        Edit = " UPDATE seleksi_nasabah SET Nama= '" & t_nama.Text & "', Pekerjaan='" & cb_pekerjaan.Text & "', Penghasilan='" & t_penghasilan.Text & "', Syarat_adm='" & cb_adm.Text & "', Agunan='" & cb_agunan.Text & "', Jenis_Kredit='" & cb_kredit.Text & "', Jumlah_Pinjaman='" & cb_jumlah.Text & "' WHERE NIK = '" & t_nik.Text & "' "
        Dim dc As New OdbcCommand(Edit, conn)
        dc.ExecuteNonQuery()
    End Sub

    Sub PanggilNasabah()
        Call Koneksi()
        cmd = New OdbcCommand("SELECT * FROM data_nasabah WHERE NIK='" & t_nik.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            t_nama.Text = dr.Item("Nama")
            t_alamat.Text = dr.Item("Alamat")
            t_usia.Text = dr.Item("Usia")
            cb_pekerjaan.Text = dr.Item("Pekerjaan")
            t_penghasilan.Text = dr.Item("Penghasilan")
            DateTimePicker1.Text = dr.Item("Tanggal")
        End If
    End Sub

    Sub PanggilSeleksi()
        Call Koneksi()
        cmd = New OdbcCommand("SELECT * FROM seleksi_nasabah WHERE NIK='" & t_nik.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            cb_adm.Text = dr.Item("Syarat_adm")
            cb_agunan.Text = dr.Item("Agunan")
            cb_kredit.Text = dr.Item("Jenis_Kredit")
            cb_jumlah.Text = dr.Item("Jumlah_Pinjaman")
        End If
    End Sub

    Public Sub DataNasabah()
        Call Koneksi()
        da = New OdbcDataAdapter("SELECT * FROM data_nasabah", conn)
        dt = New DataTable
        da.Fill(dt)

        DGV.DataSource = dt

        DGV.Columns(0).Width = 130
        DGV.Columns(1).Width = 150
        DGV.Columns(2).Width = 250
        DGV.Columns(3).Width = 50
        DGV.Columns(4).Width = 100
        DGV.Columns(5).Width = 100

    End Sub

    Public Sub Bersih()
        t_nik.Clear()
        t_nama.Clear()
        t_alamat.Clear()
        t_usia.Clear()
        cb_pekerjaan.Text = ""
        t_penghasilan.Clear()
        t_hasil.Clear()
        cb_kerja.Text = "---"
        cb_adm.Text = "---"
        cb_agunan.Text = "---"
        cb_kredit.Text = "---"
        cb_jumlah.Text = "---"
        t_nik.Focus()
    End Sub

    Public Sub SimpanNasabah()
        Call Koneksi()
        Dim Simpan As String
        Simpan = "INSERT INTO data_nasabah (NIK, Nama, Alamat, Usia, Pekerjaan, Penghasilan, Tanggal) VALUES " & _
        "('" & t_nik.Text & "','" & t_nama.Text & "','" & t_alamat.Text & "','" & t_usia.Text & "','" & cb_pekerjaan.Text & "','" & t_penghasilan.Text & "','" & DateTimePicker1.Text & "')"

        Dim dc As New OdbcCommand(Simpan, conn)
        dc.ExecuteNonQuery()

    End Sub

    Public Sub SimpanSeleksi()
        Call Koneksi()
        Dim Simpan As String
        Simpan = "INSERT INTO seleksi_nasabah (NIK, Nama, Pekerjaan, Penghasilan, Syarat_adm, Agunan, Jenis_Kredit, Jumlah_Pinjaman,Keputusan) VALUES " & _
            "('" & t_nik.Text & "','" & t_nama.Text & "','" & cb_kerja.Text & "','" & t_hasil.Text & "','" & cb_adm.Text & "','" & cb_agunan.Text & "','" & cb_kredit.Text & "','" & cb_jumlah.Text & "','-')"

        Dim dc As New OdbcCommand(Simpan, conn)
        dc.ExecuteNonQuery()

    End Sub

    Private Sub Nasabah_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call DataNasabah()
    End Sub

    Private Sub btn_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan.Click
        If t_nik.Text = "" And t_nama.Text = "" And t_alamat.Text = "" And t_usia.Text = "" And
            cb_pekerjaan.Text = "" And t_penghasilan.Text = "" And
            cb_kerja.Text = "" And t_hasil.Text = "" And cb_adm.Text = "" And cb_agunan.Text = "" And
            cb_kredit.Text = "" And cb_jumlah.Text = "" Then
            MsgBox("Harap Isi Semua Data !!!", MsgBoxStyle.Information, "DATA NASABAH")
        Else
            Try
                Call SimpanNasabah()
                Call SimpanSeleksi()
                MsgBox("Data Telah Disimpan", MsgBoxStyle.Information, "DATA NASABAH")

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            End Try
            Seleksi.t_nik.Text = t_nik.Text
            Call Bersih()
        End If
    End Sub

    Private Sub btn_hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_hapus.Click
        Dim Hapus As String
        Hapus = "DELETE FROM data_nasabah WHERE NIK='" & t_nik.Text & "'"

        MessageBox.Show("Hapus Data?", "DATA NASABAH", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If MsgBoxResult.Yes Then
            Dim dc As New OdbcCommand(Hapus, conn)
            dc.ExecuteNonQuery()
        End If
        MsgBox("Data Terhapus", MsgBoxStyle.Information, "DATA NASABAH")

    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        MessageBox.Show("Edit Data Dengan NIK " & t_nik.Text & "", "DATA NASABAH", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If vbYes Then
            Call EditNasabah()
            Call EditSeleksi()
        End If
        MsgBox("Data Telah Di Edit", MsgBoxStyle.Information, "DATA NASABAH")
        Call Bersih()


    End Sub


    Private Sub t_penghasilan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t_penghasilan.TextChanged
        t_hasil.Text = t_penghasilan.Text
    End Sub


    Private Sub cb_pekerjaan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_pekerjaan.SelectedIndexChanged
        cb_kerja.Text = cb_pekerjaan.Text
    End Sub

    Private Sub btn_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_batal.Click
        Dim Keluar As String
        Keluar = MessageBox.Show("Keluar?", "DATA NASABAH", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If vbYes Then
            Menu_Utama.Enabled = True
            Me.Hide()
        End If
    End Sub

    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        Seleksi.Show()
        Me.Hide()
    End Sub

    Private Sub t_nik_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles t_nik.KeyPress
        Call PanggilNasabah()
        Call PanggilSeleksi()

    End Sub

End Class