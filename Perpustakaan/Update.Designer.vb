<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PicBox = New System.Windows.Forms.PictureBox()
        Me.TxtDeks = New System.Windows.Forms.RichTextBox()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.CbBudaya = New System.Windows.Forms.CheckBox()
        Me.CbTeknologi = New System.Windows.Forms.CheckBox()
        Me.CbSosial = New System.Windows.Forms.CheckBox()
        Me.CbSains = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RdInggris = New System.Windows.Forms.RadioButton()
        Me.RdIndo = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.DTTanggal = New System.Windows.Forms.DateTimePicker()
        Me.TxtLokasi = New System.Windows.Forms.TextBox()
        Me.OpenFilePicture1 = New System.Windows.Forms.OpenFileDialog()
        Me.TxtthnTerbit = New System.Windows.Forms.TextBox()
        Me.ComJenis = New System.Windows.Forms.ComboBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TxtPenerbit = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnTambahPic = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PicBox
        '
        Me.PicBox.Location = New System.Drawing.Point(99, 46)
        Me.PicBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.Size = New System.Drawing.Size(150, 179)
        Me.PicBox.TabIndex = 47
        Me.PicBox.TabStop = False
        '
        'TxtDeks
        '
        Me.TxtDeks.Location = New System.Drawing.Point(475, 129)
        Me.TxtDeks.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtDeks.Name = "TxtDeks"
        Me.TxtDeks.Size = New System.Drawing.Size(220, 101)
        Me.TxtDeks.TabIndex = 46
        Me.TxtDeks.Text = ""
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(415, 813)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(150, 37)
        Me.BtnUpdate.TabIndex = 45
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'CbBudaya
        '
        Me.CbBudaya.AutoSize = True
        Me.CbBudaya.Location = New System.Drawing.Point(7, 156)
        Me.CbBudaya.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CbBudaya.Name = "CbBudaya"
        Me.CbBudaya.Size = New System.Drawing.Size(80, 24)
        Me.CbBudaya.TabIndex = 3
        Me.CbBudaya.Text = "Budaya"
        Me.CbBudaya.UseVisualStyleBackColor = True
        '
        'CbTeknologi
        '
        Me.CbTeknologi.AutoSize = True
        Me.CbTeknologi.Location = New System.Drawing.Point(7, 123)
        Me.CbTeknologi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CbTeknologi.Name = "CbTeknologi"
        Me.CbTeknologi.Size = New System.Drawing.Size(96, 24)
        Me.CbTeknologi.TabIndex = 2
        Me.CbTeknologi.Text = "Teknologi"
        Me.CbTeknologi.UseVisualStyleBackColor = True
        '
        'CbSosial
        '
        Me.CbSosial.AutoSize = True
        Me.CbSosial.Location = New System.Drawing.Point(7, 91)
        Me.CbSosial.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CbSosial.Name = "CbSosial"
        Me.CbSosial.Size = New System.Drawing.Size(70, 24)
        Me.CbSosial.TabIndex = 1
        Me.CbSosial.Text = "Sosial"
        Me.CbSosial.UseVisualStyleBackColor = True
        '
        'CbSains
        '
        Me.CbSains.AutoSize = True
        Me.CbSains.Location = New System.Drawing.Point(7, 58)
        Me.CbSains.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CbSains.Name = "CbSains"
        Me.CbSains.Size = New System.Drawing.Size(65, 24)
        Me.CbSains.TabIndex = 0
        Me.CbSains.Text = "Sains"
        Me.CbSains.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CbBudaya)
        Me.GroupBox2.Controls.Add(Me.CbTeknologi)
        Me.GroupBox2.Controls.Add(Me.CbSosial)
        Me.GroupBox2.Controls.Add(Me.CbSains)
        Me.GroupBox2.Location = New System.Drawing.Point(477, 574)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(229, 204)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kategori"
        '
        'RdInggris
        '
        Me.RdInggris.AutoSize = True
        Me.RdInggris.Location = New System.Drawing.Point(7, 84)
        Me.RdInggris.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RdInggris.Name = "RdInggris"
        Me.RdInggris.Size = New System.Drawing.Size(75, 24)
        Me.RdInggris.TabIndex = 1
        Me.RdInggris.TabStop = True
        Me.RdInggris.Text = "Inggris"
        Me.RdInggris.UseVisualStyleBackColor = True
        '
        'RdIndo
        '
        Me.RdIndo.AutoSize = True
        Me.RdIndo.Location = New System.Drawing.Point(7, 46)
        Me.RdIndo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RdIndo.Name = "RdIndo"
        Me.RdIndo.Size = New System.Drawing.Size(94, 24)
        Me.RdIndo.TabIndex = 0
        Me.RdIndo.TabStop = True
        Me.RdIndo.Text = "Indonesia"
        Me.RdIndo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdInggris)
        Me.GroupBox1.Controls.Add(Me.RdIndo)
        Me.GroupBox1.Location = New System.Drawing.Point(477, 433)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(229, 133)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bahasa"
        '
        'TxtStock
        '
        Me.TxtStock.Location = New System.Drawing.Point(477, 394)
        Me.TxtStock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(219, 27)
        Me.TxtStock.TabIndex = 42
        '
        'DTTanggal
        '
        Me.DTTanggal.Location = New System.Drawing.Point(477, 355)
        Me.DTTanggal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DTTanggal.Name = "DTTanggal"
        Me.DTTanggal.Size = New System.Drawing.Size(219, 27)
        Me.DTTanggal.TabIndex = 41
        '
        'TxtLokasi
        '
        Me.TxtLokasi.Location = New System.Drawing.Point(477, 317)
        Me.TxtLokasi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtLokasi.Name = "TxtLokasi"
        Me.TxtLokasi.Size = New System.Drawing.Size(219, 27)
        Me.TxtLokasi.TabIndex = 40
        '
        'OpenFilePicture1
        '
        Me.OpenFilePicture1.FileName = "OpenFilePicture1"
        '
        'TxtthnTerbit
        '
        Me.TxtthnTerbit.Location = New System.Drawing.Point(477, 278)
        Me.TxtthnTerbit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtthnTerbit.Name = "TxtthnTerbit"
        Me.TxtthnTerbit.Size = New System.Drawing.Size(219, 27)
        Me.TxtthnTerbit.TabIndex = 39
        '
        'ComJenis
        '
        Me.ComJenis.FormattingEnabled = True
        Me.ComJenis.Items.AddRange(New Object() {"Komik", "Majalah", "Novel", "Buku Paket"})
        Me.ComJenis.Location = New System.Drawing.Point(477, 81)
        Me.ComJenis.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComJenis.Name = "ComJenis"
        Me.ComJenis.Size = New System.Drawing.Size(219, 28)
        Me.ComJenis.TabIndex = 37
        '
        'TxtPenerbit
        '
        Me.TxtPenerbit.Location = New System.Drawing.Point(477, 239)
        Me.TxtPenerbit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtPenerbit.Name = "TxtPenerbit"
        Me.TxtPenerbit.Size = New System.Drawing.Size(219, 27)
        Me.TxtPenerbit.TabIndex = 38
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(477, 35)
        Me.TxtNama.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(219, 27)
        Me.TxtNama.TabIndex = 36
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(311, 574)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 20)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Kategori"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(311, 433)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 20)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Bahasa"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(311, 398)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 20)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Stock"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(311, 363)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 20)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Tanggal Masuk "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(311, 321)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 20)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Lokasi Rak"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(311, 282)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 20)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Tahun Terbit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(311, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Penerbit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(311, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Deskripsi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(311, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Jenis Koleksi"
        '
        'BtnTambahPic
        '
        Me.BtnTambahPic.Location = New System.Drawing.Point(99, 233)
        Me.BtnTambahPic.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnTambahPic.Name = "BtnTambahPic"
        Me.BtnTambahPic.Size = New System.Drawing.Size(150, 37)
        Me.BtnTambahPic.TabIndex = 26
        Me.BtnTambahPic.Text = "Tambah Gambar"
        Me.BtnTambahPic.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(311, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "NamaKoleksi"
        '
        'FormUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 876)
        Me.Controls.Add(Me.PicBox)
        Me.Controls.Add(Me.TxtDeks)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtStock)
        Me.Controls.Add(Me.DTTanggal)
        Me.Controls.Add(Me.TxtLokasi)
        Me.Controls.Add(Me.TxtthnTerbit)
        Me.Controls.Add(Me.ComJenis)
        Me.Controls.Add(Me.TxtPenerbit)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnTambahPic)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormUpdate"
        Me.Text = "UpdateFormKoleksi"
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicBox As PictureBox
    Friend WithEvents TxtDeks As RichTextBox
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents CbBudaya As CheckBox
    Friend WithEvents CbTeknologi As CheckBox
    Friend WithEvents CbSosial As CheckBox
    Friend WithEvents CbSains As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RdInggris As RadioButton
    Friend WithEvents RdIndo As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents DTTanggal As DateTimePicker
    Friend WithEvents TxtLokasi As TextBox
    Friend WithEvents OpenFilePicture1 As OpenFileDialog
    Friend WithEvents TxtthnTerbit As TextBox
    Friend WithEvents ComJenis As ComboBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TxtPenerbit As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnTambahPic As Button
    Friend WithEvents Label1 As Label
End Class
