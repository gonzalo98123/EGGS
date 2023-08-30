<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaEgresoHuevos
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
        Me.components = New System.ComponentModel.Container()
        Me.dtvConsulta = New System.Windows.Forms.DataGridView()
        Me.VwEgresoHuevosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dtvConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwEgresoHuevosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtvConsulta
        '
        Me.dtvConsulta.AllowUserToAddRows = False
        Me.dtvConsulta.AllowUserToDeleteRows = False
        Me.dtvConsulta.AutoGenerateColumns = False
        Me.dtvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvConsulta.DataSource = Me.VwEgresoHuevosBindingSource
        Me.dtvConsulta.Location = New System.Drawing.Point(85, 13)
        Me.dtvConsulta.Margin = New System.Windows.Forms.Padding(4)
        Me.dtvConsulta.Name = "dtvConsulta"
        Me.dtvConsulta.ReadOnly = True
        Me.dtvConsulta.Size = New System.Drawing.Size(825, 367)
        Me.dtvConsulta.TabIndex = 0
        '
        'VwEgresoHuevosBindingSource
        '
        Me.VwEgresoHuevosBindingSource.DataMember = "vw_EgresoHuevos"
        '
        'frmConsultaEgresoHuevos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(999, 431)
        Me.Controls.Add(Me.dtvConsulta)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.ForeColor = System.Drawing.Color.Gainsboro
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsultaEgresoHuevos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConsultaEgresoHuevos"
        CType(Me.dtvConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwEgresoHuevosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtvConsulta As DataGridView
    Friend WithEvents VwEgresoHuevosBindingSource As BindingSource
    Friend WithEvents FechaIngresoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RazonSocialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioVentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
