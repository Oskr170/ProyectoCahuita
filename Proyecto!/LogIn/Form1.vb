Imports System.Data.SqlClient

Public Class Form1
    Dim nameUser As String
    Dim userName As String
    Dim userRole As String

    Dim NewPoint As New System.Drawing.Point
    Dim X, Y As Integer
    Dim connectionString As String = "Data Source=LOLA\SQLEXPRESS;Initial Catalog=laboratorio;Integrated Security=True;Pooling=False"

    Public Sub Login()
        'This does the connection with the database
        'Esto realiza la conexión con la base de datos
        Dim connection As New SqlConnection(connectionString)
        Dim username As String = tbxUserName.Text
        Dim password As String = tbxUserPassword.Text
        Dim command As SqlCommand =
        New SqlCommand("SELECT U.Name, U.Username, U.Password, R.Name FROM Users U, Roles R WHERE U.Id_Role = R.Id And U.Username='" & username & "' AND U.Password='" & password & "'", connection)

        connection.Open()

        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            'si la consulta genero datos el usuario existe
            reader.Read()
            Dim name As String
            Dim roleName As String
            name = reader.GetString(0)
            roleName = reader.GetString(3)

            nameUser = name
            userName = reader.GetString(1)
            userRole = roleName


            If roleName.Equals("Administrador") Then
                'Opens Administrator User Form
                Home.tbxUserName.Text = nameUser
                Home.tbxUserNickName.Text = userName
                Home.tbxUserRole.Text = userRole
                Home.Show()
                Me.Close()
            ElseIf roleName.Equals("Estudiante") Or roleName.Equals("Profesor") Then
                'Opens Home Regular User Form
                HomeRegularUser.Show()
                HomeRegularUser.tbxUserName.Text = nameUser
                HomeRegularUser.tbxUserNickName.Text = username
                HomeRegularUser.tbxUserRole.Text = userRole
                HomeRegularUser.Show()
                Me.Close()
            End If



        Else

            MsgBox("Los datos ingresados son incorrectos. Intente de nuevo.")
            tbxUserName.ResetText()
            tbxUserPassword.ResetText()
        End If

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcceptButton = btnLogIn
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Me.Location = NewPoint

        End If
    End Sub

    Private Sub lblClose_MouseEnter(sender As Object, e As EventArgs) Handles lblClose.MouseEnter
        lblClose.BackColor = Color.Olive

    End Sub

    Private Sub lblClose_MouseLeave(sender As Object, e As EventArgs) Handles lblClose.MouseLeave
        lblClose.BackColor = Color.SeaGreen
    End Sub

    Private Sub lblMinimize_MouseEnter_1(sender As Object, e As EventArgs) Handles lblMinimize.MouseEnter
        lblMinimize.BackColor = Color.DarkGray
    End Sub

    Private Sub lblMinimize_MouseLeave(sender As Object, e As EventArgs) Handles lblMinimize.MouseLeave
        lblMinimize.BackColor = Color.SeaGreen
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Close()

    End Sub

    Private Sub lblMinimize_Click(sender As Object, e As EventArgs) Handles lblMinimize.Click
        Me.WindowState = FormWindowState.Minimized


    End Sub

    Private Sub btnLogIn_MouseEnter(sender As Object, e As EventArgs) Handles btnLogIn.MouseEnter
        btnLogIn.BackColor = Color.DarkSeaGreen
    End Sub

    Private Sub btnLogIn_MouseLeave(sender As Object, e As EventArgs) Handles btnLogIn.MouseLeave
        btnLogIn.BackColor = Color.SeaGreen
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click

        Login()
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub
End Class
