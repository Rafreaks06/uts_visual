Public Class Transaction
    Private Sub loadData()
        Try
            Dim DbItem As New DbItem()
            Dim table As DataTable = DbItem.loadAlldata()
            infoGridView.DataSource = table
            infoGridView.Columns("id").Visible = False 'umpetin id'
            infoGridView.Columns("isdelete").Visible = False 'umpetin id'
            infoGridView.Columns("tahun_terbit").Visible = False
            infoGridView.Columns("kategori").Visible = False

            infoGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message)
        End Try
    End Sub

    Private Sub Transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub infoGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles infoGridView.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = infoGridView.Rows(e.RowIndex)
            Dim Transaction As New Transaction()
            txtKode.Text = row.Cells("kode_buku").Value.ToString()
            txtJudul.Text = row.Cells("judul").Value.ToString()
            txtPenulis.Text = row.Cells("pengarang").Value.ToString()
            txtHarga.Text = row.Cells("harga").Value.ToString()
            txtStok.Text = row.Cells("stok").Value.ToString()
        End If
    End Sub

    Private Sub txtJumlah_TextChanged(sender As Object, e As EventArgs) Handles txtJumlah.TextChanged
        If String.IsNullOrEmpty(txtJumlah.Text) Then
            lblTotal1.Text = "0" ' Reset total if qty is cleared
        Else
            CalculateTotal()
        End If
    End Sub

    Private Sub CalculateTotal()
        Try
            If Not String.IsNullOrEmpty(txtHarga.Text) AndAlso Not String.IsNullOrEmpty(txtJumlah.Text) Then
                Dim harga As Decimal = CDec(txtHarga.Text)
                Dim jumlah As Integer = CInt(txtJumlah.Text)
                lblTotal1.Text = (harga * jumlah).ToString("N0")
            End If
        Catch ex As Exception
            lblTotal1.Text = "0"
        End Try
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        Try
            If String.IsNullOrEmpty(txtKode.Text) OrElse
               String.IsNullOrEmpty(txtJumlah.Text) Then
                MessageBox.Show("Pilih buku dan isi jumlah!")
                Return
            End If

            Dim jumlah As Integer = CInt(txtJumlah.Text)
            Dim stok As Integer = CInt(txtStok.Text)

            If jumlah > stok Then
                MessageBox.Show("Stok tidak mencukupi!")
                ClearForm()
                Return
            End If

            ' Simpan transaksi
            Dim DbItem As New DbItem()
            Dim total As Decimal = CDec(lblTotal1.Text)

            ' Update stok
            DbItem.UpdateStok(txtKode.Text, jumlah)

            ' Simpan ke tabel transaksi
            DbItem.InsertTransaction(txtKode.Text, jumlah, total)

            MessageBox.Show("Transaksi berhasil!")
            loadData() ' Refresh data
            ClearForm()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ClearForm()
        txtKode.Clear()
        txtJudul.Clear()
        txtPenulis.Clear()
        txtHarga.Clear()
        txtStok.Clear()
        txtJumlah.Clear()
        lblTotal1.Text = "0"
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        TransactionRecord.Show()
    End Sub

    Private Sub txtStok_TextChanged(sender As Object, e As EventArgs) Handles txtStok.TextChanged

    End Sub
End Class
