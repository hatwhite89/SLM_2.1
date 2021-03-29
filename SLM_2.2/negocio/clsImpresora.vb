Imports System.Data.SqlClient

Public Class clsImpresora
    Private objCon As New ClsConnection
    Dim aliasprint, nombre, sucursal As String
    Dim id As Integer
    Public Sub New()

    End Sub

    Public Sub Finalize()
        Me.Finalize()
    End Sub

    Public Property Aliasprint1 As String
        Get
            Return aliasprint
        End Get
        Set(value As String)
            aliasprint = value
        End Set
    End Property

    Public Property Nombre1 As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property Sucursal1 As String
        Get
            Return sucursal
        End Get
        Set(value As String)
            sucursal = value
        End Set
    End Property

    Public Property Id1 As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Function RecuperarImpresoras() As DataTable



        Using cmd As New SqlCommand
            cmd.Connection = objCon.getConexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select i.id,i.alias,i.nombre,s.nombre as sucursal from impresoras i, sucursal s where s.codigo =i.sucursal"
            objCon.cerrarConexion()
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    objCon.cerrarConexion()
                    Return dt
                End Using
                objCon.cerrarConexion()
            End Using
            objCon.cerrarConexion()
        End Using
        objCon.cerrarConexion()
    End Function
    Public Function RecuperarSucursal() As DataTable

        Dim con As New ClsConnection



        Using sqlcom As New SqlCommand
            sqlcom.Connection = con.getConexion()
            sqlcom.CommandType = CommandType.Text
            sqlcom.CommandText = "select * from sucursal"
            sqlcom.ExecuteNonQuery()


            Using da As New SqlDataAdapter
                da.SelectCommand = sqlcom
                Using dt As New DataTable
                    da.Fill(dt)

                    Return dt
                End Using

            End Using


        End Using


    End Function
    Public Function RegistrarImpresora() As String

        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmRegistrarImpresora"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "alias" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Aliasprint1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Nombre1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "sucursal" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Sucursal1
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

    Public Function EliminarImpresora() As String

        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmEliminarImpresora"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Id1
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
