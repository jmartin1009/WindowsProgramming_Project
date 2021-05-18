Public Class CustomerView
    Public Property con As New String("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DrinksProjectDB.mdb")

    Dim person As Customer
    Public Property User() As Customer
        Get
            Return person
        End Get
        Set(ByVal value As Customer)
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

    Public Sub showDataTable(sqlString As String)
        Dim checkUpdate As DataTable = Project_DLL.fnQuery(sqlString, con)
        DataGridView1.DataSource = checkUpdate
        Me.Refresh()
    End Sub

    Private Sub btnPastOrders_Click(sender As Object, e As EventArgs) Handles btnPastOrders.Click
        'Dim username As String = person.
        showDataTable("SELECT Orders.ID FROM Orders WHERE Customer_ID = (SELECT Users.ID FROM Users WHERE [Username] = '" & person.Username & "' )")

        If (btnDeleteItem.Visible) Then
            btnDeleteItem.Visible = False
            btnAddItem.Visible = False
        End If
        btnPastOrders.Visible = False
        btnViewOrder.Visible = True
        btnOrderDrink.Visible = True
        Me.Refresh()
    End Sub

    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click
        If (dgvDrink.SelectedRows.Count = 0) Then
            MessageBox.Show("Select an ingredient first.")
        Else
            Dim ingredient As Integer = dgvDrink.SelectedRows(0).Index
            dgvDrink.Rows.RemoveAt(ingredient)
            Me.Refresh()
        End If
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If (cbIngredientTypes.SelectedIndex < 0 Or cbPortions.SelectedIndex < 0) Then
            MessageBox.Show("Select an ingredient first.")
        Else
            dgvDrink.Rows.Add(cbIngredientTypes.SelectedValue, (cbPortions.SelectedIndex + 1))
        End If
    End Sub

    Private Sub BartenderView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDeleteItem.Visible = False
        btnAddItem.Visible = False
        btnOrderDrink.Visible = False
        btnViewOrder.Visible = False
        dgvDrink.Visible = False
        dgvDrink.Columns.Add(0, "Ingredient Name")
        dgvDrink.Columns.Add(0, "Portions")

        Me.Text = "" & Me.person.Username & " -- Customer"

        Dim sqlString As String = "SELECT Ingredient_Name FROM Ingredients ORDER BY Ingredient_Type_ID"
        cbIngredientTypes.DataSource = getData(sqlString)
        cbIngredientTypes.DisplayMember = "Ingredient_Name"
        cbIngredientTypes.ValueMember = "Ingredient_Name"

        Me.Refresh()
    End Sub

    Public Function getData(sql As String)
        Dim data As DataTable = Project_DLL.fnQuery(sql, con)
        Return data
    End Function

    Private Sub btnMakeDrink_Click(sender As Object, e As EventArgs) Handles btnOrderDrink.Click
        Dim sql As String = "SELECT [ID] FROM USERS WHERE [Username] = '" & Me.person.Username & "'"
        Dim personIDDT As DataTable = Project_DLL.fnQuery(sql, con)
        Dim personID As Integer = personIDDT.Rows(0).ItemArray(0)
        sql = "INSERT INTO Orders (Customer_ID, Fulfilled) VALUES (" & personID & ", " & False & ")"
        Dim insertCheck As Boolean = Project_DLL.fnInsert(sql, con)
        If Not insertCheck Then
            MessageBox.Show("Order not entered.Please try again")
        Else
            System.Threading.Thread.Sleep(500)
            sql = "SELECT [ID] FROM Orders WHERE Customer_ID = " & personID & " AND Fulfilled = " & False & " ORDER BY [ID] DESC"
            Dim orderDT As DataTable = Project_DLL.fnQuery(sql, con)
            Dim orderID As Integer = orderDT.Rows(0).ItemArray(0)
            For Each ingredient As DataGridViewRow In dgvDrink.Rows
                Dim name As String = ingredient.Cells(0).Value.ToString()
                Dim portions As Integer = ingredient.Cells(1).Value
                sql = "SELECT [ID] FROM Ingredients WHERE Ingredient_Name = '" & name & "'"
                Dim ingredDT As DataTable = Project_DLL.fnQuery(sql, con)
                Dim ingredID As Integer = ingredDT.Rows(0).ItemArray(0)
                sql = "INSERT INTO Orders_Ingredients_Combo (Order_ID, Ingredient_ID, Num_Portions) VALUES (" & orderID & ", " & ingredID & ", " & portions & ")"
                insertCheck = Project_DLL.fnInsert(sql, con)
            Next
            dgvDrink.Rows.Clear()
        End If
    End Sub

    Private Sub cbIngredientTypes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbIngredientTypes.SelectedIndexChanged
        btnDeleteItem.Visible = True
        btnAddItem.Visible = True
        btnOrderDrink.Visible = True
        dgvDrink.Visible = True
    End Sub

    Private Sub btnViewOrder_Click(sender As Object, e As EventArgs) Handles btnViewOrder.Click
        btnPastOrders.Visible = False
        If (DataGridView1.SelectedCells.Count = 0) Then
            MessageBox.Show("Select an order first.")
        Else
            Dim orderId As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
            showDataTable("SELECT Ingredients.Ingredient_Name, Num_Portions, Portion_Types.Portion_Type_Name FROM (Orders_Ingredients_Combo INNER JOIN Ingredients ON  Orders_Ingredients_Combo.Ingredient_ID = Ingredients.ID) INNER JOIN Portion_Types ON Ingredients.Portion_Type_ID = Portion_Types.ID WHERE Orders_Ingredients_Combo.Order_ID = '" & orderId & "'")
            Me.Refresh()
        End If
    End Sub

End Class