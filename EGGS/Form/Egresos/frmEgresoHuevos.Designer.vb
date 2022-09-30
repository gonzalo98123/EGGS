<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEgresoHuevos
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
        Me.Cantidad = New System.Windows.Forms.Label()
        Me.txtCantidadHuevos = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboVendedor = New System.Windows.Forms.ComboBox()
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEgreso = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtFechaCarga = New System.Windows.Forms.DateTimePicker()
        Me.chkPagado = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.chkFactura = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtComprobante2 = New System.Windows.Forms.TextBox()
        Me.txtComprobante1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboTipoComprobante = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Cantidad
        '
        Me.Cantidad.AutoSize = True
        Me.Cantidad.Location = New System.Drawing.Point(9, 100)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(52, 13)
        Me.Cantidad.TabIndex = 0
        Me.Cantidad.Text = "Cantidad:"
        '
        'txtCantidadHuevos
        '
        Me.txtCantidadHuevos.Location = New System.Drawing.Point(67, 97)
        Me.txtCantidadHuevos.Name = "txtCantidadHuevos"
        Me.txtCantidadHuevos.Size = New System.Drawing.Size(198, 20)
        Me.txtCantidadHuevos.TabIndex = 1
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(155, 39)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(39, 13)
        Me.lblCantidad.TabIndex = 3
        Me.lblCantidad.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cantidad actual de huevos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Vendedor:"
        '
        'cboVendedor
        '
        Me.cboVendedor.FormattingEnabled = True
        Me.cboVendedor.Location = New System.Drawing.Point(67, 123)
        Me.cboVendedor.Name = "cboVendedor"
        Me.cboVendedor.Size = New System.Drawing.Size(198, 21)
        Me.cboVendedor.TabIndex = 5
        '
        'cboCliente
        '
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(67, 156)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(198, 21)
        Me.cboCliente.TabIndex = 6
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(67, 186)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(198, 20)
        Me.txtTotal.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Cliente:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Total:"
        '
        'btnEgreso
        '
        Me.btnEgreso.Location = New System.Drawing.Point(465, 258)
        Me.btnEgreso.Name = "btnEgreso"
        Me.btnEgreso.Size = New System.Drawing.Size(75, 23)
        Me.btnEgreso.TabIndex = 12
        Me.btnEgreso.Text = "Egreso"
        Me.btnEgreso.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Fecha:"
        '
        'dtFechaCarga
        '
        Me.dtFechaCarga.Location = New System.Drawing.Point(67, 70)
        Me.dtFechaCarga.Name = "dtFechaCarga"
        Me.dtFechaCarga.Size = New System.Drawing.Size(198, 20)
        Me.dtFechaCarga.TabIndex = 14
        '
        'chkPagado
        '
        Me.chkPagado.AutoSize = True
        Me.chkPagado.Location = New System.Drawing.Point(135, 222)
        Me.chkPagado.Name = "chkPagado"
        Me.chkPagado.Size = New System.Drawing.Size(63, 17)
        Me.chkPagado.TabIndex = 16
        Me.chkPagado.Text = "Pagado"
        Me.chkPagado.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(308, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Obs:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(343, 70)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(198, 88)
        Me.txtObservaciones.TabIndex = 17
        '
        'chkFactura
        '
        Me.chkFactura.AutoSize = True
        Me.chkFactura.Enabled = False
        Me.chkFactura.Location = New System.Drawing.Point(67, 222)
        Me.chkFactura.Name = "chkFactura"
        Me.chkFactura.Size = New System.Drawing.Size(62, 17)
        Me.chkFactura.TabIndex = 19
        Me.chkFactura.Text = "Factura"
        Me.chkFactura.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Location = New System.Drawing.Point(184, 264)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "-"
        '
        'txtComprobante2
        '
        Me.txtComprobante2.Enabled = False
        Me.txtComprobante2.Location = New System.Drawing.Point(200, 261)
        Me.txtComprobante2.Name = "txtComprobante2"
        Me.txtComprobante2.Size = New System.Drawing.Size(96, 20)
        Me.txtComprobante2.TabIndex = 6
        '
        'txtComprobante1
        '
        Me.txtComprobante1.Enabled = False
        Me.txtComprobante1.Location = New System.Drawing.Point(135, 261)
        Me.txtComprobante1.Name = "txtComprobante1"
        Me.txtComprobante1.Size = New System.Drawing.Size(49, 20)
        Me.txtComprobante1.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Enabled = False
        Me.Label8.Location = New System.Drawing.Point(132, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Nro Comprobante"
        '
        'cboTipoComprobante
        '
        Me.cboTipoComprobante.Enabled = False
        Me.cboTipoComprobante.FormattingEnabled = True
        Me.cboTipoComprobante.Location = New System.Drawing.Point(76, 260)
        Me.cboTipoComprobante.Name = "cboTipoComprobante"
        Me.cboTipoComprobante.Size = New System.Drawing.Size(53, 21)
        Me.cboTipoComprobante.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.Location = New System.Drawing.Point(5, 254)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 26)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Tipo de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "comprobante:"
        '
        'frmEgresoHuevos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 288)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtComprobante2)
        Me.Controls.Add(Me.txtComprobante1)
        Me.Controls.Add(Me.cboTipoComprobante)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.chkFactura)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.chkPagado)
        Me.Controls.Add(Me.dtFechaCarga)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnEgreso)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.cboCliente)
        Me.Controls.Add(Me.cboVendedor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCantidadHuevos)
        Me.Controls.Add(Me.Cantidad)
        Me.Name = "frmEgresoHuevos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEgresoHuevos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cantidad As Label
    Friend WithEvents txtCantidadHuevos As TextBox
    Friend WithEvents lblCantidad As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboVendedor As ComboBox
    Friend WithEvents cboCliente As ComboBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnEgreso As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents dtFechaCarga As DateTimePicker
    Friend WithEvents chkPagado As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents chkFactura As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtComprobante2 As TextBox
    Friend WithEvents txtComprobante1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cboTipoComprobante As ComboBox
    Friend WithEvents Label9 As Label
End Class
