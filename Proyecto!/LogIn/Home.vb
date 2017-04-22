Imports System.Data.SqlClient

Public Class Home
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

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Me.Location = NewPoint

        End If
    End Sub


    Private Sub btnUserLately_Click(sender As Object, e As EventArgs) Handles btnUserLately.Click
        If pnlAdminstrateUsers.Visible = True Then
            pnlAdminstrateUsers.Visible = False
            pnlCreateUser.Visible = False
            pnlModifyUser.Visible = False
            pnlSearchUser.Visible = False
            pnlDeleteUser.Visible = False
            pnlClassReservation.Visible = False
        End If
        If panelAdminClass.Visible = True Then
            panelAdminClass.Visible = False
            pnlCreateClass.Visible = False
            pnlClassReservation.Visible = False
        End If
        pnlUser.Size = New Size(1500, 1000)
        pnlUser.Location = New Point(135, 102)
        pnlUser.Visible = True
    End Sub

    Private Sub btnUserLately_MouseEnter(sender As Object, e As EventArgs) Handles btnUserLately.MouseEnter
        lblDescripcionBoton.Visible = True

        lblDescripcionBoton.Text = "Mira tu perfil, si ocupas realizar modificaciones puedes hacerlas aca, tambien puedes ver tu actividad reciente."
    End Sub

    Private Sub btnAdmistrateUsers_Click(sender As Object, e As EventArgs) Handles btnAdministrateUsers.Click
        If panelReservations.Visible = True Then
            panelReservations.Visible = False
        End If
        If pnlUser.Visible = True Then
            pnlUser.Visible = False
        End If
        If panelAdminClass.Visible = True Then
            panelAdminClass.Visible = False
        End If
        pnlAdminstrateUsers.Size = New Size(660, 592)
        pnlAdminstrateUsers.Location = New Point(138, 78)
        pnlAdminstrateUsers.Visible = True

        Dim connection As New SqlConnection(connectionString)
        Dim userTable As New DataTable

        Dim commandSelect As New SqlCommand("SELECT U.Id 'ID', U.Name 'Nombre del Usuario', U.Username 'Nickname de Usuario', R.Name 'Rol en el Sistema' FROM Users U, Roles R WHERE U.Id_Role=R.Id", connection)
        Dim dataAdapter As New SqlDataAdapter(commandSelect)
        dataAdapter.Fill(userTable)
        dgvUserAdmin.DataSource = userTable
    End Sub

    Private Sub btnUserLately_MouseLeave(sender As Object, e As EventArgs) Handles btnUserLately.MouseLeave
        lblDescripcionBoton.Visible = False
    End Sub

    Private Sub btnAdmistrateUsers_MouseEnter(sender As Object, e As EventArgs) Handles btnAdministrateUsers.MouseEnter
        lblDescripcionBoton.Visible = True
        lblDescripcionBoton.Text = "Aquí puedes agregar, consultar, modificar y eliminar los usuarios registrados en el sistema."
    End Sub

    Private Sub btnAdmistrateUsers_MouseLeave(sender As Object, e As EventArgs) Handles btnAdministrateUsers.MouseLeave
        lblDescripcionBoton.Visible = False
    End Sub

    Private Sub btnCreateUser_Paint(ByVal sender As Object,
    ByVal e As System.Windows.Forms.PaintEventArgs) Handles btnCreateUser.Paint

        Dim buttonPath As New System.Drawing.Drawing2D.GraphicsPath

        ' Set a new rectangle to the same size as the button's 
        ' ClientRectangle property.
        Dim newRectangle As Rectangle = btnCreateUser.ClientRectangle

        ' Decrease the size of the rectangle.
        newRectangle.Inflate(-12, -12)

        ' Draw the button's border.
        'e.Graphics.DrawEllipse(System.Drawing.Pens.Black, newRectangle)

        'Increase the size of the rectangle to include the border.
        newRectangle.Inflate(1, 1)

        ' Create a circle within the new rectangle.
        buttonPath.AddEllipse(newRectangle)
        e.Graphics.DrawPath(Pens.Transparent, buttonPath)
        ' Set the button's Region property to the newly created 
        ' circle region.
        btnCreateUser.Region = New System.Drawing.Region(buttonPath)

    End Sub

    Private Sub btnModifyUser_Paint(sender As Object, e As PaintEventArgs) Handles btnModifyUser.Paint
        Dim buttonPath As New System.Drawing.Drawing2D.GraphicsPath

        ' Set a new rectangle to the same size as the button's 
        ' ClientRectangle property.
        Dim newRectangle As Rectangle = btnModifyUser.ClientRectangle()

        ' Decrease the size of the rectangle.
        newRectangle.Inflate(-12, -12)

        ' Draw the button's border.
        'e.Graphics.DrawEllipse(System.Drawing.Pens.Black, newRectangle)

        'Increase the size of the rectangle to include the border.
        newRectangle.Inflate(1, 1)

        ' Create a circle within the new rectangle.
        buttonPath.AddEllipse(newRectangle)
        e.Graphics.DrawPath(Pens.Transparent, buttonPath)
        ' Set the button's Region property to the newly created 
        ' circle region.
        btnModifyUser.Region = New System.Drawing.Region(buttonPath)
    End Sub

    Private Sub btnDeleteUser_Paint(sender As Object, e As PaintEventArgs) Handles btnDeleteUser.Paint
        Dim buttonPath As New System.Drawing.Drawing2D.GraphicsPath

        ' Set a new rectangle to the same size as the button's 
        ' ClientRectangle property.
        Dim newRectangle As Rectangle = btnDeleteUser.ClientRectangle()

        ' Decrease the size of the rectangle.
        newRectangle.Inflate(-12, -12)

        ' Draw the button's border.
        'e.Graphics.DrawEllipse(System.Drawing.Pens.Black, newRectangle)

        'Increase the size of the rectangle to include the border.
        newRectangle.Inflate(1, 1)

        ' Create a circle within the new rectangle.
        buttonPath.AddEllipse(newRectangle)
        e.Graphics.DrawPath(Pens.Transparent, buttonPath)
        ' Set the button's Region property to the newly created 
        ' circle region.
        btnDeleteUser.Region = New System.Drawing.Region(buttonPath)
    End Sub

    Private Sub btnSearchUser_Paint(sender As Object, e As PaintEventArgs) Handles btnSearchUser.Paint
        Dim buttonPath As New System.Drawing.Drawing2D.GraphicsPath

        ' Set a new rectangle to the same size as the button's 
        ' ClientRectangle property.
        Dim newRectangle As Rectangle = btnSearchUser.ClientRectangle()

        ' Decrease the size of the rectangle.
        newRectangle.Inflate(-12, -12)

        ' Draw the button's border.
        'e.Graphics.DrawEllipse(System.Drawing.Pens.Black, newRectangle)

        'Increase the size of the rectangle to include the border.
        newRectangle.Inflate(1, 1)

        ' Create a circle within the new rectangle.
        buttonPath.AddEllipse(newRectangle)
        e.Graphics.DrawPath(Pens.Transparent, buttonPath)
        ' Set the button's Region property to the newly created 
        ' circle region.
        btnSearchUser.Region = New System.Drawing.Region(buttonPath)
    End Sub

    Private Sub btnViewUsers_Paint(sender As Object, e As PaintEventArgs) Handles btnViewUsers.Paint
        Dim buttonPath As New System.Drawing.Drawing2D.GraphicsPath

        ' Set a new rectangle to the same size as the button's 
        ' ClientRectangle property.
        Dim newRectangle As Rectangle = btnViewUsers.ClientRectangle()

        ' Decrease the size of the rectangle.
        newRectangle.Inflate(-12, -12)

        ' Draw the button's border.
        'e.Graphics.DrawEllipse(System.Drawing.Pens.Black, newRectangle)

        'Increase the size of the rectangle to include the border.
        newRectangle.Inflate(1, 1)

        ' Create a circle within the new rectangle.
        buttonPath.AddEllipse(newRectangle)
        e.Graphics.DrawPath(Pens.Transparent, buttonPath)
        ' Set the button's Region property to the newly created 
        ' circle region.
        btnViewUsers.Region = New System.Drawing.Region(buttonPath)
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'TODO: esta línea de código carga datos en la tabla 'LaboratoriosDataSet.Roles' Puede moverla o quitarla según sea necesario.
        'Me.RolesTableAdapter.Fill(Me.LaboratoriosDataSet.Roles)

        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim dataSet As New DataSet()

        'Esto significa: traiga el id y el name de todos
        'los roles
        Dim sqlQuery As String
        sqlQuery = "SELECT Id, Name FROM Roles"

        'aquí conectamos con la base de datos
        connection = New SqlConnection(connectionString)

        'abrimos conexión

        connection.Open()

        'ejecutamos la sentencia SELECT
        command = New SqlCommand(sqlQuery, connection)

        'llenamos el adaptador
        adapter.SelectCommand = command

        adapter.Fill(dataSet)

        adapter.Dispose()
        command.Dispose()
        connection.Close()

        'Mostrar los roles en el combo
        cbxUserRoleCreateUser.DataSource = dataSet.Tables(0)
        cbxUserRoleCreateUser.ValueMember = "Id"
        cbxUserRoleCreateUser.DisplayMember = "Name"

        cbxUserRoleCreateUser.SelectedIndex = -1


        'Mostrar los roles en el combo
        cmbxUserRoleModifyUser.DataSource = dataSet.Tables(0)
        cmbxUserRoleModifyUser.ValueMember = "Id"
        cmbxUserRoleModifyUser.DisplayMember = "Name"

        cmbxUserRoleModifyUser.SelectedIndex = -1


        pnlUser.Size = New Size(665, 495)
        pnlUser.Location = New Point(135, 102)
        pnlUser.Visible = True

        panelAdminClass.Visible = False
        pnlAdminstrateUsers.Visible = False
        panelReservations.Visible = False

    End Sub



    Private Sub btnCreateUser_Click(sender As Object, e As EventArgs) Handles btnCreateUser.Click
        If pnlModifyUser.Visible = True Then
            pnlModifyUser.Visible = False
            pnlModifyUser.Hide()
        End If
        If pnlSearchUser.Visible = True Then
            pnlSearchUser.Visible = False
            pnlSearchUser.Hide()
        End If
        If pnlDeleteUser.Visible = True Then
            pnlDeleteUser.Visible = False
            pnlDeleteUser.Hide()
        End If
        If pnlCreateUser.Visible = False Then
            pnlCreateUser.BringToFront()
            pnlCreateUser.Size = New Size(644, 299)
            pnlCreateUser.Location = New Point(9, 293)
            pnlCreateUser.Show()
            pnlCreateUser.Visible = True
        End If

    End Sub
    Private Sub lblAddCreateUser_Click(sender As Object, e As EventArgs) Handles lblAddCreateUser.Click
        Dim connection As SqlConnection
        Dim command As SqlCommand

        'aquí conectamos con la base de datos
        connection = New SqlConnection(connectionString)

        Dim insertQuery As String
        insertQuery = "INSERT INTO Users (Name, Username, Email, Password, Id_Role) VALUES (@name, @username, @email, @password, @id_role)"

        command = New SqlCommand(insertQuery, connection)
        'esto es una instancia de la clase User
        'convierte la clase en un objeto
        Dim user = New User
        Dim role = New Role


        If tbxUserEmailCreateUser.Text.Equals("") Or tbxUserNameCreateUser.Text.Equals("") Or tbxUserPasswordCreateUser.Text.Equals("") Or tbxUserSystemNameCreateUser.Text.Equals("") Or cbxUserRoleCreateUser.SelectedIndex = -1 Then
            MsgBox("No puedes dejar ningun campo vacio.")

        Else
            Try
                user.NameUser = tbxUserNameCreateUser.Text
                user.UsernameUser = tbxUserSystemNameCreateUser.Text
                user.PasswordUser = tbxUserPasswordCreateUser.Text
                user.EmailUser = tbxUserEmailCreateUser.Text

                'Esto llena el objeto Role con lo seleccionado
                'en el combo roles
                role.IdRole = cbxUserRoleCreateUser.SelectedValue
                role.NameRole = cbxUserRoleCreateUser.Text
                Console.WriteLine(role.NameRole)

                user.RoleUser = role


                With command

                    .Parameters.AddWithValue("@username", user.UsernameUser)
                    .Parameters.AddWithValue("@password", user.PasswordUser)
                    .Parameters.AddWithValue("@id_role", user.RoleUser.IdRole)
                    .Parameters.AddWithValue("@name", user.NameUser)
                    .Parameters.AddWithValue("@email", user.EmailUser)


                End With

                'abrimos conexión
                connection.Open()

                'ejecutamos consulta
                command.ExecuteNonQuery()
                MsgBox("El Usuario fue agregado con exito.")

                command.Dispose()
                connection.Close()

                Dim userTable As New DataTable

                Dim commandSelect As New SqlCommand("SELECT U.Id 'ID', U.Name 'Nombre del Usuario', U.Username 'Nickname de Usuario', R.Name 'Rol en el Sistema' FROM Users U, Roles R WHERE U.Id_Role=R.Id", connection)
                Dim dataAdapter As New SqlDataAdapter(commandSelect)
                dataAdapter.Fill(userTable)
                dgvUserAdmin.DataSource = userTable

            Catch ex As SqlException
                MsgBox("El Usuario no pudo ser agregado, intenta de nuevo.")

            End Try

            tbxUserSystemNameCreateUser.Clear()
            tbxUserPasswordCreateUser.Clear()
            tbxUserNameCreateUser.Clear()
            tbxUserEmailCreateUser.Clear()
            tbxUserNickNameDeleteUser.Clear()
            cbxUserRoleCreateUser.SelectedIndex = -1

        End If

    End Sub

    Private Sub lblCancelCreateUser_Click(sender As Object, e As EventArgs) Handles lblCancelCreateUser.Click
        tbxUserSystemNameCreateUser.Clear()
        tbxUserPasswordCreateUser.Clear()
        tbxUserNameCreateUser.Clear()
        tbxUserEmailCreateUser.Clear()
        tbxUserNickNameDeleteUser.Clear()
        cbxUserRoleCreateUser.SelectedIndex = -1

    End Sub

    Private Sub btnModifyUser_Click(sender As Object, e As EventArgs) Handles btnModifyUser.Click
        If pnlCreateUser.Visible = True Then
            pnlCreateUser.Visible = False
            pnlCreateUser.Hide()
        End If
        If pnlSearchUser.Visible = True Then
            pnlSearchUser.Visible = False
            pnlSearchUser.Hide()
        End If
        If pnlDeleteUser.Visible = True Then
            pnlDeleteUser.Visible = False
            pnlDeleteUser.Hide()
        End If
        If pnlModifyUser.Visible = False Then
            pnlModifyUser.BringToFront()
            pnlModifyUser.Visible = True
            pnlModifyUser.Size = New Size(665, 345)
            pnlModifyUser.Location = New Point(0, 300)
            pnlModifyUser.Show()
            cmbxUserRoleModifyUser.SelectedIndex = -1
        End If
    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        If pnlCreateUser.Visible = True Then
            pnlCreateUser.Visible = False
            pnlCreateUser.Hide()
        End If
        If pnlSearchUser.Visible = True Then
            pnlSearchUser.Visible = False
            pnlSearchUser.Hide()
        End If
        If pnlModifyUser.Visible = True Then
            pnlModifyUser.Visible = False
            pnlModifyUser.Hide()
        End If
        If pnlDeleteUser.Visible = False Then
            pnlDeleteUser.BringToFront()
            pnlDeleteUser.Size = New Size(665, 345)
            pnlDeleteUser.Location = New Point(0, 300)
            pnlDeleteUser.Show()
            pnlDeleteUser.Visible = True
        End If

    End Sub

    Private Sub btnSearchUser_Click(sender As Object, e As EventArgs) Handles btnSearchUser.Click
        If pnlCreateUser.Visible = True Then
            pnlCreateUser.Visible = False
            pnlCreateUser.Hide()
        End If
        If pnlModifyUser.Visible = True Then
            pnlModifyUser.Visible = False
            pnlModifyUser.Hide()
        End If
        If pnlDeleteUser.Visible = True Then
            pnlDeleteUser.Visible = False
            pnlDeleteUser.Hide()
        End If
        If pnlSearchUser.Visible = False Then
            pnlSearchUser.BringToFront()
            pnlSearchUser.Size = New Size(665, 345)
            pnlSearchUser.Location = New Point(0, 300)
            pnlSearchUser.Show()
            pnlSearchUser.Visible = True
        End If

    End Sub




    Private Sub lblSearchUserModifyUser_Click(sender As Object, e As EventArgs)
        Dim connection As New SqlConnection(connectionString)

        Dim command As SqlCommand =
        New SqlCommand("SELECT U.Name,  R.Name FROM Users U, Roles R WHERE U.Id ='" & tbxUserIDModifyUser.Text & "'", connection)

        connection.Open()

        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            'si la consulta genero datos el usuario existe
            reader.Read()
            Dim name As String
            Dim roleName As String
            name = reader.GetString(0)
            roleName = reader.GetString(1)
            tbxUserNameModifyUser.Text = name
            cmbxUserRoleModifyUser.SelectedItem = roleName

            btnSaveModifyUser.Enabled = True

        Else
            MsgBox("¡Vaya no tenemos ningun usuario con el ID " & tbxUserIDModifyUser.Text & " en nuestro sistema!")
        End If


    End Sub


    Private Sub lblCancelModifyUser_Click(sender As Object, e As EventArgs) Handles lblCancelModifyUser.Click
        tbxUserEmailModifyUser.Clear()
        tbxUserIDModifyUser.Clear()
        tbxUserNickNameModifyUser.Clear()
        tbxUserNameModifyUser.Clear()
        cmbxUserRoleModifyUser.SelectedIndex = -1
    End Sub


    Private Sub lblDeleteDeleteUser_Click(sender As Object, e As EventArgs) Handles lblDeleteDeleteUser.Click
        If tbxUserIDDeleteUser.Text <> "" Then
            Dim connection As New SqlConnection(connectionString)

            Dim command As SqlCommand =
            New SqlCommand("DELETE FROM Users WHERE Id='" & tbxUserIDDeleteUser.Text & "'", connection)
            Try
                connection.Open()
                command.ExecuteNonQuery()

                MsgBox("¡Genial! El Usuario fue eliminado con exito.")

            Catch ex As SqlException
                MsgBox("¡Vaya un problema surgio, el usuario no fue modificado!")
            Finally
                command.Dispose()
                connection.Close()
                tbxUserEmailDeleteUser.Clear()
                tbxUserIDDeleteUser.Clear()
                tbxUserNickNameDeleteUser.Clear()
                tbxUserNameDeleteUser.Clear()

            End Try

        End If
    End Sub

    Private Sub lblCancelDeleteUser_Click(sender As Object, e As EventArgs) Handles lblCancelDeleteUser.Click
        tbxUserEmailDeleteUser.Clear()
        tbxUserIDDeleteUser.Clear()
        tbxUserNickNameDeleteUser.Clear()
        tbxUserNameDeleteUser.Clear()

    End Sub

    Private Sub btnCancelUserSearchUser_Click(sender As Object, e As EventArgs) Handles btnCancelUserSearchUser.Click
        tbxUserNameSearchUser.Clear()
        tbxUserNickNameSearchUser.Clear()
        tbxUserIDSearchUser.Clear()
        tbxUserEmailSearchUser.Clear()
        tbxUserRoleSearchUser.Clear()

    End Sub


    Private Sub btnSearchUserSearchUser_Click(sender As Object, e As EventArgs) Handles btnSearchUserSearchUser.Click

        Dim connection As New SqlConnection(connectionString)
        Dim id As Integer = tbxUserIDSearchUser.Text
        Dim command As SqlCommand =
        New SqlCommand("SELECT U.Name, U.Username, U.Email, R.Name FROM Users U, Roles R WHERE U.Id_Role = R.Id AND U.Id ='" & id & "'", connection)

        connection.Open()

        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            'si la consulta genero datos el usuario existe
            reader.Read()
            Dim name As String
            Dim role As String
            name = reader.GetString(0)
            role = reader.GetString(3)
            tbxUserNameSearchUser.Text = name
            tbxUserRoleSearchUser.Text = role
            tbxUserNickNameSearchUser.Text = reader.GetString(1)
            tbxUserEmailSearchUser.Text = reader.GetString(2)
            lblViewUserProfileSearchUser.Enabled = True

        Else
            MsgBox("¡Vaya no tenemos ningun usuario con el ID " & tbxUserIDModifyUser.Text & " en nuestro sistema!")
            tbxUserNameSearchUser.Clear()
            tbxUserIDSearchUser.Clear()
            tbxUserEmailSearchUser.Clear()
            tbxUserNickNameSearchUser.Clear()
            tbxUserRoleSearchUser.Clear()
        End If
    End Sub


    Private Sub btnSearchUserDeleteUser_Click(sender As Object, e As EventArgs) Handles btnSearchUserDeleteUser.Click
        Dim connection As New SqlConnection(connectionString)
        Dim id As Integer = tbxUserIDDeleteUser.Text
        Dim command As SqlCommand =
        New SqlCommand("SELECT U.Name, U.Username, U.Email, R.Name FROM Users U, Roles R WHERE U.Id_Role = R.Id AND U.Id ='" & id & "'", connection)

        connection.Open()

        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            'si la consulta genero datos el usuario existe
            reader.Read()
            Dim name As String
            Dim roleName As String
            name = reader.GetString(0)
            roleName = reader.GetString(3)
            tbxUserNameDeleteUser.Text = name
            tbxUserNickNameDeleteUser.Text = reader.GetString(1)
            tbxUserEmailDeleteUser.Text = reader.GetString(2)
            lblDeleteDeleteUser.Enabled = True

        Else
            MsgBox("¡Vaya no tenemos ningun usuario con el ID " & tbxUserIDModifyUser.Text & " en nuestro sistema!")
            tbxUserIDDeleteUser.Clear()
        End If
    End Sub

    Private Sub btnSearchUserModifyUser_Click(sender As Object, e As EventArgs) Handles btnSearchUserModifyUser.Click
        Dim connection As New SqlConnection(connectionString)

        Dim command As SqlCommand =
        New SqlCommand("SELECT U.Name,  U.Username, U.Email, U.Password, R.Name FROM Users U, Roles R WHERE U.Id_Role = R.Id AND U.Id ='" & tbxUserIDModifyUser.Text & "'", connection)
        'New SqlCommand("SELECT U.Name, U.Username, U.Password, R.Name FROM Users U, Roles R WHERE U.Id_Role = R.Id AND U.Username='" & tbxUserName.Text & "' AND U.Password='" & tbxUserPassword.Text & "'", connection)

        connection.Open()

        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            'si la consulta genero datos el usuario existe
            reader.Read()
            Dim name As String
            Dim roleName As String
            name = reader.GetString(0)
            Dim nickname As String = reader.GetString(1)
            Dim email As String = reader.GetString(2)
            Dim password As String = reader.GetString(3)
            roleName = reader.GetString(4)
            tbxUserNameModifyUser.Text = name
            tbxUserPasswordModifyUser.Text = password
            tbxUserEmailModifyUser.Text = email
            tbxUserNickNameModifyUser.Text = nickname

            If roleName = "Administrador" Then
                cmbxUserRoleModifyUser.SelectedIndex = 0
            End If
            If roleName = "Estudiante" Then
                cmbxUserRoleModifyUser.SelectedIndex = 2
            End If
            If roleName = "Profesor" Then
                cmbxUserRoleModifyUser.SelectedIndex = 1
            End If

            btnSaveModifyUser.Enabled = True

        Else
            MsgBox("¡Vaya no tenemos ningun usuario con el ID " & tbxUserIDModifyUser.Text & " en nuestro sistema!")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSaveModifyUser.Click
        Dim username As String = tbxUserNameModifyUser.Text
        Dim nickname As String = tbxUserNickNameModifyUser.Text
        Dim email As String = tbxUserEmailModifyUser.Text
        Dim password As String = tbxUserPasswordModifyUser.Text
        Dim role As Integer
        If cmbxUserRoleModifyUser.SelectedIndex = 0 Then
            role = 1
        End If
        If cmbxUserRoleModifyUser.SelectedIndex = 1 Then
            role = 2
        End If
        If cmbxUserRoleModifyUser.SelectedIndex = 2 Then
            role = 3
        End If
        Dim id As Integer = tbxUserIDModifyUser.Text

        If username <> "" And nickname <> "" And email <> "" And password <> "" And role <> -1 Then
            Dim connection As New SqlConnection(connectionString)

            Dim command As SqlCommand =
            New SqlCommand("UPDATE Users SET Name='" & username & "', Id_Role=" & role & ", Username='" & nickname & "', Email='" & email & "', Password='" & password & "' WHERE Id =" & id & "", connection)

            Try
                connection.Open()
                command.ExecuteNonQuery()

                MsgBox("¡Genial! El Usuario fue modificado con exito.")

            Catch ex As SqlException
                MsgBox(ex.ToString & "¡Vaya un problema surgio, el usuario no fue modificado!")
            Finally
                command.Dispose()
                connection.Close()
                tbxUserEmailModifyUser.Clear()
                tbxUserIDModifyUser.Clear()
                tbxUserNickNameModifyUser.Clear()
                tbxUserNameModifyUser.Clear()
                tbxUserPasswordModifyUser.Clear()
                cmbxUserRoleModifyUser.SelectedIndex = -1
            End Try

        End If
    End Sub

    Private Sub dgvUserAdmin_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUserAdmin.CellClick
        rowOfGridview = dgvUserAdmin.CurrentRow.Index
        If pnlModifyUser.Visible = True Then
            FillTextsComponentsOfModifyUserPanel(GetUserDataFromGridView)
        End If

        If pnlDeleteUser.Visible = True Then
            FillTextsComponentsOfDeleteUserPanel(GetUserDataFromGridView)
        End If

    End Sub

    Public Function GetUserDataFromGridView()

        'creamos la instancia de la clase usuario

        Dim user As New User
        user.IdUser = dgvUserAdmin.Item(0, rowOfGridview).Value
        user.NameUser = dgvUserAdmin.Item(1, rowOfGridview).Value.ToString
        user.UsernameUser = dgvUserAdmin.Item(2, rowOfGridview).Value.ToString
        user.EmailUser = dgvUserAdmin.Item(3, rowOfGridview).Value.ToString

        Return user

    End Function

    Public Sub FillTextsComponentsOfModifyUserPanel(user As User)
        tbxUserIDModifyUser.Text = user.IdUser
        tbxUserNameModifyUser.Text = user.NameUser
        tbxUserNickNameModifyUser.Text = user.UsernameUser
        tbxUserEmailModifyUser.Text = user.EmailUser
    End Sub

    Public Sub FillTextsComponentsOfDeleteUserPanel(user As User)
        tbxUserIDDeleteUser.Text = user.IdUser
        tbxUserNameDeleteUser.Text = user.NameUser
        tbxUserNickNameDeleteUser.Text = user.UsernameUser
        tbxUserEmailDeleteUser.Text = user.EmailUser
    End Sub
    Private Sub btnAdministrateObjects_Click(sender As Object, e As EventArgs) Handles btnAdministrateObjects.Click
        lblBienvenida.Visible = False
        If pnlUser.Visible = True Then
            pnlUser.Visible = False
        End If
        If pnlAdminstrateUsers.Visible = True Then
            pnlAdminstrateUsers.Visible = False
        End If
        If panelReservations.Visible = True Then
            panelReservations.Visible = False
        End If
        If panelAdminClass.Visible = False Then
            lblBienvenida.Visible = True
            panelAdminClass.Visible = True
            panelAdminClass.Size = New Size(660, 630)
            panelAdminClass.Location = New Point(138, 78)
            panelAdminClass.Visible = True
            Dim connection As SqlConnection

            'aquí conectamos con la base de datos
            connection = New SqlConnection(connectionString)

            Dim classTable As New DataTable

            Dim commandSelect As New SqlCommand("SELECT * FROM Classroom", connection)
            Dim dataAdapter As New SqlDataAdapter(commandSelect)
            dataAdapter.Fill(classTable)
            dgvClasses.DataSource = classTable
        End If
    End Sub


    Public Sub cargarTipoComboBox()

        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim dataSet As New DataSet()
        Dim sqlQuery As String

        sqlQuery = "SELECT Id, Name FROM Type"

        'aquí conectamos con la base de datos
        connection = New SqlConnection(connectionString)

        'abrimos conexión

        connection.Open()

        'ejecutamos la sentencia SELECT
        command = New SqlCommand(sqlQuery, connection)

        'llenamos el adaptador
        adapter.SelectCommand = command

        adapter.Fill(dataSet)

        adapter.Dispose()
        command.Dispose()
        connection.Close()
        'Mostrar los roles en el combo
        cmbCreateClassTypes.DataSource = dataSet.Tables(0)
        cmbCreateClassTypes.ValueMember = "Id"
        cmbCreateClassTypes.DisplayMember = "Name"

        cmbCreateClassTypes.SelectedIndex = -1
    End Sub



    Private Sub btnAddClass_Click(sender As Object, e As EventArgs) Handles btnAddClass.Click
        If pnlHorarios.Visible = True Then
            pnlHorarios.Visible = False
        End If
        If pnlModifyClass.Visible = True Then
            pnlModifyClass.Visible = False
        End If

        If pnlDeleteCLass.Visible = True Then
            pnlDeleteCLass.Visible = False
        End If

        If pnlCreateClass.Visible = False Then
            pnlCreateClass.BringToFront()
            pnlCreateClass.Size = New Size(660, 500)
            pnlCreateClass.Location = New Point(0, 135)
            pnlCreateClass.Show()
            pnlCreateClass.Visible = True

            Dim connection As SqlConnection
            Dim command As SqlCommand
            Dim adapter As New SqlDataAdapter
            Dim dataSet As New DataSet()

            'Esto significa: traiga el id y el name de todos
            'los roles
            Dim sqlQuery As String
            sqlQuery = "SELECT Id, Name FROM Building"

            'aquí conectamos con la base de datos
            connection = New SqlConnection(connectionString)

            'abrimos conexión

            connection.Open()

            'ejecutamos la sentencia SELECT
            command = New SqlCommand(sqlQuery, connection)

            'llenamos el adaptador
            adapter.SelectCommand = command

            adapter.Fill(dataSet)

            adapter.Dispose()
            command.Dispose()
            connection.Close()

            'Mostrar los roles en el combo
            cmbCreateClassEdificio.DataSource = dataSet.Tables(0)
            cmbCreateClassEdificio.ValueMember = "Id"
            cmbCreateClassEdificio.DisplayMember = "Name"

            cmbCreateClassEdificio.SelectedIndex = -1

            cargarTipoComboBox()
            cbxDia.Items.Add("Lunes")
            cbxDia.Items.Add("Martes")
            cbxDia.Items.Add("Miercoles")
            cbxDia.Items.Add("Jueves")
            cbxDia.Items.Add("Viernes")
            cbxDia.Items.Add("Sabado")
        End If
    End Sub

    Public Function obtnerUltimoID()
        Dim connection As SqlConnection
        Dim idLast As String = ""

        'aquí conectamos con la base de datos
        connection = New SqlConnection(connectionString)
        'SELECT LAST(Id) FROM Classroom

        Dim dt As New DataTable
        connection.Open()
        Dim sqlCmd As New SqlCommand("SELECT TOP 1 Id FROM Classroom ORDER BY Id DESC", connection)
        Dim sqlDa As New SqlDataAdapter(sqlCmd)
        sqlDa.Fill(dt)
        If dt.Rows.Count > 0 Then
            idLast = dt.Rows(0)("Id").ToString
            'tbxCreateClassName.Text = idLast
        End If
        connection.Close()
        Return idLast
    End Function
    Public Function agregarAula()
        Dim aulaNombre As String = ""

        Dim connection As SqlConnection
        Dim command As SqlCommand

        connection = New SqlConnection(connectionString)

        Dim insertQuery As String
        insertQuery = "INSERT INTO Classroom (Name, Type, Building, Description) VALUES (@name, @type, @building, @description)"
        command = New SqlCommand(insertQuery, connection)
        'esto es una instancia de la clase User
        'convierte la clase en un objeto
        Dim classroom As New Classroom

        Try

            classroom.BuildingClassroom = cmbCreateClassEdificio.Text
            classroom.TypeClassroom = cmbCreateClassTypes.Text
            classroom.DescriptionClassroom = tbxCreateClassCaracteristicas.Text
            classroom.NameClassroom = tbxCreateClassName.Text

            With command
                .Parameters.AddWithValue("@name", classroom.NameClassroom)
                .Parameters.AddWithValue("@type", classroom.TypeClassroom)
                .Parameters.AddWithValue("@building", classroom.BuildingClassroom)
                .Parameters.AddWithValue("@description", classroom.DescriptionClassroom)
            End With

            connection.Open()
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("El Aula no pudo ser agregada, intenta de nuevo.")
        Finally
            command.Dispose()
            connection.Close()
        End Try
        Return aulaNombre
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
                            horario.Clase1 = tbxCreateClassName.Text
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
                                If horarioOcupado(tbxCreateClassName.Text, tbxHoraInicial.Text, tbxHoraFinal.Text, cbxDia.Text) = True Then
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

    Private Sub lblAgregarAulaHorario_Click(sender As Object, e As EventArgs) Handles lblAgregarAulaHorario.Click

        'horarioOcupado("C-144", "1/1/1900 8:00:00 a. m.", "1/1/1900 8:00:00 a. m.", "Martes")
        Dim nombreClase As String = ""
        Dim horaInicio As String = ""
        Dim horaFinal As String = ""
        Dim dia As String = ""

        If (tbxCreateClassCaracteristicas.Text.Equals("") Or cmbCreateClassTypes.SelectedIndex = -1 Or cmbCreateClassEdificio.SelectedIndex = -1) Then
            MsgBox("No puedes dejar ningun campo vacio.")
        ElseIf auxiliar = True And (tbxCreateClassCaracteristicas.Text <> "" And cmbCreateClassEdificio.SelectedIndex <> -1 And cmbCreateClassTypes.SelectedIndex <> -1) Then
            nombreClase = tbxCreateClassName.Text

            clase = agregarAula()
            If (cbxDia.SelectedIndex <> -1 And tbxMotivo.Text <> "" And tbxHoraInicial.Text <> "" And tbxHoraFinal.Text <> "") Then
                horaInicio = tbxHoraInicial.Text
                horaFinal = tbxHoraFinal.Text
                dia = cbxDia.Text
                mensaje = agregarHorario(clase, horaInicio, horaFinal, dia)
                MsgBox("El aula fue agregada; " & mensaje)
            Else
                MsgBox("El aula fue agregada, sin embargo no se adjuntaron horarios para el aula.")
            End If
            auxiliar = False
        ElseIf auxiliar = False And (cbxDia.SelectedIndex <> -1 And tbxMotivo.Text <> "" And tbxHoraInicial.Text <> "" And tbxHoraFinal.Text <> "") Then
            mensaje = agregarHorario(clase, tbxHoraInicial.Text, tbxHoraFinal.Text, cbxDia.Text)
            If mensaje <> "" Then
                MsgBox(mensaje)
            End If
        End If
    End Sub

    Private Sub dgvClasses_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClasses.CellClick
        rowOfGridview = dgvClasses.CurrentRow.Index
        If pnlModifyClass.Visible = True Then
            FillTextsComponentsOfModifyPanel(GetClassroomDataFromGridView)
        End If

    End Sub

    Public Function GetClassroomDataFromGridView()

        'creamos la instancia de la clase usuario

        Dim classroom As New Classroom
        classroom.IdClassroom = dgvClasses.Item(0, rowOfGridview).Value
        classroom.NameClassroom = dgvClasses.Item(1, rowOfGridview).Value.ToString
        classroom.DescriptionClassroom = dgvClasses.Item(4, rowOfGridview).Value.ToString
        classroom.TypeClassroom = dgvClasses.Item(2, rowOfGridview).Value.ToString
        classroom.BuildingClassroom = dgvClasses.Item(3, rowOfGridview).Value.ToString

        Return classroom

    End Function

    Public Sub FillTextsComponentsOfModifyPanel(classroom As Classroom)
        tbxModifyCaracteristicas.Text = classroom.DescriptionClassroom
        tbxModifyClassName.Text = classroom.NameClassroom
        cbxModifyClassroom.Text = classroom.TypeClassroom
        cbxModifyEdificio.Text = classroom.BuildingClassroom
    End Sub
    Public Sub cargarTipoComboBoxModify()

        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim dataSet As New DataSet()
        Dim sqlQuery As String

        sqlQuery = "SELECT Id, Name FROM Type"

        'aquí conectamos con la base de datos
        connection = New SqlConnection(connectionString)

        'abrimos conexión

        connection.Open()

        'ejecutamos la sentencia SELECT
        command = New SqlCommand(sqlQuery, connection)

        'llenamos el adaptador
        adapter.SelectCommand = command

        adapter.Fill(dataSet)

        adapter.Dispose()
        command.Dispose()
        connection.Close()
        'Mostrar los roles en el combo
        cbxModifyClassroom.DataSource = dataSet.Tables(0)
        cbxModifyClassroom.ValueMember = "Id"
        cbxModifyClassroom.DisplayMember = "Name"

        cbxModifyClassroom.SelectedIndex = -1
    End Sub

    Private Sub btnEditClass_Click(sender As Object, e As EventArgs) Handles btnEditClass.Click
        If pnlHorarios.Visible = True Then
            pnlHorarios.Visible = False
        End If
        If pnlDeleteCLass.Visible = True Then
            pnlDeleteCLass.Visible = False
        End If
        If pnlCreateClass.Visible = True Then
            pnlCreateClass.Visible = False
        End If
        If pnlModifyClass.Visible = False Then
            pnlModifyClass.Visible = True
            pnlModifyClass.BringToFront()
            pnlModifyClass.Location = New Point(0, 288)
            pnlModifyClass.Size = New Size(660, 305)
        End If

        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim dataSet As New DataSet()

        'Esto significa: traiga el id y el name de todos
        'los roles
        Dim sqlQuery As String
        sqlQuery = "SELECT Id, Name FROM Building"

        'aquí conectamos con la base de datos
        connection = New SqlConnection(connectionString)

        'abrimos conexión

        connection.Open()

        'ejecutamos la sentencia SELECT
        command = New SqlCommand(sqlQuery, connection)

        'llenamos el adaptador
        adapter.SelectCommand = command

        adapter.Fill(dataSet)

        adapter.Dispose()
        command.Dispose()
        connection.Close()

        'Mostrar los roles en el combo
        cbxModifyEdificio.DataSource = dataSet.Tables(0)
        cbxModifyEdificio.ValueMember = "Id"
        cbxModifyEdificio.DisplayMember = "Name"

        cbxModifyEdificio.SelectedIndex = -1

        cargarTipoComboBoxModify()

        FillTextsComponentsOfModifyPanel(GetClassroomDataFromGridView)


    End Sub

    Private Sub bntSaveModifyClass_Click(sender As Object, e As EventArgs) Handles bntSaveModifyClass.Click
        Dim descripcion As String = tbxModifyCaracteristicas.Text
        Dim nombre As String = tbxModifyClassName.Text
        Dim tipo As String = cbxModifyClassroom.Text
        Dim edificio As String = cbxModifyEdificio.Text

        If edificio <> "" And nombre <> "" And tipo <> "" And nombre <> "" And descripcion <> "" Then
            Dim connection As New SqlConnection(connectionString)

            Dim command As SqlCommand =
            New SqlCommand("UPDATE Classroom SET Name='" & nombre & "', Type='" & tipo & "', Building='" & edificio & "', Description='" & descripcion & "' WHERE Id='" & dgvClasses.Item(0, rowOfGridview).Value & "'", connection)

            Try
                connection.Open()
                command.ExecuteNonQuery()

                MsgBox("¡Genial! El aula fue modificada con exito.")

                Dim classTable As New DataTable

                Dim commandSelect As New SqlCommand("SELECT * FROM Classroom", connection)
                Dim dataAdapter As New SqlDataAdapter(commandSelect)
                dataAdapter.Fill(classTable)
                dgvClasses.DataSource = classTable

            Catch ex As SqlException
                MsgBox(ex.ToString & "¡Vaya un problema surgio, el aula no fue modificada!")
            Finally
                command.Dispose()
                connection.Close()
            End Try

        End If

    End Sub


    Private Sub btnDeletePanelClass_Click(sender As Object, e As EventArgs) Handles btnDeletePanelClass.Click
        If pnlHorarios.Visible = True Then
            pnlHorarios.Visible = False
        End If
        If pnlCreateClass.Visible = True Then
            pnlCreateClass.Visible = False
        End If
        If pnlModifyClass.Visible = True Then
            pnlModifyClass.Visible = False
        End If
        If pnlDeleteCLass.Visible = False Then
            pnlDeleteCLass.Visible = True
            pnlDeleteCLass.BringToFront()
            pnlDeleteCLass.Location = New Point(0, 285)
            pnlDeleteCLass.Size = New Size(660, 345)


        End If
    End Sub

    Private Sub btnDeleteClass_Click(sender As Object, e As EventArgs) Handles btnDeleteClass.Click
        DeleteQuery(dgvClasses.Item(0, rowOfGridview).Value)
        Dim tab As New DataTable
        Dim connection As New SqlConnection(connectionString)
        Dim commandSelect As New SqlCommand("SELECT * FROM Classroom", connection)
        Dim dataAdapter As New SqlDataAdapter(commandSelect)
        dataAdapter.Fill(tab)
        dgvClasses.DataSource = tab
    End Sub





    Private Sub tbxHoraInicial_Enter(sender As Object, e As EventArgs) Handles tbxHoraInicial.Enter
        'Horas.Show()
    End Sub

    Private Sub btnAgregarHorario_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbCreateClassEdificio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCreateClassEdificio.SelectedIndexChanged
        If cmbCreateClassEdificio.SelectedIndex <> -1 Then
            Dim aulaNombre As String = obtnerUltimoID()
            aulaNombre = cmbCreateClassEdificio.Text + "-" + aulaNombre
            tbxCreateClassName.Text = aulaNombre
        Else
            tbxCreateClassName.Text = ""
        End If
    End Sub


    Private Sub tbxCreateClassName_TextChanged(sender As Object, e As EventArgs) Handles tbxCreateClassName.TextChanged
        auxiliar = True
    End Sub

    Private Sub btnHorarios_Click(sender As Object, e As EventArgs)
        If pnlDeleteCLass.Visible = True Then
            pnlDeleteCLass.Visible = False
        End If
        If pnlCreateClass.Visible = True Then
            pnlCreateClass.Visible = False
        End If
        If pnlModifyClass.Visible = True Then
            pnlModifyClass.Visible = False
        End If
        If pnlHorarios.Visible = False Then
            pnlHorarios.Visible = True
            pnlHorarios.BringToFront()
            pnlHorarios.Location = New Point(0, 285)
            pnlHorarios.Size = New Size(660, 345)

        End If
    End Sub

    Private Sub btnAgregarHorario_Click_1(sender As Object, e As EventArgs) Handles btnAgregarHorario.Click
        ' If pnlAgregarHorario.Visible = False Then
        'pnlAgregarHorario.Visible = True
        'pnlAgregarHorario.BringToFront()
        'pnlAgregarHorario.Location = New Point(6, 58)
        'pnlAgregarHorario.Size = New Point(632, 207)
        ' End If
    End Sub

    Private Sub btnAdministrateRequests_Click(sender As Object, e As EventArgs) Handles btnAdministrateRequests.Click
        lblBienvenida.Visible = False
        If pnlUser.Visible = True Then
            pnlUser.Visible = False
        End If
        If pnlAdminstrateUsers.Visible = True Then
            pnlAdminstrateUsers.Visible = False
        End If
        If panelAdminClass.Visible = True Then
            panelAdminClass.Visible = False
        End If
        If panelReservations.Visible = False Then
            lblBienvenida.Visible = True
            panelReservations.Visible = True
            panelReservations.Size = New Size(660, 630)
            panelReservations.Location = New Point(138, 78)
            panelReservations.Visible = True
            Dim connection As SqlConnection



            'aquí conectamos con la base de datos
            connection = New SqlConnection(connectionString)

            Dim classTable As New DataTable

            Dim commandSelect As New SqlCommand("SELECT * FROM Horarios", connection)
            Dim dataAdapter As New SqlDataAdapter(commandSelect)
            dataAdapter.Fill(classTable)
            dgvClassReservations.DataSource = classTable
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles btnCreateReservation.Click
        If pnlModifyReservation.Visible = True Then
            pnlModifyReservation.Visible = False
        End If
        If pnlDeleteReservation.Visible = True Then
            pnlDeleteReservation.Visible = False
        End If
        If pnlUser.Visible = True Then
            pnlUser.Visible = False
        End If
        If pnlClassReservation.Visible = True Then
            pnlClassReservation.Visible = False
        End If

        If pnlClassReservation.Visible = False Then
            btnDelReservation.Visible = False
            btnSaveReservation.Visible = True
            pnlClassReservation.Size = New Size(660, 500)
            pnlClassReservation.Location = New Point(0, 135)
            pnlClassReservation.Visible = True
            pnlHorarioReservacion.Visible = True

            'aquí conectamos con la base de datos para llenar el DGV de clases
            Dim connection As SqlConnection
            connection = New SqlConnection(connectionString)

            Dim classTable As New DataTable

            Dim commandSelect As New SqlCommand("SELECT * FROM Classroom", connection)
            Dim dataAdapter As New SqlDataAdapter(commandSelect)
            dataAdapter.Fill(classTable)
            dgvClassroomReservation.DataSource = classTable

            cbxDiaReservacion.Items.Add("Lunes")
            cbxDiaReservacion.Items.Add("Martes")
            cbxDiaReservacion.Items.Add("Miercoles")
            cbxDiaReservacion.Items.Add("Jueves")
            cbxDiaReservacion.Items.Add("Viernes")
            cbxDiaReservacion.Items.Add("Sabado")
        End If
    End Sub

    Private Sub dgvClassroomReservation_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClassroomReservation.CellClick
        rowOfGridview = dgvClassroomReservation.CurrentRow.Index
        getClassroomName(GetClassroomDataReservationsFromGridView)
    End Sub

    Public Function GetClassroomDataReservationsFromGridView()

        'creamos la instancia de la clase Classroom

        Dim classroom As New Classroom
        classroom.IdClassroom = dgvClassroomReservation.Item(0, rowOfGridview).Value
        classroom.NameClassroom = dgvClassroomReservation.Item(1, rowOfGridview).Value.ToString
        classroom.DescriptionClassroom = dgvClassroomReservation.Item(4, rowOfGridview).Value.ToString
        classroom.TypeClassroom = dgvClassroomReservation.Item(2, rowOfGridview).Value.ToString
        classroom.BuildingClassroom = dgvClassroomReservation.Item(3, rowOfGridview).Value.ToString

        Return classroom

    End Function

    Public Sub getClassroomName(classroom As Classroom)
        txbClassroom.Text = classroom.NameClassroom
    End Sub

    Private Sub btnSaveReservation_Click(sender As Object, e As EventArgs) Handles btnSaveReservation.Click
        ' insertar la reservacion
        Dim nombreClase As String = ""
        Dim horaInicio As String = ""
        Dim horaFinal As String = ""
        Dim dia As String = ""

        If (txbClassroom.Text <> "") Then
            nombreClase = txbClassroom.Text

            If (cbxDiaReservacion.SelectedIndex <> -1 And tbxMotivoReservacion.Text <> "" And tbxHoraInicialReservacion.Text <> "" And tbxHoraFinalReservacion.Text <> "") Then
                horaInicio = tbxHoraInicialReservacion.Text
                horaFinal = tbxHoraFinalReservacion.Text
                dia = cbxDiaReservacion.Text
                mensaje = agregarHorarioReservacion(clase, horaInicio, horaFinal, dia)
                MsgBox("La reservacion fue agregada " & mensaje)
            Else
                MsgBox("sin embargo no se adjuntaron horarios para el aula.")
            End If
            auxiliar = False
        ElseIf auxiliar = False And (cbxDiaReservacion.SelectedIndex <> -1 And tbxMotivoReservacion.Text <> "" And tbxHoraInicialReservacion.Text <> "" And tbxHoraFinalReservacion.Text <> "") Then
            mensaje = agregarHorarioReservacion(clase, tbxHoraInicialReservacion.Text, tbxHoraFinalReservacion.Text, cbxDiaReservacion.Text)
            If mensaje <> "" Then
                MsgBox(mensaje)
            End If
        End If

    End Sub

    Public Function agregarHorarioReservacion(clase As String, horaI As String, horaF As String, dia As String)
        Dim mensaje As String = ""
        Dim connection As SqlConnection
        Dim command As SqlCommand

        connection = New SqlConnection(connectionString)
        Dim insertQuery As String
        Dim horaInicio As String = tbxHoraInicialReservacion.Text
        Dim horaFinal As String = tbxHoraFinalReservacion.Text

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
                    tbxHoraFinalReservacion.Text = ""
                    tbxHoraInicialReservacion.Text = ""
                    'Console.WriteLine(startHour.TimeOfDay)
                Else
                    Console.WriteLine(startHour.TimeOfDay)
                    Console.WriteLine(cbxDiaReservacion.SelectedItem.ToString)
                    Dim comparacion As Integer = DateTime.Compare(startHour, finalHour)
                    If comparacion > 0 Then
                        MsgBox("La hora Inicial no puede ser mayor a la hora Final ")
                        tbxHoraFinalReservacion.Text = ""
                        tbxHoraInicialReservacion.Text = ""
                    ElseIf comparacion = 0 Then
                        MsgBox("La hora Inicial no puede ser igual a la hora Final ")
                        tbxHoraFinalReservacion.Text = ""
                        tbxHoraInicialReservacion.Text = ""
                    Else
                        ' Display in 24hr format
                        'lblTiempoLibre.Text = dtTime.ToString("HH:mm")
                        insertQuery = "INSERT INTO Horarios (Clase, Motivo, HoraInicio, HoraFinal, Dia ) VALUES (@clase, @motivo, @horaInicio, @horaFinal, @dia)"
                        command = New SqlCommand(insertQuery, connection)
                        Try

                            'esto es una instancia de la clase User
                            'convierte la clase en un objeto
                            Dim horario = New Horarios
                            horario.Clase1 = txbClassroom.Text
                            horario.Dia1 = cbxDiaReservacion.Text
                            horario.Motivo1 = tbxMotivoReservacion.Text
                            horario.HoraInicio1 = tbxHoraInicialReservacion.Text
                            horario.HoraFinal1 = tbxHoraFinalReservacion.Text
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
                                If horarioOcupadoReservacion(txbClassroom.Text, tbxHoraInicialReservacion.Text, tbxHoraFinalReservacion.Text, cbxDiaReservacion.Text) = True Then
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
                            tbxHoraInicialReservacion.Text = ""
                            tbxHoraFinalReservacion.Text = ""
                        Finally
                            command.Dispose()
                            connection.Close()
                        End Try
                    End If
                End If
            Catch ex As Exception
                mensaje = "Alguna de las horas fue ingresada con un formato incorrecto."
                tbxHoraInicialReservacion.Text = ""
                tbxHoraFinalReservacion.Text = ""
            End Try
        Else
            mensaje = "Alguna de las horas fue ingresada con un formato incorrecto."
            tbxHoraInicialReservacion.Text = ""
            tbxHoraFinalReservacion.Text = ""
        End If
        Return mensaje
    End Function

    Public Function horarioOcupadoReservacion(clase As String, horaI As String, horaF As String, dia As String)
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

    Private Sub btnModifyReservation_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnDeleteReservation_Click(sender As Object, e As EventArgs) Handles btnDeleteReservation.Click
        If pnlModifyReservation.Visible = True Then
            pnlModifyReservation.Visible = False
        End If
        If pnlDeleteReservation.Visible = True Then
            pnlDeleteReservation.Visible = False
        End If
        If pnlUser.Visible = True Then
            pnlUser.Visible = False
        End If
        If pnlClassReservation.Visible = True Then
            pnlClassReservation.Visible = False
        End If
        If pnlClassReservation.Visible = False Then
            btnDelReservation.Visible = True
            pnlDeleteReservation.Size = New Size(660, 305)
            pnlDeleteReservation.Location = New Point(0, 288)
            pnlDeleteReservation.Visible = True
            pnlHorarioReservacion.Visible = False



            'aquí conectamos con la base de datos para llenar el DGV de clases
            Dim connection As SqlConnection
            connection = New SqlConnection(connectionString)

            Dim classTable As New DataTable

            Dim commandSelect As New SqlCommand("SELECT * FROM Classroom", connection)
            Dim dataAdapter As New SqlDataAdapter(commandSelect)
            dataAdapter.Fill(classTable)
            dgvClassroomReservation.DataSource = classTable

            cbxDiaReservacion.Items.Add("Lunes")
            cbxDiaReservacion.Items.Add("Martes")
            cbxDiaReservacion.Items.Add("Miercoles")
            cbxDiaReservacion.Items.Add("Jueves")
            cbxDiaReservacion.Items.Add("Viernes")
            cbxDiaReservacion.Items.Add("Sabado")
        End If
    End Sub

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


    Public Sub DeleteQuery(id As Integer)
        Dim connection As New SqlConnection(connectionString)
        Dim commandDelete As New SqlCommand("DELETE FROM Classroom WHERE Id = '" & id & "'", connection)

        connection.Open()
        commandDelete.ExecuteNonQuery()
        connection.Close()
        MsgBox("El aula ha sido eliminada")

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub btnDelReservation_Click_1(sender As Object, e As EventArgs) Handles btnDelReservation.Click
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





End Class