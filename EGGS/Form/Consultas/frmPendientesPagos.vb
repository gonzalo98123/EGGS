Public Class frmPendientesPagos
    Dim clsCA As clsComprobanteAvicola
    Dim clsHuevo As clsHuevo
    Dim EgrHuev As frmEgresoHuevos
    Dim dt As DataTable
    Dim id As Integer

    Private Sub frmPendientesPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EGGS1DataSet1.vw_MovimientosPendientesPagos' table. You can move, or remove it, as needed.


        clsCA = New clsComprobanteAvicola
        dt = New DataTable


        'dt = clsCA.devuelveNoPagos

        dgvPendientesPagos.DataSource = dt
        ' id = dgvPendientesPagos.CurrentRow.Cells(0).Value



    End Sub

    Private Sub btnPagado_Click(sender As Object, e As EventArgs) Handles btnPagado.Click
        clsHuevo = New clsHuevo
        EgrHuev = New frmEgresoHuevos
        EgrHuev.esModificacion = True
        EgrHuev.idModificacion = id
        clsHuevo.idMovimientoHuevos = id
        clsHuevo.marcarPagoComprobante()
        MsgBox("El id seleccionado es:" + CStr(id), MsgBoxStyle.Information, "Info")
        EgrHuev.Show()
    End Sub

    Private Sub dgvPendientesPagos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPendientesPagos.SelectionChanged
        id = dgvPendientesPagos.CurrentRow.Cells(0).Value
    End Sub


End Class