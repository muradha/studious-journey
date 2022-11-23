Imports Oracle.ManagedDataAccess.Client
Public Class FormPelanggan
    Dim conn As New OracleConnection(oradb)
    Dim cmd As New OracleCommand
    Dim rd As OracleDataReader
    Dim da As OracleDataAdapter
    Dim cb As OracleCommandBuilder
    Dim ds As DataSet

    Sub Bersih()
        TxtKode.Enabled = True
        TxtKode.Text = ""
        TxtNama.Text = ""
        TxtAlamat.Text = ""
        TxtNo.Text = ""
        CmbStatus.Text = ""
        BtnUbah.Enabled = False
        BtnHapus.Enabled = False
        BtnSimpan.Enabled = True
    End Sub

    Sub TampilGrid()
        da = New OracleDataAdapter("SELECT * FROM pelanggan", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "PELANGGAN")
        DataGridView1.DataSource = (ds.Tables("PELANGGAN"))
        DataGridView1.ReadOnly = True
    End Sub
    Private Sub FormPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        TampilGrid()
        Bersih()
        CmbStatus.Items.Add("Umum")
        CmbStatus.Items.Add("Langganan")
        conn.Close()
    End Sub

    Private Sub TxtKode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKode.KeyPress
        conn.Open()
        If e.KeyChar = Chr(13) Then
            cmd = New OracleCommand("SELECT * FROM pelanggan WHERE kode_pelanggan='" & TxtKode.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                MsgBox("Data Ditemukan", vbInformation + vbOKOnly, "Pesan")
                TxtKode.Text = rd.Item("KODE_PELANGGAN")
                TxtNama.Text = rd.Item("NAMA_PELANGGAN")
                TxtAlamat.Text = rd.Item("ALAMAT_PELANGGAN")
                TxtNo.Text = rd.Item("NO_TELP")
                CmbStatus.Text = rd.Item("STATUS_PELANGGAN")

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
            CmbStatus.Focus()
        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub CmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbStatus.SelectedIndexChanged
        If BtnSimpan.Enabled = True Then
            BtnSimpan.Focus()
        Else
            BtnUbah.Focus()
        End If
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        conn.Open()

        If TxtKode.Text = "" Or CmbStatus.Text = "" Then
            MsgBox("Kode / status masih kosong")
            Exit Sub
        Else
            cmd = New OracleCommand("SELECT * FROM pelanggan WHERE kode_pelanggan='" & TxtKode.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()

            If Not rd.HasRows Then
                Dim queryTambah As String = "INSERT INTO pelanggan(kode_pelanggan,nama_pelanggan,alamat_pelanggan,no_telp,status_pelanggan) values('" & TxtKode.Text & "','" & TxtNama.Text & "','" & TxtAlamat.Text & "','" & TxtNo.Text & "','" & CmbStatus.Text & "')"
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
        End If
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
            cmd = New OracleCommand("UPDATE pelanggan SET nama_pelanggan='" & TxtNama.Text & "',alamat_pelanggan='" & TxtAlamat.Text & "',no_telp='" & TxtNo.Text & "',status_pelanggan='" & CmbStatus.Text & "' WHERE kode_pelanggan='" & TxtKode.Text & "'", conn)
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
                cmd = New OracleCommand("DELETE FROM pelanggan WHERE kode_pelanggan='" & TxtKode.Text & "'", conn)
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
        da = New OracleDataAdapter("SELECT * FROM pelanggan WHERE nama_pelanggan like '%" & TxtCari.Text & "%' ORDER BY nama_pelanggan ASC", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "PELANGGAN")
        DataGridView1.DataSource = (ds.Tables("PELANGGAN"))
        DataGridView1.ReadOnly = True
    End Sub
End Class