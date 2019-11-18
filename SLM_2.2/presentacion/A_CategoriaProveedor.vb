Public Class A_CategoriaProveedor

    Dim Categoria As New ClsCategoriaProveedor
    Private Sub A_CategoriaProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub A_CategoriaProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Listar categorias de proveedor
        dtCategorias.DataSource = Categoria.listarCategoriasProveedor

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        'Ingresar nueva categoria en base de datos

        With Categoria
            .Codig_o = txtCodBreve.Text
            .Descripcio_n = txtDescrip.Text
            .Cta_Acreedor = txtAcreedores.Text
            .Cta_Anticipos = txtAnticipos.Text
            .registrarNuevaCategoria()
        End With

    End Sub
End Class