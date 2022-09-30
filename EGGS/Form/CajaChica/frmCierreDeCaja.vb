Public Class frmCierreDeCaja
    Dim tempcaja As clsTempCaja
    Dim dtTempCaja As DataTable
    Dim dt As DataTable
    Private Sub frmCierreDeCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tempcaja = New clsTempCaja
        dt = New DataTable
        dtTempCaja = tempcaja.VerificarCajaAbierta
        dt = tempcaja.DevuelveDatosCierreCaja()

        Dim row As DataRow = dtTempCaja.Rows(dtTempCaja.Rows.Count - 1)
        Dim rowDt As DataRow = dt.Rows(dtTempCaja.Rows.Count - 1)

        If row("Cantidad") > 0 Then
            lblFecha.Text = rowDt("FechaApertura")
            lblMontoCierre.Text = rowDt("TotalDisponible")
            lblUsuario.Text = rowDt("Usuario")

        Else
            MsgBox("No hay ninguna caja abierta.", MsgBoxStyle.Critical, "Informacion")
            Me.Close()
        End If
    End Sub

    Private Sub btnComprobantes_Click(sender As Object, e As EventArgs) Handles btnComprobantes.Click
        frmConsultaComprobantesCaja.Show()
    End Sub
End Class