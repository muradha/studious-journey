Imports Oracle.ManagedDataAccess.Client
Public Class FormKategori
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
        TxtNo.Text = ""

        BtnUbah.Enabled = False
        BtnHapus.Enabled = False
        BtnSimpan.Enabled = True
    End Sub

    Sub TampilGrid()
        da = New OracleDataAdapter("SELECT * FROM kategori", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "KATEGORI")
        DataGridView1.DataSource = (ds.Tables("KATEGORI"))
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub FormKategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        TampilGrid()
        Bersih()
        conn.Close()
    End Sub

    Private Sub TxtKode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKode.KeyPress
        conn.Open()
        If e.KeyChar = Chr(13) Then
            cmd = New OracleCommand("SELECT * FROM kategori WHERE kode_kategori='" & TxtKode.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                MsgBox("Data Ditemukan", vbInformation + vbOKOnly, "Pesan")
                TxtKode.Text = rd.Item("KODE_KATEGORI")
                TxtNama.Text = rd.Item("NAMA_KATEGORI")
                TxtNo.Text = rd.Item("NO_RAK")

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
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        conn.Open()

        If TxtKode.Text = "" Or TxtNama.Text = "" Or TxtNo.Text = "" Then
            MsgBox("Data masih ada yang kosong")
            Exit Sub
        Else
            cmd = New OracleCommand("SELECT * FROM kategori WHERE kode_kategori='" & TxtKode.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()

            If Not rd.HasRows Then
                Dim queryTambah As String = "INSERT INTO kategori values('" & TxtKode.Text & "','" & TxtNama.Text & "','" & TxtNo.Text & "')"
                cmd = New OracleCommand(queryTambah, conn)
                cmd.ExecuteNonQuery()
                Bersih()
                TampilGrid()
                TxtKode.Focus()
            Else
                MsgBox("Data telah ada sebelumnya", vbInformation + vbOKOnly, "Pesan")
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
            cmd = New OracleCommand("UPDATE kategori SET nama_kategori='" & TxtNama.Text & "',no_rak='" & TxtNo.Text & "' WHERE kode_kategori='" & TxtKode.Text & "'", conn)
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
                cmd = New OracleCommand("DELETE FROM kategori WHERE kode_kategori='" & TxtKode.Text & "'", conn)
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
End Class