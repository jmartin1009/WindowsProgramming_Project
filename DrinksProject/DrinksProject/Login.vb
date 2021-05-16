﻿Public Class Login
    Public Property con As New String("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DrinksProjectDB.mdb")
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Project_DLL.connectionCheck(con)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If (tbUsername.Text = "" Or tbPassword.Text = "" Or tbUsername.Text = "Username" Or tbPassword.Text = "Password") Then
            MessageBox.Show("Please enter a username and password.")
            Return
        Else
            Dim sqlString As String = "SELECT User_Type_ID FROM Users WHERE Username = '" & tbUsername.Text & "' AND Password = '" & tbPassword.Text & "' "
            Dim checkLogin As DataTable = Project_DLL.fnQuery(sqlString, con)

            If Not checkLogin.Rows.Count = 0 Then
                If checkLogin.Rows(0).ItemArray.Contains(1) Then
                    MessageBox.Show(tbUsername.Text)
                ElseIf checkLogin.Rows(0).ItemArray.Contains(2) Then
                    MessageBox.Show(tbUsername.Text)
                ElseIf checkLogin.Rows(0).ItemArray.Contains(3) Then
                    MessageBox.Show(tbUsername.Text)
                End If
            Else
                MessageBox.Show("Username or password is invalid. Please try again.")
                tbUsername.Text = ""
                tbPassword.Text = ""
                Me.Refresh()
            End If
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
            Dim sqlString As String = "SELECT Username FROM Users WHERE Username = '" & tbUsername.Text & "' "
            Dim checkLogin As DataTable = Project_DLL.fnQuery(sqlString, con)

            If Not checkLogin.Rows.Count = 0 Then
                If checkLogin.Rows(0).ItemArray.Contains(tbUsername.Text) Then
                    'MessageBox.Show("Pause")
                    Dim changePassword = New ChangePassword
                    changePassword.User = tbUsername.Text
                    Me.Hide()
                    changePassword.Show()
                Else
                    MessageBox.Show("User does not exist, but at line 55")
                End If
            Else
                MessageBox.Show("User does not exist.")
            End If

        End If


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