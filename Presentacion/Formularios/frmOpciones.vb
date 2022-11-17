Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmOpciones

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles tbNivel.Scroll
        'Cambio de opacidad del formulario actual se utiliza el valor del trackbar en el momento que se scrollea y se divide por 100 para 
        'lograr un valor correcto en opacidad que oscila entre 0 y 1
        frmPrincipal.Opacity = tbNivel.Value / 100
        lblTrackbar.Text = tbNivel.Value & "%"
    End Sub

    Private Sub frmOpciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se muestran los valores iniciales trackbar al momento de crear el formulario
        lblTrackbar.Text = tbNivel.Value & "%"
    End Sub
End Class