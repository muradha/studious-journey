Imports System.Data.OracleClient
Module ModuleKoneksi
    Public conn As New OracleConnection
    Public oradb As String = "USER ID=C##SCOTT;PASSWORD=tiger;DATA SOURCE=localhost:1521/orcl"
    Public cmd As New OracleCommand
    Public query As String

    Sub koneksi()

        conn = New OracleConnection(oradb)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                'cmd.Connection = conn
            Else
                MessageBox.Show("Koneksi database gagal")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module