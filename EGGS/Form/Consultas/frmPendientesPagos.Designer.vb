<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPendientesPagos
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
        Me.dgvPendientesPagos = New System.Windows.Forms.DataGridView()
        CType(Me.dgvPendientesPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPendientesPagos
        '
        Me.dgvPendientesPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPendientesPagos.Location = New System.Drawing.Point(12, 88)
        Me.dgvPendientesPagos.Name = "dgvPendientesPagos"
        Me.dgvPendientesPagos.Size = New System.Drawing.Size(498, 246)
        Me.dgvPendientesPagos.TabIndex = 0
        '
        'frmPendientesPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 486)
        Me.Controls.Add(Me.dgvPendientesPagos)
        Me.Name = "frmPendientesPagos"
        Me.Text = "frmPendientesPagos"
        CType(Me.dgvPendientesPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvPendientesPagos As DataGridView
End Class
