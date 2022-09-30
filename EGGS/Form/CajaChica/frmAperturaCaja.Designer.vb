<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAperturaCaja
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
        Me.cboUsers = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.btnAbrirCaja = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'cboUsers
        '
        Me.cboUsers.FormattingEnabled = True
        Me.cboUsers.Location = New System.Drawing.Point(61, 24)
        Me.cboUsers.Name = "cboUsers"
        Me.cboUsers.Size = New System.Drawing.Size(207, 21)
        Me.cboUsers.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.ForeColor = System.Drawing.Color.Red
        Me.lblFecha.Location = New System.Drawing.Point(58, 95)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(39, 13)
        Me.lblFecha.TabIndex = 3
        Me.lblFecha.Text = "Label3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 26)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Monto de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "apertura:"
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(61, 59)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(84, 20)
        Me.txtMonto.TabIndex = 5
        '
        'btnAbrirCaja
        '
        Me.btnAbrirCaja.Location = New System.Drawing.Point(193, 122)
        Me.btnAbrirCaja.Name = "btnAbrirCaja"
        Me.btnAbrirCaja.Size = New System.Drawing.Size(75, 23)
        Me.btnAbrirCaja.TabIndex = 6
        Me.btnAbrirCaja.Text = "Abrir caja"
        Me.btnAbrirCaja.UseVisualStyleBackColor = True
        '
        'frmAperturaCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 166)
        Me.Controls.Add(Me.btnAbrirCaja)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboUsers)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAperturaCaja"
        Me.Text = "AperturaCaja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboUsers As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents btnAbrirCaja As Button
End Class
