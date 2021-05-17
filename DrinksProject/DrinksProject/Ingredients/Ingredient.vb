Public MustInherit Class Ingredient
    Public name As String
    Public type As String
    Public portion As String

    Public Sub New(name As String, type As String, portion As String)
        Me.name = name
        Me.type = type
        Me.portion = portion
    End Sub

    Public MustOverride Sub AddToDrink()
End Class
