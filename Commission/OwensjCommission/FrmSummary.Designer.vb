<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSummary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSummary))
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LblTotalSalesOutP = New System.Windows.Forms.Label()
        Me.LblTotalCommissionsOutP = New System.Windows.Forms.Label()
        Me.LblTotalPayOutP = New System.Windows.Forms.Label()
        Me.LblTotalSales = New System.Windows.Forms.Label()
        Me.LblTotalCommission = New System.Windows.Forms.Label()
        Me.LblTotalPay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnClose
        '
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(114, 199)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(74, 27)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'LblTotalSalesOutP
        '
        Me.LblTotalSalesOutP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotalSalesOutP.Location = New System.Drawing.Point(105, 59)
        Me.LblTotalSalesOutP.Name = "LblTotalSalesOutP"
        Me.LblTotalSalesOutP.Size = New System.Drawing.Size(99, 27)
        Me.LblTotalSalesOutP.TabIndex = 1
        '
        'LblTotalCommissionsOutP
        '
        Me.LblTotalCommissionsOutP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotalCommissionsOutP.Location = New System.Drawing.Point(105, 103)
        Me.LblTotalCommissionsOutP.Name = "LblTotalCommissionsOutP"
        Me.LblTotalCommissionsOutP.Size = New System.Drawing.Size(99, 27)
        Me.LblTotalCommissionsOutP.TabIndex = 2
        '
        'LblTotalPayOutP
        '
        Me.LblTotalPayOutP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotalPayOutP.Location = New System.Drawing.Point(105, 145)
        Me.LblTotalPayOutP.Name = "LblTotalPayOutP"
        Me.LblTotalPayOutP.Size = New System.Drawing.Size(98, 25)
        Me.LblTotalPayOutP.TabIndex = 3
        '
        'LblTotalSales
        '
        Me.LblTotalSales.AutoSize = True
        Me.LblTotalSales.Location = New System.Drawing.Point(30, 60)
        Me.LblTotalSales.Name = "LblTotalSales"
        Me.LblTotalSales.Size = New System.Drawing.Size(60, 13)
        Me.LblTotalSales.TabIndex = 4
        Me.LblTotalSales.Text = "Total Sales"
        '
        'LblTotalCommission
        '
        Me.LblTotalCommission.AutoSize = True
        Me.LblTotalCommission.Location = New System.Drawing.Point(10, 104)
        Me.LblTotalCommission.Name = "LblTotalCommission"
        Me.LblTotalCommission.Size = New System.Drawing.Size(89, 13)
        Me.LblTotalCommission.TabIndex = 5
        Me.LblTotalCommission.Text = "Total Commission"
        '
        'LblTotalPay
        '
        Me.LblTotalPay.AutoSize = True
        Me.LblTotalPay.Location = New System.Drawing.Point(30, 146)
        Me.LblTotalPay.Name = "LblTotalPay"
        Me.LblTotalPay.Size = New System.Drawing.Size(52, 13)
        Me.LblTotalPay.TabIndex = 6
        Me.LblTotalPay.Text = "Total Pay"
        '
        'FrmSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(300, 261)
        Me.Controls.Add(Me.LblTotalPay)
        Me.Controls.Add(Me.LblTotalCommission)
        Me.Controls.Add(Me.LblTotalSales)
        Me.Controls.Add(Me.LblTotalPayOutP)
        Me.Controls.Add(Me.LblTotalCommissionsOutP)
        Me.Controls.Add(Me.LblTotalSalesOutP)
        Me.Controls.Add(Me.BtnClose)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSummary"
        Me.Text = "Summary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnClose As Button
    Friend WithEvents LblTotalSalesOutP As Label
    Friend WithEvents LblTotalCommissionsOutP As Label
    Friend WithEvents LblTotalPayOutP As Label
    Friend WithEvents LblTotalSales As Label
    Friend WithEvents LblTotalCommission As Label
    Friend WithEvents LblTotalPay As Label
End Class
