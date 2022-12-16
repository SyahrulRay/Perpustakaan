Public Class KonfirmHapus
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        'DaftarKoleksi.LbKoleksiBuku.Items.Remove(DaftarKoleksi.selected_buku)
        DaftarKoleksi.dataPerpus.DeleteDataKoleksiByIdDatabase(DaftarKoleksi.selectedTableKoleksi)
        Me.Close()
    End Sub

    Private Sub KonfirmHapus_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LblKoleksi.Text = DaftarKoleksi.selectedTableKoleksi
    End Sub
End Class