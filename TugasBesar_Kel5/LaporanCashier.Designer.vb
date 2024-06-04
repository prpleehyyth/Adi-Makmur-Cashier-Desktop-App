<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanCashier
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
        Me.CrystalReportKasir = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.PanelLaporan = New Guna.UI2.WinForms.Guna2Panel()
        Me.ButtonKonfirmasi = New Guna.UI2.WinForms.Guna2Button()
        Me.DTPAwal = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PanelLaporan.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportKasir
        '
        Me.CrystalReportKasir.ActiveViewIndex = -1
        Me.CrystalReportKasir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportKasir.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportKasir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportKasir.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportKasir.Name = "CrystalReportKasir"
        Me.CrystalReportKasir.Size = New System.Drawing.Size(800, 450)
        Me.CrystalReportKasir.TabIndex = 0
        '
        'PanelLaporan
        '
        Me.PanelLaporan.Controls.Add(Me.ButtonKonfirmasi)
        Me.PanelLaporan.Controls.Add(Me.DTPAwal)
        Me.PanelLaporan.Controls.Add(Me.Label10)
        Me.PanelLaporan.Location = New System.Drawing.Point(29, 3)
        Me.PanelLaporan.Name = "PanelLaporan"
        Me.PanelLaporan.Size = New System.Drawing.Size(258, 447)
        Me.PanelLaporan.TabIndex = 5
        '
        'ButtonKonfirmasi
        '
        Me.ButtonKonfirmasi.BorderRadius = 10
        Me.ButtonKonfirmasi.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ButtonKonfirmasi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ButtonKonfirmasi.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ButtonKonfirmasi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ButtonKonfirmasi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonKonfirmasi.ForeColor = System.Drawing.Color.White
        Me.ButtonKonfirmasi.Location = New System.Drawing.Point(83, 293)
        Me.ButtonKonfirmasi.Name = "ButtonKonfirmasi"
        Me.ButtonKonfirmasi.Size = New System.Drawing.Size(115, 45)
        Me.ButtonKonfirmasi.TabIndex = 14
        Me.ButtonKonfirmasi.Text = "Konfirmasi"
        '
        'DTPAwal
        '
        Me.DTPAwal.BorderRadius = 7
        Me.DTPAwal.BorderThickness = 1
        Me.DTPAwal.Checked = True
        Me.DTPAwal.FillColor = System.Drawing.Color.SeaShell
        Me.DTPAwal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DTPAwal.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DTPAwal.Location = New System.Drawing.Point(32, 161)
        Me.DTPAwal.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DTPAwal.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DTPAwal.Name = "DTPAwal"
        Me.DTPAwal.Size = New System.Drawing.Size(200, 36)
        Me.DTPAwal.TabIndex = 13
        Me.DTPAwal.Value = New Date(2023, 12, 12, 23, 17, 53, 15)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Sitka Small", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(78, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 28)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "LAPORAN"
        '
        'LaporanCashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelLaporan)
        Me.Controls.Add(Me.CrystalReportKasir)
        Me.Name = "LaporanCashier"
        Me.Text = "LaporanCashier"
        Me.PanelLaporan.ResumeLayout(False)
        Me.PanelLaporan.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportKasir As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents PanelLaporan As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ButtonKonfirmasi As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DTPAwal As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label10 As Label
End Class
