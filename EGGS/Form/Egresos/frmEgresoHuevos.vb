Public Class frmEgresoHuevos
    Dim dtHue As DataTable
    Dim dtVen As DataTable
    Dim dtCli As DataTable
    Dim dtTc As DataTable
    Dim dtTcaja As DataTable
    Dim hue As clsHuevo
    Dim cliente As clsCliente
    Dim vendedor As clsVendedor
    Dim comprobante As clsComprobanteAvicola
    Dim tipocomprobante As clsTipoComprobante
    Dim tempcaja As clsTempCaja

    Dim cantidadHuevos As Integer
    Dim fecha As Date
    Dim idVendedor As Integer
    Dim idCliente As Integer
    Dim total As Decimal
    Dim pagado As Boolean
    Dim observaciones As String
    Dim cajaAbierta As Boolean



    Private Sub frmEgresoHuevos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cliente = New clsCliente
        vendedor = New clsVendedor
        dtHue = New DataTable
        dtCli = New DataTable
        dtVen = New DataTable

        hue = New clsHuevo
        dtHue = New DataTable
        'lleno los dt
        dtHue = hue.devuelveStockHuevos()
        dtCli = cliente.devuelveClientes()
        dtVen = vendedor.devuelveVendedores()

        'el procedimiento en la base esta programado para que devuelva un solo regirstro, no debe haber problemas con el for each
        For Each row As DataRow In dtHue.Rows
            lblCantidad.Text = CStr(row("CantidadStock")) + " Huevos"
        Next

        'lleno los cbo
        cboVendedor.DataSource = dtVen
        cboVendedor.ValueMember = "IdVendedor"
        cboVendedor.DisplayMember = "NombreApellido"


        cboCliente.DataSource = dtCli
        cboCliente.ValueMember = "IdCliente"
        cboCliente.DisplayMember = "RazonSocial"

    End Sub

    Private Sub btnEgreso_Click(sender As Object, e As EventArgs) Handles btnEgreso.Click

        If chkPagado.Checked = True Then
            'ESTA PARTE VA PARA EL EGRESO 
            hue = New clsHuevo
            fecha = dtFechaCarga.Value
            cantidadHuevos = CInt(txtCantidadHuevos.Text)
            idVendedor = cboVendedor.SelectedValue
            idCliente = cboCliente.SelectedValue
            total = CDec(txtTotal.Text)

            observaciones = txtObservaciones.Text

            hue.fechaCarga = fecha
            hue.cantidadHuevos = cantidadHuevos
            hue.idcliente = idCliente
            hue.idvendedor = idVendedor
            hue.total = total
            hue.pagado = True
            hue.observaciones = observaciones

            hue.egresoHuevos()
            'ESTA PARTE VA PARA GENERAR EL COMPROBANTE
            comprobante = New clsComprobanteAvicola
            If chkFactura.Checked = True Then
                comprobante.total = CDbl(txtTotal.Text)
                comprobante.comprobante = txtComprobante1.Text & "-" & txtComprobante2.Text
                comprobante.observaciones = txtObservaciones.Text
                comprobante.fechaComprobante = dtFechaCarga.Value
                comprobante.esEgreso = 0
                comprobante.idTipoComprobante = cboTipoComprobante.SelectedValue
                comprobante.ingresarComprobante()

            Else
                comprobante.total = CDbl(txtTotal.Text)
                comprobante.comprobante = "xxxx-xxxxxxxx"
                comprobante.observaciones = txtObservaciones.Text
                comprobante.fechaComprobante = dtFechaCarga.Value
                comprobante.esEgreso = 0
                comprobante.idTipoComprobante = 4
                comprobante.ingresarComprobante()
            End If


            MsgBox("Egreso cargado correctamente", MsgBoxStyle.Information, "Egreso")


        Else
            hue = New clsHuevo

            fecha = dtFechaCarga.Value
            cantidadHuevos = CInt(txtCantidadHuevos.Text)
            idVendedor = cboVendedor.SelectedValue
            idCliente = cboCliente.SelectedValue
            total = CDec(txtTotal.Text)

            observaciones = txtObservaciones.Text

            hue.fechaCarga = fecha
            hue.cantidadHuevos = cantidadHuevos
            hue.idcliente = idCliente
            hue.idvendedor = idVendedor
            hue.total = total
            hue.pagado = False
            hue.observaciones = observaciones

            hue.egresoHuevos()

            MsgBox("Egreso cargado correctamente", MsgBoxStyle.Information, "Egreso")
        End If

        Me.Close()




    End Sub

    Private Sub chkFactura_CheckedChanged(sender As Object, e As EventArgs) Handles chkFactura.CheckedChanged
        If chkFactura.Checked = True Then

            tipocomprobante = New clsTipoComprobante
            dtTc = New DataTable


            dtTc = tipocomprobante.devuelveTiposComprobantes
            cboTipoComprobante.DataSource = dtTc
            cboTipoComprobante.DisplayMember = "TipoComprobante"
            cboTipoComprobante.ValueMember = "IdTipoComprobante"

            cboTipoComprobante.Enabled = True
            txtComprobante1.Enabled = True
            txtComprobante2.Enabled = True
        Else
            cboTipoComprobante.Enabled = False
            txtComprobante1.Enabled = False
            txtComprobante2.Enabled = False
        End If
    End Sub

    Private Sub chkPagado_CheckedChanged(sender As Object, e As EventArgs) Handles chkPagado.CheckedChanged
        If chkPagado.Checked = True Then

            tempcaja = New clsTempCaja
            dtTcaja = New DataTable

            dtTcaja = tempcaja.VerificarCajaAbierta
            Dim row As DataRow = dtTcaja.Rows(dtTcaja.Rows.Count - 1)

            If row("Cantidad") > 0 Then
                chkFactura.Enabled = True
            Else
                MsgBox("Para ingresar una factura debe abrir una caja", MsgBoxStyle.Critical, "Informacion")
                chkPagado.Checked = False
            End If
        Else
            chkFactura.Checked = False
            chkFactura.Enabled = False
            cboTipoComprobante.Enabled = False
            txtComprobante1.Enabled = False
            txtComprobante2.Enabled = False
        End If
    End Sub
End Class