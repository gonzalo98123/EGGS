<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPendientesPagos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dgvPendientesPagos = New System.Windows.Forms.DataGridView()
        Me.IdMovimientoHuevosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaMovimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RazonSocialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwMovimientosPendientesPagosBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EGGS1DataSet3 = New EGGS.EGGS1DataSet3()
        Me.VwMovimientosPendientesPagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnPagado = New System.Windows.Forms.Button()
        Me.VwComprobantesCajaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EGGSDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwEgresoHuevosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EGGS1DataSet2 = New EGGS.EGGS1DataSet2()
        Me.VwMovimientosPendientesPagosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_MovimientosPendientesPagosTableAdapter = New EGGS.EGGS1DataSet2TableAdapters.vw_MovimientosPendientesPagosTableAdapter()
        Me.Vw_MovimientosPendientesPagosTableAdapter1 = New EGGS.EGGS1DataSet3TableAdapters.vw_MovimientosPendientesPagosTableAdapter()
        CType(Me.dgvPendientesPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwMovimientosPendientesPagosBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EGGS1DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwMovimientosPendientesPagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwComprobantesCajaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EGGSDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwEgresoHuevosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EGGS1DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwMovimientosPendientesPagosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPendientesPagos
        '
        Me.dgvPendientesPagos.AllowUserToAddRows = False
        Me.dgvPendientesPagos.AllowUserToDeleteRows = False
        Me.dgvPendientesPagos.AutoGenerateColumns = False
        Me.dgvPendientesPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPendientesPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdMovimientoHuevosDataGridViewTextBoxColumn, Me.FechaMovimientoDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.ObservacionDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn2, Me.RazonSocialDataGridViewTextBoxColumn, Me.NombreApellidoDataGridViewTextBoxColumn})
        Me.dgvPendientesPagos.DataSource = Me.VwMovimientosPendientesPagosBindingSource2
        Me.dgvPendientesPagos.Location = New System.Drawing.Point(13, 13)
        Me.dgvPendientesPagos.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvPendientesPagos.Name = "dgvPendientesPagos"
        Me.dgvPendientesPagos.ReadOnly = True
        Me.dgvPendientesPagos.Size = New System.Drawing.Size(928, 265)
        Me.dgvPendientesPagos.TabIndex = 0
        '
        'IdMovimientoHuevosDataGridViewTextBoxColumn
        '
        Me.IdMovimientoHuevosDataGridViewTextBoxColumn.DataPropertyName = "IdMovimientoHuevos"
        Me.IdMovimientoHuevosDataGridViewTextBoxColumn.HeaderText = "IdMovimientoHuevos"
        Me.IdMovimientoHuevosDataGridViewTextBoxColumn.Name = "IdMovimientoHuevosDataGridViewTextBoxColumn"
        Me.IdMovimientoHuevosDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdMovimientoHuevosDataGridViewTextBoxColumn.Width = 5
        '
        'FechaMovimientoDataGridViewTextBoxColumn
        '
        Me.FechaMovimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaMovimiento"
        Me.FechaMovimientoDataGridViewTextBoxColumn.HeaderText = "FechaMovimiento"
        Me.FechaMovimientoDataGridViewTextBoxColumn.Name = "FechaMovimientoDataGridViewTextBoxColumn"
        Me.FechaMovimientoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ObservacionDataGridViewTextBoxColumn
        '
        Me.ObservacionDataGridViewTextBoxColumn.DataPropertyName = "Observacion"
        Me.ObservacionDataGridViewTextBoxColumn.HeaderText = "Observacion"
        Me.ObservacionDataGridViewTextBoxColumn.Name = "ObservacionDataGridViewTextBoxColumn"
        Me.ObservacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PrecioVenta"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PrecioVenta"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'RazonSocialDataGridViewTextBoxColumn
        '
        Me.RazonSocialDataGridViewTextBoxColumn.DataPropertyName = "RazonSocial"
        Me.RazonSocialDataGridViewTextBoxColumn.HeaderText = "RazonSocial"
        Me.RazonSocialDataGridViewTextBoxColumn.Name = "RazonSocialDataGridViewTextBoxColumn"
        Me.RazonSocialDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreApellidoDataGridViewTextBoxColumn
        '
        Me.NombreApellidoDataGridViewTextBoxColumn.DataPropertyName = "NombreApellido"
        Me.NombreApellidoDataGridViewTextBoxColumn.HeaderText = "NombreApellido"
        Me.NombreApellidoDataGridViewTextBoxColumn.Name = "NombreApellidoDataGridViewTextBoxColumn"
        Me.NombreApellidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VwMovimientosPendientesPagosBindingSource2
        '
        Me.VwMovimientosPendientesPagosBindingSource2.DataMember = "vw_MovimientosPendientesPagos"
        Me.VwMovimientosPendientesPagosBindingSource2.DataSource = Me.EGGS1DataSet3
        '
        'EGGS1DataSet3
        '
        Me.EGGS1DataSet3.DataSetName = "EGGS1DataSet3"
        Me.EGGS1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwMovimientosPendientesPagosBindingSource
        '
        Me.VwMovimientosPendientesPagosBindingSource.DataMember = "vw_MovimientosPendientesPagos"
        '
        'btnPagado
        '
        Me.btnPagado.ForeColor = System.Drawing.Color.Black
        Me.btnPagado.Location = New System.Drawing.Point(703, 286)
        Me.btnPagado.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPagado.Name = "btnPagado"
        Me.btnPagado.Size = New System.Drawing.Size(238, 32)
        Me.btnPagado.TabIndex = 1
        Me.btnPagado.Text = "Marcar como pagado"
        Me.btnPagado.UseVisualStyleBackColor = True
        '
        'EGGS1DataSet2
        '
        Me.EGGS1DataSet2.DataSetName = "EGGS1DataSet2"
        Me.EGGS1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwMovimientosPendientesPagosBindingSource1
        '
        Me.VwMovimientosPendientesPagosBindingSource1.DataMember = "vw_MovimientosPendientesPagos"
        Me.VwMovimientosPendientesPagosBindingSource1.DataSource = Me.EGGS1DataSet2
        '
        'Vw_MovimientosPendientesPagosTableAdapter
        '
        Me.Vw_MovimientosPendientesPagosTableAdapter.ClearBeforeFill = True
        '
        'Vw_MovimientosPendientesPagosTableAdapter1
        '
        Me.Vw_MovimientosPendientesPagosTableAdapter1.ClearBeforeFill = True
        '
        'frmPendientesPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(951, 329)
        Me.Controls.Add(Me.btnPagado)
        Me.Controls.Add(Me.dgvPendientesPagos)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.ForeColor = System.Drawing.Color.Gainsboro
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPendientesPagos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPendientesPagos"
        CType(Me.dgvPendientesPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwMovimientosPendientesPagosBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EGGS1DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwMovimientosPendientesPagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwComprobantesCajaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EGGSDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwEgresoHuevosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EGGS1DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwMovimientosPendientesPagosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvPendientesPagos As DataGridView
    Friend WithEvents btnPagado As Button
    Friend WithEvents EGGS1DataSet As EGGS1DataSet
    Friend WithEvents VwComprobantesCajaBindingSource As BindingSource
    Friend WithEvents EGGSDataSetBindingSource As BindingSource
    Friend WithEvents VwEgresoHuevosBindingSource As BindingSource
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioVentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VwMovimientosPendientesPagosBindingSource As BindingSource
    Friend WithEvents EGGS1DataSet2 As EGGS1DataSet2
    Friend WithEvents VwMovimientosPendientesPagosBindingSource1 As BindingSource
    Friend WithEvents Vw_MovimientosPendientesPagosTableAdapter As EGGS1DataSet2TableAdapters.vw_MovimientosPendientesPagosTableAdapter
    Friend WithEvents EGGS1DataSet3 As EGGS1DataSet3
    Friend WithEvents VwMovimientosPendientesPagosBindingSource2 As BindingSource
    Friend WithEvents Vw_MovimientosPendientesPagosTableAdapter1 As EGGS1DataSet3TableAdapters.vw_MovimientosPendientesPagosTableAdapter
    Friend WithEvents IdMovimientoHuevosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaMovimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ObservacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents RazonSocialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
