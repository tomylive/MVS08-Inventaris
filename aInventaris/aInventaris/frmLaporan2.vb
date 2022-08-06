Public Class frmLaporan2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        crv.RefreshReport()
        Me.crv.ReportSource = New rptInventaris
        crv.SelectionFormula = "day({inventaris.Tanggal})=" & dtpTanggal.Value.Day & " and month({inventaris.Tanggal})=" & dtpTanggal.Value.Month & " and year({inventaris.Tanggal})=" & dtpTanggal.Value.Year
        Try
        Catch ex As Exception
        End Try
        dtpTanggal.Value = Now
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        crv.RefreshReport()
        Me.crv.ReportSource = New rptInventaris
        crv.SelectionFormula = "month({inventaris.Tanggal})=" & dtpTanggal.Value.Month & " and year({inventaris.Tanggal})=" & dtpTanggal.Value.Year
        Try
        Catch ex As Exception
        End Try
        dtpTanggal.Value = Now
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        crv.RefreshReport()
        Me.crv.ReportSource = New rptInventaris
        crv.SelectionFormula = "year({inventaris.Tanggal})=" & dtpTanggal.Value.Year
        Try
        Catch ex As Exception
        End Try
        dtpTanggal.Value = Now
    End Sub
End Class