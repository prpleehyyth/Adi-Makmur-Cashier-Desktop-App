<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomepageOwner
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomepageOwner))
        Me.PanelDT = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dgvDT = New System.Windows.Forms.DataGridView()
        Me.nama_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bayar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kembalian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbxnoInvoice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbxNamaPem = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PanelMT = New Guna.UI2.WinForms.Guna2Panel()
        Me.ButtonLaporan = New Guna.UI2.WinForms.Guna2Button()
        Me.btnlogout = New Guna.UI2.WinForms.Guna2Button()
        Me.tbxUser = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Transisi = New Guna.UI2.WinForms.Guna2Transition()
        Me.PanelDT.SuspendLayout()
        CType(Me.dgvDT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelDT
        '
        Me.PanelDT.Controls.Add(Me.Guna2HtmlLabel7)
        Me.PanelDT.Controls.Add(Me.Guna2HtmlLabel8)
        Me.PanelDT.Controls.Add(Me.Guna2HtmlLabel9)
        Me.PanelDT.Controls.Add(Me.dgvDT)
        Me.PanelDT.Controls.Add(Me.Label5)
        Me.PanelDT.Controls.Add(Me.Guna2TextBox1)
        Me.PanelDT.Controls.Add(Me.tbxnoInvoice)
        Me.PanelDT.Controls.Add(Me.tbxNamaPem)
        Me.Transisi.SetDecoration(Me.PanelDT, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelDT.Location = New System.Drawing.Point(212, 5)
        Me.PanelDT.Name = "PanelDT"
        Me.PanelDT.Size = New System.Drawing.Size(642, 432)
        Me.PanelDT.TabIndex = 14
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Transisi.SetDecoration(Me.Guna2HtmlLabel7, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Sitka Display", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(198, 16)
        Me.Guna2HtmlLabel7.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(170, 37)
        Me.Guna2HtmlLabel7.TabIndex = 23
        Me.Guna2HtmlLabel7.Text = "Detail Transaksi"
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Transisi.SetDecoration(Me.Guna2HtmlLabel8, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Sitka Text", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(11, 68)
        Me.Guna2HtmlLabel8.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(63, 20)
        Me.Guna2HtmlLabel8.TabIndex = 24
        Me.Guna2HtmlLabel8.Text = "No Invoice"
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Transisi.SetDecoration(Me.Guna2HtmlLabel9, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Sitka Text", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(11, 96)
        Me.Guna2HtmlLabel9.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(83, 20)
        Me.Guna2HtmlLabel9.TabIndex = 25
        Me.Guna2HtmlLabel9.Text = "Nama Pembeli"
        '
        'dgvDT
        '
        Me.dgvDT.BackgroundColor = System.Drawing.Color.White
        Me.dgvDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nama_item, Me.harga_item, Me.jumlah_item, Me.bayar, Me.kembalian, Me.subtotal_item})
        Me.Transisi.SetDecoration(Me.dgvDT, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.dgvDT.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvDT.Location = New System.Drawing.Point(11, 133)
        Me.dgvDT.Name = "dgvDT"
        Me.dgvDT.RowHeadersWidth = 62
        Me.dgvDT.Size = New System.Drawing.Size(635, 243)
        Me.dgvDT.TabIndex = 26
        '
        'nama_item
        '
        Me.nama_item.HeaderText = "Nama Item"
        Me.nama_item.MinimumWidth = 8
        Me.nama_item.Name = "nama_item"
        Me.nama_item.Width = 150
        '
        'harga_item
        '
        Me.harga_item.HeaderText = "Harga"
        Me.harga_item.MinimumWidth = 8
        Me.harga_item.Name = "harga_item"
        Me.harga_item.Width = 150
        '
        'jumlah_item
        '
        Me.jumlah_item.HeaderText = "Jumlah "
        Me.jumlah_item.MinimumWidth = 8
        Me.jumlah_item.Name = "jumlah_item"
        Me.jumlah_item.Width = 130
        '
        'bayar
        '
        Me.bayar.HeaderText = "bayar"
        Me.bayar.MinimumWidth = 8
        Me.bayar.Name = "bayar"
        Me.bayar.Width = 150
        '
        'kembalian
        '
        Me.kembalian.HeaderText = "kembalian"
        Me.kembalian.MinimumWidth = 8
        Me.kembalian.Name = "kembalian"
        Me.kembalian.Width = 150
        '
        'subtotal_item
        '
        Me.subtotal_item.HeaderText = "subtotal"
        Me.subtotal_item.MinimumWidth = 8
        Me.subtotal_item.Name = "subtotal_item"
        Me.subtotal_item.Width = 150
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Transisi.SetDecoration(Me.Label5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label5.Location = New System.Drawing.Point(323, 396)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Total      Rp"
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2TextBox1.BorderRadius = 5
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Transisi.SetDecoration(Me.Guna2TextBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FillColor = System.Drawing.Color.Linen
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(391, 388)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.ReadOnly = True
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(142, 26)
        Me.Guna2TextBox1.TabIndex = 28
        '
        'tbxnoInvoice
        '
        Me.tbxnoInvoice.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxnoInvoice.BorderRadius = 5
        Me.tbxnoInvoice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Transisi.SetDecoration(Me.tbxnoInvoice, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tbxnoInvoice.DefaultText = ""
        Me.tbxnoInvoice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbxnoInvoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbxnoInvoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxnoInvoice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxnoInvoice.FillColor = System.Drawing.Color.Linen
        Me.tbxnoInvoice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxnoInvoice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbxnoInvoice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxnoInvoice.Location = New System.Drawing.Point(113, 65)
        Me.tbxnoInvoice.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxnoInvoice.Name = "tbxnoInvoice"
        Me.tbxnoInvoice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbxnoInvoice.PlaceholderText = ""
        Me.tbxnoInvoice.SelectedText = ""
        Me.tbxnoInvoice.Size = New System.Drawing.Size(191, 22)
        Me.tbxnoInvoice.TabIndex = 29
        '
        'tbxNamaPem
        '
        Me.tbxNamaPem.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxNamaPem.BorderRadius = 5
        Me.tbxNamaPem.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Transisi.SetDecoration(Me.tbxNamaPem, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tbxNamaPem.DefaultText = ""
        Me.tbxNamaPem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbxNamaPem.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbxNamaPem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxNamaPem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxNamaPem.FillColor = System.Drawing.Color.Linen
        Me.tbxNamaPem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxNamaPem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbxNamaPem.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxNamaPem.Location = New System.Drawing.Point(113, 97)
        Me.tbxNamaPem.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxNamaPem.Name = "tbxNamaPem"
        Me.tbxNamaPem.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbxNamaPem.PlaceholderText = ""
        Me.tbxNamaPem.SelectedText = ""
        Me.tbxNamaPem.Size = New System.Drawing.Size(191, 19)
        Me.tbxNamaPem.TabIndex = 30
        '
        'PanelMT
        '
        Me.Transisi.SetDecoration(Me.PanelMT, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelMT.Location = New System.Drawing.Point(212, 5)
        Me.PanelMT.Name = "PanelMT"
        Me.PanelMT.Size = New System.Drawing.Size(641, 439)
        Me.PanelMT.TabIndex = 31
        '
        'ButtonLaporan
        '
        Me.ButtonLaporan.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonLaporan.BorderRadius = 12
        Me.ButtonLaporan.BorderThickness = 1
        Me.ButtonLaporan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Transisi.SetDecoration(Me.ButtonLaporan, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ButtonLaporan.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ButtonLaporan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ButtonLaporan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ButtonLaporan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ButtonLaporan.FillColor = System.Drawing.Color.Transparent
        Me.ButtonLaporan.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLaporan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonLaporan.Image = Global.TugasBesar_Kel5.My.Resources.Resources.Picture2
        Me.ButtonLaporan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ButtonLaporan.Location = New System.Drawing.Point(32, 316)
        Me.ButtonLaporan.Name = "ButtonLaporan"
        Me.ButtonLaporan.Size = New System.Drawing.Size(161, 29)
        Me.ButtonLaporan.TabIndex = 33
        Me.ButtonLaporan.Text = "Laporan"
        Me.ButtonLaporan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnlogout
        '
        Me.btnlogout.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnlogout.BorderRadius = 12
        Me.btnlogout.BorderThickness = 1
        Me.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Transisi.SetDecoration(Me.btnlogout, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnlogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnlogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnlogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnlogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnlogout.FillColor = System.Drawing.Color.Transparent
        Me.btnlogout.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.ForeColor = System.Drawing.Color.Red
        Me.btnlogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnlogout.Location = New System.Drawing.Point(32, 351)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(161, 29)
        Me.btnlogout.TabIndex = 34
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tbxUser
        '
        Me.tbxUser.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxUser.BorderRadius = 12
        Me.tbxUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Transisi.SetDecoration(Me.tbxUser, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tbxUser.DefaultText = ""
        Me.tbxUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbxUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbxUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxUser.FillColor = System.Drawing.Color.SeaShell
        Me.tbxUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxUser.Font = New System.Drawing.Font("Sitka Small", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxUser.ForeColor = System.Drawing.Color.Black
        Me.tbxUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxUser.Location = New System.Drawing.Point(21, 250)
        Me.tbxUser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxUser.Name = "tbxUser"
        Me.tbxUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbxUser.PlaceholderText = ""
        Me.tbxUser.SelectedText = ""
        Me.tbxUser.Size = New System.Drawing.Size(172, 28)
        Me.tbxUser.TabIndex = 35
        Me.tbxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2CirclePictureBox1
        '
        Me.Transisi.SetDecoration(Me.Guna2CirclePictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2CirclePictureBox1.Image = Global.TugasBesar_Kel5.My.Resources.Resources.WhatsApp_Image_2023_11_12_at_12_14_44_ec999b74
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(21, 73)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(172, 169)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 36
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Transisi.SetDecoration(Me.Guna2HtmlLabel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Sitka Small", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(70, 28)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(82, 30)
        Me.Guna2HtmlLabel1.TabIndex = 37
        Me.Guna2HtmlLabel1.Text = "OWNER"
        '
        'Transisi
        '
        Me.Transisi.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent
        Me.Transisi.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 1.0!
        Me.Transisi.DefaultAnimation = Animation1
        '
        'HomepageOwner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(855, 447)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Controls.Add(Me.tbxUser)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.ButtonLaporan)
        Me.Controls.Add(Me.PanelMT)
        Me.Controls.Add(Me.PanelDT)
        Me.Transisi.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "HomepageOwner"
        Me.Text = "HomepageOwner"
        Me.PanelDT.ResumeLayout(False)
        Me.PanelDT.PerformLayout()
        CType(Me.dgvDT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelDT As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dgvDT As DataGridView
    Friend WithEvents nama_item As DataGridViewTextBoxColumn
    Friend WithEvents harga_item As DataGridViewTextBoxColumn
    Friend WithEvents jumlah_item As DataGridViewTextBoxColumn
    Friend WithEvents bayar As DataGridViewTextBoxColumn
    Friend WithEvents kembalian As DataGridViewTextBoxColumn
    Friend WithEvents subtotal_item As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbxnoInvoice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbxNamaPem As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PanelMT As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ButtonLaporan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnlogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbxUser As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Transisi As Guna.UI2.WinForms.Guna2Transition
End Class
