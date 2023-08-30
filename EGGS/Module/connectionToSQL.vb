Imports System.Data
Imports System.Data.SqlClient
Module connectionToSQL

    Public conn As SqlConnection = New SqlConnection("Data Source=USUARIO-2CPT3FU\EGSSERVER;Initial Catalog=EGGS1;Persist Security Info=True;User ID=sa;Password=egs140498;")
    Public comm As New SqlCommand
    Public state As String




    'Modulo para generar la conexion con SQL.

    'Creo funcion para verificar la conexion a la base de datos. (Devuelve true o false)
    Function verifyConnection()
        Try

            conn.Open()
            Return True
        Catch ex As Exception
            Return False
        Finally
            conn.Close()
        End Try

    End Function

    Public Sub connect()
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Error al conectar")
        End Try
    End Sub

    'Funcion para cerrar conexion
    Public Sub disconnect()
        conn.Close()
    End Sub
End Module
