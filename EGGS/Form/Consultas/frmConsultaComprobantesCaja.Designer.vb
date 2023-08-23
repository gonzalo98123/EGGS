<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaComprobantesCaja
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwComprobantesCajaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EGGS1DataSet = New EGGS.EGGS1DataSet()
        Me.EGGSDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EGGS1DataSetComprobantes = New EGGS.EGGS1DataSetComprobantes()
        Me.VwComprobantesCajaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_ComprobantesCajaTableAdapter = New EGGS.EGGS1DataSetComprobantesTableAdapters.vw_ComprobantesCajaTableAdapter()
        Me.FechaComprobanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoComprobanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComprobanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwComprobantesCajaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EGGS1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EGGSDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EGGS1DataSetComprobantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwComprobantesCajaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(367, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COMPROBANTES DE CAJA"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tipo, Me.FechaComprobanteDataGridViewTextBoxColumn, Me.TipoComprobanteDataGridViewTextBoxColumn, Me.ComprobanteDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VwComprobantesCajaBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(71, 92)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(902, 478)
        Me.DataGridView1.TabIndex = 1
        '
        'tipo
        '
        Me.tipo.DataPropertyName = "tipo"
        Me.tipo.HeaderText = "tipo"
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        '
        'VwComprobantesCajaBindingSource
        '
        Me.VwComprobantesCajaBindingSource.DataMember = "vw_ComprobantesCaja"
        Me.VwComprobantesCajaBindingSource.DataSource = Me.EGGS1DataSet
        '
        'EGGS1DataSet
        '
        Me.EGGS1DataSet.DataSetName = "EGGS1DataSet"
        Me.EGGS1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EGGS1DataSetComprobantes
        '
        Me.EGGS1DataSetComprobantes.DataSetName = "EGGS1DataSetComprobantes"
        Me.EGGS1DataSetComprobantes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwComprobantesCajaBindingSource1
        '
        Me.VwComprobantesCajaBindingSource1.DataMember = "vw_ComprobantesCaja"
        Me.VwComprobantesCajaBindingSource1.DataSource = Me.EGGS1DataSetComprobantes
        '
        'Vw_ComprobantesCajaTableAdapter
        '
        Me.Vw_ComprobantesCajaTableAdapter.ClearBeforeFill = True
        '
        'FechaComprobanteDataGridViewTextBoxColumn
        '
        Me.FechaComprobanteDataGridViewTextBoxColumn.DataPropertyName = "FechaComprobante"
        Me.FechaComprobanteDataGridViewTextBoxColumn.HeaderText = "FechaComprobante"
        Me.FechaComprobanteDataGridViewTextBoxColumn.Name = "FechaComprobanteDataGridViewTextBoxColumn"
        '
        'TipoComprobanteDataGridViewTextBoxColumn
        '
        Me.TipoComprobanteDataGridViewTextBoxColumn.DataPropertyName = "TipoComprobante"
        Me.TipoComprobanteDataGridViewTextBoxColumn.HeaderText = "TipoComprobante"
        Me.TipoComprobanteDataGridViewTextBoxColumn.Name = "TipoComprobanteDataGridViewTextBoxColumn"
        '
        'ComprobanteDataGridViewTextBoxColumn
        '
        Me.ComprobanteDataGridViewTextBoxColumn.DataPropertyName = "Comprobante"
        Me.ComprobanteDataGridViewTextBoxColumn.HeaderText = "Comprobante"
        Me.ComprobanteDataGridViewTextBoxColumn.Name = "ComprobanteDataGridViewTextBoxColumn"
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmConsultaComprobantesCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1026, 775)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.ForeColor = System.Drawing.Color.Gainsboro
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmConsultaComprobantesCaja"
        Me.Text = "frmConsultaComprobantesCaja"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EGGS1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EGGSDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EGGS1DataSetComprobantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwComprobantesCajaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents EGGSDataSetBindingSource As BindingSource
    Friend WithEvents EGGS1DataSet As EGGS1DataSet
    Friend WithEvents VwComprobantesCajaBindingSource As BindingSource
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents EGGS1DataSetComprobantes As EGGS1DataSetComprobantes
    Friend WithEvents VwComprobantesCajaBindingSource1 As BindingSource
    Friend WithEvents Vw_ComprobantesCajaTableAdapter As EGGS1DataSetComprobantesTableAdapters.vw_ComprobantesCajaTableAdapter
    Friend WithEvents FechaComprobanteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoComprobanteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ComprobanteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
