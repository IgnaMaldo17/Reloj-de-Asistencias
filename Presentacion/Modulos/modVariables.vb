
Imports Datos
Imports Entidades
Module modVariables
    Dim UsuarioFun2 As New clsSEC
    Dim UsuarioDatos2 As New ESEC
    'Variables Publicas Datos Usuario
    Public nomUser As String
    Public apeUser As String
    Public nicUser As String
    Public idUser As Integer
    Public titulo As String = "Reloj de Asistencias"
    Public banbl As Boolean = True
    Public pasUser As String
    Public banpb As Boolean = True
    Public Sub habilitaciones(group As GroupBox, numero As Integer)
        For Each texto In group.Controls
            If numero = 1 Then
                If TypeOf texto Is TextBox Then
                    texto.clear()
                    texto.enabled = False
                    texto.forecolor = Color.Black
                    texto.backcolor = Color.White
                End If
            Else
                If TypeOf texto Is TextBox Then
                    If texto.name.ToString <> "txtID" Then
                        texto.enabled = True
                    End If
                End If
            End If
        Next
    End Sub

    Public Sub campoblanco(group As GroupBox, err As ErrorProvider)
        For Each texto In group.Controls

            If TypeOf texto Is TextBox Then
                If texto.text = "" And texto.name.ToString <> "txtID" Then
                    err.SetError(texto, "Hay uno o mas campos vacios")
                    banbl = False
                    Return
                End If
            End If


        Next

        banbl = True

    End Sub

    Public Sub ShowHide(txt As TextBox, pb As PictureBox)
        If txt.PasswordChar = "*" Then
            txt.PasswordChar = vbNullChar
            pb.Image = Image.FromFile("C:\IAES\2022\Medina\Medina Definitivo\Reloj de Asistencias\Presentacion\Resources\show.png")



        ElseIf txt.PasswordChar = vbNullChar Then
            txt.PasswordChar = "*"
            pb.Image = Image.FromFile("C:\IAES\2022\Medina\Medina Definitivo\Reloj de Asistencias\Presentacion\Resources\hide.png")


        End If
    End Sub

    Public Sub HideDef(pb As PictureBox)

        pb.Image = Image.FromFile("C:\IAES\2022\Medina\Medina Definitivo\Reloj de Asistencias\Presentacion\Resources\hide.png")

    End Sub





    Public Sub SoloInt(e As KeyPressEventArgs, err As ErrorProvider, texto As TextBox)

        err.Clear()

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            'MensajeError("Solo se puede escribir números.")
            err.SetError(texto, "Solo se puede escribir números.")
        End If


    End Sub


    Public Sub ClearLabel(labell As Label)
        labell.Text = ""

    End Sub

    Public Sub ClearText(text As TextBox)
        text.Text = ""

    End Sub

    Public Sub MensajeError(mensaje As String)
        frmPrincipal.niPrincipal.BalloonTipTitle = "Reloj de Asistencias"
        frmPrincipal.niPrincipal.BalloonTipText = mensaje
        frmPrincipal.niPrincipal.ShowBalloonTip(1000)
    End Sub


    'Public Sub Cortar(txt As TextBox)



    '    If Not txt.Text = "" Then
    '        Clipboard.SetText(txt.Text)
    '        txt.Text = ""
    '    End If

    'End Sub

    'Public Sub Pegar(txt As TextBox)
    '    txt.Text = txt.Text + Clipboard.GetText()
    'End Sub

    'Public Sub Copiar(txt As TextBox)
    '    If Not txt.Text = "" Then
    '        Clipboard.SetText(txt.Text)
    '    End If

    'End Sub





End Module