Imports Oracle.ManagedDataAccess.Client
Public Class FormPembelian
    Dim conn As New OracleConnection(oradb)
    Dim cmd As New OracleCommand
    Dim rd As OracleDataReader
    Dim da As OracleDataAdapter
    Dim cb As OracleCommandBuilder
    Dim ds As DataSet


    Sub datagrid()
        da = New OracleDataAdapter("SELECT *  FROM pembelian_detail", conn)
        ds = New DataSet
        DGPembelian.DataSource = ds.Tables("PEMBELIAN")
        DGPembelian.ReadOnly = True

        DGPembelian.Columns("kode_pembelian").HeaderText = "Kode Pembelian"
        DGPembelian.Columns("kode_barang").HeaderText = "Kode Barang"
        DGPembelian.Columns("harga_beli").HeaderText = "Harga Beli"
        DGPembelian.Columns("qty").HeaderText = "Qty"
        DGPembelian.Columns("subtotal").HeaderText = "Subtotal"

        DGPembelian.Columns("id").Width = "20"
        DGPembelian.Columns("barang_id").Width = "20"
        DGPembelian.Columns("barang_id").Width = "20"
    End Sub

    Private Sub FormPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        datagrid()
        conn.Close()
    End Sub
End Class