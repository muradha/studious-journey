<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSupplier
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
        Me.TxtCari = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.TxtKode = New System.Windows.Forms.TextBox()
        Me.TxtAlamat = New System.Windows.Forms.TextBox()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.TransaksiPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinumanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OwnerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KasirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.kode = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FrmSupplier = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtNo = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtCari
        '
        Me.TxtCari.Location = New System.Drawing.Point(142, 231)
        Me.TxtCari.Name = "TxtCari"
        Me.TxtCari.Size = New System.Drawing.Size(253, 20)
        Me.TxtCari.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Cari nama Supplier"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(213, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "*[Enter] untuk melanjutkan"
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(86, 74)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(119, 20)
        Me.TxtNama.TabIndex = 22
        '
        'TxtKode
        '
        Me.TxtKode.Location = New System.Drawing.Point(88, 34)
        Me.TxtKode.Name = "TxtKode"
        Me.TxtKode.Size = New System.Drawing.Size(119, 20)
        Me.TxtKode.TabIndex = 21
        '
        'TxtAlamat
        '
        Me.TxtAlamat.Location = New System.Drawing.Point(86, 114)
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.Size = New System.Drawing.Size(119, 20)
        Me.TxtAlamat.TabIndex = 20
        '
        'BtnBatal
        '
        Me.BtnBatal.Location = New System.Drawing.Point(320, 194)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(75, 23)
        Me.BtnBatal.TabIndex = 18
        Me.BtnBatal.Text = "BATAL"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(228, 194)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 23)
        Me.BtnHapus.TabIndex = 17
        Me.BtnHapus.Text = "HAPUS"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(44, 194)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.BtnSimpan.TabIndex = 15
        Me.BtnSimpan.Text = "SIMPAN"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'TransaksiPembelianToolStripMenuItem
        '
        Me.TransaksiPembelianToolStripMenuItem.Name = "TransaksiPembelianToolStripMenuItem"
        Me.TransaksiPembelianToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.TransaksiPembelianToolStripMenuItem.Text = "Transaksi Pembelian"
        '
        'TransaksiPenjualanToolStripMenuItem
        '
        Me.TransaksiPenjualanToolStripMenuItem.Name = "TransaksiPenjualanToolStripMenuItem"
        Me.TransaksiPenjualanToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.TransaksiPenjualanToolStripMenuItem.Text = "Transaksi Penjualan"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransaksiPenjualanToolStripMenuItem, Me.TransaksiPembelianToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'MinumanToolStripMenuItem
        '
        Me.MinumanToolStripMenuItem.Name = "MinumanToolStripMenuItem"
        Me.MinumanToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.MinumanToolStripMenuItem.Text = "Minuman"
        '
        'OwnerToolStripMenuItem
        '
        Me.OwnerToolStripMenuItem.Name = "OwnerToolStripMenuItem"
        Me.OwnerToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.OwnerToolStripMenuItem.Text = "Owner"
        '
        'KasirToolStripMenuItem
        '
        Me.KasirToolStripMenuItem.Name = "KasirToolStripMenuItem"
        Me.KasirToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.KasirToolStripMenuItem.Text = "Kasir"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KasirToolStripMenuItem, Me.OwnerToolStripMenuItem, Me.MinumanToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(85, 20)
        Me.ToolStripMenuItem1.Text = "Data Master"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(54, 20)
        Me.ToolStripMenuItem2.Text = "Profile"
        '
        'BtnUbah
        '
        Me.BtnUbah.Location = New System.Drawing.Point(136, 194)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(75, 23)
        Me.BtnUbah.TabIndex = 16
        Me.BtnUbah.Text = "UBAH"
        Me.BtnUbah.UseVisualStyleBackColor = True
        '
        'kode
        '
        Me.kode.AutoSize = True
        Me.kode.Location = New System.Drawing.Point(39, 158)
        Me.kode.Name = "kode"
        Me.kode.Size = New System.Drawing.Size(41, 13)
        Me.kode.TabIndex = 0
        Me.kode.Text = "No telp"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(28, 257)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(461, 189)
        Me.DataGridView1.TabIndex = 11
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem1, Me.TransaksiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(510, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FrmSupplier
        '
        Me.FrmSupplier.AutoSize = True
        Me.FrmSupplier.Location = New System.Drawing.Point(12, 36)
        Me.FrmSupplier.Name = "FrmSupplier"
        Me.FrmSupplier.Size = New System.Drawing.Size(73, 13)
        Me.FrmSupplier.TabIndex = 1
        Me.FrmSupplier.Text = "Kode Supplier"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nama"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TxtNo)
        Me.Panel1.Controls.Add(Me.TxtCari)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TxtNama)
        Me.Panel1.Controls.Add(Me.TxtKode)
        Me.Panel1.Controls.Add(Me.TxtAlamat)
        Me.Panel1.Controls.Add(Me.BtnBatal)
        Me.Panel1.Controls.Add(Me.BtnHapus)
        Me.Panel1.Controls.Add(Me.BtnUbah)
        Me.Panel1.Controls.Add(Me.BtnSimpan)
        Me.Panel1.Controls.Add(Me.kode)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Controls.Add(Me.FrmSupplier)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(34, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(510, 489)
        Me.Panel1.TabIndex = 15
        '
        'TxtNo
        '
        Me.TxtNo.Location = New System.Drawing.Point(86, 154)
        Me.TxtNo.Name = "TxtNo"
        Me.TxtNo.Size = New System.Drawing.Size(119, 20)
        Me.TxtNo.TabIndex = 27
        '
        'FormSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 567)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supplier"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TxtCari As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtKode As TextBox
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents BtnBatal As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents TransaksiPembelianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiPenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinumanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OwnerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KasirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents BtnUbah As Button
    Friend WithEvents kode As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FrmSupplier As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtNo As TextBox
End Class
