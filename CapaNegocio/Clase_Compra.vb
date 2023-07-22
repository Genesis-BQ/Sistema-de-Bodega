Imports System.Xml
Imports CapaDato

Public Class Clase_Compra
    Dim _cantidaddispo As Integer
    Dim _cantidadminima As Integer

#Region "Propiedades"
    Public Property Cantidaddispo As Integer
        Get
            Return _cantidaddispo
        End Get
        Set(value As Integer)
            _cantidaddispo = value
        End Set
    End Property

    Public Property Cantidadminima As Integer
        Get
            Return _cantidadminima
        End Get
        Set(value As Integer)
            _cantidadminima = value
        End Set
    End Property
#End Region
#Region "Metodos"
    Public Function leerXML()
        Dim obj_datos_Lectura As New Clase_Leer_XML
        Dim dt_producto As DataTable = Me.TablaSistemadecompras.copy
        If obj_datos_Lectura.verificarProducto Then
            Dim _archivoXML As XmlDocument = obj_datos_Lectura.leerProducto()

            Dim listaXML As XmlNodeList = _archivoXML.SelectNodes("Productos/Producto")
            Dim fila As DataRow

            For Each producto As XmlNode In listaXML
                fila = dt_producto.NewRow
                Cantidaddispo = producto("Disponible").InnerText
                Cantidadminima = producto("Minima").InnerText
                If Cantidaddispo <= Cantidadminima Then

                    fila("Fecha") = DateTime.Now.ToString()
                    fila("Codigo") = producto("Codigo").InnerText
                    fila("Producto") = producto("Producto").InnerText
                    fila("Disponible") = producto("Disponible").InnerText

                    dt_producto.Rows.Add(fila)
                End If
            Next
        End If
        Return dt_producto
    End Function
    Sub CrearXML()
        Dim obj_datos_Lectura As New Clase_Leer_XML
        Dim dt_producto As DataTable = Me.TablaSistemadecompras.copy
        If obj_datos_Lectura.verificarProducto Then
            Dim _archivoXML As XmlDocument = obj_datos_Lectura.leerProducto()
            Dim listaXML As XmlNodeList = _archivoXML.SelectNodes("Productos/Producto")
            Dim fila As DataRow

            For Each producto As XmlNode In listaXML
                fila = dt_producto.NewRow
                Cantidaddispo = producto("Disponible").InnerText
                Cantidadminima = producto("Minima").InnerText

                If Cantidaddispo <= Cantidadminima Then
                    fila("Fecha") = DateTime.Now.ToString()
                    fila("Codigo") = producto("Codigo").InnerText
                    fila("Producto") = producto("Producto").InnerText
                    fila("Disponible") = producto("Disponible").InnerText

                    dt_producto.Rows.Add(fila)

                    Dim obj_datos As New Clase_Compra_XML
                    obj_datos.Tabla = dt_producto

                    obj_datos.EscribirSistemadecompras()
                End If
            Next
        End If
    End Sub
    Public Function TablaSistemadecompras()
        Dim tabla_chequeo As New DataTable
        Dim columnaTabla As New DataColumn

        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Fecha"
        columnaTabla.Caption = "Fecha"
        columnaTabla.DataType = Type.GetType("System.DateTime")

        tabla_chequeo.Columns.Add(columnaTabla)
        columnaTabla = New DataColumn

        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Codigo"
        columnaTabla.Caption = "Codigo"
        columnaTabla.DataType = Type.GetType("System.String")

        tabla_chequeo.Columns.Add(columnaTabla)
        columnaTabla = New DataColumn

        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Producto"
        columnaTabla.Caption = "Producto"
        columnaTabla.DataType = Type.GetType("System.String")

        tabla_chequeo.Columns.Add(columnaTabla)
        columnaTabla = New DataColumn

        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Disponible"
        columnaTabla.Caption = "Disponible"
        columnaTabla.DataType = Type.GetType("System.Int32")

        tabla_chequeo.Columns.Add(columnaTabla)
        Return tabla_chequeo
    End Function
#End Region
End Class
