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
End Class