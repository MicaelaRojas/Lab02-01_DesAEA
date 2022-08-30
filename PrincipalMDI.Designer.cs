namespace Lab02_01
{
    partial class PrincipalMDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepoRventas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepoRcompras = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepoIproductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepoRproveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepoRusuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepoRclientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManUsuarios,
            this.mnuManProductos,
            this.mnuManCategorias,
            this.mnuManProveedores,
            this.mnuManClientes});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            this.mantenimientoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProVenta,
            this.mnuProCompra});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRepoRventas,
            this.mnuRepoRcompras,
            this.mnuRepoIproductos,
            this.mnuRepoRproveedores,
            this.mnuRepoRusuarios,
            this.mnuRepoRclientes});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirDelSistemaToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // mnuManUsuarios
            // 
            this.mnuManUsuarios.Name = "mnuManUsuarios";
            this.mnuManUsuarios.Size = new System.Drawing.Size(180, 22);
            this.mnuManUsuarios.Text = "Usuarios";
            this.mnuManUsuarios.Click += new System.EventHandler(this.mnuManUsuarios_Click);
            // 
            // mnuManProductos
            // 
            this.mnuManProductos.Name = "mnuManProductos";
            this.mnuManProductos.Size = new System.Drawing.Size(180, 22);
            this.mnuManProductos.Text = "Productos";
            // 
            // mnuManCategorias
            // 
            this.mnuManCategorias.Name = "mnuManCategorias";
            this.mnuManCategorias.Size = new System.Drawing.Size(180, 22);
            this.mnuManCategorias.Text = "Categorías";
            // 
            // mnuManProveedores
            // 
            this.mnuManProveedores.Name = "mnuManProveedores";
            this.mnuManProveedores.Size = new System.Drawing.Size(180, 22);
            this.mnuManProveedores.Text = "Proveedores";
            // 
            // mnuManClientes
            // 
            this.mnuManClientes.Name = "mnuManClientes";
            this.mnuManClientes.Size = new System.Drawing.Size(180, 22);
            this.mnuManClientes.Text = "Clientes";
            // 
            // mnuProVenta
            // 
            this.mnuProVenta.Name = "mnuProVenta";
            this.mnuProVenta.Size = new System.Drawing.Size(180, 22);
            this.mnuProVenta.Text = "Registrar Venta";
            // 
            // mnuProCompra
            // 
            this.mnuProCompra.Name = "mnuProCompra";
            this.mnuProCompra.Size = new System.Drawing.Size(180, 22);
            this.mnuProCompra.Text = "Registrar Compra";
            // 
            // mnuRepoRventas
            // 
            this.mnuRepoRventas.Name = "mnuRepoRventas";
            this.mnuRepoRventas.Size = new System.Drawing.Size(200, 22);
            this.mnuRepoRventas.Text = "Reporte de ventas";
            // 
            // mnuRepoRcompras
            // 
            this.mnuRepoRcompras.Name = "mnuRepoRcompras";
            this.mnuRepoRcompras.Size = new System.Drawing.Size(200, 22);
            this.mnuRepoRcompras.Text = "Reporte de compras";
            // 
            // mnuRepoIproductos
            // 
            this.mnuRepoIproductos.Name = "mnuRepoIproductos";
            this.mnuRepoIproductos.Size = new System.Drawing.Size(200, 22);
            this.mnuRepoIproductos.Text = "Inventario de productos";
            // 
            // mnuRepoRproveedores
            // 
            this.mnuRepoRproveedores.Name = "mnuRepoRproveedores";
            this.mnuRepoRproveedores.Size = new System.Drawing.Size(200, 22);
            this.mnuRepoRproveedores.Text = "Reporte de proveedores";
            // 
            // mnuRepoRusuarios
            // 
            this.mnuRepoRusuarios.Name = "mnuRepoRusuarios";
            this.mnuRepoRusuarios.Size = new System.Drawing.Size(200, 22);
            this.mnuRepoRusuarios.Text = "Reporte de usuarios";
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            this.salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            this.salirDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirDelSistemaToolStripMenuItem.Text = "Salir del sistema";
            this.salirDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.salirDelSistemaToolStripMenuItem_Click);
            // 
            // mnuRepoRclientes
            // 
            this.mnuRepoRclientes.Name = "mnuRepoRclientes";
            this.mnuRepoRclientes.Size = new System.Drawing.Size(200, 22);
            this.mnuRepoRclientes.Text = "Reporte de clientes";
            // 
            // PrincipalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel principal";
            this.Load += new System.EventHandler(this.PrincipalMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuManUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuManProductos;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuManCategorias;
        private System.Windows.Forms.ToolStripMenuItem mnuManProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuManClientes;
        private System.Windows.Forms.ToolStripMenuItem mnuProVenta;
        private System.Windows.Forms.ToolStripMenuItem mnuProCompra;
        private System.Windows.Forms.ToolStripMenuItem mnuRepoRventas;
        private System.Windows.Forms.ToolStripMenuItem mnuRepoRcompras;
        private System.Windows.Forms.ToolStripMenuItem mnuRepoIproductos;
        private System.Windows.Forms.ToolStripMenuItem mnuRepoRproveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuRepoRusuarios;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuRepoRclientes;
    }
}