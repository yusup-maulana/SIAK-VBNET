Imports MySql.Data.MySqlClient
Public Class data_penduduk




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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TabControl1.SelectedTab = TabPage2

    End Sub
    Sub tampil()
        Call koneksi()
        If txt_static.Text = "" Then
            ap = New MySqlDataAdapter("select nik, no_kk, nama, status_hubungan_keluarga, tanggal_lahir from penduduk where domisili = '" & "" & "'", con)
            dt = New DataSet
            ap.Fill(dt, "penduduk")
            DataGridView1.DataSource = dt.Tables("penduduk")
        Else
            ap = New MySqlDataAdapter("select nik, no_kk, nama, status_hubungan_keluarga,tanggal_lahir from penduduk where no_kk = '" & txt_static.Text & "'", con)
            dt = New DataSet
            ap.Fill(dt, "penduduk")
            DataGridView1.DataSource = dt.Tables("penduduk")
        End If
        Try
            DataGridView1.Columns(0).Width = 150
            DataGridView1.Columns(1).Width = 150
            DataGridView1.Columns(2).Width = 150
            DataGridView1.Columns(3).Width = 150
            DataGridView1.Columns(4).Width = 150
            DataGridView1.Columns(0).HeaderText = "NIK"
            DataGridView1.Columns(1).HeaderText = "NO KK"
            DataGridView1.Columns(2).HeaderText = "Nama"
            DataGridView1.Columns(3).HeaderText = "Status Keluarga"
            DataGridView1.Columns(4).HeaderText = "Tanggal Lahir"
        Catch ex As Exception
        End Try

    End Sub
    Sub bersih()
        txt_nik.Clear()
        txt_kk.Clear()
        txt_nama.Clear()
        txt_tl.Clear()
        txt_jk.Clear()
        rb_l.Checked = False
        rb_p.Checked = False
        cb_gold.Text = " Pilih.."
        cb_agama.Text = " Pilih.."
        cb_pendidikan.Text = " Pilih.."
        cb_pekerjaan.Text = " Pilih.."
        cb_pendidikan.Text = " Pilih.."
        cb_statuskawin.Text = " Pilih.."
        cb_statuskeluarga.Text = " Pilih.."
        rt_alamat.Clear()
        txt_rt.Clear()
        txt_rw.Clear()
        cb_kelurahan.Text = " Pilih.."
        txt_kecamatan.Text = "Andir"
        txt_kota.Text = "Bandung"
        txt_provinsi.Text = "Jawa Barat"
        txt_kodepos.Clear()
        rb_wna.Checked = False
        rb_wni.Checked = False
        txt_namayah.Clear()
        txt_namaibu.Clear()
        txt_foto.Clear()
        file1.Text = ""
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampil()
        txt_wn.Visible = False
        txt_jk.Visible = False
        update_jk.Visible = False
        update_wn.Visible = False
        update_nik.Visible = False
        lbl_id.Visible = False
        txt_static.Visible = False
        ToolStripDropDownButton2.Text = My.Settings.user1
    End Sub



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Call koneksi()
            cmd = New MySqlCommand("delete from penduduk where nik='" & lbl_id.Text & "'", con)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di hapus", MsgBoxStyle.Information)
            Call tampil()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub rb_wni_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_wni.CheckedChanged
        If rb_wni.Checked = True Then
            txt_wn.Text = rb_wni.Text
        End If
    End Sub

    Private Sub rb_l_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_l.CheckedChanged
        If rb_l.Checked = True Then
            txt_jk.Text = rb_l.Text
        End If
    End Sub

    Private Sub rb_p_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_p.CheckedChanged
        If rb_p.Checked = True Then
            txt_jk.Text = rb_p.Text
        End If
    End Sub

    Private Sub rb_wna_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_wna.CheckedChanged
        If rb_wna.Checked = True Then
            txt_wn.Text = rb_wna.Text
        End If
    End Sub

    Private Sub btn_browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_browse.Click
        Dim Ofd = New OpenFileDialog()

        If Ofd.ShowDialog = Windows.Forms.DialogResult.Cancel Then
        Else
            file1.Text = Ofd.SafeFileName
            txt_foto.Text = Ofd.FileName
        End If
    End Sub

    Private Sub btn_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan.Click
        Call koneksi()
        Try
            If txt_nik.Text = "" Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf txt_kk.Text = "" Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf txt_nama.Text = "" Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf txt_tl.Text = "" Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf txt_jk.Text = "" Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf cb_gold.Text = " Pilih.." Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf cb_pendidikan.Text = " Pilih.." Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf cb_pekerjaan.Text = " Pilih.." Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf cb_statuskawin.Text = " Pilih.." Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf cb_statuskeluarga.Text = " Pilih.." Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf rt_alamat.Text = "" Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf txt_rt.Text = "" Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf txt_rw.Text = "" Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf cb_kelurahan.Text = " Pilih.." Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf txt_kodepos.Text = "" Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf txt_wn.Text = "" Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf txt_namayah.Text = "" Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf txt_namaibu.Text = "" Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            Else


                Dim a As String = "INSERT INTO penduduk  VALUES ('" & txt_nik.Text & "','" & txt_kk.Text & "','" & txt_nama.Text & "','" & txt_tl.Text & "','" & txt_tgl.Text & "','" & txt_jk.Text & "','" & cb_gold.Text & "','" & cb_agama.Text & "','" & rt_alamat.Text & "','" & txt_rt.Text & "','" & txt_rw.Text & "','" & cb_kelurahan.Text & "','" & txt_kecamatan.Text & "','" & txt_kota.Text & "','" & txt_provinsi.Text & "','" & txt_kodepos.Text & "','" & txt_wn.Text & "','" & cb_pendidikan.Text & "','" & cb_pekerjaan.Text & "','" & cb_statuskawin.Text & "','" & cb_statuskeluarga.Text & "','" & txt_namayah.Text & "','" & txt_namaibu.Text & "','" & file1.Text & "','" & "" & "')"
                cmd = New MySqlCommand(a, con)
                cmd.ExecuteNonQuery()
                FFOperation(txt_foto.Text, "foto/", ffAction.FO_COPY, ffFlags.FOF_SILENT)
                MsgBox("Data berhasil di simpan", MsgBoxStyle.Information)
                If checkb_bersih.Checked = True Then
                    bersih()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Refresh()
        Call tampil()
    End Sub


    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        Try
            Dim i As Integer = DataGridView1.CurrentRow.Index
            lbl_id.Text = DataGridView1.Item(0, i).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            Call koneksi()
            Dim str As String
            str = "select * from penduduk where nik = '" & lbl_id.Text & "'"
            cmd = New MySqlCommand(str, con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                nik_txt.Text = rd.Item("nik")
                no_kk_txt.Text = rd.Item("no_kk")
                nama_txt.Text = rd.Item("nama")
                tempat_tanggal_lahir_txt.Text = rd.Item("tempat_lahir") & ", " & rd.Item("tanggal_lahir")
                jenis_kelamin_txt.Text = rd.Item("jenis_kelamin")
                golongan_darah_txt.Text = rd.Item("golongan_darah")
                agama_txt.Text = rd.Item("agama")
                alamat_txt.Text = rd.Item("alamat")
                rt_txt.Text = rd.Item("rt")
                rw_txt.Text = rd.Item("rw")
                kelurahan_txt.Text = rd.Item("kelurahan")
                kecamatan_txt.Text = rd.Item("kecamatan")
                kabupaten_kota_txt.Text = rd.Item("kota")
                provinsi_txt.Text = rd.Item("provinsi")
                kode_pos_txt.Text = rd.Item("kode_pos")
                kewarganegaraan_txt.Text = rd.Item("kewarganegaraan")
                pendidikan_txt.Text = rd.Item("pendidikan")
                pekerjaan_txt.Text = rd.Item("pekerjaan")
                status_perkawinan_txt.Text = rd.Item("status_perkawinan")
                status_hubungan_keluarga_txt.Text = rd.Item("status_hubungan_keluarga")
                nama_ayah_txt.Text = rd.Item("nama_ayah")
                nama_ibu_txt.Text = rd.Item("nama_ibu")
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                PictureBox1.ImageLocation = "foto/" & rd.Item("foto")
            End If
            TabControl1.SelectedTab = TabPage3
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        bersih()
    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Call koneksi()
        Try
           If update_kk.Text = "" Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf update_nama.Text = "" Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf update_tl.Text = "" Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf update_jk.Text = "" Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf update_cbgold.Text = " Pilih.." Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf update_cbpendidikan.Text = " Pilih.." Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf update_cbpekerjaan.Text = " Pilih.." Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf update_statuskawin.Text = " Pilih.." Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf update_cb_statuskeluarga.Text = " Pilih.." Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf update_alamat.Text = "" Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf update_rt.Text = "" Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf update_rw.Text = "" Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf update_cbkel.Text = " Pilih.." Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf update_kodepos.Text = "" Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf update_wn.Text = "" Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf update_namaayah.Text = "" Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            ElseIf update_namaibu.Text = "" Then
                MsgBox("Kotak isian box tidak boleh ada yang kosong", MsgBoxStyle.Exclamation)
            Else

                If update_foto.Text = "" Then
                    Dim a As String = "update penduduk set no_kk ='" & update_kk.Text & "', nama='" & update_nama.Text & "', tempat_lahir='" & update_tl.Text & "', tanggal_lahir='" & update_tgl.Text & "', jenis_kelamin='" & update_jk.Text & "', golongan_darah='" & update_cbgold.Text & "', agama='" & update_agama.Text & "', alamat='" & update_alamat.Text & "', rt='" & update_rt.Text & "', rw='" & update_rw.Text & "', kelurahan='" & update_cbkel.Text & "', kecamatan='" & update_kec.Text & "', kota='" & update_kota.Text & "', provinsi='" & update_prov.Text & "', kode_pos='" & update_kodepos.Text & "', kewarganegaraan='" & update_wn.Text & "', pendidikan='" & update_cbpendidikan.Text & "', pekerjaan='" & update_cbpekerjaan.Text & "', status_perkawinan='" & update_statuskawin.Text & "', status_hubungan_keluarga='" & update_cb_statuskeluarga.Text & "', nama_ayah='" & update_namaayah.Text & "', nama_ibu='" & update_namaibu.Text & "'where nik='" & update_nik.Text & "'"
                    cmd = New MySqlCommand(a, con)
                    cmd.ExecuteNonQuery()
                Else
                    FFOperation(update_foto.Text, "foto/", ffAction.FO_COPY, ffFlags.FOF_SILENT)
                    Dim a As String = "update penduduk set no_kk ='" & update_kk.Text & "', nama='" & update_nama.Text & "', tempat_lahir='" & update_tl.Text & "', tanggal_lahir='" & update_tgl.Text & "', jenis_kelamin='" & update_jk.Text & "', golongan_darah='" & update_cbgold.Text & "', agama='" & update_agama.Text & "', alamat='" & update_alamat.Text & "', rt='" & update_rt.Text & "', rw='" & update_rw.Text & "', kelurahan='" & update_cbkel.Text & "', kecamatan='" & update_kec.Text & "', kota='" & update_kota.Text & "', provinsi='" & update_prov.Text & "', kode_pos='" & update_kodepos.Text & "', kewarganegaraan='" & update_wn.Text & "', pendidikan='" & update_cbpendidikan.Text & "', pekerjaan='" & update_cbpekerjaan.Text & "', status_perkawinan='" & update_statuskawin.Text & "', status_hubungan_keluarga='" & update_cb_statuskeluarga.Text & "', nama_ayah='" & update_namaayah.Text & "', nama_ibu='" & update_namaibu.Text & "', foto='" & file_lbl.Text & "'where nik='" & update_nik.Text & "'"
                    cmd = New MySqlCommand(a, con)
                    cmd.ExecuteNonQuery()
                End If
               

                MsgBox("Data berhasil di ubah", MsgBoxStyle.Information)
                TabControl1.SelectedTab = TabPage1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Refresh()
        Call tampil()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Call koneksi()
            Dim str As String
            str = "select * from penduduk where nik = '" & lbl_id.Text & "'"
            cmd = New MySqlCommand(str, con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                update_nik.Text = rd.Item("nik")
                update_kk.Text = rd.Item("no_kk")
                update_nama.Text = rd.Item("nama")
                update_tl.Text = rd.Item("tempat_lahir")
                update_tgl.Text = rd.Item("tanggal_lahir")
                update_jk.Text = rd.Item("jenis_kelamin")
                update_cbgold.Text = rd.Item("golongan_darah")
                update_agama.Text = rd.Item("agama")
                update_alamat.Text = rd.Item("alamat")
                update_rt.Text = rd.Item("rt")
                update_rw.Text = rd.Item("rw")
                update_cbkel.Text = rd.Item("kelurahan")
                update_kec.Text = rd.Item("kecamatan")
                update_kota.Text = rd.Item("kota")
                update_prov.Text = rd.Item("provinsi")
                update_kodepos.Text = rd.Item("kode_pos")
                update_wn.Text = rd.Item("kewarganegaraan")
                update_cbpendidikan.Text = rd.Item("pendidikan")
                update_cbpekerjaan.Text = rd.Item("pekerjaan")
                update_statuskawin.Text = rd.Item("status_perkawinan")
                update_cb_statuskeluarga.Text = rd.Item("status_hubungan_keluarga")
                update_namaayah.Text = rd.Item("nama_ayah")
                update_namaibu.Text = rd.Item("nama_ibu")
                file_lbl.Text = rd.Item("foto")
            End If
            TabControl1.SelectedTab = TabPage4
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub update_jk_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles update_jk.TextChanged
        If update_jk.Text = "Perempuan" Then
            update_rbp.Checked = True
        Else
            update_rbl.Checked = True
        End If
    End Sub

    Private Sub update_wn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles update_wn.TextChanged
        If update_wn.Text = "Perempuan" Then
            update_rbwni.Checked = True
        Else
            update_wna.Checked = True
        End If
    End Sub

    Private Sub update_rbl_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles update_rbl.CheckedChanged
        If update_rbl.Checked = True Then
            update_jk.Text = update_rbl.Text
        End If
    End Sub

    Private Sub update_rbp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles update_rbp.CheckedChanged
        If update_rbp.Checked = True Then
            update_jk.Text = update_rbp.Text
        End If
    End Sub

    Private Sub update_rbwni_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles update_rbwni.CheckedChanged
        If update_rbwni.Checked = True Then
            update_wn.Text = update_rbwni.Text
        End If
    End Sub

    Private Sub update_wna_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles update_wna.CheckedChanged
        If update_wna.Checked = True Then
            update_wn.Text = update_wna.Text
        End If
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Dim Ofd = New OpenFileDialog()

        If Ofd.ShowDialog = Windows.Forms.DialogResult.Cancel Then
        Else
            file_lbl.Text = Ofd.SafeFileName
            update_foto.Text = Ofd.FileName
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

  

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        txt_static.Text = ""
        tampil()
        TabControl1.SelectedTab = TabPage1
    End Sub


    Private Sub txt_cari_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_cari.TextChanged
        Call koneksi()
        ap = New MySqlDataAdapter("select nik, no_kk, nama, status_hubungan_keluarga, tanggal_lahir from penduduk where nik like '%" & txt_cari.Text & "%'  or no_kk like '%" & txt_cari.Text & "%' or nama like '%" & txt_cari.Text & "%' or alamat like '%" & txt_cari.Text & "%' group by no_kk", con)
        dt = New DataSet
        ap.Fill(dt, "penduduk")
        DataGridView1.DataSource = dt.Tables("penduduk")
        Try
            DataGridView1.Columns(0).Width = 150
            DataGridView1.Columns(1).Width = 150
            DataGridView1.Columns(2).Width = 150
            DataGridView1.Columns(3).Width = 150
            DataGridView1.Columns(4).Width = 150
            DataGridView1.Columns(0).HeaderText = "NIK"
            DataGridView1.Columns(1).HeaderText = "NO KK"
            DataGridView1.Columns(2).HeaderText = "Nama"
            DataGridView1.Columns(3).HeaderText = "Status Keluarga"
            DataGridView1.Columns(4).HeaderText = "Tanggal Lahir"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        Call koneksi()
        ap = New MySqlDataAdapter("select nik, no_kk, nama, status_hubungan_keluarga, tanggal_lahir from penduduk where nik like '%" & txt_cari.Text & "%'  or no_kk like '%" & txt_cari.Text & "%' or nama like '%" & txt_cari.Text & "%' or alamat like '%" & txt_cari.Text & "%' group by no_kk", con)
        dt = New DataSet
        ap.Fill(dt, "penduduk")
        DataGridView1.DataSource = dt.Tables("penduduk")
        Try
            DataGridView1.Columns(0).Width = 150
            DataGridView1.Columns(1).Width = 150
            DataGridView1.Columns(2).Width = 150
            DataGridView1.Columns(3).Width = 150
            DataGridView1.Columns(4).Width = 150
            DataGridView1.Columns(0).HeaderText = "NIK"
            DataGridView1.Columns(1).HeaderText = "NO KK"
            DataGridView1.Columns(2).HeaderText = "Nama"
            DataGridView1.Columns(3).HeaderText = "Status Keluarga"
            DataGridView1.Columns(4).HeaderText = "Tanggal Lahir"
        Catch ex As Exception
        End Try
    End Sub

 

    Private Sub MinimizeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MinimizeToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub Button19_Click(sender As System.Object, e As System.EventArgs) Handles Button19.Click
        data_keluarga.Show()
        Me.Hide()
    End Sub


    Private Sub Button16_Click(sender As System.Object, e As System.EventArgs) Handles Button16.Click
        user.Show()
        Me.Hide()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Call koneksi()
        ap = New MySqlDataAdapter("select nik, no_kk, nama, status_hubungan_keluarga, tanggal_lahir, domisili from penduduk where domisili = '" & "Pindah" & "'", con)
            dt = New DataSet
            ap.Fill(dt, "penduduk")
            DataGridView1.DataSource = dt.Tables("penduduk")
        Try
            DataGridView1.Columns(0).Width = 150
            DataGridView1.Columns(1).Width = 150
            DataGridView1.Columns(2).Width = 150
            DataGridView1.Columns(3).Width = 150
            DataGridView1.Columns(4).Width = 150
            DataGridView1.Columns(5).Width = 150
            DataGridView1.Columns(0).HeaderText = "NIK"
            DataGridView1.Columns(1).HeaderText = "NO KK"
            DataGridView1.Columns(2).HeaderText = "Nama"
            DataGridView1.Columns(3).HeaderText = "Status Keluarga"
            DataGridView1.Columns(4).HeaderText = "Tanggal Lahir"
            DataGridView1.Columns(5).HeaderText = "Status"
        Catch ex As Exception
        End Try
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Call koneksi()
        ap = New MySqlDataAdapter("select nik, no_kk, nama, status_hubungan_keluarga, tanggal_lahir, domisili from penduduk where domisili = '" & "Pendatang" & "'", con)
        dt = New DataSet
        ap.Fill(dt, "penduduk")
        DataGridView1.DataSource = dt.Tables("penduduk")
        Try
            DataGridView1.Columns(0).Width = 150
            DataGridView1.Columns(1).Width = 150
            DataGridView1.Columns(2).Width = 150
            DataGridView1.Columns(3).Width = 150
            DataGridView1.Columns(4).Width = 150
            DataGridView1.Columns(5).Width = 150
            DataGridView1.Columns(0).HeaderText = "NIK"
            DataGridView1.Columns(1).HeaderText = "NO KK"
            DataGridView1.Columns(2).HeaderText = "Nama"
            DataGridView1.Columns(3).HeaderText = "Status Keluarga"
            DataGridView1.Columns(4).HeaderText = "Tanggal Lahir"
            DataGridView1.Columns(5).HeaderText = "Status"
        Catch ex As Exception
        End Try
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub txt_kk_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_kk.TextChanged
        Try
            Call koneksi()
            Dim str As String
            str = "select * from penduduk where no_kk = '" & txt_kk.Text & "'"
            cmd = New MySqlCommand(str, con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                cb_gold.Text = rd.Item("golongan_darah")
                cb_agama.Text = rd.Item("agama")
                rt_alamat.Text = rd.Item("alamat")
                txt_rt.Text = rd.Item("rt")
                txt_rw.Text = rd.Item("rw")
                cb_kelurahan.Text = rd.Item("kelurahan")
                txt_kecamatan.Text = rd.Item("kecamatan")
                txt_kota.Text = rd.Item("kota")
                txt_provinsi.Text = rd.Item("provinsi")
                txt_kodepos.Text = rd.Item("kode_pos")
                txt_wn.Text = rd.Item("kewarganegaraan")
                If txt_wn.Text = "WNI" Then
                    rb_wna.Checked = False
                    rb_wni.Checked = True
                ElseIf txt_wn.Text = "WNA" Then
                    rb_wna.Checked = True
                    rb_wni.Checked = False
                End If
                cb_pendidikan.Text = rd.Item("pendidikan")
                cb_pekerjaan.Text = rd.Item("pekerjaan")
                cb_statuskawin.Text = rd.Item("status_perkawinan")
                update_cb_statuskeluarga.Text = rd.Item("status_hubungan_keluarga")
                txt_namayah.Text = rd.Item("nama_ayah")
                txt_namaibu.Text = rd.Item("nama_ibu")
                rd.Close()
            Else
                txt_nama.Clear()
                txt_tl.Clear()
                txt_jk.Clear()
                rb_l.Checked = False
                rb_p.Checked = False
                cb_gold.Text = " Pilih.."
                cb_agama.Text = " Pilih.."
                cb_pendidikan.Text = " Pilih.."
                cb_pekerjaan.Text = " Pilih.."
                cb_pendidikan.Text = " Pilih.."
                cb_statuskawin.Text = " Pilih.."
                cb_statuskeluarga.Text = " Pilih.."
                rt_alamat.Clear()
                txt_rt.Clear()
                txt_rw.Clear()
                cb_kelurahan.Text = " Pilih.."
                txt_kecamatan.Text = "Andir"
                txt_kota.Text = "Bandung"
                txt_provinsi.Text = "Jawa Barat"
                txt_kodepos.Clear()
                rb_wna.Checked = False
                rb_wni.Checked = False
                txt_namayah.Clear()
                txt_namaibu.Clear()
                txt_foto.Clear()
                file1.Text = ""
                rd.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class