Public Class CustomerView
    Private Sub HomeMenu_Click(sender As Object, e As EventArgs) Handles HomeMenu.Click
        Dim login As Login = New Login()
        login.Show()
        Me.Finalize()
    End Sub

    Private Sub ExitMenu_Click(sender As Object, e As EventArgs) Handles ExitMenu.Click
        Application.Exit()
    End Sub

    Private Sub btnManageOrders_Click(sender As Object, e As EventArgs) Handles btnPastOrders.Click
        If (btnDeleteItem.Visible) Then
            btnDeleteItem.Visible = False
            btnAddItem.Visible = False
        End If
        btnOrderDrink.Visible = True
        Me.Refresh()
    End Sub

    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click
        If (dgvDrink.SelectedRows.Count = 0) Then
            MessageBox.Show("Select an ingredient first.")
        Else
            Dim ingredient As String = dgvDrink.SelectedRows(0).Cells(0).Value.ToString()
        End If
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If (DataGridView1.SelectedRows.Count = 0) Then
            MessageBox.Show("Select an ingredient first.")
        Else
            Dim ingredient As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
        End If
    End Sub

    Private Sub BartenderView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDeleteItem.Visible = False
        btnAddItem.Visible = False
        btnOrderDrink.Visible = False
        dgvDrink.Visible = False
    End Sub

    Private Sub btnMakeDrink_Click(sender As Object, e As EventArgs) Handles btnOrderDrink.Click
        'Remove order from table where selected, output all the fun stuff
    End Sub

    Private Sub cbIngredientTypes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbIngredientTypes.SelectedIndexChanged
        btnDeleteItem.Visible = True
        btnAddItem.Visible = True
        btnOrderDrink.Visible = True
        dgvDrink.Visible = True
    End Sub
End Class