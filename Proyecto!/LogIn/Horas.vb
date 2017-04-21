Public Class Horas
    Dim NewPoint As New System.Drawing.Point
    Dim X, Y As Integer
    Private Sub pnlPrincipal_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlPrincipal.MouseMove
        If e.Button = MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Me.Location = NewPoint

        End If
    End Sub

    Private Sub pnlPrincipal_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlPrincipal.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub
    Private Sub lblMinimize_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class