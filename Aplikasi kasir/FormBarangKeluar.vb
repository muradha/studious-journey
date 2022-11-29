Imports Oracle.ManagedDataAccess.Client
Public Class FormBarangKeluar
    Dim conn As New OracleConnection(oradb)
    Dim cmd As New OracleCommand
    Dim rd As OracleDataReader
    Dim da As OracleDataAdapter
    Dim cb As OracleCommandBuilder
    Dim ds As DataSet

    Sub BersihkanText()
        TxtFaktur.Text = ""
        Item.Text = ""
        TxtKode.Text = ""
        TxtNama.Text = ""
        TxtTelp.Text = ""
        TxtStatus.Text = ""
    End Sub

    Sub BuatKolomBaru()
        DGV.Columns.Add("KODE_BARANG", "Kode Barang / Scan Barcode")
        DGV.Columns.Add("NAMA_BARANG", "Nama Barang")
        DGV.Columns.Add("STOCK_BARANG", "Jumlah")
        DGV.Columns.Add("SATUAN_BARANG", "Satuan")
        DGV.Columns.Add("KODE_KATEGORI", "Kategori")
        DGV.Columns.Add("HARGA_BELI", "Harga Beli")
        DGV.Columns.Add("HARGA_JUAL", "Harga Jual")
        DGV.Columns.Add("SUBTOTAL", "Subtotal")
        AturLebarKolom()
    End Sub

    Sub AturLebarKolom()
        DGV.Columns(0).Width = 250
        DGV.Columns(1).Width = 300
        DGV.Columns(2).Width = 150
        DGV.Columns(3).Width = 150
        DGV.Columns(4).Width = 100


        'kunci kolom grid
        DGV.Columns(1).ReadOnly = True
        'DGV.Columns(2).ReadOnly = True
        DGV.Columns(3).ReadOnly = True
        DGV.Columns(4).ReadOnly = True
    End Sub

    Sub TotalItem()
        Dim HitungItem As Integer = 0
        For I As Integer = 0 To DGV.Rows.Count - 1
            HitungItem += Val(DGV.Rows(I).Cells(2).Value)
            Item.Text = HitungItem
        Next
    End Sub

    Private Sub BtnPelanggan_Click(sender As Object, e As EventArgs) Handles BtnPelanggan.Click
        DGV.Focus()
        DGV.CurrentCell = DGV.Rows(0).Cells(0)
        FormDataPelanggan.ShowDialog()
    End Sub

    Private Sub FormBarangKeluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        BuatKolomBaru()
        BersihkanText()
        TxtUser.Text = "Nama User"
        conn.Close()
    End Sub
    Private Sub TxtFaktur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFaktur.KeyPress
        conn.Open()
        If e.KeyChar = Chr(13) Then
            cmd = New OracleCommand("SELECT * FROM barang_keluar WHERE faktur='" & TxtFaktur.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                BtnPelanggan.Focus()
            Else
                MsgBox("Nomor faktur telah ada sebelumnya, harap ganti nomor faktur", vbInformation + vbOKOnly, "Pesan")
                TxtFaktur.Focus()
            End If
        End If
        conn.Close()
    End Sub

    Private Sub DGV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DGV.KeyPress
        On Error Resume Next
        If e.KeyChar = Chr(13) Then 'Tombol Enter
            TotalItem()
            DGV.CurrentCell = DGV.Rows(0).Cells(0)
        ElseIf e.KeyChar = Chr(27) Then 'tombol esc
            BersihkanText()
            DGV.Columns.Clear()
            BuatKolomBaru()
            DGV.Focus()
            DGV.CurrentCell = DGV.Rows(0).Cells(0)
        End If
    End Sub
    Private Sub GridViewTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If DGV.CurrentCell.ColumnIndex = 4 Then
            If ((Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) And Asc(e.KeyChar) <> 8) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub DGV_EditingControlShowing(sender As Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DGV.EditingControlShowing
        If e.Control.GetType.ToString() = "System.Windows.Forms.DataGridViewTextBoxEditingControl" Then
            Dim c As DataGridViewTextBoxEditingControl = CType(e.Control, DataGridViewTextBoxEditingControl)
            RemoveHandler c.KeyPress, AddressOf GridViewTextBox_KeyPress
            AddHandler c.KeyPress, AddressOf GridViewTextBox_KeyPress
        End If
    End Sub

    Private Sub DGV_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellEndEdit
        conn.Open()

        If e.ColumnIndex = 0 Then
            'Cari kode barang berdasarkan Grid kolompertama
            cmd = New OracleCommand("SELECT * FROM barang WHERE kode_barang='" & DGV.Rows(e.RowIndex).Cells(0).Value & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                DGV.CurrentCell = DGV.Rows(e.RowIndex).Cells(7)
                DGV.Rows(e.RowIndex).Cells(1).Value = rd.Item(1)
                DGV.Rows(e.RowIndex).Cells(2).Value = rd.Item(2)
                DGV.Rows(e.RowIndex).Cells(3).Value = rd.Item(3)
                DGV.Rows(e.RowIndex).Cells(4).Value = rd.Item(4)
                DGV.Rows(e.RowIndex).Cells(5).Value = rd.Item(5)
                DGV.Rows(e.RowIndex).Cells(6).Value = rd.Item(6)
                DGV.Rows(e.RowIndex).Cells(7).Value = DGV.Rows(e.RowIndex).Cells(2).Value * DGV.Rows(e.RowIndex).Cells(5).Value
                DGV.Rows(e.RowIndex).Cells(2).Value = 1
                TotalItem()
                DGV.CurrentCell = DGV(2, 0)
            Else
                MsgBox("Kode barang tidak terdaftar")
                DGV.Rows(e.RowIndex).Cells(0).Value = ""
                DGV.Rows(e.RowIndex).Cells(1).Value = ""
                DGV.Rows(e.RowIndex).Cells(2).Value = ""
                DGV.Rows(e.RowIndex).Cells(3).Value = ""
                DGV.Rows(e.RowIndex).Cells(4).Value = ""
                DGV.Rows(e.RowIndex).Cells(5).Value = ""
                DGV.Rows(e.RowIndex).Cells(6).Value = ""
                DGV.Rows(e.RowIndex).Cells(7).Value = ""
            End If
        End If
        If e.ColumnIndex = 7 Then
            TotalItem()
            DGV.CurrentCell = DGV.Rows(e.RowIndex).Cells(0)
        End If
        conn.Close()
    End Sub

    Private Sub DGV_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles DGV.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                BtnSimpan.Focus()
            Case Keys.F2
                FormDataBarang.Text = "Data Barang - Barang Masuk"
                FormDataBarang.ShowDialog()
        End Select
    End Sub

    Private Sub BtnBarang_Click(sender As Object, e As EventArgs) Handles BtnBarang.Click
        FormDataBarang.Text = "Data Barang - Barang Masuk"
        FormDataBarang.ShowDialog()
    End Sub


    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        BersihkanText()
        DGV.Columns.Clear()
        BuatKolomBaru()
        DGV.Focus()
    End Sub
    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        conn.Open()

        If TxtKode.Text = "" Or TxtFaktur.Text = "" Or Item.Text = "" Then
            MsgBox("Data belum lengkap, tidak ada transaksi atau supplier / No Faktur masih kosong")
            Exit Sub
        Else
            cmd = New OracleCommand("SELECT * FROM barang_keluar WHERE faktur='" & TxtFaktur.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()

            If Not rd.HasRows Then
                Dim simpanmaster As String = "INSERT INTO barang_keluar(faktur,tanggal,kode_petugas,kode_pelanggan) values('" & TxtFaktur.Text & "','" & Now().ToString("dd-MMM-yy") & "','" & "Kasir" & "','" & TxtKode.Text & "')"
                cmd = New OracleCommand(simpanmaster, conn)
                cmd.ExecuteNonQuery()
                For baris As Integer = 0 To DGV.Rows.Count - 2
                    Dim sqlsimpan As String = "INSERT INTO barang_keluar_detail(faktur, kode_barang,nama_barang,jumlah) values('" & TxtFaktur.Text & "','" & DGV.Rows(baris).Cells(0).Value & "','" & DGV.Rows(baris).Cells(1).Value & "','" & DGV.Rows(baris).Cells(2).Value & "')"
                    cmd = New OracleCommand(sqlsimpan, conn)
                    cmd.ExecuteNonQuery()

                    'Tambah stok barang
                    cmd = New OracleCommand("SELECT * FROM barang WHERE kode_barang='" & DGV.Rows(baris).Cells(0).Value & "'", conn)
                    rd = cmd.ExecuteReader
                    rd.Read()
                    If rd.HasRows Then
                        Dim tambahstok As String = "UPDATE barang SET stock_barang='" & rd.Item(2) + DGV.Rows(baris).Cells(2).Value & "' WHERE kode_barang='" & DGV.Rows(baris).Cells(0).Value & "'"
                        cmd = New OracleCommand(tambahstok, conn)
                        cmd.ExecuteNonQuery()
                    End If
                Next baris

                'Tapil bukti faktur Barang_Masuk
                'FormLapBarangMasuk.CrystalReportViewer1.SelectionFormula = "{Barang_Masuk.Faktur}='" & TxtFaktur.Text & "'"
                'FormLapBarangMasuk.CrystalReportViewer1.RefreshReport()
                'FormLapBarangMasuk.ShowDialog()
                DGV.Columns.Clear()
                BuatKolomBaru()
                BersihkanText()
                TxtFaktur.Focus()
            Else
                MsgBox("Nomor Faktur telah ada sebelumnya, harap ganti nomor Faktur", vbInformation + vbOKOnly, "Pesan")
                TxtFaktur.Focus()
            End If
        End If
        conn.Close()
    End Sub

    Private Sub DGV_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellValueChanged
        TotalItem()
        DGV.Rows(e.RowIndex).Cells(7).Value = DGV.Rows(e.RowIndex).Cells(2).Value * DGV.Rows(e.RowIndex).Cells(5).Value
    End Sub

    Private Sub BayarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        TampilanBayar.Show()
    End Sub
End Class
