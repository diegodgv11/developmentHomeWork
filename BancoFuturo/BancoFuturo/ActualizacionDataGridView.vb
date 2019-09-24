Module ActualizacionDataGridView
    Public Sub llenarDGV(dgv As DataGridView, procedimiento As String)
        Dim contador As Integer
        Dim columnas As Integer

        dgv.Rows.Clear()
        columnas = dgv.Columns.Count()
        Dim datos(columnas) As String

        If EjecutarProcedure(procedimiento) Then
            While tabla.Read
                contador = 0
                While contador < columnas
                    datos(contador) = tabla(contador)
                    contador += 1
                End While
                dgv.Rows.Add(datos)
            End While
        End If

        BaseDeDatos.cerrarConexion()

    End Sub
End Module
