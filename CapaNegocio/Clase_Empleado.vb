Imports CapaDato
Imports System.Xml

Public Class Clase_Empleado
    Dim _identificacion As String
    Dim _nombre As String
    Dim _primerapellido As String
    Dim _segundoapellido As String
    Dim _departamento As String
    Dim _Laboral As String
    Dim _telefono As String
    Dim _correo As String
    Dim _estado As String
    Dim _presente As Boolean = True

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

    Public Property Departamento As String
        Get
            Return _departamento
        End Get
        Set(value As String)
            _departamento = value
        End Set
    End Property

    Public Property Laboral As String
        Get
            Return _Laboral
        End Get
        Set(value As String)
            _Laboral = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
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

    'Validar
    Sub ValirEmpleado()
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
        If IsNumeric(_departamento) Or _departamento.Trim.Length = 0 Then
            Throw New System.Exception("El depertamento debe ser texto y no puede quedar en blanco!")
        End If
        If Not Departamento = "Construcción" Then
            Laboral = "No tiene"
        End If
        If Not IsNumeric(_telefono) Or _telefono.Trim.Length <> 8 Then
            Throw New System.Exception("El teléfono debe ser numérico!")
        End If
        If IsNumeric(_correo) Or _correo.Trim.Length = 0 Then
            Throw New System.Exception("El correo no debe quedar  en blanco!")
        End If
        If _estado = "" Then
            Throw New Exception("Debe de seleccionar un estado")
        End If
    End Sub
    Sub Validaridentificacion()
        If IsNumeric(_identificacion) Or _identificacion.Trim.Length = 0 Then
            Throw New System.Exception("El usuario no debe contener números o estar en blanco!")
        End If
        Dim objDatos_Lectura As New Clase_Leer_XML
        Dim dtProductos As DataTable = Me.tablaEmpleados.copy
        If objDatos_Lectura.verificarEmpleado Then
            Dim _archivoXML As XmlDocument = objDatos_Lectura.leerEmpleado()

            Dim listaXML As XmlNodeList = _archivoXML.SelectNodes("Empleados/Empleado")
            Dim fila As DataRow

            For Each producto As XmlNode In listaXML
                fila = dtProductos.NewRow
                If Identificacion = producto("Identificacion").InnerText Then
                    Presente = True
                End If
            Next
        End If
    End Sub

    Public Function tablaEmpleados()
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
        'agregar la columna del segundo apellido
        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Departamento"
        columnaTabla.Caption = "Departamento"
        columnaTabla.DataType = Type.GetType("System.String")
        'Agrego columna
        tabla_funcionarios.Columns.Add(columnaTabla)

        'agregar otra columna a la tabla
        columnaTabla = New DataColumn
        'agregar la columna del segundo apellido
        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Labora"
        columnaTabla.Caption = "Labora"
        columnaTabla.DataType = Type.GetType("System.String")
        'Agrego columna
        tabla_funcionarios.Columns.Add(columnaTabla)

        'agregar otra columna a la tabla
        columnaTabla = New DataColumn
        'agregar la columna del segundo apellido
        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Telefono"
        columnaTabla.Caption = "Telefono"
        columnaTabla.DataType = Type.GetType("System.String")
        'Agrego columna
        tabla_funcionarios.Columns.Add(columnaTabla)

        'agregar otra columna a la tabla
        columnaTabla = New DataColumn
        'agregar la columna del segundo apellido
        columnaTabla.AllowDBNull = False
        columnaTabla.ColumnName = "Correo"
        columnaTabla.Caption = "Correo"
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
        Dim dt_Empleado As DataTable = Me.tablaEmpleados.copy
        If obj_datos_Lectura.verificarEmpleado Then
            dt_Empleado = Me.leerXML()
        End If

        Dim fila As DataRow
        fila = dt_Empleado.NewRow

        fila("Cedula") = Identificacion
        fila("Nombre") = Nombre
        fila("PrimerApellido") = Primerapellido
        fila("SegundoApellido") = Segundoapellido
        fila("Departamento") = Departamento
        fila("Labora") = Laboral
        fila("Telefono") = Telefono
        fila("Correo") = Correo
        fila("Estado") = Estado

        dt_Empleado.Rows.Add(fila)

        Dim obj_datos As New Clase_Empleados_XML
        obj_datos.Tabla = dt_Empleado

        obj_datos.EscribirEmpledoXML()
    End Sub
    Sub ValidarUsuario()
        Dim obj_datos_Lectura As New Clase_Leer_XML
        Dim dt_Empleado As DataTable = Me.tablaEmpleados.copy
        If obj_datos_Lectura.verificarEmpleado Then
            Dim _archivoXML As XmlDocument = obj_datos_Lectura.leerEmpleado()
            Dim listaXML As XmlNodeList = _archivoXML.SelectNodes("Empleados/Empleado")
            Dim fila As DataRow

            For Each Empleado As XmlNode In listaXML
                fila = dt_Empleado.NewRow
                If Identificacion = Empleado("Cedula").InnerText Then
                    Throw New Exception("Ya hay un usuario registrado con el mismo número de cédula")
                End If
            Next
        End If
    End Sub
    Sub ModificarFuncionario()
        Dim obj_datos_Lectura As New Clase_Leer_XML
        Dim dt_Empleado As DataTable = Me.tablaEmpleados.copy
        If obj_datos_Lectura.verificarEmpleado Then
            Dim _archivoXML As XmlDocument = obj_datos_Lectura.leerEmpleado()
            Dim listaXML As XmlNodeList = _archivoXML.SelectNodes("Empleados/Empleado")

            Dim _archivo As New XmlTextWriter("Empleados.xml", Text.Encoding.UTF8)
            _archivo.WriteStartDocument()
            _archivo.WriteStartElement("Empleados")
            Dim fila As DataRow

            For Each Empleado As XmlNode In listaXML
                fila = dt_Empleado.NewRow
                If Identificacion = Empleado("Cedula").InnerText Then
                    fila("Cedula") = Identificacion
                    fila("Nombre") = Nombre
                    fila("PrimerApellido") = Primerapellido
                    fila("SegundoApellido") = Segundoapellido
                    fila("Departamento") = Departamento
                    fila("Labora") = Laboral
                    fila("Telefono") = Telefono
                    fila("Correo") = Correo
                    fila("Estado") = Estado

                    _archivo.WriteStartElement("Empleado")

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

                    _archivo.WriteStartElement("Departamento")
                    _archivo.WriteString(fila("Departamento"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Labora")
                    _archivo.WriteString(fila("Labora"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Telefono")
                    _archivo.WriteString(fila("Telefono"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Correo")
                    _archivo.WriteString(fila("Correo"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Estado")
                    _archivo.WriteString(fila("Estado"))
                    _archivo.WriteEndElement()

                    _archivo.WriteEndElement()
                Else
                    fila("Cedula") = Empleado("Cedula").InnerText
                    fila("Nombre") = Empleado("Nombre").InnerText
                    fila("PrimerApellido") = Empleado("PrimerApellido").InnerText
                    fila("SegundoApellido") = Empleado("SegundoApellido").InnerText
                    fila("Departamento") = Empleado("Departamento").InnerText
                    fila("Labora") = Empleado("Labora").InnerText
                    fila("Telefono") = Empleado("Telefono").InnerText
                    fila("Correo") = Empleado("Correo").InnerText
                    fila("Estado") = Empleado("Estado").InnerText

                    _archivo.WriteStartElement("Empleado")

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

                    _archivo.WriteStartElement("Departamento")
                    _archivo.WriteString(fila("Departamento"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Labora")
                    _archivo.WriteString(fila("Labora"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Telefono")
                    _archivo.WriteString(fila("Telefono"))
                    _archivo.WriteEndElement()

                    _archivo.WriteStartElement("Correo")
                    _archivo.WriteString(fila("Correo"))
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
        Dim dt_Empleado As DataTable = Me.tablaEmpleados.copy
        If obj_datos_Lectura.verificarEmpleado Then
            Dim _archivoXML As XmlDocument = obj_datos_Lectura.leerEmpleado()

            Dim listaXML As XmlNodeList = _archivoXML.SelectNodes("Empleados/Empleado")
            Dim fila As DataRow

            For Each Empleado As XmlNode In listaXML
                fila = dt_Empleado.NewRow
                fila("Cedula") = Empleado("Cedula").InnerText
                fila("Nombre") = Empleado("Nombre").InnerText
                fila("PrimerApellido") = Empleado("PrimerApellido").InnerText
                fila("SegundoApellido") = Empleado("SegundoApellido").InnerText
                fila("Departamento") = Empleado("Departamento").InnerText
                fila("Labora") = Empleado("Labora").InnerText
                fila("Telefono") = Empleado("Telefono").InnerText
                fila("Correo") = Empleado("Correo").InnerText
                fila("Estado") = Empleado("Estado").InnerText
                dt_Empleado.Rows.Add(fila)
            Next
        End If
        Return dt_Empleado
    End Function
#End Region
End Class
