Public Class NewItem
    Dim previous As Form 'Has to be set in the AdminView form thing
    Public Property con As New String("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DrinksProjectDB.mdb")

    Public Property previousForm() As Form
        Get
            Return previous
        End Get
        Set(ByVal value As Form)
            previous = value
        End Set
    End Property
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If (cbItems.SelectedIndex < 0 Or cbPortion.SelectedIndex < 0 Or tbItem.Text = "Name" Or tbItem.Text = "") Then
            MessageBox.Show("Please fill out all fields")
        Else
            'Check if the item exists already
            'If not
            Dim type As String = cbItems.SelectedValue
            Dim portion As String = cbPortion.SelectedValue
            Dim name As String = tbItem.Text
            Dim sql As String = "SELECT * FROM Ingredients WHERE Ingredient_Name = '" & name & "'"
            Dim itemCheck As DataTable = getData(sql)
            If (itemCheck.Rows.Count > 0) Then
                MessageBox.Show("Ingredient already exists. Please enter a new ingredient")
            Else
                sql = "SELECT [ID] FROM Portion_Types WHERE Portion_Type_Name = '" & portion & "'"
                Dim portionDT As DataTable = getData(sql)
                Dim portionID As Int16 = portionDT.Rows(0).ItemArray(0).ToString()
                sql = "SELECT [ID] FROM Ingredient_Types WHERE Ingredient_Type_Name = '" & type & "'"
                Dim ingredDT As DataTable = getData(sql)
                Dim ingredID As Int16 = ingredDT.Rows(0).ItemArray(0).ToString()
                sql = "INSERT INTO Ingredients (Ingredient_Name, Portion_Type_ID, Ingredient_Type_ID) VALUES ('" & name & "', " & portionID & ", " & ingredID & ")"
                Dim insertCheck As Boolean = Project_DLL.fnInsert(sql, con)
                If insertCheck Then
                    MessageBox.Show("Ingredient successfully added.")
                    tbItem.Text = "Name"
                    Me.Refresh()
                Else
                    MessageBox.Show("Error adding ingredient. Please try again.")
                End If
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

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        previous.Show()
        Me.Finalize()
    End Sub

    Private Sub NewItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sqlString As String = "SELECT Ingredient_Type_Name FROM Ingredient_Types"
        cbItems.DataSource = getData(sqlString)
        cbItems.DisplayMember = "Ingredient_Type_Name"
        cbItems.ValueMember = "Ingredient_Type_Name"
        sqlString = "SELECT Portion_Type_Name FROM Portion_Types"
        cbPortion.DataSource = getData(sqlString)
        cbPortion.DisplayMember = "Portion_Type_Name"
        cbPortion.ValueMember = "Portion_Type_Name"
        Me.Refresh()
    End Sub

    Public Function getData(sql As String)
        Dim data As DataTable = Project_DLL.fnQuery(sql, con)
        Return data
    End Function

    Private Sub cbItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbItems.SelectedIndexChanged

    End Sub
End Class