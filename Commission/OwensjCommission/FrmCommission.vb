'Project: Chapter 7 Menus, Forms, Functions
'Purpose: Week 13 Assignment
'Programmer: Jesse Owens

Option Strict On
Option Explicit On

Public Class FrmCommission

    Public TotalPay As Decimal
    Public TotalSales As Decimal
    Public TotalCommission As Decimal



    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        BtnExit.PerformClick()
    End Sub

    Private Sub FrmCommission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TStsStrip.Text = "Jesse Owens " & Date.Today
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim answer As DialogResult
        answer = MessageBox.Show("Are you sure you want to exit the program?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If answer = System.Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub PayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayToolStripMenuItem.Click

        Dim BasePay As Short
        Dim Quota As Decimal
        Dim CommRate As Decimal

        Dim Pay As Decimal
        Dim Commission As Decimal




        'input

        If TxtBoxSalesPerson.Text = "" Then
            MessageBox.Show("Please enter the name of the sales person.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf TxtBoxSales.Text = "" Then
            MessageBox.Show("Please enter a numerical value greater than zero for the sales.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf IsNumeric(TxtBoxSales.Text) = False Then
            MessageBox.Show("Please enter a numerical value greater than zero for the sales.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf CDec(TxtBoxSales.Text) <= 0 Then
            MessageBox.Show("Please enter a numerical value greater than zero for the sales.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            'processing
            BasePay = 250
            CommRate = CDec(0.15)
            Quota = CDec(TxtBoxSales.Text)

            Commission = CalcPay(Quota, CommRate)
            Pay = BasePay + Commission

            TotalCommission += Commission
            TotalSales += Quota                     'Fix the sales numbers from rounding
            TotalPay += Pay

            'output
            LblPayOutput.Text = Pay.ToString("c")

        End If

    End Sub

    Private Function CalcPay(Q As Decimal, CRate As Decimal) As Decimal
        Dim CommissionReturn As Decimal

        If Q < 1000 Then
            CommissionReturn = 0
        ElseIf Q >= 1000 Then
            CommissionReturn = Q * CRate
        End If

        Return CommissionReturn
    End Function

    Private Sub ClearPersonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearPersonToolStripMenuItem.Click
        BtnClear.PerformClick()
    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click
        Dim answer As DialogResult
        answer = MessageBox.Show("Are you sure you want to clear EVERYTHING?", "Clear Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If answer = System.Windows.Forms.DialogResult.Yes Then
            TotalPay = 0
            TotalSales = 0
            TotalCommission = 0

            ClearPersonToolStripMenuItem.PerformClick()
        End If


    End Sub

    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click
        FrmSummary.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        FrmAbout.ShowDialog()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        If TxtBoxSalesPerson.Text = "" Then
            MessageBox.Show("You must have data to clear before clearing.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf TxtBoxSales.Text = "" Then
            MessageBox.Show("You must have data to clear before clearing.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        TxtBoxSalesPerson.Text = ""
        TxtBoxSales.Text = ""
        LblPayOutput.Text = ""

        TxtBoxSalesPerson.Focus()
    End Sub
End Class
