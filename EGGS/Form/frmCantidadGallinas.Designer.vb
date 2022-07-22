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
        Me.Label1.Location = New System.Drawing.Point(21, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gallinas vivas:"
        '
        'lblCantidadVivas
        '
        Me.lblCantidadVivas.AutoSize = True
        Me.lblCantidadVivas.Location = New System.Drawing.Point(102, 22)
        Me.lblCantidadVivas.Name = "lblCantidadVivas"
        Me.lblCantidadVivas.Size = New System.Drawing.Size(39, 13)
        Me.lblCantidadVivas.TabIndex = 2
        Me.lblCantidadVivas.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ultima carga el:"
        '
        'lblUltimaCarga
        '
        Me.lblUltimaCarga.AutoSize = True
        Me.lblUltimaCarga.Location = New System.Drawing.Point(105, 65)
        Me.lblUltimaCarga.Name = "lblUltimaCarga"
        Me.lblUltimaCarga.Size = New System.Drawing.Size(39, 13)
        Me.lblUltimaCarga.TabIndex = 4
        Me.lblUltimaCarga.Text = "Label3"
        '
        'frmCantidadGallinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 151)
        Me.Controls.Add(Me.lblUltimaCarga)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCantidadVivas)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCantidadGallinas"
        Me.Text = "frmCantidadGallinas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblCantidadVivas As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblUltimaCarga As Label
End Class
