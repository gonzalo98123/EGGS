<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AvicolaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GallinasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarCantidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarGallinasMuertasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AvicolaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(951, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AvicolaToolStripMenuItem
        '
        Me.AvicolaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GallinasToolStripMenuItem})
        Me.AvicolaToolStripMenuItem.Name = "AvicolaToolStripMenuItem"
        Me.AvicolaToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.AvicolaToolStripMenuItem.Text = "Avicola"
        '
        'GallinasToolStripMenuItem
        '
        Me.GallinasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarCantidadToolStripMenuItem, Me.IngresarGallinasMuertasToolStripMenuItem})
        Me.GallinasToolStripMenuItem.Name = "GallinasToolStripMenuItem"
        Me.GallinasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GallinasToolStripMenuItem.Text = "Gallinas"
        '
        'ConsultarCantidadToolStripMenuItem
        '
        Me.ConsultarCantidadToolStripMenuItem.Name = "ConsultarCantidadToolStripMenuItem"
        Me.ConsultarCantidadToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ConsultarCantidadToolStripMenuItem.Text = "Consultar cantidad"
        '
        'IngresarGallinasMuertasToolStripMenuItem
        '
        Me.IngresarGallinasMuertasToolStripMenuItem.Name = "IngresarGallinasMuertasToolStripMenuItem"
        Me.IngresarGallinasMuertasToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.IngresarGallinasMuertasToolStripMenuItem.Text = "Ingresar gallinas muertas"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 602)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.Text = "frmPrincipal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AvicolaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GallinasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarCantidadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresarGallinasMuertasToolStripMenuItem As ToolStripMenuItem
End Class
