﻿'importas las clases
Imports CapaDato
Imports System.Xml

Public Class Clase_Entradas
    'variables 
    Dim _obj_empleado As New Clase_Empleado
    Dim _obj_productos As New Clase_Producto
    Dim _nombre As String
    Dim _cantidad As Integer
    Dim _identificacion As String
    Dim _producto As Boolean = False
#Region "Propiedades"
    Public Property Cantidad As Integer
        Get
            Return _cantidad
        End Get
        Set(value As Integer)
            _cantidad = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Identificacion As String
        Get
            Return _identificacion
        End Get
        Set(value As String)
            _identificacion = value
        End Set
    End Property

    Public Property Producto As Boolean
        Get
            Return _producto
        End Get
        Set(value As Boolean)
            _producto = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Sub ValidarEntrada()
        If _nombre = "" Then
            Throw New Exception("Debe de seleccionar un producto")
        End If
        If Not IsNumeric(Cantidad) Or Cantidad.ToString.Trim.Length = 0 Then
            Throw New Exception("La cantidad no debe quedar en blanco y debe ser numérica")
        End If
        If Not IsNumeric(_identificacion) Or _identificacion.Trim.Length = 0 Then
            Throw New Exception("La identificacion no debe quedar en blanco y debe ser numérica")
        End If
    End Sub
    Sub ValidarEmpleado()
        Dim obj_datos_Lectura As New Clase_Leer_XML
        Dim dt_empleado As DataTable = _obj_empleado.tablaEmpleados.copy
        If obj_datos_Lectura.verificarEmpleado Then
            Dim _archivoXML As XmlDocument = obj_datos_Lectura.leerEmpleado()
            Dim listaXML As XmlNodeList = _archivoXML.SelectNodes("Empleados/Empleado")
            Dim fila As DataRow

            For Each empleado As XmlNode In listaXML
                fila = dt_empleado.NewRow
                If Identificacion = empleado("Cedula").InnerText Then
                    If "Activo" = empleado("Estado").InnerText Then
                        Producto = True
                    End If
                End If
            Next
        End If
    End Sub
    Public Function Tablaentrada()
        Dim tabla_entrada As New DataTable
        Dim columnaTabla As New DataColumn

        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Producto"
        columnaTabla.Caption = "Producto"
        columnaTabla.DataType = Type.GetType("System.String")

        tabla_entrada.Columns.Add(columnaTabla)
        columnaTabla = New DataColumn

        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Cantidad"
        columnaTabla.Caption = "Cantidad"
        columnaTabla.DataType = Type.GetType("System.Int32")

        tabla_entrada.Columns.Add(columnaTabla)
        columnaTabla = New DataColumn

        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Fecha"
        columnaTabla.Caption = "Fecha"
        columnaTabla.DataType = Type.GetType("System.DateTime")

        tabla_entrada.Columns.Add(columnaTabla)

        columnaTabla = New DataColumn

        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Movimiento"
        columnaTabla.Caption = "Movimiento"
        columnaTabla.DataType = Type.GetType("System.String")

        tabla_entrada.Columns.Add(columnaTabla)
        columnaTabla = New DataColumn

        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Empleado"
        columnaTabla.Caption = "Empleado"
        columnaTabla.DataType = Type.GetType("System.String")

        tabla_entrada.Columns.Add(columnaTabla)
        Return tabla_entrada
    End Function

    Public Sub llenarTabla()
        Dim obj_datos_Lectura As New Clase_Leer_XML
        Dim dt_producto As DataTable = Me.Tablaentrada.copy
        If obj_datos_Lectura.verificarEntrada Then
            dt_producto = Me.leerXML
        End If

        Dim fila As DataRow
        fila = dt_producto.NewRow

        fila("Producto") = Nombre
        fila("Cantidad") = Cantidad
        fila("Fecha") = DateTime.Now.ToString()
        fila("Movimiento") = "Entrada"
        fila("Empleado") = Identificacion

        dt_producto.Rows.Add(fila)

        Dim obj_datos As New Clase_Entradas_XML
        obj_datos.Tabla = dt_producto

        obj_datos.EscribirEntrada()
    End Sub

    Sub AgregarProductos()
        Dim obj_datos_Lectura As New Clase_Leer_XML
        Dim dt_producto As DataTable = _obj_productos.tablaProducto.copy
        If obj_datos_Lectura.verificarProducto Then
            Dim _archivoXML As XmlDocument = obj_datos_Lectura.leerProducto()
            Dim listaXML As XmlNodeList = _archivoXML.SelectNodes("Productos/Producto")

            Dim _archivo As New XmlTextWriter("Productos.xml", Text.Encoding.UTF8)
            _archivo.WriteStartDocument()
            _archivo.WriteStartElement("Productos")
            Dim fila As DataRow

            For Each producto As XmlNode In listaXML
                fila = dt_producto.NewRow
                If Nombre = producto("Producto").InnerText Then
                    fila("Codigo") = producto("Codigo").InnerText
                    fila("Producto") = producto("Producto").InnerText
                    fila("Disponible") = Cantidad + producto("Disponible").InnerText
                    fila("Minima") = producto("Minima").InnerText

                    _archivo.WriteStartElement("Producto")

                    _archivo.WriteStartElement("Codigo")
                    _archivo.WriteString(fila("Codigo"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Producto")
                    _archivo.WriteString(fila("Producto"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Disponible")
                    _archivo.WriteString(fila("Disponible"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Minima")
                    _archivo.WriteString(fila("Minima"))
                    _archivo.WriteEndElement()

                    _archivo.WriteEndElement()
                Else
                    fila("Codigo") = producto("Codigo").InnerText
                    fila("Producto") = producto("Producto").InnerText
                    fila("Disponible") = producto("Disponible").InnerText
                    fila("Minima") = producto("Minima").InnerText

                    _archivo.WriteStartElement("Producto")

                    _archivo.WriteStartElement("Codigo")
                    _archivo.WriteString(fila("Codigo"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Producto")
                    _archivo.WriteString(fila("Producto"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Disponible")
                    _archivo.WriteString(fila("Disponible"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Minima")
                    _archivo.WriteString(fila("Minima"))
                    _archivo.WriteEndElement()

                    _archivo.WriteEndElement()
                End If
            Next
            _archivo.WriteEndElement()
            _archivo.WriteEndDocument()

            _archivo.Flush()
            _archivo.Close()
        End If
    End Sub
    Public Function leerXML()
        Dim obj_datos_Lectura As New Clase_Leer_XML
        Dim dt_producto As DataTable = Me.Tablaentrada.copy
        If obj_datos_Lectura.verificarEntrada Then
            Dim _archivoXML As XmlDocument = obj_datos_Lectura.leerEntrada()

            Dim listaXML As XmlNodeList = _archivoXML.SelectNodes("Entradas/Entrada")
            Dim fila As DataRow

            For Each producto As XmlNode In listaXML
                fila = dt_producto.NewRow
                fila("Producto") = producto("Producto").InnerText
                fila("Cantidad") = producto("Cantidad").InnerText
                fila("Fecha") = producto("Fecha").InnerText
                fila("Movimiento") = producto("Movimiento").InnerText
                fila("Empleado") = producto("Empleado").InnerText
                dt_producto.Rows.Add(fila)
            Next
        End If
        Return dt_producto
    End Function
#End Region

End Class
