Imports Oracle.ManagedDataAccess.Client
Public Class Form1
    Dim conn As New OracleConnection(oradb)
    Dim cmd As New OracleCommand
    Dim cek As OracleDataReader
    Dim da As OracleDataAdapter
    Dim cb As OracleCommandBuilder
    Dim ds As DataSet
    Dim query As String

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
        logout()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        keluar()
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        kondisiawal()
    End Sub

    Sub kondisiawal()
        inputKode.Focus()
        inputNama.Text = ""
        inputPassword.Text = ""
        inputKode.Text = ""

        levelInput.Items.Clear()
        levelInput.Items.Add("owner")
        levelInput.Items.Add("kasir")

        query = "select kode_petugas as kode,nama_petugas,status_petugas from petugas"
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
        If inputKode.Text = "" Or inputNama.Text = "" Or inputPassword.Text = "" Or levelInput.Text = "" Then
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


    Private Sub inputKode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles inputKode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "select * from petugas where kode_petugas='" & inputKode.Text & "'"
            cmd.CommandType = CommandType.Text

            Dim dr As OracleDataReader = cmd.ExecuteReader()
            If dr.Read() Then
                inputNama.Text = dr.Item("nama_petugas")
                inputPassword.Text = dr.Item("password_petugas")
                levelInput.SelectedItem = dr.Item("status_petugas")
            Else
                MsgBox("Data tidak ada")
            End If
            conn.Close()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        inputPassword.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If inputKode.Text = "" Or inputNama.Text = "" Or inputPassword.Text = "" Or levelInput.Text = "" Then
            MsgBox("Silahkan isi data terlebih dahulu")
        Else
            cmd.CommandText = "UPDATE petugas set nama_petugas='" & inputNama.Text & "', password_petugas='" & inputPassword.Text & "', status_petugas='" & levelInput.SelectedItem & "' where kode_petugas='" & inputKode.Text & "'"
            cmd.Connection = conn
            conn.Open()
            Try
                Dim aff As Integer = cmd.ExecuteNonQuery()
                MessageBox.Show(aff & " rows were affected.")
            Catch
                MessageBox.Show("Error encountered during UPDATE operation.")
            Finally
                conn.Close()
            End Try

            conn.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If inputKode.Text = "" Or inputNama.Text = "" Or inputPassword.Text = "" Or levelInput.Text = "" Then
            MsgBox("Silahkan isi data terlebih dahulu")
        Else
            cmd.CommandText = "DELETE FROM petugas where kode_petugas='" & inputKode.Text & "'"
            cmd.Connection = conn
            conn.Open()
            Try
                Dim aff As Integer = cmd.ExecuteNonQuery()
                MessageBox.Show(aff & " rows were affected.")
            Catch
                MessageBox.Show("Error encountered during UPDATE operation.")
            Finally
                conn.Close()
            End Try

            conn.Close()
        End If
    End Sub

    Private Sub inputNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles inputNama.KeyPress
        If e.KeyChar = Chr(13) Then inputPassword.Focus()
    End Sub

    Private Sub inputPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles inputPassword.KeyPress
        If e.KeyChar = Chr(13) Then levelInput.Focus()
    End Sub

    Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged
        query = "select kode_petugas as kode,nama_petugas,status_petugas from petugas WHERE lower(nama_petugas) like lower('%" & TxtCari.Text & "%') order by nama_petugas asc"
        cmd = New OracleCommand(query, conn)
        cmd.CommandType = CommandType.Text
        da = New OracleDataAdapter(cmd)
        cb = New OracleCommandBuilder(da)
        ds = New DataSet()

        DataGridView1.Refresh()

        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)

        DataGridView1.ReadOnly = True
    End Sub
End Class