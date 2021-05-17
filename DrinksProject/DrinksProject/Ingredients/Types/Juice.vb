Public Class Juice
    Inherits Ingredient
    Public Sub New(name, portion)
        MyBase.New(name, portion)
    End Sub
    Public Overrides Function AddToDrink()
        Return "A(n) " & Me.portion & " of " & Me.name & " is flowed into the glass"
    End Function
End Class
