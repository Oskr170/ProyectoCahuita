Imports System.Data.SqlClient

Public Class HomeRegularUser
    Dim NewPoint As New System.Drawing.Point
    Dim X, Y As Integer
    Dim rowOfGridview As Integer = 0
    Dim connectionString As String = "Data Source=LOLA\SQLEXPRESS;Initial Catalog=laboratorio;Integrated Security=True;Pooling=False"

    Private Sub pnlPrincipal_Paint(sender As Object, e As PaintEventArgs) Handles pnlPrincipal.Paint

    End Sub

    Private Sub pnlPrincipal_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlPrincipal.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pnlPrincipal_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlPrincipal.MouseMove
        If e.Button = MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Me.Location = NewPoint

        End If
    End Sub

    Private Sub btnAdministrateRequests_Click(sender As Object, e As EventArgs) Handles btnAdministrateRequests.Click
        If pnlUser.Visible = True Then
            pnlUser.Visible = False
        End If

        pnlClassReservation.Size = New Size(665, 592)
        pnlClassReservation.Location = New Point(135, 102)
        pnlClassReservation.Visible = True
        pnlHorarioReservacion.Visible = True

        'aquí conectamos con la base de datos para llenar el DGV de clases
        Dim connection As SqlConnection
        connection = New SqlConnection(connectionString)

        Dim classTable As New DataTable

        Dim commandSelect As New SqlCommand("SELECT * FROM Classroom", connection)
        Dim dataAdapter As New SqlDataAdapter(commandSelect)
        dataAdapter.Fill(classTable)
        dgvClasses.DataSource = classTable
    End Sub
    'Obtenemos el nombre del aula del DGV
    Private Sub dgvClasses_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClasses.CellClick
        rowOfGridview = dgvClasses.CurrentRow.Index
    End Sub

    Public Function GetClassroomDataFromGridView()

        'creamos la instancia de la clase Classroom

        Dim classroom As New Classroom
        classroom.IdClassroom = dgvClasses.Item(0, rowOfGridview).Value
        classroom.NameClassroom = dgvClasses.Item(1, rowOfGridview).Value.ToString
        classroom.DescriptionClassroom = dgvClasses.Item(4, rowOfGridview).Value.ToString
        classroom.TypeClassroom = dgvClasses.Item(2, rowOfGridview).Value.ToString
        classroom.BuildingClassroom = dgvClasses.Item(3, rowOfGridview).Value.ToString

        Return classroom

    End Function

    Public Sub getClassroomName(classroom As Classroom)
        'añadir al valor a insertar a la tabla reservaciones en el nombre del aula
    End Sub

    Private Sub btnSaveReservation_Click(sender As Object, e As EventArgs) Handles btnSaveReservation.Click
        ' insertar el horario





    End Sub

    Private Sub HomeRegularUservb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlUser.Size = New Size(665, 495)
        pnlUser.Location = New Point(135, 102)
        pnlUser.Visible = True
        pnlClassReservation.Visible = False
        pnlHorarioReservacion.Visible = False
    End Sub
End Class