<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAbout))
        Me.LblVersion = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblAssignment = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblVersion
        '
        Me.LblVersion.AutoSize = True
        Me.LblVersion.BackColor = System.Drawing.Color.Transparent
        Me.LblVersion.Location = New System.Drawing.Point(266, 220)
        Me.LblVersion.Name = "LblVersion"
        Me.LblVersion.Size = New System.Drawing.Size(69, 13)
        Me.LblVersion.TabIndex = 0
        Me.LblVersion.Text = "Version: 1.35"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.BackColor = System.Drawing.Color.Transparent
        Me.LblName.Location = New System.Drawing.Point(203, 242)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(132, 13)
        Me.LblName.TabIndex = 1
        Me.LblName.Text = "Programmer: Jesse Owens"
        '
        'LblAssignment
        '
        Me.LblAssignment.AutoSize = True
        Me.LblAssignment.BackColor = System.Drawing.Color.Transparent
        Me.LblAssignment.Location = New System.Drawing.Point(187, 265)
        Me.LblAssignment.Name = "LblAssignment"
        Me.LblAssignment.Size = New System.Drawing.Size(148, 13)
        Me.LblAssignment.TabIndex = 2
        Me.LblAssignment.Text = "Project: Week 13 Commission"
        '
        'FrmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(353, 308)
        Me.Controls.Add(Me.LblAssignment)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.LblVersion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAbout"
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblVersion As Label
    Friend WithEvents LblName As Label
    Friend WithEvents LblAssignment As Label
End Class
