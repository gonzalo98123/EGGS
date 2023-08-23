Imports System.Data.SqlClient

Public Class clsHuevo

    Dim dt As DataTable
    Dim da As SqlDataAdapter

    Private ID_MOVIMIENTO_HUEVOS As Integer
    Private FECHA_CARGA As Date
    Private CANTIDAD_HUEVOS As Integer
    Private ID_VENDEDOR As Integer
    Private ID_CLIENTE As Integer
    Private _TOTAL As Decimal
    Private _PAGADO As Boolean
    Private _OBSERVACIONES As String

    Public Property idMovimientoHuevos As Integer
        Get
            Return ID_MOVIMIENTO_HUEVOS
        End Get

        Set(value As Integer)
            ID_MOVIMIENTO_HUEVOS = value
        End Set
    End Property

    Public Property fechaCarga As Date
        Get
            Return FECHA_CARGA
        End Get

        Set(value As Date)
            FECHA_CARGA = value
        End Set
    End Property

    Public Property cantidadHuevos As Integer
        Get
            Return CANTIDAD_HUEVOS
        End Get
        Set(value As Integer)
            CANTIDAD_HUEVOS = value
        End Set
    End Property
    Public Property idvendedor As Integer
        Get
            Return ID_VENDEDOR
        End Get
        Set(value As Integer)
            ID_VENDEDOR = value
        End Set
    End Property
    Public Property idcliente As Integer
        Get
            Return ID_CLIENTE
        End Get
        Set(value As Integer)
            ID_CLIENTE = value
        End Set
    End Property
    Public Property pagado As Boolean
        Get
            Return _PAGADO
        End Get
        Set(value As Boolean)
            _PAGADO = value
        End Set
    End Property

    Public Property total As Decimal
        Get
            Return _TOTAL
        End Get
        Set(value As Decimal)
            _TOTAL = value
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



    Public Function devuelveStockHuevos()
        connect()
        dt = New DataTable
        da = New SqlDataAdapter

        comm = New SqlCommand("sp_DevuelveStockHuevos", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.Connection = conn

        da = New SqlDataAdapter(comm.CommandText, conn)
        da.Fill(dt)

        disconnect()
        Return dt

    End Function

    Public Sub ingresaHuevos()

        connect()
        comm = New SqlCommand("sp_MovimientosHuevos", conn)
        comm.CommandType = CommandType.StoredProcedure
        'Parametros para el stored procedure
        comm.Parameters.AddWithValue("@FechaMovimiento", FECHA_CARGA)
        comm.Parameters.AddWithValue("@Cantidad", CANTIDAD_HUEVOS)
        comm.Parameters.AddWithValue("@EsEgreso", 0) 'seteo a 0 ya que es ingreso.
        comm.Parameters.AddWithValue("@IdVendedor", 0)
        comm.Parameters.AddWithValue("@IdCliente", 0)
        comm.Parameters.AddWithValue("@Pagado", 0)
        comm.Parameters.AddWithValue("@Observacion", 0)
        comm.Parameters.AddWithValue("@PrecioVenta", 0)


        comm.ExecuteNonQuery()

        disconnect()

    End Sub

    Public Sub egresoHuevos()
        Try
            connect()
            'ingresamos el metodo con los parametros correspondientes
            comm = New SqlCommand("sp_MovimientosHuevos", conn)
            comm.CommandType = CommandType.StoredProcedure
            'Parametros para el stored procedure
            comm.Parameters.AddWithValue("@FechaMovimiento", FECHA_CARGA)
            comm.Parameters.AddWithValue("@Cantidad", CANTIDAD_HUEVOS)
            comm.Parameters.AddWithValue("@EsEgreso", 1) ' Pasamos 1 ya que es egreso (true)
            comm.Parameters.AddWithValue("@IdVendedor", ID_VENDEDOR)
            comm.Parameters.AddWithValue("@IdCliente", ID_CLIENTE)
            comm.Parameters.AddWithValue("@Pagado", _PAGADO)
            comm.Parameters.AddWithValue("@Observacion", _OBSERVACIONES)
            comm.Parameters.AddWithValue("@PrecioVenta", _TOTAL)

            'ejecuta
            comm.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try
    End Sub


    Public Sub marcarPagoComprobante()
        Try
            connect()
            'ingresamos el metodo con los parametros correspondientes
            comm = New SqlCommand("sp_MarcarPagoComprobante", conn)
            comm.CommandType = CommandType.StoredProcedure
            'Parametros para el stored procedure
            comm.Parameters.AddWithValue("@Id", ID_MOVIMIENTO_HUEVOS)


            'ejecuta
            comm.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try
    End Sub

    Public Function devuelveNoPagoPorId()
        connect()
        dt = New DataTable
        da = New SqlDataAdapter

        comm = New SqlCommand("sp_DevuelveMovimientoNoPagoPorID", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@Id", ID_MOVIMIENTO_HUEVOS)

        da = New SqlDataAdapter(comm.CommandText, conn)
        da.Fill(dt)

        disconnect()
        Return dt

    End Function
End Class
