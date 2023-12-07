Imports MySql.Data.MySqlClient
Public Class data_keluarga


    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        login.TextBox1.Text = ""
        login.TextBox2.Text = ""
        login.login_nip_1.Text = ""
        login.login_nama_1.Text = ""
        login.login_akses_1.Text = ""
        My.Settings.user1 = ""
        login.Show()
        Me.Hide()
    End Sub

    Sub tampil()

       
        Call koneksi()
        ap = New MySqlDataAdapter("select no_kk, nik, nama, alamat from penduduk group by no_kk", con)
        dt = New DataSet
        ap.Fill(dt, "penduduk")
        DataGridView1.DataSource = dt.Tables("penduduk")
        Try
            DataGridView1.Columns(0).Width = 70
            DataGridView1.Columns(1).Width = 130
            DataGridView1.Columns(2).Width = 100
            DataGridView1.Columns(3).Width = 150
            DataGridView1.Columns(0).HeaderText = "No KK"
            DataGridView1.Columns(1).HeaderText = "NIK"
            DataGridView1.Columns(2).HeaderText = "Kepala Keluarga"
            DataGridView1.Columns(3).HeaderText = "Alamat"
        Catch ex As Exception
        End Try



    End Sub

    Private Sub data_keluarga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil()
        lbl_id.Visible = False
        ToolStripDropDownButton2.Text = My.Settings.user1
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cari.TextChanged
        Call koneksi()
        ap = New MySqlDataAdapter("select no_kk, nik, nama, alamat from penduduk where nik like '%" & txt_cari.Text & "%'  or no_kk like '%" & txt_cari.Text & "%' or nama like '%" & txt_cari.Text & "%' or alamat like '%" & txt_cari.Text & "%' group by no_kk", con)
        dt = New DataSet
        ap.Fill(dt, "penduduk")
        DataGridView1.DataSource = dt.Tables("penduduk")
        Try
            DataGridView1.Columns(0).Width = 70
            DataGridView1.Columns(1).Width = 130
            DataGridView1.Columns(2).Width = 100
            DataGridView1.Columns(3).Width = 150
            DataGridView1.Columns(0).HeaderText = "No KK"
            DataGridView1.Columns(1).HeaderText = "NIK"
            DataGridView1.Columns(2).HeaderText = "Kepala Keluarga"
            DataGridView1.Columns(3).HeaderText = "Alamat"
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
      
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        Try
            Dim i As Integer = DataGridView1.CurrentRow.Index
            lbl_id.Text = DataGridView1.Item(0, i).Value
        Catch ex As Exception

        End Try
    End Sub



    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Call koneksi()
        ap = New MySqlDataAdapter("select no_kk, nik, nama, alamat from penduduk where nik like '%" & txt_cari.Text & "%'  or no_kk like '%" & txt_cari.Text & "%' or nama like '%" & txt_cari.Text & "%' or alamat like '%" & txt_cari.Text & "%' group by no_kk", con)
        dt = New DataSet
        ap.Fill(dt, "penduduk")
        DataGridView1.DataSource = dt.Tables("penduduk")
        Try
            DataGridView1.Columns(0).Width = 70
            DataGridView1.Columns(1).Width = 130
            DataGridView1.Columns(2).Width = 100
            DataGridView1.Columns(3).Width = 150
            DataGridView1.Columns(0).HeaderText = "No KK"
            DataGridView1.Columns(1).HeaderText = "NIK"
            DataGridView1.Columns(2).HeaderText = "Kepala Keluarga"
            DataGridView1.Columns(3).HeaderText = "Alamat"
        Catch ex As Exception
        End Try
    End Sub


    Private Sub MinimizeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MinimizeToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        data_penduduk.Show()
        Me.Hide()
        data_penduduk.txt_static.Text = lbl_id.Text
        data_penduduk.tampil()
    End Sub



    Private Sub Button17_Click(sender As System.Object, e As System.EventArgs) Handles Button17.Click
        data_penduduk.Show()
        Me.Hide()
    End Sub

   
    Private Sub Button16_Click(sender As System.Object, e As System.EventArgs) Handles Button16.Click
        user.Show()
        Me.Hide()
    End Sub
End Class