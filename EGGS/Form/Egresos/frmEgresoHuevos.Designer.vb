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
        Me.Cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Cantidad.Location = New System.Drawing.Point(161, 112)
        Me.Cantidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(89, 24)
        Me.Cantidad.TabIndex = 0
        Me.Cantidad.Text = "Cantidad:"
        '
        'txtCantidadHuevos
        '
        Me.txtCantidadHuevos.Location = New System.Drawing.Point(258, 113)
        Me.txtCantidadHuevos.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantidadHuevos.Name = "txtCantidadHuevos"
        Me.txtCantidadHuevos.Size = New System.Drawing.Size(295, 24)
        Me.txtCantidadHuevos.TabIndex = 1
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lblCantidad.ForeColor = System.Drawing.Color.DarkRed
        Me.lblCantidad.Location = New System.Drawing.Point(258, 28)
        Me.lblCantidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(66, 24)
        Me.lblCantidad.TabIndex = 3
        Me.lblCantidad.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(13, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cantidad actual de huevos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(150, 155)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Vendedor:"
        '
        'cboVendedor
        '
        Me.cboVendedor.FormattingEnabled = True
        Me.cboVendedor.Location = New System.Drawing.Point(258, 156)
        Me.cboVendedor.Margin = New System.Windows.Forms.Padding(4)
        Me.cboVendedor.Name = "cboVendedor"
        Me.cboVendedor.Size = New System.Drawing.Size(295, 26)
        Me.cboVendedor.TabIndex = 5
        '
        'cboCliente
        '
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(258, 202)
        Me.cboCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(295, 26)
        Me.cboCliente.TabIndex = 6
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(258, 247)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(295, 24)
        Me.txtTotal.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(177, 201)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 24)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Cliente:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(194, 246)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Total:"
        '
        'btnEgreso
        '
        Me.btnEgreso.ForeColor = System.Drawing.Color.Black
        Me.btnEgreso.Location = New System.Drawing.Point(727, 198)
        Me.btnEgreso.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEgreso.Name = "btnEgreso"
        Me.btnEgreso.Size = New System.Drawing.Size(160, 32)
        Me.btnEgreso.TabIndex = 12
        Me.btnEgreso.Text = "Egreso"
        Me.btnEgreso.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(181, 68)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 24)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Fecha:"
        '
        'dtFechaCarga
        '
        Me.dtFechaCarga.Location = New System.Drawing.Point(258, 67)
        Me.dtFechaCarga.Margin = New System.Windows.Forms.Padding(4)
        Me.dtFechaCarga.Name = "dtFechaCarga"
        Me.dtFechaCarga.Size = New System.Drawing.Size(295, 24)
        Me.dtFechaCarga.TabIndex = 14
        '
        'chkPagado
        '
        Me.chkPagado.AutoSize = True
        Me.chkPagado.Location = New System.Drawing.Point(475, 279)
        Me.chkPagado.Margin = New System.Windows.Forms.Padding(4)
        Me.chkPagado.Name = "chkPagado"
        Me.chkPagado.Size = New System.Drawing.Size(78, 22)
        Me.chkPagado.TabIndex = 16
        Me.chkPagado.Text = "Pagado"
        Me.chkPagado.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label6.Location = New System.Drawing.Point(588, 28)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 24)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Obs:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(592, 67)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(295, 120)
        Me.txtObservaciones.TabIndex = 17
        '
        'chkFactura
        '
        Me.chkFactura.AutoSize = True
        Me.chkFactura.Enabled = False
        Me.chkFactura.Location = New System.Drawing.Point(395, 279)
        Me.chkFactura.Margin = New System.Windows.Forms.Padding(4)
        Me.chkFactura.Name = "chkFactura"
        Me.chkFactura.Size = New System.Drawing.Size(77, 22)
        Me.chkFactura.TabIndex = 19
        Me.chkFactura.Text = "Factura"
        Me.chkFactura.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Location = New System.Drawing.Point(393, 340)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "-"
        '
        'txtComprobante2
        '
        Me.txtComprobante2.Enabled = False
        Me.txtComprobante2.Location = New System.Drawing.Point(411, 336)
        Me.txtComprobante2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComprobante2.Name = "txtComprobante2"
        Me.txtComprobante2.Size = New System.Drawing.Size(142, 24)
        Me.txtComprobante2.TabIndex = 6
        '
        'txtComprobante1
        '
        Me.txtComprobante1.Enabled = False
        Me.txtComprobante1.Location = New System.Drawing.Point(313, 336)
        Me.txtComprobante1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComprobante1.Name = "txtComprobante1"
        Me.txtComprobante1.Size = New System.Drawing.Size(72, 24)
        Me.txtComprobante1.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Enabled = False
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label8.Location = New System.Drawing.Point(311, 305)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 24)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Nro Comprobante"
        '
        'cboTipoComprobante
        '
        Me.cboTipoComprobante.Enabled = False
        Me.cboTipoComprobante.FormattingEnabled = True
        Me.cboTipoComprobante.Location = New System.Drawing.Point(227, 334)
        Me.cboTipoComprobante.Margin = New System.Windows.Forms.Padding(4)
        Me.cboTipoComprobante.Name = "cboTipoComprobante"
        Me.cboTipoComprobante.Size = New System.Drawing.Size(78, 26)
        Me.cboTipoComprobante.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label9.Location = New System.Drawing.Point(92, 312)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 48)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Tipo de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "comprobante:"
        '
        'frmEgresoHuevos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(901, 383)
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
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.ForeColor = System.Drawing.Color.Gainsboro
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEgresoHuevos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Egreso Huevos"
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
