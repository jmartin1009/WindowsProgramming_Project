Public Class Beer
    Inherits Ingredient
    Public Sub New(name, type, portion)
        MyBase.New(name, type, portion)
    End Sub
    Public Overrides Sub AddToDrink()
        Throw New NotImplementedException()
    End Sub
End Class
