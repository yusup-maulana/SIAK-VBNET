Imports CrystalDecisions.CrystalReports.Engine
Public Class laporan


    Private Sub LogoutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        login.TextBox1.Text = ""
        login.TextBox2.Text = ""
        login.login_nip_1.Text = ""
        login.login_nama_1.Text = ""
        login.login_akses_1.Text = ""
        My.Settings.user3 = ""
        login.Show()
        Me.Hide()
    End Sub

    Private Sub MinimizeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MinimizeToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub




    Private Sub laporan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ToolStripDropDownButton2.Text = My.Settings.user3
    End Sub


    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Try
            If cb_pen.Text = "" Then
                MsgBox("Pilih terlebih dahulu")
            Else
                Dim str As String = "lap.rpt"
                Dim rpt As New ReportDocument()
                rpt.Load(str)
                If cb_pen.Text = "Seluruh kelurahan" Then
                    cb_pen.Text = ""
                    rpt.SetParameterValue("v", "Seluruh kelurahan")
                Else
                    rpt.SetParameterValue("v", "kelurahan : ")
                End If
                rpt.SetParameterValue("suket", cb_pen.Text)
                crpenduduk.Refresh()
                crpenduduk.ReportSource = rpt
                crpenduduk.Show()
            End If
        

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Try
            If cbktp1.Text = "" Then
                MsgBox("Pilih terlebih dahulu")
            Else
                Dim str As String = "lapktp.rpt"
                Dim rpt As New ReportDocument()
                rpt.Load(str)
                If cbktp1.Text = "Seluruh kelurahan" Then
                    rpt.SetParameterValue("kel", "")
                    rpt.SetParameterValue("v", "Seluruh kelurahan")
                Else
                    rpt.SetParameterValue("kel", cbktp1.Text)
                    rpt.SetParameterValue("v", "kelurahan : ")
                End If
                rpt.SetParameterValue("TanggalMulai", DateTimePicker1.Text)
                rpt.SetParameterValue("TanggalSelesai", DateTimePicker2.Text)

                If txtktp1status.Text = "" Then
                    rpt.SetParameterValue("status", "")
                    rpt.SetParameterValue("s", "Semua kategori")
                Else
                    rpt.SetParameterValue("status", txtktp1status.Text)
                    rpt.SetParameterValue("s", txtktp1status.Text)
                End If

                crktp.Refresh()
                crktp.ReportSource = rpt
                crktp.Show()
            End If


        Catch ex As Exception
        End Try
     
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Try
            If cb_kel.Text = "" Then
                MsgBox("Pilih terlebih dahulu")
            Else
                Dim str As String = "lap2.rpt"
                Dim rpt As New ReportDocument()
                rpt.Load(str)
                If cb_kel.Text = "Seluruh kelurahan" Then
                    cb_kel.Text = ""
                    rpt.SetParameterValue("v", "Seluruh kelurahan")
                Else
                    rpt.SetParameterValue("v", "kelurahan : ")
                End If
                rpt.SetParameterValue("suket", cb_kel.Text)
                crkel.Refresh()
                crkel.ReportSource = rpt
                crkel.Show()
            End If


        Catch ex As Exception
        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        txtktp1status.Text = "Selesai"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        txtktp1status.Text = "Gagal"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged
        txtktp1status.Text = "Salah Cetak"
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton4.CheckedChanged
        txtktp1status.Text = "Proses"
    End Sub
    Private Sub RadioButton25_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton25.CheckedChanged
        txtktp1status.Text = ""
    End Sub

    Private Sub RadioButton27_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton27.CheckedChanged
        txtktp2pemohon.Text = "Baru"
    End Sub

    Private Sub RadioButton28_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton28.CheckedChanged
        txtktp2pemohon.Text = "Perubahan data"
    End Sub

    Private Sub RadioButton30_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton30.CheckedChanged
        txtktp2pemohon.Text = "Cetak ulang"
    End Sub

    Private Sub RadioButton26_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton26.CheckedChanged
        txtktp2pemohon.Text = ""
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        Try
            If cbkel2.Text = "" Then
                MsgBox("Pilih terlebih dahulu")
            Else
                Dim str As String = "lapktp2.rpt"
                Dim rpt As New ReportDocument()
                rpt.Load(str)
                If cbkel2.Text = "Seluruh kelurahan" Then
                    rpt.SetParameterValue("kel", "")
                    rpt.SetParameterValue("v", "Seluruh kelurahan")
                Else
                    rpt.SetParameterValue("kel", cbkel2.Text)
                    rpt.SetParameterValue("v", "kelurahan : ")
                End If
                rpt.SetParameterValue("TanggalMulai", dtp2.Text)
                rpt.SetParameterValue("TanggalSelesai", dtp21.Text)

                If txtktp2pemohon.Text = "" Then
                    rpt.SetParameterValue("status", "")
                    rpt.SetParameterValue("s", "Semua kategori")
                Else
                    rpt.SetParameterValue("status", txtktp2pemohon.Text)
                    rpt.SetParameterValue("s", txtktp2pemohon.Text)
                End If

                crktp.Refresh()
                crktp.ReportSource = rpt
                crktp.Show()
            End If


        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            If cbskk.Text = "" Then
                MsgBox("Pilih terlebih dahulu")
            Else
                Dim str As String = "lapkk.rpt"
                Dim rpt As New ReportDocument()
                rpt.Load(str)
                If cbskk.Text = "Seluruh kelurahan" Then
                    rpt.SetParameterValue("kel", "")
                    rpt.SetParameterValue("v", "Seluruh kelurahan")
                Else
                    rpt.SetParameterValue("kel", cbskk.Text)
                    rpt.SetParameterValue("v", "kelurahan : ")
                End If
                rpt.SetParameterValue("TanggalMulai", dtpstartkk.Text)
                rpt.SetParameterValue("TanggalSelesai", dtpendkk.Text)

                If txtskk.Text = "" Then
                    rpt.SetParameterValue("status", "")
                    rpt.SetParameterValue("s", "Semua kategori")
                Else
                    rpt.SetParameterValue("status", txtskk.Text)
                    rpt.SetParameterValue("s", txtskk.Text)
                End If

                crkk.Refresh()
                crkk.ReportSource = rpt
                crkk.Show()
            End If


        Catch ex As Exception
        End Try
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton6.CheckedChanged
        txtskk.Text = "Selesai"
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton7.CheckedChanged
        txtskk.Text = "Gagal"
    End Sub

    Private Sub RadioButton29_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton29.CheckedChanged
        txtskk.Text = "Salah Cetak"
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton8.CheckedChanged
        txtskk.Text = "Proses"
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton5.CheckedChanged
        txtskk.Text = ""
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        Try
            If cbpkk.Text = "" Then
                MsgBox("Pilih terlebih dahulu")
            Else
                Dim str As String = "lapkk2.rpt"
                Dim rpt As New ReportDocument()
                rpt.Load(str)
                If cbpkk.Text = "Seluruh kelurahan" Then
                    rpt.SetParameterValue("kel", "")
                    rpt.SetParameterValue("v", "Seluruh kelurahan")
                Else
                    rpt.SetParameterValue("kel", cbpkk.Text)
                    rpt.SetParameterValue("v", "kelurahan : ")
                End If
                rpt.SetParameterValue("TanggalMulai", dtppkk1.Text)
                rpt.SetParameterValue("TanggalSelesai", dtppkk2.Text)

                If txtpkk.Text = "" Then
                    rpt.SetParameterValue("status", "")
                    rpt.SetParameterValue("s", "Semua kategori")
                Else
                    rpt.SetParameterValue("status", txtpkk.Text)
                    rpt.SetParameterValue("s", txtpkk.Text)
                End If

                crkk.Refresh()
                crkk.ReportSource = rpt
                crkk.Show()
            End If


        Catch ex As Exception
        End Try
    End Sub

    Private Sub RadioButton32_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton32.CheckedChanged
        txtpkk.Text = "Baru"
    End Sub

    Private Sub RadioButton33_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton33.CheckedChanged
        txtpkk.Text = "Perubahan data"
    End Sub

    Private Sub RadioButton34_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton34.CheckedChanged
        txtpkk.Text = "Cetak ulang"
    End Sub

    Private Sub RadioButton31_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton31.CheckedChanged
        txtpkk.Text = ""
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
         
            Dim str As String = "lappindah.rpt"
                Dim rpt As New ReportDocument()
                rpt.Load(str)
            rpt.SetParameterValue("TanggalMulai", dtppindah1.Text)
            rpt.SetParameterValue("TanggalSelesai", dtppindah2.Text)
            crpindah.Refresh()
            crpindah.ReportSource = rpt
            crpindah.Show()



        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Try

            Dim str As String = "lappendatang.rpt"
            Dim rpt As New ReportDocument()
            rpt.Load(str)
            rpt.SetParameterValue("TanggalMulai", dtppen1.Text)
            rpt.SetParameterValue("TanggalSelesai", dtppen2.Text)
            crpendatang.Refresh()
            crpendatang.ReportSource = rpt
            crpendatang.Show()



        Catch ex As Exception
        End Try
    End Sub
End Class