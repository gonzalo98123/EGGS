Imports System.Data
Imports System.Data.SqlClient
Public Class clsUsers
    'propiedades de la tabla
    Private _IdUsuario As Int16
    Private _Usuario As String
    Private _Contraseña As String

    Dim dt As DataTable
    Dim da As SqlDataAdapter
    Public Function devuelveUsuarios()
        connect()
        dt = New DataTable
        da = New SqlDataAdapter

        comm = New SqlCommand("sp_DevuelveUsuarios", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.Connection = conn

        da = New SqlDataAdapter(comm.CommandText, conn)
        da.Fill(dt)

        disconnect()

        Return dt

    End Function



End Class
