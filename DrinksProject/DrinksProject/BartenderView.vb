Public Class BartenderView
    Public Property con As New String("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DrinksProjectDB.mdb")

    Dim person As Bartender
    Public Property User() As Bartender
        Get
            Return person
        End Get
        Set(ByVal value As Bartender)
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

    Private Sub btnManageInv_Click(sender As Object, e As EventArgs) Handles btnManageInv.Click
        showDataTable("SELECT Ingredient_Name, Ingredient_Type_Name FROM Ingredients INNER JOIN Ingredient_Types ON Ingredients.Ingredient_Type_ID = Ingredient_Types.ID")

        'Load datagrid view with all usernames and user types
        If (btnDeleteOrder.Visible) Then
            btnDeleteOrder.Visible = False
            btnMakeDrink.Visible = False
        End If
        btnDeleteItem.Visible = True
        btnAddItem.Visible = True
        Me.Refresh()
    End Sub

    Public Sub showDataTable(sqlString As String)
        Dim checkUpdate As DataTable = Project_DLL.fnQuery(sqlString, con)
        DataGridView1.DataSource = checkUpdate
        Me.Refresh()
    End Sub

    Private Sub btnManageOrders_Click(sender As Object, e As EventArgs) Handles btnManageOrders.Click
        showDataTable("SELECT ID, Customer_ID FROM Orders WHERE Fulfilled = " & False & " ")

        If (btnDeleteItem.Visible) Then
            btnDeleteItem.Visible = False
            btnAddItem.Visible = False
        End If
        btnDeleteOrder.Visible = True
        btnViewOrder.Visible = True
        Me.Refresh()
    End Sub

    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click
        If (DataGridView1.SelectedCells.Count = 0) Then
            MessageBox.Show("Select an ingredient first.")
        Else
            Dim ingredientName As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
            delete("DELETE FROM Ingredients WHERE Ingredient_Name ='" & ingredientName & "'")
            showDataTable("SELECT Ingredient_Name, Ingredient_Type_Name FROM Ingredients INNER JOIN Ingredient_Types ON Ingredients.Ingredient_Type_ID = Ingredient_Types.ID")
            Me.Refresh()
        End If
    End Sub

    Private Sub delete(sqlString As String)
        Dim checkDelete As Boolean = Project_DLL.fnDelete(sqlString, con)
        If Not checkDelete Then
            MessageBox.Show("Deletion not successful, please try again. ")
        Else
            DataGridView1.DataSource = Nothing
            DataGridView1.Rows.Clear()
            MessageBox.Show("Deletion successful.")
        End If
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        'Open new item form
    End Sub

    Private Sub BartenderView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDeleteItem.Visible = False
        btnAddItem.Visible = False
        btnDeleteOrder.Visible = False
        btnMakeDrink.Visible = False
        btnViewOrder.Visible = False
        Me.Text = "" & Me.person.Username & " -- Bartender"
        Me.Refresh()
    End Sub

    Private Sub btnDeleteOrder_Click(sender As Object, e As EventArgs) Handles btnDeleteOrder.Click
        If (DataGridView1.SelectedCells.Count = 0) Then
            MessageBox.Show("Select an order first.")
        Else
            Dim orderID As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
            delete("DELETE FROM Orders WHERE ID =" & orderID & " ")
            delete("DELETE FROM Orders_Ingredients_Combo WHERE Order_ID ='" & orderID & "'")

            showDataTable("SELECT ID, Customer_ID FROM Orders WHERE Fulfilled = " & False & " ")
            Me.Refresh()
        End If
    End Sub

    Private Sub btnMakeDrink_Click(sender As Object, e As EventArgs) Handles btnMakeDrink.Click
        'Remove order from table where selected, output all the fun stuff
    End Sub

    Private Sub btnViewOrder_Click(sender As Object, e As EventArgs) Handles btnViewOrder.Click
        If (DataGridView1.SelectedCells.Count = 0) Then
            MessageBox.Show("Select an order first.")
        Else
            Dim orderId As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
            showDataTable("SELECT Ingredients.Ingredient_Name, Num_Portions, Portion_Types.Portion_Type_Name FROM (Orders_Ingredients_Combo INNER JOIN Ingredients ON  Orders_Ingredients_Combo.Ingredient_ID = Ingredients.ID) INNER JOIN Portion_Types ON Ingredients.Portion_Type_ID = Portion_Types.ID WHERE Orders_Ingredients_Combo.Order_ID = '" & orderId & "'")
            Me.Refresh()
        End If

        btnDeleteOrder.Visible = False
        btnViewOrder.Visible = False
        btnMakeDrink.Visible = True
        Me.Refresh()
    End Sub
End Class