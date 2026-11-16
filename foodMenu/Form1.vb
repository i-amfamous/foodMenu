Public Class Form1
    Private Sub lblExtraTitle_Click(sender As Object, e As EventArgs) Handles lblExtraTitle.Click

    End Sub

    Private Sub lblMenuTitle_Click(sender As Object, e As EventArgs) Handles lblMenuTitle.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim totalAmount As Double = 0
        Dim discount As Double = 0.3

        If rdoWaakye.Checked Then
            totalAmount += 75
        ElseIf rdoSpaghetti.Checked Then
            totalAmount += 120
        ElseIf rdoBanku.Checked Then
            totalAmount += 55
        Else
            lblFeedBack.Text = "Please choose a meal"
            lblTotal.Text = "0.00"
            Return
        End If

        If chkChicken.Checked Then
            totalAmount += 35.88
        End If

        If chkFanta.Checked Then
            totalAmount += 15
        End If

        If chkMalt.Checked Then
            totalAmount += 20.25
        End If

        If totalAmount >= 130 Then
            totalAmount -= totalAmount * discount
            lblFeedBack.Text = "Thank you for your purchase - 30% discount applied"
        Else
            lblFeedBack.Text = "Thank you for your purchase"
        End If

        lblTotal.Text = totalAmount.ToString("0.00")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
