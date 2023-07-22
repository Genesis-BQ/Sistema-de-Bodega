Public Class FrmPrincipal2
    Private Sub IngresarEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarEmpleadoToolStripMenuItem.Click
        FrmEmpleados.Show()
    End Sub

    Private Sub RegistrarProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarProductoToolStripMenuItem.Click
        FrmProducto.Show()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        FrmCreador.Show()
    End Sub

    Private Sub MantenimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoToolStripMenuItem.Click
        FrmMantenimientoFuncionario.Show()
    End Sub

    Private Sub RegistroProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroProductoToolStripMenuItem.Click
        FrmEntrada.Show()
    End Sub

    Private Sub SalidaProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidaProductoToolStripMenuItem.Click
        FrmSalida.Show()
    End Sub

    Private Sub ChequeoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChequeoToolStripMenuItem.Click
        FrmChequeo.Show()
    End Sub
End Class