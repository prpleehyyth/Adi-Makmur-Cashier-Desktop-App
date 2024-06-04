<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Transisi = New Guna.UI2.WinForms.Guna2Transition()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Transisi.SetDecoration(Me.Guna2HtmlLabel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Perpetua Titling MT", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(221, 27)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(3, 2)
        Me.Guna2HtmlLabel1.TabIndex = 2
        '
        'Guna2GradientButton1
        '
        Me.Guna2GradientButton1.BorderRadius = 18
        Me.Guna2GradientButton1.BorderThickness = 2
        Me.Transisi.SetDecoration(Me.Guna2GradientButton1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton1.FillColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Guna2GradientButton1.FillColor2 = System.Drawing.Color.BlanchedAlmond
        Me.Guna2GradientButton1.Font = New System.Drawing.Font("Sitka Small", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GradientButton1.Location = New System.Drawing.Point(449, 257)
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.Size = New System.Drawing.Size(180, 45)
        Me.Guna2GradientButton1.TabIndex = 5
        Me.Guna2GradientButton1.Text = "Mulai"
        '
        'Guna2PictureBox2
        '
        Me.Transisi.SetDecoration(Me.Guna2PictureBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox2.Image = Global.TugasBesar_Kel5.My.Resources.Resources.Wavy_Buddies___Choosing_Food
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(22, 216)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(262, 182)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 1
        Me.Guna2PictureBox2.TabStop = False
        '
        'Guna2PictureBox1
        '
        Me.Transisi.SetDecoration(Me.Guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox1.Image = Global.TugasBesar_Kel5.My.Resources.Resources.The_Little_Things___Business_Planning
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(262, 215)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Transisi.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Courgette", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(334, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(388, 81)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Adi Makmur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Transisi.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(367, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 40)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "CAFE"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2GradientButton1)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Transisi.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Transisi As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
