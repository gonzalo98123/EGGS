Imports System.Data
Imports System.Data.SqlClient
Public Class clsUser
    'propiedades de la tabla
    Private _IdUsuario As Int16
    Private _Usuario As String
    Private _Contraseña As String

    Dim dt As DataTable
    Dim da As SqlDataAdapter
    Dim modo As Integer
    Public Function devuelveUsuarios()

        Try
            connect()
            modo = 1
            dt = New DataTable

            'ingresamos el metodo con los parametros correspondientes
            comm = New SqlCommand("sp_DevuelveUsuarios", conn)
            comm.CommandType = CommandType.StoredProcedure
            'Parametros para el stored procedure
            comm.Parameters.AddWithValue("@Modo", 1)
            comm.Parameters.AddWithValue("@IdUsuario", 0)
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
