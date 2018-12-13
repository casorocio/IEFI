Public Class ClienteForm
    Dim operacion_ As String
    Dim IdProvincia_ As Integer
    Dim MiCliente As New ClienteClass
    Public Property IdProvincia() As Integer
        Get
            Return IdProvincia_
        End Get
        Set(value As Integer)
            IdProvincia_ = value
        End Set
    End Property
    Public Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property

    Dim indice_ As Byte
    Public Property indice() As Byte
        Get
            Return indice_
        End Get
        Set(ByVal value As Byte)

            indice_ = value
        End Set
    End Property

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click

        If operacion_ <> "Insertar" Then
            MiCliente.Id = CInt(Id.Text)
        End If

        MiCliente.Nombre = Nombre.Text
        'Faltó setear la propiedad IdProvincia
        MiCliente.IdProvincia = Provinciacombo.SelectedValue

        Select Case operacion_

            Case "Insertar"
                Clienteslist.InsertarCliente(MiCliente)

            Case "Actualizar"
                Clienteslist.ActualizarCliente(MiCliente)

            Case "Eliminar"
                Clienteslist.EliminarCliente(MiCliente)

        End Select


        Me.Close()
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

    Private Sub ClienteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Fuente de datos la coleccion asignaturas_list.
        Provinciacombo.DataSource = ProvinciasList.TraerProvincia

        'El miembro de valor es siempre el id.
        Provinciacombo.ValueMember = "Id"
        'Falto el miebro o columna a mostrar en el combo.
        Provinciacombo.DisplayMember = "Provincia"

        'El valor seleccionado del combo es combo que contiene el IdProvincia
        'Provinciacombo.SelectedValue = Provinciacombo para esto es la propiedad IdProvincia del ClienteForm.
        Provinciacombo.SelectedValue = IdProvincia_

    End Sub

    Private Sub Nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Nombre.KeyPress

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False

        End If

        Me.Nombre.Text = Trim(Replace(Me.Nombre.Text, " ", ""))
        Nombre.Select(Nombre.Text.Length, 0)

    End Sub

    Private Sub SaldoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SaldoTextBox.KeyPress

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        Me.SaldoTextBox.Text = Trim(Replace(Me.SaldoTextBox.Text, "  ", " "))
        SaldoTextBox.Select(SaldoTextBox.Text.Length, 0)
        Exit Sub
    End Sub
End Class
