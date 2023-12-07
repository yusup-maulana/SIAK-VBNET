Imports MySql.Data.MySqlClient
Public Class user


    Private Sub Button17_Click(sender As System.Object, e As System.EventArgs) Handles Button17.Click
        data_penduduk.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        data_keluarga.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        login.TextBox1.Text = ""
        login.TextBox2.Text = ""
        login.login_nip_1.Text = ""
        login.login_nama_1.Text = ""
        login.login_akses_1.Text = ""
        My.Settings.user1 = ""
        login.Show()
        Me.Hide()
    End Sub

    Private Sub MinimizeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MinimizeToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Sub tampil()
        Call koneksi()
        ap = New MySqlDataAdapter("select nip,nama,username,akses from admin", con)
        dt = New DataSet
        ap.Fill(dt, "admin")
        DataGridView1.DataSource = dt.Tables("admin")
        Try
            DataGridView1.Columns(0).Width = 70
            DataGridView1.Columns(1).Width = 130
            DataGridView1.Columns(2).Width = 100
            DataGridView1.Columns(3).Width = 150
            DataGridView1.Columns(0).HeaderText = "NIP"
            DataGridView1.Columns(1).HeaderText = "Nama"
            DataGridView1.Columns(2).HeaderText = "Username"
            DataGridView1.Columns(3).HeaderText = "Akses"
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Try
            Call koneksi()
            cmd = New MySqlCommand("delete from admin where nip='" & lbl_id.Text & "'", con)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di hapus", MsgBoxStyle.Information)
            Call tampil()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub user_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tampil()
        ToolStripDropDownButton2.Text = My.Settings.user1
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Try
            If txtnip.Text = "" Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf txtnama.Text = "" Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf txtuser.Text = "" Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf txtpass.Text = "" Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf txtakses.Text = "" Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            Else
                Dim aks As String
                If txtakses.Text = "Operator" Then
                    aks = "1"
                ElseIf txtakses.Text = "Pelayanan" Then
                    aks = "2"
                ElseIf txtakses.Text = "KasiPelayanan" Then
                    aks = "3"
                End If


                Dim a As String = "INSERT INTO admin  VALUES ('" & txtnip.Text & "','" & txtnama.Text & "','" & txtuser.Text & "','" & txtpass.Text & "','" & aks & "')"
                cmd = New MySqlCommand(a, con)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil di simpan", MsgBoxStyle.Information)
                txtnip.Text = ""
                txtnama.Text = ""
                txtuser.Text = ""
                txtpass.Text = ""
                txtakses.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Refresh()
        Call tampil()
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As System.EventArgs) Handles DataGridView1.SelectionChanged

        Try
            Dim i As Integer = DataGridView1.CurrentRow.Index
            lbl_id.Text = DataGridView1.Item(0, i).Value
        Catch ex As Exception

        End Try


    End Sub

    Private Sub txt_cari_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_cari.TextChanged
        Call koneksi()
        ap = New MySqlDataAdapter("select nip,nama,username,akses from admin where nip like '%" & txt_cari.Text & "%'  or nama like '%" & txt_cari.Text & "%' or username like '%" & txt_cari.Text & "'", con)
        dt = New DataSet
        ap.Fill(dt, "admin")
        DataGridView1.DataSource = dt.Tables("admin")
        Try
            DataGridView1.Columns(0).Width = 70
            DataGridView1.Columns(1).Width = 130
            DataGridView1.Columns(2).Width = 100
            DataGridView1.Columns(3).Width = 150
            DataGridView1.Columns(0).HeaderText = "NIP"
            DataGridView1.Columns(1).HeaderText = "Nama"
            DataGridView1.Columns(2).HeaderText = "Username"
            DataGridView1.Columns(3).HeaderText = "Akses"
        Catch ex As Exception
        End Try
    End Sub
End Class