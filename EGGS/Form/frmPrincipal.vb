Imports System.ComponentModel

Public Class frmPrincipal
    Private Sub ConsultarCantidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarCantidadToolStripMenuItem.Click
        frmCantidadGallinas.Show()
    End Sub

    Private Sub IngresarGallinasMuertasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarGallinasMuertasToolStripMenuItem.Click
        frmIngresoGallinasMuertas.Show()
    End Sub

    Private Sub IngresoDeGallinasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDeGallinasToolStripMenuItem.Click
        frmIngresoGallinasVivas.Show()
    End Sub

    Private Sub ConsultarStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarStockToolStripMenuItem.Click
        frmConsultaHuevos.Show()
    End Sub

    Private Sub VendedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendedoresToolStripMenuItem.Click
        frmVendedores.Show()
    End Sub

    Private Sub ExportarvenderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarvenderToolStripMenuItem.Click
        frmEgresoHuevos.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        frmClientes.Show()
    End Sub

    Private Sub IngresoHuevosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoHuevosToolStripMenuItem.Click
        frmIngresoHuevos.Show()

    End Sub

    Private Sub ConsultarEgresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarEgresosToolStripMenuItem.Click
        frmConsultaEgresoHuevos.Show()
    End Sub

    Private Sub AperturaDeCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AperturaDeCajaToolStripMenuItem.Click
        frmAperturaCaja.Show()
    End Sub

    Private Sub TiposDeGastosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeGastosToolStripMenuItem.Click
        frmTiposGastos.Show()
    End Sub

    Private Sub IngresoDeComprobantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDeComprobantesToolStripMenuItem.Click
        frmIngesoComprobante.Show()
    End Sub

    Private Sub CierreDeCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CierreDeCajaToolStripMenuItem.Click
        frmCierreDeCaja.Show()
    End Sub

    Private Sub PagosPendientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosPendientesToolStripMenuItem.Click
        frmPendientesPagos.Show()
    End Sub
End Class