Public Class NewItem
    Dim previous As AdminView 'Has to be set in the AdminView form thing
    Public Property previousForm() As AdminView
        Get
            Return previous
        End Get
        Set(ByVal value As AdminView)
            previous = value
        End Set
    End Property
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If (cbItems.SelectedIndex < 0 Or cbPortion.SelectedIndex < 0 Or tbItem.Text = "Name" Or tbItem.Text = "") Then
            MessageBox.Show("Please fill out all fields")
        Else
            'Check if the item exists already
            'If not
            Dim type As String = cbItems.SelectedText
            Dim portion As String = cbPortion.SelectedText
            Dim name As String = tbItem.Text
            'Add to ingredients table
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
End Class