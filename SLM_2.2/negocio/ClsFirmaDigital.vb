Imports System.Data.SqlClient

Public Class ClsFirmaDigital
    Dim nombre_usuario, puesto, abreviatura, nombre_completo As String
    Dim cod_usuario As Integer
    Dim imagen As Byte()
    Public Sub New()

    End Sub

    Public Property Cod_usuario1 As Integer
        Get
            Return cod_usuario
        End Get
        Set(value As Integer)
            cod_usuario = value
        End Set
    End Property

    Public Property Imagen1 As Byte()
        Get
            Return imagen
        End Get
        Set(value As Byte())
            imagen = value
        End Set
    End Property

    Public Property Nombre_usuario1 As String
        Get
            Return nombre_usuario
        End Get
        Set(value As String)
            nombre_usuario = value
        End Set
    End Property

    Public Property Puesto1 As String
        Get
            Return puesto
        End Get
        Set(value As String)
            puesto = value
        End Set
    End Property

    Public Property Abreviatura1 As String
        Get
            Return abreviatura
        End Get
        Set(value As String)
            abreviatura = value
        End Set
    End Property

    Public Property Nombre_completo1 As String
        Get
            Return nombre_completo
        End Get
        Set(value As String)
            nombre_completo = value
        End Set
    End Property

    Public Function RegistrarFirma() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmInsertarFirma"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cod_usuario" 'nombre del almacen 
        sqlpar.Value = Cod_usuario1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre_usuario" 'nombre del almacen 
        sqlpar.Value = Nombre_usuario1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre_completo" 'nombre del almacen 
        sqlpar.Value = Nombre_completo1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "puesto" 'descripcion del almacen
        sqlpar.Value = Puesto1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "abreviatura" 'descripcion del almacen
        sqlpar.Value = Abreviatura1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "imagen" 'descripcion del almacen
        sqlpar.Value = Imagen1
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
    Public Function RecuperarFirmasDigitales() As SqlDataReader
        Dim sqlcom As SqlCommand
        sqlcom = New SqlCommand
        sqlcom.CommandText = "SELECT* from firmadigital"
        sqlcom.Connection = New ClsConnection().getConexion
        Return sqlcom.ExecuteReader
    End Function

    Public Function ActualizarFirma() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmActualizarFirma"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cod_usuario" 'nombre del almacen 
        sqlpar.Value = Cod_usuario1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre_usuario" 'nombre del almacen 
        sqlpar.Value = Nombre_usuario1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre_completo" 'nombre del almacen 
        sqlpar.Value = Nombre_completo1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "puesto" 'descripcion del almacen
        sqlpar.Value = Puesto1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "abreviatura" 'descripcion del almacen
        sqlpar.Value = Abreviatura1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "imagen" 'descripcion del almacen
        sqlpar.Value = Imagen1
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


    Public Function EliminarFirma() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmEliminarFirma"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cod_usuario" 'nombre del almacen 
        sqlpar.Value = Cod_usuario1
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
