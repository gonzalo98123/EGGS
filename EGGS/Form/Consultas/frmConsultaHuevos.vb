Public Class frmConsultaHuevos
    Dim dtHue As DataTable
    Dim dtVen As DataTable
    Dim dtCli As DataTable
    Dim hue As clsHuevo
    Dim cliente As clsCliente
    Dim vendedor As clsVendedor
    Private Sub frmConsultaHuevos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hue = New clsHuevo
        dtHue = New DataTable

        dtHue = hue.devuelveStockHuevos()

        If dtHue.Rows.Count > 0 Then
            For Each row As DataRow In dtHue.Rows
                lblCantidad.Text = CStr(row("CantidadStock")) + " Huevos"
                lblFecha.Text = CStr(row("FechaStock"))
            Next
        Else
            MsgBox("No se han registrado datos", MsgBoxStyle.Information, "Informacion")
            Me.Close()
        End If



    End Sub
End Class