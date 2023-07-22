<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCreador
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
        Me.Lblanito = New System.Windows.Forms.Label()
        Me.Lblmanejo = New System.Windows.Forms.Label()
        Me.Lblape = New System.Windows.Forms.Label()
        Me.Labelnom = New System.Windows.Forms.Label()
        Me.Lblaño = New System.Windows.Forms.Label()
        Me.Lblsistma = New System.Windows.Forms.Label()
        Me.Lblapellido = New System.Windows.Forms.Label()
        Me.Lblnombre = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegresarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lblanito
        '
        Me.Lblanito.AutoSize = True
        Me.Lblanito.BackColor = System.Drawing.Color.Transparent
        Me.Lblanito.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblanito.Location = New System.Drawing.Point(261, 163)
        Me.Lblanito.Name = "Lblanito"
        Me.Lblanito.Size = New System.Drawing.Size(50, 24)
        Me.Lblanito.TabIndex = 17
        Me.Lblanito.Text = "2022"
        '
        'Lblmanejo
        '
        Me.Lblmanejo.AutoSize = True
        Me.Lblmanejo.BackColor = System.Drawing.Color.Transparent
        Me.Lblmanejo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblmanejo.Location = New System.Drawing.Point(276, 139)
        Me.Lblmanejo.Name = "Lblmanejo"
        Me.Lblmanejo.Size = New System.Drawing.Size(173, 24)
        Me.Lblmanejo.TabIndex = 16
        Me.Lblmanejo.Text = "Manejo De Bodega"
        '
        'Lblape
        '
        Me.Lblape.AutoSize = True
        Me.Lblape.BackColor = System.Drawing.Color.Transparent
        Me.Lblape.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblape.Location = New System.Drawing.Point(279, 115)
        Me.Lblape.Name = "Lblape"
        Me.Lblape.Size = New System.Drawing.Size(152, 24)
        Me.Lblape.TabIndex = 15
        Me.Lblape.Text = "Barahona Quirós"
        '
        'Labelnom
        '
        Me.Labelnom.AutoSize = True
        Me.Labelnom.BackColor = System.Drawing.Color.Transparent
        Me.Labelnom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelnom.Location = New System.Drawing.Point(276, 91)
        Me.Labelnom.Name = "Labelnom"
        Me.Labelnom.Size = New System.Drawing.Size(79, 24)
        Me.Labelnom.TabIndex = 14
        Me.Labelnom.Text = "Génesis"
        '
        'Lblaño
        '
        Me.Lblaño.AutoSize = True
        Me.Lblaño.BackColor = System.Drawing.Color.Transparent
        Me.Lblaño.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblaño.Location = New System.Drawing.Point(210, 162)
        Me.Lblaño.Name = "Lblaño"
        Me.Lblaño.Size = New System.Drawing.Size(45, 24)
        Me.Lblaño.TabIndex = 13
        Me.Lblaño.Text = "Año"
        '
        'Lblsistma
        '
        Me.Lblsistma.AutoSize = True
        Me.Lblsistma.BackColor = System.Drawing.Color.Transparent
        Me.Lblsistma.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblsistma.Location = New System.Drawing.Point(189, 128)
        Me.Lblsistma.Name = "Lblsistma"
        Me.Lblsistma.Size = New System.Drawing.Size(81, 24)
        Me.Lblsistma.TabIndex = 12
        Me.Lblsistma.Text = "Sistema:"
        '
        'Lblapellido
        '
        Me.Lblapellido.AutoSize = True
        Me.Lblapellido.BackColor = System.Drawing.Color.Transparent
        Me.Lblapellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblapellido.Location = New System.Drawing.Point(189, 102)
        Me.Lblapellido.Name = "Lblapellido"
        Me.Lblapellido.Size = New System.Drawing.Size(84, 24)
        Me.Lblapellido.TabIndex = 11
        Me.Lblapellido.Text = "Apellido:"
        '
        'Lblnombre
        '
        Me.Lblnombre.AutoSize = True
        Me.Lblnombre.BackColor = System.Drawing.Color.Transparent
        Me.Lblnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblnombre.Location = New System.Drawing.Point(189, 76)
        Me.Lblnombre.Name = "Lblnombre"
        Me.Lblnombre.Size = New System.Drawing.Size(84, 24)
        Me.Lblnombre.TabIndex = 10
        Me.Lblnombre.Text = "Nombre:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegresarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(653, 24)
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
        'FrmCreador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(653, 345)
        Me.Controls.Add(Me.Lblanito)
        Me.Controls.Add(Me.Lblmanejo)
        Me.Controls.Add(Me.Lblape)
        Me.Controls.Add(Me.Labelnom)
        Me.Controls.Add(Me.Lblaño)
        Me.Controls.Add(Me.Lblsistma)
        Me.Controls.Add(Me.Lblapellido)
        Me.Controls.Add(Me.Lblnombre)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FrmCreador"
        Me.Text = "Creador"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lblanito As Label
    Friend WithEvents Lblmanejo As Label
    Friend WithEvents Lblape As Label
    Friend WithEvents Labelnom As Label
    Friend WithEvents Lblaño As Label
    Friend WithEvents Lblsistma As Label
    Friend WithEvents Lblapellido As Label
    Friend WithEvents Lblnombre As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RegresarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
