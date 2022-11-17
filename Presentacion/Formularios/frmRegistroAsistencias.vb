Imports Datos
Imports Entidades

Public Class frmRegistroAsistencias
    Dim ficharFunciones As New clsFIC
    Dim ficharDatos As New EFIC
    Dim EmpleadoFunciones As New clsEMP
    Dim EmpleadoDatos As New EEMP
    Private Sub frmRegistroAsistencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblHora.Text = Date.Now
        tmrDateTime.Interval = 1000  ' Un segundo
        tmrDateTime.Start()
        txtbarra.Focus()
    End Sub
    Private Sub tmrDateTime_Tick(sender As Object, e As EventArgs) Handles tmrDateTime.Tick
        Me.lblHora.Text = Date.Now
    End Sub

    Private Sub FichadaOk(objeto As Object)
        objeto.BackColor = Color.GreenYellow
        objeto.forecolor = Color.White
    End Sub

    Private Sub FichadaBad(objeto As Object)
        txtCodigo.Clear()
        objeto.BackColor = Color.Red
        objeto.forecolor = Color.White
    End Sub
    Private Sub txtCodigo_Click(sender As Object, e As EventArgs) Handles txtPersonal.Click, txtCodigo.Click, pbUsuario.Click, pbLogo.Click, pbCodigo.Click, lblHora.Click
        txtbarra.Focus()
    End Sub

    Private Sub txtbarra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbarra.KeyPress
        Try
            If e.KeyChar = ChrW(Keys.Enter) Then
                Dim i As Integer
                Dim cadena As String = ""
                If txtbarra.TextLength = 8 Then
                    cadena = txtbarra.Text
                Else
                    For i = 3 To 10
                        cadena = cadena & (txtbarra.Text.Chars(i))
                    Next i
                End If

                txtCodigo.Text = cadena
                ficharDatos.FIC_EMP_ID = CInt(cadena)
                ficharDatos.FIC_ALT_PC = My.Computer.Name
                If ficharFunciones.InsFic(ficharDatos) Then
                    EmpleadoDatos.EMP_ID = txtCodigo.Text
                    Dim data As DataTable = EmpleadoFunciones.GetNombreApellido(EmpleadoDatos)
                    txtPersonal.Text = data.Rows(0)(0).ToString
                    FichadaOk(sender)
                    FichadaOk(txtPersonal)
                    FichadaOk(txtCodigo)
                End If
                txtbarra.Clear()
                txtbarra.Focus()
            End If

        Catch ex As Exception
            FichadaBad(sender)
            FichadaBad(txtPersonal)
            FichadaBad(txtCodigo)
            txtPersonal.Text = "Legajo Erróneo"
        End Try
    End Sub
End Class