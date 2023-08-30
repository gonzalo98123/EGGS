Public Class frmClientes
    Dim dt As DataTable
    Dim clientes As clsCliente
    Dim id As Object
    'defino la variable modo para identificar si se edita o agrega
    Dim modo As Integer

    Private Sub frmVendedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt = New DataTable
        clientes = New clsCliente
        dt = clientes.devuelveClientes()

        lstClientes.DataSource = dt
        lstClientes.ValueMember = "IdCliente"
        lstClientes.DisplayMember = "RazonSocial"


    End Sub

    Private Sub lstVendedores_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstClientes.SelectedValueChanged
        dt = New DataTable
        clientes = New clsCliente
        id = lstClientes.SelectedValue

        If (TypeOf id Is Integer) Then
            clientes.idcliente = id
            dt = clientes.devuelveClientePorId()
            For Each row As DataRow In dt.Rows
                txtRazonSocial.Text = CStr(row("RazonSocial"))
                txtTelefono.Text = CStr(row("Telefono"))
                txtMail.Text = CStr(row("Mail"))
                txtDireccion.Text = CStr(row("Direccion"))
                txtObservaciones.Text = CStr(row("Observaciones"))
            Next
        End If




    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        modo = 1 'modo 1 para agregar
        lstClientes.Enabled = False
        pnlDatos.Enabled = True
        btnAceptar.Visible = False
        btnAgregar.Visible = False
        btnEliminar.Visible = False
        btnEditar.Visible = False
        btnAceptar.Visible = True
        btnCancelar.Visible = True
        txtRazonSocial.Text = ""
        txtTelefono.Text = ""
        txtMail.Text = ""
        txtDireccion.Text = ""
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        lstClientes.Enabled = True
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
        clientes = New clsCliente

        If modo = 1 Then 'modo 1 agrega
            clientes.razonsocial = txtRazonSocial.Text
            clientes.telefono = txtTelefono.Text
            clientes.mail = txtMail.Text
            clientes.observaciones = txtObservaciones.Text

            clientes.agregaCliente()
            MsgBox("Cliente agregado correctamente", MsgBoxStyle.Information, "Mensaje")

            lstClientes.Enabled = True
            pnlDatos.Enabled = False
            btnAceptar.Visible = True
            btnAgregar.Visible = True
            btnEliminar.Visible = True
            btnEditar.Visible = True
            btnAceptar.Visible = False
            btnCancelar.Visible = False


            dt = New DataTable
            clientes = New clsCliente
            dt = clientes.devuelveClientes()

            lstClientes.DataSource = dt
            lstClientes.ValueMember = "IdCliente"
            lstClientes.DisplayMember = "RazonSocial"
        End If

        If modo = 2 Then
            If (TypeOf id Is Integer) Then
                clientes = New clsCliente

                clientes.idcliente = id
                clientes.razonsocial = txtRazonSocial.Text
                clientes.telefono = txtTelefono.Text
                clientes.mail = txtMail.Text
                clientes.direccion = txtDireccion.Text
                clientes.observaciones = txtObservaciones.Text


                clientes.modificaCliente()
                MsgBox("Cliente modificado correctamente", MsgBoxStyle.Information, "Mensaje")

                lstClientes.Enabled = True
                pnlDatos.Enabled = False
                btnAceptar.Visible = True
                btnAgregar.Visible = True
                btnEliminar.Visible = True
                btnEditar.Visible = True
                btnAceptar.Visible = False
                btnCancelar.Visible = False


                dt = New DataTable
                dt = clientes.devuelveClientes

                lstClientes.DataSource = dt
                lstClientes.ValueMember = "IdCliente"
                lstClientes.DisplayMember = "RazonSocial"

            End If
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        clientes = New clsCliente

        If (TypeOf id Is Integer) Then
            clientes.idcliente = id
            clientes.eliminaCliente()
            MsgBox("Cliente eliminado correctamente", MsgBoxStyle.Information, "Mensaje")

            dt = New DataTable
            clientes = New clsCliente
            dt = clientes.devuelveClientes()

            lstClientes.DataSource = dt
            lstClientes.ValueMember = "IdCliente"
            lstClientes.DisplayMember = "RazonSocial"

        End If

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        modo = 2 'modo 2 para modificar

        id = lstClientes.SelectedValue

        lstClientes.Enabled = False
        pnlDatos.Enabled = True
        btnAceptar.Visible = False
        btnAgregar.Visible = False
        btnEliminar.Visible = False
        btnEditar.Visible = False
        btnAceptar.Visible = True
        btnCancelar.Visible = True





    End Sub


End Class