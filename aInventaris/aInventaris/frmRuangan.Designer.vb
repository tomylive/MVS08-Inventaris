<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRuangan
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
        Me.cmdKeluar = New System.Windows.Forms.Button
        Me.cmdBatal = New System.Windows.Forms.Button
        Me.cmdHapus = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdSimpan = New System.Windows.Forms.Button
        Me.cmdBaru = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.inputCari = New System.Windows.Forms.TextBox
        Me.lv = New System.Windows.Forms.ListView
        Me.SuspendLayout()
        '
        'input2
        '
        Me.input2.Location = New System.Drawing.Point(83, 66)
        Me.input2.Name = "input2"
        Me.input2.Size = New System.Drawing.Size(253, 20)
        Me.input2.TabIndex = 11
        '
        'input1
        '
        Me.input1.Location = New System.Drawing.Point(83, 41)
        Me.input1.Name = "input1"
        Me.input1.Size = New System.Drawing.Size(167, 20)
        Me.input1.TabIndex = 10
        '
        'input0
        '
        Me.input0.Location = New System.Drawing.Point(83, 15)
        Me.input0.Name = "input0"
        Me.input0.Size = New System.Drawing.Size(123, 20)
        Me.input0.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Keterangan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Kode"
        '
        'cmdKeluar
        '
        Me.cmdKeluar.Location = New System.Drawing.Point(488, 92)
        Me.cmdKeluar.Name = "cmdKeluar"
        Me.cmdKeluar.Size = New System.Drawing.Size(75, 23)
        Me.cmdKeluar.TabIndex = 31
        Me.cmdKeluar.Text = "Keluar"
        Me.cmdKeluar.UseVisualStyleBackColor = True
        '
        'cmdBatal
        '
        Me.cmdBatal.Location = New System.Drawing.Point(407, 92)
        Me.cmdBatal.Name = "cmdBatal"
        Me.cmdBatal.Size = New System.Drawing.Size(75, 23)
        Me.cmdBatal.TabIndex = 30
        Me.cmdBatal.Text = "Batal"
        Me.cmdBatal.UseVisualStyleBackColor = True
        '
        'cmdHapus
        '
        Me.cmdHapus.Location = New System.Drawing.Point(326, 92)
        Me.cmdHapus.Name = "cmdHapus"
        Me.cmdHapus.Size = New System.Drawing.Size(75, 23)
        Me.cmdHapus.TabIndex = 29
        Me.cmdHapus.Text = "Hapus"
        Me.cmdHapus.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(245, 92)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 23)
        Me.cmdEdit.TabIndex = 28
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(164, 92)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(75, 23)
        Me.cmdSimpan.TabIndex = 27
        Me.cmdSimpan.Text = "Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'cmdBaru
        '
        Me.cmdBaru.Location = New System.Drawing.Point(83, 92)
        Me.cmdBaru.Name = "cmdBaru"
        Me.cmdBaru.Size = New System.Drawing.Size(75, 23)
        Me.cmdBaru.TabIndex = 26
        Me.cmdBaru.Text = "Baru"
        Me.cmdBaru.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(485, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "<---------------Cari"
        '
        'inputCari
        '
        Me.inputCari.Location = New System.Drawing.Point(83, 224)
        Me.inputCari.Name = "inputCari"
        Me.inputCari.Size = New System.Drawing.Size(399, 20)
        Me.inputCari.TabIndex = 33
        '
        'lv
        '
        Me.lv.Location = New System.Drawing.Point(83, 121)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(480, 97)
        Me.lv.TabIndex = 32
        Me.lv.UseCompatibleStateImageBehavior = False
        '
        'frmRuangan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 261)
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
        Me.Controls.Add(Me.input1)
        Me.Controls.Add(Me.input0)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRuangan"
        Me.Text = "frmRuangan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents input2 As System.Windows.Forms.TextBox
    Friend WithEvents input1 As System.Windows.Forms.TextBox
    Friend WithEvents input0 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdKeluar As System.Windows.Forms.Button
    Friend WithEvents cmdBatal As System.Windows.Forms.Button
    Friend WithEvents cmdHapus As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents cmdBaru As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents inputCari As System.Windows.Forms.TextBox
    Friend WithEvents lv As System.Windows.Forms.ListView
End Class
