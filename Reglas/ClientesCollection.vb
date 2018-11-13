Imports System.ComponentModel
Imports System.Text
Public Class ClientesCollection

    Inherits BindingList(Of ClienteClass)

    Protected Overrides Sub OnAddingNew(ByVal e As System.ComponentModel.AddingNewEventArgs)
        MyBase.OnAddingNew(e)
        e.NewObject = New ClienteClass
    End Sub

    Protected Overrides ReadOnly Property SupportsSearchingCore() As Boolean
        Get
            Return True
        End Get
    End Property

    Protected Overrides Function FindCore(ByVal prop As PropertyDescriptor, ByVal key As Object) As Integer
        For Each Cliente In Me
            If prop.GetValue(Cliente).Equals(key) Then
                Return Me.IndexOf(Cliente)
            End If
        Next

        Return -1
    End Function

    ''' <summary>
    ''' Trae todos las Articulos.
    ''' </summary>
    ''' <returns></returns>
    Public Function TraerCliente() As ClientesCollection

        'Si la lista ya esta cargada la limpiamos.
        If Me.Items.Count > 0 Then Me.ClearItems()

        Dim ObjBaseDatos As New BaseDatosClass
        Dim MiDataTable As New DataTable
        Dim MiCliente As ClienteClass

        ObjBaseDatos.objTabla = "Cliente"
        MiDataTable = ObjBaseDatos.TraerTodo

        For Each dr As DataRow In MiDataTable.Rows
            MiCliente = New ClienteClass

            MiCliente.Id = CInt(dr("Id"))
            MiCliente.Nombre = dr("Nombre")
            MiCliente.IdProvincia = CInt("IdProvincia")

            Me.Add(MiCliente)
        Next

        Return Me

    End Function

    ''' <summary>
    ''' Trae las Articulos filtrado por IdTurno.
    ''' </summary>
    ''' <param name="IdProvincia"></param>
    ''' <returns></returns>
    Public Function TraerCliente(ByVal IdProvincia As Integer) As ClientesCollection

        'Si la lista ya esta cargada la limpiamos.
        If Me.Items.Count > 0 Then Me.ClearItems()

        Dim ObjBaseDatos As New BaseDatosClass
        Dim MiDataTable As New DataTable
        Dim MiCliente As ClienteClass
        Dim filtro As String = "IdProvincia = " & IdProvincia

        ObjBaseDatos.objTabla = "Clientes"
        MiDataTable = ObjBaseDatos.TraerFiltrado(filtro)

        For Each dr As DataRow In MiDataTable.Rows
            MiCliente = New ClienteClass

            MiCliente.Id = CInt(dr("Id"))
            MiCliente.Nombre = dr("Nombre")
            MiCliente.IdProvincia = CInt(dr("IdProvincia"))

            Me.Add(MiCliente)
        Next

        Return Me

    End Function

    Public Sub InsertarCliente(ByVal MiCliente As ClienteClass)

        Dim ObjBasedeDato As New BaseDatosClass
        'busca la tabla personas 
        ObjBasedeDato.objTabla = "Clientes"

        Dim vsql As New StringBuilder

        vsql.Append("(Nombre")
        vsql.Append("IdProvincia)")

        vsql.Append(" VALUES ")

        vsql.Append("('" & MiCliente.Nombre & "'")
        vsql.Append(", '" & MiCliente.IdProvincia & "')")

        MiCliente.Id = ObjBasedeDato.Insertar(vsql.ToString)

        'Evalúa el resultado del comando SQL.
        If MiCliente.Id = 0 Then
            MsgBox("No fue posible agregar el Cliente ")
            Exit Sub
        End If

        Me.Add(MiCliente)

    End Sub

    Public Sub EliminarCliente(ByVal MiCliente As ClienteClass)

        'Instancio el el Objeto BaseDatosClass para acceder al la base personas.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Clientes"

        'Ejecuta el método base eliminar.
        Dim resultado As Boolean
        resultado = objBaseDatos.Eliminar(MiCliente.Id)

        If Not resultado Then
            MessageBox.Show("No fue posible eliminar el registro.")
            Exit Sub
        End If

        'Creates a new collection and assign it the properties for modulo.
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiCliente)

        'Sets an PropertyDescriptor to the specific property Id.
        Dim myProperty As PropertyDescriptor = properties.Find("Id", False)

        Me.RemoveAt(Me.FindCore(myProperty, MiCliente.Id))

    End Sub

    Public Sub EliminarCliente(ByVal IdProvincia As Integer)

        'Llena articulosList con articulos del IdRubro
        Clienteslist.TraerCliente(IdProvincia)

        'Instancio el el Objeto BaseDatosClass para acceder al la base productos.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Clientes"

        For Each Cliente In Clienteslist
            'Ejecuta el método base eliminar.
            Dim resultado As Boolean
            resultado = objBaseDatos.Eliminar(Cliente.Id)

            If Not resultado Then
                MessageBox.Show("No fue posible eliminar el registro.")
                Exit For
            End If

            'Creates a new collection and assign it the properties for modulo.
            Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(Cliente)

            'Sets an PropertyDescriptor to the specific property Id.
            Dim myProperty As PropertyDescriptor = properties.Find("Id", False)
        Next

        Me.ClearItems()

    End Sub

    Public Sub ActualizarCliente(ByVal MiCliente As ClienteClass)

        'Instancio el el Objeto BaseDatosClass para acceder al la base productos.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Clientes"

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("Nombre='" & MiCliente.Nombre & "'")
        vSQL.Append(",IdProvincia='" & MiCliente.IdProvincia.ToString & "'")

        'Actualizo la tabla personas con el Id.
        Dim resultado As Boolean
        'El método actualizar es una función que devuelve True o False
        'Según como haya resultado la operación sobre la tabla SQL.
        resultado = objBaseDatos.Actualizar(vSQL.ToString, MiCliente.Id)

        If Not resultado Then
            MessageBox.Show("No fue posible modificar el registro.")
            Exit Sub
        End If

        'El código a continuación sirve para localizar el ítem en la lista
        'en este caso un persona.
        ' Creates a new collection and assign it the properties for modulo.
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiCliente)

        'Sets an PropertyDescriptor to the specific property Id.
        Dim myProperty As PropertyDescriptor = properties.Find("Id", False)
        Me.Items.Item(Me.FindCore(myProperty, MiCliente.Id)) = MiCliente

    End Sub
End Class
