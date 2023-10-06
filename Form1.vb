Imports System.Reflection.Emit

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opacity = 0.95
        CenterToParent()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnFormat_Click(sender As Object, e As EventArgs) Handles btnFormat.Click
        txtGeneralNumber.Text = Format(8972.234, "General Number")
        txtFixedNumber.Text = Format(8972.2, "Fixed")
        txtStandardNumber.Text = Format(6648972.265, "Standard")
        txtCurrency.Text = Format(6648972.265, "Currency")
        txtPercentage.Text = Format(0.556678, "Percent")
    End Sub
End Class
