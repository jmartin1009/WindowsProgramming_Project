Public MustInherit Class Ingredient
    Public name As String
    Public portion As String

    Public Sub New(name As String, portion As String)
        Me.name = name
        Me.portion = portion
    End Sub

    Public MustOverride Function AddToDrink()
End Class
