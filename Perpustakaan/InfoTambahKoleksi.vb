Public Class InfoTambahKoleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


        If Not String.IsNullOrEmpty(DaftarKoleksi.dataPerpus.GSPhoto) Then
            PicBox.Load(DaftarKoleksi.dataPerpus.GSPhoto)
            PicBox.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        LblNamaValue.Text = DaftarKoleksi.dataPerpus.GSnamaKoleksi
        LblJenisKoleksi.Text = DaftarKoleksi.dataPerpus.GSjenisKoleksi
        LblDeksValue.Text = DaftarKoleksi.dataPerpus.GSDeks
        LblPenerbitValue.Text = DaftarKoleksi.dataPerpus.GSPenerbit
        LblThnTerbitValue.Text = DaftarKoleksi.dataPerpus.GSthnTerbit
        LblLokasiValue.Text = DaftarKoleksi.dataPerpus.GSLokasi
        LblTanggalValue.Text = DaftarKoleksi.dataPerpus.GStanggalMasuk
        LblStockValue.Text = DaftarKoleksi.dataPerpus.GSStock
        LblBahasaValue.Text = DaftarKoleksi.dataPerpus.GSBahasa

        LbKategoriValue.Items.Clear()

        For Each Kat In DaftarKoleksi.dataPerpus.GSKategori
            LbKategoriValue.Items.Add(Kat)
        Next


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class