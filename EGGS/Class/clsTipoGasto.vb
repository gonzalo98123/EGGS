Imports System.Data.SqlClient
Public Class clsTipoGasto
    Private ID_TIPO_GASTO As Integer
    Private TIPO_GASTO As String
    Private _DETALLE As String
    Dim dt As DataTable
    Dim da As SqlDataAdapter

    Public Property idTipoGasto As Integer
        Get
            Return ID_TIPO_GASTO
        End Get
        Set(value As Integer)
            ID_TIPO_GASTO = value
        End Set
    End Property

    Public Property tipoGasto As String
        Get
            Return TIPO_GASTO
        End Get
        Set(value As String)
            TIPO_GASTO = value
        End Set
    End Property

    Public Property detalle As String
        Get
            Return _DETALLE
        End Get
        Set(value As String)
            _DETALLE = value
        End Set
    End Property

    Public Function devuelveTiposGastos()

        Try
            connect()
            dt = New DataTable

            'ingresamos el metodo con los parametros correspondientes
            comm = New SqlCommand("sp_DevuelveTiposGastos", conn)
            comm.CommandType = CommandType.StoredProcedure
            'Parametros para el stored procedure
            comm.Parameters.AddWithValue("@Modo", 1)
            comm.Parameters.AddWithValue("@IdTipoGasto", 0)
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

    Public Function devuelveTiposGastosPorId()

        Try
            connect()
            dt = New DataTable

            'ingresamos el metodo con los parametros correspondientes
            comm = New SqlCommand("sp_DevuelveTiposGastos", conn)
            comm.CommandType = CommandType.StoredProcedure
            'Parametros para el stored procedure
            comm.Parameters.AddWithValue("@Modo", 2)
            comm.Parameters.AddWithValue("@IdTipoGasto", ID_TIPO_GASTO)
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

    Public Sub agregaTipoGasto()
        Try
            connect()
            'ingresamos el metodo con los parametros correspondientes
            comm = New SqlCommand("sp_AgregaTipoGasto", conn)
            comm.CommandType = CommandType.StoredProcedure
            'Parametros para el stored procedure
            comm.Parameters.AddWithValue("@TipoGasto", TIPO_GASTO)
            comm.Parameters.AddWithValue("@Detalle", _DETALLE)

            comm.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try
    End Sub
    Public Sub modificaTipoGasto()
        Try
            connect()
            'ingresamos el metodo con los parametros correspondientes
            comm = New SqlCommand("sp_ModificaTipoGasto", conn)
            comm.CommandType = CommandType.StoredProcedure
            'Parametros para el stored procedure
            comm.Parameters.AddWithValue("@IdTipoGasto", ID_TIPO_GASTO)
            comm.Parameters.AddWithValue("@TipoGasto", TIPO_GASTO)
            comm.Parameters.AddWithValue("@Detalle", _DETALLE)

            'ejecuta
            comm.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try
    End Sub
    Public Sub eliminaTipoGasto()
        Try
            connect()
            'ingresamos el metodo con los parametros correspondientes
            comm = New SqlCommand("sp_EliminaTipoGasto", conn)
            comm.CommandType = CommandType.StoredProcedure
            'Parametros para el stored procedure
            comm.Parameters.AddWithValue("@IdTipoGasto", ID_TIPO_GASTO)
            'ejecuta
            comm.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try
    End Sub


End Class
