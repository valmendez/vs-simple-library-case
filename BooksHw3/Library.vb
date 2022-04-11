Public Class Library
    Private Sub btnFindBook_Click(sender As Object, e As EventArgs) Handles btnFindBook.Click

        Dim CallNumber As Integer

        CallNumber = CInt(txtCallNumber.Text)

        Select Case CallNumber
            Case 100 To 199
                txtResult.Text = "basement"
            Case 200 To 500, Is > 900            '200 to 500 and over 900
                txtResult.Text = "main floor"
            Case 501 To 699, 751 To 900           '501 to 900 except 700 to 750
                txtResult.Text = "upper floor"
            Case 700 To 750
                txtResult.Text = "archives"
        End Select
    End Sub
End Class
