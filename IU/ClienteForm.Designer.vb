<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClienteForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Provinciacombo = New System.Windows.Forms.ComboBox()
        Me.Id = New System.Windows.Forms.TextBox()
        Me.Nombre = New System.Windows.Forms.TextBox()
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.Saldo = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SaldoTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "IdProvincia"
        '
        'Provinciacombo
        '
        Me.Provinciacombo.FormattingEnabled = True
        Me.Provinciacombo.Location = New System.Drawing.Point(142, 105)
        Me.Provinciacombo.Name = "Provinciacombo"
        Me.Provinciacombo.Size = New System.Drawing.Size(269, 21)
        Me.Provinciacombo.TabIndex = 3
        '
        'Id
        '
        Me.Id.Location = New System.Drawing.Point(142, 28)
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Size = New System.Drawing.Size(100, 20)
        Me.Id.TabIndex = 4
        '
        'Nombre
        '
        Me.Nombre.Location = New System.Drawing.Point(142, 68)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(269, 20)
        Me.Nombre.TabIndex = 5
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(241, 222)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Aceptar.TabIndex = 6
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(336, 222)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 7
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.Location = New System.Drawing.Point(27, 148)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(37, 13)
        Me.Fecha.TabIndex = 8
        Me.Fecha.Text = "Fecha"
        '
        'Saldo
        '
        Me.Saldo.AutoSize = True
        Me.Saldo.Location = New System.Drawing.Point(27, 182)
        Me.Saldo.Name = "Saldo"
        Me.Saldo.Size = New System.Drawing.Size(34, 13)
        Me.Saldo.TabIndex = 9
        Me.Saldo.Text = "Saldo"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(299, 145)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 10
        '
        'SaldoTextBox
        '
        Me.SaldoTextBox.Location = New System.Drawing.Point(299, 175)
        Me.SaldoTextBox.Name = "SaldoTextBox"
        Me.SaldoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SaldoTextBox.TabIndex = 11
        '
        'ClienteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 257)
        Me.Controls.Add(Me.SaldoTextBox)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Saldo)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.Id)
        Me.Controls.Add(Me.Provinciacombo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ClienteForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ClientesForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Provinciacombo As ComboBox
    Friend WithEvents Id As TextBox
    Friend WithEvents Nombre As TextBox
    Friend WithEvents Aceptar As Button
    Friend WithEvents Salir As Button
    Friend WithEvents Fecha As Label
    Friend WithEvents Saldo As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents SaldoTextBox As TextBox
End Class
