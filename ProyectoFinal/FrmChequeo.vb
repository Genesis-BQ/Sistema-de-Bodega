Imports CapaNegocio
Public Class FrmChequeo
    Dim obj_chequeo As New Clase_Compra
    Private Sub Btnmostrar_Click(sender As Object, e As EventArgs) Handles Btnmostrar.Click
        obj_chequeo.CrearXML()
    End Sub

    Private Sub FrmChequeo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lblchequeo.Text = DateTime.Now.ToString()
        Dim dt_producto As DataTable = obj_chequeo.leerXML()
        Dgv_Chequeo.DataSource = dt_producto
    End Sub

    Private Sub RegresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarToolStripMenuItem.Click
        FrmPrincipal2.Show()
        Me.Hide()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class