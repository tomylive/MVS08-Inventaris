Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient

Public Class oop
    Private varNamaDatabase As String = ""
    Private varNamaTabel As String = ""
    Private varNamaServer As String = "localhost"
    Private varNamaUser As String = "root"
    Private varPassword As String = ""
    Private varTabelDeskripsi() As String = Nothing
    Private varNilaiTabel() = Nothing
    Private varPesan As String
    Private varPrimaryKey As Integer = 0

    Public TeksContainer As New DB_COMBO
    Public ListViewKu As New DB_VIEW

    Private varKoneksi As MySqlConnection
    Private varCON_STR As String
    Private varPerintah As MySqlCommand
    Private varPembaca As MySqlDataReader
    Private varPerintahSql As String
    Private errorSimpan As Boolean

    Enum enumAksi
        Konek = 1
        Simpan = 2
        Edit = 3
        Hapus = 4
        TutupDB = 5
    End Enum

    Private varAksi As enumAksi
    Private _canLogin As Boolean = False
    Private _loginField() As String

    Public Event Setelah_Data_Terkoneksi(ByVal Pesan As String)
    Public Event Setelah_Data_Tersimpan(ByVal Pesan As String, ByVal isError As Boolean)
    Public Event Setelah_Data_Teredit(ByVal Pesan As String, ByVal isError As Boolean)
    Public Event Setelah_Data_Terhapus(ByVal Pesan As String, ByVal isError As Boolean)

    Public Event Ketika_Close(ByVal Pesan As String)
    Public Event Setelah_Mencari(ByVal isNotNull As Boolean, ByVal Isi() As String)
    Public Event Login(ByVal field() As String, ByVal canLogin As Boolean)

    Sub ubahField(ByVal sql As String)
        Konek()
        Try
            varPerintah = New MySqlCommand(sql, varKoneksi)
            varPerintah.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
            End
        End Try
    End Sub

    Sub CobaLogin(ByVal query As String)
        Konek()
        Dim _loginItem() As String = Nothing
        Try
            varPerintah = New MySqlCommand(query, varKoneksi)
            varPembaca = varPerintah.ExecuteReader
            If varPembaca.HasRows Then
                While varPembaca.Read
                    Dim loginItem() As String = {varPembaca(0), varPembaca(1), varPembaca(2)}
                    _loginItem = loginItem
                End While
                varPembaca.Close()
                RaiseEvent Login(_loginItem, True)
            Else
                RaiseEvent Login(Nothing, False)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function jikaAda(ByVal sqlQuery As String) As Boolean
        Dim a As Boolean = False
        Konek()
        Try
            varPerintahSql = sqlQuery
            varPerintah = New MySqlCommand(varPerintahSql, varKoneksi)
            varPembaca = varPerintah.ExecuteReader
            If varPembaca.HasRows Then a = True
            varPembaca.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            End
        End Try
        Return a
    End Function

    Public Property Aksi() As enumAksi
        Get
            Return varAksi
        End Get
        Set(ByVal value As enumAksi)
            varAksi = value
            KONEK()
            If varNamaDatabase = "" Then
                MsgBox("Maaf Nama Database Belum di Set, Silahkan Set Dulu", MsgBoxStyle.Critical, "Kekosongan")
            ElseIf varTabelDeskripsi.Length = 0 Then
                MsgBox("Maaf Deskripsi Tabel Belum di Set, Silahkan Set Dulu", MsgBoxStyle.Critical, "Kekosongan")
            ElseIf varNilaiTabel.Length = 0 Then
                MsgBox("Maaf Values Of Table Belum di Set, Silahkan Set Dulu", MsgBoxStyle.Critical, "Kekosongan")
            Else
                Select Case value
                    Case 1
                        KONEK()
                        varPesan = "Database Telah Terkoneksi"
                        RaiseEvent Setelah_Data_Terkoneksi(varPesan)
                    Case 2
                        SIMPAN()
                        RaiseEvent Setelah_Data_Tersimpan(varPesan, errorSimpan)
                    Case 3
                        EDIT(varPrimaryKey)
                        RaiseEvent Setelah_Data_Teredit(varPesan, errorSimpan)
                    Case 4
                        HAPUS(varPrimaryKey)
                        RaiseEvent Setelah_Data_Terhapus(varPesan, errorSimpan)
                    Case 5
                        Tutup()
                        varPesan = "Database Telah Diputus"
                        RaiseEvent Ketika_Close(varPesan)
                End Select
            End If
        End Set
    End Property

    Sub Cari()
        Dim str As String = ""
        If varTabelDeskripsi.Length > 0 Then
            For i As Integer = 0 To varTabelDeskripsi.Length - 1
                If i > varTabelDeskripsi.Length - 2 Then
                    str &= varTabelDeskripsi(i)
                Else
                    str &= varTabelDeskripsi(i) & ","
                End If
            Next
            varPerintahSql = "select " & str & " from " & varNamaDatabase & "." & varNamaTabel & " where " & _
            varNamaTabel & "." & varTabelDeskripsi(varPrimaryKey) & "=" & getValue(varNilaiTabel(varPrimaryKey)) & " limit 1"
        End If
        KONEK()
        varPerintah = New MySqlCommand(varPerintahSql, varKoneksi)
        varPembaca = varPerintah.ExecuteReader
        Dim Ada As Boolean = varPembaca.HasRows
        Dim isi() As String = Nothing
        While varPembaca.Read
            For i As Integer = 0 To varPembaca.FieldCount - 1
                ReDim Preserve isi(i)
                Try
                    isi(i) = varPembaca(i)
                Catch ex As Exception
                    isi(i) = varPembaca(i).ToString
                End Try

            Next i
        End While

        RaiseEvent Setelah_Mencari(Ada, isi)
    End Sub

    Property PrimaryKey() As Integer
        Get
            Return varPrimaryKey
        End Get
        Set(ByVal value As Integer)
            varPrimaryKey = value
        End Set
    End Property

    Private Sub Konek()
        varCON_STR = "server=" & varNamaServer & ";uid=" & varNamaUser & ";password=" & varPassword & ";database=" & varNamaDatabase
        varKoneksi = New MySqlConnection
        If varKoneksi.State = ConnectionState.Closed Then
            Try
                varKoneksi.ConnectionString = varCON_STR
                varKoneksi.Open()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                End
            End Try
        End If
    End Sub

    Private Sub Tutup()
        If varKoneksi.State = 1 Then
            varKoneksi.Close()
            varKoneksi.Dispose()
        End If
    End Sub

    Property AlamatServer() As String
        Get
            Return varNamaServer
        End Get
        Set(ByVal value As String)
            varNamaServer = value
            TeksContainer.NamaServer = value
            ListViewKu.NamaServer = value
        End Set
    End Property

    Property NamaDatabase() As String
        Get
            Return varNamaDatabase
        End Get
        Set(ByVal value As String)
            varNamaDatabase = value
            TeksContainer.NamaDatabase = value
            ListViewKu.NamaDatabase = value
        End Set
    End Property

    Property NamaTabel() As String
        Get
            Return varNamaTabel
        End Get
        Set(ByVal value As String)
            varNamaTabel = value
        End Set
    End Property

    Property UserName() As String
        Get
            Return varNamaUser
        End Get
        Set(ByVal value As String)
            varNamaUser = value
            TeksContainer.NamaUser = value
            ListViewKu.NamaUser = value
        End Set
    End Property

    Property Password() As String
        Get
            Return varPassword
        End Get
        Set(ByVal value As String)
            varPassword = value
            TeksContainer.Password = value
            ListViewKu.Password = value
        End Set
    End Property

    Property DeskripsiTAbel() As String()
        Get
            Return varTabelDeskripsi
        End Get
        Set(ByVal value() As String)
            varTabelDeskripsi = value
        End Set
    End Property

    Property ObjekTabelValue()
        Get
            Return varNilaiTabel
        End Get
        Set(ByVal value)
            varNilaiTabel = value
        End Set
    End Property

    Private Function getValue(ByVal objek) As String
        Dim str As String = ""
        If TypeOf objek Is TextBox Then
            If objek.text = "" Then
                str = "null"
            Else
                str = "'" & objek.text & "'"
            End If
        ElseIf TypeOf objek Is ComboBox Then
            If objek.text = "" Then
                str = "null"
            Else
                str = "'" & objek.text & "'"
            End If
        ElseIf TypeOf objek Is DateTimePicker Then
            str = "'" & Format(objek.value, "yyyy-MM-dd") & "'"
        ElseIf TypeOf objek Is Label Then
            If objek.text = "" Then
                str = "null"
            Else
                str = "'" & objek.text & "'"
            End If
        ElseIf TypeOf objek Is String Then
            str = "'" & objek & "'"
        Else
            str = "'" & objek.text & "'"
        End If
        Return str
    End Function

    Private Sub Simpan()
        Dim str As String = ""
        For i As Integer = 0 To varNilaiTabel.Length - 1

            If i > varNilaiTabel.Length - 2 Then
                str &= getValue(varNilaiTabel(i))
            Else
                str &= getValue(varNilaiTabel(i)) & ","
            End If
        Next
        varPerintahSql = "insert into " & varNamaTabel & " values(" & str & ")"
        Try
            varPerintah = New MySqlCommand(varPerintahSql, varKoneksi)
            varPerintah.ExecuteNonQuery()
            varPesan = "Data Tersimpan"
        Catch ex As Exception
            varPesan = pesanError(ex.Message)
        End Try
    End Sub

    Function ambilIntiPesan(ByVal pesan As String) As String
        Dim posisi1, panjang As Integer
        For i As Integer = 1 To pesan.Length
            If Mid(pesan, i, 1) = "'" Then
                posisi1 = i + 1
                For j As Integer = i + 1 To pesan.Length
                    If Mid(pesan, j, 1) = "'" Then
                        panjang = j
                        Exit For
                    End If
                Next
                Exit For
            End If
        Next

        Dim inti As String = Mid(pesan, posisi1, panjang - posisi1)
        Return inti
    End Function

    Function pesanError(ByVal pesan As String) As String
        Dim isError1, isError2 As Boolean

        Dim errMess As String = ""
        isError1 = pesan Like "Column * cannot be null"
        isError2 = pesan Like "Duplicate entry * for key 1"

        If isError1 Then
            errMess = "Kolom " & ambilIntiPesan(pesan) & " tidak boleh kosong"
            errorSimpan = True
        ElseIf isError2 Then
            errMess = "Duplikat record kolom " & ambilIntiPesan(pesan)
            errorSimpan = True
        Else
            errorSimpan = False
            errMess = pesan
        End If

        Return errMess
    End Function

    Private Sub Edit(ByVal keyIndex As Integer)
        Dim str As String = ""
        For i As Integer = 0 To varNilaiTabel.Length - 1
            If i <> 0 Then
                If i > varNilaiTabel.Length - 2 Then
                    str &= varTabelDeskripsi(i) & "=" & getValue(varNilaiTabel(i))
                Else
                    str &= varTabelDeskripsi(i) & "=" & getValue(varNilaiTabel(i)) & ","
                End If
            End If
        Next

        'DDL = "update " & DbName & "." & TbName & " set " & str & " where convert(" & TbName & "." & TbDesc(0) & " USINg utf8)='" & TbValue(0) & "' limit 1"
        varPerintahSql = "update " & varNamaDatabase & "." & varNamaTabel & " set " & str & " where " & varNamaTabel & "." & varTabelDeskripsi(keyIndex) & "=" & getValue(varNilaiTabel(keyIndex)) & " limit 1"

        Try
            varPerintah = New MySqlCommand(varPerintahSql, varKoneksi)
            varPerintah.ExecuteNonQuery()
            varPesan = "Data Tersimpan"
        Catch ex As Exception
            varPesan = ex.Message
        End Try
    End Sub

    Private Sub Hapus(ByVal keyIndex As Integer)
        varPerintahSql = "delete from " & varNamaDatabase & "." & varNamaTabel & " where " & varNamaTabel & "." & varTabelDeskripsi(0) & "=" & getValue(varNilaiTabel(keyIndex))
        Try
            'MsgBox(DDL)
            varPerintah = New MySqlCommand(varPerintahSql, varKoneksi)
            varPerintah.ExecuteNonQuery()
            varPesan = "Data Terhapus"
        Catch ex As Exception
            varPesan = ex.Message
        End Try
    End Sub
End Class

Module DB_FUNGSI

    Public User As String = ""

    Sub hapusForm(ByVal ctl())
        On Error Resume Next
        Dim i As Integer = 0
        For i = 0 To ctl.Length - 1
            If TypeOf ctl(i) Is TextBox Then ctl(i).text = ""
            If TypeOf ctl(i) Is ComboBox Then ctl(i).text = ""
        Next
    End Sub

    Function HanyaInputNomor(ByVal Input As Char) As Char
        Select Case Asc(Input)
            Case 8 : Return Input
            Case 13 : Return Input
            Case Is >= 48
                If Asc(Input) <= 57 Then
                    Return Input
                End If
            Case Else : Return Chr(0)
        End Select
    End Function

End Module

Public Class DB_COMBO

    Private varItem() = Nothing

    Private varNamaDatabase As String = ""
    Private varNamaTabel() As String
    Private varNamaKolom() As String

    Private varNamaServer As String = "localhost"
    Private varNamaUser As String = "root"
    Private varPassword As String = ""

    Private varKoneksi As MySqlConnection
    Private varCON_STR As String
    Private varPerintah As MySqlCommand
    Private varPembaca As MySqlDataReader
    Private varPerintahSql As String

    Dim lenghtCombo As Integer = 0

    Property Password() As String
        Get
            Return varPassword
        End Get
        Set(ByVal value As String)
            varPassword = value
        End Set
    End Property

    Property NamaUser() As String
        Get
            Return varNamaUser
        End Get
        Set(ByVal value As String)
            varNamaUser = value
        End Set
    End Property

    Property NamaServer() As String
        Get
            Return varNamaServer
        End Get
        Set(ByVal value As String)
            varNamaServer = value
        End Set
    End Property

    Property NamaDatabase() As String
        Get
            Return varNamaDatabase
        End Get
        Set(ByVal value As String)
            varNamaDatabase = value
        End Set
    End Property

    Private Sub Konek()
        varCON_STR = "SERVER=" & varNamaServer & ";UID=" & varNamaUser & ";PASSWORD=" & varPassword & ";DATABASE=" & varNamaDatabase
        varKoneksi = New MySqlConnection
        If varKoneksi.State = ConnectionState.Closed Then
            Try
                varKoneksi.ConnectionString = varCON_STR
                varKoneksi.Open()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                End
            End Try
        End If
    End Sub

    Public Sub Tambah(ByVal Item, ByVal FieldName, ByVal TabelName)
        ReDim Preserve varItem(lenghtCombo)
        varItem(lenghtCombo) = Item
        ReDim Preserve varNamaKolom(lenghtCombo)
        varNamaKolom(lenghtCombo) = FieldName
        ReDim Preserve varNamaTabel(lenghtCombo)
        varNamaTabel(lenghtCombo) = TabelName
        SegarkanSemua()
        lenghtCombo += 1
    End Sub

    Public Sub Segarkan(ByVal item As Integer)
        KONEK()
        varPerintahSql = "select " & varNamaTabel(item) & "." & varNamaKolom(item) & " from " & varNamaDatabase & "." & _
        varNamaTabel(item)
        varPerintah = New MySqlCommand(varPerintahSql, varKoneksi)
        varPembaca = varPerintah.ExecuteReader
        varItem(item).items.clear()
        While varPembaca.Read
            varItem(item).items.add(varPembaca(0).ToString)
        End While
        varPembaca.Close()
    End Sub

    Public Sub Segarkan(ByVal Item As Integer, ByVal kondisi As String)
        Konek()
        varPerintahSql = "select " & varNamaTabel(Item) & "." & varNamaKolom(Item) & " from " & varNamaDatabase & "." & _
        varNamaTabel(Item) & " where " & kondisi
        varPerintah = New MySqlCommand(varPerintahSql, varKoneksi)
        varPembaca = varPerintah.ExecuteReader
        varItem(Item).items.clear()
        While varPembaca.Read
            varItem(Item).items.add(varPembaca(0).ToString)
        End While
        varPembaca.Close()
    End Sub

    Private Sub SegarkanSemua()
        KONEK()
        For i As Integer = 0 To varItem.Length - 1
            varPerintahSql = "select " & varNamaTabel(i) & "." & varNamaKolom(i) & " from " & varNamaDatabase & "." & _
            varNamaTabel(i)
            varPerintah = New MySqlCommand(varPerintahSql, varKoneksi)
            varPembaca = varPerintah.ExecuteReader
            varItem(i).items.clear()
            While varPembaca.Read
                varItem(i).items.add(varPembaca(0).ToString)
            End While
            varPembaca.Close()
        Next
    End Sub
End Class


Public Class DB_VIEW
    Private varItem() As ListView

    Private varNamaDatabase As String = ""
    Private varNamaKolom() As String

    Private varNamaServer As String = "localhost"
    Private varNamaUser As String = "root"
    Private varPassword As String = ""

    Private varKoneksi As MySqlConnection
    Public varCON_STR As String
    Private varPerintah As MySqlCommand
    Private varPembaca As MySqlDataReader
    Private varPerintahSql() As String
    Private varKolom()() As String
    Private varUkuranKolom()() As Integer

    Private lenghtView As Integer = 0

    Public Sub Segarkan(ByVal index As Integer, Optional ByVal sqlQuery As String = "")
        Konek()
        If sqlQuery = "" Then
            sqlQuery = varPerintahSql(index)
        End If

        Dim no As Integer = 1
        varPerintah = New MySqlCommand(sqlQuery, varKoneksi)
        varPembaca = varPerintah.ExecuteReader
        varItem(index).Items.Clear()
        While varPembaca.Read
            Dim listItem As New ListViewItem
            listItem.Text = no
            For j As Integer = 0 To varPembaca.FieldCount - 1
                listItem.SubItems.Add(varPembaca(j).ToString)
            Next
            varItem(index).Items.Add(listItem)
            no += 1
        End While
        varPembaca.Close()
    End Sub

    Property Password() As String
        Get
            Return varPassword
        End Get
        Set(ByVal value As String)
            varPassword = value
        End Set
    End Property

    Property NamaUser() As String
        Get
            Return varNamaUser
        End Get
        Set(ByVal value As String)
            varNamaUser = value
        End Set
    End Property

    Property NamaServer() As String
        Get
            Return varNamaServer
        End Get
        Set(ByVal value As String)
            varNamaServer = value
        End Set
    End Property

    Property NamaDatabase() As String
        Get
            Return varNamaDatabase
        End Get
        Set(ByVal value As String)
            varNamaDatabase = value
        End Set
    End Property

    Private Sub Konek()
        varCON_STR = "server=" & varNamaServer & ";uid=" & varNamaUser & ";password=" & varPassword & ";database=" & varNamaDatabase
        varKoneksi = New MySqlConnection
        If varKoneksi.State = ConnectionState.Closed Then
            Try
                varKoneksi.ConnectionString = varCON_STR
                varKoneksi.Open()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                End
            End Try
        End If
    End Sub

    Public Sub Tambah(ByVal Item As ListView, ByVal ColumnsArray() As String, ByVal ColumnSize() As Integer, ByVal sql As String)
        ReDim Preserve varItem(lenghtView)
        varItem(lenghtView) = Item
        ReDim Preserve varPerintahSql(lenghtView)
        varPerintahSql(lenghtView) = sql
        ReDim Preserve varKolom(lenghtView)
        varKolom(lenghtView) = ColumnsArray
        ReDim Preserve varUkuranKolom(lenghtView)
        varUkuranKolom(lenghtView) = ColumnSize
        BuatKolom()
        SegarkanSemua()
        lenghtView += 1
    End Sub

    Private Sub BuatKolom()
        For i As Integer = 0 To varKolom.Length - 1
            varItem(i).View = View.Details
            varItem(i).GridLines = True
            varItem(i).FullRowSelect = True
            varItem(i).Columns.Clear()
            varItem(i).Columns.Add("NO", 50, HorizontalAlignment.Center)
            For j As Integer = 0 To varKolom(i).Length - 1
                Dim kolom As Integer
                Try
                    kolom = varUkuranKolom(i)(j)
                Catch ex As Exception
                    kolom = 100
                End Try
                varItem(i).Columns.Add(varKolom(i)(j), kolom, HorizontalAlignment.Left)
            Next
        Next
    End Sub

    Sub SegarkanSemua()
        Konek()
        For i As Integer = 0 To varItem.Length - 1
            Dim no As Integer = 1
            varPerintah = New MySqlCommand(varPerintahSql(i), varKoneksi)
            varPembaca = varPerintah.ExecuteReader
            varItem(i).Items.Clear()
            While varPembaca.Read
                Dim listItem As New ListViewItem
                listItem.Text = no
                For j As Integer = 0 To varPembaca.FieldCount - 1
                    Try
                        listItem.SubItems.Add(varPembaca(j).ToString)
                    Catch ex As Exception
                        listItem.SubItems.Add(varPembaca(j))
                    End Try
                Next
                varItem(i).Items.Add(listItem)
                no += 1
            End While
            varPembaca.Close()
        Next
    End Sub
End Class