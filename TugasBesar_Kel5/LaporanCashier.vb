Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class LaporanCashier
    Private Sub ButtonKonfirmasi_Click_1(sender As Object, e As EventArgs) Handles ButtonKonfirmasi.Click
        Module1.koneksi()
        Try
            ' Mendapatkan tanggal yang dipilih dari DateTimePicker
            Dim selectedDate As Date = DTPAwal.Value

            ' Query SQL untuk mengambil data berdasarkan tanggal
            Dim sql As String = "SELECT * FROM tbl_transaksi WHERE DATE(no_invoice) = @SelectedDate"

            ' Membuka koneksi ke database
            conn.Open()

            ' Membuat objek perintah SQL
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@SelectedDate", selectedDate)


            Dim reader As MySqlDataReader = cmd.ExecuteReader()


            Dim report As New ReportDocument()
            report.Load("CrystalReportKasir.rpt")

            report.SetDataSource(reader)


            Dim reportViewer As New CrystalReportKasir()
            reportViewer.ReportSource = report
            reportViewer.Show()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            conn.Close()
        End Try
    End Sub




End Class
