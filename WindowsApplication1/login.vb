Imports MySql.Data.MySqlClient
Public Class login

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Call koneksi()
        cmd = New MySqlCommand("select * from admin where username='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'", con)
        rd = cmd.ExecuteReader()
        If rd.Read Then
            login_nip_1.Text = rd.Item("nip")
            login_nama_1.Text = rd.Item("nama")
            login_akses_1.Text = rd.Item("akses")
            rd.Close()
            If login_akses_1.Text = "1" Then
                data_penduduk.Show()
                My.Settings.user1 = login_nama_1.Text
            ElseIf login_akses_1.Text = "2" Then
                ktp.Show()
                My.Settings.user2 = login_nama_1.Text
                My.Settings.nip2 = login_nip_1.Text
            ElseIf login_akses_1.Text = "3" Then
                laporan.Show()
                My.Settings.user3 = login_nama_1.Text
            End If
            My.Settings.Save()
            Me.Hide()
        Else
            MsgBox("Login Gagal ", MsgBoxStyle.Exclamation, "Kesalahan Menginput User Atau Password")
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
End Class
