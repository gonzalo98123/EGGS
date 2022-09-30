<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCierreDeCaja
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMontoCierre = New System.Windows.Forms.Label()
        Me.btnCierreCaja = New System.Windows.Forms.Button()
        Me.btnComprobantes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CIERRE DE CAJA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha de apertura:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(115, 100)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(39, 13)
        Me.lblFecha.TabIndex = 2
        Me.lblFecha.Text = "Label3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Usuario encargado;"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(115, 125)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(39, 13)
        Me.lblUsuario.TabIndex = 4
        Me.lblUsuario.Text = "Label4"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Monto de cierre:"
        '
        'lblMontoCierre
        '
        Me.lblMontoCierre.AutoSize = True
        Me.lblMontoCierre.Location = New System.Drawing.Point(115, 154)
        Me.lblMontoCierre.Name = "lblMontoCierre"
        Me.lblMontoCierre.Size = New System.Drawing.Size(39, 13)
        Me.lblMontoCierre.TabIndex = 6
        Me.lblMontoCierre.Text = "Label5"
        '
        'btnCierreCaja
        '
        Me.btnCierreCaja.Location = New System.Drawing.Point(338, 130)
        Me.btnCierreCaja.Name = "btnCierreCaja"
        Me.btnCierreCaja.Size = New System.Drawing.Size(89, 23)
        Me.btnCierreCaja.TabIndex = 7
        Me.btnCierreCaja.Text = "Realizar cierre"
        Me.btnCierreCaja.UseVisualStyleBackColor = True
        '
        'btnComprobantes
        '
        Me.btnComprobantes.Location = New System.Drawing.Point(291, 88)
        Me.btnComprobantes.Name = "btnComprobantes"
        Me.btnComprobantes.Size = New System.Drawing.Size(134, 36)
        Me.btnComprobantes.TabIndex = 8
        Me.btnComprobantes.Text = "Ver comprobantes de caja"
        Me.btnComprobantes.UseVisualStyleBackColor = True
        '
        'frmCierreDeCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 176)
        Me.Controls.Add(Me.btnComprobantes)
        Me.Controls.Add(Me.btnCierreCaja)
        Me.Controls.Add(Me.lblMontoCierre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCierreDeCaja"
        Me.Text = "frmCierreDeCaja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblMontoCierre As Label
    Friend WithEvents btnCierreCaja As Button
    Friend WithEvents btnComprobantes As Button
End Class
