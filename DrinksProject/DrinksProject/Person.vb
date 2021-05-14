Public MustInherit Class Person

    Public Username As String

    Public Sub New(Username As String)
        Me.Username = Username
    End Sub

    Public MustOverride Sub ShowScreen()

End Class
