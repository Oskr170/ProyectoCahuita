Public Class Building
    Private id As Integer
    Private name As String


    Public Property IdBuilding As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property NameBuilding As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property
End Class
