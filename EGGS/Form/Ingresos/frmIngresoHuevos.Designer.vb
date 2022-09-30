<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresoHuevos
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
        Me.dtFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha de ingreso:"
        '
        'dtFechaIngreso
        '
        Me.dtFechaIngreso.Location = New System.Drawing.Point(117, 7)
        Me.dtFechaIngreso.Name = "dtFechaIngreso"
        Me.dtFechaIngreso.Size = New System.Drawing.Size(125, 20)
        Me.dtFechaIngreso.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cantidad:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(80, 38)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(79, 20)
        Me.txtCantidad.TabIndex = 3
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(178, 41)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(75, 23)
        Me.btnIngresar.TabIndex = 4
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'frmIngresoHuevos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 87)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtFechaIngreso)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmIngresoHuevos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmIngresoHuevos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtFechaIngreso As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents btnIngresar As Button
End Class
