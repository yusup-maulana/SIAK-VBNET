Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class pindah
    Dim kkglob, namakepalakglob As String
    Sub tampil()
        ap = New MySqlDataAdapter("select no_reg,nik2,tgl_reg,namalengkap,alamatasal,alamatpindah,klasifikasipindah from pindah", con)
        dt = New DataSet
        ap.Fill(dt, "pindah")
        DataGridView1.DataSource = dt.Tables("pindah")
        Try
            DataGridView1.Columns(0).HeaderText = "No Reg"
            DataGridView1.Columns(1).HeaderText = "NIK"
            DataGridView1.Columns(2).HeaderText = "Tanggal Reg"
            DataGridView1.Columns(3).HeaderText = "Nama pemohon"
            DataGridView1.Columns(4).HeaderText = "Alamat asal"
            DataGridView1.Columns(5).HeaderText = "Alamat tujuan"
            DataGridView1.Columns(6).HeaderText = "Klasifikasi"
        Catch ex As Exception
        End Try
    End Sub
    Sub dgv2()
        Try
            Dim i As Integer = DataGridView2.CurrentRow.Index
            txt_nik_permohon.Text = DataGridView2.Item(0, i).Value
            lblnama.Text = DataGridView2.Item(1, i).Value

        Catch ex As Exception

        End Try
       
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If txt_nik_permohon.Text = "" Then
            MsgBox("Nik pemohon masih kosong", MsgBoxStyle.Exclamation)
        Else

            Dim wwwwwww2 As String
            wwwwwww2 = "select * from  penduduk where nik = '" & txt_nik_permohon.Text & "' and domisili='" & "" & "'"
            cmd = New MySqlCommand(wwwwwww2, con)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows Then
                kkglob = rd.Item("no_kk")
                lblttl.Text = rd.Item("tempat_lahir") & ", " & rd.Item("tanggal_lahir")
                lbljk.Text = rd.Item("jenis_kelamin")
                lblagama.Text = rd.Item("agama")
                lblalamatasal.Text = rd.Item("alamat") & " " & rd.Item("rt") & " / " & rd.Item("rw")
                lblkelurahan.Text = rd.Item("kelurahan")
                lblprov.Text = rd.Item("provinsi")
                lblkota.Text = rd.Item("kota")
                Button2.Visible = True
                rd.Close()
            Else
                MsgBox("Data tersebut Telah Dipindahkan")
                rd.Close()
                Button2.Visible = False
            End If


        End If
      

    End Sub



    Private Sub txt_nik_permohon_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_nik_permohon.TextChanged

        If txt_nik_permohon.Text = "" Then
            DataGridView2.Visible = False

        Else
            DataGridView2.Visible = True

            Dim table As DataTable
            ap = New MySqlDataAdapter("select nik, nama from penduduk where nik like '%" & txt_nik_permohon.Text & "%' or nama like '%" & txt_nik_permohon.Text & "%' and domisili='" & "" & "'", con)
            dt = New DataSet
            dt.Clear()
            ap.Fill(dt, "penduduk")
            table = dt.Tables("penduduk")
            DataGridView2.DataSource = table
            Try
            Catch ex As Exception
            End Try
        End If
    End Sub

 

    Private Sub Button16_Click(sender As System.Object, e As System.EventArgs) Handles Button16.Click
        ktp.Show()
        Me.Hide()
    End Sub

    Private Sub Button18_Click(sender As System.Object, e As System.EventArgs) Handles Button18.Click
        kk.Show()
        Me.Hide()
    End Sub

    Private Sub btnambil_Click(sender As System.Object, e As System.EventArgs) Handles btnambil.Click
        Call tampil()
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub btnberanda_Click(sender As System.Object, e As System.EventArgs) Handles btnberanda.Click
        TabControl1.SelectedTab = TabPage1
    End Sub


    Private Sub pindah_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DataGridView2.Visible = False
        koneksi()
        ToolStripDropDownButton2.Text = My.Settings.user2
    End Sub

    Private Sub DataGridView2_CellClick1(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        dgv2()
    End Sub


    Private Sub DataGridView2_CellMouseClick1(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick
        dgv2()
    End Sub

    Private Sub DataGridView2_LostFocus1(sender As Object, e As System.EventArgs) Handles DataGridView2.LostFocus
        DataGridView2.Visible = False
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim wwwwwww As String
        wwwwwww = "select * from  penduduk where no_kk = '" & kkglob & "' and status_hubungan_keluarga='" & "Kepala Keluarga" & "'"
        cmd = New MySqlCommand(wwwwwww, con)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            namakepalakglob = rd.Item("nama")
            rd.Close()
        Else
            rd.Close()
            namakepalakglob = lblnama.Text
        End If
        Try
            Button2.Visible = False
            Dim tglnow As String = Format(Now, "yyyy-MM-dd")
            Dim query As String = "insert into pindah (tgl_reg, no_kk, namakepalakeluarga, nik2, alamatasal, kelurahanasal, kecasal, kotaasal,provinsi,namalengkap,alasanpindah,alamatpindah,kelurahanpindah,kecpindah,kotapindah,provinsipindah,klasifikasipindah,jenispindah,nip_petugas) values ('" & tglnow & "','" & kkglob & "','" & namakepalakglob & "','" & txt_nik_permohon.Text & "','" & lblalamatasal.Text & "','" & lblkelurahan.Text & "','" & "Andir" & "','" & lblkota.Text & "','" & lblprov.Text & "','" & lblnama.Text & "','" & txtalasanpindah.Text & "','" & txtalamattujuan.Text & "','" & txtkelurahanpindah.Text & "','" & txtkecpindah.Text & "','" & txtkotapindah.Text & "','" & txtprovpindah.Text & "','" & cbklasifikasi.Text & "','" & cbjenispindah.Text & "','" & My.Settings.nip2 & "')"
            cmd = New MySqlCommand(query, con)
            cmd.ExecuteNonQuery()
            Dim j As String = "update penduduk set domisili ='" & "Pindah" & "'where nik='" & txt_nik_permohon.Text & "'"
            cmd = New MySqlCommand(j, con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("data tersebut sudah ada", MsgBoxStyle.Critical)
        End Try



        Try
            Dim str As String = "pindahsurat.rpt"
            Dim rpt As New ReportDocument()
            rpt.Load(str)
            rpt.SetParameterValue("suket", txt_nik_permohon.Text)
            suket.Refresh()
            suket.ReportSource = rpt
            suket.Show()
            TabControl1.SelectedTab = TabPage4

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        lblagama.Text = ""
        lblalamatasal.Text = ""
        lbljk.Text = ""
        lblkelurahan.Text = ""
        lblkota.Text = ""
        lblnama.Text = ""
        lblprov.Text = ""
        lblttl.Text = ""
        kkglob = ""
        txt_nik_permohon.Text = ""
        txtalamattujuan.Text = ""
        txtalasanpindah.Text = ""
        txtkecpindah.Text = ""
        txtkelurahanpindah.Text = ""
        txtkotapindah.Text = "Bandung"
        txtprovpindah.Text = "Jawa Barat"
        cbjenispindah.Text = "Antar Kecamatan"
        cbklasifikasi.Text = "Anggota keluarga"
    End Sub

    Private Sub txt_cari_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_cari.TextChanged
        ap = New MySqlDataAdapter("select  no_reg,nik2,tgl_reg,namalengkap,alamatasal,alamatpindah,klasifikasipindah from pindah  where namalengkap like '%" & txt_cari.Text & "%' or  tgl_reg like '%" & txt_cari.Text & "%' or  alamatpindah like '%" & txt_cari.Text & "%' or  alamatasal like '%" & txt_cari.Text & "%' or  klasifikasipindah like '%" & txt_cari.Text & "%'", con)
        dt = New DataSet
        ap.Fill(dt, "pindah")
        DataGridView1.DataSource = dt.Tables("pindah")
        Try
            DataGridView1.Columns(0).HeaderText = "No Reg"
            DataGridView1.Columns(1).HeaderText = "NIK"
            DataGridView1.Columns(2).HeaderText = "Tanggal Reg"
            DataGridView1.Columns(3).HeaderText = "Nama pemohon"
            DataGridView1.Columns(4).HeaderText = "Alamat asal"
            DataGridView1.Columns(5).HeaderText = "Alamat tujuan"
            DataGridView1.Columns(6).HeaderText = "Klasifikasi"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Try
            Dim str As String = "pindahsurat.rpt"
            Dim rpt As New ReportDocument()
            rpt.Load(str)
            rpt.SetParameterValue("suket", txtnik.Text)
            suket.Refresh()
            suket.ReportSource = rpt
            suket.Show()
            TabControl1.SelectedTab = TabPage4

        Catch ex As Exception

        End Try
    End Sub



    Private Sub DataGridView1_SelectionChanged(sender As Object, e As System.EventArgs) Handles DataGridView1.SelectionChanged
        Try
            Dim i As Integer = DataGridView1.CurrentRow.Index
            txtnik.Text = DataGridView1.Item(1, i).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click

        Dim i As Integer = DataGridView1.CurrentRow.Index
        Dim a As String = DataGridView1.Item(0, i).Value
        Dim wwwwwww2 As String
        wwwwwww2 = "select * from  pindah where no_reg = '" & a & "'"
        cmd = New MySqlCommand(wwwwwww2, con)

        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txtnokk.Text = rd.Item("no_kk")
            txttglreg.Text = rd.Item("tgl_reg")
            txtnoreg.Text = rd.Item("no_reg")
            txtnmkklga.Text = rd.Item("namakepalakeluarga")
            txtnamalenkap.Text = rd.Item("namalengkap")
            txtalamatasal.Text = rd.Item("alamatasal")
            txtkelurahanasal.Text = rd.Item("kelurahanasal")
            txtkecamatanasal.Text = rd.Item("kecasal")
            txtprov.Text = rd.Item("provinsi")
            txtkotaasal.Text = rd.Item("kotaasal")
            txtalasan_pindah.Text = rd.Item("alasanpindah")
            txtnik.Text = rd.Item("nik2")
            txtkelurahan_pindah.Text = rd.Item("kelurahanpindah")
            txtalamat_pindah.Text = rd.Item("alamatpindah")
            txtkec_pindah.Text = rd.Item("kecpindah")
            txtkota_pindah.Text = rd.Item("kotapindah")
            txtkasifikasi_pindah.Text = rd.Item("klasifikasipindah")
            txtjenis_pindah.Text = rd.Item("jenispindah")
            rd.Close()
        Else
            rd.Close()
        End If

        TabControl1.SelectedTab = TabPage3
    End Sub


    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Try
            Dim j As String = "update pindah set alasanpindah ='" & upalasanpindah.Text & "', alamatpindah='" & upalasanpindah.Text & "', kelurahanpindah='" & upkel.Text & "', kecpindah='" & upkec.Text & "', kotapindah='" & upkota.Text & "', provinsipindah='" & upprov.Text & "', klasifikasipindah='" & upklasifikasi.Text & "', jenispindah='" & upjenispindah.Text & "'where nik2='" & txtnik.Text & "'"
            cmd = New MySqlCommand(j, con)
            cmd.ExecuteNonQuery()
            Dim j2 As String = "update penduduk set domisili ='" & "Pindah" & "'where nik='" & txtnik.Text & "'"
            cmd = New MySqlCommand(j2, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("data tersebut sudah ada", MsgBoxStyle.Critical)
        End Try
        Call tampil()
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub btnhapus_Click(sender As System.Object, e As System.EventArgs) Handles btnhapus.Click
        Dim i As Integer = DataGridView1.CurrentRow.Index
        Dim a As String = DataGridView1.Item(1, i).Value
        Dim wwwwwww2 As String
        wwwwwww2 = "select * from  pindah where nik2 = '" & a & "'"
        cmd = New MySqlCommand(wwwwwww2, con)

        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            upalamattujuan.Text = rd.Item("alamatasal")
            upkel.Text = rd.Item("kelurahanasal")
            upkec.Text = rd.Item("kecasal")
            upprov.Text = rd.Item("provinsi")
            upkota.Text = rd.Item("kotaasal")
            upalasanpindah.Text = rd.Item("alasanpindah")
            upklasifikasi.Text = rd.Item("klasifikasipindah")
            upjenispindah.Text = rd.Item("jenispindah")
            rd.Close()
        Else
            rd.Close()
        End If

        TabControl1.SelectedTab = TabPage5
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        pendatang.Show()
        Me.Hide()
    End Sub

    Private Sub MinimizeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MinimizeToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        login.TextBox1.Text = ""
        login.TextBox2.Text = ""
        login.login_nip_1.Text = ""
        login.login_nama_1.Text = ""
        login.login_akses_1.Text = ""
        My.Settings.user2 = ""
        My.Settings.nip2 = ""
        login.Show()
        Me.Hide()
    End Sub
End Class