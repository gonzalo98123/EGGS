Imports System.Data.SqlClient
Public Class clsComprobanteAvicola
    Private ID_COMPROBANTE As Integer
    Private FECHA_COMPROBANTE As Date
    Private _COMPROBANTE As String
    Private ID_TIPO_COMPROBANTE As Integer
    Private ID_TIPO_GASTO As Integer
    Private _OBSERVACIONES As String
    Private _TOTAL As Double
    Private ES_EGRESO As Boolean

    Dim dt As DataTable
    Dim da As SqlDataAdapter

    Public Property idComprobante As Integer
        Get
            Return ID_COMPROBANTE
        End Get
        Set(value As Integer)
            ID_COMPROBANTE = value
        End Set
    End Property

    Public Property fechaComprobante As Date
        Get
            Return FECHA_COMPROBANTE
        End Get
        Set(value As Date)
            FECHA_COMPROBANTE = value
        End Set
    End Property

    Public Property idTipoComprobante As Integer
        Get
            Return ID_TIPO_COMPROBANTE
        End Get
        Set(value As Integer)
            ID_TIPO_COMPROBANTE = value
        End Set
    End Property

    Public Property idTipoGasto As Integer
        Get
            Return ID_TIPO_GASTO
        End Get
        Set(value As Integer)
            ID_TIPO_GASTO = value
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

    Public Property total As Decimal
        Get
            Return _TOTAL
        End Get
        Set(value As Decimal)
            _TOTAL = value
        End Set
    End Property

    Public Property comprobante As String
        Get
            Return _COMPROBANTE
        End Get
        Set(value As String)
            _COMPROBANTE = value
        End Set
    End Property

    Public Property esEgreso As Boolean
        Get
            Return ES_EGRESO
        End Get
        Set(value As Boolean)
            ES_EGRESO = value
        End Set
    End Property

    Public Sub ingresarComprobante()
        Try
            connect()
            'ingresamos el metodo con los parametros correspondientes
            comm = New SqlCommand("sp_IngresarComprobante", conn)
            comm.CommandType = CommandType.StoredProcedure
            'Parametros para el stored procedure
            comm.Parameters.AddWithValue("@FechaComprobante", FECHA_COMPROBANTE)
            comm.Parameters.AddWithValue("@IdTipoComprobante", ID_TIPO_COMPROBANTE)
            comm.Parameters.AddWithValue("@Comprobante", _COMPROBANTE)
            comm.Parameters.AddWithValue("@IdTipoGasto", ID_TIPO_GASTO)
            comm.Parameters.AddWithValue("@Observaciones", _OBSERVACIONES)
            comm.Parameters.AddWithValue("@total", _TOTAL)
            comm.Parameters.AddWithValue("@EsEgreso", ES_EGRESO)
            'ejecuta
            comm.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try
    End Sub


    Public Function devuelveNoPagos()
        connect()
        dt = New DataTable
        da = New SqlDataAdapter

        comm = New SqlCommand("vw_ComprobantesCaja", conn)
        comm.CommandType = CommandType.StoredProcedure

        da = New SqlDataAdapter(comm.CommandText, conn)
        da.Fill(dt)

        disconnect()
        Return dt

    End Function




End Class
