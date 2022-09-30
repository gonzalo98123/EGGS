Public Class frmIngresoHuevos

    Dim huevos As clsHuevo
    Dim fecha As Date
    Dim cantidad As Integer

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        huevos = New clsHuevo
        fecha = dtFechaIngreso.Value()
        cantidad = CInt(txtCantidad.Text)

        huevos.cantidadHuevos = cantidad
        huevos.fechaCarga = fecha
        huevos.ingresaHuevos()
        MsgBox("Se han cargado los datos correctamente", MsgBoxStyle.Information, "Carga")
        Me.Close()

    End Sub

    Private Sub frmIngresoHuevos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class