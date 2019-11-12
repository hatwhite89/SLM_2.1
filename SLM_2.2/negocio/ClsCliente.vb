Imports System.Data.SqlClient
Public Class ClsCliente

    Dim codigo, codigoClasificacion As Integer
    Dim nombre1, nombre2, apellido1, apellido2, nombreCompleto, scanId, identidad, rtn, genero, direccion, telCasa, telTrabajo, celular, correo1, correo2 As String
    Dim fechaNacimiento As Date
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

    Public Property CodigoClasificacion1 As Integer
        Get
            Return codigoClasificacion
        End Get
        Set(value As Integer)
            codigoClasificacion = value
        End Set
    End Property

    Public Property ScanId1 As String
        Get
            Return scanId
        End Get
        Set(value As String)
            scanId = value
        End Set
    End Property

    Public Property Rtn1 As String
        Get
            Return rtn
        End Get
        Set(value As String)
            rtn = value
        End Set
    End Property

    Public Property Identidad1 As String
        Get
            Return identidad
        End Get
        Set(value As String)
            identidad = value
        End Set
    End Property

    Public Property Nombre_1 As String
        Get
            Return nombre1
        End Get
        Set(value As String)
            nombre1 = value
        End Set
    End Property

    Public Property Nombre_2 As String
        Get
            Return nombre2
        End Get
        Set(value As String)
            nombre2 = value
        End Set
    End Property

    Public Property Apellido_1 As String
        Get
            Return apellido1
        End Get
        Set(value As String)
            apellido1 = value
        End Set
    End Property

    Public Property Apellido_2 As String
        Get
            Return apellido2
        End Get
        Set(value As String)
            apellido2 = value
        End Set
    End Property

    Public Property NombreCompleto1 As String
        Get
            Return nombreCompleto
        End Get
        Set(value As String)
            nombreCompleto = value
        End Set
    End Property

    Public Property Genero1 As String
        Get
            Return genero
        End Get
        Set(value As String)
            genero = value
        End Set
    End Property

    Public Property Direccion1 As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property

    Public Property TelCasa1 As String
        Get
            Return telCasa
        End Get
        Set(value As String)
            telCasa = value
        End Set
    End Property

    Public Property TelTrabajo1 As String
        Get
            Return telTrabajo
        End Get
        Set(value As String)
            telTrabajo = value
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

    Public Property Correo_1 As String
        Get
            Return correo1
        End Get
        Set(value As String)
            correo1 = value
        End Set
    End Property

    Public Property Correo_2 As String
        Get
            Return correo2
        End Get
        Set(value As String)
            correo2 = value
        End Set
    End Property

    Public Property FechaNacimiento1 As Date
        Get
            Return fechaNacimiento
        End Get
        Set(value As Date)
            fechaNacimiento = value
        End Set
    End Property

    Public Function RegistrarNuevoCliente() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "slmInsertarCliente"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "scanId" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = ScanId1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "identidad" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Identidad1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "rtn" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Rtn1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre1" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Nombre_1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre2" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Nombre_2
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "apellido1" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Apellido_1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "apellido2" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Apellido_2
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombreCompleto" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = NombreCompleto1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaNacimiento" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = FechaNacimiento1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "genero" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Genero1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "direccion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Direccion1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "telCasa" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = TelCasa1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "telTrabajo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = TelTrabajo1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "celular" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Celular1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "correo1" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Correo_1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "correo2" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Correo_2
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoClasificacion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = CodigoClasificacion1
        sqlcom.Parameters.Add(sqlpar)


        sqlpar = New SqlParameter
        sqlpar.ParameterName = "salida"
        sqlpar.Value = ""
        sqlcom.Parameters.Add(sqlpar)

        sqlpar.Direction = ParameterDirection.Output

        Dim con As New ClsConnection
        sqlcom.Connection = con.getConexion

        sqlcom.ExecuteNonQuery()

        par_sal = sqlcom.Parameters("salida").Value

        Return par_sal

    End Function

    Public Function ModificarCliente() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "slmModificarCliente"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Codigo1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "scanId" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = ScanId1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "identidad" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Identidad1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "rtn" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Rtn1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre1" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Nombre_1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre2" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Nombre_2
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "apellido1" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Apellido_1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "apellido2" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Apellido_2
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombreCompleto" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = NombreCompleto1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaNacimiento" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = FechaNacimiento1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "genero" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Genero1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "direccion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Direccion1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "telCasa" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = TelCasa1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "telTrabajo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = TelTrabajo1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "celular" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Celular1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "correo1" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Correo_1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "correo2" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Correo_2
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoClasificacion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = CodigoClasificacion1
        sqlcom.Parameters.Add(sqlpar)



        sqlpar = New SqlParameter
        sqlpar.ParameterName = "salida"
        sqlpar.Value = ""
        sqlcom.Parameters.Add(sqlpar)

        sqlpar.Direction = ParameterDirection.Output

        Dim con As New ClsConnection
        sqlcom.Connection = con.getConexion

        sqlcom.ExecuteNonQuery()

        par_sal = sqlcom.Parameters("salida").Value

        Return par_sal

    End Function


    Public Function BuscarCliente() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "slmBuscarClienteId"
            cmd.Parameters.Add("@identidad", SqlDbType.VarChar).Value = Identidad1
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using

    End Function


End Class
