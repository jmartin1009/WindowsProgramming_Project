Public Class BartenderView
    Private Sub HomeMenu_Click(sender As Object, e As EventArgs) Handles HomeMenu.Click
        Dim login As Login = New Login()
        login.Show()
        Me.Finalize()
    End Sub

    Private Sub ExitMenu_Click(sender As Object, e As EventArgs) Handles ExitMenu.Click
        Application.Exit()
    End Sub

    Private Sub btnManageInv_Click(sender As Object, e As EventArgs) Handles btnManageInv.Click
        'Load datagrid view with all usernames and user types
        If (btnDeleteOrder.Visible) Then
            btnDeleteOrder.Visible = False
            btnMakeDrink.Visible = False
        End If
        btnDeleteItem.Visible = True
        btnAddItem.Visible = True
        Me.Refresh()
    End Sub

    Private Sub btnManageOrders_Click(sender As Object, e As EventArgs) Handles btnManageOrders.Click
        If (btnDeleteItem.Visible) Then
            btnDeleteItem.Visible = False
            btnAddItem.Visible = False
        End If
        btnDeleteOrder.Visible = True
        btnMakeDrink.Visible = True
        Me.Refresh()
    End Sub

    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click
        If (DataGridView1.SelectedRows.Count = 0) Then
            MessageBox.Show("Select a user first.")
        Else
            Dim ingredient As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
            'Delete from users/whatever where name = username
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
    End Sub

    Private Sub btnDeleteOrder_Click(sender As Object, e As EventArgs) Handles btnDeleteOrder.Click
        'Remove order row from table where selected
        'Check if order selected
    End Sub

    Private Sub btnMakeDrink_Click(sender As Object, e As EventArgs) Handles btnMakeDrink.Click
        'Remove order from table where selected, output all the fun stuff
    End Sub
End Class