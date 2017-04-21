<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblForgottenPassword = New System.Windows.Forms.LinkLabel()
        Me.صورة_دائرة1 = New PictureBoxAbouAmmar.صورة_دائرة()
        Me.tbxUserPassword = New System.Windows.Forms.TextBox()
        Me.tbxUserName = New System.Windows.Forms.TextBox()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.lblMinimize = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.صورة_دائرة1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lblForgottenPassword)
        Me.Panel1.Controls.Add(Me.صورة_دائرة1)
        Me.Panel1.Controls.Add(Me.tbxUserPassword)
        Me.Panel1.Controls.Add(Me.tbxUserName)
        Me.Panel1.Controls.Add(Me.btnLogIn)
        Me.Panel1.Controls.Add(Me.lblMinimize)
        Me.Panel1.Controls.Add(Me.lblClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 600)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(78, 330)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 20)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "usuario"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(78, 380)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 20)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "contraseña"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblForgottenPassword
        '
        Me.lblForgottenPassword.ActiveLinkColor = System.Drawing.Color.Silver
        Me.lblForgottenPassword.AutoSize = True
        Me.lblForgottenPassword.LinkColor = System.Drawing.Color.Transparent
        Me.lblForgottenPassword.Location = New System.Drawing.Point(199, 448)
        Me.lblForgottenPassword.Name = "lblForgottenPassword"
        Me.lblForgottenPassword.Size = New System.Drawing.Size(116, 13)
        Me.lblForgottenPassword.TabIndex = 6
        Me.lblForgottenPassword.TabStop = True
        Me.lblForgottenPassword.Text = "¿Olvidó la contraseña?"
        '
        'صورة_دائرة1
        '
        Me.صورة_دائرة1.BackColor = System.Drawing.Color.Transparent
        Me.صورة_دائرة1.BackgroundImage = CType(resources.GetObject("صورة_دائرة1.BackgroundImage"), System.Drawing.Image)
        Me.صورة_دائرة1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.صورة_دائرة1.Location = New System.Drawing.Point(99, 135)
        Me.صورة_دائرة1.Name = "صورة_دائرة1"
        Me.صورة_دائرة1.Size = New System.Drawing.Size(219, 212)
        Me.صورة_دائرة1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.صورة_دائرة1.TabIndex = 5
        Me.صورة_دائرة1.TabStop = False
        '
        'tbxUserPassword
        '
        Me.tbxUserPassword.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.tbxUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxUserPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tbxUserPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxUserPassword.ForeColor = System.Drawing.Color.White
        Me.tbxUserPassword.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.tbxUserPassword.Location = New System.Drawing.Point(99, 403)
        Me.tbxUserPassword.Name = "tbxUserPassword"
        Me.tbxUserPassword.Size = New System.Drawing.Size(219, 24)
        Me.tbxUserPassword.TabIndex = 4
        Me.tbxUserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbxUserPassword.UseSystemPasswordChar = True
        '
        'tbxUserName
        '
        Me.tbxUserName.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.tbxUserName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxUserName.ForeColor = System.Drawing.Color.White
        Me.tbxUserName.Location = New System.Drawing.Point(96, 353)
        Me.tbxUserName.Name = "tbxUserName"
        Me.tbxUserName.Size = New System.Drawing.Size(219, 24)
        Me.tbxUserName.TabIndex = 3
        Me.tbxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnLogIn
        '
        Me.btnLogIn.BackColor = System.Drawing.Color.Transparent
        Me.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogIn.ForeColor = System.Drawing.Color.FloralWhite
        Me.btnLogIn.Location = New System.Drawing.Point(118, 475)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(170, 34)
        Me.btnLogIn.TabIndex = 2
        Me.btnLogIn.Text = "Ingresar"
        Me.btnLogIn.UseVisualStyleBackColor = False
        '
        'lblMinimize
        '
        Me.lblMinimize.BackColor = System.Drawing.Color.Transparent
        Me.lblMinimize.Image = CType(resources.GetObject("lblMinimize.Image"), System.Drawing.Image)
        Me.lblMinimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblMinimize.Location = New System.Drawing.Point(333, 0)
        Me.lblMinimize.Name = "lblMinimize"
        Me.lblMinimize.Size = New System.Drawing.Size(32, 32)
        Me.lblMinimize.TabIndex = 1
        '
        'lblClose
        '
        Me.lblClose.BackColor = System.Drawing.Color.Transparent
        Me.lblClose.Image = CType(resources.GetObject("lblClose.Image"), System.Drawing.Image)
        Me.lblClose.Location = New System.Drawing.Point(367, 0)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(32, 32)
        Me.lblClose.TabIndex = 0
        Me.lblClose.UseCompatibleTextRendering = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(400, 600)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.صورة_دائرة1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblClose As Label
    Friend WithEvents lblMinimize As Label
    Friend WithEvents btnLogIn As Button
    Friend WithEvents tbxUserPassword As TextBox
    Friend WithEvents tbxUserName As TextBox
    Friend WithEvents صورة_دائرة1 As PictureBoxAbouAmmar.صورة_دائرة
    Friend WithEvents lblForgottenPassword As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
End Class
