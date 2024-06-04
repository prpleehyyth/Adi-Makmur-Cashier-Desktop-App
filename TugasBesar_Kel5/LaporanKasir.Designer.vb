<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanKasir
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
        Me.ButtonBack = New Guna.UI2.WinForms.Guna2Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'ButtonBack
        '
        Me.ButtonBack.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonBack.BorderRadius = 12
        Me.ButtonBack.BorderThickness = 1
        Me.ButtonBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ButtonBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ButtonBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ButtonBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ButtonBack.FillColor = System.Drawing.Color.Transparent
        Me.ButtonBack.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonBack.Image = Global.TugasBesar_Kel5.My.Resources.Resources.Picture2
        Me.ButtonBack.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ButtonBack.Location = New System.Drawing.Point(12, 139)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(108, 29)
        Me.ButtonBack.TabIndex = 7
        Me.ButtonBack.Text = "Back"
        Me.ButtonBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Margin = New System.Windows.Forms.Padding(2)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(533, 292)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelWidth = 133
        '
        'LaporanKasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 292)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "LaporanKasir"
        Me.Text = "LaporanKasir"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
