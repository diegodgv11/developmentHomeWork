<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_registroClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RB_eliminar = New System.Windows.Forms.RadioButton()
        Me.RB_modificar = New System.Windows.Forms.RadioButton()
        Me.RB_registrar = New System.Windows.Forms.RadioButton()
        Me.GB_controles = New System.Windows.Forms.GroupBox()
        Me.Btn_aceptar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RB_eliminar)
        Me.GroupBox1.Controls.Add(Me.RB_modificar)
        Me.GroupBox1.Controls.Add(Me.RB_registrar)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(539, 71)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selecciona un modo"
        '
        'RB_eliminar
        '
        Me.RB_eliminar.AutoSize = True
        Me.RB_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RB_eliminar.Location = New System.Drawing.Point(385, 29)
        Me.RB_eliminar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RB_eliminar.Name = "RB_eliminar"
        Me.RB_eliminar.Size = New System.Drawing.Size(132, 24)
        Me.RB_eliminar.TabIndex = 2
        Me.RB_eliminar.TabStop = True
        Me.RB_eliminar.Text = "Eliminar cliente"
        Me.RB_eliminar.UseVisualStyleBackColor = True
        '
        'RB_modificar
        '
        Me.RB_modificar.AutoSize = True
        Me.RB_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RB_modificar.Location = New System.Drawing.Point(203, 29)
        Me.RB_modificar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RB_modificar.Name = "RB_modificar"
        Me.RB_modificar.Size = New System.Drawing.Size(140, 24)
        Me.RB_modificar.TabIndex = 1
        Me.RB_modificar.TabStop = True
        Me.RB_modificar.Text = "Modificar cliente"
        Me.RB_modificar.UseVisualStyleBackColor = True
        '
        'RB_registrar
        '
        Me.RB_registrar.AutoSize = True
        Me.RB_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RB_registrar.Location = New System.Drawing.Point(23, 29)
        Me.RB_registrar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RB_registrar.Name = "RB_registrar"
        Me.RB_registrar.Size = New System.Drawing.Size(141, 24)
        Me.RB_registrar.TabIndex = 0
        Me.RB_registrar.TabStop = True
        Me.RB_registrar.Text = "Registrar cliente"
        Me.RB_registrar.UseVisualStyleBackColor = True
        '
        'GB_controles
        '
        Me.GB_controles.Enabled = False
        Me.GB_controles.Location = New System.Drawing.Point(18, 88)
        Me.GB_controles.Name = "GB_controles"
        Me.GB_controles.Size = New System.Drawing.Size(539, 159)
        Me.GB_controles.TabIndex = 1
        Me.GB_controles.TabStop = False
        Me.GB_controles.Text = "Modo"
        '
        'Btn_aceptar
        '
        Me.Btn_aceptar.Enabled = False
        Me.Btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_aceptar.Location = New System.Drawing.Point(18, 253)
        Me.Btn_aceptar.Name = "Btn_aceptar"
        Me.Btn_aceptar.Size = New System.Drawing.Size(539, 39)
        Me.Btn_aceptar.TabIndex = 2
        Me.Btn_aceptar.Text = "Aceptar"
        Me.Btn_aceptar.UseVisualStyleBackColor = True
        '
        'Frm_registroClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(569, 303)
        Me.Controls.Add(Me.Btn_aceptar)
        Me.Controls.Add(Me.GB_controles)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_registroClientes"
        Me.Text = "Registrar clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RB_eliminar As RadioButton
    Friend WithEvents RB_modificar As RadioButton
    Friend WithEvents RB_registrar As RadioButton
    Friend WithEvents GB_controles As GroupBox
    Friend WithEvents Btn_aceptar As Button
End Class
