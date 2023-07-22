<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistrarFuncionario
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Bttregresar = New System.Windows.Forms.Button()
        Me.Txtcontraseña = New System.Windows.Forms.TextBox()
        Me.Txtusuario = New System.Windows.Forms.TextBox()
        Me.Txtsegundape = New System.Windows.Forms.TextBox()
        Me.Txtprmerape = New System.Windows.Forms.TextBox()
        Me.Txtnombre = New System.Windows.Forms.TextBox()
        Me.Txtidentificación = New System.Windows.Forms.TextBox()
        Me.Lblcontraseña = New System.Windows.Forms.Label()
        Me.Lblusuario = New System.Windows.Forms.Label()
        Me.Lblsegundape = New System.Windows.Forms.Label()
        Me.Lblprimerape = New System.Windows.Forms.Label()
        Me.Lblnombre = New System.Windows.Forms.Label()
        Me.LblIdentificacion = New System.Windows.Forms.Label()
        Me.BttRegistrar = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.CmbEstado = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(205, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(252, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Tag = ""
        Me.Label2.Text = "La contraseña tiene ue ser de letras y no de número"
        '
        'Bttregresar
        '
        Me.Bttregresar.Location = New System.Drawing.Point(256, 282)
        Me.Bttregresar.Name = "Bttregresar"
        Me.Bttregresar.Size = New System.Drawing.Size(75, 23)
        Me.Bttregresar.TabIndex = 41
        Me.Bttregresar.Text = "Regresar"
        Me.Bttregresar.UseVisualStyleBackColor = True
        '
        'Txtcontraseña
        '
        Me.Txtcontraseña.Location = New System.Drawing.Point(248, 189)
        Me.Txtcontraseña.Name = "Txtcontraseña"
        Me.Txtcontraseña.Size = New System.Drawing.Size(188, 20)
        Me.Txtcontraseña.TabIndex = 40
        Me.Txtcontraseña.UseSystemPasswordChar = True
        '
        'Txtusuario
        '
        Me.Txtusuario.Location = New System.Drawing.Point(248, 162)
        Me.Txtusuario.Name = "Txtusuario"
        Me.Txtusuario.Size = New System.Drawing.Size(188, 20)
        Me.Txtusuario.TabIndex = 39
        '
        'Txtsegundape
        '
        Me.Txtsegundape.Location = New System.Drawing.Point(268, 138)
        Me.Txtsegundape.Name = "Txtsegundape"
        Me.Txtsegundape.Size = New System.Drawing.Size(168, 20)
        Me.Txtsegundape.TabIndex = 38
        '
        'Txtprmerape
        '
        Me.Txtprmerape.Location = New System.Drawing.Point(254, 111)
        Me.Txtprmerape.Name = "Txtprmerape"
        Me.Txtprmerape.Size = New System.Drawing.Size(182, 20)
        Me.Txtprmerape.TabIndex = 37
        '
        'Txtnombre
        '
        Me.Txtnombre.Location = New System.Drawing.Point(248, 83)
        Me.Txtnombre.Name = "Txtnombre"
        Me.Txtnombre.Size = New System.Drawing.Size(188, 20)
        Me.Txtnombre.TabIndex = 36
        '
        'Txtidentificación
        '
        Me.Txtidentificación.Location = New System.Drawing.Point(248, 56)
        Me.Txtidentificación.Name = "Txtidentificación"
        Me.Txtidentificación.Size = New System.Drawing.Size(188, 20)
        Me.Txtidentificación.TabIndex = 35
        '
        'Lblcontraseña
        '
        Me.Lblcontraseña.AutoSize = True
        Me.Lblcontraseña.Location = New System.Drawing.Point(171, 185)
        Me.Lblcontraseña.Name = "Lblcontraseña"
        Me.Lblcontraseña.Size = New System.Drawing.Size(61, 13)
        Me.Lblcontraseña.TabIndex = 34
        Me.Lblcontraseña.Text = "Contraseña"
        '
        'Lblusuario
        '
        Me.Lblusuario.AutoSize = True
        Me.Lblusuario.Location = New System.Drawing.Point(172, 162)
        Me.Lblusuario.Name = "Lblusuario"
        Me.Lblusuario.Size = New System.Drawing.Size(43, 13)
        Me.Lblusuario.TabIndex = 33
        Me.Lblusuario.Text = "Usuario"
        '
        'Lblsegundape
        '
        Me.Lblsegundape.AutoSize = True
        Me.Lblsegundape.Location = New System.Drawing.Point(171, 137)
        Me.Lblsegundape.Name = "Lblsegundape"
        Me.Lblsegundape.Size = New System.Drawing.Size(90, 13)
        Me.Lblsegundape.TabIndex = 32
        Me.Lblsegundape.Text = "Segundo Apellido"
        '
        'Lblprimerape
        '
        Me.Lblprimerape.AutoSize = True
        Me.Lblprimerape.Location = New System.Drawing.Point(171, 111)
        Me.Lblprimerape.Name = "Lblprimerape"
        Me.Lblprimerape.Size = New System.Drawing.Size(76, 13)
        Me.Lblprimerape.TabIndex = 31
        Me.Lblprimerape.Text = "Primer Apellido"
        '
        'Lblnombre
        '
        Me.Lblnombre.AutoSize = True
        Me.Lblnombre.Location = New System.Drawing.Point(171, 84)
        Me.Lblnombre.Name = "Lblnombre"
        Me.Lblnombre.Size = New System.Drawing.Size(44, 13)
        Me.Lblnombre.TabIndex = 30
        Me.Lblnombre.Text = "Nombre"
        '
        'LblIdentificacion
        '
        Me.LblIdentificacion.AutoSize = True
        Me.LblIdentificacion.Location = New System.Drawing.Point(171, 56)
        Me.LblIdentificacion.Name = "LblIdentificacion"
        Me.LblIdentificacion.Size = New System.Drawing.Size(70, 13)
        Me.LblIdentificacion.TabIndex = 29
        Me.LblIdentificacion.Text = "Identificacion"
        '
        'BttRegistrar
        '
        Me.BttRegistrar.Location = New System.Drawing.Point(348, 282)
        Me.BttRegistrar.Name = "BttRegistrar"
        Me.BttRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.BttRegistrar.TabIndex = 28
        Me.BttRegistrar.Text = "Registrar"
        Me.BttRegistrar.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(672, 24)
        Me.MenuStrip1.TabIndex = 43
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Location = New System.Drawing.Point(175, 224)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(40, 13)
        Me.LblEstado.TabIndex = 44
        Me.LblEstado.Text = "Estado"
        '
        'CmbEstado
        '
        Me.CmbEstado.FormattingEnabled = True
        Me.CmbEstado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.CmbEstado.Location = New System.Drawing.Point(248, 224)
        Me.CmbEstado.Name = "CmbEstado"
        Me.CmbEstado.Size = New System.Drawing.Size(188, 21)
        Me.CmbEstado.TabIndex = 45
        '
        'FrmRegistrarFuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(672, 341)
        Me.Controls.Add(Me.CmbEstado)
        Me.Controls.Add(Me.LblEstado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Bttregresar)
        Me.Controls.Add(Me.Txtcontraseña)
        Me.Controls.Add(Me.Txtusuario)
        Me.Controls.Add(Me.Txtsegundape)
        Me.Controls.Add(Me.Txtprmerape)
        Me.Controls.Add(Me.Txtnombre)
        Me.Controls.Add(Me.Txtidentificación)
        Me.Controls.Add(Me.Lblcontraseña)
        Me.Controls.Add(Me.Lblusuario)
        Me.Controls.Add(Me.Lblsegundape)
        Me.Controls.Add(Me.Lblprimerape)
        Me.Controls.Add(Me.Lblnombre)
        Me.Controls.Add(Me.LblIdentificacion)
        Me.Controls.Add(Me.BttRegistrar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmRegistrarFuncionario"
        Me.Text = "Registrar"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Bttregresar As Button
    Friend WithEvents Txtcontraseña As TextBox
    Friend WithEvents Txtusuario As TextBox
    Friend WithEvents Txtsegundape As TextBox
    Friend WithEvents Txtprmerape As TextBox
    Friend WithEvents Txtnombre As TextBox
    Friend WithEvents Txtidentificación As TextBox
    Friend WithEvents Lblcontraseña As Label
    Friend WithEvents Lblusuario As Label
    Friend WithEvents Lblsegundape As Label
    Friend WithEvents Lblprimerape As Label
    Friend WithEvents Lblnombre As Label
    Friend WithEvents LblIdentificacion As Label
    Friend WithEvents BttRegistrar As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LblEstado As Label
    Friend WithEvents CmbEstado As ComboBox
End Class
