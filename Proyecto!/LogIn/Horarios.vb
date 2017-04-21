Public Class Horarios

    Private id As Integer
    Private clase As String
    Private motivo As String
    Private horaInicio As String
    Private horaFinal As String
    Private dia As String

    Public Property Id1 As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property Clase1 As String
        Get
            Return clase
        End Get
        Set(value As String)
            clase = value
        End Set
    End Property

    Public Property Motivo1 As String
        Get
            Return motivo
        End Get
        Set(value As String)
            motivo = value
        End Set
    End Property

    Public Property HoraInicio1 As String
        Get
            Return horaInicio
        End Get
        Set(value As String)
            horaInicio = value
        End Set
    End Property

    Public Property HoraFinal1 As String
        Get
            Return horaFinal
        End Get
        Set(value As String)
            horaFinal = value
        End Set
    End Property

    Public Property Dia1 As String
        Get
            Return dia
        End Get
        Set(value As String)
            dia = value
        End Set
    End Property
End Class
