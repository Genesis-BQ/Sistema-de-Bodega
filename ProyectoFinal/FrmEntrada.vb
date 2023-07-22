Imports CapaNegocio
Public Class FrmEntrada
    Dim obj_entrada As New CapaNegocio.Clase_Entradas
    Dim objProducto As New Clase_Producto
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Try
            'ingresar los datos
            obj_entrada.Nombre = CmbProducto.Text
            obj_entrada.Cantidad = txtcantidad.Text
            obj_entrada.Identificacion = Txtidentificacion.Text


            'validaciones de entrada
            obj_entrada.ValidarEntrada()
            obj_entrada.ValidarEmpleado()
            If obj_entrada.Producto = True Then
                obj_entrada.AgregarProductos()
                obj_entrada.llenarTabla()
                cargarProductos()
                cargarEntradas()

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
    Public Sub cargarEntradas()
        Dim obj_producto As New CapaNegocio.Clase_Entradas
        Dim dt_producto As DataTable = obj_producto.leerXML()
        Dgv_Entrada.DataSource = dt_producto
    End Sub
    Public Sub cargarProductos()
        Dim dtProductos As DataTable = objProducto.leerXML()
        Dgv_Productos.DataSource = dtProductos

        Me.CmbProducto.DataSource = dtProductos
        Me.CmbProducto.DisplayMember = "Producto"
        Me.CmbProducto.ValueMember = "Codigo"
    End Sub

    Private Sub FrmEntrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarProductos()
        cargarEntradas()
        CmbProducto.Text = ""
    End Sub

    Private Sub RegresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarToolStripMenuItem.Click
        FrmPrincipal2.Show()
        Me.Hide()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class