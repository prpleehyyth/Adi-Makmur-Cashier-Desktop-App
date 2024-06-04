<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomepageAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomepageAdmin))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Transisi = New Guna.UI2.WinForms.Guna2Transition()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.ButtonLaporan = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonMasterTransaksi = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonMaterBarang = New Guna.UI2.WinForms.Guna2Button()
        Me.tbxUser = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxTotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbxnoInvoice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbxNamaPem = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PanelMasterB = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGVMasterBarang = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.id_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btHapus = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btUbah = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.rbMinuman = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rbMakanan = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.btUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.btSimpan = New Guna.UI2.WinForms.Guna2Button()
        Me.NUD = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.tbxHarga = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbxNamaBarang = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel10 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PanelMT = New Guna.UI2.WinForms.Guna2Panel()
        Me.tbtotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.DGVMT = New System.Windows.Forms.DataGridView()
        Me.noInvoice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDT.SuspendLayout()
        CType(Me.dgvDT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMasterB.SuspendLayout()
        CType(Me.DGVMasterBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMT.SuspendLayout()
        CType(Me.DGVMT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.ButtonLaporan)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.btnLogout)
        Me.Guna2Panel1.Controls.Add(Me.ButtonMasterTransaksi)
        Me.Guna2Panel1.Controls.Add(Me.ButtonMaterBarang)
        Me.Guna2Panel1.Controls.Add(Me.tbxUser)
        Me.Guna2Panel1.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Transisi.SetDecoration(Me.Guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(219, 450)
        Me.Guna2Panel1.TabIndex = 0
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
        Me.ButtonLaporan.Image = CType(resources.GetObject("ButtonLaporan.Image"), System.Drawing.Image)
        Me.ButtonLaporan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ButtonLaporan.Location = New System.Drawing.Point(31, 356)
        Me.ButtonLaporan.Name = "ButtonLaporan"
        Me.ButtonLaporan.Size = New System.Drawing.Size(161, 29)
        Me.ButtonLaporan.TabIndex = 8
        Me.ButtonLaporan.Text = "Laporan Stok"
        Me.ButtonLaporan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Transisi.SetDecoration(Me.Label3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Sitka Small", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(69, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 28)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ADMIN"
        '
        'btnLogout
        '
        Me.btnLogout.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLogout.BorderRadius = 12
        Me.btnLogout.BorderThickness = 1
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Transisi.SetDecoration(Me.btnLogout, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogout.FillColor = System.Drawing.Color.Transparent
        Me.btnLogout.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.Location = New System.Drawing.Point(31, 391)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(161, 29)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "Logout"
        '
        'ButtonMasterTransaksi
        '
        Me.ButtonMasterTransaksi.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonMasterTransaksi.BorderRadius = 12
        Me.ButtonMasterTransaksi.BorderThickness = 1
        Me.ButtonMasterTransaksi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Transisi.SetDecoration(Me.ButtonMasterTransaksi, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ButtonMasterTransaksi.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ButtonMasterTransaksi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ButtonMasterTransaksi.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ButtonMasterTransaksi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ButtonMasterTransaksi.FillColor = System.Drawing.Color.Transparent
        Me.ButtonMasterTransaksi.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMasterTransaksi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonMasterTransaksi.Image = CType(resources.GetObject("ButtonMasterTransaksi.Image"), System.Drawing.Image)
        Me.ButtonMasterTransaksi.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ButtonMasterTransaksi.Location = New System.Drawing.Point(31, 322)
        Me.ButtonMasterTransaksi.Name = "ButtonMasterTransaksi"
        Me.ButtonMasterTransaksi.Size = New System.Drawing.Size(161, 29)
        Me.ButtonMasterTransaksi.TabIndex = 4
        Me.ButtonMasterTransaksi.Text = "Master Transaksi"
        Me.ButtonMasterTransaksi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonMaterBarang
        '
        Me.ButtonMaterBarang.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonMaterBarang.BorderRadius = 12
        Me.ButtonMaterBarang.BorderThickness = 1
        Me.ButtonMaterBarang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Transisi.SetDecoration(Me.ButtonMaterBarang, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ButtonMaterBarang.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ButtonMaterBarang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ButtonMaterBarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ButtonMaterBarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ButtonMaterBarang.FillColor = System.Drawing.Color.Transparent
        Me.ButtonMaterBarang.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMaterBarang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonMaterBarang.Image = CType(resources.GetObject("ButtonMaterBarang.Image"), System.Drawing.Image)
        Me.ButtonMaterBarang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ButtonMaterBarang.Location = New System.Drawing.Point(31, 287)
        Me.ButtonMaterBarang.Name = "ButtonMaterBarang"
        Me.ButtonMaterBarang.Size = New System.Drawing.Size(161, 29)
        Me.ButtonMaterBarang.TabIndex = 3
        Me.ButtonMaterBarang.Text = "  Master Barang"
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
        Me.tbxUser.Location = New System.Drawing.Point(25, 235)
        Me.tbxUser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxUser.Name = "tbxUser"
        Me.tbxUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbxUser.PlaceholderText = ""
        Me.tbxUser.SelectedText = ""
        Me.tbxUser.Size = New System.Drawing.Size(172, 28)
        Me.tbxUser.TabIndex = 2
        Me.tbxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2CirclePictureBox1
        '
        Me.Transisi.SetDecoration(Me.Guna2CirclePictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(25, 60)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(172, 169)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 0
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'PanelDT
        '
        Me.PanelDT.Controls.Add(Me.Guna2HtmlLabel7)
        Me.PanelDT.Controls.Add(Me.Guna2HtmlLabel8)
        Me.PanelDT.Controls.Add(Me.Guna2HtmlLabel9)
        Me.PanelDT.Controls.Add(Me.dgvDT)
        Me.PanelDT.Controls.Add(Me.Label2)
        Me.PanelDT.Controls.Add(Me.tbxTotal)
        Me.PanelDT.Controls.Add(Me.tbxnoInvoice)
        Me.PanelDT.Controls.Add(Me.tbxNamaPem)
        Me.Transisi.SetDecoration(Me.PanelDT, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelDT.Location = New System.Drawing.Point(224, 3)
        Me.PanelDT.Name = "PanelDT"
        Me.PanelDT.Size = New System.Drawing.Size(577, 438)
        Me.PanelDT.TabIndex = 1
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Transisi.SetDecoration(Me.Guna2HtmlLabel7, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Sitka Display", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(217, 16)
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
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(31, 68)
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
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(31, 96)
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
        Me.dgvDT.Location = New System.Drawing.Point(31, 133)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Transisi.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label2.Location = New System.Drawing.Point(343, 396)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Total      Rp"
        '
        'tbxTotal
        '
        Me.tbxTotal.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxTotal.BorderRadius = 5
        Me.tbxTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Transisi.SetDecoration(Me.tbxTotal, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tbxTotal.DefaultText = ""
        Me.tbxTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbxTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbxTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxTotal.FillColor = System.Drawing.Color.Linen
        Me.tbxTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxTotal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbxTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxTotal.Location = New System.Drawing.Point(411, 388)
        Me.tbxTotal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxTotal.Name = "tbxTotal"
        Me.tbxTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbxTotal.PlaceholderText = ""
        Me.tbxTotal.ReadOnly = True
        Me.tbxTotal.SelectedText = ""
        Me.tbxTotal.Size = New System.Drawing.Size(142, 26)
        Me.tbxTotal.TabIndex = 28
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
        Me.tbxnoInvoice.Location = New System.Drawing.Point(132, 65)
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
        Me.tbxNamaPem.Location = New System.Drawing.Point(132, 97)
        Me.tbxNamaPem.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxNamaPem.Name = "tbxNamaPem"
        Me.tbxNamaPem.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbxNamaPem.PlaceholderText = ""
        Me.tbxNamaPem.SelectedText = ""
        Me.tbxNamaPem.Size = New System.Drawing.Size(191, 19)
        Me.tbxNamaPem.TabIndex = 30
        '
        'PanelMasterB
        '
        Me.PanelMasterB.Controls.Add(Me.Label4)
        Me.PanelMasterB.Controls.Add(Me.DGVMasterBarang)
        Me.PanelMasterB.Controls.Add(Me.rbMinuman)
        Me.PanelMasterB.Controls.Add(Me.rbMakanan)
        Me.PanelMasterB.Controls.Add(Me.btUpdate)
        Me.PanelMasterB.Controls.Add(Me.btSimpan)
        Me.PanelMasterB.Controls.Add(Me.NUD)
        Me.PanelMasterB.Controls.Add(Me.tbxHarga)
        Me.PanelMasterB.Controls.Add(Me.tbxNamaBarang)
        Me.PanelMasterB.Controls.Add(Me.Label1)
        Me.PanelMasterB.Controls.Add(Me.Guna2HtmlLabel5)
        Me.PanelMasterB.Controls.Add(Me.Guna2HtmlLabel3)
        Me.PanelMasterB.Controls.Add(Me.Guna2HtmlLabel10)
        Me.Transisi.SetDecoration(Me.PanelMasterB, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelMasterB.Location = New System.Drawing.Point(224, 3)
        Me.PanelMasterB.Name = "PanelMasterB"
        Me.PanelMasterB.Size = New System.Drawing.Size(627, 438)
        Me.PanelMasterB.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Transisi.SetDecoration(Me.Label4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Sitka Display", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(224, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 35)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "MASTER BARANG"
        '
        'DGVMasterBarang
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DGVMasterBarang.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVMasterBarang.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVMasterBarang.ColumnHeadersHeight = 15
        Me.DGVMasterBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGVMasterBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_barang, Me.nama_barang, Me.harga, Me.stock, Me.btHapus, Me.btUbah})
        Me.Transisi.SetDecoration(Me.DGVMasterBarang, Guna.UI2.AnimatorNS.DecorationType.None)
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVMasterBarang.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVMasterBarang.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVMasterBarang.Location = New System.Drawing.Point(40, 162)
        Me.DGVMasterBarang.Name = "DGVMasterBarang"
        Me.DGVMasterBarang.RowHeadersVisible = False
        Me.DGVMasterBarang.RowHeadersWidth = 62
        Me.DGVMasterBarang.Size = New System.Drawing.Size(563, 224)
        Me.DGVMasterBarang.TabIndex = 38
        Me.DGVMasterBarang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGVMasterBarang.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGVMasterBarang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGVMasterBarang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGVMasterBarang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGVMasterBarang.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGVMasterBarang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVMasterBarang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVMasterBarang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVMasterBarang.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVMasterBarang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGVMasterBarang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGVMasterBarang.ThemeStyle.HeaderStyle.Height = 15
        Me.DGVMasterBarang.ThemeStyle.ReadOnly = False
        Me.DGVMasterBarang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGVMasterBarang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVMasterBarang.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVMasterBarang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGVMasterBarang.ThemeStyle.RowsStyle.Height = 22
        Me.DGVMasterBarang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVMasterBarang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'id_barang
        '
        Me.id_barang.HeaderText = "ID Barang"
        Me.id_barang.MinimumWidth = 8
        Me.id_barang.Name = "id_barang"
        '
        'nama_barang
        '
        Me.nama_barang.HeaderText = "Nama Barang"
        Me.nama_barang.MinimumWidth = 8
        Me.nama_barang.Name = "nama_barang"
        '
        'harga
        '
        Me.harga.HeaderText = "Harga"
        Me.harga.MinimumWidth = 8
        Me.harga.Name = "harga"
        '
        'stock
        '
        Me.stock.HeaderText = "Stock"
        Me.stock.MinimumWidth = 8
        Me.stock.Name = "stock"
        '
        'btHapus
        '
        Me.btHapus.HeaderText = ""
        Me.btHapus.MinimumWidth = 8
        Me.btHapus.Name = "btHapus"
        Me.btHapus.Text = "HAPUS"
        Me.btHapus.UseColumnTextForButtonValue = True
        '
        'btUbah
        '
        Me.btUbah.HeaderText = ""
        Me.btUbah.MinimumWidth = 8
        Me.btUbah.Name = "btUbah"
        Me.btUbah.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.btUbah.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.btUbah.Text = "UBAH"
        Me.btUbah.UseColumnTextForButtonValue = True
        '
        'rbMinuman
        '
        Me.rbMinuman.AutoSize = True
        Me.rbMinuman.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbMinuman.CheckedState.BorderThickness = 0
        Me.rbMinuman.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbMinuman.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbMinuman.CheckedState.InnerOffset = -4
        Me.Transisi.SetDecoration(Me.rbMinuman, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.rbMinuman.Location = New System.Drawing.Point(128, 111)
        Me.rbMinuman.Name = "rbMinuman"
        Me.rbMinuman.Size = New System.Drawing.Size(68, 17)
        Me.rbMinuman.TabIndex = 37
        Me.rbMinuman.Text = "Minuman"
        Me.rbMinuman.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbMinuman.UncheckedState.BorderThickness = 2
        Me.rbMinuman.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rbMinuman.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rbMakanan
        '
        Me.rbMakanan.AutoSize = True
        Me.rbMakanan.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbMakanan.CheckedState.BorderThickness = 0
        Me.rbMakanan.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbMakanan.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbMakanan.CheckedState.InnerOffset = -4
        Me.Transisi.SetDecoration(Me.rbMakanan, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.rbMakanan.Location = New System.Drawing.Point(52, 111)
        Me.rbMakanan.Name = "rbMakanan"
        Me.rbMakanan.Size = New System.Drawing.Size(70, 17)
        Me.rbMakanan.TabIndex = 36
        Me.rbMakanan.Text = "Makanan"
        Me.rbMakanan.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbMakanan.UncheckedState.BorderThickness = 2
        Me.rbMakanan.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rbMakanan.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'btUpdate
        '
        Me.btUpdate.BorderRadius = 8
        Me.btUpdate.BorderThickness = 1
        Me.Transisi.SetDecoration(Me.btUpdate, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btUpdate.ForeColor = System.Drawing.Color.White
        Me.btUpdate.Location = New System.Drawing.Point(522, 113)
        Me.btUpdate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btUpdate.Name = "btUpdate"
        Me.btUpdate.Size = New System.Drawing.Size(81, 29)
        Me.btUpdate.TabIndex = 34
        Me.btUpdate.Text = "Update"
        '
        'btSimpan
        '
        Me.btSimpan.BorderRadius = 8
        Me.btSimpan.BorderThickness = 1
        Me.Transisi.SetDecoration(Me.btSimpan, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btSimpan.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btSimpan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btSimpan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btSimpan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btSimpan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btSimpan.ForeColor = System.Drawing.Color.White
        Me.btSimpan.Location = New System.Drawing.Point(422, 113)
        Me.btSimpan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btSimpan.Name = "btSimpan"
        Me.btSimpan.Size = New System.Drawing.Size(78, 27)
        Me.btSimpan.TabIndex = 33
        Me.btSimpan.Text = "Simpan"
        '
        'NUD
        '
        Me.NUD.BackColor = System.Drawing.Color.Transparent
        Me.NUD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Transisi.SetDecoration(Me.NUD, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.NUD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD.Location = New System.Drawing.Point(264, 104)
        Me.NUD.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NUD.Name = "NUD"
        Me.NUD.Size = New System.Drawing.Size(71, 27)
        Me.NUD.TabIndex = 32
        '
        'tbxHarga
        '
        Me.tbxHarga.BorderRadius = 8
        Me.tbxHarga.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Transisi.SetDecoration(Me.tbxHarga, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tbxHarga.DefaultText = ""
        Me.tbxHarga.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbxHarga.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbxHarga.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxHarga.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxHarga.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxHarga.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbxHarga.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxHarga.Location = New System.Drawing.Point(452, 67)
        Me.tbxHarga.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxHarga.Name = "tbxHarga"
        Me.tbxHarga.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbxHarga.PlaceholderText = ""
        Me.tbxHarga.SelectedText = ""
        Me.tbxHarga.Size = New System.Drawing.Size(151, 22)
        Me.tbxHarga.TabIndex = 29
        '
        'tbxNamaBarang
        '
        Me.tbxNamaBarang.BorderRadius = 8
        Me.tbxNamaBarang.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Transisi.SetDecoration(Me.tbxNamaBarang, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tbxNamaBarang.DefaultText = ""
        Me.tbxNamaBarang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbxNamaBarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbxNamaBarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxNamaBarang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxNamaBarang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxNamaBarang.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbxNamaBarang.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxNamaBarang.Location = New System.Drawing.Point(105, 65)
        Me.tbxNamaBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxNamaBarang.Name = "tbxNamaBarang"
        Me.tbxNamaBarang.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbxNamaBarang.PlaceholderText = ""
        Me.tbxNamaBarang.SelectedText = ""
        Me.tbxNamaBarang.Size = New System.Drawing.Size(213, 22)
        Me.tbxNamaBarang.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Transisi.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label1.Location = New System.Drawing.Point(384, 75)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Harga     Rp"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Transisi.SetDecoration(Me.Guna2HtmlLabel5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(230, 111)
        Me.Guna2HtmlLabel5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(31, 15)
        Me.Guna2HtmlLabel5.TabIndex = 26
        Me.Guna2HtmlLabel5.Text = "Stock"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Transisi.SetDecoration(Me.Guna2HtmlLabel3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(5, 111)
        Me.Guna2HtmlLabel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(27, 15)
        Me.Guna2HtmlLabel3.TabIndex = 25
        Me.Guna2HtmlLabel3.Text = "Jenis"
        '
        'Guna2HtmlLabel10
        '
        Me.Guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent
        Me.Transisi.SetDecoration(Me.Guna2HtmlLabel10, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel10.Location = New System.Drawing.Point(5, 72)
        Me.Guna2HtmlLabel10.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Guna2HtmlLabel10.Name = "Guna2HtmlLabel10"
        Me.Guna2HtmlLabel10.Size = New System.Drawing.Size(93, 15)
        Me.Guna2HtmlLabel10.TabIndex = 24
        Me.Guna2HtmlLabel10.Text = "Nama Barang/Item"
        '
        'PanelMT
        '
        Me.PanelMT.Controls.Add(Me.tbtotal)
        Me.PanelMT.Controls.Add(Me.Guna2HtmlLabel6)
        Me.PanelMT.Controls.Add(Me.Guna2HtmlLabel2)
        Me.PanelMT.Controls.Add(Me.DGVMT)
        Me.Transisi.SetDecoration(Me.PanelMT, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelMT.Location = New System.Drawing.Point(224, 3)
        Me.PanelMT.Name = "PanelMT"
        Me.PanelMT.Size = New System.Drawing.Size(651, 444)
        Me.PanelMT.TabIndex = 31
        '
        'tbtotal
        '
        Me.tbtotal.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbtotal.BorderRadius = 5
        Me.tbtotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Transisi.SetDecoration(Me.tbtotal, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tbtotal.DefaultText = ""
        Me.tbtotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbtotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbtotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbtotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbtotal.FillColor = System.Drawing.Color.Linen
        Me.tbtotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbtotal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbtotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbtotal.Location = New System.Drawing.Point(431, 380)
        Me.tbtotal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbtotal.Name = "tbtotal"
        Me.tbtotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbtotal.PlaceholderText = ""
        Me.tbtotal.ReadOnly = True
        Me.tbtotal.SelectedText = ""
        Me.tbtotal.Size = New System.Drawing.Size(130, 24)
        Me.tbtotal.TabIndex = 26
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Transisi.SetDecoration(Me.Guna2HtmlLabel6, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(333, 389)
        Me.Guna2HtmlLabel6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(86, 15)
        Me.Guna2HtmlLabel6.TabIndex = 25
        Me.Guna2HtmlLabel6.Text = "Total Pemasukan"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Transisi.SetDecoration(Me.Guna2HtmlLabel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Sitka Display", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(217, 16)
        Me.Guna2HtmlLabel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(180, 37)
        Me.Guna2HtmlLabel2.TabIndex = 23
        Me.Guna2HtmlLabel2.Text = "Master Transaksi"
        '
        'DGVMT
        '
        Me.DGVMT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGVMT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.noInvoice, Me.nama, Me.total})
        Me.Transisi.SetDecoration(Me.DGVMT, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DGVMT.Location = New System.Drawing.Point(36, 85)
        Me.DGVMT.Name = "DGVMT"
        Me.DGVMT.RowHeadersWidth = 62
        Me.DGVMT.Size = New System.Drawing.Size(538, 277)
        Me.DGVMT.TabIndex = 24
        '
        'noInvoice
        '
        Me.noInvoice.HeaderText = "No. Invoice"
        Me.noInvoice.MinimumWidth = 8
        Me.noInvoice.Name = "noInvoice"
        Me.noInvoice.Width = 150
        '
        'nama
        '
        Me.nama.HeaderText = "Nama Pembeli"
        Me.nama.MinimumWidth = 8
        Me.nama.Name = "nama"
        Me.nama.Width = 150
        '
        'total
        '
        Me.total.HeaderText = "Total Pembelian"
        Me.total.MinimumWidth = 8
        Me.total.Name = "total"
        Me.total.Width = 130
        '
        'HomepageAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(898, 450)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.PanelMasterB)
        Me.Controls.Add(Me.PanelDT)
        Me.Controls.Add(Me.PanelMT)
        Me.Transisi.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Name = "HomepageAdmin"
        Me.Text = "HomepageAdmin"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDT.ResumeLayout(False)
        Me.PanelDT.PerformLayout()
        CType(Me.dgvDT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMasterB.ResumeLayout(False)
        Me.PanelMasterB.PerformLayout()
        CType(Me.DGVMasterBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMT.ResumeLayout(False)
        Me.PanelMT.PerformLayout()
        CType(Me.DGVMT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Transisi As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ButtonMaterBarang As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbxUser As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents ButtonMasterTransaksi As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PanelDT As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dgvDT As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxTotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbxnoInvoice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbxNamaPem As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PanelMT As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents tbtotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents DGVMT As DataGridView
    Friend WithEvents noInvoice As DataGridViewTextBoxColumn
    Friend WithEvents nama As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PanelMasterB As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btSimpan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents NUD As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents tbxHarga As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbxNamaBarang As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel10 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DGVMasterBarang As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents rbMinuman As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbMakanan As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents nama_item As DataGridViewTextBoxColumn
    Friend WithEvents harga_item As DataGridViewTextBoxColumn
    Friend WithEvents jumlah_item As DataGridViewTextBoxColumn
    Friend WithEvents bayar As DataGridViewTextBoxColumn
    Friend WithEvents kembalian As DataGridViewTextBoxColumn
    Friend WithEvents subtotal_item As DataGridViewTextBoxColumn
    Friend WithEvents id_barang As DataGridViewTextBoxColumn
    Friend WithEvents nama_barang As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents stock As DataGridViewTextBoxColumn
    Friend WithEvents btHapus As DataGridViewButtonColumn
    Friend WithEvents btUbah As DataGridViewButtonColumn
    Friend WithEvents ButtonLaporan As Guna.UI2.WinForms.Guna2Button
End Class
