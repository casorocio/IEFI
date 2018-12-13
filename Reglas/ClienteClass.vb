Public Class ClienteClass


    Dim Id_, IdProvincia_ As Integer
    Dim Nombre_ As String
    Dim Saldo_ As Decimal
    Dim Fecha_ As Date
    Public Property Saldo() As Decimal
        Get
            Return Saldo_
        End Get
        Set(value As Decimal)
            Saldo_ = value
        End Set
    End Property
    Public Property Fecha() As Date
        Get
            Return Fecha_
        End Get
        Set(value As Date)
            Fecha_ = value
        End Set
    End Property
    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return Nombre_
        End Get
        Set(ByVal value As String)
            Nombre_ = value
        End Set
    End Property

    Public Property IdProvincia() As Integer
        Get
            Return IdProvincia_
        End Get
        Set(value As Integer)
            IdProvincia_ = value
        End Set
    End Property

    Dim nomprovincia_ As String
    Public ReadOnly Property nomprovincia()
        Get
            'Busca el id que corresponde a IdProvincia y cuando lo encuentra retorna la columna provincia con la columna del nombre(Provincia)
            For Each provinci As ProvinciaClass In ProvinciasList
                If provinci.Id = IdProvincia_ Then
                    nomprovincia_ = provinci.Provincia
                    Exit For
                End If
            Next

            Return nomprovincia_
        End Get
    End Property

End Class
