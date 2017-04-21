<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Horas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlPrincipal = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAM = New System.Windows.Forms.Button()
        Me.btnPM = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.pnlPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.pnlPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPrincipal.Controls.Add(Me.btn0)
        Me.pnlPrincipal.Controls.Add(Me.btn9)
        Me.pnlPrincipal.Controls.Add(Me.btn8)
        Me.pnlPrincipal.Controls.Add(Me.btn7)
        Me.pnlPrincipal.Controls.Add(Me.btn6)
        Me.pnlPrincipal.Controls.Add(Me.btn5)
        Me.pnlPrincipal.Controls.Add(Me.btn4)
        Me.pnlPrincipal.Controls.Add(Me.btn3)
        Me.pnlPrincipal.Controls.Add(Me.btn2)
        Me.pnlPrincipal.Controls.Add(Me.btn1)
        Me.pnlPrincipal.Controls.Add(Me.btnCancel)
        Me.pnlPrincipal.Controls.Add(Me.btnOK)
        Me.pnlPrincipal.Controls.Add(Me.btnPM)
        Me.pnlPrincipal.Controls.Add(Me.btnAM)
        Me.pnlPrincipal.Controls.Add(Me.Label1)
        Me.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(162, 192)
        Me.pnlPrincipal.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label1.Location = New System.Drawing.Point(3, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "--:--"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAM
        '
        Me.btnAM.FlatAppearance.BorderSize = 0
        Me.btnAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAM.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnAM.Location = New System.Drawing.Point(-1, 135)
        Me.btnAM.Name = "btnAM"
        Me.btnAM.Size = New System.Drawing.Size(30, 23)
        Me.btnAM.TabIndex = 5
        Me.btnAM.Text = "am"
        Me.btnAM.UseVisualStyleBackColor = True
        '
        'btnPM
        '
        Me.btnPM.FlatAppearance.BorderSize = 0
        Me.btnPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPM.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnPM.Location = New System.Drawing.Point(127, 135)
        Me.btnPM.Name = "btnPM"
        Me.btnPM.Size = New System.Drawing.Size(30, 23)
        Me.btnPM.TabIndex = 6
        Me.btnPM.Text = "pm"
        Me.btnPM.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.FlatAppearance.BorderSize = 0
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnOK.Location = New System.Drawing.Point(51, 164)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(30, 23)
        Me.btnOK.TabIndex = 7
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnCancel.Location = New System.Drawing.Point(78, 164)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(30, 23)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "x"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.FlatAppearance.BorderSize = 0
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn1.Location = New System.Drawing.Point(6, 43)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(30, 23)
        Me.btn1.TabIndex = 9
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.FlatAppearance.BorderSize = 0
        Me.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn2.Location = New System.Drawing.Point(62, 43)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(30, 23)
        Me.btn2.TabIndex = 10
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.FlatAppearance.BorderSize = 0
        Me.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn3.Location = New System.Drawing.Point(119, 43)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(30, 23)
        Me.btn3.TabIndex = 11
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.FlatAppearance.BorderSize = 0
        Me.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn4.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn4.Location = New System.Drawing.Point(6, 72)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(30, 23)
        Me.btn4.TabIndex = 12
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.FlatAppearance.BorderSize = 0
        Me.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn5.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn5.Location = New System.Drawing.Point(62, 72)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(30, 23)
        Me.btn5.TabIndex = 13
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.FlatAppearance.BorderSize = 0
        Me.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn6.Location = New System.Drawing.Point(119, 72)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(30, 23)
        Me.btn6.TabIndex = 14
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.FlatAppearance.BorderSize = 0
        Me.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn7.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn7.Location = New System.Drawing.Point(6, 101)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(30, 23)
        Me.btn7.TabIndex = 15
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.FlatAppearance.BorderSize = 0
        Me.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn8.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn8.Location = New System.Drawing.Point(62, 101)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(30, 23)
        Me.btn8.TabIndex = 16
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.FlatAppearance.BorderSize = 0
        Me.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn9.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn9.Location = New System.Drawing.Point(119, 101)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(30, 23)
        Me.btn9.TabIndex = 17
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.FlatAppearance.BorderSize = 0
        Me.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn0.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn0.Location = New System.Drawing.Point(62, 135)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(30, 23)
        Me.btn0.TabIndex = 18
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'Horas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(162, 192)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Horas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Horas"
        Me.pnlPrincipal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlPrincipal As Panel
    Friend WithEvents btnPM As Button
    Friend WithEvents btnAM As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn0 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOK As Button
End Class
