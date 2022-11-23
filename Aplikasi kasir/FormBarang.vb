Imports Oracle.ManagedDataAccess.Client
Public Class FormBarang
    Dim conn As New OracleConnection(oradb)
    Dim cmd As New OracleCommand
    Dim rd As OracleDataReader
    Dim da As OracleDataAdapter
    Dim cb As OracleCommandBuilder
    Dim ds As DataSet

    Sub Bersih()
        TxtKode.Text = ""
        TxtNama.Text = ""
        CmbKategori.Text = ""
        CmbSatuan.Text = ""
        TxtStock.Text = ""

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
                Dim queryTambah As String = "INSERT INTO barang(kode_barang,nama_barang,kode_kategori,satuan_barang,stock_barang) values('" & TxtKode.Text & "','" & TxtNama.Text & "','" & CmbKategori.Text & "','" & CmbSatuan.Text & "','" & Val(TxtStock.Text) & "')"
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
            cmd = New OracleCommand("UPDATE barang SET nama_barang='" & TxtNama.Text & "',kode_kategori='" & CmbKategori.Text & "',satuan_barang='" & CmbSatuan.Text & "',stock_barang='" & Val(TxtStock.Text) & "' WHERE kode_barang='" & TxtKode.Text & "'", conn)
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
            da = New OracleDataAdapter("SELECT * FROM barang WHERE nama_barang like '%" & TxtCari.Text & "%' ORDER BY nama_barang ASC", conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "BARANG")
            DataGridView1.DataSource = (ds.Tables("BARANG"))
            DataGridView1.ReadOnly = True
        ElseIf RbKode.Checked = True Then
            da = New OracleDataAdapter("SELECT * FROM barang WHERE kode_barang like '%" & TxtCari.Text & "%' ORDER BY kode_barang ASC", conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "BARANG")
            DataGridView1.DataSource = (ds.Tables("BARANG"))
            DataGridView1.ReadOnly = True
        End If
    End Sub
End Class