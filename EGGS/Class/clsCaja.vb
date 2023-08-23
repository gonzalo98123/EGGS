Imports System.Data.SqlClient
Public Class clsCaja
    Private ID_CAJA As Integer
    Private ID_USUARIO As Integer
    Private ID_COMPROBANTE As Integer
    Private ES_APERTURA As Boolean
    Private FECHA_APERTURA As DateTime
    Private MONTO_APERTURA As Double
    Private ES_CIERRE As Boolean
    Private FECHA_CIERRE As DateTime
    Private MONTO_CIERRE As Double
    Private TOTAL_DISPONIBLE As Double

    Public Property idCaja As Integer
        Get
            Return ID_CAJA
        End Get
        Set(value As Integer)
            ID_CAJA = value
        End Set
    End Property

    Public Property idUsuario As Integer
        Get
            Return ID_USUARIO
        End Get
        Set(value As Integer)
            ID_USUARIO = value
        End Set
    End Property

    Public Property idComprobante As Integer
        Get
            Return ID_COMPROBANTE
        End Get
        Set(value As Integer)
            ID_COMPROBANTE = value
        End Set
    End Property

    Public Property esApertura As Boolean
        Get
            Return ES_APERTURA
        End Get
        Set(value As Boolean)
            ES_APERTURA = value
        End Set
    End Property

    Public Property fechaApertura As Date
        Get
            Return FECHA_APERTURA
        End Get
        Set(value As Date)
            FECHA_APERTURA = value
        End Set
    End Property

    Public Property montoApertura As Double
        Get
            Return MONTO_APERTURA
        End Get
        Set(value As Double)
            MONTO_APERTURA = value
        End Set
    End Property

    Public Property esCierre As Boolean
        Get
            Return ES_CIERRE
        End Get
        Set(value As Boolean)
            ES_CIERRE = value
        End Set
    End Property

    Public Property fechaCierre As Date
        Get
            Return FECHA_CIERRE
        End Get
        Set(value As Date)
            FECHA_CIERRE = value
        End Set
    End Property

    Public Property montoCierre As Double
        Get
            Return MONTO_CIERRE
        End Get
        Set(value As Double)
            MONTO_CIERRE = value
        End Set
    End Property

    Public Property totalDisponible As Double
        Get
            Return TOTAL_DISPONIBLE
        End Get
        Set(value As Double)
            TOTAL_DISPONIBLE = value
        End Set
    End Property

    Public Sub cierreCaja()
        Try
            connect()
            'ingresamos el metodo con los parametros correspondientes
            comm = New SqlCommand("sp_CierreCaja", conn)
            comm.CommandType = CommandType.StoredProcedure
            'ejecuta
            comm.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try
    End Sub
End Class






