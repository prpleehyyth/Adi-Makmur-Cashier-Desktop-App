Imports MySql.Data.MySqlClient
Public Class HomepageCashier
    Dim connectionString As String = "Server=localhost;Database=db_cafe2;User ID= root;Password=;"

    Dim connection As New MySqlConnection(connectionString)
    Dim id_user As String

    Private Sub HomepageCashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            isi_ComboBox()
            invoice()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub clear()
        tbxNamaPembeli.Text = ""
        RBDebit.Checked = False
        RBTunai.Checked = False
        tbxUangBayar.Text = ""
        tbxUangKembali.Text = ""
        tbxTotal.Text = ""
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Then
                DirectCast(ctr, TextBox).Text = ""
            ElseIf TypeOf ctr Is ComboBox Then
                DirectCast(ctr, ComboBox).SelectedItem = Nothing
            End If
        Next
    End Sub
    Sub isi_ComboBox()
        da = New MySqlDataAdapter("select * from tbl_barang order by id_barang", conn)
        da.Fill(ds, "barang")
        cbxPilihBarang.Items.Clear()
        For i As Integer = 0 To ds.Tables("barang").Rows.Count - 1
            cbxPilihBarang.Items.Add(ds.Tables("barang").Rows(i).Item(1).ToString())
        Next
    End Sub

    Sub invoice()
        ds.Clear()
        da = New MySqlDataAdapter("SELECT CASE WHEN MAX(CAST(SUBSTRING(no_invoice, 5, 3) AS UNSIGNED)) IS NULL THEN 1 
              ELSE MAX(CAST(SUBSTRING(no_invoice, 5, 3) AS UNSIGNED)) + 1
              END AS nomor 
              FROM (
                  SELECT 
                    MAX(CAST(SUBSTRING(no_invoice, 9,2) AS UNSIGNED)) AS hari,
                    MAX(CAST(SUBSTRING(no_invoice, 12, 2) AS UNSIGNED)) AS bln,
                    MAX(CAST(SUBSTRING(no_invoice, 15, 4) AS UNSIGNED)) AS thn,
                    no_invoice 
                    FROM tbl_transaksi 
                    GROUP BY no_invoice) a 
              WHERE a.hari = DAY(NOW()) AND a.bln = MONTH(NOW()) AND a.thn = YEAR(NOW());", conn)
        da.Fill(ds, "nomor")

        ' Check if there are any rows in the DataTable
        If ds.Tables("nomor").Rows.Count > 0 Then
            Dim nom As Integer = Integer.Parse(ds.Tables("nomor").Rows(0).Item(0))
            tbxInvoice.Text = "INV/" & Format(nom, "0##") & "/" & Format(Now.Day, "0#") & "/" & Now.Month & "/" & Now.Year
        Else
            ' Handle the case where there are no rows in the DataTable
            MessageBox.Show("Error generating invoice number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub HomepageCashier_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        invoice()
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        Try
            Dim nama_pembeli As String = tbxNamaPembeli.Text
            Dim namaItem As String = cbxPilihBarang.SelectedItem
            Dim baris As Integer = -1
            For Each row As DataGridViewRow In DGVPembelian.Rows
                If row.Cells("nama_item").Value = namaItem Then
                    baris = row.Index
                End If
            Next
            ds.Clear()
            da = New MySqlDataAdapter("select harga, stock from tbl_barang where nama_barang='" & cbxPilihBarang.SelectedItem.ToString() & "'", conn)
            da.Fill(ds, "harga")
            Dim harga As Integer = ds.Tables("harga").Rows(0).Item(0)
            Dim stock As Integer = ds.Tables("harga").Rows(0).Item(1)
            If stock = 0 Then
                MsgBox("stock telah habis")
            Else
                If baris > -1 Then
                    If DGVPembelian.Rows(baris).Cells("jumlah").Value + tbxJumlah.Text <= stock Then
                        DGVPembelian.Rows(baris).Cells("jumlah").Value += tbxJumlah.Text
                        DGVPembelian.Rows(baris).Cells("subtotal").Value += tbxJumlah.Text * harga
                    Else
                        MsgBox("Stock tidak mencukupi")
                    End If
                Else
                    If tbxJumlah.Text <= stock Then
                        Dim jumlah As Integer = Integer.Parse(tbxJumlah.Text)
                        Dim subtotal As Integer = jumlah * harga
                        DGVPembelian.Rows.Add(namaItem, harga, jumlah, subtotal)
                    Else
                        MsgBox("Stock tidak mencukupi")
                    End If
                End If
                Dim total As Integer = 0
                For Each row As DataGridViewRow In DGVPembelian.Rows
                    If row.Cells("subtotal").Value IsNot Nothing Then
                        total += row.Cells("subtotal").Value
                    End If
                Next
                tbxTotal.Text = total
            End If

            cbxPilihBarang.SelectedItem = Nothing
            tbxJumlah.Text = String.Empty
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub DGVPembelian_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPembelian.CellContentClick
        If e.ColumnIndex = DGVPembelian.Columns("btRemove").Index AndAlso e.RowIndex >= 0 Then
            DGVPembelian.Rows.RemoveAt(e.RowIndex)
        End If
        Dim total As Integer = 0
        For Each row As DataGridViewRow In DGVPembelian.Rows
            If row.Cells("subtotal").Value IsNot Nothing Then
                total += row.Cells("subtotal").Value
            End If
        Next
        tbxTotal.Text = total
    End Sub
    Private Sub ButtonSelesai_Click(sender As Object, e As EventArgs) Handles ButtonSelesai.Click
        Try
            ds.Clear()

            Dim metodePembayaran As String

            If RBDebit.Checked Then
                metodePembayaran = "Debit"
            Else
                metodePembayaran = "Tunai"
            End If

            da = New MySqlDataAdapter("insert into tbl_transaksi Values (?,?,?,?,?,?)", conn)
            da.SelectCommand.Parameters.AddWithValue("no_invoice", tbxInvoice.Text)
            da.SelectCommand.Parameters.AddWithValue("nama_pembeli", tbxNamaPembeli.Text)
            da.SelectCommand.Parameters.AddWithValue("metode", metodePembayaran)
            da.SelectCommand.Parameters.AddWithValue("bayar", tbxUangBayar.Text)
            da.SelectCommand.Parameters.AddWithValue("kembalian", tbxUangKembali.Text)
            da.SelectCommand.Parameters.AddWithValue("total", tbxTotal.Text)
            da.Fill(ds, "transaksi")

            For i As Integer = 0 To DGVPembelian.Rows.Count - 1
                Dim jumlah As Integer = DGVPembelian.Rows(i).Cells("jumlah").Value
                Dim subtotal As Integer = DGVPembelian.Rows(i).Cells("subtotal").Value
                Dim nama_item As String = DGVPembelian.Rows(i).Cells("nama_item").Value
                ds.Clear()
                da = New MySqlDataAdapter("select id_barang from tbl_barang where nama_barang='" & nama_item & "'", conn)
                da.Fill(ds, "barang")
                If ds.Tables("barang").Rows.Count > 0 Then
                    Dim id_item As String = ds.Tables("barang").Rows(0).Item(0)
                    If Not (jumlah = 0 OrElse subtotal = 0) Then
                        ds.Clear()
                        Dim query As String = "update tbl_barang set stock = stock - " & jumlah & " where id_barang = '" & id_item & "'"
                        da = New MySqlDataAdapter("update tbl_barang set stock = stock - '" & jumlah & "' where id_barang ='" & id_item & "'", conn)
                        da.Fill(ds, "update")

                        ds.Clear()
                        da = New MySqlDataAdapter("insert into tbl_detailtransaksi (no_invoice, id_barang, jumlah, subtotal) values (?,?,?,?)", conn)
                        da.SelectCommand.Parameters.AddWithValue("no_invoice", tbxInvoice.Text)
                        da.SelectCommand.Parameters.AddWithValue("id_barang", id_item)
                        da.SelectCommand.Parameters.AddWithValue("jumlah", jumlah)
                        da.SelectCommand.Parameters.AddWithValue("subtotal", subtotal)
                        da.Fill(ds, "detail")
                    End If
                End If
            Next
            Dim StrukPembelian As New LaporanKasir
            StrukPembelian.InvoiceNumber = tbxInvoice.Text
            StrukPembelian.CustomerName = tbxNamaPembeli.Text
            StrukPembelian.Show()
            DGVPembelian.Rows.Clear()
            clear()
            invoice()
            MessageBox.Show("Data berhasil disimpan")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Dim startDate As String = DTPAwal.Value.ToString("yyyy-MM-dd")
    'ShowReport(startDate)
    ' Dim selectedDate As Date = DTPAwal.Value
    'Dim query As String = "SELECT * FROM tbl_detailtransaksi WHERE no_Invoice ON @SelectedDate "
    'connection.Open()
    'Dim cmd As New MySqlCommand(query, connection)
    'cmd.Parameters.AddWithValue("@SelectedDate", selectedDate)
    'Dim reader As MySqlDataReader = cmd.ExecuteReader()
    'Dim report As New ReportDocument()
    'report.Load("CrystalReportCashier.rpt") ' Gantilah dengan path file .rpt Anda

    ' Menetapkan sumber data untuk laporan

    'Dim reportViewer As New LaporanCashier()
    'reportViewer.Show()


    Private Sub ButtonKonfirmasi_Click(sender As Object, e As EventArgs)
        '  Dim da = New MySqlDataAdapter("Select * From tbl_transaksi Where no_invoice", conn)
        ' Dim selectedDate As Date = DTPAwal.Value

        ' Parameter untuk laporan Crystal Reports
        ' Dim dayParameter As New CrystalDecisions.Shared.ParameterDiscreteValue()
        'dayParameter.Value = selectedDate.Day

        'im monthParameter As New CrystalDecisions.Shared.ParameterDiscreteValue()
        'monthParameter.Value = selectedDate.Month

        'Dim yearParameter As New CrystalDecisions.Shared.ParameterDiscreteValue()
        'yearParameter.Value = selectedDate.Year

        ' Menetapkan nilai parameter ke dalam laporan Crystal Reports
        'CrystalReportCashier.ParameterFieldInfo("SelectedDay").CurrentValues.Clear()
        'CrystalReportViewer1.ParameterFieldInfo("SelectedMonth").CurrentValues.Clear()
        'CrystalReportViewer1.ParameterFieldInfo("SelectedYear").CurrentValues.Clear()

        'CrystalReportViewer1.ParameterFieldInfo("SelectedDay").CurrentValues.Add(dayParameter)
        'CrystalReportViewer1.ParameterFieldInfo("SelectedMonth").CurrentValues.Add(monthParameter)
        'CrystalReportViewer1.ParameterFieldInfo("SelectedYear").CurrentValues.Add(yearParameter)

        ' Menampilkan laporan Crystal Reports
        'CrystalReportViewer1.RefreshReport()


    End Sub
    'Private Sub ShowReport(startDate As String)

    'End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Close()
        Login.Show()
    End Sub
    Private Sub ButtonPembelian_Click(sender As Object, e As EventArgs) Handles ButtonPembelian.Click
        'Transisi.HideSync(PanelLaporan)
        Transisi.ShowSync(PanelPembelian)
    End Sub
    Private Sub ButtonLaporan_Click(sender As Object, e As EventArgs) Handles ButtonLaporan.Click
        Dim laporanharian As New LaporanKasir2
        laporanharian.Show()


    End Sub


    Private Sub tbxUangBayar_TextChanged(sender As Object, e As EventArgs) Handles tbxUangBayar.TextChanged
        Dim total = tbxTotal.Text
        If tbxUangBayar.Text.All(AddressOf Char.IsDigit) Then
        Else
            tbxUangBayar.Text = ""
        End If
        If tbxUangBayar.Text IsNot "" Then
            Dim bayar As Integer = CInt(tbxUangBayar.Text)

            Dim kembalian As Integer = bayar - total
            tbxUangKembali.Text = kembalian

        End If
    End Sub
End Class