Public Class Classroom
    Private id As Integer
    Private name As String
    Private type As String
    Private building As String
    Private description As String

    Public Property TypeClassroom As String
        Get
            Return type
        End Get
        Set(value As String)
            type = value
        End Set
    End Property


    Public Property IdClassroom As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property NameClassroom As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

    Public Property BuildingClassroom As String
        Get
            Return building
        End Get
        Set(value As String)
            building = value
        End Set
    End Property

    Public Property DescriptionClassroom As String
        Get
            Return description
        End Get
        Set(value As String)
            description = value
        End Set
    End Property
End Class
