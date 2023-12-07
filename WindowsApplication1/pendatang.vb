Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class pendatang
    Sub tampil()
        ap = New MySqlDataAdapter("select no_reg,nik2,tgl_reg,namalengkap,alamatasal,alamatpindah,klasifikasipindah from pendatang", con)
        dt = New DataSet
        ap.Fill(dt, "pendatang")
        DataGridView1.DataSource = dt.Tables("pendatang")
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
    Private Sub Button16_Click(sender As System.Object, e As System.EventArgs) Handles Button16.Click
        ktp.Show()
        Me.Hide()
    End Sub

    Private Sub Button18_Click(sender As System.Object, e As System.EventArgs) Handles Button18.Click
        kk.Show()
        Me.Hide()
    End Sub

    Private Sub Button17_Click(sender As System.Object, e As System.EventArgs) Handles Button17.Click
        pindah.Show()
        Me.Hide()
    End Sub

    Private Sub btnberanda_Click(sender As System.Object, e As System.EventArgs) Handles btnberanda.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub btnambil_Click(sender As System.Object, e As System.EventArgs) Handles btnambil.Click
        Call tampil()
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub btnhapus_Click(sender As System.Object, e As System.EventArgs) Handles btnhapus.Click
        Dim i As Integer = DataGridView1.CurrentRow.Index
        Dim a As String = DataGridView1.Item(1, i).Value
        Dim wwwwwww2 As String
        wwwwwww2 = "select * from  pendatang where nik2 = '" & a & "'"
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

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click

        Dim i As Integer = DataGridView1.CurrentRow.Index
        Dim a As String = DataGridView1.Item(0, i).Value
        Dim wwwwwww2 As String
        wwwwwww2 = "select * from  pendatang where no_reg = '" & a & "'"
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

    Private Sub txt_cari_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_cari.TextChanged
        ap = New MySqlDataAdapter("select  no_reg,nik2,tgl_reg,namalengkap,alamatasal,alamatpindah,klasifikasipindah from pendatang  where namalengkap like '%" & txt_cari.Text & "%' or  tgl_reg like '%" & txt_cari.Text & "%' or  alamatpindah like '%" & txt_cari.Text & "%' or  alamatasal like '%" & txt_cari.Text & "%' or  klasifikasipindah like '%" & txt_cari.Text & "%'", con)
        dt = New DataSet
        ap.Fill(dt, "pendatang")
        DataGridView1.DataSource = dt.Tables("pendatang")
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



    Private Sub DataGridView1_SelectionChanged(sender As Object, e As System.EventArgs) Handles DataGridView1.SelectionChanged
        Try
            Dim i As Integer = DataGridView1.CurrentRow.Index
            txtnik.Text = DataGridView1.Item(1, i).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Try
            Dim str As String = "..\..\pendatangsurat.rpt"
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

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Try
            Dim j As String = "update pendatang set alasanpindah ='" & upalasanpindah.Text & "', alamatpindah='" & upalasanpindah.Text & "', kelurahanpindah='" & upkel.Text & "', kecpindah='" & upkec.Text & "', kotapindah='" & upkota.Text & "', provinsipindah='" & upprov.Text & "', klasifikasipindah='" & upklasifikasi.Text & "', jenispindah='" & upjenispindah.Text & "'where nik2='" & txtnik.Text & "'"
            cmd = New MySqlCommand(j, con)
            cmd.ExecuteNonQuery()
            Dim j2 As String = "update penduduk set domisili ='" & "Pendatang" & "'where nik='" & txtnik.Text & "'"
            cmd = New MySqlCommand(j2, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("data tersebut sudah ada", MsgBoxStyle.Critical)
        End Try
        Call tampil()
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub pendatang_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        koneksi()
        ToolStripDropDownButton2.Text = My.Settings.user2
    End Sub
    Sub bersih()
        txt_nik.Clear()
        txt_kk.Clear()
        txt_nama.Clear()
        txt_tl.Clear()
        txt_jk.Clear()
        rbll.Checked = False
        rbpp.Checked = False
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

        txtalamattujuan.Text = ""
        txtalasanpindah.Text = ""
        txtkecpindah.Text = ""
        txtkelurahanpindah.Text = ""
        txtkotapindah.Text = "Bandung"
        txtprovpindah.Text = "Jawa Barat"
        cbjenispindah.Text = "Antar Kecamatan"
        cbklasifikasi.Text = "Anggota keluarga"
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim wwwwwww2 As String
        wwwwwww2 = "select nik,no_kk from  penduduk where nik = '" & txt_nik.Text & "'and no_kk = '" & txt_kk.Text & "'"
        cmd = New MySqlCommand(wwwwwww2, con)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            MsgBox("Nik/NoKK tersebut sudah ada", MsgBoxStyle.Critical)
            rd.Close()
        Else
            rd.Close()
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


                Dim a As String = "INSERT INTO penduduk  VALUES ('" & txt_nik.Text & "','" & txt_kk.Text & "','" & txt_nama.Text & "','" & txt_tl.Text & "','" & txt_tgl.Text & "','" & txt_jk.Text & "','" & cb_gold.Text & "','" & cb_agama.Text & "','" & rt_alamat.Text & "','" & txt_rt.Text & "','" & txt_rw.Text & "','" & cb_kelurahan.Text & "','" & txt_kecamatan.Text & "','" & txt_kota.Text & "','" & txt_provinsi.Text & "','" & txt_kodepos.Text & "','" & txt_wn.Text & "','" & cb_pendidikan.Text & "','" & cb_pekerjaan.Text & "','" & cb_statuskawin.Text & "','" & cb_statuskeluarga.Text & "','" & txt_namayah.Text & "','" & txt_namaibu.Text & "','" & file1.Text & "','" & "Pendatang" & "')"
                cmd = New MySqlCommand(a, con)
                cmd.ExecuteNonQuery()
                FFOperation(txt_foto.Text, "foto/", ffAction.FO_COPY, ffFlags.FOF_SILENT)
                MsgBox("Data berhasil di simpan", MsgBoxStyle.Information)
                Try

                    Dim tglnow As String = Format(Now, "yyyy-MM-dd")
                    Dim query As String = "insert into pendatang (tgl_reg, no_kk, namakepalakeluarga, nik2, alamatasal, kelurahanasal, kecasal, kotaasal,provinsi,namalengkap,alasanpindah,alamatpindah,kelurahanpindah,kecpindah,kotapindah,provinsipindah,klasifikasipindah,jenispindah,nip_petugas) values ('" & tglnow & "','" & txt_kk.Text & "','" & cb_statuskeluarga.Text & "','" & txt_nik.Text & "','" & rt_alamat.Text & "','" & cb_kelurahan.Text & "','" & txt_kecamatan.Text & "','" & txt_kota.Text & "','" & txt_provinsi.Text & "','" & txt_nama.Text & "','" & txtalasanpindah.Text & "','" & txtalamattujuan.Text & "','" & txtkelurahanpindah.Text & "','" & txtkecpindah.Text & "','" & txtkotapindah.Text & "','" & txtprovpindah.Text & "','" & cbklasifikasi.Text & "','" & cbjenispindah.Text & "','" & My.Settings.nip2 & "')"
                    cmd = New MySqlCommand(query, con)
                    cmd.ExecuteNonQuery()
                    Dim j As String = "update penduduk set domisili ='" & "Pendatang" & "'where nik='" & txt_nik.Text & "'"
                    cmd = New MySqlCommand(j, con)
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox("a")
                End Try
                Try
                    Dim str As String = "..\..\pendatangsurat.rpt"
                    Dim rpt As New ReportDocument()
                    rpt.Load(str)
                    rpt.SetParameterValue("suket", txt_nik.Text)
                    suket.Refresh()
                    suket.ReportSource = rpt
                    suket.Show()
                    TabControl1.SelectedTab = TabPage4
                Catch ex As Exception
                End Try
            End If

        End If

    End Sub


    Private Sub rb_wni_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rb_wni.CheckedChanged
        If rb_wni.Checked = True Then
            txt_wn.Text = rb_wni.Text
        End If
    End Sub

    Private Sub rb_wna_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rb_wna.CheckedChanged
        If rb_wna.Checked = True Then
            txt_wn.Text = rb_wna.Text
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        bersih()
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

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbll.CheckedChanged
        If rbll.Checked = True Then
            txt_jk.Text = rbll.Text
        End If
    End Sub

    Private Sub rbpp_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbpp.CheckedChanged
        If rbpp.Checked = True Then
            txt_jk.Text = rbpp.Text
        End If
    End Sub

    Private Sub btn_browse_Click(sender As System.Object, e As System.EventArgs) Handles btn_browse.Click
        Dim Ofd = New OpenFileDialog()

        If Ofd.ShowDialog = Windows.Forms.DialogResult.Cancel Then
        Else
            file1.Text = Ofd.SafeFileName
            txt_foto.Text = Ofd.FileName
        End If
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

                txt_namayah.Text = rd.Item("nama_ayah")
                txt_namaibu.Text = rd.Item("nama_ibu")
                rd.Close()
            Else
                txt_nama.Clear()
                txt_tl.Clear()
                txt_jk.Clear()
                rbll.Checked = False
                rbpp.Checked = False
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