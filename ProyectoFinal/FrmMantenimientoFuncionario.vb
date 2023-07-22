Imports CapaNegocio
Public Class FrmMantenimientoFuncionario
    Dim obj_Funcionario As New Clase_Funcionario
    Private Sub BttnAgregar_Click(sender As Object, e As EventArgs) Handles BttnAgregar.Click
        Try
            'pasos de datos desde interfaz al objeto
            obj_Funcionario.Identificacion = Txtidentificación.Text
            obj_Funcionario.Nombre = Txtnombre.Text
            obj_Funcionario.Primerapellido = Txtprmerape.Text
            obj_Funcionario.Segundoapellido = Txtsegundape.Text
            obj_Funcionario.Usuario = Txtusuario.Text
            obj_Funcionario.Contraseña = Txtcontraseña.Text
            obj_Funcionario.Estado = CmbEstado.Text
            'validar los datos
            obj_Funcionario.ValidarFuncionario()
            obj_Funcionario.ValidarUsuario()
            obj_Funcionario.Llenartabla()
            cargar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Hide()
    End Sub
    Public Sub cargar()
        Dim obj_funcionario As New Clase_Funcionario
        Dim dt_funcionario As DataTable = obj_funcionario.leerXML()
        Dgv_Funcionario.DataSource = dt_funcionario
    End Sub

    Private Sub FrmMantenimientoFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
    End Sub

    Private Sub BttnModificar_Click(sender As Object, e As EventArgs) Handles BttnModificar.Click
        Try
            'pasos de datos desde interfaz al objeto
            obj_Funcionario.Identificacion = Txtidentificación.Text
            obj_Funcionario.Nombre = Txtnombre.Text
            obj_Funcionario.Primerapellido = Txtprmerape.Text
            obj_Funcionario.Segundoapellido = Txtsegundape.Text
            obj_Funcionario.Usuario = Txtusuario.Text
            obj_Funcionario.Contraseña = Txtcontraseña.Text
            obj_Funcionario.Estado = CmbEstado.Text
            'validar los datos
            obj_Funcionario.ValidarFuncionario()
            obj_Funcionario.ModificarFuncionario()
            cargar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Dgv_Funcionario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Funcionario.CellContentClick
        Dim i As Integer
        i = Dgv_Funcionario.CurrentRow.Index
        Txtidentificación.Text = Dgv_Funcionario.Item(0, i).Value()
        Txtnombre.Text = Dgv_Funcionario.Item(1, i).Value()
        Txtprmerape.Text = Dgv_Funcionario.Item(2, i).Value()
        Txtsegundape.Text = Dgv_Funcionario.Item(3, i).Value()
        Txtusuario.Text = Dgv_Funcionario.Item(4, i).Value()
        Txtcontraseña.Text = Dgv_Funcionario.Item(5, i).Value()
        CmbEstado.Text = Dgv_Funcionario.Item(6, i).Value()
    End Sub

    Private Sub RegresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarToolStripMenuItem.Click
        FrmPrincipal2.Show()
        Me.Hide()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class