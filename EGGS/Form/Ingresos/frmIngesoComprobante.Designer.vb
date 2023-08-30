<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngesoComprobante
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtMontoTotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboTiposGastos = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCargarComprobante = New System.Windows.Forms.Button()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtComprobante2 = New System.Windows.Forms.TextBox()
        Me.txtComprobante1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboTipoComprobante = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtFechaComprobante = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtMontoTotal)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.cboTiposGastos)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btnCargarComprobante)
        Me.Panel1.Controls.Add(Me.txtObservaciones)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.cboTipoComprobante)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dtFechaComprobante)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(14, 14)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(658, 615)
        Me.Panel1.TabIndex = 0
        '
        'txtMontoTotal
        '
        Me.txtMontoTotal.Location = New System.Drawing.Point(149, 292)
        Me.txtMontoTotal.Margin = New System.Windows.Forms.Padding(5)
        Me.txtMontoTotal.Name = "txtMontoTotal"
        Me.txtMontoTotal.Size = New System.Drawing.Size(162, 29)
        Me.txtMontoTotal.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 297)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 24)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Monto total:"
        '
        'cboTiposGastos
        '
        Me.cboTiposGastos.FormattingEnabled = True
        Me.cboTiposGastos.Location = New System.Drawing.Point(325, 53)
        Me.cboTiposGastos.Margin = New System.Windows.Forms.Padding(5)
        Me.cboTiposGastos.Name = "cboTiposGastos"
        Me.cboTiposGastos.Size = New System.Drawing.Size(302, 32)
        Me.cboTiposGastos.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(319, 24)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 24)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Tipo de gasto:"
        '
        'btnCargarComprobante
        '
        Me.btnCargarComprobante.ForeColor = System.Drawing.Color.Black
        Me.btnCargarComprobante.Location = New System.Drawing.Point(391, 556)
        Me.btnCargarComprobante.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCargarComprobante.Name = "btnCargarComprobante"
        Me.btnCargarComprobante.Size = New System.Drawing.Size(240, 43)
        Me.btnCargarComprobante.TabIndex = 8
        Me.btnCargarComprobante.Text = "Cargar comprobante"
        Me.btnCargarComprobante.UseVisualStyleBackColor = True
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(27, 385)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(5)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(600, 156)
        Me.txtObservaciones.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 356)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 24)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Observaciones"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtComprobante2)
        Me.Panel2.Controls.Add(Me.txtComprobante1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(183, 148)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(447, 96)
        Me.Panel2.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(112, 53)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "-"
        '
        'txtComprobante2
        '
        Me.txtComprobante2.Location = New System.Drawing.Point(132, 48)
        Me.txtComprobante2.Margin = New System.Windows.Forms.Padding(5)
        Me.txtComprobante2.Name = "txtComprobante2"
        Me.txtComprobante2.Size = New System.Drawing.Size(285, 29)
        Me.txtComprobante2.TabIndex = 6
        '
        'txtComprobante1
        '
        Me.txtComprobante1.Location = New System.Drawing.Point(11, 48)
        Me.txtComprobante1.Margin = New System.Windows.Forms.Padding(5)
        Me.txtComprobante1.Name = "txtComprobante1"
        Me.txtComprobante1.Size = New System.Drawing.Size(87, 29)
        Me.txtComprobante1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, -5)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nro Comprobante"
        '
        'cboTipoComprobante
        '
        Me.cboTipoComprobante.FormattingEnabled = True
        Me.cboTipoComprobante.Location = New System.Drawing.Point(27, 196)
        Me.cboTipoComprobante.Margin = New System.Windows.Forms.Padding(5)
        Me.cboTipoComprobante.Name = "cboTipoComprobante"
        Me.cboTipoComprobante.Size = New System.Drawing.Size(141, 32)
        Me.cboTipoComprobante.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 143)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 48)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipo de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "comprobante:"
        '
        'dtFechaComprobante
        '
        Me.dtFechaComprobante.Location = New System.Drawing.Point(27, 56)
        Me.dtFechaComprobante.Margin = New System.Windows.Forms.Padding(5)
        Me.dtFechaComprobante.Name = "dtFechaComprobante"
        Me.dtFechaComprobante.Size = New System.Drawing.Size(253, 29)
        Me.dtFechaComprobante.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha de ingreso:"
        '
        'frmIngesoComprobante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(684, 651)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.ForeColor = System.Drawing.Color.Gainsboro
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmIngesoComprobante"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "frmIngesoComprobante"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cboTiposGastos As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCargarComprobante As Button
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtComprobante2 As TextBox
    Friend WithEvents txtComprobante1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboTipoComprobante As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtFechaComprobante As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMontoTotal As TextBox
    Friend WithEvents Label7 As Label
End Class
