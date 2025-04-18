<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Input
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtJudul = New System.Windows.Forms.TextBox()
        Me.txtPenulis = New System.Windows.Forms.TextBox()
        Me.txtTahun = New System.Windows.Forms.TextBox()
        Me.txtKategori = New System.Windows.Forms.TextBox()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(38, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Judul"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(30, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Penulis"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(18, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tahun Terbit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(313, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Stok"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(18, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Kode Buku"
        '
        'txtJudul
        '
        Me.txtJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtJudul.Location = New System.Drawing.Point(130, 162)
        Me.txtJudul.Name = "txtJudul"
        Me.txtJudul.Size = New System.Drawing.Size(150, 24)
        Me.txtJudul.TabIndex = 5
        '
        'txtPenulis
        '
        Me.txtPenulis.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtPenulis.Location = New System.Drawing.Point(130, 217)
        Me.txtPenulis.Name = "txtPenulis"
        Me.txtPenulis.Size = New System.Drawing.Size(150, 24)
        Me.txtPenulis.TabIndex = 6
        '
        'txtTahun
        '
        Me.txtTahun.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtTahun.Location = New System.Drawing.Point(130, 274)
        Me.txtTahun.Name = "txtTahun"
        Me.txtTahun.Size = New System.Drawing.Size(150, 24)
        Me.txtTahun.TabIndex = 7
        '
        'txtKategori
        '
        Me.txtKategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtKategori.Location = New System.Drawing.Point(130, 317)
        Me.txtKategori.Name = "txtKategori"
        Me.txtKategori.Size = New System.Drawing.Size(150, 24)
        Me.txtKategori.TabIndex = 8
        '
        'txtKode
        '
        Me.txtKode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtKode.Location = New System.Drawing.Point(130, 112)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(150, 24)
        Me.txtKode.TabIndex = 9
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.Cyan
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Location = New System.Drawing.Point(312, 208)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(127, 33)
        Me.BtnAdd.TabIndex = 11
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Location = New System.Drawing.Point(452, 208)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(127, 33)
        Me.BtnDelete.TabIndex = 12
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'txtHarga
        '
        Me.txtHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtHarga.Location = New System.Drawing.Point(406, 112)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(150, 24)
        Me.txtHarga.TabIndex = 16
        '
        'txtStok
        '
        Me.txtStok.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtStok.Location = New System.Drawing.Point(406, 166)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(150, 24)
        Me.txtStok.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(308, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Harga"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(32, 321)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Kategori"
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtId.Location = New System.Drawing.Point(317, 278)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(82, 24)
        Me.txtId.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Lucida Console", 30.0!)
        Me.Label6.Location = New System.Drawing.Point(170, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(257, 40)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Form Input"
        '
        'Input
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(655, 354)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtStok)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtKode)
        Me.Controls.Add(Me.txtKategori)
        Me.Controls.Add(Me.txtTahun)
        Me.Controls.Add(Me.txtPenulis)
        Me.Controls.Add(Me.txtJudul)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Input"
        Me.Text = "input"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents txtPenulis As TextBox
    Friend WithEvents txtTahun As TextBox
    Friend WithEvents txtKategori As TextBox
    Friend WithEvents txtKode As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtId As TextBox
End Class
