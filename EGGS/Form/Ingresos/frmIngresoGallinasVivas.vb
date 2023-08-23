Public Class frmIngresoGallinasVivas

    Dim boolKey As Boolean
    Dim cantidad As Int32
    Dim fechaCarga As Date

    Dim gallinas As clsGallina

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If (txtCantidad.Text <> "") Then
            cantidad = CInt(txtCantidad.Text)
            fechaCarga = dtFechaIngreso.Value

            gallinas = New clsGallina
            gallinas.cantidadGallinas = cantidad
            gallinas.fechaCarga = fechaCarga
            gallinas.ingresoGallinas()

            MsgBox("Cargado correctamente", MessageBoxButtons.OK, "Mensaje")
            Me.Close()

        Else
            MsgBox("Ingrese una cantidad", MessageBoxButtons.OK, "Alerta")
        End If
    End Sub



    Private Sub dtFechaIngreso_ValueChanged(sender As Object, e As EventArgs) Handles dtFechaIngreso.ValueChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class