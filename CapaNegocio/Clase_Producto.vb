Imports System.Xml
Imports CapaDato

Public Class Clase_Producto
    Dim _Producto As String
    Dim _Codigo As String
    Dim _Disponible As Integer
    Dim _Minima As Integer


#Region "Propiedades"
    Public Property Producto As String
        Get
            Return _Producto
        End Get
        Set(value As String)
            _Producto = value
        End Set
    End Property

    Public Property Codigo As String
        Get
            Return _Codigo
        End Get
        Set(value As String)
            _Codigo = value
        End Set
    End Property

    Public Property Disponible As Integer
        Get
            Return _Disponible
        End Get
        Set(value As Integer)
            _Disponible = value
        End Set
    End Property

    Public Property Minima As Integer
        Get
            Return _Minima
        End Get
        Set(value As Integer)
            _Minima = value
        End Set
    End Property

#End Region
#Region "Metodo"

    Sub ValidarProducto()
        If IsNumeric(_Producto) Or _Producto.Trim.Length = 0 Then
            Throw New System.Exception("El nombre no debe contener números o estar en blanco!")
        End If
        If (_Codigo.Trim.Length = 0) Then
            Throw New System.Exception("El Código no quedar en blaco! ")
        End If
        If Not IsNumeric(_Disponible) Then
            Throw New System.Exception("La cantidad disponible no debe quedar en blanco!")
        End If
        If Not IsNumeric(_Minima) Then
            Throw New System.Exception("La cantidad minima no debe quedar en blanco!")
        End If
    End Sub
    Public Function tablaProducto()
        'crear la tabla junto con la columnas
        Dim tabla_funcionarios As New DataTable
        Dim columnaTabla As New DataColumn

        'agregar la columna de la cedula
        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Producto"
        columnaTabla.Caption = "Producto"
        columnaTabla.DataType = Type.GetType("System.String")
        'Agrego columna
        tabla_funcionarios.Columns.Add(columnaTabla)

        'agregar otra columna a la tabla
        columnaTabla = New DataColumn
        'agregar la columna del nombre
        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Codigo"
        columnaTabla.Caption = "Codigo"
        columnaTabla.DataType = Type.GetType("System.String")
        'Agrego columna
        tabla_funcionarios.Columns.Add(columnaTabla)

        'agregar otra columna a la tabla
        columnaTabla = New DataColumn
        'agregar la columna del primer apellido
        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Disponible"
        columnaTabla.Caption = "Disponible"
        columnaTabla.DataType = Type.GetType("System.Int32")
        'Agrego columna
        tabla_funcionarios.Columns.Add(columnaTabla)

        'agregar otra columna a la tabla
        columnaTabla = New DataColumn
        'agregar la columna del segundo apellido
        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Minima"
        columnaTabla.Caption = "Minima"
        columnaTabla.DataType = Type.GetType("System.Int32")
        'Agrego columna
        tabla_funcionarios.Columns.Add(columnaTabla)

        Return tabla_funcionarios
    End Function
    Sub Llenartabla()
        Dim obj_datos_Lectura As New Clase_Leer_XML
        Dim dt_Producto As DataTable = Me.tablaProducto.copy
        If obj_datos_Lectura.verificarProducto Then
            dt_Producto = Me.leerXML()
        End If

        Dim fila As DataRow
        fila = dt_Producto.NewRow

        fila("Producto") = Producto
        fila("Codigo") = Codigo
        fila("Disponible") = Disponible
        fila("Minima") = Minima

        dt_Producto.Rows.Add(fila)

        Dim obj_datos As New Clase_Producto_XML
        obj_datos.Tabla = dt_Producto

        obj_datos.EscribirProductoXML()
    End Sub
    Sub ModificarProducto()
        Dim obj_datos_Lectura As New Clase_Leer_XML
        Dim dt_producto As DataTable = Me.tablaProducto.copy
        If obj_datos_Lectura.verificarProducto Then
            Dim _archivoXML As XmlDocument = obj_datos_Lectura.leerProducto()
            Dim listaXML As XmlNodeList = _archivoXML.SelectNodes("Productos/Producto")

            Dim _archivo As New XmlTextWriter("Productos.xml", Text.Encoding.UTF8)
            _archivo.WriteStartDocument()
            _archivo.WriteStartElement("Productos")
            Dim fila As DataRow

            For Each Productos As XmlNode In listaXML
                fila = dt_producto.NewRow
                If Codigo = Productos("Codigo").InnerText Then
                    fila("Producto") = Producto
                    fila("Codigo") = Codigo
                    fila("Disponible") = Disponible
                    fila("Minima") = Minima


                    _archivo.WriteStartElement("Producto")

                    _archivo.WriteStartElement("Producto")
                    _archivo.WriteString(fila("Producto"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Codigo")
                    _archivo.WriteString(fila("Codigo"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Disponible")
                    _archivo.WriteString(fila("Disponible"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Minima")
                    _archivo.WriteString(fila("Minima"))
                    _archivo.WriteEndElement()

                    _archivo.WriteEndElement()
                Else
                    fila("Producto") = Productos("Producto").InnerText
                    fila("Codigo") = Productos("Codigo").InnerText
                    fila("Disponible") = Productos("Disponible").InnerText
                    fila("Minima") = Productos("Minima").InnerText



                    _archivo.WriteStartElement("Producto")

                    _archivo.WriteStartElement("Producto")
                    _archivo.WriteString(fila("Producto"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Codigo")
                    _archivo.WriteString(fila("Codigo"))
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
        Dim dt_Productos As DataTable = Me.tablaProducto.copy
        If obj_datos_Lectura.verificarProducto Then
            Dim _archivoXML As XmlDocument = obj_datos_Lectura.leerProducto()

            Dim listaXML As XmlNodeList = _archivoXML.SelectNodes("Productos/Producto")
            Dim fila As DataRow

            For Each Productos As XmlNode In listaXML
                fila = dt_Productos.NewRow
                fila("Producto") = Productos("Producto").InnerText
                fila("Codigo") = Productos("Codigo").InnerText
                fila("Disponible") = Productos("Disponible").InnerText
                fila("Minima") = Productos("Minima").InnerText
                dt_Productos.Rows.Add(fila)
            Next
        End If
        Return dt_Productos
    End Function
#End Region
End Class
