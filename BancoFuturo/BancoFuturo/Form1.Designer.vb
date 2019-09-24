<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.IngresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepositoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RetiroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransferenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarCuentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarDepositoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarRetiroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarTransferenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarCuentasPorClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarTransferenciasPorCuentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarDepositoPorCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarRetirosPorCuentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusquedasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusquedaDeCuentasPorSaldoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusquedaDeDepositoPorMontoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusquedaDeRetirosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusquedaDeTransferenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresosToolStripMenuItem, Me.OperacionesToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.BusquedasToolStripMenuItem, Me.AcercaDeToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(608, 31)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'IngresosToolStripMenuItem
        '
        Me.IngresosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarClienteToolStripMenuItem, Me.RegistrarCuentaToolStripMenuItem})
        Me.IngresosToolStripMenuItem.Name = "IngresosToolStripMenuItem"
        Me.IngresosToolStripMenuItem.Size = New System.Drawing.Size(81, 25)
        Me.IngresosToolStripMenuItem.Text = "Ingresos"
        '
        'RegistrarClienteToolStripMenuItem
        '
        Me.RegistrarClienteToolStripMenuItem.Name = "RegistrarClienteToolStripMenuItem"
        Me.RegistrarClienteToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.RegistrarClienteToolStripMenuItem.Text = "Registrar Cliente"
        '
        'RegistrarCuentaToolStripMenuItem
        '
        Me.RegistrarCuentaToolStripMenuItem.Name = "RegistrarCuentaToolStripMenuItem"
        Me.RegistrarCuentaToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.RegistrarCuentaToolStripMenuItem.Text = "Registrar Cuenta"
        '
        'OperacionesToolStripMenuItem
        '
        Me.OperacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepositoToolStripMenuItem, Me.RetiroToolStripMenuItem, Me.TransferenciaToolStripMenuItem})
        Me.OperacionesToolStripMenuItem.Name = "OperacionesToolStripMenuItem"
        Me.OperacionesToolStripMenuItem.Size = New System.Drawing.Size(109, 25)
        Me.OperacionesToolStripMenuItem.Text = "Operaciones"
        '
        'DepositoToolStripMenuItem
        '
        Me.DepositoToolStripMenuItem.Name = "DepositoToolStripMenuItem"
        Me.DepositoToolStripMenuItem.Size = New System.Drawing.Size(173, 26)
        Me.DepositoToolStripMenuItem.Text = "Deposito"
        '
        'RetiroToolStripMenuItem
        '
        Me.RetiroToolStripMenuItem.Name = "RetiroToolStripMenuItem"
        Me.RetiroToolStripMenuItem.Size = New System.Drawing.Size(173, 26)
        Me.RetiroToolStripMenuItem.Text = "Retiro"
        '
        'TransferenciaToolStripMenuItem
        '
        Me.TransferenciaToolStripMenuItem.Name = "TransferenciaToolStripMenuItem"
        Me.TransferenciaToolStripMenuItem.Size = New System.Drawing.Size(173, 26)
        Me.TransferenciaToolStripMenuItem.Text = "Transferencia"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarClientesToolStripMenuItem, Me.ConsultarCuentasToolStripMenuItem, Me.ConsultarDepositoToolStripMenuItem, Me.ConsultarRetiroToolStripMenuItem, Me.ConsultarTransferenciasToolStripMenuItem, Me.ConsultarCuentasPorClienteToolStripMenuItem, Me.ConsultarTransferenciasPorCuentasToolStripMenuItem, Me.ConsultarDepositoPorCuentaToolStripMenuItem, Me.ConsultarRetirosPorCuentasToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(90, 25)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'ConsultarClientesToolStripMenuItem
        '
        Me.ConsultarClientesToolStripMenuItem.Name = "ConsultarClientesToolStripMenuItem"
        Me.ConsultarClientesToolStripMenuItem.Size = New System.Drawing.Size(336, 26)
        Me.ConsultarClientesToolStripMenuItem.Text = "Consultar Clientes"
        '
        'ConsultarCuentasToolStripMenuItem
        '
        Me.ConsultarCuentasToolStripMenuItem.Name = "ConsultarCuentasToolStripMenuItem"
        Me.ConsultarCuentasToolStripMenuItem.Size = New System.Drawing.Size(336, 26)
        Me.ConsultarCuentasToolStripMenuItem.Text = "Consultar Cuentas"
        '
        'ConsultarDepositoToolStripMenuItem
        '
        Me.ConsultarDepositoToolStripMenuItem.Name = "ConsultarDepositoToolStripMenuItem"
        Me.ConsultarDepositoToolStripMenuItem.Size = New System.Drawing.Size(336, 26)
        Me.ConsultarDepositoToolStripMenuItem.Text = "Consultar Deposito"
        '
        'ConsultarRetiroToolStripMenuItem
        '
        Me.ConsultarRetiroToolStripMenuItem.Name = "ConsultarRetiroToolStripMenuItem"
        Me.ConsultarRetiroToolStripMenuItem.Size = New System.Drawing.Size(336, 26)
        Me.ConsultarRetiroToolStripMenuItem.Text = "Consultar Retiro"
        '
        'ConsultarTransferenciasToolStripMenuItem
        '
        Me.ConsultarTransferenciasToolStripMenuItem.Name = "ConsultarTransferenciasToolStripMenuItem"
        Me.ConsultarTransferenciasToolStripMenuItem.Size = New System.Drawing.Size(336, 26)
        Me.ConsultarTransferenciasToolStripMenuItem.Text = "Consultar Transferencias"
        '
        'ConsultarCuentasPorClienteToolStripMenuItem
        '
        Me.ConsultarCuentasPorClienteToolStripMenuItem.Name = "ConsultarCuentasPorClienteToolStripMenuItem"
        Me.ConsultarCuentasPorClienteToolStripMenuItem.Size = New System.Drawing.Size(336, 26)
        Me.ConsultarCuentasPorClienteToolStripMenuItem.Text = "Consultar Cuentas por Cliente"
        '
        'ConsultarTransferenciasPorCuentasToolStripMenuItem
        '
        Me.ConsultarTransferenciasPorCuentasToolStripMenuItem.Name = "ConsultarTransferenciasPorCuentasToolStripMenuItem"
        Me.ConsultarTransferenciasPorCuentasToolStripMenuItem.Size = New System.Drawing.Size(336, 26)
        Me.ConsultarTransferenciasPorCuentasToolStripMenuItem.Text = "Consultar Transferencias por cuentas"
        '
        'ConsultarDepositoPorCuentaToolStripMenuItem
        '
        Me.ConsultarDepositoPorCuentaToolStripMenuItem.Name = "ConsultarDepositoPorCuentaToolStripMenuItem"
        Me.ConsultarDepositoPorCuentaToolStripMenuItem.Size = New System.Drawing.Size(336, 26)
        Me.ConsultarDepositoPorCuentaToolStripMenuItem.Text = "Consultar Deposito por cuenta"
        '
        'ConsultarRetirosPorCuentasToolStripMenuItem
        '
        Me.ConsultarRetirosPorCuentasToolStripMenuItem.Name = "ConsultarRetirosPorCuentasToolStripMenuItem"
        Me.ConsultarRetirosPorCuentasToolStripMenuItem.Size = New System.Drawing.Size(336, 26)
        Me.ConsultarRetirosPorCuentasToolStripMenuItem.Text = "Consultar Retiros por cuentas"
        '
        'BusquedasToolStripMenuItem
        '
        Me.BusquedasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BusquedaDeCuentasPorSaldoToolStripMenuItem, Me.BusquedaDeDepositoPorMontoToolStripMenuItem, Me.BusquedaDeRetirosToolStripMenuItem, Me.BusquedaDeTransferenciasToolStripMenuItem})
        Me.BusquedasToolStripMenuItem.Name = "BusquedasToolStripMenuItem"
        Me.BusquedasToolStripMenuItem.Size = New System.Drawing.Size(97, 25)
        Me.BusquedasToolStripMenuItem.Text = "Busquedas"
        '
        'BusquedaDeCuentasPorSaldoToolStripMenuItem
        '
        Me.BusquedaDeCuentasPorSaldoToolStripMenuItem.Name = "BusquedaDeCuentasPorSaldoToolStripMenuItem"
        Me.BusquedaDeCuentasPorSaldoToolStripMenuItem.Size = New System.Drawing.Size(313, 26)
        Me.BusquedaDeCuentasPorSaldoToolStripMenuItem.Text = "Busqueda de cuentas por saldo"
        '
        'BusquedaDeDepositoPorMontoToolStripMenuItem
        '
        Me.BusquedaDeDepositoPorMontoToolStripMenuItem.Name = "BusquedaDeDepositoPorMontoToolStripMenuItem"
        Me.BusquedaDeDepositoPorMontoToolStripMenuItem.Size = New System.Drawing.Size(313, 26)
        Me.BusquedaDeDepositoPorMontoToolStripMenuItem.Text = "Busqueda de Deposito por monto"
        '
        'BusquedaDeRetirosToolStripMenuItem
        '
        Me.BusquedaDeRetirosToolStripMenuItem.Name = "BusquedaDeRetirosToolStripMenuItem"
        Me.BusquedaDeRetirosToolStripMenuItem.Size = New System.Drawing.Size(313, 26)
        Me.BusquedaDeRetirosToolStripMenuItem.Text = "Busqueda de Retiros"
        '
        'BusquedaDeTransferenciasToolStripMenuItem
        '
        Me.BusquedaDeTransferenciasToolStripMenuItem.Name = "BusquedaDeTransferenciasToolStripMenuItem"
        Me.BusquedaDeTransferenciasToolStripMenuItem.Size = New System.Drawing.Size(313, 26)
        Me.BusquedaDeTransferenciasToolStripMenuItem.Text = "Busqueda de Transferencias"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(91, 25)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca De"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(53, 25)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(608, 365)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Banco Futuro"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents IngresosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarCuentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OperacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepositoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RetiroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransferenciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarCuentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarDepositoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarRetiroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarTransferenciasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarCuentasPorClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarTransferenciasPorCuentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarDepositoPorCuentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarRetirosPorCuentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BusquedasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BusquedaDeCuentasPorSaldoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BusquedaDeDepositoPorMontoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BusquedaDeRetirosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BusquedaDeTransferenciasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
