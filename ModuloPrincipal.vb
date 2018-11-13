Option Strict On
Option Explicit Off
Module ModuloPrincipal
    Public Clienteslist As New ClientesCollection
    Public ProvinciasList As New ProvinciasCollection

    Public Sub main()

        Application.Run(ClientesGrid)

    End Sub
End Module
