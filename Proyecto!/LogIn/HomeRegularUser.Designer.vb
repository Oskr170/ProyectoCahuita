<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeRegularUser
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeRegularUser))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlPrincipal = New System.Windows.Forms.Panel()
        Me.btnSearchReservations = New System.Windows.Forms.Button()
        Me.btnCancelReservation = New System.Windows.Forms.Button()
        Me.pnlClassReservation = New System.Windows.Forms.Panel()
        Me.lblClassroom = New System.Windows.Forms.Label()
        Me.txbClassroom = New System.Windows.Forms.TextBox()
        Me.dgvClasses = New System.Windows.Forms.DataGridView()
        Me.btnSaveReservation = New System.Windows.Forms.Button()
        Me.pnlHorarioReservacion = New System.Windows.Forms.Panel()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.tbxHoraFinal = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.tbxHoraInicial = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.tbxMotivo = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.cbxDia = New System.Windows.Forms.ComboBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.lblHorario = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblClassReservation = New System.Windows.Forms.Label()
        Me.lblDescripcionBoton = New System.Windows.Forms.Label()
        Me.lblBienvenida = New System.Windows.Forms.Label()
        Me.pnlUser = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnlRecentActivity = New System.Windows.Forms.Panel()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.lblRecentActivity = New System.Windows.Forms.Label()
        Me.صورة_دائرة1 = New PictureBoxAbouAmmar.صورة_دائرة()
        Me.tbxUserRole = New System.Windows.Forms.TextBox()
        Me.tbxUserNickName = New System.Windows.Forms.TextBox()
        Me.tbxUserName = New System.Windows.Forms.TextBox()
        Me.lblPerfil = New System.Windows.Forms.Label()
        Me.btnAdministrateRequests = New System.Windows.Forms.Button()
        Me.btnUserLately = New System.Windows.Forms.Button()
        Me.lblColumn = New System.Windows.Forms.Label()
        Me.pnlPrincipal.SuspendLayout()
        Me.pnlClassReservation.SuspendLayout()
        CType(Me.dgvClasses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHorarioReservacion.SuspendLayout()
        Me.pnlUser.SuspendLayout()
        CType(Me.صورة_دائرة1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.SeaGreen
        Me.btnMinimize.BackgroundImage = CType(resources.GetObject("btnMinimize.BackgroundImage"), System.Drawing.Image)
        Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMinimize.Location = New System.Drawing.Point(977, 0)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(43, 39)
        Me.btnMinimize.TabIndex = 4
        Me.btnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.SeaGreen
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(1024, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(43, 39)
        Me.btnClose.TabIndex = 3
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.Controls.Add(Me.btnSearchReservations)
        Me.pnlPrincipal.Controls.Add(Me.btnCancelReservation)
        Me.pnlPrincipal.Controls.Add(Me.pnlClassReservation)
        Me.pnlPrincipal.Controls.Add(Me.lblDescripcionBoton)
        Me.pnlPrincipal.Controls.Add(Me.lblBienvenida)
        Me.pnlPrincipal.Controls.Add(Me.pnlUser)
        Me.pnlPrincipal.Controls.Add(Me.btnAdministrateRequests)
        Me.pnlPrincipal.Controls.Add(Me.btnUserLately)
        Me.pnlPrincipal.Controls.Add(Me.lblColumn)
        Me.pnlPrincipal.Controls.Add(Me.btnMinimize)
        Me.pnlPrincipal.Controls.Add(Me.btnClose)
        Me.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.pnlPrincipal.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(1067, 825)
        Me.pnlPrincipal.TabIndex = 5
        '
        'btnSearchReservations
        '
        Me.btnSearchReservations.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearchReservations.FlatAppearance.BorderSize = 0
        Me.btnSearchReservations.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Thistle
        Me.btnSearchReservations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle
        Me.btnSearchReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchReservations.Image = CType(resources.GetObject("btnSearchReservations.Image"), System.Drawing.Image)
        Me.btnSearchReservations.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearchReservations.Location = New System.Drawing.Point(0, 358)
        Me.btnSearchReservations.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearchReservations.Name = "btnSearchReservations"
        Me.btnSearchReservations.Size = New System.Drawing.Size(180, 85)
        Me.btnSearchReservations.TabIndex = 35
        Me.btnSearchReservations.Text = "Buscar Reservación"
        Me.btnSearchReservations.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearchReservations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSearchReservations.UseVisualStyleBackColor = False
        '
        'btnCancelReservation
        '
        Me.btnCancelReservation.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancelReservation.FlatAppearance.BorderSize = 0
        Me.btnCancelReservation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Thistle
        Me.btnCancelReservation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle
        Me.btnCancelReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelReservation.Image = CType(resources.GetObject("btnCancelReservation.Image"), System.Drawing.Image)
        Me.btnCancelReservation.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelReservation.Location = New System.Drawing.Point(-1, 265)
        Me.btnCancelReservation.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelReservation.Name = "btnCancelReservation"
        Me.btnCancelReservation.Size = New System.Drawing.Size(180, 85)
        Me.btnCancelReservation.TabIndex = 34
        Me.btnCancelReservation.Text = "Cancelar Reservación"
        Me.btnCancelReservation.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCancelReservation.UseVisualStyleBackColor = False
        '
        'pnlClassReservation
        '
        Me.pnlClassReservation.BackColor = System.Drawing.Color.Transparent
        Me.pnlClassReservation.Controls.Add(Me.lblClassroom)
        Me.pnlClassReservation.Controls.Add(Me.txbClassroom)
        Me.pnlClassReservation.Controls.Add(Me.dgvClasses)
        Me.pnlClassReservation.Controls.Add(Me.btnSaveReservation)
        Me.pnlClassReservation.Controls.Add(Me.pnlHorarioReservacion)
        Me.pnlClassReservation.Controls.Add(Me.Label2)
        Me.pnlClassReservation.Controls.Add(Me.Label1)
        Me.pnlClassReservation.Controls.Add(Me.lblClassReservation)
        Me.pnlClassReservation.Location = New System.Drawing.Point(204, 194)
        Me.pnlClassReservation.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlClassReservation.Name = "pnlClassReservation"
        Me.pnlClassReservation.Size = New System.Drawing.Size(863, 618)
        Me.pnlClassReservation.TabIndex = 33
        Me.pnlClassReservation.Visible = False
        '
        'lblClassroom
        '
        Me.lblClassroom.AutoSize = True
        Me.lblClassroom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassroom.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblClassroom.Location = New System.Drawing.Point(22, 275)
        Me.lblClassroom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClassroom.Name = "lblClassroom"
        Me.lblClassroom.Size = New System.Drawing.Size(63, 25)
        Me.lblClassroom.TabIndex = 50
        Me.lblClassroom.Text = "Aula: "
        Me.lblClassroom.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txbClassroom
        '
        Me.txbClassroom.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.txbClassroom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txbClassroom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbClassroom.ForeColor = System.Drawing.Color.White
        Me.txbClassroom.Location = New System.Drawing.Point(91, 272)
        Me.txbClassroom.Margin = New System.Windows.Forms.Padding(4)
        Me.txbClassroom.Multiline = True
        Me.txbClassroom.Name = "txbClassroom"
        Me.txbClassroom.Size = New System.Drawing.Size(209, 30)
        Me.txbClassroom.TabIndex = 50
        Me.txbClassroom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvClasses
        '
        Me.dgvClasses.AllowUserToAddRows = False
        Me.dgvClasses.AllowUserToDeleteRows = False
        Me.dgvClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClasses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvClasses.BackgroundColor = System.Drawing.Color.MediumSeaGreen
        Me.dgvClasses.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvClasses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClasses.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvClasses.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvClasses.GridColor = System.Drawing.Color.White
        Me.dgvClasses.Location = New System.Drawing.Point(4, 111)
        Me.dgvClasses.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvClasses.Name = "dgvClasses"
        Me.dgvClasses.ReadOnly = True
        Me.dgvClasses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvClasses.RowHeadersVisible = False
        Me.dgvClasses.RowTemplate.ReadOnly = True
        Me.dgvClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClasses.Size = New System.Drawing.Size(849, 151)
        Me.dgvClasses.TabIndex = 54
        '
        'btnSaveReservation
        '
        Me.btnSaveReservation.BackColor = System.Drawing.Color.Transparent
        Me.btnSaveReservation.FlatAppearance.BorderSize = 0
        Me.btnSaveReservation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Thistle
        Me.btnSaveReservation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle
        Me.btnSaveReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveReservation.Image = CType(resources.GetObject("btnSaveReservation.Image"), System.Drawing.Image)
        Me.btnSaveReservation.Location = New System.Drawing.Point(370, 523)
        Me.btnSaveReservation.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSaveReservation.Name = "btnSaveReservation"
        Me.btnSaveReservation.Size = New System.Drawing.Size(108, 95)
        Me.btnSaveReservation.TabIndex = 53
        Me.btnSaveReservation.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSaveReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSaveReservation.UseVisualStyleBackColor = False
        '
        'pnlHorarioReservacion
        '
        Me.pnlHorarioReservacion.Controls.Add(Me.Label49)
        Me.pnlHorarioReservacion.Controls.Add(Me.Label51)
        Me.pnlHorarioReservacion.Controls.Add(Me.Label52)
        Me.pnlHorarioReservacion.Controls.Add(Me.tbxHoraFinal)
        Me.pnlHorarioReservacion.Controls.Add(Me.Label53)
        Me.pnlHorarioReservacion.Controls.Add(Me.tbxHoraInicial)
        Me.pnlHorarioReservacion.Controls.Add(Me.Label54)
        Me.pnlHorarioReservacion.Controls.Add(Me.tbxMotivo)
        Me.pnlHorarioReservacion.Controls.Add(Me.Label55)
        Me.pnlHorarioReservacion.Controls.Add(Me.cbxDia)
        Me.pnlHorarioReservacion.Controls.Add(Me.Label56)
        Me.pnlHorarioReservacion.Controls.Add(Me.lblHorario)
        Me.pnlHorarioReservacion.Location = New System.Drawing.Point(10, 314)
        Me.pnlHorarioReservacion.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlHorarioReservacion.Name = "pnlHorarioReservacion"
        Me.pnlHorarioReservacion.Size = New System.Drawing.Size(843, 201)
        Me.pnlHorarioReservacion.TabIndex = 52
        Me.pnlHorarioReservacion.Visible = False
        '
        'Label49
        '
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label49.Location = New System.Drawing.Point(10, 128)
        Me.Label49.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(836, 57)
        Me.Label49.TabIndex = 49
        Me.Label49.Text = "Para la admision de horas de inicio y hora final: Ingrese los datos de la sieguie" &
    "nte manera HH:MMam ó HH:MMpm."
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label51.Location = New System.Drawing.Point(706, 83)
        Me.Label51.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(128, 30)
        Me.Label51.TabIndex = 47
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label52.Location = New System.Drawing.Point(691, 54)
        Me.Label52.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(128, 25)
        Me.Label52.TabIndex = 46
        Me.Label52.Text = "Horas Libres:"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tbxHoraFinal
        '
        Me.tbxHoraFinal.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.tbxHoraFinal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxHoraFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxHoraFinal.ForeColor = System.Drawing.Color.White
        Me.tbxHoraFinal.Location = New System.Drawing.Point(586, 83)
        Me.tbxHoraFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.tbxHoraFinal.Multiline = True
        Me.tbxHoraFinal.Name = "tbxHoraFinal"
        Me.tbxHoraFinal.Size = New System.Drawing.Size(99, 30)
        Me.tbxHoraFinal.TabIndex = 45
        Me.tbxHoraFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label53.Location = New System.Drawing.Point(570, 53)
        Me.Label53.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(107, 25)
        Me.Label53.TabIndex = 44
        Me.Label53.Text = "Hora Final:"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tbxHoraInicial
        '
        Me.tbxHoraInicial.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.tbxHoraInicial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxHoraInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxHoraInicial.ForeColor = System.Drawing.Color.White
        Me.tbxHoraInicial.Location = New System.Drawing.Point(462, 83)
        Me.tbxHoraInicial.Margin = New System.Windows.Forms.Padding(4)
        Me.tbxHoraInicial.Multiline = True
        Me.tbxHoraInicial.Name = "tbxHoraInicial"
        Me.tbxHoraInicial.Size = New System.Drawing.Size(99, 30)
        Me.tbxHoraInicial.TabIndex = 43
        Me.tbxHoraInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label54.Location = New System.Drawing.Point(439, 53)
        Me.Label54.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(114, 25)
        Me.Label54.TabIndex = 42
        Me.Label54.Text = "Hora Inicial:"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tbxMotivo
        '
        Me.tbxMotivo.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.tbxMotivo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxMotivo.ForeColor = System.Drawing.Color.White
        Me.tbxMotivo.Location = New System.Drawing.Point(227, 83)
        Me.tbxMotivo.Margin = New System.Windows.Forms.Padding(4)
        Me.tbxMotivo.Multiline = True
        Me.tbxMotivo.Name = "tbxMotivo"
        Me.tbxMotivo.Size = New System.Drawing.Size(209, 30)
        Me.tbxMotivo.TabIndex = 41
        Me.tbxMotivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label55.Location = New System.Drawing.Point(214, 49)
        Me.Label55.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(76, 25)
        Me.Label55.TabIndex = 40
        Me.Label55.Text = "Motivo:"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cbxDia
        '
        Me.cbxDia.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.cbxDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDia.ForeColor = System.Drawing.SystemColors.Menu
        Me.cbxDia.FormattingEnabled = True
        Me.cbxDia.Location = New System.Drawing.Point(28, 81)
        Me.cbxDia.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxDia.Name = "cbxDia"
        Me.cbxDia.Size = New System.Drawing.Size(179, 32)
        Me.cbxDia.TabIndex = 39
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label56.Location = New System.Drawing.Point(15, 53)
        Me.Label56.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(47, 25)
        Me.Label56.TabIndex = 38
        Me.Label56.Text = "Dia:"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblHorario
        '
        Me.lblHorario.AutoSize = True
        Me.lblHorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorario.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblHorario.Location = New System.Drawing.Point(14, 7)
        Me.lblHorario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHorario.Name = "lblHorario"
        Me.lblHorario.Size = New System.Drawing.Size(103, 31)
        Me.lblHorario.TabIndex = 1
        Me.lblHorario.Text = "Horario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(26, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(229, 29)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Seleccione un aula: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(69, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 29)
        Me.Label1.TabIndex = 8
        '
        'lblClassReservation
        '
        Me.lblClassReservation.AutoSize = True
        Me.lblClassReservation.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassReservation.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblClassReservation.Location = New System.Drawing.Point(26, 20)
        Me.lblClassReservation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClassReservation.Name = "lblClassReservation"
        Me.lblClassReservation.Size = New System.Drawing.Size(233, 39)
        Me.lblClassReservation.TabIndex = 7
        Me.lblClassReservation.Text = "Reservar Aula"
        Me.lblClassReservation.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDescripcionBoton
        '
        Me.lblDescripcionBoton.ForeColor = System.Drawing.Color.White
        Me.lblDescripcionBoton.Location = New System.Drawing.Point(184, 79)
        Me.lblDescripcionBoton.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescripcionBoton.Name = "lblDescripcionBoton"
        Me.lblDescripcionBoton.Size = New System.Drawing.Size(879, 22)
        Me.lblDescripcionBoton.TabIndex = 32
        Me.lblDescripcionBoton.Text = "Descripción Botón"
        Me.lblDescripcionBoton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDescripcionBoton.Visible = False
        '
        'lblBienvenida
        '
        Me.lblBienvenida.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenida.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBienvenida.Location = New System.Drawing.Point(183, 32)
        Me.lblBienvenida.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBienvenida.Name = "lblBienvenida"
        Me.lblBienvenida.Size = New System.Drawing.Size(484, 47)
        Me.lblBienvenida.TabIndex = 31
        Me.lblBienvenida.Text = "Bienvenido al Sistema!"
        Me.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlUser
        '
        Me.pnlUser.BackColor = System.Drawing.Color.Transparent
        Me.pnlUser.Controls.Add(Me.Label14)
        Me.pnlUser.Controls.Add(Me.Label9)
        Me.pnlUser.Controls.Add(Me.Label7)
        Me.pnlUser.Controls.Add(Me.pnlRecentActivity)
        Me.pnlUser.Controls.Add(Me.btnSaveChanges)
        Me.pnlUser.Controls.Add(Me.lblRecentActivity)
        Me.pnlUser.Controls.Add(Me.صورة_دائرة1)
        Me.pnlUser.Controls.Add(Me.tbxUserRole)
        Me.pnlUser.Controls.Add(Me.tbxUserNickName)
        Me.pnlUser.Controls.Add(Me.tbxUserName)
        Me.pnlUser.Controls.Add(Me.lblPerfil)
        Me.pnlUser.Location = New System.Drawing.Point(188, 119)
        Me.pnlUser.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlUser.Name = "pnlUser"
        Me.pnlUser.Size = New System.Drawing.Size(241, 48)
        Me.pnlUser.TabIndex = 30
        Me.pnlUser.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(437, 75)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(105, 25)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Nickname:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(201, 139)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 25)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Rol:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(184, 75)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 25)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Nombre:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlRecentActivity
        '
        Me.pnlRecentActivity.BackColor = System.Drawing.Color.Transparent
        Me.pnlRecentActivity.Location = New System.Drawing.Point(8, 273)
        Me.pnlRecentActivity.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlRecentActivity.Name = "pnlRecentActivity"
        Me.pnlRecentActivity.Size = New System.Drawing.Size(849, 283)
        Me.pnlRecentActivity.TabIndex = 15
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.BackColor = System.Drawing.Color.Transparent
        Me.btnSaveChanges.FlatAppearance.BorderSize = 0
        Me.btnSaveChanges.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Thistle
        Me.btnSaveChanges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle
        Me.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveChanges.ForeColor = System.Drawing.Color.White
        Me.btnSaveChanges.Image = CType(resources.GetObject("btnSaveChanges.Image"), System.Drawing.Image)
        Me.btnSaveChanges.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSaveChanges.Location = New System.Drawing.Point(728, 90)
        Me.btnSaveChanges.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(131, 97)
        Me.btnSaveChanges.TabIndex = 14
        Me.btnSaveChanges.Text = "Guardar Cambios"
        Me.btnSaveChanges.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSaveChanges.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSaveChanges.UseVisualStyleBackColor = False
        Me.btnSaveChanges.Visible = False
        '
        'lblRecentActivity
        '
        Me.lblRecentActivity.AutoSize = True
        Me.lblRecentActivity.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecentActivity.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRecentActivity.Location = New System.Drawing.Point(56, 236)
        Me.lblRecentActivity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRecentActivity.Name = "lblRecentActivity"
        Me.lblRecentActivity.Size = New System.Drawing.Size(300, 39)
        Me.lblRecentActivity.TabIndex = 13
        Me.lblRecentActivity.Text = "Actividad Reciente"
        Me.lblRecentActivity.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'صورة_دائرة1
        '
        Me.صورة_دائرة1.BackColor = System.Drawing.Color.Transparent
        Me.صورة_دائرة1.BackgroundImage = CType(resources.GetObject("صورة_دائرة1.BackgroundImage"), System.Drawing.Image)
        Me.صورة_دائرة1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.صورة_دائرة1.Location = New System.Drawing.Point(8, 54)
        Me.صورة_دائرة1.Margin = New System.Windows.Forms.Padding(4)
        Me.صورة_دائرة1.Name = "صورة_دائرة1"
        Me.صورة_دائرة1.Size = New System.Drawing.Size(185, 167)
        Me.صورة_دائرة1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.صورة_دائرة1.TabIndex = 12
        Me.صورة_دائرة1.TabStop = False
        '
        'tbxUserRole
        '
        Me.tbxUserRole.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.tbxUserRole.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxUserRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxUserRole.ForeColor = System.Drawing.Color.White
        Me.tbxUserRole.Location = New System.Drawing.Point(223, 167)
        Me.tbxUserRole.Margin = New System.Windows.Forms.Padding(4)
        Me.tbxUserRole.Name = "tbxUserRole"
        Me.tbxUserRole.Size = New System.Drawing.Size(212, 30)
        Me.tbxUserRole.TabIndex = 10
        Me.tbxUserRole.Text = "user name"
        Me.tbxUserRole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbxUserNickName
        '
        Me.tbxUserNickName.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.tbxUserNickName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxUserNickName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxUserNickName.ForeColor = System.Drawing.Color.White
        Me.tbxUserNickName.Location = New System.Drawing.Point(459, 103)
        Me.tbxUserNickName.Margin = New System.Windows.Forms.Padding(4)
        Me.tbxUserNickName.Name = "tbxUserNickName"
        Me.tbxUserNickName.Size = New System.Drawing.Size(287, 30)
        Me.tbxUserNickName.TabIndex = 9
        Me.tbxUserNickName.Text = "user name"
        Me.tbxUserNickName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbxUserName
        '
        Me.tbxUserName.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.tbxUserName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxUserName.ForeColor = System.Drawing.Color.White
        Me.tbxUserName.Location = New System.Drawing.Point(219, 103)
        Me.tbxUserName.Margin = New System.Windows.Forms.Padding(4)
        Me.tbxUserName.Name = "tbxUserName"
        Me.tbxUserName.Size = New System.Drawing.Size(212, 30)
        Me.tbxUserName.TabIndex = 8
        Me.tbxUserName.Text = "user name"
        Me.tbxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPerfil
        '
        Me.lblPerfil.AutoSize = True
        Me.lblPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerfil.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPerfil.Location = New System.Drawing.Point(33, 0)
        Me.lblPerfil.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPerfil.Name = "lblPerfil"
        Me.lblPerfil.Size = New System.Drawing.Size(95, 39)
        Me.lblPerfil.TabIndex = 7
        Me.lblPerfil.Text = "Perfil"
        Me.lblPerfil.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnAdministrateRequests
        '
        Me.btnAdministrateRequests.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAdministrateRequests.FlatAppearance.BorderSize = 0
        Me.btnAdministrateRequests.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Thistle
        Me.btnAdministrateRequests.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle
        Me.btnAdministrateRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdministrateRequests.Image = CType(resources.GetObject("btnAdministrateRequests.Image"), System.Drawing.Image)
        Me.btnAdministrateRequests.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAdministrateRequests.Location = New System.Drawing.Point(0, 167)
        Me.btnAdministrateRequests.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdministrateRequests.Name = "btnAdministrateRequests"
        Me.btnAdministrateRequests.Size = New System.Drawing.Size(180, 85)
        Me.btnAdministrateRequests.TabIndex = 29
        Me.btnAdministrateRequests.Text = "Reservar Aula"
        Me.btnAdministrateRequests.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdministrateRequests.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAdministrateRequests.UseVisualStyleBackColor = False
        '
        'btnUserLately
        '
        Me.btnUserLately.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnUserLately.FlatAppearance.BorderSize = 0
        Me.btnUserLately.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Thistle
        Me.btnUserLately.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle
        Me.btnUserLately.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserLately.Image = CType(resources.GetObject("btnUserLately.Image"), System.Drawing.Image)
        Me.btnUserLately.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUserLately.Location = New System.Drawing.Point(0, 55)
        Me.btnUserLately.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUserLately.Name = "btnUserLately"
        Me.btnUserLately.Size = New System.Drawing.Size(180, 85)
        Me.btnUserLately.TabIndex = 28
        Me.btnUserLately.Text = "NombreUsuario"
        Me.btnUserLately.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUserLately.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnUserLately.UseVisualStyleBackColor = False
        '
        'lblColumn
        '
        Me.lblColumn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblColumn.Location = New System.Drawing.Point(-4, 0)
        Me.lblColumn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColumn.Name = "lblColumn"
        Me.lblColumn.Size = New System.Drawing.Size(184, 825)
        Me.lblColumn.TabIndex = 8
        '
        'HomeRegularUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(1067, 825)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "HomeRegularUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HomeRegularUser"
        Me.pnlPrincipal.ResumeLayout(False)
        Me.pnlClassReservation.ResumeLayout(False)
        Me.pnlClassReservation.PerformLayout()
        CType(Me.dgvClasses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHorarioReservacion.ResumeLayout(False)
        Me.pnlHorarioReservacion.PerformLayout()
        Me.pnlUser.ResumeLayout(False)
        Me.pnlUser.PerformLayout()
        CType(Me.صورة_دائرة1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents pnlPrincipal As Panel
    Friend WithEvents lblColumn As Label
    Friend WithEvents btnAdministrateRequests As Button
    Friend WithEvents btnUserLately As Button
    Friend WithEvents pnlUser As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents pnlRecentActivity As Panel
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents lblRecentActivity As Label
    Friend WithEvents صورة_دائرة1 As PictureBoxAbouAmmar.صورة_دائرة
    Friend WithEvents tbxUserRole As TextBox
    Friend WithEvents tbxUserNickName As TextBox
    Friend WithEvents tbxUserName As TextBox
    Friend WithEvents lblPerfil As Label
    Friend WithEvents lblDescripcionBoton As Label
    Friend WithEvents lblBienvenida As Label
    Friend WithEvents pnlClassReservation As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblClassReservation As Label
    Friend WithEvents pnlHorarioReservacion As Panel
    Friend WithEvents Label49 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents tbxHoraFinal As TextBox
    Friend WithEvents Label53 As Label
    Friend WithEvents tbxHoraInicial As TextBox
    Friend WithEvents Label54 As Label
    Friend WithEvents tbxMotivo As TextBox
    Friend WithEvents Label55 As Label
    Friend WithEvents cbxDia As ComboBox
    Friend WithEvents Label56 As Label
    Friend WithEvents lblHorario As Label
    Friend WithEvents btnSaveReservation As Button
    Friend WithEvents dgvClasses As DataGridView
    Friend WithEvents btnSearchReservations As Button
    Friend WithEvents btnCancelReservation As Button
    Friend WithEvents lblClassroom As Label
    Friend WithEvents txbClassroom As TextBox
End Class
