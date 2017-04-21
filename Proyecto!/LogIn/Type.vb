Public Class Type
    Private id As Integer
    Private name As String
    Private description As String

    Public Property IdType As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property NameType As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

    Public Property DescriptionType As String
        Get
            Return description
        End Get
        Set(value As String)
            description = value
        End Set
    End Property
End Class
