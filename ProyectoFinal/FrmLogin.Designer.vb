<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Bttregistrar = New System.Windows.Forms.Button()
        Me.Txtcontraseña = New System.Windows.Forms.TextBox()
        Me.Txtusuario = New System.Windows.Forms.TextBox()
        Me.Lblcontraseña = New System.Windows.Forms.Label()
        Me.Llbusuario = New System.Windows.Forms.Label()
        Me.Bttiniciar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(227, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 21)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Iniciar Sesión "
        '
        'Bttregistrar
        '
        Me.Bttregistrar.BackColor = System.Drawing.Color.Transparent
        Me.Bttregistrar.Location = New System.Drawing.Point(200, 230)
        Me.Bttregistrar.Name = "Bttregistrar"
        Me.Bttregistrar.Size = New System.Drawing.Size(75, 23)
        Me.Bttregistrar.TabIndex = 9
        Me.Bttregistrar.Text = "Registrar"
        Me.Bttregistrar.UseVisualStyleBackColor = False
        '
        'Txtcontraseña
        '
        Me.Txtcontraseña.Location = New System.Drawing.Point(200, 127)
        Me.Txtcontraseña.Name = "Txtcontraseña"
        Me.Txtcontraseña.Size = New System.Drawing.Size(172, 20)
        Me.Txtcontraseña.TabIndex = 13
        Me.Txtcontraseña.UseSystemPasswordChar = True
        '
        'Txtusuario
        '
        Me.Txtusuario.Location = New System.Drawing.Point(200, 92)
        Me.Txtusuario.Name = "Txtusuario"
        Me.Txtusuario.Size = New System.Drawing.Size(172, 20)
        Me.Txtusuario.TabIndex = 12
        '
        'Lblcontraseña
        '
        Me.Lblcontraseña.AutoSize = True
        Me.Lblcontraseña.Location = New System.Drawing.Point(133, 130)
        Me.Lblcontraseña.Name = "Lblcontraseña"
        Me.Lblcontraseña.Size = New System.Drawing.Size(61, 13)
        Me.Lblcontraseña.TabIndex = 11
        Me.Lblcontraseña.Text = "Contraseña"
        '
        'Llbusuario
        '
        Me.Llbusuario.AutoSize = True
        Me.Llbusuario.BackColor = System.Drawing.Color.Transparent
        Me.Llbusuario.Location = New System.Drawing.Point(133, 92)
        Me.Llbusuario.Name = "Llbusuario"
        Me.Llbusuario.Size = New System.Drawing.Size(43, 13)
        Me.Llbusuario.TabIndex = 10
        Me.Llbusuario.Text = "Usuario"
        '
        'Bttiniciar
        '
        Me.Bttiniciar.BackColor = System.Drawing.Color.Transparent
        Me.Bttiniciar.ForeColor = System.Drawing.Color.Black
        Me.Bttiniciar.Location = New System.Drawing.Point(297, 230)
        Me.Bttiniciar.Name = "Bttiniciar"
        Me.Bttiniciar.Size = New System.Drawing.Size(75, 23)
        Me.Bttiniciar.TabIndex = 8
        Me.Bttiniciar.Text = "Iniciar"
        Me.Bttiniciar.UseVisualStyleBackColor = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ClientSize = New System.Drawing.Size(544, 312)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Bttregistrar)
        Me.Controls.Add(Me.Txtcontraseña)
        Me.Controls.Add(Me.Txtusuario)
        Me.Controls.Add(Me.Lblcontraseña)
        Me.Controls.Add(Me.Llbusuario)
        Me.Controls.Add(Me.Bttiniciar)
        Me.Name = "FrmLogin"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Bttregistrar As Button
    Friend WithEvents Txtcontraseña As TextBox
    Friend WithEvents Txtusuario As TextBox
    Friend WithEvents Lblcontraseña As Label
    Friend WithEvents Llbusuario As Label
    Friend WithEvents Bttiniciar As Button
End Class
