

Imports System.Data.SqlClient
Public Class ClsTomaDeMuestras

    Dim codMuestra, codExamen As Integer
    Dim descripcion As String

    'Constructor
    Public Sub New()

    End Sub

    Public Property codMuestra_ As Integer
        Get
            Return codMuestra
        End Get
        Set(value As Integer)
            codMuestra = value
        End Set
    End Property

    Public Property codExamen_ As Integer
        Get
            Return codExamen
        End Get
        Set(value As Integer)
            codExamen = value
        End Set
    End Property

    Public Property Descripcion_ As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property



    Public Function registrarNuevo() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmInsertarTomaDeMuestras"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codExamen" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codExamen_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Descripcion_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "ID"
        sqlpar.Value = ""
        sqlcom.Parameters.Add(sqlpar)

        sqlpar.Direction = ParameterDirection.Output

        Dim con As New ClsConnection
        sqlcom.Connection = con.getConexion

        sqlcom.ExecuteNonQuery()

        con.cerrarConexion()

        par_sal = sqlcom.Parameters("ID").Value

        Return par_sal

    End Function







    Public Function modificarRegistro() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmActualizarTomaDeMuestras"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codMuestra" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codMuestra_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codExamen" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codExamen_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Descripcion_
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
