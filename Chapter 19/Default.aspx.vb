Imports System.Math

Partial Class _Default
    Inherits Page

    Protected Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim LoanPayment As Double
        'Use Pmt function to determine payment for 36-month loan
        LoanPayment = Pmt(CDbl(InterestTextBox.Text) / 12, 36, CDbl(AmountTextBox.Text))
        PaymentTextBox.Text = Format(Abs(LoanPayment), "$0.00")

    End Sub
End Class