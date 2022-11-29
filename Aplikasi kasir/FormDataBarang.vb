Imports Oracle.ManagedDataAccess.Client
Public Class FormDataBarang
    Dim conn As New OracleConnection(oradb)
    Dim cmd As New OracleCommand
    Dim rd As OracleDataReader
    Dim da As OracleDataAdapter
    Dim cb As OracleCommandBuilder
    Dim ds As DataSet
    Private Sub FormDataBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        da = New OracleDataAdapter("SELECT * FROM barang", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "BARANG")
        DGBarang.DataSource = (ds.Tables("BARANG"))
        DGBarang.ReadOnly = True
        DGBarang.Columns(0).Width = 120
        DGBarang.Columns(1).Width = 300
        DGBarang.Columns(2).Width = 75
        conn.Close()

    End Sub

    Private Sub CariTxt_TextChanged(sender As Object, e As EventArgs) Handles CariTxt.TextChanged
        da = New OracleDataAdapter("SELECT * FROM barang WHERE LOWER(nama_barang) like LOWER('%" & CariTxt.Text & "%') ORDER BY nama_barang ASC", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "BARANG")
        DGBarang.DataSource = (ds.Tables("BARANG"))
        DGBarang.ReadOnly = True

    End Sub
End Class