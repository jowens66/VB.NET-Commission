Public Class FrmSummary


    Public Sub FrmSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblTotalSalesOutP.Text = FrmCommission.TotalSales.ToString("c")
        LblTotalCommissionsOutP.Text = FrmCommission.TotalCommission.ToString("c")
        LblTotalPayOutP.Text = FrmCommission.TotalPay.ToString("c")
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class