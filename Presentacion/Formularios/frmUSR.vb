Imports Datos
Imports Entidades

Public Class frmUSR
    Dim UsuarioFun As New clsUSR
    Dim UsuarioDatos As New EUSR
    Dim bandera As Boolean = True
    Dim ret As String
    'Dim ent As Integer = 5

    Dim a As TextBox

#Region "Procesos"

    'Private Sub Test()
    '    Select Case ent

    '        Case 1 : a = txtApellido
    '        Case 2 : a = txtNombre
    '        Case 3 : a = txtNickName
    '        Case 4 : MensajeError("Error")
    '        Case 6 : MensajeError("Error")
    '        Case 5 : MensajeError("Error")


    '    End Select
    'End Sub
    Private Sub Inicio()
        tsbCopiar.Enabled = False
        tsbPegar.Enabled = False
        tsbCortar.Enabled = False
        tsbEliminar.Enabled = False
        tsbCancelar.Enabled = False
        tsbGuardar.Enabled = False
        tsbNuevo.Enabled = True
        GetActivos()
        rdActivos.Checked = True
        habilitaciones(Me.gbDatos, 1)

    End Sub
    Private Sub GetActivos()
        dgvUsuarios.DataSource = UsuarioFun.GetUsuarios()
        'dgvUsuarios.Columns(5).Visible = False
    End Sub
    Private Sub GetElimminados()
        dgvUsuarios.DataSource = UsuarioFun.GetEliminados()
    End Sub
    Private Sub Determinar()
        If rdActivos.Checked = True Then
            GetActivos()
            tsbHabilitar.Enabled = False
        Else
            GetElimminados()
            tsbHabilitar.Enabled = True
        End If
    End Sub
    Private Sub habilitar()
        tsbCopiar.Enabled = True
        tsbPegar.Enabled = True
        tsbCortar.Enabled = True
        tsbEliminar.Enabled = False
        tsbCancelar.Enabled = True
        tsbGuardar.Enabled = True
        tsbNuevo.Enabled = False
        tsbHabilitar.Enabled = False
        bandera = True
        habilitaciones(Me.gbDatos, 2)
        txtApellido.Focus()
    End Sub

#End Region

#Region "Eventos"
    Private Sub frmUSR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicio()
    End Sub
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
        frmPrincipal.AbrirFormulario(frmMenu)
    End Sub
    Private Sub rdActivos_CheckedChanged(sender As Object, e As EventArgs) Handles rdActivos.CheckedChanged
        Determinar()
    End Sub
    Private Sub rdEliminados_CheckedChanged(sender As Object, e As EventArgs) Handles rdEliminados.CheckedChanged
        Determinar()
    End Sub
    Private Sub NuevoToolStripButton_Click(sender As Object, e As EventArgs) Handles tsbNuevo.Click
        habilitar()
    End Sub
    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Inicio()
    End Sub
    Private Sub dgvUsuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellDoubleClick

        habilitar()
        bandera = False
        tsbEliminar.Enabled = True
        If rdEliminados.Checked = True Then
            tsbHabilitar.Enabled = True
        End If
        txtID.Text = dgvUsuarios.SelectedCells(0).Value.ToString()
        txtApellido.Text = dgvUsuarios.SelectedCells(2).Value.ToString()
        txtNombre.Text = dgvUsuarios.SelectedCells(3).Value.ToString()
        ret = dgvUsuarios.SelectedCells(1).Value.ToString()
        txtNickName.Text = ret
        'txtPassword.Text = dgvUsuarios.SelectedCells(5).Value.ToString()
    End Sub
    Private Sub tsbEliminar_Click(sender As Object, e As EventArgs) Handles tsbEliminar.Click
        Dim resultado As DialogResult = MessageBox.Show("Esta por eliminar un registro, ¿Desea continuar?", "Eliminar usuario " & txtApellido.Text & "," & txtNombre.Text, MessageBoxButtons.YesNoCancel)
        If resultado = DialogResult.Yes Then
            If UsuarioFun.DelUsu(txtID.Text, idUser) Then
                Inicio()
            Else
                MensajeError("Hubo un error al intentar eliminar el usuario " & txtNickName.Text)
            End If
        End If
    End Sub
    Private Sub tsbHabilitar_Click(sender As Object, e As EventArgs) Handles tsbHabilitar.Click
        If UsuarioFun.RecUsu(txtID.Text) Then
            Inicio()
        Else
            MensajeError("Hubo un error al intentar recuperar el usuario " & txtNickName.Text)
        End If
    End Sub
    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click
        campoblanco(gbDatos, ep)
        If banbl = True Then

            ep.Clear()
            If txtPassword.Text <> txtPassword2.Text Then
                ep.SetError(txtPassword2, "Los passwords no coinciden")
                Return
            End If
            Dim Usuario As New clsUSR
            Dim tabla As New DataTable
            tabla = Usuario.UsuVer(txtNickName.Text)

            UsuarioDatos.USR_APE = txtApellido.Text
            UsuarioDatos.USR_NOM = txtNombre.Text
            UsuarioDatos.USR_PAS = txtPassword.Text
            UsuarioDatos.USR_NIC = txtNickName.Text
            UsuarioDatos.USR_CRE_ID = idUser
            If bandera Then



                If tabla(0)(0) = 0 Then
                    If UsuarioFun.InsUsu(UsuarioDatos) Then
                        MensajeError("Registro grabado exitosamente.")
                        Inicio()
                    Else
                        MensajeError("Sucedio un error al intentar grabar el usuario.")


                    End If
                Else
                    MensajeError("Usuario existente, intente con otro.")
                End If


            Else

                If tabla(0)(0) = 0 Or txtNickName.Text = ret Then
                    UsuarioDatos.USR_ID = txtID.Text
                    If UsuarioFun.UpdUsu(UsuarioDatos) Then
                        MensajeError("Registro actualizado exitosamente.")
                        Inicio()
                    Else
                        MensajeError("Ocurrio un error al intentar guardar los cambios")
                    End If
                Else
                    MensajeError("Usuario existente, intente con otro.")
                End If

            End If

        ElseIf banbl = True Then
            MensajeError("Hay uno o mas campos vacios")
            ep.Clear()
        End If
    End Sub

    Private Sub tsbImprimir_Click(sender As Object, e As EventArgs) Handles tsbImprimir.Click
        frmRepUsu.Show()
    End Sub

    'Private Sub tsbImprimir_Click(sender As Object, e As EventArgs) Handles tsbImprimir.Click
    '    frmRepUsu.Show()
    'End Sub

    'Private Sub txtApellido_Click(sender As Object, e As EventArgs) Handles txtApellido.Click
    '    ent = 1
    'End Sub

    'Private Sub txtNombre_Click(sender As Object, e As EventArgs) Handles txtNombre.Click
    '    ent = 2
    'End Sub

    'Private Sub txtNickName_Click(sender As Object, e As EventArgs) Handles txtNickName.Click
    '    ent = 3
    'End Sub

    'Private Sub txtPassword_Click(sender As Object, e As EventArgs) Handles txtPassword.Click
    '    ent = 4
    'End Sub

    'Private Sub txtPassword2_Click(sender As Object, e As EventArgs) Handles txtPassword2.Click
    '    ent = 6
    'End Sub

    'Private Sub tsbCortar_Click(sender As Object, e As EventArgs) Handles tsbCortar.Click
    '    If ent = 5 Or 6 Or 4 Then

    '    Else
    '        Test()
    '        Cortar(a)
    '    End If
    'End Sub

    'Private Sub tsbCopiar_Click(sender As Object, e As EventArgs) Handles tsbCopiar.Click
    '    If ent = 5 Or 6 Or 4 Then

    '    Else
    '        Test()
    '        Copiar(a)
    '    End If
    'End Sub

    'Private Sub tsbPegar_Click(sender As Object, e As EventArgs) Handles tsbPegar.Click
    '    If ent = 5 Or 6 Or 4 Then

    '    Else
    '        Test()
    '        Pegar(a)
    '    End If
    'End Sub






#End Region

End Class