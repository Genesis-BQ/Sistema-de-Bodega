<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal2
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FuncionariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalidaProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChequeoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FuncionariosToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.ProductoToolStripMenuItem, Me.AcercaDeToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(725, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FuncionariosToolStripMenuItem
        '
        Me.FuncionariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoToolStripMenuItem})
        Me.FuncionariosToolStripMenuItem.Name = "FuncionariosToolStripMenuItem"
        Me.FuncionariosToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.FuncionariosToolStripMenuItem.Text = "Funcionarios"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarEmpleadoToolStripMenuItem})
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'IngresarEmpleadoToolStripMenuItem
        '
        Me.IngresarEmpleadoToolStripMenuItem.Name = "IngresarEmpleadoToolStripMenuItem"
        Me.IngresarEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.IngresarEmpleadoToolStripMenuItem.Text = "Ingresar Empleado"
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarProductoToolStripMenuItem, Me.RegistroProductoToolStripMenuItem, Me.SalidaProductoToolStripMenuItem, Me.ChequeoToolStripMenuItem})
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.ProductoToolStripMenuItem.Text = "Producto"
        '
        'RegistrarProductoToolStripMenuItem
        '
        Me.RegistrarProductoToolStripMenuItem.Name = "RegistrarProductoToolStripMenuItem"
        Me.RegistrarProductoToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.RegistrarProductoToolStripMenuItem.Text = "Registrar Producto"
        '
        'RegistroProductoToolStripMenuItem
        '
        Me.RegistroProductoToolStripMenuItem.Name = "RegistroProductoToolStripMenuItem"
        Me.RegistroProductoToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.RegistroProductoToolStripMenuItem.Text = "Entrada Producto"
        '
        'SalidaProductoToolStripMenuItem
        '
        Me.SalidaProductoToolStripMenuItem.Name = "SalidaProductoToolStripMenuItem"
        Me.SalidaProductoToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.SalidaProductoToolStripMenuItem.Text = "Salida Producto"
        '
        'ChequeoToolStripMenuItem
        '
        Me.ChequeoToolStripMenuItem.Name = "ChequeoToolStripMenuItem"
        Me.ChequeoToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ChequeoToolStripMenuItem.Text = "Chequeo"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca De"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'FrmPrincipal2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(725, 329)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FrmPrincipal2"
        Me.Text = "Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresarEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalidaProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChequeoToolStripMenuItem As ToolStripMenuItem
End Class
