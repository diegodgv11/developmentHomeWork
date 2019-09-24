Module BaseDeDatos
    'Conexion'
    Public miconexion As New SqlClient.SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Banco.mdf;Integrated Security=True")
    'Ejecutor de comandos'
    Public cmdSql As New SqlClient.SqlCommand()
    'Data Reader lector de datos'
    Public tabla As SqlClient.SqlDataReader


    Public Function AbrirConexion() As Boolean
        Try
            miconexion.Open()
            cmdSql.Connection = miconexion
            cmdSql.CommandType = CommandType.Text
            Return True

        Catch ex As Exception

            MsgBox("Error en la base de datos" + ex.Message)
            Return False
        End Try
    End Function

    Public Function EjecutarProcedure(qProcedure As String) As Boolean
        Dim strSql As String
        strSql = "exec " + qProcedure
        cmdSql.CommandText = strSql
        AbrirConexion()
        Try
            'obteniendo respuestas registros en el reader.
            tabla = cmdSql.ExecuteReader
            Return True

        Catch ex As Exception
            MsgBox("Error en la linea SQL " + ex.Message)
            Return False
        End Try
    End Function


    Public Function EjecutarProcedureNoQuery(qProcedure As String) As Boolean
        Dim strSql As String
        strSql = "exec " + qProcedure
        cmdSql.CommandText = strSql
        AbrirConexion()
        Try
            'obteniendo respuestas registros en el reader.
            cmdSql.ExecuteNonQuery()
            Return True

        Catch ex As Exception
            MsgBox("Error en la linea SQL " + ex.Message)
            Return False
        End Try
    End Function
    Public Sub cerrarConexion()
        miconexion.Close()
    End Sub
    Public Function ejecutarProcedureAdvance(procedure As String, datos() As String) As Boolean
        Dim cadena As String
        Dim i As Integer = 0
        cadena = $"{procedure} "
        If EjecutarProcedure($"obtenerParametros @procedimiento = {procedure}") Then
            While tabla.Read
                If i = 0 Then
                    cadena &= " " & tabla(0) & $"={datos(i)}"
                    i += 1
                Else
                    cadena &= " " & tabla(0) & $"='{datos(i)}'"
                    i += 1
                End If
            End While
        Else
            Return False
        End If
        MsgBox(cadena)
        Return True
    End Function
End Module
