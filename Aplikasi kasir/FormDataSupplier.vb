Imports Oracle.ManagedDataAccess.Client
Public Class FormDataSupplier
    Dim conn As New OracleConnection(oradb)
    Dim cmd As New OracleCommand
    Dim rd As OracleDataReader
    Dim da As OracleDataAdapter
    Dim cb As OracleCommandBuilder
    Dim ds As DataSet
    Private Sub FormDataSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        da = New OracleDataAdapter("SELECT * FROM supplier", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "supplier")
        DGVSupplier.DataSource = (ds.Tables("SUPPLIER"))
        DGVSupplier.ReadOnly = True
        conn.Close()
    End Sub

    Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged
        da = New OracleDataAdapter("SELECT * FROM supplier WHERE LOWER(nama_supplier) like LOWER('%" & TxtCari.Text & "%') ORDER BY nama_supplier ASC", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "SUPPLIER")
        DGVSupplier.DataSource = (ds.Tables("SUPPLIER"))
        DGVSupplier.ReadOnly = True
    End Sub

    Private Sub TxtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCari.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
            FormBarangMasuk.DGV.Focus()
            FormBarangMasuk.DGV.CurrentCell = FormBarangMasuk.DGV.Rows(0).Cells(0)
        End If
    End Sub

    Private Sub DGVSupplier_DoubleClick(sender As Object, e As EventArgs) Handles DGVSupplier.DoubleClick
        Try
            With DGVSupplier
                FormBarangMasuk.TxtKode.Text = .SelectedCells(0).Value
                FormBarangMasuk.TxtNama.Text = .SelectedCells(1).Value
                FormBarangMasuk.TxtAlamat.Text = .SelectedCells(2).Value
            End With
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub DGVSupplier_KeyDown(sender As Object, e As KeyEventArgs) Handles DGVSupplier.KeyDown
        'Tutup form saat tombol esc ditahan
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
End Class