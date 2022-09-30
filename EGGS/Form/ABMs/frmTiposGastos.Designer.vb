<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTiposGastos
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
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTipoGasto = New System.Windows.Forms.TextBox()
        Me.lstTiposGastos = New System.Windows.Forms.ListBox()
        Me.pnlDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(138, 241)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 9
        Me.btnEditar.Text = "Modificar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(138, 212)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(138, 183)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'pnlDatos
        '
        Me.pnlDatos.Controls.Add(Me.txtDetalle)
        Me.pnlDatos.Controls.Add(Me.Label4)
        Me.pnlDatos.Controls.Add(Me.btnCancelar)
        Me.pnlDatos.Controls.Add(Me.btnAceptar)
        Me.pnlDatos.Controls.Add(Me.Label1)
        Me.pnlDatos.Controls.Add(Me.txtTipoGasto)
        Me.pnlDatos.Enabled = False
        Me.pnlDatos.Location = New System.Drawing.Point(138, 12)
        Me.pnlDatos.Name = "pnlDatos"
        Me.pnlDatos.Size = New System.Drawing.Size(279, 165)
        Me.pnlDatos.TabIndex = 6
        '
        'txtDetalle
        '
        Me.txtDetalle.Location = New System.Drawing.Point(58, 43)
        Me.txtDetalle.Multiline = True
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(194, 77)
        Me.txtDetalle.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Obs:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(201, 126)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        Me.btnCancelar.Visible = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(120, 126)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 8
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        Me.btnAceptar.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre:"
        '
        'txtTipoGasto
        '
        Me.txtTipoGasto.Location = New System.Drawing.Point(58, 17)
        Me.txtTipoGasto.Name = "txtTipoGasto"
        Me.txtTipoGasto.Size = New System.Drawing.Size(194, 20)
        Me.txtTipoGasto.TabIndex = 0
        '
        'lstTiposGastos
        '
        Me.lstTiposGastos.FormattingEnabled = True
        Me.lstTiposGastos.Location = New System.Drawing.Point(12, 12)
        Me.lstTiposGastos.Name = "lstTiposGastos"
        Me.lstTiposGastos.Size = New System.Drawing.Size(120, 251)
        Me.lstTiposGastos.TabIndex = 5
        '
        'frmTiposGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 278)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.pnlDatos)
        Me.Controls.Add(Me.lstTiposGastos)
        Me.Name = "frmTiposGastos"
        Me.Text = "frmTiposGastos"
        Me.pnlDatos.ResumeLayout(False)
        Me.pnlDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents pnlDatos As Panel
    Friend WithEvents txtDetalle As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTipoGasto As TextBox
    Friend WithEvents lstTiposGastos As ListBox
End Class
