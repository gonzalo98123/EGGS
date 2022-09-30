<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.pnlDatos = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.lstClientes = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.pnlDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(12, 350)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 9
        Me.btnEditar.Text = "Modificar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(12, 379)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(12, 321)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'pnlDatos
        '
        Me.pnlDatos.Controls.Add(Me.Label5)
        Me.pnlDatos.Controls.Add(Me.txtDireccion)
        Me.pnlDatos.Controls.Add(Me.Label4)
        Me.pnlDatos.Controls.Add(Me.txtObservaciones)
        Me.pnlDatos.Controls.Add(Me.btnCancelar)
        Me.pnlDatos.Controls.Add(Me.btnAceptar)
        Me.pnlDatos.Controls.Add(Me.Label2)
        Me.pnlDatos.Controls.Add(Me.Label3)
        Me.pnlDatos.Controls.Add(Me.Label1)
        Me.pnlDatos.Controls.Add(Me.txtMail)
        Me.pnlDatos.Controls.Add(Me.txtTelefono)
        Me.pnlDatos.Controls.Add(Me.txtRazonSocial)
        Me.pnlDatos.Enabled = False
        Me.pnlDatos.Location = New System.Drawing.Point(138, 12)
        Me.pnlDatos.Name = "pnlDatos"
        Me.pnlDatos.Size = New System.Drawing.Size(323, 303)
        Me.pnlDatos.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Observaciones:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(109, 129)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(194, 109)
        Me.txtObservaciones.TabIndex = 10
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(232, 244)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        Me.btnCancelar.Visible = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(151, 244)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 8
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        Me.btnAceptar.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Mail:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Telefono:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Razon social:"
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(112, 72)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(194, 20)
        Me.txtMail.TabIndex = 2
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(112, 46)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(194, 20)
        Me.txtTelefono.TabIndex = 1
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Location = New System.Drawing.Point(112, 16)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(194, 20)
        Me.txtRazonSocial.TabIndex = 0
        '
        'lstClientes
        '
        Me.lstClientes.FormattingEnabled = True
        Me.lstClientes.Location = New System.Drawing.Point(12, 12)
        Me.lstClientes.Name = "lstClientes"
        Me.lstClientes.Size = New System.Drawing.Size(120, 303)
        Me.lstClientes.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Direccion:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(112, 98)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(194, 20)
        Me.txtDireccion.TabIndex = 12
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 418)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.pnlDatos)
        Me.Controls.Add(Me.lstClientes)
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmClientes"
        Me.pnlDatos.ResumeLayout(False)
        Me.pnlDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents pnlDatos As Panel
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMail As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtRazonSocial As TextBox
    Friend WithEvents lstClientes As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDireccion As TextBox
End Class
