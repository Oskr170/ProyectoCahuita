Public Class Role
    Private id As Integer
    Private name As String
    Private description As String

    Public Property IdRole As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property NameRole As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

    Public Property DescriptionRole As String
        Get
            Return description
        End Get
        Set(value As String)
            description = value
        End Set
    End Property
End Class
