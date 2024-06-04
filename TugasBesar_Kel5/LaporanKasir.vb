Imports MySql.Data.MySqlClient
Public Class LaporanKasir
    Dim conn As New MySqlConnection
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet

    Public Property InvoiceNumber As String
    Public Property CustomerName As String
    Sub koneksi()
        conn = New MySqlConnection("server=localhost" + ";user id = root" + "; password=" + "" + ";database=db_cafe2")
    End Sub

    Sub tampil_data()
        Try
            da = New MySqlDataAdapter(“SELECT
                                      t.no_invoice,
                                      t.nama_pembeli,
                                      b.nama_barang AS nama_barang,
                                      dt.jumlah AS jumlah,
                                      b.harga AS harga,
                                      t.total,
                                      dt.subtotal AS subtotal,
                                      t.metode,
                                      t.bayar,
                                      t.kembalian
                                 FROM
                                      tbl_transaksi t
                                 JOIN
                                      tbl_detailtransaksi dt ON t.no_Invoice = dt.no_Invoice
                                 LEFT JOIN
                                      tbl_barang b ON dt.id_barang = b.id_barang
                                 WHERE dt.no_Invoice= @no_Invoice", conn)
            da.SelectCommand.Parameters.AddWithValue("@no_Invoice", InvoiceNumber)
            da.Fill(ds, "xxx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Form_CR_Nota_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LaporanKasir_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ds.Clear()
        koneksi()
        Try
            Dim report As New CrystalReport2
            tampil_data()
            report.SetDataSource(ds.Tables("xxx"))
            For Each paramfield As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition In report.ParameterFields
                Select Case paramfield.Name
                    Case "nama_pembeli"
                        paramfield.CurrentValues.Clear()
                        paramfield.CurrentValues.AddValue(CustomerName)
                        report.DataDefinition.ParameterFields(paramfield.Name).ApplyCurrentValues(paramfield.CurrentValues)
                    Case "no_invoice"
                        paramfield.CurrentValues.Clear()
                        paramfield.CurrentValues.AddValue(InvoiceNumber)
                        report.DataDefinition.ParameterFields(paramfield.Name).ApplyCurrentValues(paramfield.CurrentValues)
                End Select
            Next
            CrystalReportViewer1.ReportSource = report
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message & vbCrLf & ex.StackTrace, "Crystal Reports Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Hide()

    End Sub
End Class