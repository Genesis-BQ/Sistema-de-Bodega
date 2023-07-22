Imports System.Xml
Public Class Clase_Compra_XML
    Dim _tabla As DataTable

#Region "Propiedades"
    Public Property Tabla As DataTable
        Get
            Return _tabla
        End Get
        Set(value As DataTable)
            _tabla = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Sub EscribirSistemadecompras()
        Dim _archivo As New XmlTextWriter("Sistema de compras.xml", Text.Encoding.UTF8)
        _archivo.WriteStartDocument()
        _archivo.WriteStartElement("Productos")

        For Each Fila As DataRow In Tabla.Rows
            _archivo.WriteStartElement("Producto")

            _archivo.WriteStartElement("Fecha")
            _archivo.WriteString(Fila("Fecha"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("Codigo")
            _archivo.WriteString(Fila("Codigo"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("Producto")
            _archivo.WriteString(Fila("Producto"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("Disponible")
            _archivo.WriteString(Fila("Disponible"))
            _archivo.WriteEndElement()

            _archivo.WriteEndElement()
        Next

        _archivo.WriteEndElement()
        _archivo.WriteEndDocument()

        _archivo.Flush()
        _archivo.Close()
    End Sub
#End Region
End Class
