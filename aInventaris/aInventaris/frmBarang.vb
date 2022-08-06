Public Class frmBarang
    Dim WithEvents barang As New oop
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
        Dim hapus() = {input0, input1, input2, input3}
        For Each obj In hapus
            obj.text = ""
        Next
    End Sub
    Sub DisableInput(Optional ByVal t As Boolean = True)
        Dim obj
        Dim hapus() = {input0, input1, input2, input3}
        For Each obj In hapus
            If t Then
                obj.enabled = False
            Else
                obj.enabled = True
            End If
        Next
    End Sub
    Dim listSql As String = "select *from barang order by kode asc"
    Private Sub frmBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        barang.NamaDatabase = "dbinventaris"
        barang.NamaTabel = "barang"
        Dim deskripsi() As String = {"kode", "nama", "stock", "keterangan"}
        Dim value() = {input0, input1, input2, input3}
        barang.DeskripsiTAbel = deskripsi
        barang.ObjekTabelValue = value
        Dim listKu As String() = {"Kode", "Nama", "Stock", "Keterangan"}
        Dim listSize As Integer() = {100, 100, 100, 200}
        barang.ListViewKu.Tambah(Me.lv, listKu, listSize, listSql)
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
        barang.Aksi = oop.enumAksi.Simpan
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        barang.Aksi = oop.enumAksi.Edit
    End Sub

    Private Sub cmdHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHapus.Click
        barang.Aksi = oop.enumAksi.Hapus
    End Sub
    Private Sub barang_Setelah_Data_Teredit(ByVal Pesan As String, ByVal isError As Boolean) Handles barang.Setelah_Data_Teredit
        MsgBox(Pesan)
        If Not isError Then
            barang.ListViewKu.Segarkan(0)
            Status(_status.Baru)
        End If
    End Sub

    Private Sub barang_Setelah_Data_Terhapus(ByVal Pesan As String, ByVal isError As Boolean) Handles barang.Setelah_Data_Terhapus
        MsgBox(Pesan)
        If Not isError Then
            barang.ListViewKu.Segarkan(0)
            Status(_status.Baru)
        End If
    End Sub

    Private Sub barang_Setelah_Data_Tersimpan(ByVal Pesan As String, ByVal isError As Boolean) Handles barang.Setelah_Data_Tersimpan
        MsgBox(Pesan)
        If Not isError Then
            barang.ListViewKu.Segarkan(0)
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
            barang.Cari()
        End If
    End Sub
    Private Sub barang_Setelah_Mencari(ByVal isNotNull As Boolean, ByVal Isi() As String) Handles barang.Setelah_Mencari
        If isNotNull Then
            DisableInput(False)
            input0.Text = Isi(0)
            input0.Enabled = False
            input1.Text = Isi(1)
            input2.Text = Isi(2)
            input3.Text = Isi(3)
            Status(_status.Edit)
        Else
            DisableInput(False)
            input1.Focus()
            Status(_status.Simpan)
        End If
    End Sub
    Private Sub inputCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inputCari.TextChanged
        Try
            barang.ListViewKu.Segarkan(0, "select * from barang where Nama like '%" & inputCari.Text & "%' order by kode asc")
        Catch ex As Exception
        End Try
    End Sub
    Private Sub input2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles input2.KeyPress
        e.KeyChar = HanyaInputNomor(e.KeyChar)
    End Sub
    Private Sub lv_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lv.Click
        input0.Text = lv.SelectedItems(0).SubItems(1).Text
        barang.Cari()
        If tutup = True Then
            frmInventaris.input1.Text = input0.Text
            tutup = 0
            Me.Close()
        End If
    End Sub
    Public tutup As Boolean = 0

End Class