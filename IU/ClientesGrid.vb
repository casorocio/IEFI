Public Class ClientesGrid

    'Dim MiCliente As New ClienteClass

    Private Sub llenarform()

        'Número dila seleccionado del datagridview
        Dim fila As Integer = DataGridView1.CurrentRow.Index

        ClienteForm.Id.Text = Clienteslist.Item(fila).Id
        ClienteForm.Nombre.Text = Clienteslist.Item(fila).Nombre
        'Falto asignar el IdProvincia de la lista para poder seleeccionarlo el combo.
        ClienteForm.IdProvincia = Clienteslist.Item(fila).IdProvincia


    End Sub

    Private Sub Insertar_Click(sender As Object, e As EventArgs) Handles Insertar.Click
        ClienteForm.operacion = "Insertar"
        ClienteForm.Text = "Insertar Cliente"

        ClienteForm.Show()
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("No hay filas para eliminar.")
            Exit Sub
        End If

        ClienteForm.operacion = "Eliminar"
        ClienteForm.Text = "Eliminar  Cliente"
        ClienteForm.indice = DataGridView1.CurrentRow.Index
        'CursoForm.TituloLable1.text = "Eliminar Cliente"
        ClienteForm.IdProvincia = Clienteslist.Item(DataGridView1.CurrentRow.Index).IdProvincia

        llenarform()
        ClienteForm.Show()
    End Sub

    Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles Actualizar.Click

        'Determina si existen filas en el DataGridView
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("No hay filas para modificar.")
            Exit Sub
        End If

        ClienteForm.operacion = "Actualizar"
        ClienteForm.Text = "actualiza Cliente"
        ClienteForm.indice = DataGridView1.CurrentRow.Index

        llenarform()
        ClienteForm.Show()

        'Selecciono nuevamente la fila para que refresque el contenido, sino no muestra la modificación.
        DataGridView1.Rows(DataGridView1.CurrentRow.Index).Selected = False
        DataGridView1.Rows(DataGridView1.CurrentRow.Index).Selected = True

    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click

        Me.Dispose()

    End Sub

    Private Sub ClientesGrid_Load(sender As Object, e As EventArgs) Handles Me.Load

        ClientesCollectionBindingSource.DataSource = Clienteslist.TraerCliente
        'Debe llenarse la provinciasList para mostrar la columna nombre de la provincia en la grilla.
        ProvinciasList.TraerProvincia()

        'Si la cantidad de filas es mayor a cero, entonces selecciono la primer fila.
        If DataGridView1.Rows.Count > 0 Then
            DataGridView1.Rows(0).Selected = True
        End If
    End Sub
End Class