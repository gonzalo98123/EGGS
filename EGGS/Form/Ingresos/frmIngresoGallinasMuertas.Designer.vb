<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresoGallinasMuertas
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
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.dtFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese la cantidad de gallinas muertas:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(226, 27)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(110, 20)
        Me.txtCantidad.TabIndex = 1
        '
        'dtFechaIngreso
        '
        Me.dtFechaIngreso.Location = New System.Drawing.Point(226, 63)
        Me.dtFechaIngreso.Name = "dtFechaIngreso"
        Me.dtFechaIngreso.Size = New System.Drawing.Size(110, 20)
        Me.dtFechaIngreso.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(180, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha:"
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(261, 89)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(75, 23)
        Me.btnIngresar.TabIndex = 4
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'frmIngresoGallinasMuertas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 135)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtFechaIngreso)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmIngresoGallinasMuertas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmIngresoGallinasMuertas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents dtFechaIngreso As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents btnIngresar As Button
End Class
