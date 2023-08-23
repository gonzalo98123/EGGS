Public Class frmCierreDeCaja
    Dim tempcaja As clsTempCaja
    Dim caja As clsCaja
    Dim dtTempCaja As DataTable
    Dim dt As DataTable
    Private Sub frmCierreDeCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tempcaja = New clsTempCaja
        dt = New DataTable
        dtTempCaja = tempcaja.VerificarCajaAbierta
        dt = tempcaja.DevuelveDatosCierreCaja()

        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                lblFecha.Text = CDate(row("FechaApertura"))
                lblMontoCierre.Text = CStr(row("TotalDisponible"))
                lblUsuario.Text = CStr(row("Usuario"))
            Next
        Else
            MsgBox("No hay ninguna caja abierta.", MsgBoxStyle.Critical, "Informacion")
            Me.Close()
        End If
    End Sub

    Private Sub btnComprobantes_Click(sender As Object, e As EventArgs) Handles btnComprobantes.Click
        frmConsultaComprobantesCaja.Show()
    End Sub

    Private Sub btnCierreCaja_Click(sender As Object, e As EventArgs) Handles btnCierreCaja.Click
        caja = New clsCaja
        caja.cierreCaja()
        MsgBox("Caja cerrada correctamente")
    End Sub
End Class