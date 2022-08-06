<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventaris
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
        Me.input2 = New System.Windows.Forms.TextBox
        Me.input1 = New System.Windows.Forms.TextBox
        Me.input0 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.input3 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.input4 = New System.Windows.Forms.DateTimePicker
        Me.input5 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.input11 = New System.Windows.Forms.TextBox
        Me.input22 = New System.Windows.Forms.TextBox
        Me.input33 = New System.Windows.Forms.TextBox
        Me.cmdKeluar = New System.Windows.Forms.Button
        Me.cmdBatal = New System.Windows.Forms.Button
        Me.cmdHapus = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdSimpan = New System.Windows.Forms.Button
        Me.cmdBaru = New System.Windows.Forms.Button
        Me.lv = New System.Windows.Forms.ListView
        Me.Label10 = New System.Windows.Forms.Label
        Me.inputCari = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'input2
        '
        Me.input2.Location = New System.Drawing.Point(88, 79)
        Me.input2.Name = "input2"
        Me.input2.Size = New System.Drawing.Size(123, 20)
        Me.input2.TabIndex = 17
        '
        'input1
        '
        Me.input1.Location = New System.Drawing.Point(88, 44)
        Me.input1.Name = "input1"
        Me.input1.Size = New System.Drawing.Size(123, 20)
        Me.input1.TabIndex = 16
        '
        'input0
        '
        Me.input0.Location = New System.Drawing.Point(88, 18)
        Me.input0.Name = "input0"
        Me.input0.Size = New System.Drawing.Size(123, 20)
        Me.input0.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Kondisi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Kode"
        '
        'input3
        '
        Me.input3.Location = New System.Drawing.Point(88, 105)
        Me.input3.Name = "input3"
        Me.input3.Size = New System.Drawing.Size(123, 20)
        Me.input3.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Ruangan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Tanggal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Keterangan"
        '
        'input4
        '
        Me.input4.Location = New System.Drawing.Point(88, 133)
        Me.input4.Name = "input4"
        Me.input4.Size = New System.Drawing.Size(200, 20)
        Me.input4.TabIndex = 22
        '
        'input5
        '
        Me.input5.Location = New System.Drawing.Point(92, 166)
        Me.input5.Name = "input5"
        Me.input5.Size = New System.Drawing.Size(253, 20)
        Me.input5.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(213, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "+"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(214, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "+"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(214, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "+"
        '
        'input11
        '
        Me.input11.Enabled = False
        Me.input11.Location = New System.Drawing.Point(232, 45)
        Me.input11.Name = "input11"
        Me.input11.Size = New System.Drawing.Size(463, 20)
        Me.input11.TabIndex = 27
        '
        'input22
        '
        Me.input22.Enabled = False
        Me.input22.Location = New System.Drawing.Point(233, 79)
        Me.input22.Name = "input22"
        Me.input22.Size = New System.Drawing.Size(463, 20)
        Me.input22.TabIndex = 28
        '
        'input33
        '
        Me.input33.Enabled = False
        Me.input33.Location = New System.Drawing.Point(233, 105)
        Me.input33.Name = "input33"
        Me.input33.Size = New System.Drawing.Size(463, 20)
        Me.input33.TabIndex = 29
        '
        'cmdKeluar
        '
        Me.cmdKeluar.Location = New System.Drawing.Point(497, 192)
        Me.cmdKeluar.Name = "cmdKeluar"
        Me.cmdKeluar.Size = New System.Drawing.Size(75, 23)
        Me.cmdKeluar.TabIndex = 35
        Me.cmdKeluar.Text = "Keluar"
        Me.cmdKeluar.UseVisualStyleBackColor = True
        '
        'cmdBatal
        '
        Me.cmdBatal.Location = New System.Drawing.Point(416, 192)
        Me.cmdBatal.Name = "cmdBatal"
        Me.cmdBatal.Size = New System.Drawing.Size(75, 23)
        Me.cmdBatal.TabIndex = 34
        Me.cmdBatal.Text = "Batal"
        Me.cmdBatal.UseVisualStyleBackColor = True
        '
        'cmdHapus
        '
        Me.cmdHapus.Location = New System.Drawing.Point(335, 192)
        Me.cmdHapus.Name = "cmdHapus"
        Me.cmdHapus.Size = New System.Drawing.Size(75, 23)
        Me.cmdHapus.TabIndex = 33
        Me.cmdHapus.Text = "Hapus"
        Me.cmdHapus.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(254, 192)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 23)
        Me.cmdEdit.TabIndex = 32
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(173, 192)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(75, 23)
        Me.cmdSimpan.TabIndex = 31
        Me.cmdSimpan.Text = "Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'cmdBaru
        '
        Me.cmdBaru.Location = New System.Drawing.Point(92, 192)
        Me.cmdBaru.Name = "cmdBaru"
        Me.cmdBaru.Size = New System.Drawing.Size(75, 23)
        Me.cmdBaru.TabIndex = 30
        Me.cmdBaru.Text = "Baru"
        Me.cmdBaru.UseVisualStyleBackColor = True
        '
        'lv
        '
        Me.lv.Location = New System.Drawing.Point(92, 221)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(631, 149)
        Me.lv.TabIndex = 36
        Me.lv.UseCompatibleStateImageBehavior = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(494, 379)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "<---------------Cari"
        '
        'inputCari
        '
        Me.inputCari.Location = New System.Drawing.Point(92, 376)
        Me.inputCari.Name = "inputCari"
        Me.inputCari.Size = New System.Drawing.Size(399, 20)
        Me.inputCari.TabIndex = 37
        '
        'frmInventaris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 407)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.inputCari)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.cmdKeluar)
        Me.Controls.Add(Me.cmdBatal)
        Me.Controls.Add(Me.cmdHapus)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdSimpan)
        Me.Controls.Add(Me.cmdBaru)
        Me.Controls.Add(Me.input33)
        Me.Controls.Add(Me.input22)
        Me.Controls.Add(Me.input11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.input5)
        Me.Controls.Add(Me.input4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.input3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.input2)
        Me.Controls.Add(Me.input1)
        Me.Controls.Add(Me.input0)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmInventaris"
        Me.Text = "Form Inventaris"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents input2 As System.Windows.Forms.TextBox
    Friend WithEvents input1 As System.Windows.Forms.TextBox
    Friend WithEvents input0 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents input3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents input4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents input5 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents input11 As System.Windows.Forms.TextBox
    Friend WithEvents input22 As System.Windows.Forms.TextBox
    Friend WithEvents input33 As System.Windows.Forms.TextBox
    Friend WithEvents cmdKeluar As System.Windows.Forms.Button
    Friend WithEvents cmdBatal As System.Windows.Forms.Button
    Friend WithEvents cmdHapus As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents cmdBaru As System.Windows.Forms.Button
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents inputCari As System.Windows.Forms.TextBox
End Class
