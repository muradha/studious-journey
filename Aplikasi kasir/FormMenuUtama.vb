Public Class FormMenuUtama
    Private Sub FormMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblHari.Text = Format(Now, "dddd, dd-MMMM-yyyy")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblJam.Text = Format(Now, "hh:mm:ss")
    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
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
        'Me.Hide()
        'formlogin.show
    End Sub

    Private Sub BtnGantiPass_Click(sender As Object, e As EventArgs) Handles BtnGantiPass.Click
        'FormGantiPassword.ShowDialog()
    End Sub

    Private Sub BtnPengguna_Click(sender As Object, e As EventArgs) Handles BtnPengguna.Click

    End Sub

    Private Sub BtnSupplier_Click(sender As Object, e As EventArgs) Handles BtnSupplier.Click
        FormSupplier.ShowDialog()
    End Sub

    Private Sub BtnPelanggan_Click(sender As Object, e As EventArgs) Handles BtnPelanggan.Click
        FormPelanggan.ShowDialog()
    End Sub

    Private Sub BtnBarangMasuk_Click(sender As Object, e As EventArgs) Handles BtnBarangMasuk.Click
        FormBarangMasuk.Show()
        FormBarangMasuk.TxtKasir.Text = Me.LblNmUsr.Text
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

End Class