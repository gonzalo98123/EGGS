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
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(192, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CIERRE DE CAJA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 109)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha de apertura:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(186, 109)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(66, 24)
        Me.lblFecha.TabIndex = 2
        Me.lblFecha.Text = "Label3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 153)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Usuario encargado:"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(194, 153)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(66, 24)
        Me.lblUsuario.TabIndex = 4
        Me.lblUsuario.Text = "Label4"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 193)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 24)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Monto de cierre:"
        '
        'lblMontoCierre
        '
        Me.lblMontoCierre.AutoSize = True
        Me.lblMontoCierre.Location = New System.Drawing.Point(167, 193)
        Me.lblMontoCierre.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblMontoCierre.Name = "lblMontoCierre"
        Me.lblMontoCierre.Size = New System.Drawing.Size(66, 24)
        Me.lblMontoCierre.TabIndex = 6
        Me.lblMontoCierre.Text = "Label5"
        '
        'btnCierreCaja
        '
        Me.btnCierreCaja.ForeColor = System.Drawing.Color.Black
        Me.btnCierreCaja.Location = New System.Drawing.Point(488, 165)
        Me.btnCierreCaja.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCierreCaja.Name = "btnCierreCaja"
        Me.btnCierreCaja.Size = New System.Drawing.Size(164, 43)
        Me.btnCierreCaja.TabIndex = 7
        Me.btnCierreCaja.Text = "Realizar cierre"
        Me.btnCierreCaja.UseVisualStyleBackColor = True
        '
        'btnComprobantes
        '
        Me.btnComprobantes.ForeColor = System.Drawing.Color.Black
        Me.btnComprobantes.Location = New System.Drawing.Point(450, 88)
        Me.btnComprobantes.Margin = New System.Windows.Forms.Padding(5)
        Me.btnComprobantes.Name = "btnComprobantes"
        Me.btnComprobantes.Size = New System.Drawing.Size(246, 67)
        Me.btnComprobantes.TabIndex = 8
        Me.btnComprobantes.Text = "Ver comprobantes de caja"
        Me.btnComprobantes.UseVisualStyleBackColor = True
        '
        'frmCierreDeCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(725, 263)
        Me.Controls.Add(Me.btnComprobantes)
        Me.Controls.Add(Me.btnCierreCaja)
        Me.Controls.Add(Me.lblMontoCierre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.ForeColor = System.Drawing.Color.Gainsboro
        Me.Margin = New System.Windows.Forms.Padding(5)
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
