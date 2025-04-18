<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Transaction
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.infoGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtPenulis = New System.Windows.Forms.TextBox()
        Me.txtJudul = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnProses = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotal1 = New System.Windows.Forms.Label()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCheck = New System.Windows.Forms.Button()
        CType(Me.infoGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'infoGridView
        '
        Me.infoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.infoGridView.Location = New System.Drawing.Point(365, 97)
        Me.infoGridView.Name = "infoGridView"
        Me.infoGridView.Size = New System.Drawing.Size(428, 349)
        Me.infoGridView.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label1.Location = New System.Drawing.Point(417, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Master Transaction"
        '
        'txtJumlah
        '
        Me.txtJumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtJumlah.Location = New System.Drawing.Point(137, 327)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(166, 24)
        Me.txtJumlah.TabIndex = 18
        '
        'txtHarga
        '
        Me.txtHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtHarga.Location = New System.Drawing.Point(137, 228)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(166, 24)
        Me.txtHarga.TabIndex = 17
        '
        'txtPenulis
        '
        Me.txtPenulis.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtPenulis.Location = New System.Drawing.Point(137, 198)
        Me.txtPenulis.Name = "txtPenulis"
        Me.txtPenulis.Size = New System.Drawing.Size(166, 24)
        Me.txtPenulis.TabIndex = 16
        '
        'txtJudul
        '
        Me.txtJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtJudul.Location = New System.Drawing.Point(137, 168)
        Me.txtJudul.Name = "txtJudul"
        Me.txtJudul.Size = New System.Drawing.Size(166, 24)
        Me.txtJudul.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(19, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Judul Buku"
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(176, 413)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(129, 33)
        Me.btnProses.TabIndex = 0
        Me.btnProses.Text = "Submit"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(22, 413)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 33)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(19, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 18)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Penulis"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(19, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 18)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Harga"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(19, 331)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 18)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Qty"
        '
        'txtKode
        '
        Me.txtKode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtKode.Location = New System.Drawing.Point(139, 138)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(166, 24)
        Me.txtKode.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(19, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 18)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Kode Buku"
        '
        'lblTotal1
        '
        Me.lblTotal1.AutoSize = True
        Me.lblTotal1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblTotal1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotal1.Location = New System.Drawing.Point(17, 463)
        Me.lblTotal1.Name = "lblTotal1"
        Me.lblTotal1.Size = New System.Drawing.Size(110, 39)
        Me.lblTotal1.TabIndex = 23
        Me.lblTotal1.Text = "Harga"
        '
        'txtStok
        '
        Me.txtStok.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtStok.Location = New System.Drawing.Point(139, 258)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(166, 24)
        Me.txtStok.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(21, 262)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 18)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "stok"
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(22, 22)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(131, 33)
        Me.btnCheck.TabIndex = 28
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'Transaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.txtStok)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblTotal1)
        Me.Controls.Add(Me.txtKode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnProses)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtPenulis)
        Me.Controls.Add(Me.txtJudul)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.infoGridView)
        Me.Name = "Transaction"
        Me.Size = New System.Drawing.Size(798, 514)
        CType(Me.infoGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents infoGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtPenulis As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnProses As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtKode As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotal1 As Label
    Friend WithEvents txtStok As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCheck As Button
End Class
