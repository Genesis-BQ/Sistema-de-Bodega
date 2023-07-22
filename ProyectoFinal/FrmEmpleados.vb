Imports CapaNegocio
Public Class FrmEmpleados
    Dim obj_Empleado As New Clase_Empleado
    Private Sub BttAgregar_Click(sender As Object, e As EventArgs) Handles BttAgregar.Click
        Try
            'pasos de datos desde interfaz al objeto
            obj_Empleado.Identificacion = TxtIdentificación.Text
            obj_Empleado.Nombre = TxtNombre.Text
            obj_Empleado.Primerapellido = Txtprimape.Text
            obj_Empleado.Segundoapellido = Txtseguape.Text
            obj_Empleado.Departamento = CmbDepartamento.Text
            obj_Empleado.Laboral = Txtlaboral.Text
            obj_Empleado.Telefono = TxtTelefono.Text
            obj_Empleado.Correo = Txtcorreo.Text
            obj_Empleado.Estado = CmbEstado.Text
            'validar los datos
            obj_Empleado.ValirEmpleado()
            obj_Empleado.ValidarUsuario()
            obj_Empleado.Llenartabla()
            cargar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub cargar()
        Dim obj_Empleado As New Clase_Empleado
        Dim dt_Empleado As DataTable = obj_Empleado.leerXML()
        Dvg_Empelados.DataSource = dt_Empleado
    End Sub

    Private Sub FrmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
    End Sub

    Private Sub BttModificar_Click(sender As Object, e As EventArgs) Handles BttModificar.Click
        Try
            'pasos de datos desde interfaz al objeto
            obj_Empleado.Identificacion = TxtIdentificación.Text
            obj_Empleado.Nombre = TxtNombre.Text
            obj_Empleado.Primerapellido = Txtprimape.Text
            obj_Empleado.Segundoapellido = Txtseguape.Text
            obj_Empleado.Departamento = CmbDepartamento.Text
            obj_Empleado.Laboral = Txtlaboral.Text
            obj_Empleado.Telefono = TxtTelefono.Text
            obj_Empleado.Correo = Txtcorreo.Text
            obj_Empleado.Estado = CmbEstado.Text
            'validar los datos
            obj_Empleado.ValirEmpleado()
            obj_Empleado.ModificarFuncionario()
            cargar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RegresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarToolStripMenuItem.Click
        FrmPrincipal2.Show()
        Me.Hide()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Dvg_Empelados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dvg_Empelados.CellClick
        Dim i As Integer
        i = Dvg_Empelados.CurrentRow.Index
        TxtIdentificación.Text = Dvg_Empelados.Item(0, i).Value()
        TxtNombre.Text = Dvg_Empelados.Item(1, i).Value()
        Txtprimape.Text = Dvg_Empelados.Item(2, i).Value()
        Txtseguape.Text = Dvg_Empelados.Item(3, i).Value()
        CmbDepartamento.Text = Dvg_Empelados.Item(4, i).Value()
        Txtlaboral.Text = Dvg_Empelados.Item(5, i).Value()
        TxtTelefono.Text = Dvg_Empelados.Item(6, i).Value()
        Txtcorreo.Text = Dvg_Empelados.Item(7, i).Value()
        CmbEstado.Text = Dvg_Empelados.Item(8, i).Value()
    End Sub
End Class