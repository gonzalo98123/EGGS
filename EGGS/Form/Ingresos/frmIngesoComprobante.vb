
Public Class frmIngesoComprobante
    Dim clsTg As clsTipoGasto
    Dim clsTc As clsTipoComprobante
    Dim clsCa As clsComprobanteAvicola
    Dim tempcaja As clsTempCaja
    Dim dtTempCaja As DataTable
    Dim dtTg As DataTable
    Dim dtTc As DataTable
    Private Sub frmIngesoComprobante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clsTg = New clsTipoGasto
        dtTg = New DataTable
        clsTc = New clsTipoComprobante
        dtTc = New DataTable
        tempcaja = New clsTempCaja
        dtTempCaja = tempcaja.VerificarCajaAbierta

        Dim row As DataRow = dtTempCaja.Rows(dtTempCaja.Rows.Count - 1)

        If row("Cantidad") > 0 Then
            dtTg = clsTg.devuelveTiposGastos
            cboTiposGastos.DataSource = dtTg
            cboTiposGastos.ValueMember = "IdTipoGasto"
            cboTiposGastos.DisplayMember = "TipoGasto"

            dtTc = clsTc.devuelveTiposComprobantes
            cboTipoComprobante.DataSource = dtTc
            cboTipoComprobante.ValueMember = "IdTipoComprobante"
            cboTipoComprobante.DisplayMember = "TipoComprobante"
        Else
            MsgBox("Para ingresar una factura debe abrir una caja", MsgBoxStyle.Critical, "Informacion")
            Me.Close()
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCargarComprobante.Click
        clsCa = New clsComprobanteAvicola

        clsCa.fechaComprobante = dtFechaComprobante.Value
        clsCa.idTipoComprobante = cboTipoComprobante.SelectedValue
        clsCa.comprobante = txtComprobante1.Text & "-" & txtComprobante2.Text
        clsCa.idTipoGasto = cboTiposGastos.SelectedValue
        clsCa.observaciones = txtObservaciones.Text
        clsCa.total = CDbl(txtMontoTotal.Text)
        clsCa.esEgreso = True

        clsCa.ingresarComprobante()
        MsgBox("Comprobante cargado correctamente", MsgBoxStyle.Information, "Ingreso de comprobante")

    End Sub
End Class