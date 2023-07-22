<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEntrada
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
        Me.CmbProducto = New System.Windows.Forms.ComboBox()
        Me.Dgv_Entrada = New System.Windows.Forms.DataGridView()
        Me.Lblidentificacion = New System.Windows.Forms.Label()
        Me.Txtcantidad = New System.Windows.Forms.TextBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.LblProducto = New System.Windows.Forms.Label()
        Me.LblCantidad = New System.Windows.Forms.Label()
        Me.Txtidentificacion = New System.Windows.Forms.TextBox()
        Me.Dgv_Productos = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegresarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.Dgv_Entrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmbProducto
        '
        Me.CmbProducto.FormattingEnabled = True
        Me.CmbProducto.Location = New System.Drawing.Point(146, 63)
        Me.CmbProducto.Name = "CmbProducto"
        Me.CmbProducto.Size = New System.Drawing.Size(147, 21)
        Me.CmbProducto.TabIndex = 0
        '
        'Dgv_Entrada
        '
        Me.Dgv_Entrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Entrada.Location = New System.Drawing.Point(12, 170)
        Me.Dgv_Entrada.Name = "Dgv_Entrada"
        Me.Dgv_Entrada.Size = New System.Drawing.Size(481, 243)
        Me.Dgv_Entrada.TabIndex = 1
        '
        'Lblidentificacion
        '
        Me.Lblidentificacion.AutoSize = True
        Me.Lblidentificacion.Location = New System.Drawing.Point(56, 30)
        Me.Lblidentificacion.Name = "Lblidentificacion"
        Me.Lblidentificacion.Size = New System.Drawing.Size(70, 13)
        Me.Lblidentificacion.TabIndex = 2
        Me.Lblidentificacion.Text = "Identificacion"
        '
        'Txtcantidad
        '
        Me.Txtcantidad.Location = New System.Drawing.Point(433, 30)
        Me.Txtcantidad.Name = "Txtcantidad"
        Me.Txtcantidad.Size = New System.Drawing.Size(147, 20)
        Me.Txtcantidad.TabIndex = 3
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(505, 65)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 4
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'LblProducto
        '
        Me.LblProducto.AutoSize = True
        Me.LblProducto.Location = New System.Drawing.Point(76, 66)
        Me.LblProducto.Name = "LblProducto"
        Me.LblProducto.Size = New System.Drawing.Size(50, 13)
        Me.LblProducto.TabIndex = 5
        Me.LblProducto.Text = "Producto"
        '
        'LblCantidad
        '
        Me.LblCantidad.AutoSize = True
        Me.LblCantidad.Location = New System.Drawing.Point(329, 33)
        Me.LblCantidad.Name = "LblCantidad"
        Me.LblCantidad.Size = New System.Drawing.Size(98, 13)
        Me.LblCantidad.TabIndex = 6
        Me.LblCantidad.Text = "Cantidad a ingresar"
        '
        'Txtidentificacion
        '
        Me.Txtidentificacion.Location = New System.Drawing.Point(146, 30)
        Me.Txtidentificacion.Name = "Txtidentificacion"
        Me.Txtidentificacion.Size = New System.Drawing.Size(147, 20)
        Me.Txtidentificacion.TabIndex = 7
        '
        'Dgv_Productos
        '
        Me.Dgv_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Productos.Location = New System.Drawing.Point(505, 170)
        Me.Dgv_Productos.Name = "Dgv_Productos"
        Me.Dgv_Productos.Size = New System.Drawing.Size(267, 243)
        Me.Dgv_Productos.TabIndex = 8
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegresarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RegresarToolStripMenuItem
        '
        Me.RegresarToolStripMenuItem.Name = "RegresarToolStripMenuItem"
        Me.RegresarToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.RegresarToolStripMenuItem.Text = "Regresar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'FrmEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(784, 425)
        Me.Controls.Add(Me.Dgv_Productos)
        Me.Controls.Add(Me.Txtidentificacion)
        Me.Controls.Add(Me.LblCantidad)
        Me.Controls.Add(Me.LblProducto)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.Txtcantidad)
        Me.Controls.Add(Me.Lblidentificacion)
        Me.Controls.Add(Me.Dgv_Entrada)
        Me.Controls.Add(Me.CmbProducto)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmEntrada"
        Me.Text = "FrmEntrada"
        CType(Me.Dgv_Entrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbProducto As ComboBox
    Friend WithEvents Dgv_Entrada As DataGridView
    Friend WithEvents Lblidentificacion As Label
    Friend WithEvents Txtcantidad As TextBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents LblProducto As Label
    Friend WithEvents LblCantidad As Label
    Friend WithEvents Txtidentificacion As TextBox
    Friend WithEvents Dgv_Productos As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RegresarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
