Imports Datos
Imports Entidades
Public Class frmCambiarContraseña
    Dim UsuarioFun As New clsUSR
    Dim UsuarioDatos As New EUSR
    Dim bandera As Boolean = True
    Dim banchg As Boolean = False


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub


    Private Sub btnCambiar_Click(sender As Object, e As EventArgs) Handles btnCambiar.Click

        ep.Clear()

        campoblanco(gbPasChg, ep)
        If banbl = True Then

            Dim Usuario As New clsUSR
            Dim tabla As New DataTable
            tabla = Usuario.PasVer(txtUsuario.Text, txtpassword.Text)

            If tabla(0)(0) = 2 Then

                If txtNewPass.Text <> txtNewPass2.Text Then
                    ep.SetError(txtNewPass2, "Los passwords no coinciden.")
                    'MensajeError("Los passwords no coinciden")
                    Return
                End If


                UsuarioDatos.USR_PAS = txtpassword.Text
                UsuarioDatos.USR_NIC = txtUsuario.Text
                UsuarioFun.ChgPas(UsuarioDatos, Me.txtNewPass.Text)
                MensajeError("Contraseña cambiada con éxito.")

                Me.Close()

            Else
                'MensajeError("Contraseña incorrecta")
                ep.SetError(txtpassword, "Contraseña incorrecta.")
            End If

        ElseIf banbl = False Then
            MensajeError("Hay uno o mas campos vacíos.")
            ep.Clear()
        End If

    End Sub

    Private Sub frmCambiarContraseña_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Inicio()
    End Sub

    Private Sub txtNewPass2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNewPass2.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnCambiar_Click(sender, e)
        End If
    End Sub

    'Private Sub chkMostrar_CheckedChanged(sender As Object, e As EventArgs)
    '    If chkMostrar.Checked = True Then
    '        txtpassword.PasswordChar = ""
    '        txtNewPass.PasswordChar = ""
    '        txtNewPass2.PasswordChar = ""
    '    Else
    '        txtpassword.PasswordChar = "*"
    '        txtNewPass.PasswordChar = "*"
    '        txtNewPass2.PasswordChar = "*"
    '    End If
    'End Sub

    Private Sub Inicio()


        txtpassword.PasswordChar = "*"
        txtNewPass.PasswordChar = "*"
        txtNewPass2.PasswordChar = "*"
        ClearText(txtpassword)
        ClearText(txtNewPass)
        ClearText(txtNewPass2)
        txtUsuario.Text = nicUser
        txtUsuario.Enabled = False
        'chkMostrar.Checked = False
        HideDef(pb1)
        HideDef(pb2)
        HideDef(pb3)


    End Sub

    Private Sub pb1_Click(sender As Object, e As EventArgs) Handles pb1.Click
        ShowHide(txtpassword, pb1)

    End Sub

    Private Sub pb2_Click(sender As Object, e As EventArgs) Handles pb2.Click
        ShowHide(txtNewPass, pb2)
    End Sub

    Private Sub pb3_Click(sender As Object, e As EventArgs) Handles pb3.Click
        ShowHide(txtNewPass2, pb3)
    End Sub
End Class