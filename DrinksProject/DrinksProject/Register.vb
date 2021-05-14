Public Class Register
    Public Property con As New String("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DrinksProjectDB.mdb")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If (tbUsername.Text = "" Or tbPassword.Text = "" Or tbConfirm.Text = "" Or tbPIN.Text = "") Then
            MessageBox.Show("Please fill out all fields")
        ElseIf (tbPassword.Text <> tbConfirm.Text) Then
            MessageBox.Show("Passwords do not match")
            tbPassword.Clear()
            tbConfirm.Clear()
        Else
            Try
                Dim pinInt As Int32 = Convert.ToInt32(tbPIN.Text)
                Dim user_Type_ID As Int32 = 1

                Dim sqlString As String = "SELECT Username FROM Users WHERE Username = '" & tbUsername.Text & "' "
                Dim checkLogin As DataTable = Project_DLL.fnQuery(sqlString, con)

                If checkLogin.Rows.Count = 0 Then

                    sqlString = "INSERT INTO Users ([Username], [Password], [User_Type_ID], [User_Pin]) VALUES ('" & tbUsername.Text & "', '" & tbPassword.Text & "', " & user_Type_ID & ", " & pinInt & ")"
                    Dim userUpdated As Boolean = Project_DLL.fnInsertII(sqlString, con)
                    If userUpdated Then
                        MessageBox.Show("Good")
                    Else
                        MessageBox.Show("Bad")
                    End If
                Else
                    MessageBox.Show("User already exists. Please try again.")
                End If


            Catch ex As Exception
                MessageBox.Show("Error")
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