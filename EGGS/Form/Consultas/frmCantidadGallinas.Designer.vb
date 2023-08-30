<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCantidadGallinas
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
        Me.lblCantidadVivas = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblUltimaCarga = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(68, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gallinas vivas:"
        '
        'lblCantidadVivas
        '
        Me.lblCantidadVivas.AutoSize = True
        Me.lblCantidadVivas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lblCantidadVivas.ForeColor = System.Drawing.Color.DarkRed
        Me.lblCantidadVivas.Location = New System.Drawing.Point(205, 35)
        Me.lblCantidadVivas.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblCantidadVivas.Name = "lblCantidadVivas"
        Me.lblCantidadVivas.Size = New System.Drawing.Size(66, 24)
        Me.lblCantidadVivas.TabIndex = 2
        Me.lblCantidadVivas.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(57, 73)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ultima carga el:"
        '
        'lblUltimaCarga
        '
        Me.lblUltimaCarga.AutoSize = True
        Me.lblUltimaCarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lblUltimaCarga.ForeColor = System.Drawing.Color.DarkRed
        Me.lblUltimaCarga.Location = New System.Drawing.Point(205, 73)
        Me.lblUltimaCarga.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblUltimaCarga.Name = "lblUltimaCarga"
        Me.lblUltimaCarga.Size = New System.Drawing.Size(66, 24)
        Me.lblUltimaCarga.TabIndex = 4
        Me.lblUltimaCarga.Text = "Label3"
        '
        'frmCantidadGallinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(416, 145)
        Me.Controls.Add(Me.lblUltimaCarga)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCantidadVivas)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.ForeColor = System.Drawing.Color.Gainsboro
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCantidadGallinas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cantidad de Gallinas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblCantidadVivas As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblUltimaCarga As Label
End Class
