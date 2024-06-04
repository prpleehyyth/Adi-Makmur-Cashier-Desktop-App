Imports MySql.Data.MySqlClient
Public Class HomepageOwner
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
        Login.Show()
    End Sub

    Private Sub HomepageOwner_Load(sender As Object, e As EventArgs)
        Module1.koneksi()
    End Sub

    Private Sub ButtonLaporan_Click(sender As Object, e As EventArgs) Handles ButtonLaporan.Click
        laporanowner.Show()
    End Sub

    Private Sub HomepageOwner_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'Public nama_pembeli As String


End Class