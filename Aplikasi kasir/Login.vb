Imports Oracle.ManagedDataAccess.Client
Imports System.Data

Public Class Login

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Dim conn As New OracleConnection(oradb)
        Dim cmd As New OracleCommand
        Dim cek As OracleDataReader

        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MsgBox("Data tidak boleh kosong !")
            Exit Sub
        Else
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from admin where nama='" & UsernameTextBox.Text & "' and password='" & PasswordTextBox.Text & "'"
            cmd.ExecuteNonQuery()
            cek = cmd.ExecuteReader()
            cek.Read()
            If cek.HasRows Then
                Me.Hide()
                Form1.Show()
            Else
                MsgBox("Username atau Password salah !")
            End If
            conn.Close()
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            PasswordTextBox.UseSystemPasswordChar = False
        Else
            PasswordTextBox.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        keluar()
    End Sub

    Private Sub KasirToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form1.Show()
    End Sub

End Class
