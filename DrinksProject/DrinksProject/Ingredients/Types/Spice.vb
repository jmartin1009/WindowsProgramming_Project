Public Class Spice
    Inherits Ingredient
    Public Sub New(name, portion)
        MyBase.New(name, portion)
    End Sub
    Public Overrides Function AddToDrink()
        Return "A(n) " & Me.portion & " of " & Me.name & " is sprinkled over the glass"
    End Function
End Class
