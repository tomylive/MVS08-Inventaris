Public Class frmUser
    Dim WithEvents login As New oop
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
    Dim listSql As String = "select *from login order by username asc"
    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        login.NamaDatabase = "dbinventaris"
        login.NamaTabel = "login"
        Dim deskripsi() As String = {"username", "password", "nama"}
        Dim value() = {input0, input1, input2}
        login.DeskripsiTAbel = deskripsi
        login.ObjekTabelValue = value
        Dim listKu As String() = {"username", "Password", "Nama"}
        Dim listSize As Integer() = {100, 100, 100, 200}
        login.ListViewKu.Tambah(Me.lv, listKu, listSize, listSql)
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
        login.Aksi = oop.enumAksi.Simpan
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        login.Aksi = oop.enumAksi.Edit
    End Sub

    Private Sub cmdHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHapus.Click
        login.Aksi = oop.enumAksi.Hapus
    End Sub
    Private Sub login_Setelah_Data_Teredit(ByVal Pesan As String, ByVal isError As Boolean) Handles login.Setelah_Data_Teredit
        MsgBox(Pesan)
        If Not isError Then
            login.ListViewKu.Segarkan(0)
            Status(_status.Baru)
        End If
    End Sub

    Private Sub login_Setelah_Data_Terhapus(ByVal Pesan As String, ByVal isError As Boolean) Handles login.Setelah_Data_Terhapus
        MsgBox(Pesan)
        If Not isError Then
            login.ListViewKu.Segarkan(0)
            Status(_status.Baru)
        End If
    End Sub

    Private Sub login_Setelah_Data_Tersimpan(ByVal Pesan As String, ByVal isError As Boolean) Handles login.Setelah_Data_Tersimpan
        MsgBox(Pesan)
        If Not isError Then
            login.ListViewKu.Segarkan(0)
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
            login.Cari()
        End If
    End Sub
    Private Sub login_Setelah_Mencari(ByVal isNotNull As Boolean, ByVal Isi() As String) Handles login.Setelah_Mencari
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
            login.ListViewKu.Segarkan(0, "select * from login where nama like '%" & inputCari.Text & "%' order by username asc")
        Catch ex As Exception
        End Try
    End Sub
    Private Sub lv_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lv.DoubleClick
        input0.Text = lv.SelectedItems(0).SubItems(1).Text
        login.Cari()
    End Sub
End Class