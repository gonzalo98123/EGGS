Imports System.Data.SqlClient
Public Class clsGallinas

    Dim dt As DataTable
    Dim da As SqlDataAdapter

    Private FECHA_CARGA As Date
    Private CANTIDAD_GALLINAS_MUERTAS As Integer

    Public Property fechaCarga As Date
        Get
            Return FECHA_CARGA
        End Get

        Set(value As Date)
            FECHA_CARGA = value
        End Set
    End Property

    Public Property cantidadGallinasMuertas As Integer
        Get
            Return CANTIDAD_GALLINAS_MUERTAS
        End Get
        Set(value As Integer)
            CANTIDAD_GALLINAS_MUERTAS = value
        End Set
    End Property

    Public Function devuelveRegistroGallinas()
        connect()
        dt = New DataTable
        da = New SqlDataAdapter

        comm = New SqlCommand("sp_DevuelveRegistroGallinas", conn)
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
            comm = New SqlCommand("sp_IngresoGallinasMuertas", conn)
            comm.CommandType = CommandType.StoredProcedure
            'Parametros para el stored procedure
            comm.Parameters.AddWithValue("@FechaCarga", FECHA_CARGA)
            comm.Parameters.AddWithValue("@IngresoGallinasMuertas", CANTIDAD_GALLINAS_MUERTAS)
            'ejecuta
            comm.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnect()
        End Try
    End Sub

End Class
