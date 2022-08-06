<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.input0 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.input1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.input2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdKeluar = New System.Windows.Forms.Button
        Me.cmdBatal = New System.Windows.Forms.Button
        Me.cmdHapus = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdSimpan = New System.Windows.Forms.Button
        Me.cmdBaru = New System.Windows.Forms.Button
        Me.lv = New System.Windows.Forms.ListView
        Me.Label5 = New System.Windows.Forms.Label
        Me.inputCari = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'input0
        '
        Me.input0.Location = New System.Drawing.Point(77, 12)
        Me.input0.Name = "input0"
        Me.input0.Size = New System.Drawing.Size(130, 20)
        Me.input0.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Username"
        '
        'input1
        '
        Me.input1.Location = New System.Drawing.Point(77, 38)
        Me.input1.Name = "input1"
        Me.input1.Size = New System.Drawing.Size(266, 20)
        Me.input1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Password"
        '
        'input2
        '
        Me.input2.Location = New System.Drawing.Point(77, 64)
        Me.input2.Name = "input2"
        Me.input2.Size = New System.Drawing.Size(347, 20)
        Me.input2.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Nama"
        '
        'cmdKeluar
        '
        Me.cmdKeluar.Location = New System.Drawing.Point(482, 90)
        Me.cmdKeluar.Name = "cmdKeluar"
        Me.cmdKeluar.Size = New System.Drawing.Size(75, 23)
        Me.cmdKeluar.TabIndex = 19
        Me.cmdKeluar.Text = "Keluar"
        Me.cmdKeluar.UseVisualStyleBackColor = True
        '
        'cmdBatal
        '
        Me.cmdBatal.Location = New System.Drawing.Point(401, 90)
        Me.cmdBatal.Name = "cmdBatal"
        Me.cmdBatal.Size = New System.Drawing.Size(75, 23)
        Me.cmdBatal.TabIndex = 18
        Me.cmdBatal.Text = "Batal"
        Me.cmdBatal.UseVisualStyleBackColor = True
        '
        'cmdHapus
        '
        Me.cmdHapus.Location = New System.Drawing.Point(320, 90)
        Me.cmdHapus.Name = "cmdHapus"
        Me.cmdHapus.Size = New System.Drawing.Size(75, 23)
        Me.cmdHapus.TabIndex = 17
        Me.cmdHapus.Text = "Hapus"
        Me.cmdHapus.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(239, 90)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 23)
        Me.cmdEdit.TabIndex = 16
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(158, 90)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(75, 23)
        Me.cmdSimpan.TabIndex = 15
        Me.cmdSimpan.Text = "Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'cmdBaru
        '
        Me.cmdBaru.Location = New System.Drawing.Point(77, 90)
        Me.cmdBaru.Name = "cmdBaru"
        Me.cmdBaru.Size = New System.Drawing.Size(75, 23)
        Me.cmdBaru.TabIndex = 14
        Me.cmdBaru.Text = "Baru"
        Me.cmdBaru.UseVisualStyleBackColor = True
        '
        'lv
        '
        Me.lv.Location = New System.Drawing.Point(77, 119)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(480, 97)
        Me.lv.TabIndex = 20
        Me.lv.UseCompatibleStateImageBehavior = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(479, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "<---------------Cari"
        '
        'inputCari
        '
        Me.inputCari.Location = New System.Drawing.Point(77, 222)
        Me.inputCari.Name = "inputCari"
        Me.inputCari.Size = New System.Drawing.Size(399, 20)
        Me.inputCari.TabIndex = 21
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 261)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.inputCari)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.cmdKeluar)
        Me.Controls.Add(Me.cmdBatal)
        Me.Controls.Add(Me.cmdHapus)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdSimpan)
        Me.Controls.Add(Me.cmdBaru)
        Me.Controls.Add(Me.input2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.input1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.input0)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmUser"
        Me.Text = "Form User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents input0 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents input1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents input2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdKeluar As System.Windows.Forms.Button
    Friend WithEvents cmdBatal As System.Windows.Forms.Button
    Friend WithEvents cmdHapus As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents cmdBaru As System.Windows.Forms.Button
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents inputCari As System.Windows.Forms.TextBox
End Class
