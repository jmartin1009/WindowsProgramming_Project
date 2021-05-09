Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (tbUsername.Text = "" Or tbPassword.Text = "" Or tbUsername.Text = "Username" Or tbPassword.Text = "Password") Then
            MessageBox.Show("Please enter a username and password.")
            Return
        End If

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim reg = New Register()
        Me.Hide()
        reg.Show()
    End Sub

    Private Sub btnChangePW_Click(sender As Object, e As EventArgs) Handles btnChangePW.Click
        If (tbUsername.Text = "" Or tbPassword.Text = "" Or tbUsername.Text = "Username") Then
            MessageBox.Show("Please enter a username.")
        Else
            'Check database for username
            Dim change = New ChangePassword()
            change.User = tbUsername.Text
            Me.Hide()
            change.Show()
        End If


    End Sub
End Class