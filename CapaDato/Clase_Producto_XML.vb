'importar las clases
Imports System.Xml
Imports System.Data
Public Class Clase_Producto_XML

    'variables de trabajo
    Dim _tabla As DataTable
    'propiedades de la varibale
    Public Property Tabla As DataTable
        Get
            Return _tabla
        End Get
        Set(value As DataTable)
            _tabla = value
        End Set
    End Property
    'proceso de la creación del xml 
    Sub EscribirProductoXML()
        'nombre el arhico xml 
        Dim _archivo As New XmlTextWriter("Productos.xml", System.Text.Encoding.UTF8)
        'creación del xml
        _archivo.WriteStartDocument()
        'crear la etiqueta principal 
        _archivo.WriteStartElement("Productos")
        'crear la tabla o nodo del xml
        For Each Fila As DataRow In _tabla.Rows
            'crea el nodo 
            _archivo.WriteStartElement("Producto")
            'crea los datos a dentro del nodo

            'agregar la cedula 
            _archivo.WriteStartElement("Producto") 'Nombre de la etiqueta
            _archivo.WriteString(Fila("Producto")) 'Nombre del datatable
            _archivo.WriteEndElement()

            'agregar el nombre
            _archivo.WriteStartElement("Codigo")
            _archivo.WriteString(Fila("Codigo"))
            _archivo.WriteEndElement()

            'agregar primer apellido
            _archivo.WriteStartElement("Disponible")
            _archivo.WriteString(Fila("Disponible"))
            _archivo.WriteEndElement()

            'agregar segundo apellido
            _archivo.WriteStartElement("Minima")
            _archivo.WriteString(Fila("Minima"))
            _archivo.WriteEndElement()


            ' cierra del nodo funcionario
            _archivo.WriteEndElement()
        Next

        _archivo.WriteEndElement()
        _archivo.WriteEndDocument()

        _archivo.Flush()

        _archivo.Close()

    End Sub
End Class
