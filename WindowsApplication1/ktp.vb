Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class ktp
    Sub btnambilktp()
        Try

            Call koneksi()
            Dim wwwwwww As String
            wwwwwww = "select * from  ktp where no_reg = '" & lbl_id.Text & "'"
            cmd = New MySqlCommand(wwwwwww, con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                txtnoreg.Text = rd.Item("no_reg")
                txttglreg.Text = rd.Item("tgl_reg")
                txttlselesai.Text = rd.Item("tgl_selesai")
                txtnik.Text = rd.Item("nik")
                txtjenispermoonan.Text = rd.Item("jenis_permohonan")
                txtstatus.Text = rd.Item("status")
                txtket.Text = rd.Item("keterangan")
                txttglmbil.Text = rd.Item("tgl_diambil")
            End If
        Catch ex As Exception
        End Try

        Try
            Dim wwwwwww2 As String
            wwwwwww2 = "select * from  penduduk where nik = '" & txtnik.Text & "'"
            cmd = New MySqlCommand(wwwwwww2, con)
            rd.Close()
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                txtnokk.Text = rd.Item("no_kk")
                txtnama.Text = rd.Item("nama")
                txtttl.Text = rd.Item("tempat_lahir") & ", " & rd.Item("tanggal_lahir")
                txtjk.Text = rd.Item("jenis_kelamin")
                txtagama.Text = rd.Item("agama")
                txtalamat.Text = rd.Item("alamat")
                txtrtrw.Text = rd.Item("rt") & " / " & rd.Item("rw")
                txtkelurahan.Text = rd.Item("kelurahan")
                txtstatuskawin.Text = rd.Item("status_perkawinan")
                txthubkel.Text = rd.Item("status_hubungan_keluarga")
                txtpekerjaan.Text = rd.Item("pekerjaan")
            End If
        Catch ex As Exception

        End Try
        TabControl1.SelectedTab = TabPage3
    End Sub
    Sub btnstatusktp()
        Try
            Dim i As Integer = DataGridView1.CurrentRow.Index
            lnoreg.Text = DataGridView1.Item(0, i).Value
            ltglreg.Text = DataGridView1.Item(1, i).Value
            lnik.Text = DataGridView1.Item(2, i).Value
            lnama.Text = DataGridView1.Item(3, i).Value

            TabControl1.SelectedTab = TabPage2
        Catch ex As Exception

        End Try
    End Sub
    Sub btnhapusdata()
        Try
            Call koneksi()
            cmd = New MySqlCommand("delete from ktp where no_reg='" & lbl_id.Text & "'", con)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di hapus", MsgBoxStyle.Information)
            Call tampil()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
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
    Sub tampil()
        Call koneksi()
        ap = New MySqlDataAdapter("select ktp.no_reg, ktp.tgL_reg, ktp.nik, penduduk.nama, ktp.status from ktp inner join penduduk on penduduk.nik = ktp.nik", con)
        dt = New DataSet
        ap.Fill(dt, "ktp")
        DataGridView1.DataSource = dt.Tables("ktp")
        Try
            DataGridView1.Columns(0).HeaderText = "No Reg"
            DataGridView1.Columns(1).HeaderText = "Tanggal Reg"
            DataGridView1.Columns(2).HeaderText = "NIK"
            DataGridView1.Columns(3).HeaderText = "Nama"
            DataGridView1.Columns(4).HeaderText = "status"
        Catch ex As Exception
        End Try
    End Sub
    Sub tampildgv2()

    End Sub


    Private Sub ktp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil()
        DataGridView2.Visible = False
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal
        ToolStripDropDownButton2.Text = My.Settings.user2
    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cari.TextChanged, txt_cari.TextChanged
        Call koneksi()
        ap = New MySqlDataAdapter("select ktp.no_reg, ktp.tgL_reg, ktp.nik, penduduk.nama, ktp.status from ktp  inner join penduduk on penduduk.nik = ktp.nik  where penduduk.nama like '%" & txt_cari.Text & "%' or  ktp.nik like '%" & txt_cari.Text & "%' or  ktp.status like '%" & txt_cari.Text & "%' or  ktp.no_reg like '%" & txt_cari.Text & "%' or  ktp.tgl_reg like '%" & txt_cari.Text & "%'", con)
        dt = New DataSet
        ap.Fill(dt, "ktp")
        DataGridView1.DataSource = dt.Tables("ktp")
        Try
            DataGridView1.Columns(0).HeaderText = "No Reg"
            DataGridView1.Columns(1).HeaderText = "Tanggal Reg"
            DataGridView1.Columns(2).HeaderText = "NIK"
            DataGridView1.Columns(3).HeaderText = "Nama"
            DataGridView1.Columns(4).HeaderText = "status"
        Catch ex As Exception
        End Try
    End Sub



    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        Try
            Dim i As Integer = DataGridView1.CurrentRow.Index
            lbl_id.Text = DataGridView1.Item(0, i).Value
            tzt_nama.Text = DataGridView1.Item(3, i).Value
            tzt_status.Text = DataGridView1.Item(4, i).Value

            If tzt_status.Text = "Salah Cetak" Then

                tzt_status.ForeColor = Color.Red
            ElseIf tzt_status.Text = "Gagal" Then

                tzt_status.ForeColor = Color.Red
            Else
                tzt_status.ForeColor = Color.Green

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cb_peermohon.Text = "" Then
            MsgBox("Pilih terlebih dahulu Permohonan", MsgBoxStyle.Critical)
        ElseIf txt_nik_permohon.Text = "" Then
            MsgBox("Nik Masih Kosong", MsgBoxStyle.Critical)
        Else


            koneksi()
            Try
                Dim tglnow As String = Format(Now, "yyyy-MM-dd")
                Dim tglplus14 As String = Format(DateAdd("d", 15 - 1, Now), "yyyy-MM-dd")

                Dim str As String = "select * from ktp where nik = '" & txt_nik_permohon.Text & "' and tgl_diambil ='" & "" & "'"
                cmd = New MySqlCommand(str, con)

                rd = cmd.ExecuteReader
                If rd.Read Then
                    MsgBox("Perhatian : untuk data " & rd.Item("nik") & " sedang dalam tahap proses", MsgBoxStyle.Critical)
                    rd.Close()
                Else
                    rd.Close()
                    Dim str2 As String = "select * from ktp where nik = '" & txt_nik_permohon.Text & "' and jenis_permohonan ='" & cb_peermohon.Text & "'"
                    cmd = New MySqlCommand(str2, con)
                    rd.Close()
                    rd = cmd.ExecuteReader
                    If rd.Read Then
                        MsgBox("Perhatian : untuk data " & rd.Item("nik") & " Sudah membuat permohonan Baru pada tanggal " & rd.Item("tgl_reg"), MsgBoxStyle.Critical)
                        rd.Close()
                    Else
                        rd.Close()
                        Dim query As String = "insert into ktp (tgl_reg, tgl_selesai, jenis_permohonan, nik, status, keterangan, tgl_diambil, nip_petugas) values ('" & tglnow & "','" & tglplus14 & "','" & cb_peermohon.Text & "','" & txt_nik_permohon.Text & "','" & "Proses" & "','" & "" & "','" & "" & "','" & My.Settings.nip2 & "')"
                        cmd = New MySqlCommand(query, con)
                        cmd.ExecuteNonQuery()
                        MsgBox("Data berhasil di simpan", MsgBoxStyle.Information)
                    End If
                End If

                rd.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try



        End If
    End Sub

    Private Sub txt_nik_permohon_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_nik_permohon.GotFocus
      
         
        DataGridView2.Visible = True

    End Sub

    Private Sub txt_nik_permohon_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_nik_permohon.TextChanged
        lbl_nama_permohonan.Text = ""
        lbl_nik_pemohon.Text = ""
        If txt_nik_permohon.Text = "" Then
            DataGridView2.Visible = False
            btnsuket.Visible = False
        Else
            DataGridView2.Visible = True
            btnsuket.Visible = True
            Dim table As DataTable
            ap = New MySqlDataAdapter("select nik, nama from penduduk where nik like '%" & txt_nik_permohon.Text & "%' or nama like '%" & txt_nik_permohon.Text & "%'", con)
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

    Private Sub DataGridView2_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Try
            Dim i As Integer = DataGridView2.CurrentRow.Index
            txt_nik_permohon.Text = DataGridView2.Item(0, i).Value
            lbl_nama_permohonan.Text = DataGridView2.Item(1, i).Value

            lbl_nik_pemohon.Text = DataGridView2.Item(0, i).Value
            DataGridView2.Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView2_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick
        Try
            Dim i As Integer = DataGridView2.CurrentRow.Index
            txt_nik_permohon.Text = DataGridView2.Item(0, i).Value
            lbl_nama_permohonan.Text = DataGridView2.Item(1, i).Value
            lbl_nik_pemohon.Text = DataGridView2.Item(0, i).Value
        Catch ex As Exception

        End Try
    End Sub



    Private Sub DataGridView2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView2.LostFocus
        DataGridView2.Visible = False
    End Sub



    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles btnupdate.Click
        Call koneksi()
        Dim j As String = "update ktp set status ='" & tstatus.Text & "', keterangan='" & tket.Text & "'where no_reg='" & lnoreg.Text & "'"
        cmd = New MySqlCommand(j, con)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Di Ubah", MsgBoxStyle.Information, "Mengubah Data")
        TabControl1.SelectedTab = TabPage1
        tampil()
    End Sub

    Private Sub rbselesai_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbselesai.CheckedChanged

        tstatus.Text = "Selesai"
        tket.Text = "Selesai Cetak"
    End Sub

    Private Sub rbgagal_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbgagal.CheckedChanged

        tstatus.Text = "Gagal"
        tket.Text = "Hasil cetak jelek"
    End Sub

    Private Sub rbsalahcetak_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbsalahcetak.CheckedChanged

        tstatus.Text = "Salah Cetak"
        tket.Text = "Data tidak sinkron"
    End Sub

    

    Private Sub btnpengmbilan_Click(sender As System.Object, e As System.EventArgs) Handles btnpengmbilan.Click
        Call koneksi()
        If txttglmbil.Text = "-" Or txttglmbil.Text = "" Then
            If txtstatus.Text = "Selesai" Then
                Dim tglnow As String = Format(Now, "yyyy-MM-dd")
                Dim j As String = "update ktp set tgl_diambil ='" & tglnow & "' where no_reg='" & txtnoreg.Text & "'"
                cmd = New MySqlCommand(j, con)
                cmd.ExecuteNonQuery()
                MsgBox("Pengambilan KTP di catat untuk " & txtnama.Text, MsgBoxStyle.Information, "Pemnambilan KTP")
                TabControl1.SelectedTab = TabPage1
                tampil()
            ElseIf txtstatus.Text = "Gagal" Then
                MsgBox("Pengambilan KTP dengan nama " & txtnama.Text & " , tidak bisa di ambil dikarenakan Gagal " & txttglmbil.Text, MsgBoxStyle.Critical, "Pemnambilan KTP")
            ElseIf txtstatus.Text = "Salah Cetak" Then
                MsgBox("Pengambilan KTP dengan nama " & txtnama.Text & " , tidak bisa di ambil dikarenakan Salah Cetak " & txttglmbil.Text, MsgBoxStyle.Critical, "Pemnambilan KTP")
            ElseIf txtstatus.Text = "Proses" Then
                MsgBox("Pengambilan KTP dengan nama " & txtnama.Text & " , tidak bisa di ambil dikarenakan masih di proses " & txttglmbil.Text, MsgBoxStyle.Critical, "Pemnambilan KTP")
            End If
        Else
            If txtstatus.Text = "Proses" Then
                MsgBox("Pengambilan KTP dengan nama " & txtnama.Text & " , tidak bisa di ambil dikarenakan masih di proses " & txttglmbil.Text, MsgBoxStyle.Critical, "Pemnambilan KTP")
            ElseIf txtstatus.Text = "Salah Cetak" Then
                MsgBox("Pengambilan KTP dengan nama " & txtnama.Text & " , tidak bisa di ambil dikarenakan Salah Cetak " & txttglmbil.Text, MsgBoxStyle.Critical, "Pemnambilan KTP")
            ElseIf txtstatus.Text = "Gagal" Then
                MsgBox("Pengambilan KTP dengan nama " & txtnama.Text & " , tidak bisa di ambil dikarenakan Gagal " & txttglmbil.Text, MsgBoxStyle.Critical, "Pemnambilan KTP")
            Else
                MsgBox("Pengambilan KTP dengan nama " & txtnama.Text & " , sudah di ambil pada tanggal " & txttglmbil.Text, MsgBoxStyle.Critical, "Pemnambilan KTP")
            End If
        End If


    End Sub

    Private Sub btnsuket_Click(sender As System.Object, e As System.EventArgs) Handles btnsuket.Click
        Try
            Dim str As String = "suket.rpt"
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


    Private Sub KKKartuKeluargaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        kk.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub MinimizeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MinimizeToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
   


    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles btnhapus.Click
        btnhapusdata()
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles btncektatus.Click
        btnstatusktp()
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles btnambil.Click
        btnambilktp()
    End Sub

    Private Sub Button18_Click(sender As System.Object, e As System.EventArgs) Handles Button18.Click
        kk.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click_1(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        pendatang.Show()
        Me.Hide()
    End Sub

    Private Sub Button17_Click(sender As System.Object, e As System.EventArgs) Handles Button17.Click
        pindah.Show()
        Me.Hide()
    End Sub

   

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles btnberanda.Click
        TabControl1.SelectedTab = TabPage1
        tampil()
    End Sub

    Private Sub DataGridView2_MouseLeave(sender As Object, e As System.EventArgs) Handles DataGridView2.MouseLeave

    End Sub


End Class