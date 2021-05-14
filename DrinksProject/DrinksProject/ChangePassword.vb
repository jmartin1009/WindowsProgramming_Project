Public Class ChangePassword

    Dim username As String
    Public Property User() As String
        Get
            Return username
        End Get
        Set(ByVal value As String)
            username = value
        End Set
    End Property

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        If (tbPassword.Text = "" Or tbConfirm.Text = "" Or tbPIN.Text = "") Then
            MessageBox.Show("Please fill out all the fields")
        ElseIf (tbPassword.Text <> tbConfirm.Text) Then
            MessageBox.Show("Passwords do not match")
        Else
            'check if PIN is 4 numbers
            'check if PIN matches, if so, change password
        End If

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim login = New Login()
        Me.Finalize()
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