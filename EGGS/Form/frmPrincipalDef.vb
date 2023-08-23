Public Class frmPrincipalDef
    Private Sub frmPrincipalDef_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ocultarMenu()
    End Sub

    Private Sub ocultarMenu()
        pnlGallinas.Visible = False
        pnlHuevos.Visible = False
        pnlCajaChica.Visible = False
    End Sub
    Private Sub mostrarMenu(submenu As Panel)
        If submenu.Visible = False Then
            ocultarMenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub btnGallinas_Click(sender As Object, e As EventArgs) Handles btnGallinas.Click
        mostrarMenu(pnlGallinas)
    End Sub

    Private formularioActual As Form = Nothing
    Public Sub abrirFormHijo(formularioHijo As Form)
        If formularioActual IsNot Nothing Then formularioActual.Close()

        formularioActual = formularioHijo
        formularioHijo.TopLevel = False
        formularioHijo.FormBorderStyle = FormBorderStyle.None
        formularioHijo.Dock = DockStyle.Fill
        btnIngresoGallinasMuertas.Controls.Add(formularioHijo)
        btnIngresoGallinasMuertas.Tag = formularioHijo
        formularioHijo.BringToFront()
        formularioHijo.Show()
    End Sub

    Private Sub btnIngresoGallinas_Click(sender As Object, e As EventArgs) Handles btnIngresoGallinas.Click
        abrirFormHijo(New frmIngresoGallinasVivas())
    End Sub

    Private Sub btnHuevos_Click(sender As Object, e As EventArgs) Handles btnHuevos.Click
        mostrarMenu(pnlHuevos)
    End Sub

    Private Sub btnCajaChica_Click(sender As Object, e As EventArgs) Handles btnCajaChica.Click
        mostrarMenu(pnlCajaChica)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        abrirFormHijo(New frmIngresoGallinasMuertas)
    End Sub

    Private Sub btnConsultarStockGallinas_Click(sender As Object, e As EventArgs) Handles btnConsultarStockGallinas.Click
        abrirFormHijo(New frmCantidadGallinas)
    End Sub

    Private Sub btnIngresoHuevos_Click(sender As Object, e As EventArgs) Handles btnIngresoHuevos.Click
        abrirFormHijo(New frmIngresoHuevos)
    End Sub

    Private Sub btnExportarVender_Click(sender As Object, e As EventArgs) Handles btnExportarVender.Click
        abrirFormHijo(New frmEgresoHuevos)
    End Sub

    Private Sub btnStockHuevos_Click(sender As Object, e As EventArgs) Handles btnStockHuevos.Click
        abrirFormHijo(New frmConsultaHuevos)
    End Sub

    Private Sub btnConsultarEgresos_Click(sender As Object, e As EventArgs) Handles btnConsultarEgresos.Click
        abrirFormHijo(New frmConsultaEgresoHuevos)
    End Sub

    Private Sub btnPagosPendientes_Click(sender As Object, e As EventArgs) Handles btnPagosPendientes.Click
        abrirFormHijo(New frmPendientesPagos)
    End Sub

    Private Sub btnVendedores_Click(sender As Object, e As EventArgs) Handles btnVendedores.Click
        abrirFormHijo(New frmVendedores)
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        abrirFormHijo(New frmClientes)
    End Sub

    Private Sub btnTiposGastos_Click(sender As Object, e As EventArgs) Handles btnTiposGastos.Click
        abrirFormHijo(New frmTiposGastos)
    End Sub

    Private Sub btnAperturaCaja_Click(sender As Object, e As EventArgs) Handles btnAperturaCaja.Click
        abrirFormHijo(New frmAperturaCaja)
    End Sub

    Private Sub btnIngresoComprobantes_Click(sender As Object, e As EventArgs) Handles btnIngresoComprobantes.Click
        abrirFormHijo(New frmIngesoComprobante)
    End Sub

    Private Sub btnCierreCaja_Click(sender As Object, e As EventArgs) Handles btnCierreCaja.Click
        abrirFormHijo(New frmCierreDeCaja)
    End Sub


End Class