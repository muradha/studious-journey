Imports Oracle.ManagedDataAccess.Client
Public Class TampilanBayar
    Dim conn As New OracleConnection(oradb)
    Dim cmd As New OracleCommand
    Dim rd As OracleDataReader
    Dim da As OracleDataAdapter
    Dim cb As OracleCommandBuilder
    Dim ds As DataSet
    Dim total As String
    Private Sub TampilanBayar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        cmd = New OracleCommand("SELECT * FROM barang WHERE kode_barang='" & FormBarangMasuk.TxtFaktur.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Label7.Text = rd.Item(7)
        End If
        conn.Close()
    End Sub
End Class