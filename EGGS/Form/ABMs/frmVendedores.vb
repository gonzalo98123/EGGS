Public Class frmVendedores

    Dim dt As DataTable
    Dim vendedores As clsVendedor
    Dim id As Object
    'defino la variable modo para identificar si se edita o agrega
    Dim modo As Integer

    Private Sub frmVendedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt = New DataTable
        vendedores = New clsVendedor
        dt = vendedores.devuelveVendedores()

        lstVendedores.DataSource = dt
        lstVendedores.ValueMember = "IdVendedor"
        lstVendedores.DisplayMember = "NombreApellido"

    End Sub

    Private Sub lstVendedores_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstVendedores.SelectedValueChanged
        dt = New DataTable
        vendedores = New clsVendedor
        id = lstVendedores.SelectedValue

        If (TypeOf id Is Integer) Then
            vendedores.idVendedor = id
            dt = vendedores.devuelveVendedoresPorId()
            For Each row As DataRow In dt.Rows
                txtNombreApellido.Text = CStr(row("NombreApellido"))
                txtTelefono.Text = CStr(row("Telefono"))
                txtMail.Text = CStr(row("Mail"))
                txtObservaciones.Text = CStr(row("Observaciones"))
            Next
        End If




    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        modo = 1 'modo 1 para agregar
        lstVendedores.Enabled = False
        pnlDatos.Enabled = True
        btnAceptar.Visible = False
        btnAgregar.Visible = False
        btnEliminar.Visible = False
        btnEditar.Visible = False
        btnAceptar.Visible = True
        btnCancelar.Visible = True
        txtNombreApellido.Text = ""
        txtTelefono.Text = ""
        txtMail.Text = ""
        txtObservaciones.Text = ""
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        lstVendedores.Enabled = True
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
        vendedores = New clsVendedor

        If modo = 1 Then 'modo 1 agrega
            vendedores.nombreApellido = txtNombreApellido.Text
            vendedores.telefono = txtTelefono.Text
            vendedores.mail = txtMail.Text
            vendedores.observaciones = txtObservaciones.Text

            vendedores.agregaVendedor()
            MsgBox("Vendedor agregado correctamente", MsgBoxStyle.Information, "Mensaje")

            lstVendedores.Enabled = True
            pnlDatos.Enabled = False
            btnAceptar.Visible = True
            btnAgregar.Visible = True
            btnEliminar.Visible = True
            btnEditar.Visible = True
            btnAceptar.Visible = False
            btnCancelar.Visible = False


            dt = New DataTable
            vendedores = New clsVendedor
            dt = vendedores.devuelveVendedores()

            lstVendedores.DataSource = dt
            lstVendedores.ValueMember = "IdVendedor"
            lstVendedores.DisplayMember = "NombreApellido"
        End If

        If modo = 2 Then
            If (TypeOf id Is Integer) Then
                vendedores = New clsVendedor

                vendedores.idVendedor = id
                vendedores.nombreApellido = txtNombreApellido.Text
                vendedores.telefono = txtTelefono.Text
                vendedores.mail = txtMail.Text
                vendedores.observaciones = txtObservaciones.Text

                vendedores.modificaVendedor()
                MsgBox("Vendedor modificado correctamente", MsgBoxStyle.Information, "Mensaje")

                lstVendedores.Enabled = True
                pnlDatos.Enabled = False
                btnAceptar.Visible = True
                btnAgregar.Visible = True
                btnEliminar.Visible = True
                btnEditar.Visible = True
                btnAceptar.Visible = False
                btnCancelar.Visible = False


                dt = New DataTable
                dt = vendedores.devuelveVendedores()

                lstVendedores.DataSource = dt
                lstVendedores.ValueMember = "IdVendedor"
                lstVendedores.DisplayMember = "NombreApellido"

            End If
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        vendedores = New clsVendedor
        id = lstVendedores.SelectedValue

        If (TypeOf id Is Integer) Then
            vendedores.idVendedor = id
            vendedores.eliminaVendedor()
            MsgBox("Vendedor eliminado correctamente", MsgBoxStyle.Information, "Mensaje")

            dt = New DataTable
            vendedores = New clsVendedor
            dt = vendedores.devuelveVendedores()

            lstVendedores.DataSource = dt
            lstVendedores.ValueMember = "IdVendedor"
            lstVendedores.DisplayMember = "NombreApellido"

        End If

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        modo = 2 'modo 2 para modificar

        id = lstVendedores.SelectedValue

        lstVendedores.Enabled = False
        pnlDatos.Enabled = True
        btnAceptar.Visible = False
        btnAgregar.Visible = False
        btnEliminar.Visible = False
        btnEditar.Visible = False
        btnAceptar.Visible = True
        btnCancelar.Visible = True





    End Sub
End Class