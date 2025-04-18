Public Class TransactionRecord
    Private Sub loadData()
        Try
            Dim DbRecord As New DbRecord()
            Dim table As DataTable = DbRecord.loadAlldata()
            infoGridView.DataSource = table
            infoGridView.Columns("id").Visible = False 'umpetin id'

            infoGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells ' Atur lebar kolom
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message)
        End Try
    End Sub

    Private Sub TransactionRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub
End Class