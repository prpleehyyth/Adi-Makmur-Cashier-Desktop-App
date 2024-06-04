Imports MySql.Data.MySqlClient
Public Class LaporanInbound
    Sub tampil_data()
        da = New MySqlDataAdapter("select * from tbl_barang", conn)
        da.Fill(ds, "xxx")
    End Sub

    Private Sub LaporanInbound_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ds.Clear()
        koneksi()
        Try
            Dim myrpt As New CrystalReport1
            tampil_data()
            myrpt.SetDataSource(ds.Tables("xxx"))
            CrystalReportViewer1.ReportSource = Nothing
            CrystalReportViewer1.ReportSource = myrpt
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message)
        End Try
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub LaporanInbound_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class