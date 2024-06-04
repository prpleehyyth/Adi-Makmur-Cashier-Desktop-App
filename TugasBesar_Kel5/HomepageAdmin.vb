Imports MySql.Data.MySqlClient
Public Class HomepageAdmin
    Dim SelectedID As String = " "

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Login.Show()
        Login.PanelSignIn.Visible = True
    End Sub

    Private Sub HomepageAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.koneksi()
        tampil_data()
    End Sub
    Sub clear()
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Then
                ctr.Text = ""
            ElseIf TypeOf ctr Is ComboBox Then
                DirectCast(ctr, ComboBox).SelectedItem = Nothing
            ElseIf TypeOf ctr Is RadioButton Then
                DirectCast(ctr, RadioButton).Checked = False
            ElseIf TypeOf ctr Is NumericUpDown Then
                DirectCast(ctr, NumericUpDown).Value = 0
            End If
        Next
    End Sub
    'MASTER BARANG
    Sub tampil_data()
        Try
            ds.Clear()
            da = New MySqlDataAdapter("select*from tbl_barang", conn)
            da.Fill(ds, "barang")
            DGVMasterBarang.Rows.Clear()

            For i As Integer = 0 To ds.Tables("barang").Rows.Count - 1
                DGVMasterBarang.Rows.Add(ds.Tables("barang").Rows(i).Item(0).ToString,
                                     ds.Tables("barang").Rows(i).Item(1).ToString,
                                     ds.Tables("barang").Rows(i).Item(2).ToString,
                                     ds.Tables("barang").Rows(i).Item(3).ToString)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ButtonMaterBarang_Click(sender As Object, e As EventArgs) Handles ButtonMaterBarang.Click
        Transisi.Hide(PanelDT)
        Transisi.Hide(PanelMT)
        Transisi.Show(PanelMasterB)
    End Sub

    Private Sub ButtonMasterTransaksi_Click(sender As Object, e As EventArgs) Handles ButtonMasterTransaksi.Click
        Transisi.HideSync(PanelDT)
        Transisi.HideSync(PanelMasterB)
        Transisi.ShowSync(PanelMT)
        koneksi()
        tampil_detail()
        Dim total As Integer = 0
        For Each row As DataGridViewRow In DGVMT.Rows
            If row.Cells("total").Value IsNot Nothing Then
                total += Integer.Parse(row.Cells("total").Value)
            End If
        Next
        tbtotal.Text = total
    End Sub


    Private Sub btSimpan_Click(sender As Object, e As EventArgs) Handles btSimpan.Click
        Dim id_barang As String
        If rbMakanan.Checked Then
            ds.Clear()
            da = New MySqlDataAdapter("SELECT CASE WHEN MAX(CAST(SUBSTRING(id_barang, 2, 3) AS UNSIGNED)) IS NULL THEN 'F001'
                                       ELSE CONCAT('F', LPAD(MAX(CAST(SUBSTRING(id_barang, 2, 3) AS UNSIGNED)) + 1, 3, '0')) END AS nomor 
                                       FROM tbl_barang WHERE id_barang LIKE 'F%';", conn)
            da.Fill(ds, "id")
            id_barang = ds.Tables("id").Rows(0).Item(0)
        ElseIf rbMinuman.Checked Then
            da = New MySqlDataAdapter("SELECT CASE WHEN MAX(CAST(SUBSTRING(id_barang, 2, 3) AS UNSIGNED)) IS NULL THEN 'D001'
                                       ELSE CONCAT('D', LPAD(MAX(CAST(SUBSTRING(id_barang, 2, 3) AS UNSIGNED)) + 1, 3, '0')) END AS nomor 
                                       FROM tbl_barang WHERE id_barang LIKE 'D%';", conn)
            da.Fill(ds, "id")
            id_barang = ds.Tables("id").Rows(0).Item(0)

        Else
            MessageBox.Show("Pilih jenis terlebih dahulu!")
        End If

        ds.Clear()
        da = New MySqlDataAdapter("insert into tbl_barang Values (?,?,?,?)", conn)
        da.SelectCommand.Parameters.AddWithValue("id_barang", id_barang)
        da.SelectCommand.Parameters.AddWithValue("nama_barang", tbxNamaBarang.Text)
        da.SelectCommand.Parameters.AddWithValue("harga", tbxHarga.Text)
        da.SelectCommand.Parameters.AddWithValue("stock", NUD.Value)
        da.Fill(ds, "data_barang")
        ds.Clear()
        MessageBox.Show("Data berhasil disimpan")
        clear()
        tampil_data()
    End Sub

    'MASTER TRANSAKSI

    Sub tampil_detail()
        Try

            ds.Clear()
            da = New MySqlDataAdapter("select no_invoice, nama_pembeli, total from tbl_transaksi", conn)
            da.Fill(ds, "transaksi")
            DGVMT.Rows.Clear()

            For i As Integer = 0 To ds.Tables("transaksi").Rows.Count - 1
                DGVMT.Rows.Add(ds.Tables("transaksi").Rows(i).Item(0).ToString,
                                     ds.Tables("transaksi").Rows(i).Item(1).ToString,
                                     ds.Tables("transaksi").Rows(i).Item(2).ToString)
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public invoice As String
    Public nama_pembeli As String

    Private Sub DGVMT_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DGVMT.CellDoubleClick
        Try
            If DGVMT.SelectedRows.Count > 0 Then
                Dim total As Integer = 0
                Transisi.ShowSync(PanelDT)
                Transisi.HideSync(PanelMT)
                Dim selectedRow As DataGridViewRow = DGVMT.SelectedRows(0)
                invoice = selectedRow.Cells("noInvoice").Value.ToString()
                nama_pembeli = selectedRow.Cells("nama").Value.ToString()

                tbxnoInvoice.Text = invoice
                tbxNamaPem.Text = nama_pembeli

                ds.Clear()
                da = New MySqlDataAdapter("SELECT nama_barang, harga, jumlah, bayar, kembalian, subtotal FROM tbl_transaksi 
right join tbl_detailtransaksi USING(no_invoice)
right join tbl_barang USING(id_barang)
where no_invoice = '" & invoice & "'", conn)
                da.Fill(ds, "detail_transaksi")
                dgvDT.Rows.Clear()

                For i As Integer = 0 To ds.Tables("detail_transaksi").Rows.Count - 1
                    total += Integer.Parse(ds.Tables("detail_transaksi").Rows(i).Item(5).ToString)
                    dgvDT.Rows.Add(ds.Tables("detail_transaksi").Rows(i).Item(0).ToString,
                                         ds.Tables("detail_transaksi").Rows(i).Item(1).ToString,
                                         ds.Tables("detail_transaksi").Rows(i).Item(2).ToString,
ds.Tables("detail_transaksi").Rows(i).Item(3).ToString,
ds.Tables("detail_transaksi").Rows(i).Item(4).ToString,
ds.Tables("detail_transaksi").Rows(i).Item(5).ToString)
                Next

                tbxTotal.Text = total
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub DGVMasterBarang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVMasterBarang.CellContentClick
        If e.ColumnIndex = DGVMasterBarang.Columns("btHapus").Index AndAlso e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow
            selectedRow = DGVMasterBarang.Rows(e.RowIndex)
            Dim idBarang As String = selectedRow.Cells(0).Value

            Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data " & idBarang & "?", "Konfirmasi",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                da = New MySqlDataAdapter("update tbl_detailtransaksi set id_barang=null where id_barang='" & idBarang & "'", conn)
                da.Fill(ds, "xxxx")
                ds.Clear()
                da = New MySqlDataAdapter("delete from tbl_barang where id_barang='" & idBarang & "'", conn)
                da.Fill(ds, "xxxx")
                ds.Clear()
                DGVMasterBarang.Rows.RemoveAt(e.RowIndex)
            End If

        ElseIf e.ColumnIndex = DGVMasterBarang.Columns("btUbah").Index AndAlso e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DGVMasterBarang.Rows(e.RowIndex)
            tbxNamaBarang.Text = selectedRow.Cells("nama_barang").Value.ToString()
            tbxHarga.Text = selectedRow.Cells("harga").Value.ToString()
            NUD.Value = selectedRow.Cells("stock").Value.ToString()
            SelectedID = selectedRow.Cells("id_barang").Value.ToString()

        End If
    End Sub

    Private Sub btUpdate_Click(sender As Object, e As EventArgs) Handles btUpdate.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin memperbaharui data " & SelectedID & "?", "Konfirmasi",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        da = New MySqlDataAdapter("select*from tbl_barang where id_barang='" & SelectedID & "'", conn)
        da.Fill(ds, "xxxx")
        If ds.Tables("xxxx").Rows.Count < 1 Then
            MsgBox("Kode Tidak Tersedia")

        ElseIf result = DialogResult.Yes Then
            da = New MySqlDataAdapter("update tbl_barang set nama_barang=?, harga=?, stock=? where id_barang=?", conn)
            da.SelectCommand.Parameters.AddWithValue("nama_barang", tbxNamaBarang.Text)
            da.SelectCommand.Parameters.AddWithValue("harga", tbxHarga.Text)
            da.SelectCommand.Parameters.AddWithValue("stock", NUD.Value)
            da.SelectCommand.Parameters.AddWithValue("id_barang", SelectedID)

            da.Fill(ds, "xxxx")
            clear()
            tampil_data()
        End If
    End Sub

    Private Sub ButtonLaporan_Click(sender As Object, e As EventArgs) Handles ButtonLaporan.Click
        Dim laporanstok As New LaporanInbound
        laporanstok.Show()
    End Sub

    Private Sub tbxUser_TextChanged(sender As Object, e As EventArgs) Handles tbxUser.TextChanged

    End Sub
End Class