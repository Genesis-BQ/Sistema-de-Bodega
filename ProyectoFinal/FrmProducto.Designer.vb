<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProducto
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
        Me.Dgv_Producto = New System.Windows.Forms.DataGridView()
        Me.TxtMinima = New System.Windows.Forms.TextBox()
        Me.TxtDisponible = New System.Windows.Forms.TextBox()
        Me.TxtProducto = New System.Windows.Forms.TextBox()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.LblMinima = New System.Windows.Forms.Label()
        Me.LblDisponible = New System.Windows.Forms.Label()
        Me.Lblproducto = New System.Windows.Forms.Label()
        Me.LblCodigo = New System.Windows.Forms.Label()
        Me.BttRegistrar = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegresarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BttnModificar = New System.Windows.Forms.Button()
        CType(Me.Dgv_Producto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dgv_Producto
        '
        Me.Dgv_Producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Producto.Location = New System.Drawing.Point(44, 160)
        Me.Dgv_Producto.Name = "Dgv_Producto"
        Me.Dgv_Producto.Size = New System.Drawing.Size(588, 187)
        Me.Dgv_Producto.TabIndex = 20
        '
        'TxtMinima
        '
        Me.TxtMinima.Location = New System.Drawing.Point(463, 76)
        Me.TxtMinima.Name = "TxtMinima"
        Me.TxtMinima.Size = New System.Drawing.Size(183, 20)
        Me.TxtMinima.TabIndex = 19
        '
        'TxtDisponible
        '
        Me.TxtDisponible.Location = New System.Drawing.Point(463, 50)
        Me.TxtDisponible.Name = "TxtDisponible"
        Me.TxtDisponible.Size = New System.Drawing.Size(183, 20)
        Me.TxtDisponible.TabIndex = 18
        '
        'TxtProducto
        '
        Me.TxtProducto.Location = New System.Drawing.Point(137, 50)
        Me.TxtProducto.Name = "TxtProducto"
        Me.TxtProducto.Size = New System.Drawing.Size(183, 20)
        Me.TxtProducto.TabIndex = 17
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(137, 76)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(183, 20)
        Me.TxtCodigo.TabIndex = 16
        '
        'LblMinima
        '
        Me.LblMinima.AutoSize = True
        Me.LblMinima.BackColor = System.Drawing.Color.Transparent
        Me.LblMinima.Location = New System.Drawing.Point(371, 79)
        Me.LblMinima.Name = "LblMinima"
        Me.LblMinima.Size = New System.Drawing.Size(85, 13)
        Me.LblMinima.TabIndex = 15
        Me.LblMinima.Text = "Cantidad Minima"
        '
        'LblDisponible
        '
        Me.LblDisponible.AutoSize = True
        Me.LblDisponible.BackColor = System.Drawing.Color.Transparent
        Me.LblDisponible.Location = New System.Drawing.Point(356, 53)
        Me.LblDisponible.Name = "LblDisponible"
        Me.LblDisponible.Size = New System.Drawing.Size(101, 13)
        Me.LblDisponible.TabIndex = 14
        Me.LblDisponible.Text = "Cantidad Disponible"
        '
        'Lblproducto
        '
        Me.Lblproducto.AutoSize = True
        Me.Lblproducto.BackColor = System.Drawing.Color.Transparent
        Me.Lblproducto.Location = New System.Drawing.Point(41, 53)
        Me.Lblproducto.Name = "Lblproducto"
        Me.Lblproducto.Size = New System.Drawing.Size(90, 13)
        Me.Lblproducto.TabIndex = 13
        Me.Lblproducto.Text = "Nombre Producto"
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.BackColor = System.Drawing.Color.Transparent
        Me.LblCodigo.Location = New System.Drawing.Point(88, 79)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(43, 13)
        Me.LblCodigo.TabIndex = 12
        Me.LblCodigo.Text = "Codigo "
        '
        'BttRegistrar
        '
        Me.BttRegistrar.BackColor = System.Drawing.Color.Transparent
        Me.BttRegistrar.Location = New System.Drawing.Point(245, 110)
        Me.BttRegistrar.Name = "BttRegistrar"
        Me.BttRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.BttRegistrar.TabIndex = 11
        Me.BttRegistrar.Text = "Resgistrar"
        Me.BttRegistrar.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegresarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(717, 24)
        Me.MenuStrip1.TabIndex = 21
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
        'BttnModificar
        '
        Me.BttnModificar.BackColor = System.Drawing.Color.Transparent
        Me.BttnModificar.Location = New System.Drawing.Point(341, 110)
        Me.BttnModificar.Name = "BttnModificar"
        Me.BttnModificar.Size = New System.Drawing.Size(75, 23)
        Me.BttnModificar.TabIndex = 22
        Me.BttnModificar.Text = "Modificar"
        Me.BttnModificar.UseVisualStyleBackColor = False
        '
        'FrmProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(717, 374)
        Me.Controls.Add(Me.BttnModificar)
        Me.Controls.Add(Me.Dgv_Producto)
        Me.Controls.Add(Me.TxtMinima)
        Me.Controls.Add(Me.TxtDisponible)
        Me.Controls.Add(Me.TxtProducto)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.LblMinima)
        Me.Controls.Add(Me.LblDisponible)
        Me.Controls.Add(Me.Lblproducto)
        Me.Controls.Add(Me.LblCodigo)
        Me.Controls.Add(Me.BttRegistrar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FrmProducto"
        Me.Text = "Producto"
        CType(Me.Dgv_Producto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgv_Producto As DataGridView
    Friend WithEvents TxtMinima As TextBox
    Friend WithEvents TxtDisponible As TextBox
    Friend WithEvents TxtProducto As TextBox
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents LblMinima As Label
    Friend WithEvents LblDisponible As Label
    Friend WithEvents Lblproducto As Label
    Friend WithEvents LblCodigo As Label
    Friend WithEvents BttRegistrar As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RegresarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BttnModificar As Button
End Class
