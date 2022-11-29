Imports Oracle.ManagedDataAccess.Client
Imports System.Drawing.Printing
Public Class FormBarang
    Dim conn As New OracleConnection(oradb)
    Dim cmd As New OracleCommand
    Dim rd As OracleDataReader
    Dim da As OracleDataAdapter
    Dim cb As OracleCommandBuilder
    Dim ds As DataSet
    Dim WithEvents PD As New PrintDocument
    Dim PDD As New PrintPreviewDialog
    Dim t_qty As Long
    Dim panjang As Integer

    Sub Bersih()
        TxtKode.Text = ""
        TxtNama.Text = ""
        CmbKategori.Text = ""
        CmbSatuan.Text = ""
        TxtStock.Text = ""
        TxtHrgBli.Text = ""
        TxtHrgJual.Text = ""
        TxtDsknJual.Text = ""

        TxtKode.Enabled = True
        BtnUbah.Enabled = False
        BtnHapus.Enabled = False
        BtnSimpan.Enabled = True
    End Sub
    Sub TampilGrid()
        da = New OracleDataAdapter("SELECT * FROM barang", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "BARANG")
        DataGridView1.DataSource = (ds.Tables("BARANG"))
        DataGridView1.ReadOnly = True
    End Sub

    Sub TampilKategori()
        cmd = New OracleCommand("SELECT * FROM kategori", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            CmbKategori.Items.Add(rd.Item(0))
        Loop
    End Sub

    Sub TampilSatuan()
        cmd = New OracleCommand("SELECT * FROM satuan", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            CmbSatuan.Items.Add(rd.Item(0))
        Loop
    End Sub

    Private Sub FormBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        TxtKode.Focus()
        TampilGrid()
        TampilKategori()
        TampilSatuan()
        conn.Close()
    End Sub

    Private Sub TxtKode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKode.KeyPress
        conn.Open()
        If e.KeyChar = Chr(13) Then
            cmd = New OracleCommand("SELECT * FROM barang WHERE kode_barang='" & TxtKode.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                MsgBox("Data Ditemukan", vbInformation + vbOKOnly, "Pesan")
                TxtKode.Text = rd.Item("KODE_BARANG")
                TxtNama.Text = rd.Item("NAMA_BARANG")
                CmbKategori.Text = rd.Item("KODE_KATEGORI")
                CmbSatuan.Text = rd.Item("SATUAN_BARANG")
                TxtStock.Text = rd.Item("STOCK_BARANG")
                TxtHrgBli.Text = rd.Item("HARGA_BELI")
                TxtHrgJual.Text = rd.Item("HARGA_JUAL")
                TxtDsknJual.Text = rd.Item("DISKON_JUAL")

                TxtKode.Enabled = False
                BtnSimpan.Enabled = False
                BtnHapus.Enabled = True
                BtnUbah.Enabled = True
                BtnBatal.Focus()
            Else
                TxtNama.Focus()
            End If
        End If
        conn.Close()
    End Sub

    Private Sub TxtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNama.KeyPress
        If e.KeyChar = Chr(13) Then
            CmbKategori.Focus()
        End If
    End Sub

    Private Sub CmbKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbKategori.SelectedIndexChanged
        CmbSatuan.Focus()
    End Sub

    Private Sub CmbSatuan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSatuan.SelectedIndexChanged
        TxtStock.Focus()
    End Sub


    Private Sub TxtStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtStock.KeyPress
        If e.KeyChar = Chr(13) Then
            BtnSimpan.Focus()
        Else
            BtnUbah.Focus()
        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub BtnKategori_Click(sender As Object, e As EventArgs) Handles BtnKategori.Click
        FormKategori.Show()
    End Sub

    Private Sub BtnSatuan_Click(sender As Object, e As EventArgs) Handles BtnSatuan.Click
        FormSatuan.Show()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        conn.Open()

        If TxtKode.Text = "" Or TxtNama.Text = "" Then
            MsgBox("Kode / Nama Barang masih ada yang kosong")
            Exit Sub
        Else
            cmd = New OracleCommand("SELECT * FROM barang WHERE kode_barang='" & TxtKode.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()

            If Not rd.HasRows Then
                Dim queryTambah As String = "INSERT INTO barang(kode_barang,nama_barang,kode_kategori,satuan_barang,stock_barang,harga_beli,harga_jual,diskon_jual) values('" & TxtKode.Text & "','" & TxtNama.Text & "','" & CmbKategori.Text & "','" & CmbSatuan.Text & "','" & Val(TxtStock.Text) & "','" & Val(TxtHrgBli.Text) & "','" & Val(TxtHrgJual.Text) & "','" & Val(TxtDsknJual.Text) & "')"
                cmd = New OracleCommand(queryTambah, conn)
                cmd.ExecuteNonQuery()
                Bersih()
                TampilGrid()
                TxtKode.Focus()
            Else
                MsgBox("Kode barang telah ada sebelumnya", vbInformation + vbOKOnly, "Pesan")
                TampilGrid()
            End If
        End If
        conn.Close()
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Bersih()
        TampilGrid()
        TxtKode.Focus()
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        conn.Open()

        If TxtKode.Text = "" Then
            MsgBox("Kode masih kosong")
            BtnBatal.Focus()
            Exit Sub
        Else
            cmd = New OracleCommand("UPDATE barang SET nama_barang='" & TxtNama.Text & "',kode_kategori='" & CmbKategori.Text & "',satuan_barang='" & CmbSatuan.Text & "',stock_barang='" & Val(TxtStock.Text) & "',harga_beli='" & Val(TxtHrgBli.Text) & "',harga_jual='" & Val(TxtHrgJual.Text) & "',diskon_jual='" & Val(TxtDsknJual.Text) & "' WHERE kode_barang='" & TxtKode.Text & "'", conn)
            cmd.ExecuteNonQuery()
            Bersih()
            TampilGrid()
            TxtKode.Focus()
        End If
        conn.Close()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        conn.Open()
        If TxtKode.Text = "" Then
            MsgBox("Kode masih kosong")
            TxtNama.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin akan dihapus...?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                cmd = New OracleCommand("DELETE FROM barang WHERE kode_barang='" & TxtKode.Text & "'", conn)
                cmd.ExecuteNonQuery()
                Bersih()
                TampilGrid()
                TxtKode.Focus()
            Else
                Bersih()
                TampilGrid()
                TxtKode.Focus()

            End If
        End If
        conn.Close()
    End Sub

    Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged
        If RbNama.Checked = True Then
            da = New OracleDataAdapter("SELECT * FROM barang WHERE LOWER(nama_barang) like LOWER('%" & TxtCari.Text & "%') ORDER BY nama_barang ASC", conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "BARANG")
            DataGridView1.DataSource = (ds.Tables("BARANG"))
            DataGridView1.ReadOnly = True
        ElseIf RbKode.Checked = True Then
            da = New OracleDataAdapter("SELECT * FROM barang WHERE LOWER(kode_barang) like LOWER('%" & TxtCari.Text & "%') ORDER BY kode_barang ASC", conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "BARANG")
            DataGridView1.DataSource = (ds.Tables("BARANG"))
            DataGridView1.ReadOnly = True
        End If
    End Sub

    Private Sub TxtStock_TextChanged(sender As Object, e As EventArgs) Handles TxtStock.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ubahpanjang()
        PDD.Document = PD
        PDD.ShowDialog()
        'PD.Print()
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 500, panjang)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f10 As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim f10b As New Font("Times New Roman", 10, FontStyle.Bold)
        Dim f14 As New Font("Times New Roman", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width
        Dim t_harga As Long


        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim garis As String
        garis = "------------------------------------------------------------------------------------"

        e.Graphics.DrawString("Nama Toko", f14, Brushes.Black, centermargin, 5, tengah)
        e.Graphics.DrawString("Jl. Jendral Sudirman No.123", f10, Brushes.Black, centermargin, 25, tengah)
        e.Graphics.DrawString("HP: 0000-1234-5678", f10, Brushes.Black, centermargin, 40, tengah)

        e.Graphics.DrawString("No Faktur", f10, Brushes.Black, 0, 60)
        e.Graphics.DrawString(":", f10, Brushes.Black, 65, 60)
        e.Graphics.DrawString("12345", f10, Brushes.Black, 75, 60)

        e.Graphics.DrawString("Kasir", f10, Brushes.Black, 0, 75)
        e.Graphics.DrawString(":", f10, Brushes.Black, 65, 75)
        e.Graphics.DrawString("Anisa", f10, Brushes.Black, 75, 75)

        e.Graphics.DrawString("05/02/2021 00:00", f10, Brushes.Black, 0, 90)

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 100)
        DataGridView1.AllowUserToAddRows = False

        Dim tinggi As Integer
        Dim i As Long
        For baris As Integer = 0 To DataGridView1.RowCount - 1
            tinggi += 15
            e.Graphics.DrawString(DataGridView1.Rows(baris).Cells(0).Value.ToString, f10, Brushes.Black, 0, 100 + tinggi)
            e.Graphics.DrawString(DataGridView1.Rows(baris).Cells(1).Value.ToString, f10, Brushes.Black, 100, 100 + tinggi)
            e.Graphics.DrawString(DataGridView1.Rows(baris).Cells(4).Value.ToString, f10, Brushes.Black, 350, 100 + tinggi)


            i = DataGridView1.Rows(baris).Cells(2).Value

            DataGridView1.Rows(baris).Cells(2).Value = Format(i, "##,##0")
            e.Graphics.DrawString(DataGridView1.Rows(baris).Cells(2).Value.ToString, f10, Brushes.Black, rightmargin - 30, 100 + tinggi, kanan)
            e.Graphics.DrawString(DataGridView1.Rows(baris).Cells(3).Value.ToString, f10, Brushes.Black, rightmargin, 100 + tinggi, kanan)
        Next

        tinggi = 110 + tinggi
        hitungtotal()
        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, tinggi)
        e.Graphics.DrawString("Total : " & Format(t_qty, "##,##0"), f10b, Brushes.Black, rightmargin, 10 + tinggi, kanan)
        e.Graphics.DrawString(t_qty, f10b, Brushes.Black, 0, 10 + tinggi)

    End Sub
    Sub hitungtotal()
        Dim hitung As Long = 0
        For baris As Long = 0 To DataGridView1.RowCount - 1
            hitung = hitung + DataGridView1.Rows(baris).Cells(2).Value
        Next

        t_qty = hitung
    End Sub

    Sub ubahpanjang()
        Dim rowcount As Integer
        panjang = 0
        rowcount = DataGridView1.Rows.Count
        panjang = rowcount * 15
        panjang = panjang + 200
    End Sub
End Class