Public Class Input


    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        Try
            Dim DbItem As New DbItem
            Dim kode_buku As String = txtKode.Text
            Dim judul As String = txtJudul.Text
            Dim pengarang As String = txtPenulis.Text
            Dim tahun_terbit As String = txtTahun.Text
            Dim kategori As String = txtKategori.Text
            Dim harga As String = txtHarga.Text
            Dim stok As String = txtStok.Text

            If String.IsNullOrEmpty(txtId.Text) Then 'kondisi jika id kosong' 
                DbItem.insert(kode_buku, judul, pengarang, tahun_terbit, kategori, harga, stok)
                MessageBox.Show("Data Berhasil Ditambahkan")
            Else
                Dim id As String = txtId.Text
                DbItem.update(kode_buku, judul, pengarang, tahun_terbit, kategori, harga, stok, CInt(id))
                MessageBox.Show("Data Berhasil Diupdate")
            End If

            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Failed to insert:" & ex.Message)

        End Try
    End Sub

    Private Sub Input_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(txtId.Text) Then 'kondisi jika id kosong' 
            BtnDelete.Hide()
            txtId.Hide()
        Else
            BtnDelete.Show()
        End If
    End Sub



    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim DbItem As New DbItem
        If String.IsNullOrEmpty(txtId.Text) Then 'kondisi jika id kosong' 
            MessageBox.Show("Data is not exist")
        Else
            Dim id As String = txtId.Text
            DbItem.delete(CInt(id))
            MessageBox.Show("Data has been delete succesfully")
            Hide()
        End If
    End Sub
End Class