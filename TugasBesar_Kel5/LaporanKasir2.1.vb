Imports MySql.Data.MySqlClient
Public Class LaporanKasir2
    Dim conn As New MySqlConnection
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet

    Sub koneksi()
        conn = New MySqlConnection("server=localhost;user id=root;password=;database=db_cafe2")
    End Sub

    Sub tampil_data()
        da = New MySqlDataAdapter("SELECT * FROM tbl_transaksi WHERE SUBSTRING(CURRENT_DATE(), 9, 10) = SUBSTRING(no_invoice, 9, 2);
                                    ", conn)
        da.Fill(ds, "xxx")
    End Sub

    Sub clear()
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Then
                ctr.text = ""
            ElseIf TypeOf ctr Is ComboBox Then
                DirectCast(ctr, ComboBox).SelectedItem = Nothing
            End If
        Next
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub btShow_Click_1(sender As Object, e As EventArgs)
        ds.Clear()
        koneksi()
        Try
            Dim myrpt As New CrystalReport3
            tampil_data()
            myrpt.SetDataSource(ds.Tables("xxx"))
            CrystalReportViewer1.ReportSource = Nothing
            CrystalReportViewer1.ReportSource = myrpt
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message)
        End Try

    End Sub

    Private Sub btBack_Click_1(sender As Object, e As EventArgs)
        HomepageCashier.Show()
        Me.Hide()
    End Sub



    Private Sub LaporanKasir2_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ds.Clear()
        koneksi()
        Try
            Dim myrpt As New CrystalReport3
            tampil_data()
            myrpt.SetDataSource(ds.Tables("xxx"))
            CrystalReportViewer1.ReportSource = Nothing
            CrystalReportViewer1.ReportSource = myrpt
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message)
        End Try
    End Sub
End Class

