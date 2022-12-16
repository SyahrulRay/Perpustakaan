Public Class TambahKoleksi


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DTTanggal.Format = DateTimePickerFormat.Custom
        DTTanggal.CustomFormat = "yyyy/MM/dd"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnTambahKoleksi.Click




        DaftarKoleksi.dataPerpus.GSnamaKoleksi = TxtNama.Text
        DaftarKoleksi.dataPerpus.GSjenisKoleksi = ComJenis.SelectedItem
        DaftarKoleksi.dataPerpus.GSDeks = TxtDeks.Text
        DaftarKoleksi.dataPerpus.GSPenerbit = TxtPenerbit.Text
        DaftarKoleksi.dataPerpus.GSthnTerbit = TxtthnTerbit.Text
        DaftarKoleksi.dataPerpus.GSLokasi = TxtLokasi.Text
        DaftarKoleksi.dataPerpus.GStanggalMasuk = DTTanggal.Value.ToShortDateString
        DaftarKoleksi.dataPerpus.GSStock = TxtStock.Text

        If RdIndo.Checked Then
            DaftarKoleksi.dataPerpus.GSBahasa = "Bahasa Indonesia"
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

        Dim infoKoleksi = New InfoTambahKoleksi()
        DaftarKoleksi.LbKoleksiBuku.Items.Add(DaftarKoleksi.dataPerpus.GSnamaKoleksi)
        infoKoleksi.Show()

        Dim convertedKoleksi = DaftarKoleksi.dataPerpus.convertKoleksiToString(DaftarKoleksi.dataPerpus.GSKategori)
        DaftarKoleksi.dataPerpus.AddDataKoleksiDatabase(
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
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnTambahPic.Click
        Dim filereader
        OpenFilePicture1.Title = "Buka Picture"
        OpenFilePicture1.Filter = "Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.JPEG|Image PNG|*.png|Image GIF|*.gif|All Format|*.*"
        OpenFilePicture1.ShowDialog()
        PicBox.Load(OpenFilePicture1.FileName)
        PicBox.SizeMode = PictureBoxSizeMode.StretchImage

        DaftarKoleksi.dataPerpus.GSPhoto = OpenFilePicture1.FileNames.ToString()
        DaftarKoleksi.dataPerpus.GSPhoto = DaftarKoleksi.dataPerpus.GSPhoto.Replace("\", "/")


    End Sub
End Class