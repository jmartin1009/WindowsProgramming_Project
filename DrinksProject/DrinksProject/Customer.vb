Public Class Customer
    Inherits Person

    Public Sub New(Username)
        MyBase.New(Username)
    End Sub

    Public Overrides Sub ShowScreen()
        Dim form As CustomerView = New CustomerView()
        form.User = Me
        form.Show()
    End Sub


End Class