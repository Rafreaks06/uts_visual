<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Data_Management
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchTxt = New System.Windows.Forms.TextBox()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.InputBtn = New System.Windows.Forms.Button()
        Me.infoGridView = New System.Windows.Forms.DataGridView()
        Me.ResetBtn = New System.Windows.Forms.Button()
        CType(Me.infoGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(61, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DATA MASTER"
        '
        'searchTxt
        '
        Me.searchTxt.Location = New System.Drawing.Point(368, 55)
        Me.searchTxt.Name = "searchTxt"
        Me.searchTxt.Size = New System.Drawing.Size(160, 20)
        Me.searchTxt.TabIndex = 2
        '
        'SearchBtn
        '
        Me.SearchBtn.Location = New System.Drawing.Point(577, 55)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(144, 33)
        Me.SearchBtn.TabIndex = 3
        Me.SearchBtn.Text = "Search"
        Me.SearchBtn.UseVisualStyleBackColor = True
        '
        'InputBtn
        '
        Me.InputBtn.Location = New System.Drawing.Point(9, 39)
        Me.InputBtn.Name = "InputBtn"
        Me.InputBtn.Size = New System.Drawing.Size(157, 49)
        Me.InputBtn.TabIndex = 4
        Me.InputBtn.Text = "Add"
        Me.InputBtn.UseVisualStyleBackColor = True
        '
        'infoGridView
        '
        Me.infoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.infoGridView.Location = New System.Drawing.Point(9, 91)
        Me.infoGridView.Name = "infoGridView"
        Me.infoGridView.Size = New System.Drawing.Size(712, 298)
        Me.infoGridView.TabIndex = 5
        '
        'ResetBtn
        '
        Me.ResetBtn.Location = New System.Drawing.Point(172, 39)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(144, 49)
        Me.ResetBtn.TabIndex = 6
        Me.ResetBtn.Text = "Clear"
        Me.ResetBtn.UseVisualStyleBackColor = True
        '
        'Data_Management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.infoGridView)
        Me.Controls.Add(Me.InputBtn)
        Me.Controls.Add(Me.SearchBtn)
        Me.Controls.Add(Me.searchTxt)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Data_Management"
        Me.Size = New System.Drawing.Size(745, 423)
        CType(Me.infoGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents searchTxt As TextBox
    Friend WithEvents SearchBtn As Button
    Friend WithEvents InputBtn As Button
    Friend WithEvents infoGridView As DataGridView
    Friend WithEvents ResetBtn As Button
End Class
