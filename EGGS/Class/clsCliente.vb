Imports System.Data.SqlClient

Public Class clsCliente
    Private ID_CLIENTE As Integer
    Private RAZON_SOCIAL As String
    Private _TELEFONO As String
    Private _MAIL As String
    Private _DIRECCION As String
    Private _OBSERVACIONES As String

    Dim dt As DataTable
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim modo As Integer
    Public Property idcliente As Integer
        Get
            Return ID_CLIENTE
        End Get

        Set(value As Integer)
            ID_CLIENTE = value
        End Set
    End Property

    Public Property razonsocial As String
        Get
            Return RAZON_SOCIAL
        End Get

        Set(value As String)
            RAZON_SOCIAL = value
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
    Public Property direccion As String
        Get
            Return _OBSERVACIONES
        End Get

        Set(value As String)
            _OBSERVACIONES = value
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
    Public Function devuelveClientes()
        Try
            connect()

            dt = New DataTable
            modo = 1
            'ingresamos el metodo con los parametros correspondientes
            comm = New SqlCommand("sp_DevuelveClientes", conn)
            comm.CommandType = CommandType.StoredProcedure
            'Parametros para el stored procedure
            comm.Parameters.AddWithValue("@Modo", modo)
            comm.Parameters.AddWithValue("@IdCliente", ID_CLIENTE)
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

    Public Sub agregaCliente()
        Try
            connect()
            'ingresamos el metodo con los parametros correspondientes
            comm = New SqlCommand("sp_AgregaCliente", conn)
            comm.CommandType = CommandType.StoredProcedure
            'Parametros para el stored procedure
            comm.Parameters.AddWithValue("@RazonSocial", RAZON_SOCIAL)
            comm.Parameters.AddWithValue("@Telefono", _TELEFONO)
            comm.Parameters.AddWithValue("@Mail", _MAIL)
            comm.Parameters.AddWithValue("@Direccion", _MAIL)
            comm.Parameters.AddWithValue("@Observaciones", _OBSERVACIONES)
            'ejecuta
            comm.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try
    End Sub
    Public Sub eliminaCliente()
        Try
            connect()
            'ingresamos el metodo con los parametros correspondientes
            comm = New SqlCommand("sp_EliminaCliente", conn)
            comm.CommandType = CommandType.StoredProcedure
            'Parametros para el stored procedure
            comm.Parameters.AddWithValue("@IdCliente", ID_CLIENTE)
            'ejecuta
            comm.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try
    End Sub
    Public Function devuelveClientePorId()

        Try
            connect()

            dt = New DataTable
            modo = 2

            'ingresamos el metodo con los parametros correspondientes
            comm = New SqlCommand("sp_DevuelveClientes", conn)
            comm.CommandType = CommandType.StoredProcedure
            'Parametros para el stored procedure
            comm.Parameters.AddWithValue("@Modo", modo)
            comm.Parameters.AddWithValue("@IdCliente", ID_CLIENTE)
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

    Public Sub modificaCliente()
        Try
            connect()
            'ingresamos el metodo con los parametros correspondientes
            comm = New SqlCommand("sp_ModificaCliente", conn)
            comm.CommandType = CommandType.StoredProcedure
            'Parametros para el stored procedure
            comm.Parameters.AddWithValue("@IdCliente", ID_CLIENTE)
            comm.Parameters.AddWithValue("@RazonSocial", RAZON_SOCIAL)
            comm.Parameters.AddWithValue("@Telefono", _TELEFONO)
            comm.Parameters.AddWithValue("@Mail", _MAIL)
            comm.Parameters.AddWithValue("@Direccion", _MAIL)
            comm.Parameters.AddWithValue("@Observaciones", _OBSERVACIONES)
            'ejecuta
            comm.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try
    End Sub
End Class
