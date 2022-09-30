Imports System.Data
Imports System.Data.SqlClient
Public Class clsVendedor

    'propiedades de la tabla
    Private ID_VENDEDOR As Integer
    Private NOMBRE_APELLIDO As String
    Private _TELEFONO As String
    Private _MAIL As String
    Private _OBSERVACIONES As String
    Private modo As Integer

    Dim dt As DataTable
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader
    Public Property idVendedor As Integer
        Get
            Return ID_VENDEDOR
        End Get

        Set(value As Integer)
            ID_VENDEDOR = value
        End Set
    End Property

    Public Property nombreApellido As String
        Get
            Return NOMBRE_APELLIDO
        End Get

        Set(value As String)
            NOMBRE_APELLIDO = value
        End Set
    End Property

    Public Property telefono As String
        Get
            Return _TELEFONO
        End Get

        Set(value As String)
            _TELEFONO = value
        End Set
    End Property
    Public Property mail As String
        Get
            Return _MAIL
        End Get

        Set(value As String)
            _MAIL = value
        End Set
    End Property
    Public Property observaciones As String
        Get
            Return _OBSERVACIONES
        End Get

        Set(value As String)
            _OBSERVACIONES = value
        End Set
    End Property

    Public Function devuelveVendedores()

        Try
            connect()
            modo = 1
            dt = New DataTable

            'ingresamos el metodo con los parametros correspondientes
            comm = New SqlCommand("sp_DevuelveVendedores", conn)
            comm.CommandType = CommandType.StoredProcedure
            'Parametros para el stored procedure
            comm.Parameters.AddWithValue("@Modo", modo)
            comm.Parameters.AddWithValue("@IdVendedor", 0)
            'ejecuta
            da = New SqlDataAdapter(comm)
            da.Fill(dt)

            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try

    End Function

    Public Function devuelveVendedoresPorId()

        Try
            connect()
            modo = 2
            dt = New DataTable

            'ingresamos el metodo con los parametros correspondientes
            comm = New SqlCommand("sp_DevuelveVendedores", conn)
            comm.CommandType = CommandType.StoredProcedure
            'Parametros para el stored procedure
            comm.Parameters.AddWithValue("@Modo", modo)
            comm.Parameters.AddWithValue("@IdVendedor", ID_VENDEDOR)
            'ejecuta
            da = New SqlDataAdapter(comm)
            da.Fill(dt)

            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try

    End Function

    Public Sub agregaVendedor()
        Try
            connect()
            'ingresamos el metodo con los parametros correspondientes
            comm = New SqlCommand("sp_AgregaVendedor", conn)
            comm.CommandType = CommandType.StoredProcedure
            'Parametros para el stored procedure
            comm.Parameters.AddWithValue("@NombreApellido", NOMBRE_APELLIDO)
            comm.Parameters.AddWithValue("@Telefono", _TELEFONO)
            comm.Parameters.AddWithValue("@Mail", _MAIL)
            comm.Parameters.AddWithValue("@Observaciones", _OBSERVACIONES)
            'ejecuta
            comm.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try
    End Sub
    Public Sub modificaVendedor()
        Try
            connect()
            'ingresamos el metodo con los parametros correspondientes
            comm = New SqlCommand("sp_ModificaVendedor", conn)
            comm.CommandType = CommandType.StoredProcedure
            'Parametros para el stored procedure
            comm.Parameters.AddWithValue("@IdVendedor", ID_VENDEDOR)
            comm.Parameters.AddWithValue("@NombreApellido", NOMBRE_APELLIDO)
            comm.Parameters.AddWithValue("@Telefono", _TELEFONO)
            comm.Parameters.AddWithValue("@Mail", _MAIL)
            comm.Parameters.AddWithValue("@Observaciones", _OBSERVACIONES)
            'ejecuta
            comm.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try
    End Sub
    Public Sub eliminaVendedor()
        Try
            connect()
            'ingresamos el metodo con los parametros correspondientes
            comm = New SqlCommand("sp_EliminaVendedor", conn)
            comm.CommandType = CommandType.StoredProcedure
            'Parametros para el stored procedure
            comm.Parameters.AddWithValue("@IdVendedor", ID_VENDEDOR)
            'ejecuta
            comm.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try
    End Sub

End Class
