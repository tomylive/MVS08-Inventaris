Public Class frmRuangan
    Dim WithEvents ruangan As New oop
    Dim statusKu As Integer
    Enum _status
        Baru = 0
        Simpan = 1
        Edit = 2
    End Enum
    Sub Status(ByVal st As _status)
        statusKu = st
        Select Case st
            Case 0
                cmdBaru.Enabled = True
                cmdSimpan.Enabled = False
                cmdEdit.Enabled = False
                cmdHapus.Enabled = False
                cmdBatal.Enabled = False
                cmdKeluar.Enabled = True
            Case 1
                cmdBaru.Enabled = False
                cmdSimpan.Enabled = True
                cmdEdit.Enabled = False
                cmdHapus.Enabled = False
                cmdBatal.Enabled = True
                cmdKeluar.Enabled = False
            Case 2
                cmdBaru.Enabled = False
                cmdSimpan.Enabled = False
                cmdEdit.Enabled = True
                cmdHapus.Enabled = True
                cmdBatal.Enabled = True
                cmdKeluar.Enabled = False
        End Select
    End Sub
    Sub hapusInput()
        Dim obj
        Dim hapus() = {input0, input1, input2}
        For Each obj In hapus
            obj.text = ""
        Next
    End Sub
    Sub DisableInput(Optional ByVal t As Boolean = True)
        Dim obj
        Dim hapus() = {input0, input1, input2}
        For Each obj In hapus
            If t Then
                obj.enabled = False
            Else
                obj.enabled = True
            End If
        Next
    End Sub
    Dim listSql As String = "select *from ruangan order by nama asc"
    Private Sub frmruangan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ruangan.NamaDatabase = "dbinventaris"
        ruangan.NamaTabel = "ruangan"
        Dim deskripsi() As String = {"kode", "nama", "keterangan"}
        Dim value() = {input0, input1, input2}
        ruangan.DeskripsiTAbel = deskripsi
        ruangan.ObjekTabelValue = value
        Dim listKu As String() = {"kode", "nama", "keterangan"}
        Dim listSize As Integer() = {100, 100, 100, 200}
        ruangan.ListViewKu.Tambah(Me.lv, listKu, listSize, listSql)
        Status(_status.Baru)
        hapusInput()
        DisableInput()
    End Sub

    Private Sub cmdBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBaru.Click
        hapusInput()
        input0.Enabled = True
        input0.Focus()
    End Sub

    Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
        ruangan.Aksi = oop.enumAksi.Simpan
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        ruangan.Aksi = oop.enumAksi.Edit
    End Sub

    Private Sub cmdHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHapus.Click
        ruangan.Aksi = oop.enumAksi.Hapus
    End Sub
    Private Sub ruangan_Setelah_Data_Teredit(ByVal Pesan As String, ByVal isError As Boolean) Handles ruangan.Setelah_Data_Teredit
        MsgBox(Pesan)
        If Not isError Then
            ruangan.ListViewKu.Segarkan(0)
            Status(_status.Baru)
        End If
    End Sub

    Private Sub ruangan_Setelah_Data_Terhapus(ByVal Pesan As String, ByVal isError As Boolean) Handles ruangan.Setelah_Data_Terhapus
        MsgBox(Pesan)
        If Not isError Then
            ruangan.ListViewKu.Segarkan(0)
            Status(_status.Baru)
        End If
    End Sub

    Private Sub ruangan_Setelah_Data_Tersimpan(ByVal Pesan As String, ByVal isError As Boolean) Handles ruangan.Setelah_Data_Tersimpan
        MsgBox(Pesan)
        If Not isError Then
            ruangan.ListViewKu.Segarkan(0)
            Status(_status.Baru)
        End If
    End Sub

    Private Sub cmdBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBatal.Click
        Status(_status.Baru)
    End Sub

    Private Sub cmdKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdKeluar.Click
        Me.Close()
    End Sub
    Private Sub input0_KeymPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles input0.KeyPress
        If Asc(e.KeyChar) = 13 Then
            ruangan.Cari()
        End If
    End Sub
    Private Sub ruangan_Setelah_Mencari(ByVal isNotNull As Boolean, ByVal Isi() As String) Handles ruangan.Setelah_Mencari
        If isNotNull Then
            DisableInput(False)
            input0.Text = Isi(0)
            input0.Enabled = False
            input1.Text = Isi(1)
            input2.Text = Isi(2)
            Status(_status.Edit)
        Else
            DisableInput(False)
            input1.Focus()
            Status(_status.Simpan)
        End If
    End Sub
    Private Sub inputCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inputCari.TextChanged
        Try
            ruangan.ListViewKu.Segarkan(0, "select * from ruangan where nama like '%" & inputCari.Text & "%' order by nama asc")
        Catch ex As Exception
        End Try
    End Sub
    Private Sub lv_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lv.DoubleClick
        input0.Text = lv.SelectedItems(0).SubItems(1).Text
        ruangan.Cari()
        If tutup = True Then
            frmInventaris.input3.Text = input0.Text
            tutup = 0
            Me.Close()
        End If
    End Sub
    Public tutup As Boolean = 0
End Class