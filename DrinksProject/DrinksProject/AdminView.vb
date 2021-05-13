Public Class AdminView

    Private Sub HomeMenu_Click(sender As Object, e As EventArgs) Handles HomeMenu.Click
        Dim login As Login = New Login()
        login.Show()
        Me.Finalize()
    End Sub

    Private Sub ExitMenu_Click(sender As Object, e As EventArgs) Handles ExitMenu.Click
        Application.Exit()
    End Sub

    Private Sub btnManageUsers_Click(sender As Object, e As EventArgs) Handles btnManageUsers.Click
        'If others.visible, set them to false
        'Load datagrid view with all usernames and user types
        btnDeleteUser.Visible = True
        btnChangeType.Visible = True
        rbCustomer.Visible = True
        rbBartender.Visible = True
        rbAdmin.Visible = True
    End Sub

    Private Sub btnManageIngredients_Click(sender As Object, e As EventArgs) Handles btnManageIngredients.Click

    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        If (DataGridView1.SelectedRows.Count = 0) Then
            MessageBox.Show("Select a user first.")
        Else
            Dim username As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
            'Delete from users/whatever where name = username
        End If
    End Sub

    Private Sub btnChangeType_Click(sender As Object, e As EventArgs) Handles btnChangeType.Click
        If (rbAdmin.Checked) Then
            'update user type where
            Dim username As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
        ElseIf (rbBartender.Checked) Then
            Dim username As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
        ElseIf (rbCustomer.Checked) Then
            Dim username As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
        Else
            MessageBox.Show("Please select a role for the user to be changed to.")
        End If
    End Sub

    Private Sub AdminView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDeleteUser.Visible = False
        btnChangeType.Visible = False
        rbCustomer.Visible = False
        rbBartender.Visible = False
        rbAdmin.Visible = False
    End Sub
End Class