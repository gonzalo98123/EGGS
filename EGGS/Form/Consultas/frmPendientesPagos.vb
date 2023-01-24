Public Class frmPendientesPagos
    Dim clsCA As clsComprobanteAvicola
    Dim dt As DataTable
    Dim id As Integer

    Private Sub frmPendientesPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clsCA = New clsComprobanteAvicola
        dt = New DataTable


        dt = clsCA.devuelveNoPagos

        dgvPendientesPagos.DataSource = dt
        id = dgvPendientesPagos.CurrentRow.Cells(0).Value


    End Sub

    Private Sub btnPagado_Click(sender As Object, e As EventArgs) Handles btnPagado.Click
        MsgBox("El id seleccionado es:" + CStr(id), MsgBoxStyle.Information, "Info")
    End Sub

    Private Sub dgvPendientesPagos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPendientesPagos.SelectionChanged
        id = dgvPendientesPagos.CurrentRow.Cells(0).Value
    End Sub
End Class