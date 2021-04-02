Imports System.Data.SqlClient

Public Class ClsCuentasAlmacen
    Dim nombre, cuenta As String
    Dim cuenta_id As Integer
    Public Sub New()

    End Sub

    Public Property Nombre1 As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property Cuenta1 As String
        Get
            Return cuenta
        End Get
        Set(value As String)
            cuenta = value
        End Set
    End Property

    Public Property Cuenta_id1 As Integer
        Get
            Return cuenta_id
        End Get
        Set(value As Integer)
            cuenta_id = value
        End Set
    End Property

    Public Function RegistrarCuentaPrincipal() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmRegistrarCuentaAlmacen"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Nombre1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cuenta" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Cuenta1
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


    Public Function RegistrarCuentaSecundaria() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmRegistrarCuentaAlmacen2"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Nombre1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cuenta" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Cuenta1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cuenta_id" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Cuenta_id1
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
