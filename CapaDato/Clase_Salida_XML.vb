﻿Imports System.Xml
Public Class Clase_Salida_XML
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
#Region "Propiedades"
    Sub EscribirSalida()
        Dim _archivo As New XmlTextWriter("Salidas.xml", Text.Encoding.UTF8)
        _archivo.WriteStartDocument()
        _archivo.WriteStartElement("Salidas")

        For Each Fila As DataRow In Tabla.Rows
            _archivo.WriteStartElement("Salida")

            _archivo.WriteStartElement("Producto")
            _archivo.WriteString(Fila("Producto"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("Cantidad")
            _archivo.WriteString(Fila("Cantidad"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("Fecha")
            _archivo.WriteString(Fila("Fecha"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("Movimiento")
            _archivo.WriteString(Fila("Movimiento"))
            _archivo.WriteEndElement()

            _archivo.WriteStartElement("Empleado")
            _archivo.WriteString(Fila("Empleado"))
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
