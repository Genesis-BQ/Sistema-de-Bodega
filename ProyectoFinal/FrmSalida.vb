'importar las clases
Imports CapaNegocio
Public Class FrmSalida
    Dim obj_salida As New CapaNegocio.Clase_Salida
    Dim objProducto As New Clase_Producto
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Try
            'ingresar los datos
            obj_salida.Nombre = CmbProducto.Text
            obj_salida.Cantidad = Txtcantidad.Text
            obj_salida.Identificacion = Txtidentificacion.Text


            'validaciones de entrada

            obj_salida.ValidarSalida()
            obj_salida.VerificarCantidad()
            obj_salida.ValidarEmpleado()
            If obj_salida.Product = True Then
                obj_salida.EliminarProductos()
                obj_salida.llenarTabla()
                cargarProductos()
                cargarSalidas()

                CmbProducto.Text = ""
                Txtcantidad.Text = ""
                Txtidentificacion.Text = ""
            Else
                MessageBox.Show("El empleado esta inactivo o no se encuntras datos del empleados con esa identificación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub cargarSalidas()
        Dim obj_producto As New CapaNegocio.Clase_Salida
        Dim dt_producto As DataTable = obj_producto.leerXML()
        Dgv_Salida.DataSource = dt_producto
    End Sub
    Public Sub cargarProductos()
        Dim dtProductos As DataTable = objProducto.leerXML()
        Dgv_Productos.DataSource = dtProductos

        Me.CmbProducto.DataSource = dtProductos
        Me.CmbProducto.DisplayMember = "Producto"
        Me.CmbProducto.ValueMember = "Codigo"
    End Sub

    Private Sub FrmSalida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarProductos()
        cargarSalidas()
    End Sub

    Private Sub RegresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarToolStripMenuItem.Click
        FrmPrincipal2.Show()
        Me.Hide()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class