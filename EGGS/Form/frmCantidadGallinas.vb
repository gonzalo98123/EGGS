Public Class frmCantidadGallinas
    Dim gall As clsGallinas
    Dim dt As DataTable
    Private Sub frmCantidadGallinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gall = New clsGallinas
        dt = New DataTable

        dt = gall.devuelveRegistroGallinas()

        'el procedimiento en la base esta programado para que devuelva un solo regirstro, no debe haber problemas con el for each
        For Each row As DataRow In dt.Rows
            lblCantidadVivas.Text = CStr(row("VivasALaFecha"))
            lblUltimaCarga.Text = CStr(row("FechaCarga"))

        Next
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class