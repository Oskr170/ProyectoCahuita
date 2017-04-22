Imports System.Data.SqlClient

Public Class HomeRegularUser

    Dim mensaje As String = ""
    Dim clase As String
    Dim auxiliar As Boolean = True
    Dim horaInicial As New ArrayList()
    Dim horaFinaliza As New ArrayList()
    Dim dia As New ArrayList()

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
        If pnlDeleteReservation.Visible = True Then
            pnlDeleteReservation.Visible = False
        End If
        If pnlViewReservations.Visible = True Then
            pnlViewReservations.Visible = False
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

        cbxDia.Items.Add("Lunes")
        cbxDia.Items.Add("Martes")
        cbxDia.Items.Add("Miercoles")
        cbxDia.Items.Add("Jueves")
        cbxDia.Items.Add("Viernes")
        cbxDia.Items.Add("Sabado")
    End Sub
    'Obtenemos el nombre del aula del DGV
    Private Sub dgvClasses_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClasses.CellClick
        rowOfGridview = dgvClasses.CurrentRow.Index
        getClassroomName(GetClassroomDataFromGridView)
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
        txbClassroomName.Text = classroom.NameClassroom
    End Sub

    Private Sub btnSaveReservation_Click(sender As Object, e As EventArgs)

    End Sub

    Public Function agregarHorario(clase As String, horaI As String, horaF As String, dia As String)
        Dim mensaje As String = ""
        Dim connection As SqlConnection
        Dim command As SqlCommand

        connection = New SqlConnection(connectionString)
        Dim insertQuery As String
        Dim horaInicio As String = tbxHoraInicial.Text
        Dim horaFinal As String = tbxHoraFinal.Text

        If horaInicio.EndsWith("pm") Or horaInicio.EndsWith("am") Or horaFinal.EndsWith("pm") Or horaFinal.EndsWith("am") Then
            Dim startHour As Date
            Dim finalHour As Date
            Try
                Dim startAbleHour As Date = #07:00:00#
                Dim finishAbleHour As Date = #22:00:00#
                startHour = Convert.ToDateTime(horaInicio)
                finalHour = Convert.ToDateTime(horaFinal)
                If ((startHour.TimeOfDay < startAbleHour.TimeOfDay) Or (startHour.TimeOfDay > finishAbleHour.TimeOfDay) Or (finalHour.TimeOfDay < startAbleHour.TimeOfDay) Or (finalHour.TimeOfDay > finishAbleHour.TimeOfDay)) Then
                    MsgBox("El horario de disposicion de clases es de de lunes a sabado de 7:00am a 10:00pm")
                    tbxHoraFinal.Text = ""
                    tbxHoraInicial.Text = ""
                    'Console.WriteLine(startHour.TimeOfDay)
                Else
                    Console.WriteLine(startHour.TimeOfDay)
                    Console.WriteLine(cbxDia.SelectedItem.ToString)
                    Dim comparacion As Integer = DateTime.Compare(startHour, finalHour)
                    If comparacion > 0 Then
                        MsgBox("La hora Inicial no puede ser mayor a la hora Final ")
                        tbxHoraFinal.Text = ""
                        tbxHoraInicial.Text = ""
                    ElseIf comparacion = 0 Then
                        MsgBox("La hora Inicial no puede ser igual a la hora Final ")
                        tbxHoraFinal.Text = ""
                        tbxHoraInicial.Text = ""
                    Else
                        ' Display in 24hr format
                        'lblTiempoLibre.Text = dtTime.ToString("HH:mm")
                        insertQuery = "INSERT INTO Horarios (Clase, Motivo, HoraInicio, HoraFinal, Dia ) VALUES (@clase, @motivo, @horaInicio, @horaFinal, @dia)"
                        command = New SqlCommand(insertQuery, connection)
                        Try

                            'esto es una instancia de la clase User
                            'convierte la clase en un objeto
                            Dim horario = New Horarios
                            horario.Clase1 = txbClassroomName.Text
                            horario.Dia1 = cbxDia.Text
                            horario.Motivo1 = tbxMotivo.Text
                            horario.HoraInicio1 = tbxHoraInicial.Text
                            horario.HoraFinal1 = tbxHoraFinal.Text
                            With command
                                '@clase, @motivo, @horaInicio, @horaFinal, @dia
                                .Parameters.AddWithValue("@clase", horario.Clase1)
                                .Parameters.AddWithValue("@motivo", horario.Motivo1)
                                .Parameters.AddWithValue("@horaInicio", horario.HoraInicio1)
                                .Parameters.AddWithValue("@horaFinal", horario.HoraFinal1)
                                .Parameters.AddWithValue("@dia", horario.Dia1)
                            End With
                            'abrimos conexión
                            connection.Open()
                            'ejecutamos consulta
                            If auxiliar = False Then
                                If horarioOcupado(txbClassroomName.Text, tbxHoraInicial.Text, tbxHoraFinal.Text, cbxDia.Text) = True Then
                                    mensaje = "El aula ya cuenta con una reservación en el periodo de " & horaI & " a " & horaF & " el día " & dia

                                Else
                                    command.ExecuteNonQuery()
                                    mensaje = "El horario fue agregado con exito."
                                End If
                            Else
                                command.ExecuteNonQuery()
                                mensaje = "El horario fue agregado con exito."
                            End If

                        Catch ex As Exception
                            Console.WriteLine(ex.StackTrace)
                            Console.WriteLine(ex.Message)
                            mensaje = "No se pudo agregar el horario. Segundo try catch"
                            tbxHoraInicial.Text = ""
                            tbxHoraFinal.Text = ""
                        Finally
                            command.Dispose()
                            connection.Close()
                        End Try
                    End If
                End If
            Catch ex As Exception
                mensaje = "Alguna de las horas fue ingresada con un formato incorrecto."
                tbxHoraInicial.Text = ""
                tbxHoraFinal.Text = ""
            End Try
        Else
            mensaje = "Alguna de las horas fue ingresada con un formato incorrecto."
            tbxHoraInicial.Text = ""
            tbxHoraFinal.Text = ""
        End If
        Return mensaje
    End Function

    Public Function horarioOcupado(clase As String, horaI As String, horaF As String, dia As String)
        Dim bool As Boolean
        Dim connection As New SqlConnection(connectionString)
        'Dim startHour As Date = Convert.ToDateTime(horaI)
        'Dim finalHour As Date = Convert.ToDateTime(horaF)

        Dim command As SqlCommand =
            New SqlCommand("SELECT Clase, HoraInicio, HoraFinal FROM Horarios WHERE (Clase='" & clase & "' AND Dia='" & dia & "') AND ('" & horaI & "' < HoraFinal AND HoraInicio < '" & horaF & "')", connection)

        Try
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                bool = True
            Else
                bool = False
            End If
        Catch ex As SqlException
            MsgBox(ex.ToString & "¡Vaya un problema surgio, no se pudo verificar si el horario existe!")
        Finally
            command.Dispose()
            connection.Close()
        End Try
        Return bool
    End Function

    Private Sub dgvClassReservations_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClassReservations.CellClick
        rowOfGridview = dgvClassReservations.CurrentRow.Index
        getClassReservation(GetClassReservationDataReservationsFromGridView)
    End Sub

    Public Function GetClassReservationDataReservationsFromGridView()

        'creamos la instancia de la clase Horarios

        Dim horarios As New Horarios
        horarios.Id1 = dgvClassReservations.Item(0, rowOfGridview).Value
        horarios.Clase1 = dgvClassReservations.Item(1, rowOfGridview).Value
        horarios.Motivo1 = dgvClassReservations.Item(2, rowOfGridview).Value
        horarios.HoraInicio1 = dgvClassReservations.Item(3, rowOfGridview).Value
        horarios.HoraFinal1 = dgvClassReservations.Item(4, rowOfGridview).Value
        horarios.Dia1 = dgvClassReservations.Item(5, rowOfGridview).Value

        Return horarios

    End Function

    Public Sub getClassReservation(horarios As Horarios)
        txbClassDelete.Text = horarios.Id1
    End Sub

    Private Sub btnCancelReservation_Click(sender As Object, e As EventArgs) Handles btnCancelReservation.Click
        If pnlUser.Visible = True Then
            pnlUser.Visible = False
        End If
        If pnlClassReservation.Visible = True Then
            pnlClassReservation.Visible = False
        End If
        If pnlViewReservations.Visible = True Then
            pnlViewReservations.Visible = False
        End If


        pnlDeleteReservation.Size = New Size(665, 592)
        pnlDeleteReservation.Location = New Point(135, 102)
        pnlDeleteReservation.Visible = True


        'aquí conectamos con la base de datos para llenar el DGV de clases
        Dim connection As SqlConnection
        connection = New SqlConnection(connectionString)

        Dim classTable As New DataTable

        Dim commandSelect As New SqlCommand("SELECT * FROM Horarios", connection)
        Dim dataAdapter As New SqlDataAdapter(commandSelect)
        dataAdapter.Fill(classTable)
        dgvClassReservations.DataSource = classTable


    End Sub

    Private Sub btnSaveReservation_Click_1(sender As Object, e As EventArgs) Handles btnSaveReservation.Click
        ' insertar la reservacion
        Dim nombreClase As String = ""
        Dim horaInicio As String = ""
        Dim horaFinal As String = ""
        Dim dia As String = ""

        If (txbClassroomName.Text <> "") Then
            nombreClase = txbClassroomName.Text

            If (cbxDia.SelectedIndex <> -1 And tbxMotivo.Text <> "" And tbxHoraInicial.Text <> "" And tbxHoraFinal.Text <> "") Then
                horaInicio = tbxHoraInicial.Text
                horaFinal = tbxHoraFinal.Text
                dia = cbxDia.Text
                mensaje = agregarHorario(clase, horaInicio, horaFinal, dia)
                MsgBox("La reservacion fue agregada " & mensaje)
            Else
                MsgBox("sin embargo no se adjuntaron horarios para el aula.")
            End If
            auxiliar = False
        ElseIf auxiliar = False And (cbxDia.SelectedIndex <> -1 And tbxMotivo.Text <> "" And tbxHoraInicial.Text <> "" And tbxHoraFinal.Text <> "") Then
            mensaje = agregarHorario(clase, tbxHoraInicial.Text, tbxHoraFinal.Text, cbxDia.Text)
            If mensaje <> "" Then
                MsgBox(mensaje)
            End If
        End If
    End Sub

    Private Sub btnDelReservation_Click(sender As Object, e As EventArgs) Handles btnDelReservation.Click
        Dim id As Integer
        id = txbClassDelete.Text
        Dim connection As New SqlConnection(connectionString)
        Dim commandDelete As New SqlCommand("DELETE FROM Horarios WHERE Id = '" & id & "'", connection)

        connection.Open()
        commandDelete.ExecuteNonQuery()
        connection.Close()
        MsgBox("La reservacion ha sido eliminada")
        txbClassDelete.Text = ""

        Dim classTable As New DataTable

        Dim commandSelect As New SqlCommand("SELECT * FROM Horarios", connection)
        Dim dataAdapter As New SqlDataAdapter(commandSelect)
        dataAdapter.Fill(classTable)
        dgvClassReservations.DataSource = classTable
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnViewReservations.Click
        If pnlUser.Visible = True Then
            pnlUser.Visible = False
        End If
        If pnlClassReservation.Visible = True Then
            pnlClassReservation.Visible = False
        End If
        If pnlDeleteReservation.Visible = True Then
            pnlDeleteReservation.Visible = False
        End If



        pnlViewReservations.Size = New Size(665, 592)
        pnlViewReservations.Location = New Point(135, 102)
        pnlViewReservations.Visible = True


        'aquí conectamos con la base de datos para llenar el DGV de clases
        Dim connection As SqlConnection
        connection = New SqlConnection(connectionString)

        Dim classTable As New DataTable

        Dim commandSelect As New SqlCommand("SELECT * FROM Horarios", connection)
        Dim dataAdapter As New SqlDataAdapter(commandSelect)
        dataAdapter.Fill(classTable)
        dgvViewReservations.DataSource = classTable

    End Sub

    Private Sub HomeRegularUservb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlUser.Size = New Size(665, 495)
        pnlUser.Location = New Point(135, 102)
        pnlUser.Visible = True
        pnlClassReservation.Visible = False
        pnlHorarioReservacion.Visible = False
    End Sub
End Class