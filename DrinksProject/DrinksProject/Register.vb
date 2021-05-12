Public Class Register
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If (tbUsername.Text = "" Or tbPassword.Text = "" Or tbConfirm.Text = "" Or tbPIN.Text = "") Then
            MessageBox.Show("Please fill out all fields")
        ElseIf (tbPassword.Text <> tbConfirm.Text) Then
            MessageBox.Show("Passwords do not match")
            tbPassword.Clear()
            tbConfirm.Clear()
        Else
            'Check if PIN is only numbers
            'Check if user already exists
            'Add user if not
        End If
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim login = New Login()
        Me.Hide()
        login.Show()
    End Sub

    Private Sub HomeMenu_Click(sender As Object, e As EventArgs) Handles HomeMenu.Click
        Dim login As Login = New Login()
        login.Show()
        Me.Finalize()
    End Sub

    Private Sub ExitMenu_Click(sender As Object, e As EventArgs) Handles ExitMenu.Click
        Application.Exit()
    End Sub
End Class