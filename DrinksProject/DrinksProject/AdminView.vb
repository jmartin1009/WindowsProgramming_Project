Public Class AdminView
    Public Property con As New String("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DrinksProjectDB.mdb")

    Dim person As Admin
    Public Property User() As Admin
        Get
            Return person
        End Get
        Set(ByVal value As Admin)
            person = value
        End Set
    End Property

    Private Sub HomeMenu_Click(sender As Object, e As EventArgs) Handles HomeMenu.Click
        Dim login As Login = New Login()
        login.Show()
        Me.Finalize()
    End Sub

    Private Sub ExitMenu_Click(sender As Object, e As EventArgs) Handles ExitMenu.Click
        Application.Exit()
    End Sub

    Private Sub btnManageUsers_Click(sender As Object, e As EventArgs) Handles btnManageUsers.Click
        'Load datagrid view with all usernames and user types
        showUsers()

        If (btnAddIngredient.Visible) Then
            btnAddIngredient.Visible = False
            btnDeleteIngredient.Visible = False
        End If
        btnDeleteUser.Visible = True
        btnChangeType.Visible = True
        rbCustomer.Visible = True
        rbBartender.Visible = True
        rbAdmin.Visible = True
        Me.Refresh()
    End Sub

    Public Sub showUsers()
        Dim sqlString As String = "SELECT [Username], User_Type FROM Users INNER JOIN User_Types ON Users.User_Type_ID = User_Types.ID"
        Dim checkUpdate As DataTable = Project_DLL.fnQuery(sqlString, con)
        DataGridView1.DataSource = checkUpdate
    End Sub


    Private Sub btnManageIngredients_Click(sender As Object, e As EventArgs) Handles btnManageIngredients.Click
        'Fill datagridview with data
        If (btnDeleteUser.Visible) Then
            btnDeleteUser.Visible = False
            btnChangeType.Visible = False
            rbCustomer.Visible = False
            rbBartender.Visible = False
            rbAdmin.Visible = False
        End If
        btnAddIngredient.Visible = True
        btnDeleteIngredient.Visible = True
        Me.Refresh()
    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        If (DataGridView1.SelectedCells.Count = 0) Then
            MessageBox.Show("Select a user first.")
        Else
            Dim username As String = DataGridView1.SelectedCells(0).Value.ToString()
            Dim sqlString As String = "DELETE FROM Users WHERE [Username] ='" & username & "'"
            Dim checkDelete As Boolean = Project_DLL.fnDelete(sqlString, con)
            If Not checkDelete Then
                MessageBox.Show("User was not deleted successfully, please try again. ")
            End If
            showUsers()
        End If
    End Sub

    Private Sub btnChangeType_Click(sender As Object, e As EventArgs) Handles btnChangeType.Click
        Dim sqlString As String
        Dim username As String = DataGridView1.SelectedCells(0).Value.ToString()
        If (rbAdmin.Checked) Then
            sqlString = "UPDATE Users SET User_Type_ID = '" & 1 & "' WHERE Username = '" & username & "'"
        ElseIf (rbBartender.Checked) Then
            sqlString = "UPDATE Users SET User_Type_ID = '" & 2 & "' WHERE Username = '" & username & "'"
        ElseIf (rbCustomer.Checked) Then
            sqlString = "UPDATE Users SET User_Type_ID = '" & 3 & "' WHERE Username = '" & username & "'"
        Else
            MessageBox.Show("Please select a role for the user to be changed to.")
        End If

        If Not String.IsNullOrEmpty(sqlString) Then
            Dim check As Boolean = Project_DLL.fnUpdate(sqlString, con)
            If Not check Then
                MessageBox.Show("Error changing user type")
            Else
                MessageBox.Show("User type changed successfully")
                showUsers()
            End If
        End If
    End Sub

    Private Sub AdminView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'BUTTONS ARE ON TOP OF EACHOTHER, MOVE TOP BUTTONS TO FIND ONES BELOW
        btnDeleteUser.Visible = False
        btnChangeType.Visible = False
        rbCustomer.Visible = False
        rbBartender.Visible = False
        rbAdmin.Visible = False
        btnAddIngredient.Visible = False
        btnDeleteIngredient.Visible = False
        Me.Text = "" & Me.person.Username & " -- Admin"
        Me.Refresh()
    End Sub

    Private Sub btnAddIngredient_Click(sender As Object, e As EventArgs) Handles btnAddIngredient.Click

    End Sub

    Private Sub btnDeleteIngredient_Click(sender As Object, e As EventArgs) Handles btnDeleteIngredient.Click

    End Sub
End Class