<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Transisi = New Guna.UI2.WinForms.Guna2Transition()
        Me.PanelSignUP = New Guna.UI2.WinForms.Guna2Panel()
        Me.ButtonSignUp = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.linkSignIn = New System.Windows.Forms.LinkLabel()
        Me.tbxConfirm = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbxPassword2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbxRoleSU = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.tbxUsernameSU = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PanelSignIn = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.LinkSignUp = New System.Windows.Forms.LinkLabel()
        Me.tbxPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbxUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelSignUP.SuspendLayout()
        Me.PanelSignIn.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'PanelSignUP
        '
        Me.PanelSignUP.BorderColor = System.Drawing.Color.DimGray
        Me.PanelSignUP.BorderRadius = 18
        Me.PanelSignUP.BorderThickness = 1
        Me.PanelSignUP.Controls.Add(Me.ButtonSignUp)
        Me.PanelSignUP.Controls.Add(Me.Guna2HtmlLabel6)
        Me.PanelSignUP.Controls.Add(Me.linkSignIn)
        Me.PanelSignUP.Controls.Add(Me.tbxConfirm)
        Me.PanelSignUP.Controls.Add(Me.tbxPassword2)
        Me.PanelSignUP.Controls.Add(Me.cbxRoleSU)
        Me.PanelSignUP.Controls.Add(Me.tbxUsernameSU)
        Me.PanelSignUP.Controls.Add(Me.Guna2HtmlLabel5)
        Me.PanelSignUP.Controls.Add(Me.Guna2HtmlLabel4)
        Me.PanelSignUP.Controls.Add(Me.Guna2HtmlLabel3)
        Me.PanelSignUP.Controls.Add(Me.Guna2HtmlLabel2)
        Me.PanelSignUP.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Transisi.SetDecoration(Me.PanelSignUP, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelSignUP.Location = New System.Drawing.Point(33, 12)
        Me.PanelSignUP.Name = "PanelSignUP"
        Me.PanelSignUP.Size = New System.Drawing.Size(304, 408)
        Me.PanelSignUP.TabIndex = 0
        '
        'ButtonSignUp
        '
        Me.ButtonSignUp.BorderRadius = 18
        Me.Transisi.SetDecoration(Me.ButtonSignUp, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ButtonSignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ButtonSignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ButtonSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ButtonSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ButtonSignUp.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonSignUp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonSignUp.ForeColor = System.Drawing.Color.White
        Me.ButtonSignUp.Location = New System.Drawing.Point(102, 324)
        Me.ButtonSignUp.Name = "ButtonSignUp"
        Me.ButtonSignUp.Size = New System.Drawing.Size(86, 33)
        Me.ButtonSignUp.TabIndex = 12
        Me.ButtonSignUp.Text = "Sign Up"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Transisi.SetDecoration(Me.Guna2HtmlLabel6, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Perpetua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(79, 379)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(105, 17)
        Me.Guna2HtmlLabel6.TabIndex = 10
        Me.Guna2HtmlLabel6.Text = "Sudah memiliki akun?"
        '
        'linkSignIn
        '
        Me.linkSignIn.AutoSize = True
        Me.Transisi.SetDecoration(Me.linkSignIn, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.linkSignIn.LinkArea = New System.Windows.Forms.LinkArea(0, 7)
        Me.linkSignIn.Location = New System.Drawing.Point(190, 379)
        Me.linkSignIn.Name = "linkSignIn"
        Me.linkSignIn.Size = New System.Drawing.Size(40, 13)
        Me.linkSignIn.TabIndex = 9
        Me.linkSignIn.TabStop = True
        Me.linkSignIn.Text = "Sign In"
        '
        'tbxConfirm
        '
        Me.tbxConfirm.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxConfirm.BorderRadius = 10
        Me.tbxConfirm.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Transisi.SetDecoration(Me.tbxConfirm, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tbxConfirm.DefaultText = ""
        Me.tbxConfirm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbxConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbxConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxConfirm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxConfirm.FillColor = System.Drawing.Color.Snow
        Me.tbxConfirm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxConfirm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbxConfirm.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxConfirm.Location = New System.Drawing.Point(26, 287)
        Me.tbxConfirm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxConfirm.Name = "tbxConfirm"
        Me.tbxConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbxConfirm.PlaceholderText = ""
        Me.tbxConfirm.SelectedText = ""
        Me.tbxConfirm.Size = New System.Drawing.Size(245, 31)
        Me.tbxConfirm.TabIndex = 8
        '
        'tbxPassword2
        '
        Me.tbxPassword2.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxPassword2.BorderRadius = 10
        Me.tbxPassword2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Transisi.SetDecoration(Me.tbxPassword2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tbxPassword2.DefaultText = ""
        Me.tbxPassword2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbxPassword2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbxPassword2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxPassword2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxPassword2.FillColor = System.Drawing.Color.Snow
        Me.tbxPassword2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxPassword2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbxPassword2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxPassword2.Location = New System.Drawing.Point(26, 219)
        Me.tbxPassword2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxPassword2.Name = "tbxPassword2"
        Me.tbxPassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbxPassword2.PlaceholderText = ""
        Me.tbxPassword2.SelectedText = ""
        Me.tbxPassword2.Size = New System.Drawing.Size(245, 31)
        Me.tbxPassword2.TabIndex = 7
        '
        'cbxRoleSU
        '
        Me.cbxRoleSU.BackColor = System.Drawing.Color.Transparent
        Me.cbxRoleSU.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbxRoleSU.BorderRadius = 12
        Me.Transisi.SetDecoration(Me.cbxRoleSU, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.cbxRoleSU.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxRoleSU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRoleSU.FillColor = System.Drawing.Color.Snow
        Me.cbxRoleSU.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxRoleSU.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxRoleSU.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxRoleSU.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbxRoleSU.ItemHeight = 30
        Me.cbxRoleSU.Items.AddRange(New Object() {"Admin", "Cashier", "Owner"})
        Me.cbxRoleSU.Location = New System.Drawing.Point(26, 152)
        Me.cbxRoleSU.Name = "cbxRoleSU"
        Me.cbxRoleSU.Size = New System.Drawing.Size(160, 36)
        Me.cbxRoleSU.TabIndex = 6
        '
        'tbxUsernameSU
        '
        Me.tbxUsernameSU.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxUsernameSU.BorderRadius = 10
        Me.tbxUsernameSU.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Transisi.SetDecoration(Me.tbxUsernameSU, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tbxUsernameSU.DefaultText = ""
        Me.tbxUsernameSU.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbxUsernameSU.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbxUsernameSU.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxUsernameSU.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxUsernameSU.FillColor = System.Drawing.Color.Snow
        Me.tbxUsernameSU.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxUsernameSU.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbxUsernameSU.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxUsernameSU.Location = New System.Drawing.Point(26, 94)
        Me.tbxUsernameSU.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxUsernameSU.Name = "tbxUsernameSU"
        Me.tbxUsernameSU.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbxUsernameSU.PlaceholderText = ""
        Me.tbxUsernameSU.SelectedText = ""
        Me.tbxUsernameSU.Size = New System.Drawing.Size(245, 31)
        Me.tbxUsernameSU.TabIndex = 5
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Transisi.SetDecoration(Me.Guna2HtmlLabel5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(26, 125)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(36, 23)
        Me.Guna2HtmlLabel5.TabIndex = 4
        Me.Guna2HtmlLabel5.Text = "Role" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Transisi.SetDecoration(Me.Guna2HtmlLabel4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(26, 258)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(149, 23)
        Me.Guna2HtmlLabel4.TabIndex = 3
        Me.Guna2HtmlLabel4.Text = "Verifikasi Kata Sandi"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Transisi.SetDecoration(Me.Guna2HtmlLabel3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(26, 190)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(79, 23)
        Me.Guna2HtmlLabel3.TabIndex = 2
        Me.Guna2HtmlLabel3.Text = "Kata Sandi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Transisi.SetDecoration(Me.Guna2HtmlLabel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(26, 65)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(122, 23)
        Me.Guna2HtmlLabel2.TabIndex = 1
        Me.Guna2HtmlLabel2.Text = "Nama Pengguna"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Transisi.SetDecoration(Me.Guna2HtmlLabel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(102, 12)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(115, 37)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "Sign Up"
        '
        'PanelSignIn
        '
        Me.PanelSignIn.BorderColor = System.Drawing.Color.DimGray
        Me.PanelSignIn.BorderRadius = 18
        Me.PanelSignIn.BorderThickness = 1
        Me.PanelSignIn.Controls.Add(Me.Label4)
        Me.PanelSignIn.Controls.Add(Me.Label3)
        Me.PanelSignIn.Controls.Add(Me.Label2)
        Me.PanelSignIn.Controls.Add(Me.Label1)
        Me.PanelSignIn.Controls.Add(Me.ButtonLogin)
        Me.PanelSignIn.Controls.Add(Me.LinkSignUp)
        Me.PanelSignIn.Controls.Add(Me.tbxPassword)
        Me.PanelSignIn.Controls.Add(Me.tbxUsername)
        Me.Transisi.SetDecoration(Me.PanelSignIn, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelSignIn.Location = New System.Drawing.Point(32, 11)
        Me.PanelSignIn.Name = "PanelSignIn"
        Me.PanelSignIn.Size = New System.Drawing.Size(304, 408)
        Me.PanelSignIn.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Transisi.SetDecoration(Me.Label3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Sitka Subheading", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(23, 169)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 23)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Kata Sandi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Transisi.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Sitka Subheading", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(23, 95)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nama Pengguna"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Transisi.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(85, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 35)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Sign In"
        '
        'ButtonLogin
        '
        Me.ButtonLogin.BorderRadius = 18
        Me.Transisi.SetDecoration(Me.ButtonLogin, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ButtonLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ButtonLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ButtonLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ButtonLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ButtonLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonLogin.ForeColor = System.Drawing.Color.White
        Me.ButtonLogin.Location = New System.Drawing.Point(112, 301)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(86, 33)
        Me.ButtonLogin.TabIndex = 11
        Me.ButtonLogin.Text = "Login"
        '
        'LinkSignUp
        '
        Me.LinkSignUp.AutoSize = True
        Me.Transisi.SetDecoration(Me.LinkSignUp, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LinkSignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkSignUp.LinkArea = New System.Windows.Forms.LinkArea(0, 7)
        Me.LinkSignUp.Location = New System.Drawing.Point(191, 351)
        Me.LinkSignUp.Name = "LinkSignUp"
        Me.LinkSignUp.Size = New System.Drawing.Size(56, 16)
        Me.LinkSignUp.TabIndex = 9
        Me.LinkSignUp.TabStop = True
        Me.LinkSignUp.Text = "Sign Up"
        '
        'tbxPassword
        '
        Me.tbxPassword.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxPassword.BorderRadius = 10
        Me.tbxPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Transisi.SetDecoration(Me.tbxPassword, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tbxPassword.DefaultText = ""
        Me.tbxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxPassword.FillColor = System.Drawing.Color.Snow
        Me.tbxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxPassword.Location = New System.Drawing.Point(26, 197)
        Me.tbxPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxPassword.Name = "tbxPassword"
        Me.tbxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxPassword.PlaceholderText = ""
        Me.tbxPassword.SelectedText = ""
        Me.tbxPassword.Size = New System.Drawing.Size(245, 31)
        Me.tbxPassword.TabIndex = 7
        '
        'tbxUsername
        '
        Me.tbxUsername.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbxUsername.BorderRadius = 10
        Me.tbxUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Transisi.SetDecoration(Me.tbxUsername, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tbxUsername.DefaultText = ""
        Me.tbxUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbxUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbxUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxUsername.FillColor = System.Drawing.Color.Snow
        Me.tbxUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbxUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxUsername.Location = New System.Drawing.Point(26, 125)
        Me.tbxUsername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxUsername.Name = "tbxUsername"
        Me.tbxUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbxUsername.PlaceholderText = ""
        Me.tbxUsername.SelectedText = ""
        Me.tbxUsername.Size = New System.Drawing.Size(245, 31)
        Me.tbxUsername.TabIndex = 5
        '
        'Guna2PictureBox1
        '
        Me.Transisi.SetDecoration(Me.Guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox1.Image = Global.TugasBesar_Kel5.My.Resources.Resources.Foodies___Food_Delivery
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(369, 36)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(400, 357)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Transisi.SetDecoration(Me.Label4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Perpetua", 11.25!)
        Me.Label4.Location = New System.Drawing.Point(56, 352)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Belum memiliki akun?"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.PanelSignIn)
        Me.Controls.Add(Me.PanelSignUP)
        Me.Transisi.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Name = "Login"
        Me.Text = "jn"
        Me.PanelSignUP.ResumeLayout(False)
        Me.PanelSignUP.PerformLayout()
        Me.PanelSignIn.ResumeLayout(False)
        Me.PanelSignIn.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Transisi As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents PanelSignUP As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents tbxConfirm As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbxPassword2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbxRoleSU As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents tbxUsernameSU As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents linkSignIn As LinkLabel
    Friend WithEvents PanelSignIn As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LinkSignUp As LinkLabel
    Friend WithEvents tbxPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbxRole As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents tbxUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ButtonLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonSignUp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
End Class
