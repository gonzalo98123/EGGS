Public Class frmCantidadGallinas
    Dim gall As clsGallina
    Dim dt As DataTable
    Private Sub frmCantidadGallinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gall = New clsGallina
        dt = New DataTable


        dt = gall.devuelveRegistroGallinas()

        If dt.Rows.Count > 0 Then
            'el procedimiento en la base esta programado para que devuelva un solo regirstro, no debe haber problemas con el for each
            For Each row As DataRow In dt.Rows
                lblCantidadVivas.Text = CStr(row("Cantidad"))
                lblUltimaCarga.Text = CStr(row("FechaStock"))
            Next
        Else
            MsgBox("No se han registrado datos", MsgBoxStyle.Information, "Informacion")
            lblCantidadVivas.Text = ""
            lblUltimaCarga.Text = ""
        End If

    End Sub

End Class