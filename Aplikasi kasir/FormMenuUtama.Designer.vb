<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuUtama
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LnlKodeUser = New System.Windows.Forms.Label()
        Me.LblNmUsr = New System.Windows.Forms.Label()
        Me.LblHari = New System.Windows.Forms.Label()
        Me.LblJam = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnMinimize = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.BtnGantiPass = New System.Windows.Forms.Button()
        Me.BtnPengguna = New System.Windows.Forms.Button()
        Me.BtnSupplier = New System.Windows.Forms.Button()
        Me.BtnPelanggan = New System.Windows.Forms.Button()
        Me.BtnSatuan = New System.Windows.Forms.Button()
        Me.BtnKategori = New System.Windows.Forms.Button()
        Me.BtnBarang = New System.Windows.Forms.Button()
        Me.BtnBarangMasuk = New System.Windows.Forms.Button()
        Me.BtnBarangKeluar = New System.Windows.Forms.Button()
        Me.BtnStockOpname = New System.Windows.Forms.Button()
        Me.BtnLapMaster = New System.Windows.Forms.Button()
        Me.BtnLapBrgMasuk = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnLapStockOpname = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkViolet
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 26)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkViolet
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 494)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 26)
        Me.Panel2.TabIndex = 1
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 520)
        Me.ShapeContainer1.TabIndex = 2
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 4
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 1
        Me.LineShape1.X2 = 809
        Me.LineShape1.Y1 = 141
        Me.LineShape1.Y2 = 143
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 38)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "PT Mitra Jaya Abadi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 36)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Program"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Selamat Datang"
        '
        'LnlKodeUser
        '
        Me.LnlKodeUser.AutoSize = True
        Me.LnlKodeUser.Location = New System.Drawing.Point(44, 260)
        Me.LnlKodeUser.Name = "LnlKodeUser"
        Me.LnlKodeUser.Size = New System.Drawing.Size(57, 13)
        Me.LnlKodeUser.TabIndex = 6
        Me.LnlKodeUser.Text = "Kode User"
        '
        'LblNmUsr
        '
        Me.LblNmUsr.AutoSize = True
        Me.LblNmUsr.Location = New System.Drawing.Point(44, 293)
        Me.LblNmUsr.Name = "LblNmUsr"
        Me.LblNmUsr.Size = New System.Drawing.Size(60, 13)
        Me.LblNmUsr.TabIndex = 7
        Me.LblNmUsr.Text = "Nama User"
        '
        'LblHari
        '
        Me.LblHari.AutoSize = True
        Me.LblHari.Location = New System.Drawing.Point(640, 439)
        Me.LblHari.Name = "LblHari"
        Me.LblHari.Size = New System.Drawing.Size(26, 13)
        Me.LblHari.TabIndex = 9
        Me.LblHari.Text = "Hari"
        '
        'LblJam
        '
        Me.LblJam.AutoSize = True
        Me.LblJam.Location = New System.Drawing.Point(731, 439)
        Me.LblJam.Name = "LblJam"
        Me.LblJam.Size = New System.Drawing.Size(26, 13)
        Me.LblJam.TabIndex = 10
        Me.LblJam.Text = "Jam"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'BtnMinimize
        '
        Me.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimize.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnMinimize.Location = New System.Drawing.Point(591, 50)
        Me.BtnMinimize.Name = "BtnMinimize"
        Me.BtnMinimize.Size = New System.Drawing.Size(75, 43)
        Me.BtnMinimize.TabIndex = 8
        Me.BtnMinimize.Text = "Minimize"
        Me.BtnMinimize.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnKeluar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnKeluar.Location = New System.Drawing.Point(682, 50)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(75, 43)
        Me.BtnKeluar.TabIndex = 11
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'BtnLogout
        '
        Me.BtnLogout.BackColor = System.Drawing.Color.Indigo
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnLogout.Location = New System.Drawing.Point(26, 439)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(75, 43)
        Me.BtnLogout.TabIndex = 12
        Me.BtnLogout.Text = "Log Out"
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'BtnGantiPass
        '
        Me.BtnGantiPass.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnGantiPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGantiPass.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGantiPass.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnGantiPass.Location = New System.Drawing.Point(107, 439)
        Me.BtnGantiPass.Name = "BtnGantiPass"
        Me.BtnGantiPass.Size = New System.Drawing.Size(75, 43)
        Me.BtnGantiPass.TabIndex = 13
        Me.BtnGantiPass.Text = "Ganti Password"
        Me.BtnGantiPass.UseVisualStyleBackColor = False
        '
        'BtnPengguna
        '
        Me.BtnPengguna.BackColor = System.Drawing.Color.SeaGreen
        Me.BtnPengguna.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPengguna.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPengguna.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnPengguna.Location = New System.Drawing.Point(216, 204)
        Me.BtnPengguna.Name = "BtnPengguna"
        Me.BtnPengguna.Size = New System.Drawing.Size(146, 52)
        Me.BtnPengguna.TabIndex = 14
        Me.BtnPengguna.Text = "Pengguna"
        Me.BtnPengguna.UseVisualStyleBackColor = False
        '
        'BtnSupplier
        '
        Me.BtnSupplier.BackColor = System.Drawing.Color.Tomato
        Me.BtnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSupplier.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSupplier.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnSupplier.Location = New System.Drawing.Point(216, 260)
        Me.BtnSupplier.Name = "BtnSupplier"
        Me.BtnSupplier.Size = New System.Drawing.Size(70, 59)
        Me.BtnSupplier.TabIndex = 15
        Me.BtnSupplier.Text = "Supplier"
        Me.BtnSupplier.UseVisualStyleBackColor = False
        '
        'BtnPelanggan
        '
        Me.BtnPelanggan.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPelanggan.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPelanggan.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnPelanggan.Location = New System.Drawing.Point(292, 260)
        Me.BtnPelanggan.Name = "BtnPelanggan"
        Me.BtnPelanggan.Size = New System.Drawing.Size(70, 59)
        Me.BtnPelanggan.TabIndex = 16
        Me.BtnPelanggan.Text = "Pelanggan"
        Me.BtnPelanggan.UseVisualStyleBackColor = False
        '
        'BtnSatuan
        '
        Me.BtnSatuan.BackColor = System.Drawing.Color.DarkCyan
        Me.BtnSatuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSatuan.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSatuan.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnSatuan.Location = New System.Drawing.Point(368, 204)
        Me.BtnSatuan.Name = "BtnSatuan"
        Me.BtnSatuan.Size = New System.Drawing.Size(70, 52)
        Me.BtnSatuan.TabIndex = 17
        Me.BtnSatuan.Text = "Satuan"
        Me.BtnSatuan.UseVisualStyleBackColor = False
        '
        'BtnKategori
        '
        Me.BtnKategori.BackColor = System.Drawing.Color.Indigo
        Me.BtnKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnKategori.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKategori.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnKategori.Location = New System.Drawing.Point(444, 204)
        Me.BtnKategori.Name = "BtnKategori"
        Me.BtnKategori.Size = New System.Drawing.Size(70, 52)
        Me.BtnKategori.TabIndex = 18
        Me.BtnKategori.Text = "Kategori"
        Me.BtnKategori.UseVisualStyleBackColor = False
        '
        'BtnBarang
        '
        Me.BtnBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBarang.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBarang.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnBarang.Location = New System.Drawing.Point(368, 260)
        Me.BtnBarang.Name = "BtnBarang"
        Me.BtnBarang.Size = New System.Drawing.Size(146, 59)
        Me.BtnBarang.TabIndex = 19
        Me.BtnBarang.Text = "Barang"
        Me.BtnBarang.UseVisualStyleBackColor = False
        '
        'BtnBarangMasuk
        '
        Me.BtnBarangMasuk.BackColor = System.Drawing.Color.Indigo
        Me.BtnBarangMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBarangMasuk.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBarangMasuk.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnBarangMasuk.Location = New System.Drawing.Point(216, 325)
        Me.BtnBarangMasuk.Name = "BtnBarangMasuk"
        Me.BtnBarangMasuk.Size = New System.Drawing.Size(146, 52)
        Me.BtnBarangMasuk.TabIndex = 20
        Me.BtnBarangMasuk.Text = "Barang Masuk"
        Me.BtnBarangMasuk.UseVisualStyleBackColor = False
        '
        'BtnBarangKeluar
        '
        Me.BtnBarangKeluar.BackColor = System.Drawing.Color.Tomato
        Me.BtnBarangKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBarangKeluar.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnBarangKeluar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnBarangKeluar.Location = New System.Drawing.Point(368, 325)
        Me.BtnBarangKeluar.Name = "BtnBarangKeluar"
        Me.BtnBarangKeluar.Size = New System.Drawing.Size(70, 52)
        Me.BtnBarangKeluar.TabIndex = 21
        Me.BtnBarangKeluar.Text = "Barang Keluar"
        Me.BtnBarangKeluar.UseVisualStyleBackColor = False
        '
        'BtnStockOpname
        '
        Me.BtnStockOpname.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnStockOpname.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStockOpname.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStockOpname.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnStockOpname.Location = New System.Drawing.Point(444, 325)
        Me.BtnStockOpname.Name = "BtnStockOpname"
        Me.BtnStockOpname.Size = New System.Drawing.Size(70, 52)
        Me.BtnStockOpname.TabIndex = 22
        Me.BtnStockOpname.Text = "Stock Opname"
        Me.BtnStockOpname.UseVisualStyleBackColor = False
        '
        'BtnLapMaster
        '
        Me.BtnLapMaster.BackColor = System.Drawing.Color.SeaGreen
        Me.BtnLapMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLapMaster.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLapMaster.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnLapMaster.Location = New System.Drawing.Point(520, 204)
        Me.BtnLapMaster.Name = "BtnLapMaster"
        Me.BtnLapMaster.Size = New System.Drawing.Size(184, 52)
        Me.BtnLapMaster.TabIndex = 23
        Me.BtnLapMaster.Text = "Laporan Master"
        Me.BtnLapMaster.UseVisualStyleBackColor = False
        '
        'BtnLapBrgMasuk
        '
        Me.BtnLapBrgMasuk.BackColor = System.Drawing.Color.Crimson
        Me.BtnLapBrgMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLapBrgMasuk.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnLapBrgMasuk.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnLapBrgMasuk.Location = New System.Drawing.Point(520, 260)
        Me.BtnLapBrgMasuk.Name = "BtnLapBrgMasuk"
        Me.BtnLapBrgMasuk.Size = New System.Drawing.Size(89, 59)
        Me.BtnLapBrgMasuk.TabIndex = 24
        Me.BtnLapBrgMasuk.Text = "Laporan Barang Masuk"
        Me.BtnLapBrgMasuk.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(615, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 59)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Laporan Barang Keluar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnLapStockOpname
        '
        Me.BtnLapStockOpname.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnLapStockOpname.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLapStockOpname.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLapStockOpname.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnLapStockOpname.Location = New System.Drawing.Point(520, 325)
        Me.BtnLapStockOpname.Name = "BtnLapStockOpname"
        Me.BtnLapStockOpname.Size = New System.Drawing.Size(184, 52)
        Me.BtnLapStockOpname.TabIndex = 26
        Me.BtnLapStockOpname.Text = "Laporan Stock Opname"
        Me.BtnLapStockOpname.UseVisualStyleBackColor = False
        '
        'FormMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(800, 520)
        Me.Controls.Add(Me.BtnLapStockOpname)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnLapBrgMasuk)
        Me.Controls.Add(Me.BtnLapMaster)
        Me.Controls.Add(Me.BtnStockOpname)
        Me.Controls.Add(Me.BtnBarangKeluar)
        Me.Controls.Add(Me.BtnBarangMasuk)
        Me.Controls.Add(Me.BtnBarang)
        Me.Controls.Add(Me.BtnKategori)
        Me.Controls.Add(Me.BtnSatuan)
        Me.Controls.Add(Me.BtnPelanggan)
        Me.Controls.Add(Me.BtnSupplier)
        Me.Controls.Add(Me.BtnPengguna)
        Me.Controls.Add(Me.BtnGantiPass)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.LblJam)
        Me.Controls.Add(Me.LblHari)
        Me.Controls.Add(Me.BtnMinimize)
        Me.Controls.Add(Me.LblNmUsr)
        Me.Controls.Add(Me.LnlKodeUser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMenuUtama"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LnlKodeUser As Label
    Friend WithEvents LblNmUsr As Label
    Friend WithEvents LblHari As Label
    Friend WithEvents LblJam As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtnMinimize As Button
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents BtnLogout As Button
    Friend WithEvents BtnGantiPass As Button
    Friend WithEvents BtnPengguna As Button
    Friend WithEvents BtnSupplier As Button
    Friend WithEvents BtnPelanggan As Button
    Friend WithEvents BtnSatuan As Button
    Friend WithEvents BtnKategori As Button
    Friend WithEvents BtnBarang As Button
    Friend WithEvents BtnBarangMasuk As Button
    Friend WithEvents BtnBarangKeluar As Button
    Friend WithEvents BtnStockOpname As Button
    Friend WithEvents BtnLapMaster As Button
    Friend WithEvents BtnLapBrgMasuk As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnLapStockOpname As Button
End Class
