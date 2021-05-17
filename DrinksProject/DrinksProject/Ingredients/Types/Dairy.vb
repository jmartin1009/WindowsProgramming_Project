Public Class Dairy
    Inherits Ingredient
    Public Sub New(name, portion)
        MyBase.New(name, portion)
    End Sub
    Public Overrides Function AddToDrink()
        Return "A(n) " & Me.portion & " of " & Me.name & " is splashed into the glass"
    End Function
End Class
