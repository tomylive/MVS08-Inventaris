Public Class frmInventaris
    Dim WithEvents inventaris As New oop
    Dim WithEvents barang As New oop
    Dim WithEvents kondisi As New oop
    Dim WithEvents ruangan As New oop

    Private Sub frmInventaris_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        barang.NamaDatabase = "dbinventaris"
        barang.NamaTabel = "barang"
        Dim adeskripsi() As String = {"kode", "nama", "stock", "keterangan"}
        Dim avalue() = {input1, input11, input11, input11}
        barang.DeskripsiTAbel = adeskripsi
        barang.ObjekTabelValue = avalue

        kondisi.NamaDatabase = "dbinventaris"
        kondisi.NamaTabel = "kondisi"
        Dim bdeskripsi() As String = {"kode", "nama", "Keterangan"}
        Dim bvalue() = {input2, input22, input22}
        kondisi.DeskripsiTAbel = bdeskripsi
        kondisi.ObjekTabelValue = bvalue

        ruangan.NamaDatabase = "dbinventaris"
        ruangan.NamaTabel = "ruangan"
        Dim cdeskripsi() As String = {"kode", "nama", "keterangan"}
        Dim cvalue() = {input3, input33, input33}
        ruangan.DeskripsiTAbel = cdeskripsi
        ruangan.ObjekTabelValue = cvalue


        inventaris.NamaDatabase = "dbinventaris"
        inventaris.NamaTabel = "inventaris"
        Dim deskripsi() As String = {"kode", "barang", "kondisi", "ruangan", "tanggal", "keterangan"}
        Dim value() = {input0, input1, input2, input3, input4, input5}
        inventaris.DeskripsiTAbel = deskripsi
        inventaris.ObjekTabelValue = value
        Dim listKu As String() = {"Kode", "Barang", "Kondisi", "Ruangan", "Tanggal", "Keterangan"}
        Dim listSize As Integer() = {100, 100, 100, 200}
        inventaris.ListViewKu.Tambah(Me.lv, listKu, listSize, listSql)
        Status(_status.Baru)
        hapusInput()
        DisableInput()

    End Sub
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
    Dim listSql As String = "select a.kode, b.nama, c.nama, d.nama, a.tanggal, a.keterangan from inventaris a, barang b, kondisi c, ruangan d where a.barang=b.kode and a.kondisi=c.kode and a.ruangan=d.kode"

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        frmBarang.Close()
        frmBarang.tutup = 1

        frmBarang.ShowDialog(Me)
    End Sub
    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        frmBarang.Close()
        frmKondisi.tutup = 1

        frmKondisi.ShowDialog(Me)
    End Sub
    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        frmBarang.Close()
        frmRuangan.tutup = 1

        frmRuangan.ShowDialog(Me)
    End Sub
    Private Sub input1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles input1.TextChanged
        If input1.Text = "" Then
            input1.Text = ""
        Else
            barang.Cari()
        End If
    End Sub
    Private Sub barang_Setelah_Mencari(ByVal isNotNull As Boolean, ByVal Isi() As String) Handles barang.Setelah_Mencari
        If isNotNull Then
            input11.Text = "Barang : " & Isi(1)
        End If
    End Sub

    Private Sub input2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles input2.TextChanged
        If input2.Text = "" Then
            input2.Text = ""
        Else
            kondisi.Cari()
        End If
    End Sub
    Private Sub kondisi_Setelah_Mencari(ByVal isNotNull As Boolean, ByVal Isi() As String) Handles kondisi.Setelah_Mencari
        If isNotNull Then
            input22.Text = "Kondisi : " & Isi(1)
        End If
    End Sub

    Private Sub input3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles input3.TextChanged
        If input3.Text = "" Then
            input3.Text = ""
        Else
            ruangan.Cari()
        End If
    End Sub
    Private Sub ruangan_Setelah_Mencari(ByVal isNotNull As Boolean, ByVal Isi() As String) Handles ruangan.Setelah_Mencari
        If isNotNull Then
            input33.Text = "Ruangan : " & Isi(1)
        End If
    End Sub
    Private Sub cmdBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBaru.Click
        hapusInput()
        input0.Enabled = True
        input0.Focus()
    End Sub

    Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
        inventaris.Aksi = oop.enumAksi.Simpan
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        inventaris.Aksi = oop.enumAksi.Edit
    End Sub

    Private Sub cmdHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHapus.Click
        inventaris.Aksi = oop.enumAksi.Hapus
    End Sub
    Private Sub inventaris_Setelah_Data_Teredit(ByVal Pesan As String, ByVal isError As Boolean) Handles inventaris.Setelah_Data_Teredit
        MsgBox(Pesan)
        If Not isError Then
            inventaris.ListViewKu.Segarkan(0)
            Status(_status.Baru)
        End If
    End Sub

    Private Sub inventaris_Setelah_Data_Terhapus(ByVal Pesan As String, ByVal isError As Boolean) Handles inventaris.Setelah_Data_Terhapus
        MsgBox(Pesan)
        If Not isError Then
            inventaris.ListViewKu.Segarkan(0)
            Status(_status.Baru)
        End If
    End Sub

    Private Sub inventaris_Setelah_Data_Tersimpan(ByVal Pesan As String, ByVal isError As Boolean) Handles inventaris.Setelah_Data_Tersimpan
        MsgBox(Pesan)
        If Not isError Then
            inventaris.ListViewKu.Segarkan(0)
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
            inventaris.Cari()
        End If
    End Sub
    Private Sub inventaris_Setelah_Mencari(ByVal isNotNull As Boolean, ByVal Isi() As String) Handles inventaris.Setelah_Mencari
        If isNotNull Then
            DisableInput(False)
            input0.Text = Isi(0)
            input0.Enabled = False
            input1.Text = Isi(1)
            input2.Text = Isi(2)
            input3.Text = Isi(3)
            input4.Text = Isi(4)
            input5.Text = Isi(5)
            Status(_status.Edit)
        Else
            DisableInput(False)
            input1.Focus()
            Status(_status.Simpan)
        End If
    End Sub
    Private Sub inputCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inputCari.TextChanged
        Try
            inventaris.ListViewKu.Segarkan(0, "select a.kode, b.nama, c.nama, d.nama, a.tanggal, a.keterangan from inventaris a, barang b, kondisi c, ruangan d where a.barang=b.kode and a.kondisi=c.kode and a.ruangan=d.kode and b.nama='" & inputCari.Text & "'")
        Catch ex As Exception
        End Try
    End Sub
    Private Sub lv_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lv.DoubleClick
        input0.Text = lv.SelectedItems(0).SubItems(1).Text
        inventaris.Cari()
    End Sub
End Class