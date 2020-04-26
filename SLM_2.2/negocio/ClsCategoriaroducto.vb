Imports System.Data.SqlClient

Public Class ClsCategoriaroducto
    'variables

    Dim id As Integer
    Dim nombre, descrip As String

    'constructor
    Public Sub New()

    End Sub

    Public Property IdCategoriaProducto As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property NombreCategoriaProducto As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property DescripcionCategoriaProducto As String
        Get
            Return descrip
        End Get
        Set(value As String)
            descrip = value
        End Set
    End Property

    Public Function RegistrarCategoriaProducto() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmRegistrarCategoriaProductoOC"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre_categoria"
        sqlpar.Value = NombreCategoriaProducto
        sqlcom.Parameters.Add(sqlpar)



        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion"
        sqlpar.Value = DescripcionCategoriaProducto
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "salida"
        sqlpar.Value = ""
        sqlcom.Parameters.Add(sqlpar)

        sqlpar.Direction = ParameterDirection.Output

        Dim con As New ClsConnection
        sqlcom.Connection = con.getConexion

        sqlcom.ExecuteNonQuery()

        con.cerrarConexion()

        par_sal = sqlcom.Parameters("salida").Value

        Return par_sal

    End Function

End Class
