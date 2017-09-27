Public Class frmHome

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.Hide()
        frmResult.Show()
        frmResult.txtResult.Text = password2
    End Sub
End Class