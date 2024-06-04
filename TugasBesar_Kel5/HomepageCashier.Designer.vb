<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomepageCashier
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomepageCashier))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnlogout = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonLaporan = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonPembelian = New Guna.UI2.WinForms.Guna2Button()
        Me.tbxUser = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.PanelPembelian = New Guna.UI2.WinForms.Guna2Panel()
        Me.tbxUangBayar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbxUangKembali = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ButtonSelesai = New Guna.UI2.WinForms.Guna2Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbxTotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ButtonHapus = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonTambah = New Guna.UI2.WinForms.Guna2Button()
        Me.RBDebit = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.RBTunai = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbxInvoice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbxJumlah = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbxPilihBarang = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbxNamaPembeli = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DGVPembelian = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.nama_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btRemove = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Transisi = New Guna.UI2.WinForms.Guna2Transition()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPembelian.SuspendLayout()
        CType(Me.DGVPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.btnlogout)
        Me.Guna2Panel1.Controls.Add(Me.ButtonLaporan)
        Me.Guna2Panel1.Controls.Add(Me.ButtonPembelian)
        Me.Guna2Panel1.Controls.Add(Me.tbxUser)
        Me.Guna2Panel1.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Transisi.SetDecoration(Me.Guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(219, 450)
        Me.Guna2Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Transisi.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Sitka Small", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(57, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 28)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "CASHIER"
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
        Me.btnlogout.Location = New System.Drawing.Point(31, 357)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(161, 29)
        Me.btnlogout.TabIndex = 5
        Me.btnlogout.Text = "Logout"
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
        Me.ButtonLaporan.Image = Global.TugasBesar_Kel5.My.Resources.Resources.Picture1
        Me.ButtonLaporan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ButtonLaporan.Location = New System.Drawing.Point(31, 322)
        Me.ButtonLaporan.Name = "ButtonLaporan"
        Me.ButtonLaporan.Size = New System.Drawing.Size(161, 29)
        Me.ButtonLaporan.TabIndex = 4
        Me.ButtonLaporan.Text = "Laporan"
        Me.ButtonLaporan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'ButtonPembelian
        '
        Me.ButtonPembelian.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonPembelian.BorderRadius = 12
        Me.ButtonPembelian.BorderThickness = 1
        Me.ButtonPembelian.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Transisi.SetDecoration(Me.ButtonPembelian, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ButtonPembelian.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ButtonPembelian.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ButtonPembelian.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ButtonPembelian.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ButtonPembelian.FillColor = System.Drawing.Color.Transparent
        Me.ButtonPembelian.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPembelian.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonPembelian.Image = Global.TugasBesar_Kel5.My.Resources.Resources.Picture3
        Me.ButtonPembelian.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ButtonPembelian.Location = New System.Drawing.Point(31, 287)
        Me.ButtonPembelian.Name = "ButtonPembelian"
        Me.ButtonPembelian.Size = New System.Drawing.Size(161, 29)
        Me.ButtonPembelian.TabIndex = 3
        Me.ButtonPembelian.Text = "Pembelian"
        Me.ButtonPembelian.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.Guna2CirclePictureBox1.Image = Global.TugasBesar_Kel5.My.Resources.Resources.WhatsApp_Image_2023_11_12_at_12_36_55_f35d364c
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(25, 60)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(172, 169)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 0
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'PanelPembelian
        '
        Me.PanelPembelian.Controls.Add(Me.tbxUangBayar)
        Me.PanelPembelian.Controls.Add(Me.Label9)
        Me.PanelPembelian.Controls.Add(Me.Label8)
        Me.PanelPembelian.Controls.Add(Me.tbxUangKembali)
        Me.PanelPembelian.Controls.Add(Me.ButtonSelesai)
        Me.PanelPembelian.Controls.Add(Me.Label7)
        Me.PanelPembelian.Controls.Add(Me.tbxTotal)
        Me.PanelPembelian.Controls.Add(Me.ButtonHapus)
        Me.PanelPembelian.Controls.Add(Me.ButtonTambah)
        Me.PanelPembelian.Controls.Add(Me.RBDebit)
        Me.PanelPembelian.Controls.Add(Me.RBTunai)
        Me.PanelPembelian.Controls.Add(Me.Label6)
        Me.PanelPembelian.Controls.Add(Me.tbxInvoice)
        Me.PanelPembelian.Controls.Add(Me.Label4)
        Me.PanelPembelian.Controls.Add(Me.tbxJumlah)
        Me.PanelPembelian.Controls.Add(Me.cbxPilihBarang)
        Me.PanelPembelian.Controls.Add(Me.Label3)
        Me.PanelPembelian.Controls.Add(Me.Label5)
        Me.PanelPembelian.Controls.Add(Me.tbxNamaPembeli)
        Me.PanelPembelian.Controls.Add(Me.Label11)
        Me.PanelPembelian.Controls.Add(Me.DGVPembelian)
        Me.Transisi.SetDecoration(Me.PanelPembelian, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelPembelian.Location = New System.Drawing.Point(222, 0)
        Me.PanelPembelian.Name = "PanelPembelian"
        Me.PanelPembelian.Size = New System.Drawing.Size(573, 450)
        Me.PanelPembelian.TabIndex = 15
        '
        'tbxUangBayar
        '
        Me.tbxUangBayar.BorderRadius = 7
        Me.tbxUangBayar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Transisi.SetDecoration(Me.tbxUangBayar, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tbxUangBayar.DefaultText = ""
        Me.tbxUangBayar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbxUangBayar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbxUangBayar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxUangBayar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxUangBayar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxUangBayar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbxUangBayar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxUangBayar.Location = New System.Drawing.Point(88, 287)
        Me.tbxUangBayar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxUangBayar.Name = "tbxUangBayar"
        Me.tbxUangBayar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbxUangBayar.PlaceholderText = ""
        Me.tbxUangBayar.SelectedText = ""
        Me.tbxUangBayar.Size = New System.Drawing.Size(144, 23)
        Me.tbxUangBayar.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Transisi.SetDecoration(Me.Label9, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label9.Font = New System.Drawing.Font("Sitka Display", 12.0!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(6, 285)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 23)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Uang Bayar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Transisi.SetDecoration(Me.Label8, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label8.Font = New System.Drawing.Font("Sitka Display", 12.0!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(5, 316)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 23)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Kembalian"
        '
        'tbxUangKembali
        '
        Me.tbxUangKembali.BorderRadius = 7
        Me.tbxUangKembali.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Transisi.SetDecoration(Me.tbxUangKembali, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tbxUangKembali.DefaultText = ""
        Me.tbxUangKembali.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbxUangKembali.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbxUangKembali.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxUangKembali.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxUangKembali.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxUangKembali.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbxUangKembali.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxUangKembali.Location = New System.Drawing.Point(88, 316)
        Me.tbxUangKembali.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxUangKembali.Name = "tbxUangKembali"
        Me.tbxUangKembali.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbxUangKembali.PlaceholderText = ""
        Me.tbxUangKembali.ReadOnly = True
        Me.tbxUangKembali.SelectedText = ""
        Me.tbxUangKembali.Size = New System.Drawing.Size(144, 23)
        Me.tbxUangKembali.TabIndex = 23
        '
        'ButtonSelesai
        '
        Me.ButtonSelesai.BorderColor = System.Drawing.Color.DimGray
        Me.ButtonSelesai.BorderRadius = 7
        Me.ButtonSelesai.BorderThickness = 1
        Me.Transisi.SetDecoration(Me.ButtonSelesai, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ButtonSelesai.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ButtonSelesai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ButtonSelesai.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ButtonSelesai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ButtonSelesai.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonSelesai.ForeColor = System.Drawing.Color.White
        Me.ButtonSelesai.Location = New System.Drawing.Point(9, 356)
        Me.ButtonSelesai.Name = "ButtonSelesai"
        Me.ButtonSelesai.Size = New System.Drawing.Size(144, 27)
        Me.ButtonSelesai.TabIndex = 22
        Me.ButtonSelesai.Text = "Selesai"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Transisi.SetDecoration(Me.Label7, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label7.Font = New System.Drawing.Font("Sitka Display", 12.0!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(6, 258)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 23)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Total   Rp. "
        '
        'tbxTotal
        '
        Me.tbxTotal.BorderRadius = 7
        Me.tbxTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Transisi.SetDecoration(Me.tbxTotal, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tbxTotal.DefaultText = ""
        Me.tbxTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbxTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbxTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxTotal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbxTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxTotal.Location = New System.Drawing.Point(88, 258)
        Me.tbxTotal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxTotal.Name = "tbxTotal"
        Me.tbxTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbxTotal.PlaceholderText = ""
        Me.tbxTotal.SelectedText = ""
        Me.tbxTotal.Size = New System.Drawing.Size(144, 23)
        Me.tbxTotal.TabIndex = 20
        '
        'ButtonHapus
        '
        Me.ButtonHapus.BorderColor = System.Drawing.Color.DimGray
        Me.ButtonHapus.BorderRadius = 7
        Me.ButtonHapus.BorderThickness = 1
        Me.Transisi.SetDecoration(Me.ButtonHapus, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ButtonHapus.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ButtonHapus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ButtonHapus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ButtonHapus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ButtonHapus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonHapus.ForeColor = System.Drawing.Color.White
        Me.ButtonHapus.Location = New System.Drawing.Point(146, 216)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(103, 27)
        Me.ButtonHapus.TabIndex = 19
        Me.ButtonHapus.Text = "Hapus"
        '
        'ButtonTambah
        '
        Me.ButtonTambah.BorderColor = System.Drawing.Color.DimGray
        Me.ButtonTambah.BorderRadius = 7
        Me.ButtonTambah.BorderThickness = 1
        Me.Transisi.SetDecoration(Me.ButtonTambah, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ButtonTambah.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ButtonTambah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ButtonTambah.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ButtonTambah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ButtonTambah.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonTambah.ForeColor = System.Drawing.Color.White
        Me.ButtonTambah.Location = New System.Drawing.Point(10, 216)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(103, 27)
        Me.ButtonTambah.TabIndex = 18
        Me.ButtonTambah.Text = "Tambah"
        '
        'RBDebit
        '
        Me.RBDebit.AutoSize = True
        Me.RBDebit.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RBDebit.CheckedState.BorderThickness = 0
        Me.RBDebit.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RBDebit.CheckedState.InnerColor = System.Drawing.Color.White
        Me.RBDebit.CheckedState.InnerOffset = -4
        Me.Transisi.SetDecoration(Me.RBDebit, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.RBDebit.Location = New System.Drawing.Point(199, 184)
        Me.RBDebit.Name = "RBDebit"
        Me.RBDebit.Size = New System.Drawing.Size(50, 17)
        Me.RBDebit.TabIndex = 17
        Me.RBDebit.Text = "Debit"
        Me.RBDebit.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RBDebit.UncheckedState.BorderThickness = 2
        Me.RBDebit.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.RBDebit.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'RBTunai
        '
        Me.RBTunai.AutoSize = True
        Me.RBTunai.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RBTunai.CheckedState.BorderThickness = 0
        Me.RBTunai.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RBTunai.CheckedState.InnerColor = System.Drawing.Color.White
        Me.RBTunai.CheckedState.InnerOffset = -4
        Me.Transisi.SetDecoration(Me.RBTunai, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.RBTunai.Location = New System.Drawing.Point(141, 184)
        Me.RBTunai.Name = "RBTunai"
        Me.RBTunai.Size = New System.Drawing.Size(52, 17)
        Me.RBTunai.TabIndex = 16
        Me.RBTunai.Text = "Tunai"
        Me.RBTunai.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RBTunai.UncheckedState.BorderThickness = 2
        Me.RBTunai.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.RBTunai.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Transisi.SetDecoration(Me.Label6, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label6.Font = New System.Drawing.Font("Sitka Display", 12.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(9, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 23)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Jenis Pembayaran"
        '
        'tbxInvoice
        '
        Me.tbxInvoice.BorderRadius = 7
        Me.tbxInvoice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Transisi.SetDecoration(Me.tbxInvoice, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tbxInvoice.DefaultText = ""
        Me.tbxInvoice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbxInvoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbxInvoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxInvoice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxInvoice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxInvoice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbxInvoice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxInvoice.Location = New System.Drawing.Point(146, 47)
        Me.tbxInvoice.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxInvoice.Name = "tbxInvoice"
        Me.tbxInvoice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbxInvoice.PlaceholderText = ""
        Me.tbxInvoice.SelectedText = ""
        Me.tbxInvoice.Size = New System.Drawing.Size(127, 23)
        Me.tbxInvoice.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Transisi.SetDecoration(Me.Label4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Sitka Display", 12.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(9, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 23)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Jumlah"
        '
        'tbxJumlah
        '
        Me.tbxJumlah.BorderRadius = 7
        Me.tbxJumlah.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Transisi.SetDecoration(Me.tbxJumlah, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tbxJumlah.DefaultText = ""
        Me.tbxJumlah.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbxJumlah.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbxJumlah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxJumlah.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxJumlah.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxJumlah.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbxJumlah.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxJumlah.Location = New System.Drawing.Point(117, 152)
        Me.tbxJumlah.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxJumlah.Name = "tbxJumlah"
        Me.tbxJumlah.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbxJumlah.PlaceholderText = ""
        Me.tbxJumlah.SelectedText = ""
        Me.tbxJumlah.Size = New System.Drawing.Size(160, 23)
        Me.tbxJumlah.TabIndex = 12
        '
        'cbxPilihBarang
        '
        Me.cbxPilihBarang.BackColor = System.Drawing.Color.Transparent
        Me.cbxPilihBarang.BorderRadius = 7
        Me.Transisi.SetDecoration(Me.cbxPilihBarang, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.cbxPilihBarang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxPilihBarang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPilihBarang.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxPilihBarang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxPilihBarang.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbxPilihBarang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbxPilihBarang.ItemHeight = 19
        Me.cbxPilihBarang.Location = New System.Drawing.Point(117, 121)
        Me.cbxPilihBarang.Name = "cbxPilihBarang"
        Me.cbxPilihBarang.Size = New System.Drawing.Size(160, 25)
        Me.cbxPilihBarang.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Transisi.SetDecoration(Me.Label3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Sitka Display", 12.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(9, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 23)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Pilih Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Transisi.SetDecoration(Me.Label5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Sitka Display", 12.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(9, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Nama Pembeli"
        '
        'tbxNamaPembeli
        '
        Me.tbxNamaPembeli.BorderRadius = 7
        Me.tbxNamaPembeli.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Transisi.SetDecoration(Me.tbxNamaPembeli, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tbxNamaPembeli.DefaultText = ""
        Me.tbxNamaPembeli.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbxNamaPembeli.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbxNamaPembeli.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxNamaPembeli.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxNamaPembeli.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxNamaPembeli.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbxNamaPembeli.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxNamaPembeli.Location = New System.Drawing.Point(117, 92)
        Me.tbxNamaPembeli.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxNamaPembeli.Name = "tbxNamaPembeli"
        Me.tbxNamaPembeli.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbxNamaPembeli.PlaceholderText = ""
        Me.tbxNamaPembeli.SelectedText = ""
        Me.tbxNamaPembeli.Size = New System.Drawing.Size(160, 23)
        Me.tbxNamaPembeli.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Transisi.SetDecoration(Me.Label11, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label11.Font = New System.Drawing.Font("Sitka Small", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(8, 42)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(137, 28)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "PEMBELIAN"
        '
        'DGVPembelian
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DGVPembelian.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVPembelian.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVPembelian.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVPembelian.ColumnHeadersHeight = 28
        Me.DGVPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGVPembelian.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nama_item, Me.harga, Me.jumlah, Me.subtotal, Me.btRemove})
        Me.Transisi.SetDecoration(Me.DGVPembelian, Guna.UI2.AnimatorNS.DecorationType.None)
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVPembelian.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVPembelian.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVPembelian.Location = New System.Drawing.Point(284, 22)
        Me.DGVPembelian.Name = "DGVPembelian"
        Me.DGVPembelian.RowHeadersVisible = False
        Me.DGVPembelian.RowHeadersWidth = 62
        Me.DGVPembelian.Size = New System.Drawing.Size(282, 381)
        Me.DGVPembelian.TabIndex = 0
        Me.DGVPembelian.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGVPembelian.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGVPembelian.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGVPembelian.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGVPembelian.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGVPembelian.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGVPembelian.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVPembelian.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVPembelian.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVPembelian.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVPembelian.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGVPembelian.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGVPembelian.ThemeStyle.HeaderStyle.Height = 28
        Me.DGVPembelian.ThemeStyle.ReadOnly = False
        Me.DGVPembelian.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGVPembelian.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVPembelian.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVPembelian.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGVPembelian.ThemeStyle.RowsStyle.Height = 22
        Me.DGVPembelian.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVPembelian.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'nama_item
        '
        Me.nama_item.HeaderText = "Nama Barang"
        Me.nama_item.MinimumWidth = 8
        Me.nama_item.Name = "nama_item"
        '
        'harga
        '
        Me.harga.HeaderText = "Harga"
        Me.harga.MinimumWidth = 8
        Me.harga.Name = "harga"
        '
        'jumlah
        '
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.MinimumWidth = 8
        Me.jumlah.Name = "jumlah"
        '
        'subtotal
        '
        Me.subtotal.HeaderText = "Total"
        Me.subtotal.MinimumWidth = 8
        Me.subtotal.Name = "subtotal"
        '
        'btRemove
        '
        Me.btRemove.HeaderText = ""
        Me.btRemove.MinimumWidth = 8
        Me.btRemove.Name = "btRemove"
        Me.btRemove.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.btRemove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.btRemove.Text = "REMOVE"
        Me.btRemove.UseColumnTextForButtonValue = True
        '
        'Transisi
        '
        Me.Transisi.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Scale
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
        Animation1.TransparencyCoeff = 0!
        Me.Transisi.DefaultAnimation = Animation1
        '
        'HomepageCashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelPembelian)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Transisi.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Name = "HomepageCashier"
        Me.Text = "HomepageCashier"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPembelian.ResumeLayout(False)
        Me.PanelPembelian.PerformLayout()
        CType(Me.DGVPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ButtonLaporan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonPembelian As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbxUser As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents btnlogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelPembelian As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents tbxUangBayar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tbxUangKembali As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ButtonSelesai As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label7 As Label
    Friend WithEvents tbxTotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ButtonHapus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonTambah As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents RBDebit As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents RBTunai As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents tbxInvoice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbxJumlah As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbxPilihBarang As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbxNamaPembeli As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DGVPembelian As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Transisi As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents nama_item As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents jumlah As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents btRemove As DataGridViewButtonColumn
End Class
