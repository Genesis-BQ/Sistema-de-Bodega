<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSalida
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
        Me.Dgv_Productos = New System.Windows.Forms.DataGridView()
        Me.Txtidentificacion = New System.Windows.Forms.TextBox()
        Me.LblCantidad = New System.Windows.Forms.Label()
        Me.LblProducto = New System.Windows.Forms.Label()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Txtcantidad = New System.Windows.Forms.TextBox()
        Me.Lblidentificacion = New System.Windows.Forms.Label()
        Me.Dgv_Salida = New System.Windows.Forms.DataGridView()
        Me.CmbProducto = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegresarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.Dgv_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_Salida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dgv_Productos
        '
        Me.Dgv_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Productos.Location = New System.Drawing.Point(555, 158)
        Me.Dgv_Productos.Name = "Dgv_Productos"
        Me.Dgv_Productos.Size = New System.Drawing.Size(225, 243)
        Me.Dgv_Productos.TabIndex = 17
        '
        'Txtidentificacion
        '
        Me.Txtidentificacion.Location = New System.Drawing.Point(154, 34)
        Me.Txtidentificacion.Name = "Txtidentificacion"
        Me.Txtidentificacion.Size = New System.Drawing.Size(147, 20)
        Me.Txtidentificacion.TabIndex = 16
        '
        'LblCantidad
        '
        Me.LblCantidad.AutoSize = True
        Me.LblCantidad.Location = New System.Drawing.Point(351, 37)
        Me.LblCantidad.Name = "LblCantidad"
        Me.LblCantidad.Size = New System.Drawing.Size(84, 13)
        Me.LblCantidad.TabIndex = 15
        Me.LblCantidad.Text = "Cantidad a pedir"
        '
        'LblProducto
        '
        Me.LblProducto.AutoSize = True
        Me.LblProducto.Location = New System.Drawing.Point(84, 70)
        Me.LblProducto.Name = "LblProducto"
        Me.LblProducto.Size = New System.Drawing.Size(50, 13)
        Me.LblProducto.TabIndex = 14
        Me.LblProducto.Text = "Producto"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(513, 69)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 13
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'Txtcantidad
        '
        Me.Txtcantidad.Location = New System.Drawing.Point(441, 34)
        Me.Txtcantidad.Name = "Txtcantidad"
        Me.Txtcantidad.Size = New System.Drawing.Size(147, 20)
        Me.Txtcantidad.TabIndex = 12
        '
        'Lblidentificacion
        '
        Me.Lblidentificacion.AutoSize = True
        Me.Lblidentificacion.Location = New System.Drawing.Point(64, 34)
        Me.Lblidentificacion.Name = "Lblidentificacion"
        Me.Lblidentificacion.Size = New System.Drawing.Size(70, 13)
        Me.Lblidentificacion.TabIndex = 11
        Me.Lblidentificacion.Text = "Identificacion"
        '
        'Dgv_Salida
        '
        Me.Dgv_Salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Salida.Location = New System.Drawing.Point(12, 158)
        Me.Dgv_Salida.Name = "Dgv_Salida"
        Me.Dgv_Salida.Size = New System.Drawing.Size(537, 243)
        Me.Dgv_Salida.TabIndex = 10
        '
        'CmbProducto
        '
        Me.CmbProducto.FormattingEnabled = True
        Me.CmbProducto.Location = New System.Drawing.Point(154, 67)
        Me.CmbProducto.Name = "CmbProducto"
        Me.CmbProducto.Size = New System.Drawing.Size(147, 21)
        Me.CmbProducto.TabIndex = 9
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegresarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 18
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
        'FrmSalida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Dgv_Productos)
        Me.Controls.Add(Me.Txtidentificacion)
        Me.Controls.Add(Me.LblCantidad)
        Me.Controls.Add(Me.LblProducto)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.Txtcantidad)
        Me.Controls.Add(Me.Lblidentificacion)
        Me.Controls.Add(Me.Dgv_Salida)
        Me.Controls.Add(Me.CmbProducto)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmSalida"
        Me.Text = "Salida"
        CType(Me.Dgv_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_Salida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgv_Productos As DataGridView
    Friend WithEvents Txtidentificacion As TextBox
    Friend WithEvents LblCantidad As Label
    Friend WithEvents LblProducto As Label
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents Txtcantidad As TextBox
    Friend WithEvents Lblidentificacion As Label
    Friend WithEvents Dgv_Salida As DataGridView
    Friend WithEvents CmbProducto As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RegresarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
