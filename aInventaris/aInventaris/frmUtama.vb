Imports System.Windows.Forms
Public Class frmUtama
    Sub buka(ByVal frm As Form)
        frm.MdiParent = Me
        frm.Show()
        frm.BringToFront()
    End Sub
    Private Sub BarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangToolStripMenuItem.Click
        buka(frmBarang)
    End Sub

    Private Sub KondisiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KondisiToolStripMenuItem.Click
        buka(frmKondisi)
    End Sub

    Private Sub RuanganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RuanganToolStripMenuItem.Click
        buka(frmRuangan)
    End Sub

    Private Sub InventarisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventarisToolStripMenuItem.Click
        buka(frmInventaris)
    End Sub

    Private Sub BarangToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangToolStripMenuItem1.Click
        Try
            frmLaporan.CrystalReportViewer1.ReportSource = New rptBarang
            buka(frmLaporan)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        If MsgBox("Ingin Log Out?", MsgBoxStyle.Critical + vbYesNo) = MsgBoxResult.Yes Then
            frmLogin.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        If MsgBox("Ingin Keluar?", MsgBoxStyle.Critical + vbYesNo) = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub PenggunaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenggunaToolStripMenuItem.Click
        buka(frmUser)
    End Sub

    Private Sub KondisiToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KondisiToolStripMenuItem1.Click
        Try
            frmLaporan.CrystalReportViewer1.ReportSource = New rptKondisi
            buka(frmLaporan)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RuanganToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RuanganToolStripMenuItem1.Click
        Try
            frmLaporan.CrystalReportViewer1.ReportSource = New rptRuangan
            buka(frmLaporan)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub InventarisToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventarisToolStripMenuItem1.Click
        Try
            frmLaporan2.crv.ReportSource = New rptInventaris
            buka(frmLaporan2)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class