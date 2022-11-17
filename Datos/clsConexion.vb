Imports System.Data.SqlClient

Public Class clsConexion
    'Creamos un objeto del tipo SqlConnection
    Public con As New SqlConnection
    'Funcion Conectado nos permitira realizar una conexion a un servidor y base especificado en el objeto con
    Public Function Conectado()
        Try
            'Agregamos al objeto las credenciales del servidor sql
            con = New SqlConnection("data source=DESKTOP-4GDEKQI\SQLEXPRESS02;initial catalog=Sistema; Integrated Security = True")
            'Abrimos la conexion
            con.Open()
            'Retornamos el valor true para informar el exito de la conexion
            Return True
        Catch ex As Exception
            'Si sucede algun error, informamos por mensaje de pantalla el detalle
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    'Una vez que tenemos resultados de la base siempre deberemos cerrar la conexion para no ocupar recursos sin sentido del servidor sql
    Public Function Desconectado()
        Try
            'Preguntamos si la conexion esta abierta
            If con.State = ConnectionState.Open Then
                'Si esto es asi, cerramos la conexion
                con.Close()
                'Devolvemos el valor true para informar que la conexion se encuentra cerrada
                Return True
            Else
                'Devolvemos el valor true para informar que la conexion se encuentra cerrada
                Return True
            End If
        Catch ex As Exception
            'Si sucede algun error, informamos por mensaje de pantalla el detalle
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Class