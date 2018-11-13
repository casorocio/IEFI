Imports System.ComponentModel
Imports System.Text

Public Class ProvinciasCollection

    Inherits BindingList(Of ProvinciaClass)

    Protected Overrides Sub OnAddingNew(ByVal e As System.ComponentModel.AddingNewEventArgs)
            MyBase.OnAddingNew(e)
        e.NewObject = New ProvinciaClass

    End Sub

        Protected Overrides ReadOnly Property SupportsSearchingCore() As Boolean
            Get
                Return True
            End Get
        End Property

        Protected Overrides Function FindCore(ByVal prop As PropertyDescriptor, ByVal key As Object) As Integer
        For Each Provincia In Me
            If prop.GetValue(Provincia).Equals(key) Then
                Return Me.IndexOf(Provincia)
            End If
        Next

        Return -1
        End Function

    Public Function TraerProvincia() As ProvinciasCollection

        If Me.Items.Count > 0 Then Me.ClearItems()

        'crea la intancia de base de datos
        Dim ObjBaseDatos As New BaseDatosClass
        Dim MiDataTable As New DataTable
        Dim MiProvincia As ProvinciaClass

        ObjBaseDatos.objTabla = "Provincias"
        'devuelve los datos de la base de dato
        MiDataTable = ObjBaseDatos.TraerTodo
        'por cada dr (fila)llena cada fecha

        For Each dr As DataRow In MiDataTable.Rows
            'crea la instancia por cada campo
            MiProvincia = New ProvinciaClass

            MiProvincia.Id = CInt(dr("Id"))
            MiProvincia.Provincia = dr("Provincia")

            Me.Add(MiProvincia)

        Next

        Return Me

    End Function

    Public Sub InsertarProvincia(ByVal MiProvincia As ProvinciaClass)

        Dim ObjBasedeDato As New BaseDatosClass
        'busca la tabla personas 
        ObjBasedeDato.objTabla = "Provincias"

        Dim vsql As New StringBuilder
        vsql.Append("(Provincia)")

        vsql.Append(" VALUES ")

        vsql.Append("('" & MiProvincia.Provincia & "')")

        MiProvincia.Id = ObjBasedeDato.Insertar(vsql.ToString)

        'Evalúa el resultado del comando SQL.
        If MiProvincia.Id = 0 Then
            MsgBox("No fue posible agregar el Provincia ")
            Exit Sub
        End If

        Me.Add(MiProvincia)

    End Sub

    Public Sub EliminarProvincia(ByVal MiProvincia As ProvinciaClass)

        ' Instancio en el objeto BaseDatosClass para accede a la base Fechas
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Provincia"

        For Each Provincia In ProvinciasList

            'ejecuta el método base eliminar 
            Dim resultado As Boolean

            resultado = objBaseDatos.Eliminar(MiProvincia.Id)

            If Not resultado Then
                MessageBox.Show("No fue posible eliminar Rubro" + CStr(MiProvincia.Id))
                Exit Sub
            End If

        Next

        Me.ClearItems()

    End Sub

    Public Sub ActualizarProvincia(ByVal MiProvincia As ProvinciaClass)

        'Instancio el el Objeto BaseDatosClass para acceder al la base personas.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Provincias"

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        'vSQL.Append("Id='" & MiPersona.Id.ToString & "'")
        vSQL.Append("Provincia='" & MiProvincia.Provincia & "'")
        'vSQL.Append(",FechaDesde='" & MiRubro.FechaDesde.ToString & "'")
        'vSQL.Append(",FechaHasta='" & MiRubro.FechaHasta.ToString & "'")

        'Actualizo la tabla personas con el Id.
        Dim resultado As Boolean
        'El método actualizar es una función que devuelve True o False
        'Según como haya resultado la operación sobre la tabla SQL.
        resultado = objBaseDatos.Actualizar(vSQL.ToString, MiProvincia.Id)

        If Not resultado Then
            MessageBox.Show("No fue posible modificar el Provincia ")
            Exit Sub
        End If

        'El código a continuación sirve para localizar el ítem en la lista
        'en este caso un Rubro.
        ' Creates a new collection and assign it the properties for modulo.
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiProvincia)

        'Sets an PropertyDescriptor to the specific property Id.
        Dim myProperty As PropertyDescriptor = properties.Find("Id", False)
        Me.Items.Item(Me.FindCore(myProperty, MiProvincia.Id)) = MiProvincia

    End Sub

End Class
