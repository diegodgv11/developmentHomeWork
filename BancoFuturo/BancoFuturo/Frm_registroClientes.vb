Public Class Frm_registroClientes
    Dim LabelD1, LabelD2, LabelD3, LabelD4, LabelD5, LabelD6, LabelD7, LabelD8 As New Label()
    Dim LabelD9, LabelD10, LabelD11, LabelD12, LabelD13, LabelD14, LabelD15, LabelD16 As New Label()
    Dim TextBoxD1, TextBoxD2, TextBoxD3, TextBoxD4, TextBoxD5, TextBoxD6, TextBoxD7, TextBoxD8 As New TextBox()
    Dim TextBoxD9, TextBoxD10, TextBoxD11, TextBoxD12, TextBoxD13, TextBoxD14, TextBoxD15, TextBoxD16 As New TextBox()
    Dim ButtonD1 As Button
    Public Function correlativoClientes() As Integer
        Dim toca As Integer
        If (BaseDeDatos.EjecutarProcedure("correlativoCliente")) Then
            Try
                tabla.Read()
                toca = tabla(0) + 1
            Catch ex As Exception
                toca = InputBox("Indique el correlativo inicial")
            End Try
        End If
        BaseDeDatos.cerrarConexion()
        Return toca
    End Function
    Private Sub RB_registrar_CheckedChanged(sender As Object, e As EventArgs) Handles RB_registrar.CheckedChanged
        If RB_registrar.Checked Then
            GB_controles.Text = "Registrar cliente"
            GB_controles.Controls.Clear()
            ' ID '
            LabelD1.Name = "Label_ID"
            LabelD1.Text = "ID:"
            LabelD1.Size = New Size(30, 20)
            LabelD1.Location = New Point(12, 28)
            GB_controles.Controls.Add(LabelD1)

            TextBoxD1.Name = "Txt_ID"
            TextBoxD1.BorderStyle = BorderStyle.FixedSingle
            TextBoxD1.Size = New Size(161, 28)
            TextBoxD1.Location = New Point(75, 26)
            GB_controles.Controls.Add(TextBoxD1)
            ' DPI '
            LabelD2.Name = "Label_DPI"
            LabelD2.Text = "DPI:"
            LabelD2.Size = New Size(42, 20)
            LabelD2.Location = New Point(12, 56)
            GB_controles.Controls.Add(LabelD2)

            TextBoxD2.Name = "Txt_DPI"
            TextBoxD2.BorderStyle = BorderStyle.FixedSingle
            TextBoxD2.Size = New Size(161, 26)
            TextBoxD2.Location = New Point(75, 54)
            GB_controles.Controls.Add(TextBoxD2)
            ' Nombre '
            LabelD3.Name = "Label_Nombre"
            LabelD3.Text = "Nombre:"
            LabelD3.Size = New Size(70, 26)
            LabelD3.Location = New Point(12, 84)
            GB_controles.Controls.Add(LabelD3)

            TextBoxD3.Name = "Txt_Nombre"
            TextBoxD3.BorderStyle = BorderStyle.FixedSingle
            TextBoxD3.Size = New Size(151, 26)
            TextBoxD3.Location = New Point(85, 82)
            GB_controles.Controls.Add(TextBoxD3)
            ' Apellido
            LabelD4.Name = "Label_Apellido"
            LabelD4.Text = "Apellido:"
            LabelD4.Size = New Size(69, 20)
            LabelD4.Location = New Point(251, 30)
            GB_controles.Controls.Add(LabelD4)

            TextBoxD4.Name = "Txt_Apellido"
            TextBoxD4.BorderStyle = BorderStyle.FixedSingle
            TextBoxD4.Size = New Size(197, 26)
            TextBoxD4.Location = New Point(326, 27)
            GB_controles.Controls.Add(TextBoxD4)
            ' Dirección
            LabelD5.Name = "Label_Direccion"
            LabelD5.Text = "Dirección:"
            LabelD5.Size = New Size(79, 20)
            LabelD5.Location = New Point(251, 58)
            GB_controles.Controls.Add(LabelD5)

            TextBoxD5.Name = "Txt_Direccion"
            TextBoxD5.BorderStyle = BorderStyle.FixedSingle
            TextBoxD5.Size = New Size(187, 26)
            TextBoxD5.Location = New Point(336, 55)
            GB_controles.Controls.Add(TextBoxD5)
            ' Teléfono
            LabelD6.Name = "Label_Telefono"
            LabelD6.Text = "Teléfono:"
            LabelD6.Size = New Size(75, 20)
            LabelD6.Location = New Point(251, 87)
            GB_controles.Controls.Add(LabelD6)

            TextBoxD6.Name = "Txt_Telefono"
            TextBoxD6.BorderStyle = BorderStyle.FixedSingle
            TextBoxD6.Size = New Size(197, 26)
            TextBoxD6.Location = New Point(326, 84)
            GB_controles.Controls.Add(TextBoxD6)
            ' Email
            LabelD7.Name = "Label_Email"
            LabelD7.Text = "Email:"
            LabelD7.Size = New Size(52, 20)
            LabelD7.Location = New Point(251, 116)
            GB_controles.Controls.Add(LabelD7)

            TextBoxD7.Name = "Txt_Email"
            TextBoxD7.BorderStyle = BorderStyle.FixedSingle
            TextBoxD7.Size = New Size(209, 26)
            TextBoxD7.Location = New Point(314, 113)
            GB_controles.Controls.Add(TextBoxD7)

            GB_controles.Enabled = True
            Btn_aceptar.Enabled = True
            ' Boton restaurar correlativo '
            Dim ButtonD1 As New Button()
            AddHandler ButtonD1.Click, AddressOf establecerCorrelativo
            ButtonD1.Text = "Restaurar Correlativo"
            ButtonD1.FlatStyle = FlatStyle.Flat
            ButtonD1.Size = New Size(220, 28)
            ButtonD1.Location = New Point(16, 113)
            GB_controles.Controls.Add(ButtonD1)

            GB_controles.Enabled = True
            Btn_aceptar.Text = "Registrar"

            ' metodos de inicialización
            TextBoxD1.Text = correlativoClientes()
        End If
    End Sub
    Private Sub RB_modificar_CheckedChanged(sender As Object, e As EventArgs) Handles RB_modificar.CheckedChanged
        If RB_modificar.Checked Then
            GB_controles.Text = "Modificar cliente"
            GB_controles.Controls.Clear()
            ' ID '
            LabelD9.Name = "Label_ID"
            LabelD9.Text = "ID:"
            LabelD9.Size = New Size(30, 20)
            LabelD9.Location = New Point(12, 28)
            GB_controles.Controls.Add(LabelD9)

            TextBoxD9.Name = "Txt_ID"
            TextBoxD9.BorderStyle = BorderStyle.FixedSingle
            TextBoxD9.Size = New Size(161, 28)
            TextBoxD9.Location = New Point(75, 26)
            GB_controles.Controls.Add(TextBoxD9)
            ' DPI '
            LabelD10.Name = "Label_DPI"
            LabelD10.Text = "DPI:"
            LabelD10.Size = New Size(42, 20)
            LabelD10.Location = New Point(12, 56)
            GB_controles.Controls.Add(LabelD10)

            TextBoxD10.Name = "Txt_DPI"
            TextBoxD10.BorderStyle = BorderStyle.FixedSingle
            TextBoxD10.Size = New Size(161, 26)
            TextBoxD10.Location = New Point(75, 54)
            GB_controles.Controls.Add(TextBoxD10)
            ' Nombre '
            LabelD11.Name = "Label_Nombre"
            LabelD11.Text = "Nombre:"
            LabelD11.Size = New Size(70, 26)
            LabelD11.Location = New Point(12, 84)
            GB_controles.Controls.Add(LabelD11)

            TextBoxD11.Name = "Txt_Nombre"
            TextBoxD11.BorderStyle = BorderStyle.FixedSingle
            TextBoxD11.Size = New Size(151, 26)
            TextBoxD11.Location = New Point(85, 82)
            GB_controles.Controls.Add(TextBoxD11)
            ' Apellido
            LabelD12.Name = "Label_Apellido"
            LabelD12.Text = "Apellido:"
            LabelD12.Size = New Size(69, 20)
            LabelD12.Location = New Point(251, 30)
            GB_controles.Controls.Add(LabelD12)

            TextBoxD12.Name = "Txt_Apellido"
            TextBoxD12.BorderStyle = BorderStyle.FixedSingle
            TextBoxD12.Size = New Size(197, 26)
            TextBoxD12.Location = New Point(326, 27)
            GB_controles.Controls.Add(TextBoxD12)
            ' Dirección
            LabelD13.Name = "Label_Direccion"
            LabelD13.Text = "Dirección:"
            LabelD13.Size = New Size(79, 20)
            LabelD13.Location = New Point(251, 58)
            GB_controles.Controls.Add(LabelD13)

            TextBoxD13.Name = "Txt_Direccion"
            TextBoxD13.BorderStyle = BorderStyle.FixedSingle
            TextBoxD13.Size = New Size(187, 26)
            TextBoxD13.Location = New Point(336, 55)
            GB_controles.Controls.Add(TextBoxD13)
            ' Teléfono
            LabelD14.Name = "Label_Telefono"
            LabelD14.Text = "Teléfono:"
            LabelD14.Size = New Size(75, 20)
            LabelD14.Location = New Point(251, 87)
            GB_controles.Controls.Add(LabelD14)

            TextBoxD14.Name = "Txt_Telefono"
            TextBoxD14.BorderStyle = BorderStyle.FixedSingle
            TextBoxD14.Size = New Size(197, 26)
            TextBoxD14.Location = New Point(326, 84)
            GB_controles.Controls.Add(TextBoxD14)
            ' Email
            LabelD15.Name = "Label_Email"
            LabelD15.Text = "Email:"
            LabelD15.Size = New Size(52, 20)
            LabelD15.Location = New Point(251, 116)
            GB_controles.Controls.Add(LabelD15)

            TextBoxD15.Name = "Txt_Email"
            TextBoxD15.BorderStyle = BorderStyle.FixedSingle
            TextBoxD15.Size = New Size(209, 26)
            TextBoxD15.Location = New Point(314, 113)
            GB_controles.Controls.Add(TextBoxD15)

            GB_controles.Enabled = True
            Btn_aceptar.Text = "Modificar"
        End If
    End Sub

    Private Sub RB_eliminar_CheckedChanged(sender As Object, e As EventArgs) Handles RB_eliminar.CheckedChanged
        If RB_eliminar.Checked Then
            GB_controles.Text = "Eliminar cliente"
            GB_controles.Controls.Clear()

            LabelD8.Name = "Label_eliminar"
            LabelD8.Text = "ID del cliente a eliminar:"
            LabelD8.Size = New Size(176, 20)
            LabelD8.Location = New Point(177, 53)
            GB_controles.Controls.Add(LabelD8)

            TextBoxD8.Name = "Txt_IDEliminar"
            TextBoxD8.BorderStyle = BorderStyle.FixedSingle
            TextBoxD8.Size = New Size(244, 26)
            TextBoxD8.Location = New Point(146, 76)
            GB_controles.Controls.Add(TextBoxD8)

            GB_controles.Enabled = True
            Btn_aceptar.Text = "Eliminar"
        End If
    End Sub
    Private Sub establecerCorrelativo()
        TextBoxD1.Text = correlativoClientes()
    End Sub
    Private Sub Btn_aceptar_Click(sender As Object, e As EventArgs) Handles Btn_aceptar.Click
        If RB_registrar.Checked Then
            Dim datos(7) As String
            datos = {TextBoxD1.Text,
                    TextBoxD2.Text,
                    TextBoxD3.Text,
                    TextBoxD4.Text,
                    TextBoxD5.Text,
                    TextBoxD6.Text,
                    TextBoxD7.Text}
            If ejecutarProcedureAdvance("agregarCliente", datos) Then
                MsgBox("Cliente ingresado exitosamente")
            End If
            cerrarConexion()
        ElseIf RB_modificar.Checked Then
            Dim datos(7) As String
            datos = {TextBoxD9.Text,
                    TextBoxD10.Text,
                    TextBoxD11.Text,
                    TextBoxD12.Text,
                    TextBoxD13.Text,
                    TextBoxD14.Text,
                    TextBoxD15.Text}
            If ejecutarProcedureAdvance("modificarCliente", datos) Then
                MsgBox("Cliente modificado exitosamente")
            End If
            cerrarConexion()
        ElseIf RB_eliminar.Checked Then
            If ejecutarProcedureAdvance("eliminarCliente", {TextBoxD8.Text}) Then
                MsgBox("Cliente eliminado exitosamente")
            End If
            cerrarConexion()
        End If
    End Sub
End Class