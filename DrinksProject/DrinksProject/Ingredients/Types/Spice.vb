Public Class Spice
    Inherits Ingredient
    Public Sub New(name, portion)
        MyBase.New(name, portion)
    End Sub
    Public Overrides Function AddToDrink()
        Throw New NotImplementedException()
    End Function
End Class
