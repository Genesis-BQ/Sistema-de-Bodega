Imports System.Xml
Imports System.IO

Public Class Clase_Leer_XML
    Dim _archivoXML As New XmlDocument
#Region "Propiedades"
    Public Property ArchivoXML As XmlDocument
        Get
            Return _archivoXML
        End Get
        Set(value As XmlDocument)
            _archivoXML = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Function verificar()
        Return File.Exists("Funcionarios.xml")
    End Function

    Public Function leer()
        ArchivoXML.Load("Funcionarios.xml")
        Return ArchivoXML
    End Function

    Public Function verificarEmpleado()
        Return File.Exists("Empleados.xml")
    End Function

    Public Function leerEmpleado()
        ArchivoXML.Load("Empleados.xml")
        Return ArchivoXML
    End Function

    Public Function verificarProducto()
        Return File.Exists("Productos.xml")
    End Function

    Public Function leerProducto()
        ArchivoXML.Load("Productos.xml")
        Return ArchivoXML
    End Function

    Public Function verificarEntrada()
        Return File.Exists("Entradas.xml")
    End Function

    Public Function leerEntrada()
        ArchivoXML.Load("Entradas.xml")
        Return ArchivoXML
    End Function
    Public Function verificarSalida()
        Return File.Exists("Salidas.xml")
    End Function

    Public Function leerSalida()
        ArchivoXML.Load("Salidas.xml")
        Return ArchivoXML
    End Function
#End Region
End Class
