Imports System.Data.SqlClient

Public Class ClsRecibo
    Dim numero, codigoFormaPago As Integer
    Dim referencia, moneda, observaciones As String
    Dim infoClte, ok As Boolean
    Dim fechaTrans As Date
    Dim depositado As Double
    'Constructor
    Public Sub New()

    End Sub
    Public Property numero_ As Integer
        Get
            Return numero
        End Get
        Set(value As Integer)
            numero = value
        End Set
    End Property
    Public Property moneda_ As String
        Get
            Return moneda
        End Get
        Set(value As String)
            moneda = value
        End Set
    End Property
    Public Property depositado_ As Double
        Get
            Return depositado
        End Get
        Set(value As Double)
            depositado = value
        End Set
    End Property
    Public Property codigoFormaPago_ As Integer
        Get
            Return codigoFormaPago
        End Get
        Set(value As Integer)
            codigoFormaPago = value
        End Set
    End Property
    Public Property observaciones_ As String
        Get
            Return observaciones
        End Get
        Set(value As String)
            observaciones = value
        End Set
    End Property
    Public Property referencia_ As String
        Get
            Return referencia
        End Get
        Set(value As String)
            referencia = value
        End Set
    End Property
    Public Property fechaTrans_ As Date
        Get
            Return fechaTrans
        End Get
        Set(value As Date)
            fechaTrans = value
        End Set
    End Property
    Public Property infoClte_ As Boolean
        Get
            Return infoClte
        End Get
        Set(value As Boolean)
            infoClte = value
        End Set
    End Property
    Public Property ok_ As Boolean
        Get
            Return ok
        End Get
        Set(value As Boolean)
            ok = value
        End Set
    End Property
    Public Function RegistrarNuevoRecibo() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmInsertarRecibo"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaTrans" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = fechaTrans_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "referencia" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = referencia_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoFormaPago" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoFormaPago_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "infoClte" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = infoClte_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "ok" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = ok_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "moneda" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = moneda_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "depositado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = depositado_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "observaciones" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = observaciones_
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

    Public Function ModificarRecibo() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmModificarRecibo"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "numero" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = numero_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaTrans" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = fechaTrans_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "referencia" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = referencia_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoFormaPago" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoFormaPago_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "infoClte" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = infoClte_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "ok" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = ok_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "moneda" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = moneda_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "depositado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = depositado_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "observaciones" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = observaciones_
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
    Public Function BuscarReciboNumImprimir() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarReciboNumImprimir"
            cmd.Parameters.Add("@numero", SqlDbType.Int).Value = numero_
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    objCon.cerrarConexion()
                    Return dt
                End Using
            End Using
        End Using
    End Function
    Public Function BuscarReciboNum() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarReciboNum"
            cmd.Parameters.Add("@numero", SqlDbType.Int).Value = numero_
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    objCon.cerrarConexion()
                    Return dt
                End Using
            End Using
        End Using
    End Function
    Public Function BuscarReciboRef() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarReciboRef"
            cmd.Parameters.Add("@referencia", SqlDbType.VarChar).Value = referencia_
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    objCon.cerrarConexion()
                    Return dt
                End Using
            End Using
        End Using
    End Function
    Public Function CapturarRecibo() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("M_slmCapturarNumeroRecibo", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function
    Public Function SeleccionarRecibo() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("M_slmSeleccionarRecibo", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function
End Class