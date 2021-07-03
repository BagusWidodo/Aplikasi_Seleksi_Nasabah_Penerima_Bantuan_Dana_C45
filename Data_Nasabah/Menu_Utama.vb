Public Class Menu_Utama

    Private Sub Menu_Utama_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        link_nasabah.Cursor = Cursors.Hand
        link_seleksi.Cursor = Cursors.Hand
        link_laporan.Cursor = Cursors.Hand
        link_logout.Cursor = Cursors.Hand
    End Sub

    Private Sub link_nasabah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles link_nasabah.Click
        Nasabah.Show()
        Me.Enabled = False
    End Sub

    Private Sub link_seleksi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles link_seleksi.Click
        Seleksi.Show()
        Me.Enabled = False
    End Sub

    Private Sub link_laporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles link_laporan.Click
        Laporan.Show()
        Me.Enabled = False
    End Sub

    Private Sub link_logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles link_logout.Click
        Dim Keluar As String
        Keluar = MessageBox.Show("Keluar Dari Sistem?", "PEMINJAMAN DANA", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If vbYes Then
            End
        End If
    End Sub

End Class
