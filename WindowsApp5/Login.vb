Public Class frmLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtLogin.Text = "lemon" Then
            Me.Hide()
            frmHome.Show()
        Else
            MessageBox.Show("Wrong Password")
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtLogin.TextChanged

    End Sub
End Class
