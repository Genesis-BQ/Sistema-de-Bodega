﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoFuncionario
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
        Me.CmbEstado = New System.Windows.Forms.ComboBox()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BttnAgregar = New System.Windows.Forms.Button()
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
        Me.BttnModificar = New System.Windows.Forms.Button()
        Me.Dgv_Funcionario = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegresarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.Dgv_Funcionario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmbEstado
        '
        Me.CmbEstado.FormattingEnabled = True
        Me.CmbEstado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.CmbEstado.Location = New System.Drawing.Point(373, 92)
        Me.CmbEstado.Name = "CmbEstado"
        Me.CmbEstado.Size = New System.Drawing.Size(188, 21)
        Me.CmbEstado.TabIndex = 62
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Location = New System.Drawing.Point(326, 95)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(40, 13)
        Me.LblEstado.TabIndex = 61
        Me.LblEstado.Text = "Estado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(326, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(252, 13)
        Me.Label2.TabIndex = 60
        Me.Label2.Tag = ""
        Me.Label2.Text = "La contraseña tiene ue ser de letras y no de número"
        '
        'BttnAgregar
        '
        Me.BttnAgregar.Location = New System.Drawing.Point(236, 154)
        Me.BttnAgregar.Name = "BttnAgregar"
        Me.BttnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BttnAgregar.TabIndex = 59
        Me.BttnAgregar.Text = "Agregar"
        Me.BttnAgregar.UseVisualStyleBackColor = True
        '
        'Txtcontraseña
        '
        Me.Txtcontraseña.Location = New System.Drawing.Point(114, 115)
        Me.Txtcontraseña.Name = "Txtcontraseña"
        Me.Txtcontraseña.Size = New System.Drawing.Size(188, 20)
        Me.Txtcontraseña.TabIndex = 58
        Me.Txtcontraseña.UseSystemPasswordChar = True
        '
        'Txtusuario
        '
        Me.Txtusuario.Location = New System.Drawing.Point(114, 88)
        Me.Txtusuario.Name = "Txtusuario"
        Me.Txtusuario.Size = New System.Drawing.Size(188, 20)
        Me.Txtusuario.TabIndex = 57
        '
        'Txtsegundape
        '
        Me.Txtsegundape.Location = New System.Drawing.Point(387, 61)
        Me.Txtsegundape.Name = "Txtsegundape"
        Me.Txtsegundape.Size = New System.Drawing.Size(168, 20)
        Me.Txtsegundape.TabIndex = 56
        '
        'Txtprmerape
        '
        Me.Txtprmerape.Location = New System.Drawing.Point(373, 34)
        Me.Txtprmerape.Name = "Txtprmerape"
        Me.Txtprmerape.Size = New System.Drawing.Size(182, 20)
        Me.Txtprmerape.TabIndex = 55
        '
        'Txtnombre
        '
        Me.Txtnombre.Location = New System.Drawing.Point(93, 61)
        Me.Txtnombre.Name = "Txtnombre"
        Me.Txtnombre.Size = New System.Drawing.Size(188, 20)
        Me.Txtnombre.TabIndex = 54
        '
        'Txtidentificación
        '
        Me.Txtidentificación.Location = New System.Drawing.Point(93, 34)
        Me.Txtidentificación.Name = "Txtidentificación"
        Me.Txtidentificación.Size = New System.Drawing.Size(188, 20)
        Me.Txtidentificación.TabIndex = 53
        '
        'Lblcontraseña
        '
        Me.Lblcontraseña.AutoSize = True
        Me.Lblcontraseña.Location = New System.Drawing.Point(37, 111)
        Me.Lblcontraseña.Name = "Lblcontraseña"
        Me.Lblcontraseña.Size = New System.Drawing.Size(61, 13)
        Me.Lblcontraseña.TabIndex = 52
        Me.Lblcontraseña.Text = "Contraseña"
        '
        'Lblusuario
        '
        Me.Lblusuario.AutoSize = True
        Me.Lblusuario.Location = New System.Drawing.Point(38, 88)
        Me.Lblusuario.Name = "Lblusuario"
        Me.Lblusuario.Size = New System.Drawing.Size(43, 13)
        Me.Lblusuario.TabIndex = 51
        Me.Lblusuario.Text = "Usuario"
        '
        'Lblsegundape
        '
        Me.Lblsegundape.AutoSize = True
        Me.Lblsegundape.Location = New System.Drawing.Point(290, 60)
        Me.Lblsegundape.Name = "Lblsegundape"
        Me.Lblsegundape.Size = New System.Drawing.Size(90, 13)
        Me.Lblsegundape.TabIndex = 50
        Me.Lblsegundape.Text = "Segundo Apellido"
        '
        'Lblprimerape
        '
        Me.Lblprimerape.AutoSize = True
        Me.Lblprimerape.Location = New System.Drawing.Point(290, 34)
        Me.Lblprimerape.Name = "Lblprimerape"
        Me.Lblprimerape.Size = New System.Drawing.Size(76, 13)
        Me.Lblprimerape.TabIndex = 49
        Me.Lblprimerape.Text = "Primer Apellido"
        '
        'Lblnombre
        '
        Me.Lblnombre.AutoSize = True
        Me.Lblnombre.Location = New System.Drawing.Point(37, 64)
        Me.Lblnombre.Name = "Lblnombre"
        Me.Lblnombre.Size = New System.Drawing.Size(44, 13)
        Me.Lblnombre.TabIndex = 48
        Me.Lblnombre.Text = "Nombre"
        '
        'LblIdentificacion
        '
        Me.LblIdentificacion.AutoSize = True
        Me.LblIdentificacion.Location = New System.Drawing.Point(16, 34)
        Me.LblIdentificacion.Name = "LblIdentificacion"
        Me.LblIdentificacion.Size = New System.Drawing.Size(70, 13)
        Me.LblIdentificacion.TabIndex = 47
        Me.LblIdentificacion.Text = "Identificacion"
        '
        'BttnModificar
        '
        Me.BttnModificar.Location = New System.Drawing.Point(317, 154)
        Me.BttnModificar.Name = "BttnModificar"
        Me.BttnModificar.Size = New System.Drawing.Size(75, 23)
        Me.BttnModificar.TabIndex = 46
        Me.BttnModificar.Text = "Modificar"
        Me.BttnModificar.UseVisualStyleBackColor = True
        '
        'Dgv_Funcionario
        '
        Me.Dgv_Funcionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Funcionario.Location = New System.Drawing.Point(19, 202)
        Me.Dgv_Funcionario.Name = "Dgv_Funcionario"
        Me.Dgv_Funcionario.Size = New System.Drawing.Size(704, 221)
        Me.Dgv_Funcionario.TabIndex = 63
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegresarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(749, 24)
        Me.MenuStrip1.TabIndex = 64
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
        'FrmMantenimientoFuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(749, 443)
        Me.Controls.Add(Me.Dgv_Funcionario)
        Me.Controls.Add(Me.CmbEstado)
        Me.Controls.Add(Me.LblEstado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BttnAgregar)
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
        Me.Controls.Add(Me.BttnModificar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMantenimientoFuncionario"
        Me.Text = "Mantenimiento Funcionario"
        CType(Me.Dgv_Funcionario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbEstado As ComboBox
    Friend WithEvents LblEstado As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BttnAgregar As Button
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
    Friend WithEvents BttnModificar As Button
    Friend WithEvents Dgv_Funcionario As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RegresarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
