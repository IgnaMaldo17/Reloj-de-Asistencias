'Importamos las funciones sqlClient
Imports System.Data.SqlClient
Imports Entidades
Public Class clsEMP
    'Heredamos la clase conexion para utilizar sus metodos
    Inherits clsConexion
    'Creamos un sqlCommand para conectarnos a los procedimientos de sql
    Dim cmd As New SqlCommand

    Public Function GetNombreApellido(empleado As EEMP) As DataTable
        With cmd
            'Utilizamos el metodo de la clase clsConexion para conectarnos
            Conectado()
            'Establecemos el procedidmiento que vamos a ejecutar
            cmd = New SqlCommand("SP_EMP_GET_NAME")
            'Establecemos el tipo de comando que vamos a ejecutar, en este caso procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            'Agreamos los valores de los parametros del procedimiento, en este caso dos 
            cmd.Parameters.AddWithValue("@emp_id", empleado.EMP_ID)
            'Agregamos la cadena de conexion
            cmd.Connection = con
            'Establecemos el tiempo maximo de espera a respuesta de sql
            cmd.CommandTimeout = 9999
            'Creamos una variable del tipo DataTable para almacenar el resultado
            Dim dt As New DataTable
            'Creamos una variable dataAdpater para ajustar el resultado al DataTable
            Dim da As New SqlDataAdapter(cmd)
            'Se agrega el resultado del procedimiento al DataTable
            da.Fill(dt)
            'Como paso final de la funcion devolvemos el resultado
            Return dt
        End With
    End Function

    Public Function GetEmpleados() As DataTable
        With cmd
            'Utilizamos el metodo de la clase clsConexion para conectarnos
            Conectado()
            'Establecemos el procedidmiento que vamos a ejecutar
            cmd = New SqlCommand("SP_EMP_LIST")
            'Establecemos el tipo de comando que vamos a ejecutar, en este caso procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            'Agregamos la cadena de conexion
            cmd.Connection = con
            'Creamos una variable del tipo DataTable para almacenar el resultado
            Dim dt As New DataTable
            'Creamos una variable dataAdpater para ajustar el resultado al DataTable
            Dim da As New SqlDataAdapter(cmd)
            'Se agrega el resultado del procedimiento al DataTable
            da.Fill(dt)
            'Como paso final de la funcion devolvemos el resultado
            Return dt
        End With
    End Function
    Public Function GetEmpleadosEli() As DataTable
        With cmd
            'Utilizamos el metodo de la clase clsConexion para conectarnos
            Conectado()
            'Establecemos el procedidmiento que vamos a ejecutar
            cmd = New SqlCommand("SP_EMP_LIST_ELI")
            'Establecemos el tipo de comando que vamos a ejecutar, en este caso procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            'Agregamos la cadena de conexion
            cmd.Connection = con
            'Creamos una variable del tipo DataTable para almacenar el resultado
            Dim dt As New DataTable
            'Creamos una variable dataAdpater para ajustar el resultado al DataTable
            Dim da As New SqlDataAdapter(cmd)
            'Se agrega el resultado del procedimiento al DataTable
            da.Fill(dt)
            'Como paso final de la funcion devolvemos el resultado
            Return dt
        End With
    End Function

    Public Function DelEmp(id As Integer, id_eliminador As Integer) As Boolean
        With cmd
            'Utilizamos el metodo de la clase clsConexion para conectarnos
            Conectado()
            'Establecemos el procedidmiento que vamos a ejecutar
            cmd = New SqlCommand("SP_EMP_DEL")
            'Establecemos el tipo de comando que vamos a ejecutar, en este caso procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@EMP_ID", id)
            cmd.Parameters.AddWithValue("@EMP_BAJ_ID", id_eliminador)
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

    Public Function RecEmp(id As Integer) As Boolean
        With cmd
            'Utilizamos el metodo de la clase clsConexion para conectarnos
            Conectado()
            'Establecemos el procedidmiento que vamos a ejecutar
            cmd = New SqlCommand("SP_EMP_REC")
            'Establecemos el tipo de comando que vamos a ejecutar, en este caso procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@EMP_ID", id)
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

    Public Function InsEmp(empleado As EEMP) As Boolean
        With cmd
            'Utilizamos el metodo de la clase clsConexion para conectarnos
            Conectado()
            'Establecemos el procedidmiento que vamos a ejecutar
            cmd = New SqlCommand("SP_EMP_INS")
            'Establecemos el tipo de comando que vamos a ejecutar, en este caso procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure


            cmd.Parameters.AddWithValue("@EMP_ID", empleado.EMP_ID)
            cmd.Parameters.AddWithValue("@EMP_DNI", empleado.EMP_DNI)
            cmd.Parameters.AddWithValue("@EMP_APE", empleado.EMP_APE)
            cmd.Parameters.AddWithValue("@EMP_NOM", empleado.EMP_NOM)
            cmd.Parameters.AddWithValue("@EMP_DIR", empleado.EMP_DIR)
            cmd.Parameters.AddWithValue("@EMP_SEC_ID", empleado.EMP_SEC_ID)
            cmd.Parameters.AddWithValue("@EMP_DAT_NAC", empleado.EMP_DAT_NAC)
            cmd.Parameters.AddWithValue("@EMP_CRE_ID", empleado.EMP_CRE_ID)


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

    Public Function UpdEmp(empleado As EEMP) As Boolean
        With cmd
            'Utilizamos el metodo de la clase clsConexion para conectarnos
            Conectado()
            'Establecemos el procedidmiento que vamos a ejecutar
            cmd = New SqlCommand("SP_EMP_UPD")
            'Establecemos el tipo de comando que vamos a ejecutar, en este caso procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@EMP_ID", empleado.EMP_ID)
            cmd.Parameters.AddWithValue("@EMP_ID2", empleado.EMP_ID)
            cmd.Parameters.AddWithValue("@EMP_DNI", empleado.EMP_DNI)
            cmd.Parameters.AddWithValue("@EMP_APE", empleado.EMP_APE)
            cmd.Parameters.AddWithValue("@EMP_NOM", empleado.EMP_NOM)
            cmd.Parameters.AddWithValue("@EMP_DIR", empleado.EMP_DIR)
            cmd.Parameters.AddWithValue("@EMP_SEC_ID", empleado.EMP_SEC_ID)
            cmd.Parameters.AddWithValue("@EMP_DAT_NAC", empleado.EMP_DAT_NAC)




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
