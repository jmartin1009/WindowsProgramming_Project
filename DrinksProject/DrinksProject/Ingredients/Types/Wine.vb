Public Class Wine
    Inherits Ingredient
    Public Sub New(name, portion)
        MyBase.New(name, portion)
    End Sub
    Public Overrides Function AddToDrink()
        Return "A(n) " & Me.portion & " of " & Me.name & " is slowly cascaded into the glass"
    End Function
End Class
