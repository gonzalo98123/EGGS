<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AvicolaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GallinasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresoDeGallinasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarGallinasMuertasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarCantidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HuevosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresoHuevosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarvenderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarEgresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosPendientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposDeGastosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CajaChicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AperturaDeCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresoDeComprobantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CierreDeCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AvicolaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(11, 4, 0, 4)
        Me.MenuStrip1.Size = New System.Drawing.Size(1744, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AvicolaToolStripMenuItem
        '
        Me.AvicolaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GallinasToolStripMenuItem, Me.HuevosToolStripMenuItem, Me.VendedoresToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.TiposDeGastosToolStripMenuItem, Me.CajaChicaToolStripMenuItem})
        Me.AvicolaToolStripMenuItem.Name = "AvicolaToolStripMenuItem"
        Me.AvicolaToolStripMenuItem.Size = New System.Drawing.Size(58, 19)
        Me.AvicolaToolStripMenuItem.Text = "Avicola"
        '
        'GallinasToolStripMenuItem
        '
        Me.GallinasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresoDeGallinasToolStripMenuItem, Me.IngresarGallinasMuertasToolStripMenuItem, Me.ConsultarCantidadToolStripMenuItem})
        Me.GallinasToolStripMenuItem.Name = "GallinasToolStripMenuItem"
        Me.GallinasToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.GallinasToolStripMenuItem.Text = "Gallinas"
        '
        'IngresoDeGallinasToolStripMenuItem
        '
        Me.IngresoDeGallinasToolStripMenuItem.Name = "IngresoDeGallinasToolStripMenuItem"
        Me.IngresoDeGallinasToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.IngresoDeGallinasToolStripMenuItem.Text = "Ingreso de gallinas"
        '
        'IngresarGallinasMuertasToolStripMenuItem
        '
        Me.IngresarGallinasMuertasToolStripMenuItem.Name = "IngresarGallinasMuertasToolStripMenuItem"
        Me.IngresarGallinasMuertasToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.IngresarGallinasMuertasToolStripMenuItem.Text = "Ingresar gallinas muertas"
        '
        'ConsultarCantidadToolStripMenuItem
        '
        Me.ConsultarCantidadToolStripMenuItem.Name = "ConsultarCantidadToolStripMenuItem"
        Me.ConsultarCantidadToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.ConsultarCantidadToolStripMenuItem.Text = "Consultar cantidad"
        '
        'HuevosToolStripMenuItem
        '
        Me.HuevosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarStockToolStripMenuItem, Me.IngresoHuevosToolStripMenuItem, Me.ExportarvenderToolStripMenuItem, Me.ConsultarEgresosToolStripMenuItem, Me.PagosPendientesToolStripMenuItem})
        Me.HuevosToolStripMenuItem.Name = "HuevosToolStripMenuItem"
        Me.HuevosToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.HuevosToolStripMenuItem.Text = "Huevos"
        '
        'ConsultarStockToolStripMenuItem
        '
        Me.ConsultarStockToolStripMenuItem.Name = "ConsultarStockToolStripMenuItem"
        Me.ConsultarStockToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ConsultarStockToolStripMenuItem.Text = "Consultar stock"
        '
        'IngresoHuevosToolStripMenuItem
        '
        Me.IngresoHuevosToolStripMenuItem.Name = "IngresoHuevosToolStripMenuItem"
        Me.IngresoHuevosToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.IngresoHuevosToolStripMenuItem.Text = "Ingreso huevos"
        '
        'ExportarvenderToolStripMenuItem
        '
        Me.ExportarvenderToolStripMenuItem.Name = "ExportarvenderToolStripMenuItem"
        Me.ExportarvenderToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ExportarvenderToolStripMenuItem.Text = "Exportar/vender"
        '
        'ConsultarEgresosToolStripMenuItem
        '
        Me.ConsultarEgresosToolStripMenuItem.Name = "ConsultarEgresosToolStripMenuItem"
        Me.ConsultarEgresosToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ConsultarEgresosToolStripMenuItem.Text = "Consultar Egresos"
        '
        'PagosPendientesToolStripMenuItem
        '
        Me.PagosPendientesToolStripMenuItem.Name = "PagosPendientesToolStripMenuItem"
        Me.PagosPendientesToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.PagosPendientesToolStripMenuItem.Text = "Pagos pendientes"
        '
        'VendedoresToolStripMenuItem
        '
        Me.VendedoresToolStripMenuItem.Name = "VendedoresToolStripMenuItem"
        Me.VendedoresToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.VendedoresToolStripMenuItem.Text = "Vendedores"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'TiposDeGastosToolStripMenuItem
        '
        Me.TiposDeGastosToolStripMenuItem.Name = "TiposDeGastosToolStripMenuItem"
        Me.TiposDeGastosToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.TiposDeGastosToolStripMenuItem.Text = "Tipos de gastos"
        '
        'CajaChicaToolStripMenuItem
        '
        Me.CajaChicaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AperturaDeCajaToolStripMenuItem, Me.IngresoDeComprobantesToolStripMenuItem, Me.CierreDeCajaToolStripMenuItem})
        Me.CajaChicaToolStripMenuItem.Name = "CajaChicaToolStripMenuItem"
        Me.CajaChicaToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.CajaChicaToolStripMenuItem.Text = "Caja chica"
        '
        'AperturaDeCajaToolStripMenuItem
        '
        Me.AperturaDeCajaToolStripMenuItem.Name = "AperturaDeCajaToolStripMenuItem"
        Me.AperturaDeCajaToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.AperturaDeCajaToolStripMenuItem.Text = "Apertura de caja"
        '
        'IngresoDeComprobantesToolStripMenuItem
        '
        Me.IngresoDeComprobantesToolStripMenuItem.Name = "IngresoDeComprobantesToolStripMenuItem"
        Me.IngresoDeComprobantesToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.IngresoDeComprobantesToolStripMenuItem.Text = "Ingreso de comprobantes"
        '
        'CierreDeCajaToolStripMenuItem
        '
        Me.CierreDeCajaToolStripMenuItem.Name = "CierreDeCajaToolStripMenuItem"
        Me.CierreDeCajaToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.CierreDeCajaToolStripMenuItem.Text = "Cierre de caja"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1744, 1057)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EGGS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
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
    Friend WithEvents IngresoDeGallinasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HuevosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarStockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportarvenderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresoHuevosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarEgresosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CajaChicaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AperturaDeCajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TiposDeGastosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresoDeComprobantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CierreDeCajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagosPendientesToolStripMenuItem As ToolStripMenuItem
End Class
