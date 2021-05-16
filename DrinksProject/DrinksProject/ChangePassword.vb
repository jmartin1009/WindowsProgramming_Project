Public Class ChangePassword
    Public Property con As New String("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DrinksProjectDB.mdb")

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
        ElseIf (tbPIN.Text.Length < 4) Then
            MessageBox.Show("PIN not valid")
        Else
            Dim sqlString As String = "SELECT User_Pin FROM Users WHERE Username = '" & username & "' "
            Dim checkPin As DataTable = Project_DLL.fnQuery(sqlString, con)

            Try
                If Not checkPin.Rows.Count = 0 Then
                    Dim pinInt As Int32 = Convert.ToInt32(tbPIN.Text)
                    If checkPin.Rows(0).ItemArray.Contains(Convert.ToInt32(pinInt)) Then
                        'MessageBox.Show("User and PIN match")

                        sqlString = "UPDATE users SET [Password] = '" & tbPassword.Text & "' WHERE Username = '" & username & "'"
                        Dim check As Boolean = Project_DLL.fnUpdate(sqlString, con)
                        If Not check Then
                            MessageBox.Show("Error resetting password.")
                        Else
                            MessageBox.Show("Password reset successfully.")
                            Dim login = New Login
                            Me.Finalize()
                            login.Show()
                        End If
                    Else
                        MessageBox.Show("PIN does not match the given user. Please try again")
                        tbPassword.Text = ""
                        tbConfirm.Text = ""
                        tbPIN.Text = ""
                        Me.Refresh()
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try


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