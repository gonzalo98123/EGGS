Imports System.ComponentModel

Public Class frmPrincipal
    Private Sub ConsultarCantidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarCantidadToolStripMenuItem.Click
        frmCantidadGallinas.Show()
    End Sub

    Private Sub IngresarGallinasMuertasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarGallinasMuertasToolStripMenuItem.Click
        frmIngresoGallinasMuertas.Show()
    End Sub
End Class