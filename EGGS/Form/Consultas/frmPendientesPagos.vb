Public Class frmPendientesPagos
    Dim clsCA As clsComprobanteAvicola
    Dim clsHuevo As clsHuevo
    Dim EgrHuev As frmEgresoHuevos
    Dim dt As DataTable
    Dim id As Integer

    Private Sub frmPendientesPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EGGS1DataSet3.vw_MovimientosPendientesPagos' table. You can move, or remove it, as needed.
        Me.Vw_MovimientosPendientesPagosTableAdapter1.Fill(Me.EGGS1DataSet3.vw_MovimientosPendientesPagos)
        'TODO: This line of code loads data into the 'EGGS1DataSet2.vw_MovimientosPendientesPagos' table. You can move, or remove it, as needed.
        Me.Vw_MovimientosPendientesPagosTableAdapter.Fill(Me.EGGS1DataSet2.vw_MovimientosPendientesPagos)


    End Sub

    Private Sub btnPagado_Click(sender As Object, e As EventArgs) Handles btnPagado.Click
        EgrHuev = New frmEgresoHuevos
        clsCA = New clsComprobanteAvicola
        clsCA.idMovimientosHuevos = id
        clsCA.marcarComoPagado()
        MsgBox("El comprobante se marco como pagado.")
        EgrHuev.Show()
    End Sub

    Private Sub dgvPendientesPagos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPendientesPagos.SelectionChanged
        id = dgvPendientesPagos.CurrentRow.Cells(0).Value
    End Sub


End Class