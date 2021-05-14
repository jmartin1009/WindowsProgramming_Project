Public Class Customer
    Inherits Person

    Public Sub New(Username)
        MyBase.New(Username)
    End Sub

    Public Overrides Sub ShowScreen()
        Throw New NotImplementedException()
    End Sub


End Class