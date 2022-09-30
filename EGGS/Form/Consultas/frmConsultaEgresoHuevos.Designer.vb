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
        Me.EGGSDataSet = New EGGS.EGGSDataSet()
        Me.VwEgresoHuevosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_EgresoHuevosTableAdapter = New EGGS.EGGSDataSetTableAdapters.vw_EgresoHuevosTableAdapter()
        Me.FechaIngresoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RazonSocialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtvConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EGGSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwEgresoHuevosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtvConsulta
        '
        Me.dtvConsulta.AllowUserToAddRows = False
        Me.dtvConsulta.AllowUserToDeleteRows = False
        Me.dtvConsulta.AutoGenerateColumns = False
        Me.dtvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvConsulta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaIngresoDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.NombreApellidoDataGridViewTextBoxColumn, Me.RazonSocialDataGridViewTextBoxColumn, Me.PrecioVentaDataGridViewTextBoxColumn})
        Me.dtvConsulta.DataSource = Me.VwEgresoHuevosBindingSource
        Me.dtvConsulta.Location = New System.Drawing.Point(12, 113)
        Me.dtvConsulta.Name = "dtvConsulta"
        Me.dtvConsulta.ReadOnly = True
        Me.dtvConsulta.Size = New System.Drawing.Size(550, 265)
        Me.dtvConsulta.TabIndex = 0
        '
        'EGGSDataSet
        '
        Me.EGGSDataSet.DataSetName = "EGGSDataSet"
        Me.EGGSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwEgresoHuevosBindingSource
        '
        Me.VwEgresoHuevosBindingSource.DataMember = "vw_EgresoHuevos"
        Me.VwEgresoHuevosBindingSource.DataSource = Me.EGGSDataSet
        '
        'Vw_EgresoHuevosTableAdapter
        '
        Me.Vw_EgresoHuevosTableAdapter.ClearBeforeFill = True
        '
        'FechaIngresoDataGridViewTextBoxColumn
        '
        Me.FechaIngresoDataGridViewTextBoxColumn.DataPropertyName = "FechaIngreso"
        Me.FechaIngresoDataGridViewTextBoxColumn.HeaderText = "FechaIngreso"
        Me.FechaIngresoDataGridViewTextBoxColumn.Name = "FechaIngresoDataGridViewTextBoxColumn"
        Me.FechaIngresoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreApellidoDataGridViewTextBoxColumn
        '
        Me.NombreApellidoDataGridViewTextBoxColumn.DataPropertyName = "NombreApellido"
        Me.NombreApellidoDataGridViewTextBoxColumn.HeaderText = "NombreApellido"
        Me.NombreApellidoDataGridViewTextBoxColumn.Name = "NombreApellidoDataGridViewTextBoxColumn"
        Me.NombreApellidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RazonSocialDataGridViewTextBoxColumn
        '
        Me.RazonSocialDataGridViewTextBoxColumn.DataPropertyName = "RazonSocial"
        Me.RazonSocialDataGridViewTextBoxColumn.HeaderText = "RazonSocial"
        Me.RazonSocialDataGridViewTextBoxColumn.Name = "RazonSocialDataGridViewTextBoxColumn"
        Me.RazonSocialDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioVentaDataGridViewTextBoxColumn
        '
        Me.PrecioVentaDataGridViewTextBoxColumn.DataPropertyName = "PrecioVenta"
        Me.PrecioVentaDataGridViewTextBoxColumn.HeaderText = "PrecioVenta"
        Me.PrecioVentaDataGridViewTextBoxColumn.Name = "PrecioVentaDataGridViewTextBoxColumn"
        Me.PrecioVentaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmConsultaEgresoHuevos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 390)
        Me.Controls.Add(Me.dtvConsulta)
        Me.Name = "frmConsultaEgresoHuevos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConsultaEgresoHuevos"
        CType(Me.dtvConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EGGSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwEgresoHuevosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtvConsulta As DataGridView
    Friend WithEvents EGGSDataSet As EGGSDataSet
    Friend WithEvents VwEgresoHuevosBindingSource As BindingSource
    Friend WithEvents Vw_EgresoHuevosTableAdapter As EGGSDataSetTableAdapters.vw_EgresoHuevosTableAdapter
    Friend WithEvents FechaIngresoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RazonSocialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioVentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
