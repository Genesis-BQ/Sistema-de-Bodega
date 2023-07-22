
'importar la clase 
Imports System.Xml
Imports CapaDato
Public Class Clase_Funcionario
    'Declarar Variables
    Dim _identificacion As String
    Dim _nombre As String
    Dim _primerapellido As String
    Dim _segundoapellido As String
    Dim _usuario As String
    Dim _contraseña As String
    Dim _estado As String
    Dim _presente As Boolean = False

#Region "Propiedades"
    Public Property Identificacion As String
        Get
            Return _identificacion
        End Get
        Set(value As String)
            _identificacion = value
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

    Public Property Primerapellido As String
        Get
            Return _primerapellido
        End Get
        Set(value As String)
            _primerapellido = value
        End Set
    End Property
    Public Property Segundoapellido As String
        Get
            Return _segundoapellido
        End Get
        Set(value As String)
            _segundoapellido = value
        End Set
    End Property
    Public Property Usuario As String
        Get
            Return _usuario
        End Get
        Set(value As String)
            _usuario = value
        End Set
    End Property

    Public Property Contraseña As String
        Get
            Return _contraseña
        End Get
        Set(value As String)
            _contraseña = value
        End Set
    End Property

    Public Property Estado As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value
        End Set
    End Property
    Public Property Presente As Boolean
        Get
            Return _presente
        End Get
        Set(value As Boolean)
            _presente = value
        End Set
    End Property
#End Region

#Region "Metodo"
    Sub ValidarFuncionario()
        'Aca va validar Funcionario
        If Not IsNumeric(_identificacion) Or _identificacion.Trim.Length <> 9 Then
            Throw New System.Exception("La  cédula debe tener  un tamaño de 9 dígitos y ser numérico!")
        End If
        If IsNumeric(_nombre) Or _nombre.Trim.Length = 0 Then
            Throw New System.Exception("El nombre no debe contener números o estar en blanco!")
        End If
        If IsNumeric(_primerapellido) Or _primerapellido.Trim.Length = 0 Then
            Throw New System.Exception("El primer apellido no debe contener números o estar en blanco!")
        End If
        If IsNumeric(_segundoapellido) Or _segundoapellido.Trim.Length = 0 Then
            Throw New System.Exception("El segundo apellido no debe contener números o estar en blanco!")
        End If
        If IsNumeric(_usuario) Or _usuario.Trim.Length = 0 Then
            Throw New System.Exception("El usuario no debe contener números o estar en blanco!")
        End If
        If IsNumeric(_contraseña) Or _contraseña.Trim.Length = 0 Then
            Throw New System.Exception("La contraseña no debe quedar en blanco!")
        End If
        If _estado = "" Then
            Throw New Exception("Debe de seleccionar un estado")
        End If
    End Sub
    Sub ValidarContraseña()
        If IsNumeric(_usuario) Or _usuario.Trim.Length = 0 Then
            Throw New System.Exception("El usuario no debe contener números o estar en blanco!")
        End If
        If IsNumeric(_contraseña) Or _contraseña.Trim.Length = 0 Then
            Throw New System.Exception("La contraseña no debe quedar en blanco!")
        End If
        Dim objDatos_Lectura As New Clase_Leer_XML
        Dim dtProductos As DataTable = Me.tablafuncionarios.copy
        If objDatos_Lectura.verificar Then
            Dim _archivoXML As XmlDocument = objDatos_Lectura.leer()

            Dim listaXML As XmlNodeList = _archivoXML.SelectNodes("Funcionarios/Funcionario")
            Dim fila As DataRow

            For Each producto As XmlNode In listaXML
                fila = dtProductos.NewRow
                If Usuario = producto("Usuario").InnerText Then
                    If Contraseña = producto("Contraseña").InnerText Then
                        If "Activo" = producto("Estado").InnerText Then
                            Presente = True
                        End If
                    End If
                End If
            Next
        End If

    End Sub

    Public Function tablafuncionarios()
        'crear la tabla junto con la columnas
        Dim tabla_funcionarios As New DataTable
        Dim columnaTabla As New DataColumn

        'agregar la columna de la cedula
        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Cedula"
        columnaTabla.Caption = "Cedula"
        columnaTabla.DataType = Type.GetType("System.String")
        'Agrego columna
        tabla_funcionarios.Columns.Add(columnaTabla)

        'agregar otra columna a la tabla
        columnaTabla = New DataColumn
        'agregar la columna del nombre
        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Nombre"
        columnaTabla.Caption = "Nombre"
        columnaTabla.DataType = Type.GetType("System.String")
        'Agrego columna
        tabla_funcionarios.Columns.Add(columnaTabla)

        'agregar otra columna a la tabla
        columnaTabla = New DataColumn
        'agregar la columna del primer apellido
        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "PrimerApellido"
        columnaTabla.Caption = "PrimerApellido"
        columnaTabla.DataType = Type.GetType("System.String")
        'Agrego columna
        tabla_funcionarios.Columns.Add(columnaTabla)

        'agregar otra columna a la tabla
        columnaTabla = New DataColumn
        'agregar la columna del segundo apellido
        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "SegundoApellido"
        columnaTabla.Caption = "SegundoApellido"
        columnaTabla.DataType = Type.GetType("System.String")
        'Agrego columna
        tabla_funcionarios.Columns.Add(columnaTabla)

        'agregar otra columna a la tabla
        columnaTabla = New DataColumn
        'agregar la columna del usuario
        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Usuario"
        columnaTabla.Caption = "Usuario"
        columnaTabla.DataType = Type.GetType("System.String")
        'Agrego columna
        tabla_funcionarios.Columns.Add(columnaTabla)

        'agregar otra columna a la tabla
        columnaTabla = New DataColumn
        'agregar la columna de la contraseña
        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Contraseña"
        columnaTabla.Caption = "Contraseña"
        columnaTabla.DataType = Type.GetType("System.String")
        'Agrego columna
        tabla_funcionarios.Columns.Add(columnaTabla)

        'agregar otra columna a la tabla
        columnaTabla = New DataColumn
        'agregar la columna el estado
        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Estado"
        columnaTabla.Caption = "Estado"
        columnaTabla.DataType = Type.GetType("System.String")
        'Agrego columna
        tabla_funcionarios.Columns.Add(columnaTabla)

        Return tabla_funcionarios
    End Function
    Sub Llenartabla()
        Dim obj_datos_Lectura As New Clase_Leer_XML
        Dim dt_funcionario As DataTable = Me.tablafuncionarios.copy
        If obj_datos_Lectura.verificar Then
            dt_funcionario = Me.leerXML()
        End If

        Dim fila As DataRow
        fila = dt_funcionario.NewRow

        fila("Cedula") = Identificacion
        fila("Nombre") = Nombre
        fila("PrimerApellido") = Primerapellido
        fila("SegundoApellido") = Segundoapellido
        fila("Usuario") = Usuario
        fila("Contraseña") = Contraseña
        fila("Estado") = Estado

        dt_funcionario.Rows.Add(fila)

        Dim obj_datos As New Clase_Funcionario_XML
        obj_datos.Tabla = dt_funcionario

        obj_datos.EscribirFuncionarioXML()
    End Sub

    Sub ValidarUsuario()
        Dim obj_datos_Lectura As New Clase_Leer_XML
        Dim dt_funcionario As DataTable = Me.tablafuncionarios.copy
        If obj_datos_Lectura.verificar Then
            Dim _archivoXML As XmlDocument = obj_datos_Lectura.leer()
            Dim listaXML As XmlNodeList = _archivoXML.SelectNodes("Funcionarios/Funcionario")
            Dim fila As DataRow

            For Each funcionario As XmlNode In listaXML
                fila = dt_funcionario.NewRow
                If Identificacion = funcionario("Cedula").InnerText Then
                    Throw New Exception("Ya hay un usuario registrado con el mismo número de cédula")
                End If
            Next
        End If
    End Sub
    Sub ModificarFuncionario()
        Dim obj_datos_Lectura As New Clase_Leer_XML
        Dim dt_funcionario As DataTable = Me.tablafuncionarios.copy
        If obj_datos_Lectura.verificar Then
            Dim _archivoXML As XmlDocument = obj_datos_Lectura.leer()
            Dim listaXML As XmlNodeList = _archivoXML.SelectNodes("Funcionarios/Funcionario")

            Dim _archivo As New XmlTextWriter("Funcionarios.xml", Text.Encoding.UTF8)
            _archivo.WriteStartDocument()
            _archivo.WriteStartElement("Funcionarios")
            Dim fila As DataRow

            For Each funcionario As XmlNode In listaXML
                fila = dt_funcionario.NewRow
                If Identificacion = funcionario("Cedula").InnerText Then
                    fila("Cedula") = Identificacion
                    fila("Nombre") = Nombre
                    fila("PrimerApellido") = Primerapellido
                    fila("SegundoApellido") = Segundoapellido
                    fila("Usuario") = Usuario
                    fila("Contraseña") = Contraseña
                    fila("Estado") = Estado

                    _archivo.WriteStartElement("Funcionario")

                    _archivo.WriteStartElement("Cedula")
                    _archivo.WriteString(fila("Cedula"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Nombre")
                    _archivo.WriteString(fila("Nombre"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("PrimerApellido")
                    _archivo.WriteString(fila("PrimerApellido"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("SegundoApellido")
                    _archivo.WriteString(fila("SegundoApellido"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Usuario")
                    _archivo.WriteString(fila("Usuario"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Contraseña")
                    _archivo.WriteString(fila("Contraseña"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Estado")
                    _archivo.WriteString(fila("Estado"))
                    _archivo.WriteEndElement()

                    _archivo.WriteEndElement()
                Else
                    fila("Cedula") = funcionario("Cedula").InnerText
                    fila("Nombre") = funcionario("Nombre").InnerText
                    fila("PrimerApellido") = funcionario("PrimerApellido").InnerText
                    fila("SegundoApellido") = funcionario("SegundoApellido").InnerText
                    fila("Usuario") = funcionario("Usuario").InnerText
                    fila("Contraseña") = funcionario("Contraseña").InnerText
                    fila("Estado") = funcionario("Estado").InnerText

                    _archivo.WriteStartElement("Funcionario")

                    _archivo.WriteStartElement("Cedula")
                    _archivo.WriteString(fila("Cedula"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Nombre")
                    _archivo.WriteString(fila("Nombre"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("PrimerApellido")
                    _archivo.WriteString(fila("PrimerApellido"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("SegundoApellido")
                    _archivo.WriteString(fila("SegundoApellido"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Usuario")
                    _archivo.WriteString(fila("Usuario"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Contraseña")
                    _archivo.WriteString(fila("Contraseña"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Estado")
                    _archivo.WriteString(fila("Estado"))
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
        Dim dt_funcionario As DataTable = Me.tablafuncionarios.copy
        If obj_datos_Lectura.verificar Then
            Dim _archivoXML As XmlDocument = obj_datos_Lectura.leer()

            Dim listaXML As XmlNodeList = _archivoXML.SelectNodes("Funcionarios/Funcionario")
            Dim fila As DataRow

            For Each funcionario As XmlNode In listaXML
                fila = dt_funcionario.NewRow
                fila("Cedula") = funcionario("Cedula").InnerText
                fila("Nombre") = funcionario("Nombre").InnerText
                fila("PrimerApellido") = funcionario("PrimerApellido").InnerText
                fila("SegundoApellido") = funcionario("SegundoApellido").InnerText
                fila("Usuario") = funcionario("Usuario").InnerText
                fila("Contraseña") = funcionario("Contraseña").InnerText
                fila("Estado") = funcionario("Estado").InnerText
                dt_funcionario.Rows.Add(fila)
            Next
        End If
        Return dt_funcionario
    End Function
#End Region
End Class
