Imports System.Diagnostics.Tracing
Imports System.DirectoryServices.ActiveDirectory

Public Class DaftarKoleksi
    Public Shared dataPerpus As DataPerpus
    Public Shared selected_buku
    Public Shared selectedTableKoleksi
    Public Shared selectedTableKoleksiNama

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        dataPerpus = New DataPerpus()
        ReloadDataTableDatabase()
    End Sub

    Private Sub LbKoleksiBuku_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LbKoleksiBuku.KeyPress
        If LbKoleksiBuku.SelectedItem.count <= 0 Then
            e.Handled = True
            MessageBox.Show("Please Select At Least One Item")
        End If

    End Sub

    Private Sub BtnPlus_Click(sender As Object, e As EventArgs) Handles BtnPlus.Click
        Dim TambahKoleksi = New TambahKoleksi()
        TambahKoleksi.Show()
    End Sub

    Private Sub BtnMin_Click(sender As Object, e As EventArgs) Handles BtnMin.Click
        Dim konfirmHapus = New KonfirmHapus


        If LbKoleksiBuku.SelectedItem Is Nothing Then
            MessageBox.Show("Please Select At Least One Item")

        Else
            selected_buku = LbKoleksiBuku.SelectedItem
            konfirmHapus.Show()
            'If konfirmHapus.BtnHapus Is Clicke Then
        End If

    End Sub

    Public Sub UpdateDataTableArrayList()
        'DataGridKoleksi.Rows.Clear()
        For Each rowKoleksi In dataPerpus.getKoleksiDataTable
            Dim dataTable As String() = {
                rowKoleksi(0),
                rowKoleksi(1),
                rowKoleksi(3),
                rowKoleksi(4),
                rowKoleksi(2),
                rowKoleksi(5),
                rowKoleksi(6),
                rowKoleksi(7),
                rowKoleksi(8),
                rowKoleksi(9)}
            DataGridKoleksi.Rows.Add(dataTable)
        Next
    End Sub

    Private Sub DaftarKoleksi_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        UpdateDataTableArrayList()
        ReloadDataTableDatabase()
    End Sub

    Private Sub DataGridKoleksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridKoleksi.CellClick
        'selectedTableKoleksi = DataGridKoleksi.CurrentRow.Index
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridKoleksi.Rows(index)

        selectedTableKoleksi = selectedRow.Cells(0).Value
        selectedTableKoleksiNama = selectedRow.Cells(1).Value

    End Sub

    Private Sub BtnShow_Click(sender As Object, e As EventArgs) Handles BtnShow.Click
        If selectedTableKoleksi Is Nothing Then
            MessageBox.Show("Pleas Select at Least 1 Item ")
        Else

            Dim dataSelected As List(Of String) = dataPerpus.GetDataKoleksiByIdDatabase(selectedTableKoleksi)
            dataPerpus.GSnamaKoleksi = dataSelected(1)
            dataPerpus.GSjenisKoleksi = dataSelected(2)
            dataPerpus.GSDeks = dataSelected(3)
            dataPerpus.GSPenerbit = dataSelected(4)
            dataPerpus.GSthnTerbit = dataSelected(5)
            dataPerpus.GSLokasi = dataSelected(6)
            dataPerpus.GStanggalMasuk = dataSelected(7)
            dataPerpus.GSStock = dataSelected(8)
            dataPerpus.GSBahasa = dataSelected(9)
            dataPerpus.GSPhoto = dataSelected(11)

            Dim data_Koleksi As List(Of String) = dataPerpus.convertStringToKoleksi(dataSelected(10))

            'For Each info_tambah In data_Koleksi
            '    Kategori_arr.Add(info_tambah)
            'Next

            dataPerpus.GSKategori = data_Koleksi

            Dim infoTambah = New InfoTambahKoleksi()
            infoTambah.Show()


        End If

    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridKoleksi.DataSource = dataPerpus.GetDataKoleksiDatabase()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim dataSelected As List(Of String) = dataPerpus.GetDataKoleksiByIdDatabase(selectedTableKoleksi)
        dataPerpus.GSnamaKoleksi = dataSelected(1)
        dataPerpus.GSjenisKoleksi = dataSelected(2)
        dataPerpus.GSDeks = dataSelected(3)
        dataPerpus.GSPenerbit = dataSelected(4)
        dataPerpus.GSthnTerbit = dataSelected(5)
        dataPerpus.GSLokasi = dataSelected(6)
        dataPerpus.GStanggalMasuk = dataSelected(7)
        dataPerpus.GSStock = dataSelected(8)
        dataPerpus.GSBahasa = dataSelected(9)
        dataPerpus.GSPhoto = dataSelected(11)

        Dim data_Koleksi As List(Of String) = dataPerpus.convertStringToKoleksi(dataSelected(10))


        Dim formUpdate = New FormUpdate()
        formUpdate.Show()


    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim FormHapus = New KonfirmHapus()
        FormHapus.Show()
    End Sub
End Class
