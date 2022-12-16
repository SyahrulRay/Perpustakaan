Imports System.Runtime.CompilerServices
Imports System.Text
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common
Imports Mysqlx.XDevAPI.Relational

Public Class DataPerpus
    Public Sub New()

    End Sub



    Private namaKoleksi As String
    Private jenisKoleksi As String
    Private Deks As String
    Private Penerbit As String
    Private thnTerbit As String
    Private Lokasi As String
    Private tanggalMasuk As String
    Private Stock As String
    Private Bahasa As String
    Private Kategori_arr As New List(Of String)
    Private Photo As String
    Private koleksiDataTable As New ArrayList()

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlComm As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "perpustakaan"

    Public Property GSnamaKoleksi As String
        Get
            Return namaKoleksi
        End Get
        Set(value As String)
            namaKoleksi = value
        End Set
    End Property

    Public Property GSjenisKoleksi As String
        Get
            Return jenisKoleksi
        End Get
        Set(value As String)
            jenisKoleksi = value
        End Set
    End Property

    Public Property GSDeks As String
        Get
            Return Deks
        End Get
        Set(value As String)
            Deks = value
        End Set
    End Property

    Public Property GSPenerbit As String
        Get
            Return Penerbit
        End Get
        Set(value As String)
            Penerbit = value
        End Set
    End Property

    Public Property GSthnTerbit As String
        Get
            Return thnTerbit
        End Get
        Set(value As String)
            thnTerbit = value
        End Set
    End Property

    Public Property GSLokasi As String
        Get
            Return Lokasi
        End Get
        Set(value As String)
            Lokasi = value
        End Set
    End Property

    Public Property GStanggalMasuk As String
        Get
            Return tanggalMasuk
        End Get
        Set(value As String)
            tanggalMasuk = value
        End Set
    End Property

    Public Property GSStock As String
        Get
            Return Stock
        End Get
        Set(value As String)
            Stock = value
        End Set
    End Property
    Public Property GSBahasa As String
        Get
            Return Bahasa
        End Get
        Set(value As String)
            Bahasa = value
        End Set
    End Property

    Public Property GSKategori As List(Of String)
        Get
            Return Kategori_arr
        End Get
        Set(value As List(Of String))
            Kategori_arr = value
        End Set
    End Property

    Public Property GSPhoto As String
        Get
            Return Photo
        End Get
        Set(value As String)
            Photo = value
        End Set
    End Property

    Public Function addKoleksiDataTable(namaKoleksi As String,
        jenisKoleksi As String,
        Deks As String,
        Penerbit As String,
        thnTerbit As String,
        Lokasi As String,
        tanggalMasuk As String,
        Stock As String,
        Bahasa As String,
        Kategori_arr As String,
        Photo As String
        )

        koleksiDataTable.Add({
        namaKoleksi,
        jenisKoleksi,
        Deks,
        Penerbit,
        thnTerbit,
        Lokasi,
        tanggalMasuk,
        Stock,
        Bahasa,
        Kategori_arr,
        Photo})

    End Function

    Public Function removeDataTable(index As Integer)
        koleksiDataTable.RemoveAt(index)
    End Function

    Public Function convertKoleksiToString(vals As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()
        For Each val As String In vals
            builder.Append(val).Append("|")
        Next

        Dim res = builder.ToString()
        Return res
    End Function

    Public Function convertStringToKoleksi(value As String)
        Dim arr() As String = value.Split("|")

        Dim vals As List(Of String) = arr.ToList()
        Return vals
    End Function


    Public ReadOnly Property getKoleksiDataTable As ArrayList
        Get
            Return koleksiDataTable
        End Get
    End Property

    'Public Sub addKoleksi(item As String)
    '    Kategori_arr.Add(item)
    'End Sub

    Public Function GetDataKoleksiDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " _
        + password + ";" + "database = " + database + ";" + "convert zero datetime=True"
        dbConn.Open()
        sqlComm.Connection = dbConn
        sqlComm.CommandText = "SELECT ID_KOLEKSI AS 'ID',
                               NAMA_KOLEKSI AS 'NAMA KOLEKSI',
                               JENIS_KOLEKSI AS 'JENIS KOLEKSI',
                               DESKRIPSI AS 'DESKRIPSI',
                               PENERBIT AS 'PENERBIT',
                               THN_TERBIT AS 'TAHUN TERBIT',
                               LOKASI AS 'LOKASI',
                               TGL_MASUK AS 'TANGGAL MASUK',
                               STOCK AS 'STOCK',
                               BAHASA AS 'BAHASA',
                               KATEGORI AS 'KATEGORI'
                               FROM DATAPERPUS"

        sqlRead = sqlComm.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()

        Return result
    End Function

    Public Function AddDataKoleksiDatabase(
                                            namaKoleksi As String,
                                            jenisKoleksi As String,
                                            Deks As String,
                                            Penerbit As String,
                                            thnTerbit As String,
                                            Lokasi As String,
                                            tanggalMasuk As Date,
                                            Stock As String,
                                            Bahasa As String,
                                            Kategori_arr As String,
                                            Photo As String)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " _
        + password + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlComm.Connection = dbConn
            sqlQuery = "INSERT INTO DATAPERPUS(NAMA_KOLEKSI,JENIS_KOLEKSI,DESKRIPSI,
                        PENERBIT,THN_TERBIT,LOKASI,TGL_MASUK, STOCK, BAHASA, KATEGORI,PHOTO) VALUE (
                        '" & namaKoleksi & "',
                        '" & jenisKoleksi & "',
                        '" & Deks & "',
                        '" & Penerbit & "',
                        '" & thnTerbit & "',
                        '" & Lokasi & "',
                        '" & tanggalMasuk.ToString("yyyy/MM/dd") & "',
                        '" & Stock & "',
                        '" & Bahasa & "',
                        '" & Kategori_arr & "',
                        '" & Photo & "')
                        "

            sqlComm = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlComm.ExecuteReader

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()

        End Try

    End Function

    Public Function GetDataKoleksiByIdDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " _
        + password + ";" + "database = " + database
        dbConn.Open()

        sqlComm.Connection = dbConn
        sqlComm.CommandText = "SELECT ID_KOLEKSI,
                               NAMA_KOLEKSI,JENIS_KOLEKSI,DESKRIPSI,
                               PENERBIT,THN_TERBIT,LOKASI,TGL_MASUK, STOCK, BAHASA, KATEGORI,PHOTO
                               FROM DATAPERPUS WHERE ID_KOLEKSI = '" & ID & "'"

        sqlRead = sqlComm.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
            result.Add(sqlRead.GetString(5).ToString())
            result.Add(sqlRead.GetString(6).ToString())
            result.Add(sqlRead.GetString(7).ToString())
            result.Add(sqlRead.GetString(8).ToString())
            result.Add(sqlRead.GetString(9).ToString())
            result.Add(sqlRead.GetString(10).ToString())
            result.Add(sqlRead.GetString(11).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateDateKoleksiByIdDatabase(ID As Integer,
                                                  namaKoleksi As String,
                                                  jenisKoleksi As String,
                                                  Deks As String,
                                                  Penerbit As String,
                                                  thnTerbit As String,
                                                  Lokasi As String,
                                                  tanggalMasuk As Date,
                                                  Stock As Integer,
                                                  Bahasa As String,
                                                  Kategori_arr As String,
                                                  Photo As String)
        thnTerbit = thnTerbit.ToString()
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " _
        + password + ";" + "database = " + database

        Try
            dbConn.Open()
            sqlComm.Connection = dbConn
            sqlQuery = " UPDATE DATAPERPUS SET 
                       " & " NAMA_KOLEKSI '" & namaKoleksi & "',
                       " & " JENIS_KOLEKSI '" & jenisKoleksi & "',
                       " & " DESKRIPSI '" & Deks & "',
                       " & " PENERBIT '" & Penerbit & "',
                       " & " THN_TERBIT '" & thnTerbit & "',
                       " & " LOKASI '" & Lokasi & "',
                       " & " TGL_MASUK '" & tanggalMasuk.ToString("yyyy/MM/dd") & "',
                       " & " STOCK '" & Stock & "',
                       " & " BAHASA '" & Bahasa & "',
                       " & " KATEGORI '" & Kategori_arr & "',
                       " & " PHOTO '" & Photo & "'
                       " & " WHERE ID_KOLEKSI =  '" & ID & "'
                       "

            sqlComm = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlComm.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function DeleteDataKoleksiByIdDatabase(ID As Integer)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " _
        + password + ";" + "database = " + database

        Try
            dbConn.Open()
            sqlComm.Connection = dbConn
            sqlQuery = "DELETE DATAPERPUS" &
                       "WHERE ID_KOLEKSI='" & ID & "'"

            Debug.WriteLine(sqlQuery)

            sqlComm = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlComm.ExecuteReader
            dbConn.Close()


            sqlRead.Close()
            dbConn.Close()


        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

    End Function


End Class
