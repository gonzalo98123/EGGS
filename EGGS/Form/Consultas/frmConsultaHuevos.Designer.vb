<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaHuevos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cantidad actual de huevos:"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(195, 43)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(39, 13)
        Me.lblCantidad.TabIndex = 1
        Me.lblCantidad.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ultima actualizacion registrada:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(196, 72)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(39, 13)
        Me.lblFecha.TabIndex = 3
        Me.lblFecha.Text = "Label3"
        '
        'frmConsultaHuevos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 176)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmConsultaHuevos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConsultaHuevos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFecha As Label
End Class
