﻿Imports System.Data.SqlClient

Public Class ClsMedico

    Dim codigo, codigo_especialidad, codigo_especialidad2 As Integer
    Dim nombre_completo, correo, correo2, telefono, celular As String
    'Constructor
    Public Sub New()

    End Sub


    Public Property Codigo1 As Integer
        Get
            Return codigo
        End Get
        Set(value As Integer)
            codigo = value
        End Set
    End Property

    Public Property Codigo_especialidad1 As Integer
        Get
            Return codigo_especialidad
        End Get
        Set(value As Integer)
            codigo_especialidad = value
        End Set
    End Property
    Public Property codigo_especialidad2_ As Integer
        Get
            Return codigo_especialidad2
        End Get
        Set(value As Integer)
            codigo_especialidad2 = value
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

    Public Property Correo1 As String
        Get
            Return correo
        End Get
        Set(value As String)
            correo = value
        End Set
    End Property

    Public Property Telefono1 As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property

    Public Property Celular1 As String
        Get
            Return celular
        End Get
        Set(value As String)
            celular = value
        End Set
    End Property

    Public Property Correo21 As String
        Get
            Return correo2
        End Get
        Set(value As String)
            correo2 = value
        End Set
    End Property

    Public Function RegistrarNuevoMedico() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmInsertarMedico"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigo_especialidad" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Codigo_especialidad1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre_completo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Nombre_completo1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "correo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Correo1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "correo2" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Correo21
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "telefono" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Telefono1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "celular" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Celular1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigo_especialidad2" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigo_especialidad2_
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

    Public Function ModificarMedico() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmModificarMedico"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Codigo1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigo_especialidad" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Codigo_especialidad1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre_completo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Nombre_completo1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "correo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Correo1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "correo2" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Correo21
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "telefono" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Telefono1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "celular" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Celular1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigo_especialidad2" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigo_especialidad2_
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


    Public Function BuscarMedicoEspecialidad() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarMedicoEspecialidad"
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Nombre_completo1
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
    Public Function BuscarMedico() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarMedico"
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Nombre_completo1
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

    Public Function SeleccionarMedico() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("M_slmSeleccionarMedico", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function

    Public Function BuscarMedicoCode() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarMedicoCode"
            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = Codigo1
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

End Class
