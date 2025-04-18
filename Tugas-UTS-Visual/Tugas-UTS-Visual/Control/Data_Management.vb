Imports System.Runtime.CompilerServices.RuntimeHelpers

Public Class Data_Management
    Private Sub loadData()
        Try
            Dim DbItem As New DbItem()
            Dim table As DataTable = DbItem.loadAlldata()
            infoGridView.DataSource = table
            infoGridView.Columns("id").Visible = False 'umpetin id'
            infoGridView.Columns("isdelete").Visible = False 'umpetin id'


        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message)
        End Try
    End Sub

    Private Sub Data_Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Try
            Dim searchTerm As String = searchTxt.Text.Trim()

            Dim DbItem As New DbItem()
            Dim resultTable As DataTable = DbItem.SearchBooks(searchTerm)

            ' Validasi input kosong
            If String.IsNullOrWhiteSpace(searchTerm) Then
                MessageBox.Show("Silakan masukkan kata kunci pencarian", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                searchTxt.Focus()
                Return
            End If


            If resultTable.Rows.Count > 0 Then
                infoGridView.DataSource = resultTable
                infoGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            Else
                MessageBox.Show("Tidak ditemukan buku dengan judul '" & searchTerm & "'", "Informasi",
                              MessageBoxButtons.OK, MessageBoxIcon.Information)
                loadData() ' Tampilkan semua data jika tidak ada hasil
            End If
        Catch ex As Exception
            MessageBox.Show("Error saat mencari: " & ex.Message)
        End Try
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        searchTxt.Clear()
        loadData()
    End Sub

    Private Sub InputBtn_Click(sender As Object, e As EventArgs) Handles InputBtn.Click
        Input.Show()
    End Sub

    Private Sub infoGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles infoGridView.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = infoGridView.Rows(e.RowIndex)
            Dim Input As New Input()
            Input.txtKode.Text = row.Cells("kode_buku").Value.ToString()
            Input.txtJudul.Text = row.Cells("judul").Value.ToString()
            Input.txtPenulis.Text = row.Cells("pengarang").Value.ToString()
            Input.txtId.Text = row.Cells("id").Value.ToString()
            Input.txtTahun.Text = row.Cells("tahun_terbit").Value.ToString()
            Input.txtKategori.Text = row.Cells("kategori").Value.ToString()
            Input.txtHarga.Text = row.Cells("harga").Value.ToString()
            Input.txtStok.Text = row.Cells("stok").Value.ToString()
            Input.Show()

        End If
    End Sub

End Class