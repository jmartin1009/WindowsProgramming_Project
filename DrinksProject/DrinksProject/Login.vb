Public Class Login
    Public Property con As New String("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DrinksProjectDB.mdb")
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Project_DLL.connectionCheck(con)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (tbUsername.Text = "" Or tbPassword.Text = "" Or tbUsername.Text = "Username" Or tbPassword.Text = "Password") Then
            MessageBox.Show("Please enter a username and password.")
            Return
        Else
            Dim checkLogin As DataTable = Project_DLL.fnLogin(tbUsername.Text, tbPassword.Text, con)
            If checkLogin.Rows(0).ItemArray.Contains(1) Then
                'ADMIN
            ElseIf checkLogin.Rows(0).ItemArray.Contains(2) Then
                'BARETENDER
            ElseIf checkLogin.Rows(0).ItemArray.Contains(3) Then
                'CUSTOMER
            Else
                'DA DUDE DON'T EXIST, GIVE EM THE BOOT
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
            'Check database for username
            Dim change = New ChangePassword()
            change.User = tbUsername.Text
            Me.Hide()
            change.Show()
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