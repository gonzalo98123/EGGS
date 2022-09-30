Public Class frmTiposGastos
    Dim dt As DataTable
    Dim tipogasto As clsTipoGasto
    Dim id As Object
    Dim modo As Integer
    Private Sub frmVendedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt = New DataTable
        tipogasto = New clsTipoGasto
        dt = tipogasto.devuelveTiposGastos

        lstTiposGastos.DataSource = dt
        lstTiposGastos.ValueMember = "IdTipoGasto"
        lstTiposGastos.DisplayMember = "TipoGasto"

    End Sub

    Private Sub lstVendedores_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstTiposGastos.SelectedValueChanged
        dt = New DataTable
        tipogasto = New clsTipoGasto
        id = lstTiposGastos.SelectedValue

        If (TypeOf id Is Integer) Then
            tipogasto.idTipoGasto = id
            dt = tipogasto.devuelveTiposGastosPorId()
            For Each row As DataRow In dt.Rows
                txtTipoGasto.Text = CStr(row("TipoGasto"))
                txtDetalle.Text = CStr(row("Detalle"))
            Next
        End If




    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        modo = 1 'modo 1 para agregar
        lstTiposGastos.Enabled = False
        pnlDatos.Enabled = True
        btnAceptar.Visible = False
        btnAgregar.Visible = False
        btnEliminar.Visible = False
        btnEditar.Visible = False
        btnAceptar.Visible = True
        btnCancelar.Visible = True
        txtTipoGasto.Text = ""
        txtDetalle.Text = ""
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        lstTiposGastos.Enabled = True
        pnlDatos.Enabled = False
        btnAceptar.Visible = True
        btnAgregar.Visible = True
        btnEliminar.Visible = True
        btnEditar.Visible = True
        btnAceptar.Visible = False
        btnCancelar.Visible = False
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        'pregunto que modo es
        tipogasto = New clsTipoGasto

        If modo = 1 Then 'modo 1 agrega
            tipogasto.tipoGasto = txtTipoGasto.Text
            tipogasto.detalle = txtDetalle.Text

            tipogasto.agregaTipoGasto()
            MsgBox("Tipo de gasto agregado correctamente", MsgBoxStyle.Information, "Mensaje")

            lstTiposGastos.Enabled = True
            pnlDatos.Enabled = False
            btnAceptar.Visible = True
            btnAgregar.Visible = True
            btnEliminar.Visible = True
            btnEditar.Visible = True
            btnAceptar.Visible = False
            btnCancelar.Visible = False


            dt = New DataTable
            tipogasto = New clsTipoGasto
            dt = tipogasto.devuelveTiposGastos

            lstTiposGastos.DataSource = dt
            lstTiposGastos.ValueMember = "IdTipoGasto"
            lstTiposGastos.DisplayMember = "TipoGasto"
        End If

        If modo = 2 Then
            If (TypeOf id Is Integer) Then
                tipogasto = New clsTipoGasto

                tipogasto.idTipoGasto = id
                tipogasto.tipoGasto = txtTipoGasto.Text
                tipogasto.detalle = txtDetalle.Text

                tipogasto.modificaTipoGasto()
                MsgBox("Tipo de gasto modificado correctamente", MsgBoxStyle.Information, "Mensaje")

                lstTiposGastos.Enabled = True
                pnlDatos.Enabled = False
                btnAceptar.Visible = True
                btnAgregar.Visible = True
                btnEliminar.Visible = True
                btnEditar.Visible = True
                btnAceptar.Visible = False
                btnCancelar.Visible = False


                dt = New DataTable
                dt = tipogasto.devuelveTiposGastos()

                lstTiposGastos.DataSource = dt
                lstTiposGastos.ValueMember = "IdTipoGasto"
                lstTiposGastos.DisplayMember = "TipoGasto"

            End If
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        tipogasto = New clsTipoGasto
        id = lstTiposGastos.SelectedValue

        If (TypeOf id Is Integer) Then
            tipogasto.idTipoGasto = id
            tipogasto.eliminaTipoGasto()
            MsgBox("Tipo de gasto eliminado correctamente", MsgBoxStyle.Information, "Mensaje")

            dt = New DataTable
            tipogasto = New clsTipoGasto
            dt = tipogasto.devuelveTiposGastos()

            lstTiposGastos.DataSource = dt
            lstTiposGastos.ValueMember = "IdTipoGasto"
            lstTiposGastos.DisplayMember = "TipoGasto"

        End If

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        modo = 2 'modo 2 para modificar

        id = lstTiposGastos.SelectedValue

        lstTiposGastos.Enabled = False
        pnlDatos.Enabled = True
        btnAceptar.Visible = False
        btnAgregar.Visible = False
        btnEliminar.Visible = False
        btnEditar.Visible = False
        btnAceptar.Visible = True
        btnCancelar.Visible = True





    End Sub
End Class