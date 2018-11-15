﻿Public Class ClienteForm
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
End Class
