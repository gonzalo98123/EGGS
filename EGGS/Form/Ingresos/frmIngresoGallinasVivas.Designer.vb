<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresoGallinasVivas
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
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.dtFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingreso de gallinas:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(135, 32)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(151, 20)
        Me.txtCantidad.TabIndex = 2
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(211, 93)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'dtFechaIngreso
        '
        Me.dtFechaIngreso.Location = New System.Drawing.Point(135, 58)
        Me.dtFechaIngreso.Name = "dtFechaIngreso"
        Me.dtFechaIngreso.Size = New System.Drawing.Size(151, 20)
        Me.dtFechaIngreso.TabIndex = 5
        '
        'frmIngresoGallinasVivas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 140)
        Me.Controls.Add(Me.dtFechaIngreso)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmIngresoGallinasVivas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmIngresoGallinasVivas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents dtFechaIngreso As DateTimePicker
End Class
