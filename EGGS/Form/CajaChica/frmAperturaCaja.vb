Public Class frmAperturaCaja
    Dim clsTC As clsTempCaja
    Private Sub AperturaCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clsTC = New clsTempCaja
        Dim dt As DataTable
        dt = clsTC.VerificarCajaAbierta
        Dim row As DataRow = dt.Rows(dt.Rows.Count - 1)

        If row("Cantidad") > 0 Then
            MsgBox("Ya se encuentra una caja abierta.", MsgBoxStyle.Critical, "Informacion")
            Me.Close()
        End If

        Dim clsUser As New clsUser
        Dim dtUser As New DataTable
        dtUser = clsUser.devuelveUsuarios()
        cboUsers.DataSource = dtUser
        cboUsers.ValueMember = "IdUsuario"
        cboUsers.DisplayMember = "Usuario"
        lblFecha.Text = DateTime.Now.ToLongDateString()

    End Sub

    Private Sub btnAbrirCaja_Click(sender As Object, e As EventArgs) Handles btnAbrirCaja.Click
        clsTC = New clsTempCaja

        clsTC.idUsuario = cboUsers.SelectedValue
        clsTC.fechaApertura = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        clsTC.esApertura = True
        clsTC.montoApertura = CDbl(txtMonto.Text)

        clsTC.AperturaCaja()

        MsgBox("Se abrio la caja correctamente", MsgBoxStyle.Information, "Apertura caja")
        Me.Close()

    End Sub
End Class