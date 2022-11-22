Imports Oracle.ManagedDataAccess.Client
Public Class Form1
    Dim conn As New OracleConnection(oradb)
    Dim cmd As New OracleCommand
    Dim cek As OracleDataReader
    Dim da As OracleDataAdapter
    Dim cb As OracleCommandBuilder
    Dim ds As DataSet
    Dim query As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginToolStripMenuItem.Visible = False
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Hide()
        logout()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        keluar()
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        kondisiawal()
    End Sub

    Sub kondisiawal()
        inputNama.Text = ""
        inputPassword.Text = ""
        inputKode.Text = ""

        levelInput.Items.Clear()
        levelInput.Items.Add("owner")
        levelInput.Items.Add("kasir")



        query = "select id as kode,nama,tingkat from admin"
        cmd = New OracleCommand(query, conn)
        cmd.CommandType = CommandType.Text
        da = New OracleDataAdapter(cmd)
        cb = New OracleCommandBuilder(da)
        ds = New DataSet()

        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)

        DataGridView1.Refresh()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If inputKode.Text = "" & inputNama.Text = "" & inputPassword.Text = "" & levelInput.SelectedItem = "" Then
            MsgBox("Silahkan isi data terlebih dahulu")
        Else
            cmd.CommandText = "INSERT INTO admin values ('" & inputKode.Text & "','" & inputNama.Text & "','" & inputPassword.Text & "', '" & levelInput.SelectedItem & "')"
            cmd.Connection = conn
            conn.Open()
            Try
                Dim aff As Integer = cmd.ExecuteNonQuery()
                MessageBox.Show(aff & " rows were affected.")
            Catch
                MessageBox.Show("Error encountered during INSERT operation.")
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Dispose()
    End Sub


    Private Sub inputKode_KeyPress(sender As Object, e As KeyPressEventArgs, KeyAscii As Integer) Handles inputKode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            conn.Open()

        End If
    End Sub
End Class