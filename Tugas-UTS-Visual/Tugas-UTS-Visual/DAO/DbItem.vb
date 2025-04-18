Imports Npgsql

Public Class DbItem
    Dim npgsqlConn As NpgsqlConnection
    Dim cmd As NpgsqlCommand
    Dim rs As NpgsqlDataReader
    Dim adp As NpgsqlDataAdapter
    Dim query As String
    Public Function SearchBooks(titleKeyword As String) As DataTable

        npgsqlConn = Dbconnnection.openconnection()
        query = "SELECT * FROM manage_buku " &
                                  "WHERE judul ILIKE @searchTerm " &
                                  "AND isdelete = 0 " &
                                  "ORDER BY kode_buku"
        cmd = New NpgsqlCommand(query, npgsqlConn)
        adp = New NpgsqlDataAdapter(cmd) 'mengambil data hasil query'
        Dim resultTable As New DataTable()
        cmd.Parameters.AddWithValue("@searchTerm", "%" & titleKeyword.ToLower() & "%")
        adp.Fill(resultTable)
        Return resultTable


    End Function

    Public Function loadAlldata() As DataTable

        query = "SELECT * FROM manage_buku where isdelete = 0 order by kode_buku" 'query database'
        npgsqlConn = Dbconnnection.openconnection 'pembukaan koneksi'
        cmd = New NpgsqlCommand(query, npgsqlConn) 'eksekusi query berdasarkan koneksi'
        adp = New NpgsqlDataAdapter(cmd) 'mengambil data hasil query'
        Dim table As New DataTable() 'definisi tabel penampungan'
        adp.Fill(table) 'data ditampung di table'

        Return table
    End Function

    Public Function insert(kode_buku As String, judul As String, pengarang As String,
                              tahun_terbit As Integer, kategori As String, harga As Decimal, stok As Integer) As Integer 'memberikan value'
        npgsqlConn = Dbconnnection.openconnection()
        query = "insert into manage_buku (kode_buku, judul, pengarang, tahun_terbit, kategori, harga, stok)"
        query = query & " Values (@kode_buku, @judul, @pengarang, @tahun_terbit, @kategori, @harga, @stok)" 'query insert'
        cmd = New NpgsqlCommand(query, npgsqlConn)
        cmd.Parameters.AddWithValue("@kode_buku", kode_buku)
        cmd.Parameters.AddWithValue("@judul", judul)
        cmd.Parameters.AddWithValue("@pengarang", pengarang)
        cmd.Parameters.AddWithValue("@tahun_terbit", tahun_terbit)
        cmd.Parameters.AddWithValue("@kategori", kategori)
        cmd.Parameters.AddWithValue("@harga", harga)
        cmd.Parameters.AddWithValue("@stok", stok)
        Dim result As Integer
        result = cmd.ExecuteNonQuery()
        Dbconnnection.CloseConnection()
        Return result
    End Function
    Public Function update(kode_buku As String, judul As String, pengarang As String, tahun_terbit As Integer,
            kategori As String, harga As Decimal, stok As Integer, id As Integer) As Integer
        query = "UPDATE manage_buku SET judul = @judul, pengarang = @pengarang, tahun_terbit = @tahun_terbit, 
            kategori = @kategori, harga = @harga, stok = @stok, kode_buku = @kode_buku "
        query = query & "WHERE id = @id"
        npgsqlConn = Dbconnnection.openconnection() 'pembukaan koneksi'
        cmd = New NpgsqlCommand(query, npgsqlConn)
        cmd.Parameters.AddWithValue("@kode_buku", kode_buku)
        cmd.Parameters.AddWithValue("@judul", judul)
        cmd.Parameters.AddWithValue("@pengarang", pengarang)
        cmd.Parameters.AddWithValue("@tahun_terbit", tahun_terbit)
        cmd.Parameters.AddWithValue("@kategori", kategori)
        cmd.Parameters.AddWithValue("@harga", harga)
        cmd.Parameters.AddWithValue("@stok", stok)
        cmd.Parameters.AddWithValue("@id", id)
        Dim result As Integer
        result = cmd.ExecuteNonQuery()
        Dbconnnection.CloseConnection()
        Return result
    End Function






    Public Function delete(id As Integer) As Integer
        query = "UPDATE manage_buku set isdelete = @flagYes "
        query = query & "where id = @id"
        npgsqlConn = Dbconnnection.openconnection()
        cmd = New NpgsqlCommand(query, npgsqlConn)
        cmd.Parameters.AddWithValue("@flagYes", 1)
        cmd.Parameters.AddWithValue("@id", id)
        Dim result As Integer
        result = cmd.ExecuteNonQuery()
        Dbconnnection.CloseConnection()
        Return result


    End Function


    ' Fungsi Update Stok
    Public Function UpdateStok(kodeBuku As String, jumlah As Integer) As Integer


        query = "UPDATE manage_buku SET stok = stok - @jumlah WHERE kode_buku = @kode"
        npgsqlConn = Dbconnnection.openconnection()
        cmd = New NpgsqlCommand(query, npgsqlConn)
        cmd.Parameters.AddWithValue("@jumlah", jumlah)
        cmd.Parameters.AddWithValue("@kode", kodeBuku)
        Dim result As Integer
        result = cmd.ExecuteNonQuery()
        Dbconnnection.CloseConnection()
        Return result


    End Function

    ' Fungsi Simpan Transaksi
    Public Function InsertTransaction(kodeBuku As String, jumlah As Integer, total As Decimal) As Integer
        query = "INSERT INTO transactions (kode_buku, jumlah, total, tanggal) VALUES (@kode, @jumlah, @total, NOW())"
        npgsqlConn = Dbconnnection.openconnection()
        cmd = New NpgsqlCommand(query, npgsqlConn)
        cmd.Parameters.AddWithValue("@kode", kodeBuku)
        cmd.Parameters.AddWithValue("@jumlah", jumlah)
        cmd.Parameters.AddWithValue("@total", total)
        Dim result As Integer
        result = cmd.ExecuteNonQuery()
        Dbconnnection.CloseConnection()
        Return result


        Using npgsqlConn As NpgsqlConnection = Dbconnnection.openconnection()
            Dim query As String = "INSERT INTO transactions (kode_buku, jumlah, total, tanggal) 
                                VALUES (@kode, @jumlah, @total, NOW())"
            Using cmd As New NpgsqlCommand(query, npgsqlConn)
                cmd.Parameters.AddWithValue("@kode", kodeBuku)
                cmd.Parameters.AddWithValue("@jumlah", jumlah)
                cmd.Parameters.AddWithValue("@total", total)
                Return cmd.ExecuteNonQuery()
            End Using
        End Using
    End Function
End Class



