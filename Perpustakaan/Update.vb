Public Class FormUpdate

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PicBox.Load(DaftarKoleksi.dataPerpus.GSPhoto)
        PicBox.SizeMode = PictureBoxSizeMode.StretchImage
        DTTanggal.Format = DateTimePickerFormat.Custom
        DTTanggal.CustomFormat = "yyyy/MM/dd"
        TxtNama.Text = DaftarKoleksi.dataPerpus.GSnamaKoleksi
        ComJenis.SelectedItem() = DaftarKoleksi.dataPerpus.GSjenisKoleksi
        TxtDeks.Text = DaftarKoleksi.dataPerpus.GSDeks
        TxtPenerbit.Text = DaftarKoleksi.dataPerpus.GSPenerbit
        TxtthnTerbit.Text = DaftarKoleksi.dataPerpus.GSthnTerbit
        TxtLokasi.Text = DaftarKoleksi.dataPerpus.GSLokasi
        DTTanggal.Value = DaftarKoleksi.dataPerpus.GStanggalMasuk
        TxtStock.Text = DaftarKoleksi.dataPerpus.GSStock

        If String.Compare(DaftarKoleksi.dataPerpus.GSBahasa, "Bahasa Indonesia") = 0 Then
            RdIndo.Checked = True
        ElseIf String.Compare(DaftarKoleksi.dataPerpus.GSBahasa, "Bahasa Inggris") = 0 Then
            RdInggris.Checked = True
        End If

        For Each Kategori In DaftarKoleksi.dataPerpus.GSKategori
            If String.Compare(Kategori, "Sains") Then
                CbSains.Checked = True
            ElseIf String.Compare(Kategori, "Budaya") Then
                CbBudaya.Checked = True
            ElseIf String.Compare(Kategori, "Teknologi") Then
                CbTeknologi.Checked = True
            ElseIf String.Compare(Kategori, "Sosial") Then
                CbSosial.Checked = True
            End If

        Next
    End Sub
    Private Sub BtnTambahKoleksi_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        DaftarKoleksi.dataPerpus.GSnamaKoleksi = TxtNama.Text
        DaftarKoleksi.dataPerpus.GSjenisKoleksi = ComJenis.SelectedItem
        DaftarKoleksi.dataPerpus.GSDeks = TxtDeks.Text
        DaftarKoleksi.dataPerpus.GSPenerbit = TxtPenerbit.Text
        DaftarKoleksi.dataPerpus.GSthnTerbit = TxtthnTerbit.Text
        DaftarKoleksi.dataPerpus.GSLokasi = TxtLokasi.Text
        DaftarKoleksi.dataPerpus.GStanggalMasuk = DTTanggal.Value.ToShortDateString
        DaftarKoleksi.dataPerpus.GSStock = TxtStock.Text

        If RdIndo.Checked Then
            DaftarKoleksi.dataPerpus.GSBahasa = "Baha Indonesia"
        End If
        If RdInggris.Checked Then
            DaftarKoleksi.dataPerpus.GSBahasa = "Bahasa Inggris"
        End If

        If CbSains.Checked() Then
            DaftarKoleksi.dataPerpus.GSKategori.Add("Sains")
        End If
        If CbBudaya.Checked() Then
            DaftarKoleksi.dataPerpus.GSKategori.Add("Budaya")
        End If
        If CbTeknologi.Checked() Then
            DaftarKoleksi.dataPerpus.GSKategori.Add("Teknologi")
        End If
        If CbSosial.Checked() Then
            DaftarKoleksi.dataPerpus.GSKategori.Add("Sosial")
        End If

        DaftarKoleksi.dataPerpus.GSPhoto = OpenFilePicture1.FileName

        Dim convertedKoleksi = DaftarKoleksi.dataPerpus.convertKoleksiToString(DaftarKoleksi.dataPerpus.GSKategori)
        DaftarKoleksi.dataPerpus.UpdateDateKoleksiByIdDatabase(
        DaftarKoleksi.selectedTableKoleksi,
        DaftarKoleksi.dataPerpus.GSnamaKoleksi,
        DaftarKoleksi.dataPerpus.GSjenisKoleksi,
        DaftarKoleksi.dataPerpus.GSDeks,
        DaftarKoleksi.dataPerpus.GSPenerbit,
        DaftarKoleksi.dataPerpus.GSthnTerbit,
        DaftarKoleksi.dataPerpus.GSLokasi,
        DaftarKoleksi.dataPerpus.GStanggalMasuk,
        DaftarKoleksi.dataPerpus.GSStock,
        DaftarKoleksi.dataPerpus.GSBahasa,
        convertedKoleksi,
        DaftarKoleksi.dataPerpus.GSPhoto
        )

        Dim infotambah = New InfoTambahKoleksi()
        infotambah.Show()

        Me.Close()
    End Sub
End Class