Imports Datos
Imports Entidades
Public Class frmEMP

    Dim UsuarioFun As New clsEMP
    Dim UsuarioDatos As New EEMP
    Dim UsuarioFun2 As New clsSEC
    Dim UsuarioDatos2 As New ESEC
    Dim bandera As Boolean = True
    'Dim ent As Integer = 5
    'Dim a As TextBox

#Region "Procesos"


    'Private Sub Test()
    '    Select Case ent
    '        Case 0 : a = txtID2
    '        Case 1 : a = txtDNI
    '        Case 2 : a = txtApellido
    '        Case 3 : a = txtNombre
    '        Case 6 : MensajeError("Error")
    '        Case 5 : MensajeError("Error")
    '        Case 4 : a = txtDireccion


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
        GetEmpAct()
        rdActivos.Checked = True
        habilitaciones(Me.gbDatos, 1)
        cbSector.Enabled = False

        dtpFecNac.Enabled = False



        CargacmSector()
        cbSector.Text = ""
    End Sub

    Private Sub GetEmpEli()
        dgvEmpleados.DataSource = UsuarioFun.GetEmpleadosEli()
    End Sub
    Private Sub Determinar()
        If rdActivos.Checked = True Then
            GetEmpAct()
            tsbHabilitar.Enabled = False
        Else
            GetEmpEli()
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
        txtID2.Focus()
    End Sub

    Private Sub GetEmpAct()
        dgvEmpleados.DataSource = UsuarioFun.GetEmpleados()
        dgvEmpleados.Columns(8).Visible = False
    End Sub

    Private Sub CargacmSector()
        cbSector.DataSource = UsuarioFun2.GetSectores()
        cbSector.ValueMember = "ID"
        cbSector.DisplayMember = "NOMBRE"
    End Sub
#End Region

#Region "Eventos"

    Private Sub frmEMP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicio()

    End Sub

    Private Sub rdActivos_CheckedChanged(sender As Object, e As EventArgs) Handles rdActivos.CheckedChanged
        Determinar()
    End Sub

    Private Sub rdEliminados_CheckedChanged(sender As Object, e As EventArgs) Handles rdEliminados.CheckedChanged
        Determinar()
    End Sub

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
        frmPrincipal.AbrirFormulario(frmMenu)
    End Sub

    Private Sub tsbNuevo_Click(sender As Object, e As EventArgs) Handles tsbNuevo.Click
        habilitar()
        cbSector.Enabled = True
        dtpFecNac.Enabled = True
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Inicio()
    End Sub



    Private Sub dgvEmpleados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleados.CellDoubleClick
        habilitar()
        txtID2.Enabled = False
        cbSector.Enabled = True
        dtpFecNac.Enabled = True
        bandera = False
        tsbEliminar.Enabled = True
        If rdEliminados.Checked = True Then
            tsbHabilitar.Enabled = True
        End If
        txtID2.Text = dgvEmpleados.SelectedCells(0).Value.ToString()
        txtDNI.Text = dgvEmpleados.SelectedCells(1).Value.ToString()
        txtApellido.Text = dgvEmpleados.SelectedCells(2).Value.ToString()
        txtNombre.Text = dgvEmpleados.SelectedCells(3).Value.ToString()
        txtDireccion.Text = dgvEmpleados.SelectedCells(4).Value.ToString()
        cbSector.SelectedValue = dgvEmpleados.SelectedCells(8).Value.ToString()
        dtpFecNac.Value = dgvEmpleados.SelectedCells(6).Value.ToString()

    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click
        ep.Clear()
        campoblanco(Me.gbDatos, ep)

        Dim Usuario As New clsSEC
        Dim tabla As New DataTable
        tabla = Usuario.CmbVer(cbSector.SelectedValue)

        If tabla(0)(0) = 2 Then


            If banbl = True Then

                UsuarioDatos.EMP_ID = txtID2.Text
                UsuarioDatos.EMP_DNI = txtDNI.Text
                UsuarioDatos.EMP_APE = txtApellido.Text
                UsuarioDatos.EMP_NOM = txtNombre.Text
                UsuarioDatos.EMP_DIR = txtDireccion.Text
                UsuarioDatos.EMP_SEC_ID = cbSector.SelectedValue
                UsuarioDatos.EMP_DAT_NAC = dtpFecNac.Value
                UsuarioDatos.EMP_CRE_ID = idUser

                If bandera Then
                    If UsuarioFun.InsEmp(UsuarioDatos) Then
                        MensajeError("Registro grabado exitosamente.")
                        Inicio()
                    Else
                        MensajeError("Sucedio un error al intentar grabar el empleado.")
                    End If
                Else
                    UsuarioDatos.EMP_ID = txtID2.Text
                    If UsuarioFun.UpdEmp(UsuarioDatos) Then
                        MensajeError("Registro actualizado exitosamente.")
                        Inicio()
                    Else
                        MensajeError("Ocurrio un error al intentar guardar los cambios")
                    End If
                End If
            ElseIf banbl = False Then
                MensajeError("Hay uno o mas campos vacios")
                ep.Clear()
            End If



        Else
            'MensajeError("Contraseña incorrecta")
            ep.SetError(cbSector, "El sector es incorrecto.")
        End If





    End Sub

    Private Sub tsbHabilitar_Click(sender As Object, e As EventArgs) Handles tsbHabilitar.Click
        campoblanco(Me.gbDatos, ep)
        If banbl = True Then
            If UsuarioFun.RecEmp(txtID2.Text) Then
                Inicio()
            Else
                MensajeError("Hubo un error al intentar recuperar el empleado " & txtApellido.Text)
            End If
        ElseIf banbl = False Then
            MensajeError("Hay uno o mas campos vacios")
            ep.Clear()
        End If

    End Sub

    Private Sub tsbEliminar_Click(sender As Object, e As EventArgs) Handles tsbEliminar.Click
        Dim resultado As DialogResult = MessageBox.Show("Esta por eliminar un registro, ¿Desea continuar?", "Eliminar empleado " & txtApellido.Text & "," & txtNombre.Text, MessageBoxButtons.YesNoCancel)
        If resultado = DialogResult.Yes Then
            If UsuarioFun.DelEmp(txtID2.Text, idUser) Then
                Inicio()
            Else
                MensajeError("Hubo un error al intentar eliminar el empleado " & txtApellido.Text)
            End If
        End If
    End Sub




    Private Sub tsbImprimir_Click(sender As Object, e As EventArgs) Handles tsbImprimir.Click
        frmRepEmp.Show()
    End Sub

    Private Sub txtDNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDNI.KeyPress
        SoloInt(e, ep, txtDNI)
    End Sub

    Private Sub txtID2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID2.KeyPress
        SoloInt(e, ep, txtID2)
    End Sub

    Private Sub txtID2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtID2.KeyDown
        If e.Modifiers = Keys.Control Then
            e.Handled = True
            txtID2.ReadOnly = True
            MensajeError("No se puede usar atajos.")

        Else
            txtID2.ReadOnly = False
        End If
    End Sub

    Private Sub txtDNI_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDNI.KeyDown
        If e.Modifiers = Keys.Control Then
            e.Handled = True
            txtDNI.ReadOnly = True
            MensajeError("No se puede usar atajos.")

        Else
            txtDNI.ReadOnly = False
        End If
    End Sub


    'Private Sub tsbCopiar_Click(sender As Object, e As EventArgs) Handles tsbCopiar.Click

    '    If ent = 5 Or 6 Then

    '    Else
    '        Test()
    '        Copiar(a)
    '    End If
    'End Sub

    'Private Sub tsbPegar_Click(sender As Object, e As EventArgs) Handles tsbPegar.Click

    '    If ent = 5 Or 6 Then

    '    Else
    '        Test()
    '        Pegar(a)
    '    End If

    'End Sub

    'Private Sub tsbCortar_Click(sender As Object, e As EventArgs) Handles tsbCortar.Click
    '    If ent = 5 Or 6 Then

    '    Else
    '        Test()
    '        Cortar(a)
    '    End If


    'End Sub

    'Private Sub txtID2_Click(sender As Object, e As EventArgs) Handles txtID2.Click
    '    ent = 0
    'End Sub

    'Private Sub txtDNI_Click(sender As Object, e As EventArgs) Handles txtDNI.Click
    '    ent = 1
    'End Sub

    'Private Sub txtApellido_Click(sender As Object, e As EventArgs) Handles txtApellido.Click
    '    ent = 2
    'End Sub

    'Private Sub txtNombre_Click(sender As Object, e As EventArgs) Handles txtNombre.Click
    '    ent = 3
    'End Sub

    'Private Sub txtDireccion_Click(sender As Object, e As EventArgs) Handles txtDireccion.Click
    '    ent = 4
    'End Sub

    'Private Sub cbSector_Click(sender As Object, e As EventArgs) Handles cbSector.Click
    '    ent = 6
    'End Sub





#End Region

End Class