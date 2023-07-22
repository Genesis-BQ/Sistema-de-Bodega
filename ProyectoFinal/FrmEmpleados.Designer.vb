<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpleados
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
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.LblTeléfono = New System.Windows.Forms.Label()
        Me.CmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.Txtcorreo = New System.Windows.Forms.TextBox()
        Me.Txtlaboral = New System.Windows.Forms.TextBox()
        Me.Txtseguape = New System.Windows.Forms.TextBox()
        Me.Txtprimape = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtIdentificación = New System.Windows.Forms.TextBox()
        Me.Dvg_Empelados = New System.Windows.Forms.DataGridView()
        Me.LblCorreo = New System.Windows.Forms.Label()
        Me.LblLaboral = New System.Windows.Forms.Label()
        Me.LblDepartemnto = New System.Windows.Forms.Label()
        Me.Lblseguape = New System.Windows.Forms.Label()
        Me.Lblprimape = New System.Windows.Forms.Label()
        Me.Lblnombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BttModificar = New System.Windows.Forms.Button()
        Me.BttAgregar = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegresarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CmbEstado = New System.Windows.Forms.ComboBox()
        Me.LblEstado = New System.Windows.Forms.Label()
        CType(Me.Dvg_Empelados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(456, 89)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(276, 20)
        Me.TxtTelefono.TabIndex = 65
        '
        'LblTeléfono
        '
        Me.LblTeléfono.AutoSize = True
        Me.LblTeléfono.Location = New System.Drawing.Point(401, 95)
        Me.LblTeléfono.Name = "LblTeléfono"
        Me.LblTeléfono.Size = New System.Drawing.Size(49, 13)
        Me.LblTeléfono.TabIndex = 64
        Me.LblTeléfono.Text = "Telefono"
        '
        'CmbDepartamento
        '
        Me.CmbDepartamento.FormattingEnabled = True
        Me.CmbDepartamento.Items.AddRange(New Object() {"Recursos Humanos", "Financiero", "Logística", "Construcción", "Administrativo", "Tecnología"})
        Me.CmbDepartamento.Location = New System.Drawing.Point(108, 88)
        Me.CmbDepartamento.Name = "CmbDepartamento"
        Me.CmbDepartamento.Size = New System.Drawing.Size(276, 21)
        Me.CmbDepartamento.TabIndex = 63
        '
        'Txtcorreo
        '
        Me.Txtcorreo.Location = New System.Drawing.Point(456, 114)
        Me.Txtcorreo.Name = "Txtcorreo"
        Me.Txtcorreo.Size = New System.Drawing.Size(276, 20)
        Me.Txtcorreo.TabIndex = 62
        '
        'Txtlaboral
        '
        Me.Txtlaboral.Location = New System.Drawing.Point(108, 111)
        Me.Txtlaboral.Name = "Txtlaboral"
        Me.Txtlaboral.Size = New System.Drawing.Size(276, 20)
        Me.Txtlaboral.TabIndex = 61
        '
        'Txtseguape
        '
        Me.Txtseguape.Location = New System.Drawing.Point(476, 62)
        Me.Txtseguape.Name = "Txtseguape"
        Me.Txtseguape.Size = New System.Drawing.Size(276, 20)
        Me.Txtseguape.TabIndex = 60
        '
        'Txtprimape
        '
        Me.Txtprimape.Location = New System.Drawing.Point(456, 39)
        Me.Txtprimape.Name = "Txtprimape"
        Me.Txtprimape.Size = New System.Drawing.Size(276, 20)
        Me.Txtprimape.TabIndex = 59
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(85, 62)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(276, 20)
        Me.TxtNombre.TabIndex = 58
        '
        'TxtIdentificación
        '
        Me.TxtIdentificación.Location = New System.Drawing.Point(85, 39)
        Me.TxtIdentificación.Name = "TxtIdentificación"
        Me.TxtIdentificación.Size = New System.Drawing.Size(276, 20)
        Me.TxtIdentificación.TabIndex = 57
        '
        'Dvg_Empelados
        '
        Me.Dvg_Empelados.AllowUserToOrderColumns = True
        Me.Dvg_Empelados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dvg_Empelados.Location = New System.Drawing.Point(85, 216)
        Me.Dvg_Empelados.Name = "Dvg_Empelados"
        Me.Dvg_Empelados.Size = New System.Drawing.Size(654, 211)
        Me.Dvg_Empelados.TabIndex = 56
        '
        'LblCorreo
        '
        Me.LblCorreo.AutoSize = True
        Me.LblCorreo.Location = New System.Drawing.Point(412, 118)
        Me.LblCorreo.Name = "LblCorreo"
        Me.LblCorreo.Size = New System.Drawing.Size(38, 13)
        Me.LblCorreo.TabIndex = 55
        Me.LblCorreo.Text = "Correo"
        '
        'LblLaboral
        '
        Me.LblLaboral.AutoSize = True
        Me.LblLaboral.Location = New System.Drawing.Point(55, 113)
        Me.LblLaboral.Name = "LblLaboral"
        Me.LblLaboral.Size = New System.Drawing.Size(42, 13)
        Me.LblLaboral.TabIndex = 54
        Me.LblLaboral.Text = "Laboral"
        '
        'LblDepartemnto
        '
        Me.LblDepartemnto.AutoSize = True
        Me.LblDepartemnto.Location = New System.Drawing.Point(37, 91)
        Me.LblDepartemnto.Name = "LblDepartemnto"
        Me.LblDepartemnto.Size = New System.Drawing.Size(65, 13)
        Me.LblDepartemnto.TabIndex = 53
        Me.LblDepartemnto.Text = "Deparmento"
        '
        'Lblseguape
        '
        Me.Lblseguape.AutoSize = True
        Me.Lblseguape.Location = New System.Drawing.Point(380, 62)
        Me.Lblseguape.Name = "Lblseguape"
        Me.Lblseguape.Size = New System.Drawing.Size(90, 13)
        Me.Lblseguape.TabIndex = 52
        Me.Lblseguape.Text = "Segundo Apellido"
        '
        'Lblprimape
        '
        Me.Lblprimape.AutoSize = True
        Me.Lblprimape.Location = New System.Drawing.Point(380, 40)
        Me.Lblprimape.Name = "Lblprimape"
        Me.Lblprimape.Size = New System.Drawing.Size(76, 13)
        Me.Lblprimape.TabIndex = 51
        Me.Lblprimape.Text = "Primer Apellido"
        '
        'Lblnombre
        '
        Me.Lblnombre.AutoSize = True
        Me.Lblnombre.Location = New System.Drawing.Point(9, 64)
        Me.Lblnombre.Name = "Lblnombre"
        Me.Lblnombre.Size = New System.Drawing.Size(44, 13)
        Me.Lblnombre.TabIndex = 50
        Me.Lblnombre.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Identificación"
        '
        'BttModificar
        '
        Me.BttModificar.BackColor = System.Drawing.Color.Transparent
        Me.BttModificar.Location = New System.Drawing.Point(409, 176)
        Me.BttModificar.Name = "BttModificar"
        Me.BttModificar.Size = New System.Drawing.Size(75, 23)
        Me.BttModificar.TabIndex = 48
        Me.BttModificar.Text = "Modificar"
        Me.BttModificar.UseVisualStyleBackColor = False
        '
        'BttAgregar
        '
        Me.BttAgregar.BackColor = System.Drawing.Color.Transparent
        Me.BttAgregar.Location = New System.Drawing.Point(328, 176)
        Me.BttAgregar.Name = "BttAgregar"
        Me.BttAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BttAgregar.TabIndex = 47
        Me.BttAgregar.Text = "Agregar"
        Me.BttAgregar.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegresarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 46
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
        'CmbEstado
        '
        Me.CmbEstado.FormattingEnabled = True
        Me.CmbEstado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.CmbEstado.Location = New System.Drawing.Point(327, 143)
        Me.CmbEstado.Name = "CmbEstado"
        Me.CmbEstado.Size = New System.Drawing.Size(188, 21)
        Me.CmbEstado.TabIndex = 67
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Location = New System.Drawing.Point(281, 143)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(40, 13)
        Me.LblEstado.TabIndex = 66
        Me.LblEstado.Text = "Estado"
        '
        'FrmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CmbEstado)
        Me.Controls.Add(Me.LblEstado)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.LblTeléfono)
        Me.Controls.Add(Me.CmbDepartamento)
        Me.Controls.Add(Me.Txtcorreo)
        Me.Controls.Add(Me.Txtlaboral)
        Me.Controls.Add(Me.Txtseguape)
        Me.Controls.Add(Me.Txtprimape)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtIdentificación)
        Me.Controls.Add(Me.Dvg_Empelados)
        Me.Controls.Add(Me.LblCorreo)
        Me.Controls.Add(Me.LblLaboral)
        Me.Controls.Add(Me.LblDepartemnto)
        Me.Controls.Add(Me.Lblseguape)
        Me.Controls.Add(Me.Lblprimape)
        Me.Controls.Add(Me.Lblnombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BttModificar)
        Me.Controls.Add(Me.BttAgregar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FrmEmpleados"
        Me.Text = "Empleados"
        CType(Me.Dvg_Empelados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents LblTeléfono As Label
    Friend WithEvents CmbDepartamento As ComboBox
    Friend WithEvents Txtcorreo As TextBox
    Friend WithEvents Txtlaboral As TextBox
    Friend WithEvents Txtseguape As TextBox
    Friend WithEvents Txtprimape As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtIdentificación As TextBox
    Friend WithEvents Dvg_Empelados As DataGridView
    Friend WithEvents LblCorreo As Label
    Friend WithEvents LblLaboral As Label
    Friend WithEvents LblDepartemnto As Label
    Friend WithEvents Lblseguape As Label
    Friend WithEvents Lblprimape As Label
    Friend WithEvents Lblnombre As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BttModificar As Button
    Friend WithEvents BttAgregar As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RegresarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CmbEstado As ComboBox
    Friend WithEvents LblEstado As Label
End Class
