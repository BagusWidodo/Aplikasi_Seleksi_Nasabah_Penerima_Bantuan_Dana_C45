Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Laporan

    Public Sub Laporan()
        Call Koneksi()
        da = New OdbcDataAdapter("SELECT * FROM laporan", conn)
        dt = New DataTable
        da.Fill(dt)

        DGV.DataSource = dt
    End Sub

    Private Sub Laporan_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call Laporan()
    End Sub

    Private Sub btn_keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_keluar.Click
        Dim Keluar As String
        Keluar = MessageBox.Show("Keluar?", "LAPORAN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If vbYes Then
            Menu_Utama.Enabled = True
            Me.Hide()
        End If
    End Sub

    Private Sub btn_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_print.Click
        Print.Show()
    End Sub
End Class