Public Class Bartender
    Inherits Person

    Public Sub New(Username)
        MyBase.New(Username)
    End Sub

    Public Overrides Sub ShowScreen()
        Dim form As BartenderView = New BartenderView()
        form.User = Me
        form.Show()
    End Sub


End Class
