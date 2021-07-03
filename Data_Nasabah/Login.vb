Public Class Login

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Menu_Utama.Show()
        Menu_Utama.Enabled = False
    End Sub

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        If TextBox1.Text = "ADMIN" And TextBox2.Text = "12345" Then
            Menu_Utama.Enabled = True
            Me.Hide()
        Else
            MsgBox("Username & Password Salah !!!", MsgBoxStyle.Information, "FORM LOGIN")
        End If
    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Dim keluar As String
        keluar = MessageBox.Show("Keluar Dari Sistem?", "FORM LOGIN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If vbYes Then
            End
        End If
    End Sub
End Class