Imports CapaNegocio
Public Class FrmLogin
    Dim obj_login As New Clase_Funcionario

    Private Sub Bttiniciar_Click(sender As Object, e As EventArgs) Handles Bttiniciar.Click
        Try
            obj_login.Usuario = Txtusuario.Text
            obj_login.Contraseña = Txtcontraseña.Text

            'Validaciones

            obj_login.ValidarContraseña()

            'Registro exitiso
            If obj_login.Presente = True Then
                Me.Hide()
                FrmPrincipal2.Show()
                MessageBox.Show(text:="El inicio de sesion fue exitoso", "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show(text:="El inicio de sesion fue erróneo", "Inicio de sesión erróneo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub Bttregistrar_Click(sender As Object, e As EventArgs) Handles Bttregistrar.Click
        FrmRegistrarFuncionario.Show()
        Me.Hide()

    End Sub
End Class