Imports System.Data.OracleClient
Module Modul
    Public oradb As String = "USER ID=C##SCOTT;PASSWORD=tiger;DATA SOURCE=localhost:1521/orcl"


    Sub keluar()
        Dim response As Integer
        response = MessageBox.Show("Yakin ingin keluar dari aplikasi ?", "Keluar aplikasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = vbYes Then
            Application.Exit()
        End If
    End Sub

    Sub logout()
        Login.Show()
        Login.UsernameTextBox.Text = ""
        Login.PasswordTextBox.Text = ""
        Login.UsernameTextBox.Focus()
    End Sub

    Sub terkunci()

    End Sub
End Module