Public Class frmConsultaComprobantesCaja
    Private Sub frmConsultaComprobantesCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EGGS1DataSetComprobantes.vw_ComprobantesCaja' table. You can move, or remove it, as needed.
        Me.Vw_ComprobantesCajaTableAdapter.Fill(Me.EGGS1DataSetComprobantes.vw_ComprobantesCaja)
        'TODO: This line of code loads data into the 'EGGS1DataSet.vw_ComprobantesCaja' table. You can move, or remove it, as needed.

    End Sub
End Class