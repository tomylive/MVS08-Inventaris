Public Class frmLogin
    Dim WithEvents fungsiLogin As New oop

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fungsiLogin.NamaDatabase = "dbinventaris"
        fungsiLogin.NamaTabel = "login"
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        fungsiLogin.CobaLogin("select * from login where username='" & input0.Text & "' and password='" & input1.Text & "'")
    End Sub
    Private Sub fungsiLogin_Login(ByVal field() As String, ByVal canLogin As Boolean) Handles fungsiLogin.Login
        If canLogin Then
            If field(0) = input0.Text And field(1) = input1.Text Then
                Timer1.Enabled = False
                frmUtama.Show()
                Me.Hide()
            Else
                MsgBox("Maaf Akun anda salah")
            End If
        Else
            MsgBox("Maaf akun anda tidak terdaftar")
        End If
    End Sub
    Private Sub input0_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles input0.KeyPress
        If Asc(e.KeyChar) = 13 Then
            input1.Focus()
        End If
    End Sub

    Private Sub input1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles input1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub frmLogin_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        input0.Clear()
        input1.Clear()
        input0.Focus()
    End Sub

    Private Sub cmdBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        End
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        MsgBox("Anda tidak di kenal", MsgBoxStyle.Critical, "Maaf")
        Application.Exit()
    End Sub
End Class
