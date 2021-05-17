Public Class Admin
    Inherits Person

    Public Sub New(Username)
        MyBase.New(Username)
    End Sub

    Public Overrides Sub ShowScreen()
        Dim form As AdminView = New AdminView()
        form.User = Me
        form.Show()
    End Sub


End Class
