Imports System.Data.SqlClient

Public Class clsTipoComprobante
    Private ID_TIPOCOMPROBANTE As Integer
    Private TIPO_COMPROBANTE As String
    Private _DETALLE As String

    Dim dt As DataTable
    Dim da As SqlDataAdapter

    Public Property idTipoComprobante As Integer
        Get
            Return ID_TIPOCOMPROBANTE
        End Get
        Set(value As Integer)
            ID_TIPOCOMPROBANTE = value
        End Set
    End Property

    Public Property tipoComprobante As String
        Get
            Return TIPO_COMPROBANTE
        End Get
        Set(value As String)
            TIPO_COMPROBANTE = value
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

    Public Function devuelveTiposComprobantes()
        Try
            connect()

            dt = New DataTable


            'ingresamos el metodo con los parametros correspondientes
            comm = New SqlCommand("sp_DevuelveTiposComprobantes", conn)
            comm.CommandType = CommandType.StoredProcedure
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

End Class
