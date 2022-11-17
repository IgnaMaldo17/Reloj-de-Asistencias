'Importamos las funciones sqlClient
Imports System.Data.SqlClient
Imports Entidades
Public Class clsFIC
    'Heredamos la clase conexion para utilizar sus metodos
    Inherits clsConexion
    'Creamos un sqlCommand para conectarnos a los procedimientos de sql
    Dim cmd As New SqlCommand

    Public Function InsFic(fichada As EFIC) As Boolean
        With cmd
            'Utilizamos el metodo de la clase clsConexion para conectarnos
            Conectado()
            'Establecemos el procedidmiento que vamos a ejecutar
            cmd = New SqlCommand("SP_FIC_INS")
            'Establecemos el tipo de comando que vamos a ejecutar, en este caso procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@FIC_EMP_ID", fichada.FIC_EMP_ID)
            cmd.Parameters.AddWithValue("@FIC_ALT_PC", fichada.FIC_ALT_PC)
            'Agregamos la cadena de conexion
            cmd.Connection = con
            'Creamos una variable del tipo DataTable para almacenar el resultado
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        End With
    End Function
End Class
