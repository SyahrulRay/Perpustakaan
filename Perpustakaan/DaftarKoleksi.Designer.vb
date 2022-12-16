<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DaftarKoleksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LbKoleksiBuku = New System.Windows.Forms.ListBox()
        Me.BtnPlus = New System.Windows.Forms.Button()
        Me.BtnMin = New System.Windows.Forms.Button()
        Me.DataGridKoleksi = New System.Windows.Forms.DataGridView()
        Me.BtnShow = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KoleksiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1605, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KoleksiToolStripMenuItem
        '
        Me.KoleksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahKoleksiToolStripMenuItem})
        Me.KoleksiToolStripMenuItem.Name = "KoleksiToolStripMenuItem"
        Me.KoleksiToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.KoleksiToolStripMenuItem.Text = "Koleksi"
        '
        'TambahKoleksiToolStripMenuItem
        '
        Me.TambahKoleksiToolStripMenuItem.Name = "TambahKoleksiToolStripMenuItem"
        Me.TambahKoleksiToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.TambahKoleksiToolStripMenuItem.Text = "Tambah Koleksi"
        '
        'LbKoleksiBuku
        '
        Me.LbKoleksiBuku.FormattingEnabled = True
        Me.LbKoleksiBuku.ItemHeight = 20
        Me.LbKoleksiBuku.Items.AddRange(New Object() {"Koleksi Buku", "a", "a", "a", "a", "a"})
        Me.LbKoleksiBuku.Location = New System.Drawing.Point(7, 69)
        Me.LbKoleksiBuku.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LbKoleksiBuku.Name = "LbKoleksiBuku"
        Me.LbKoleksiBuku.Size = New System.Drawing.Size(105, 464)
        Me.LbKoleksiBuku.TabIndex = 1
        '
        'BtnPlus
        '
        Me.BtnPlus.BackColor = System.Drawing.Color.White
        Me.BtnPlus.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.plusbutton
        Me.BtnPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPlus.Location = New System.Drawing.Point(14, 36)
        Me.BtnPlus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnPlus.Name = "BtnPlus"
        Me.BtnPlus.Size = New System.Drawing.Size(25, 29)
        Me.BtnPlus.TabIndex = 2
        Me.BtnPlus.UseVisualStyleBackColor = False
        '
        'BtnMin
        '
        Me.BtnMin.BackColor = System.Drawing.Color.White
        Me.BtnMin.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.minbtn
        Me.BtnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMin.Location = New System.Drawing.Point(40, 36)
        Me.BtnMin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnMin.Name = "BtnMin"
        Me.BtnMin.Size = New System.Drawing.Size(25, 29)
        Me.BtnMin.TabIndex = 3
        Me.BtnMin.UseVisualStyleBackColor = False
        '
        'DataGridKoleksi
        '
        Me.DataGridKoleksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridKoleksi.Location = New System.Drawing.Point(273, 71)
        Me.DataGridKoleksi.Name = "DataGridKoleksi"
        Me.DataGridKoleksi.RowHeadersWidth = 51
        Me.DataGridKoleksi.RowTemplate.Height = 29
        Me.DataGridKoleksi.Size = New System.Drawing.Size(1301, 464)
        Me.DataGridKoleksi.TabIndex = 4
        '
        'BtnShow
        '
        Me.BtnShow.Location = New System.Drawing.Point(739, 553)
        Me.BtnShow.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnShow.Name = "BtnShow"
        Me.BtnShow.Size = New System.Drawing.Size(145, 31)
        Me.BtnShow.TabIndex = 5
        Me.BtnShow.Text = "Show"
        Me.BtnShow.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(922, 553)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(145, 31)
        Me.BtnUpdate.TabIndex = 6
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(1135, 553)
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(145, 31)
        Me.BtnHapus.TabIndex = 7
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'DaftarKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1605, 600)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnShow)
        Me.Controls.Add(Me.DataGridKoleksi)
        Me.Controls.Add(Me.BtnMin)
        Me.Controls.Add(Me.BtnPlus)
        Me.Controls.Add(Me.LbKoleksiBuku)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "DaftarKoleksi"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahKoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LbKoleksiBuku As ListBox
    Friend WithEvents BtnPlus As Button
    Friend WithEvents BtnMin As Button
    Friend WithEvents DataGridKoleksi As DataGridView
    Friend WithEvents BtnShow As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnHapus As Button
End Class
