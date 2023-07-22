Imports CapaNegocio
Public Class FrmRegistrarFuncionario
    Dim obj_Funcionario As New Clase_Funcionario
    Private Sub Bttregresar_Click(sender As Object, e As EventArgs) Handles Bttregresar.Click
        FrmLogin.Show()
        Me.Hide()

    End Sub

    Private Sub BttRegistrar_Click(sender As Object, e As EventArgs) Handles BttRegistrar.Click
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
            'Registro exitiso
            MessageBox.Show(text:="El funcionario fue registrado exitosamente", "Registo Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Hide()
    End Sub
    Private Sub SalirToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class