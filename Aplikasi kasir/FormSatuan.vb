Imports Oracle.ManagedDataAccess.Client
Public Class FormSatuan
    Dim conn As New OracleConnection(oradb)
    Dim cmd As New OracleCommand
    Dim rd As OracleDataReader
    Dim da As OracleDataAdapter
    Dim cb As OracleCommandBuilder
    Dim ds As DataSet
    Sub TampilGrid()
        da = New OracleDataAdapter("SELECT * FROM satuan", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "SATUAN")
        DataGridView1.DataSource = (ds.Tables("SATUAN"))
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub FormSatuan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TxtNama.Focus()
    End Sub

    Private Sub FormSatuan_Load(sender As Object, e As EventArgs) Handles Me.Load
        conn.Open()
        TampilGrid()
        BtnHapus.Enabled = False
        conn.Close()
    End Sub

    Private Sub TxtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNama.KeyPress
        conn.Open()
        If e.KeyChar = Chr(13) Then
            cmd = New OracleCommand("SELECT * FROM satuan WHERE nama_satuan='" & TxtNama.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                MsgBox("Data telah ada sebelumnya", vbInformation + vbOKOnly, "Pesan")
                TxtNama.Text = rd.Item("NAMA_SATUAN")

                TxtNama.Enabled = False
                BtnSimpan.Enabled = False
                BtnHapus.Enabled = True
                BtnBatal.Focus()
            Else
                BtnHapus.Enabled = False
                TxtNama.Focus()
            End If
        End If
        conn.Close()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        conn.Open()

        If TxtNama.Text = "" Then
            MsgBox("Nama masih kosong")
            Exit Sub
        Else

            cmd = New OracleCommand("SELECT * FROM satuan WHERE nama_satuan='" & TxtNama.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()

            If Not rd.HasRows Then
                Dim queryTambah As String = "INSERT INTO satuan(nama_satuan) values('" & TxtNama.Text & "')"
                cmd = New OracleCommand(queryTambah, conn)
                cmd.ExecuteNonQuery()
                TxtNama.Enabled = True
                BtnSimpan.Enabled = True
                BtnHapus.Enabled = False
                TxtNama.Text = ""
                TxtNama.Focus()
                TampilGrid()

            Else
                MsgBox("Data telah ada sebelumnya", vbInformation + vbOKOnly, "Pesan")
                TampilGrid()
            End If
            conn.Close()
        End If
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        TxtNama.Enabled = True
        BtnSimpan.Enabled = True
        BtnHapus.Enabled = False
        TxtNama.Text = ""
        TxtNama.Focus()
        TampilGrid()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        conn.Open()

        If TxtNama.Text = "" Then
            MsgBox("Nama masih kosong")
            TxtNama.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin akan dihapus...?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OracleCommand("DELETE FROM satuan WHERE nama_satuan='" & TxtNama.Text & "'", conn)
                cmd.ExecuteNonQuery()
                TxtNama.Enabled = True
                BtnSimpan.Enabled = True
                BtnHapus.Enabled = False
                TxtNama.Focus()
                TampilGrid()
            Else
                TxtNama.Enabled = True
                BtnSimpan.Enabled = True
                BtnHapus.Enabled = False
                TxtNama.Text = ""
                TxtNama.Focus()
                TampilGrid()
            End If
        End If
        conn.Close()
    End Sub
End Class