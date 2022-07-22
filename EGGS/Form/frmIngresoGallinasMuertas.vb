Public Class frmIngresoGallinasMuertas

    Dim boolKey As Boolean
    Dim cantidadMuertas As Int32
    Dim fechaCarga As Date

    Dim gallinas As clsGallinas



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If (txtCantidad.Text <> "") Then
            cantidadMuertas = CInt(txtCantidad.Text)
            fechaCarga = dtFechaIngreso.Value

            gallinas = New clsGallinas
            gallinas.cantidadGallinasMuertas = cantidadMuertas
            gallinas.fechaCarga = fechaCarga
            gallinas.ingresoGallinasMuertas()

            MsgBox("Cargado correctamente", MessageBoxButtons.OK, "Mensaje")
            Me.Close()

        Else
            MsgBox("Ingrese una cantidad", MessageBoxButtons.OK, "Alerta")
        End If

    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            MsgBox("Ingrese solo numeros", MessageBoxButtons.OK, "Alerta")
            boolKey = False
        End If
    End Sub
End Class