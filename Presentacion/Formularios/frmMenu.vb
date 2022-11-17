Public Class frmMenu

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        frmPrincipal.AbrirFormulario(frmUSR)
    End Sub
    Private Sub btnCambiarContraseña_Click(sender As Object, e As EventArgs) Handles btnCambiarContraseña.Click
        frmCambiarContraseña.ShowDialog()
    End Sub
    Private Sub btnUsuarios_MouseHover(sender As Object, e As EventArgs) Handles btnUsuarios.MouseHover
        MouseArriba(sender, "ABM Usuarios: Permite la modificación de información sobre los usuarios del sistema.")
    End Sub
    Private Sub btnCambiarContraseña_MouseHover(sender As Object, e As EventArgs) Handles btnCambiarContraseña.MouseHover
        MouseArriba(sender, "Permite el cambio de contraseña del usuario logeado.")
    End Sub

    Private Sub btnPersonal_MouseHover(sender As Object, e As EventArgs) Handles btnPersonal.MouseHover
        MouseArriba(sender, "ABM Personal: Permite la administración de Personal a ser controlado por el control de asistencias.")
    End Sub
    Private Sub btnFichador_MouseHover(sender As Object, e As EventArgs) Handles btnFichador.MouseHover
        MouseArriba(sender, "Interface encargada de registrar activamente ingresos/egresos del personal.")
    End Sub
    Private Sub MouseArriba(objeto As Object, mensaje As String)
        objeto.Cursor = Cursors.Hand
        lblDescripcion.Text = mensaje
    End Sub
    Private Sub btnFichador_Leave(sender As Object, e As EventArgs) Handles btnUsuarios.Leave, btnPersonal.Leave, btnFichador.Leave, btnCambiarContraseña.Leave
        ClearLabel(lblDescripcion)
    End Sub

    Private Sub btnFichador_Click(sender As Object, e As EventArgs) Handles btnFichador.Click
        frmPrincipal.AbrirFormulario(frmRegistroAsistencias)
    End Sub

    Private Sub btnPersonal_Click(sender As Object, e As EventArgs) Handles btnPersonal.Click
        frmPrincipal.AbrirFormulario(frmEMP)
    End Sub
End Class