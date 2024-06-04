Imports MySql.Data.MySqlClient
Public Class laporanowner
    Dim conn As New MySqlConnection
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet

    Sub koneksi()
        conn = New MySqlConnection("server=localhost" + ";user id = root" + "; password=" + "" + ";database=db_cafe2")
    End Sub
    Sub tampil_data()
        da = New MySqlDataAdapter("select*from tbl_transaksi", conn)
        da.Fill(ds, "xxx")
    End Sub
    Private Sub Laporanowner_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ds.Clear()
        koneksi()
        Try
            Dim myrpt As New CrystalReportowner
            tampil_data()
            myrpt.SetDataSource(ds.Tables("xxx"))
            CrystalReportViewer1.ReportSource = Nothing
            CrystalReportViewer1.ReportSource = myrpt
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message)
        End Try
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()

    End Sub
End Class