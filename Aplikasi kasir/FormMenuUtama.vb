Imports Oracle.ManagedDataAccess.Client

Public Class FormMenuUtama

    Dim conn As New OracleConnection(oradb)
    Dim cmd As New OracleCommand
    Dim cek As OracleDataReader
    Dim da As OracleDataAdapter
    Dim cb As OracleCommandBuilder
    Dim ds As DataSet
    Dim query As String


    Private Sub FormMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblHari.Text = Format(Now, "dddd, dd-MMMM-yyyy")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblJam.Text = Format(Now, "hh:mm:ss")
    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Dim pesan As String
        pesan = MsgBox("Yakin ingin keluar ??", vbInformation + vbYesNo, "Konfirmasi")
        If pesan = vbYes Then
            End
        End If
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Hide()
        logout()
    End Sub

    Private Sub BtnGantiPass_Click(sender As Object, e As EventArgs)
        'FormGantiPassword.ShowDialog()
    End Sub

    Private Sub BtnPengguna_Click(sender As Object, e As EventArgs) Handles BtnPengguna.Click
        Form1.Show()
    End Sub

    Private Sub BtnSupplier_Click(sender As Object, e As EventArgs) Handles BtnSupplier.Click
        FormSupplier.ShowDialog()
    End Sub

    Private Sub BtnPelanggan_Click(sender As Object, e As EventArgs) Handles BtnPelanggan.Click
        FormPelanggan.ShowDialog()
    End Sub

    Private Sub BtnBarangMasuk_Click(sender As Object, e As EventArgs) Handles BtnBarangMasuk.Click
        FormBarangMasuk.Show()
    End Sub

    Private Sub BtnSatuan_Click(sender As Object, e As EventArgs) Handles BtnSatuan.Click
        FormSatuan.ShowDialog()
    End Sub

    Private Sub BtnKategori_Click(sender As Object, e As EventArgs) Handles BtnKategori.Click
        FormKategori.Show()
    End Sub

    Private Sub BtnBarang_Click(sender As Object, e As EventArgs) Handles BtnBarang.Click
        FormBarang.ShowDialog()
    End Sub

    Private Sub BtnBarangKeluar_Click(sender As Object, e As EventArgs) Handles BtnBarangKeluar.Click
        FormBarangKeluar.Show()
    End Sub


End Class