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
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwMovimientosPendientesPagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnPagado = New System.Windows.Forms.Button()
        Me.VwComprobantesCajaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EGGSDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwEgresoHuevosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvPendientesPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwMovimientosPendientesPagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwComprobantesCajaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EGGSDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwEgresoHuevosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPendientesPagos
        '
        Me.dgvPendientesPagos.AutoGenerateColumns = False
        Me.dgvPendientesPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPendientesPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CantidadDataGridViewTextBoxColumn, Me.PrecioVentaDataGridViewTextBoxColumn})
        Me.dgvPendientesPagos.DataSource = Me.VwMovimientosPendientesPagosBindingSource
        Me.dgvPendientesPagos.Location = New System.Drawing.Point(13, 13)
        Me.dgvPendientesPagos.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvPendientesPagos.Name = "dgvPendientesPagos"
        Me.dgvPendientesPagos.Size = New System.Drawing.Size(928, 265)
        Me.dgvPendientesPagos.TabIndex = 0
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        '
        'PrecioVentaDataGridViewTextBoxColumn
        '
        Me.PrecioVentaDataGridViewTextBoxColumn.DataPropertyName = "PrecioVenta"
        Me.PrecioVentaDataGridViewTextBoxColumn.HeaderText = "PrecioVenta"
        Me.PrecioVentaDataGridViewTextBoxColumn.Name = "PrecioVentaDataGridViewTextBoxColumn"
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
        Me.Name = "frmPendientesPagos"
        Me.Text = "frmPendientesPagos"
        CType(Me.dgvPendientesPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwMovimientosPendientesPagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwComprobantesCajaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EGGSDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwEgresoHuevosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
