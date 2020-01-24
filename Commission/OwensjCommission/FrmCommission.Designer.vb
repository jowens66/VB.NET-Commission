<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCommission
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCommission))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearPersonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtBoxSalesPerson = New System.Windows.Forms.TextBox()
        Me.TxtBoxSales = New System.Windows.Forms.TextBox()
        Me.LblPayOutput = New System.Windows.Forms.Label()
        Me.LblPay = New System.Windows.Forms.Label()
        Me.LblSalesPerson = New System.Windows.Forms.Label()
        Me.LblSales = New System.Windows.Forms.Label()
        Me.StsStrip = New System.Windows.Forms.StatusStrip()
        Me.TStsStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.MenuStrip.SuspendLayout()
        Me.StsStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PayToolStripMenuItem, Me.SummaryToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem1.Text = "&File"
        '
        'PayToolStripMenuItem
        '
        Me.PayToolStripMenuItem.Name = "PayToolStripMenuItem"
        Me.PayToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.PayToolStripMenuItem.Text = "&Pay"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.SummaryToolStripMenuItem.Text = "&Summary"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearPersonToolStripMenuItem, Me.ClearAllToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'ClearPersonToolStripMenuItem
        '
        Me.ClearPersonToolStripMenuItem.Name = "ClearPersonToolStripMenuItem"
        Me.ClearPersonToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ClearPersonToolStripMenuItem.Text = "C&lear Person"
        '
        'ClearAllToolStripMenuItem
        '
        Me.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem"
        Me.ClearAllToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ClearAllToolStripMenuItem.Text = "Clea&r All"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'TxtBoxSalesPerson
        '
        Me.TxtBoxSalesPerson.Location = New System.Drawing.Point(96, 57)
        Me.TxtBoxSalesPerson.Name = "TxtBoxSalesPerson"
        Me.TxtBoxSalesPerson.Size = New System.Drawing.Size(89, 20)
        Me.TxtBoxSalesPerson.TabIndex = 1
        '
        'TxtBoxSales
        '
        Me.TxtBoxSales.Location = New System.Drawing.Point(96, 92)
        Me.TxtBoxSales.Name = "TxtBoxSales"
        Me.TxtBoxSales.Size = New System.Drawing.Size(89, 20)
        Me.TxtBoxSales.TabIndex = 2
        '
        'LblPayOutput
        '
        Me.LblPayOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblPayOutput.Location = New System.Drawing.Point(97, 130)
        Me.LblPayOutput.Name = "LblPayOutput"
        Me.LblPayOutput.Size = New System.Drawing.Size(89, 21)
        Me.LblPayOutput.TabIndex = 3
        '
        'LblPay
        '
        Me.LblPay.AutoSize = True
        Me.LblPay.Location = New System.Drawing.Point(56, 131)
        Me.LblPay.Name = "LblPay"
        Me.LblPay.Size = New System.Drawing.Size(25, 13)
        Me.LblPay.TabIndex = 4
        Me.LblPay.Text = "Pay"
        '
        'LblSalesPerson
        '
        Me.LblSalesPerson.AutoSize = True
        Me.LblSalesPerson.Location = New System.Drawing.Point(22, 60)
        Me.LblSalesPerson.Name = "LblSalesPerson"
        Me.LblSalesPerson.Size = New System.Drawing.Size(69, 13)
        Me.LblSalesPerson.TabIndex = 5
        Me.LblSalesPerson.Text = "Sales Person"
        '
        'LblSales
        '
        Me.LblSales.AutoSize = True
        Me.LblSales.Location = New System.Drawing.Point(48, 95)
        Me.LblSales.Name = "LblSales"
        Me.LblSales.Size = New System.Drawing.Size(33, 13)
        Me.LblSales.TabIndex = 6
        Me.LblSales.Text = "Sales"
        '
        'StsStrip
        '
        Me.StsStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TStsStrip})
        Me.StsStrip.Location = New System.Drawing.Point(0, 239)
        Me.StsStrip.Name = "StsStrip"
        Me.StsStrip.Size = New System.Drawing.Size(284, 22)
        Me.StsStrip.TabIndex = 7
        Me.StsStrip.Text = "StatusStrip1"
        '
        'TStsStrip
        '
        Me.TStsStrip.Name = "TStsStrip"
        Me.TStsStrip.Size = New System.Drawing.Size(53, 17)
        Me.TStsStrip.Text = "TStsStrip"
        '
        'BtnExit
        '
        Me.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnExit.Location = New System.Drawing.Point(106, 205)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(70, 22)
        Me.BtnExit.TabIndex = 8
        Me.BtnExit.Text = "&Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClear.Location = New System.Drawing.Point(97, 176)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(88, 23)
        Me.BtnClear.TabIndex = 9
        Me.BtnClear.Text = "Clear Person"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'FrmCommission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClear
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.StsStrip)
        Me.Controls.Add(Me.LblSales)
        Me.Controls.Add(Me.LblSalesPerson)
        Me.Controls.Add(Me.LblPay)
        Me.Controls.Add(Me.LblPayOutput)
        Me.Controls.Add(Me.TxtBoxSales)
        Me.Controls.Add(Me.TxtBoxSalesPerson)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "FrmCommission"
        Me.Text = "Commission"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StsStrip.ResumeLayout(False)
        Me.StsStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearPersonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TxtBoxSalesPerson As TextBox
    Friend WithEvents TxtBoxSales As TextBox
    Friend WithEvents LblPayOutput As Label
    Friend WithEvents LblPay As Label
    Friend WithEvents LblSalesPerson As Label
    Friend WithEvents LblSales As Label
    Friend WithEvents StsStrip As StatusStrip
    Friend WithEvents TStsStrip As ToolStripStatusLabel
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnClear As Button
End Class
