Imports Oracle.ManagedDataAccess.Client

Public Class FormSupplier
    Dim conn As New OracleConnection(oradb)
    Dim cmd As New OracleCommand
    Dim rd As OracleDataReader
    Dim da As OracleDataAdapter
    Dim cb As OracleCommandBuilder
    Dim ds As DataSet
    Dim query As String

    Sub Bersih()
        TxtKode.Enabled = True
        TxtKode.Text = ""
        TxtNama.Text = ""
        TxtAlamat.Text = ""
        TxtNo.Text = ""
        BtnUbah.Enabled = False
        BtnHapus.Enabled = False
        BtnSimpan.Enabled = True
    End Sub

    Sub TampilGrid()
        da = New OracleDataAdapter("SELECT * FROM supplier", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Supplier")
        DataGridView1.DataSource = (ds.Tables("Supplier"))
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub FormSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        TampilGrid()
        Bersih()
        conn.Close()
    End Sub
    Private Sub TxtKode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKode.KeyPress
        conn.Open()
        If e.KeyChar = Chr(13) Then
            cmd = New OracleCommand("SELECT * FROM supplier WHERE kode_supplier='" & TxtKode.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                MsgBox("Data Ditemukan", vbInformation + vbOKOnly, "Pesan")
                TxtKode.Text = rd.Item("KODE_SUPPLIER")
                TxtNama.Text = rd.Item("NAMA_SUPPLIER")
                TxtAlamat.Text = rd.Item("ALAMAT_SUPPLIER")
                TxtNo.Text = rd.Item("NO_TELP")

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
            TxtAlamat.Focus()
        End If
    End Sub

    Private Sub TxtAlamat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAlamat.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtNo.Focus()
        End If
    End Sub

    Private Sub TxtNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNo.KeyPress
        If e.KeyChar = Chr(13) Then
            If BtnSimpan.Enabled = True Then
                BtnSimpan.Focus()
            Else
                BtnUbah.Focus()
            End If
        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        conn.Open()

        If TxtKode.Text = "" Or TxtNama.Text = "" Then
            MsgBox("Kode / Nama masih kosong")
            Exit Sub
        End If

        cmd = New OracleCommand("SELECT * FROM supplier WHERE kode_supplier='" & TxtKode.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()

        If Not rd.HasRows Then
            Dim queryTambah As String = "INSERT INTO supplier(kode_supplier,nama_supplier,alamat_supplier,no_telp) values('" & TxtKode.Text & "','" & TxtNama.Text & "','" & TxtAlamat.Text & "','" & TxtNo.Text & "')"
            cmd = New OracleCommand(queryTambah, conn)
            cmd.ExecuteNonQuery()
            Bersih()
            TampilGrid()
            TxtKode.Focus()
        Else
            MsgBox("Data telah ada sebelumnya", vbInformation + vbOKOnly, "Pesan")
            TampilGrid()
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
            cmd = New OracleCommand("UPDATE supplier SET nama_supplier='" & TxtNama.Text & "',alamat_supplier='" & TxtAlamat.Text & "',no_telp='" & TxtNo.Text & "' WHERE kode_supplier='" & TxtKode.Text & "'", conn)
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
                cmd = New OracleCommand("DELETE FROM supplier WHERE kode_supplier='" & TxtKode.Text & "'", conn)
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
        da = New OracleDataAdapter("SELECT * FROM supplier WHERE nama_supplier like '%" & TxtCari.Text & "%' ORDER BY nama_supplier ASC", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "SUPPLIER")
        DataGridView1.DataSource = (ds.Tables("SUPPLIER"))
        DataGridView1.ReadOnly = True
    End Sub

End Class