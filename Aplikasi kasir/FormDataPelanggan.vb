Imports Oracle.ManagedDataAccess.Client
Public Class FormDataPelanggan
    Dim conn As New OracleConnection(oradb)
    Dim cmd As New OracleCommand
    Dim rd As OracleDataReader
    Dim da As OracleDataAdapter
    Dim cb As OracleCommandBuilder
    Dim ds As DataSet

    Private Sub FormDataPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        da = New OracleDataAdapter("SELECT * FROM pelanggan", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "PELANGGAN")
        DGVPelanggan.DataSource = (ds.Tables("PELANGGAN"))
        DGVPelanggan.ReadOnly = True
        conn.Close()
    End Sub

    Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged
        da = New OracleDataAdapter("SELECT * FROM pelanggan WHERE LOWER(nama_pelanggan) like LOWER('%" & TxtCari.Text & "%') ORDER BY nama_pelanggan ASC", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "PELANGGAN")
        DGVPelanggan.DataSource = (ds.Tables("PELANGGAN"))
        DGVPelanggan.ReadOnly = True
    End Sub

    Private Sub TxtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCari.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
            FormBarangKeluar.DGV.Focus()
            FormBarangKeluar.DGV.CurrentCell = FormBarangKeluar.DGV.Rows(0).Cells(0)
        End If
    End Sub

    Private Sub DGVPelanggan_DoubleClick(sender As Object, e As EventArgs) Handles DGVPelanggan.DoubleClick
        Try
            With DGVPelanggan
                FormBarangKeluar.TxtKode.Text = .SelectedCells(0).Value
                FormBarangKeluar.TxtNama.Text = .SelectedCells(1).Value
                FormBarangKeluar.TxtTelp.Text = .SelectedCells(3).Value
                FormBarangKeluar.TxtStatus.Text = .SelectedCells(4).Value
            End With
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub DGVPelanggan_KeyDown(sender As Object, e As KeyEventArgs) Handles DGVPelanggan.KeyDown
        'Tutup form saat tombol esc ditahan
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
End Class