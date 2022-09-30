Imports System.Data.SqlClient
Public Class clsGallina

    Dim dt As DataTable
    Dim da As SqlDataAdapter

    Private FECHA_CARGA As Date
    Private CANTIDAD_GALLINAS As Integer

    Public Property fechaCarga As Date
        Get
            Return FECHA_CARGA
        End Get

        Set(value As Date)
            FECHA_CARGA = value
        End Set
    End Property

    Public Property cantidadGallinas As Integer
        Get
            Return CANTIDAD_GALLINAS
        End Get
        Set(value As Integer)
            CANTIDAD_GALLINAS = value
        End Set
    End Property

    Public Function devuelveRegistroGallinas()
        connect()
        dt = New DataTable
        da = New SqlDataAdapter

        comm = New SqlCommand("sp_DevuelveStockGallinas", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.Connection = conn

        da = New SqlDataAdapter(comm.CommandText, conn)
        da.Fill(dt)

        disconnect()
        Return dt

    End Function

    Public Sub ingresoGallinasMuertas()
        Try
            connect()
            'ingresamos el metodo con los parametros correspondientes
            comm = New SqlCommand("sp_MovimientoGallinas", conn)
            comm.CommandType = CommandType.StoredProcedure
            'Parametros para el stored procedure
            comm.Parameters.AddWithValue("@FechaCarga", FECHA_CARGA)
            comm.Parameters.AddWithValue("@Cantidad", CANTIDAD_GALLINAS)
            comm.Parameters.AddWithValue("@Ingreso", 0) 'seteo a falso ya que no es ingreso
            'ejecuta
            comm.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try
    End Sub

    Public Sub ingresoGallinas()
        Try
            connect()
            'ingresamos el metodo con los parametros correspondientes
            comm = New SqlCommand("sp_MovimientoGallinas", conn)
            comm.CommandType = CommandType.StoredProcedure
            'Parametros para el stored procedure
            comm.Parameters.AddWithValue("@FechaCarga", FECHA_CARGA)
            comm.Parameters.AddWithValue("@Cantidad", CANTIDAD_GALLINAS)
            comm.Parameters.AddWithValue("@Ingreso", 1) 'seteo a true ya que es ingreso
            'ejecuta
            comm.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try
    End Sub

End Class
