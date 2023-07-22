Imports CapaNegocio
Public Class FrmProducto
    Dim obj_producto As New Clase_Producto
    Private Sub BttRegistrar_Click(sender As Object, e As EventArgs) Handles BttRegistrar.Click
        Try
            'objetos de los datos
            obj_producto.Codigo = TxtCodigo.Text
            obj_producto.Producto = TxtProducto.Text
            obj_producto.Disponible = TxtDisponible.Text
            obj_producto.Minima = TxtMinima.Text

            'validar los datos
            obj_producto.ValidarProducto()
            obj_producto.Llenartabla()
            cargar()
            'Registro exitiso
            MessageBox.Show(text:="El ingreso del producto fue exitoso", " Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub cargar()
        Dim obj_Producto As New Clase_Producto
        Dim dt_Producto As DataTable = obj_Producto.leerXML()
        Dgv_Producto.DataSource = dt_Producto
    End Sub

    Private Sub RegresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarToolStripMenuItem.Click
        FrmPrincipal2.Show()
        Me.Hide()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub BttnModificar_Click(sender As Object, e As EventArgs) Handles BttnModificar.Click
        Try
            'pasos de datos desde interfaz al objeto
            obj_producto.Codigo = TxtCodigo.Text
            obj_producto.Producto = TxtProducto.Text
            obj_producto.Disponible = TxtDisponible.Text
            obj_producto.Minima = TxtMinima.Text
            'validar los datos
            obj_producto.ValidarProducto()
            obj_producto.ModificarProducto()
            cargar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
    End Sub

    Private Sub Dgv_Producto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Producto.CellContentClick
        Dim i As Integer
        i = Dgv_Producto.CurrentRow.Index
        TxtProducto.Text = Dgv_Producto.Item(0, i).Value()
        TxtCodigo.Text = Dgv_Producto.Item(1, i).Value()
        TxtDisponible.Text = Dgv_Producto.Item(2, i).Value()
        TxtMinima.Text = Dgv_Producto.Item(3, i).Value()

    End Sub
End Class