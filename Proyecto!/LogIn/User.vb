Public Class User
    Private id As Integer
    Private name As String
    Private username As String
    Private password As String
    Private role As Role
    Private email As String

    Public Property EmailUser As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property


    Public Property IdUser As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property NameUser As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

    Public Property UsernameUser As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property

    Public Property PasswordUser As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property

    Public Property RoleUser As Role
        Get
            Return role
        End Get
        Set(value As Role)
            role = value
        End Set
    End Property
End Class
