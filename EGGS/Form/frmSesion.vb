
Imports System.Data
Public Class frmSesion

    Dim users As clsUser
    Dim dt As DataTable


    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click


        'Verificamos que los txt no esten vacios.
        If txtUser.Text = "" Then
            MsgBox("El campo usuario esta vacio.", MessageBoxButtons.OK, "Alerta")
            txtUser.Focus()
        Else
            If txtPass.Text = "" Then
                MsgBox("El campo contraseña esta vacio.", MessageBoxButtons.OK, "Alerta")
                txtPass.Focus()

            Else 'Una vez que todos los campos esten completos verificamos los datos.

                'Se trae los datos de la tabla Usuarios de la base.
                users = New clsUser
                dt = New DataTable
                dt = users.devuelveUsuarios()

                For Each row As DataRow In dt.Rows

                    If txtUser.Text = CStr(row("Usuario")) Then
                        If txtPass.Text = CStr(row("Contraseña")) Then
                            frmPrincipal.Show()
                            Me.Close()
                            Exit Sub
                        Else
                            MsgBox("Contraseña incorrecta", MessageBoxButtons.OK, "Alerta")
                            Exit Sub
                        End If
                    Else
                        MsgBox("Usuario incorrecto", MessageBoxButtons.OK, "Alerta")
                        Exit Sub
                    End If

                Next

            End If
        End If

    End Sub

    Private Sub frmSesion_Load(sender As Object, e As EventArgs) Handles Me.Load
        'En el evento load del form verificamos si esta funcionando la conexion con la base.


        CustomizeComponents()

        If verifyConnection() = True Then
            lblResult.Text = "Online"
            lblResult.ForeColor = Color.Green
        Else
            MsgBox("No se pudo establecer la conexion.", MessageBoxButtons.OK, "Error")
            Me.Close()
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CustomizeComponents()
        txtUser.AutoSize = False
        txtUser.Size = New Size(350, 35)
        txtPass.AutoSize = False
        txtPass.Size = New Size(350, 35)
    End Sub

    Private Sub btnIniciarSesion_Paint(sender As Object, e As PaintEventArgs) Handles btnIniciarSesion.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath
        Dim myRectangle As Rectangle = btnIniciarSesion.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        btnIniciarSesion.Region = New Region(buttonPath)
    End Sub
End Class