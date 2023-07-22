'importar las clases
Imports System.Xml
Imports System.Data
Public Class Clase_Funcionario_XML
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
    Sub EscribirFuncionarioXML()
        'nombre el arhico xml 
        Dim _archivo As New XmlTextWriter("Funcionarios.xml", System.Text.Encoding.UTF8)
        'creación del xml
        _archivo.WriteStartDocument()
        'crear la etiqueta principal 
        _archivo.WriteStartElement("Funcionarios")
        'crear la tabla o nodo del xml
        For Each Fila As DataRow In _tabla.Rows
            'crea el nodo 
            _archivo.WriteStartElement("Funcionario")
            'crea los datos a dentro del nodo

            'agregar la cedula 
            _archivo.WriteStartElement("Cedula") 'Nombre de la etiqueta
            _archivo.WriteString(Fila("Cedula")) 'Nombre del datatable
            _archivo.WriteEndElement()

            'agregar el nombre
            _archivo.WriteStartElement("Nombre")
            _archivo.WriteString(Fila("Nombre"))
            _archivo.WriteEndElement()

            'agregar primer apellido
            _archivo.WriteStartElement("PrimerApellido")
            _archivo.WriteString(Fila("PrimerApellido"))
            _archivo.WriteEndElement()

            'agregar segundo apellido
            _archivo.WriteStartElement("SegundoApellido")
            _archivo.WriteString(Fila("SegundoApellido"))
            _archivo.WriteEndElement()

            'agregar usuario
            _archivo.WriteStartElement("Usuario")
            _archivo.WriteString(Fila("Usuario"))
            _archivo.WriteEndElement()

            'agregar contraseña
            _archivo.WriteStartElement("Contraseña")
            _archivo.WriteString(Fila("Contraseña"))
            _archivo.WriteEndElement()

            'agregar estado
            _archivo.WriteStartElement("Estado")
            _archivo.WriteString(Fila("Estado"))
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
