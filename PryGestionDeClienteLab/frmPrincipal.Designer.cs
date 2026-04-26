namespace PryGestionDeClienteLab
{
    partial class frmManejoClientes
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
            this.msAgregarNuevosClientes = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeTodosLosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesDeudoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesOrdenadosPorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msAgregarNuevosClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // msAgregarNuevosClientes
            // 
            this.msAgregarNuevosClientes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msAgregarNuevosClientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.clientesToolStripMenuItem,
            this.ventasToolStripMenuItem});
            this.msAgregarNuevosClientes.Location = new System.Drawing.Point(0, 0);
            this.msAgregarNuevosClientes.Name = "msAgregarNuevosClientes";
            this.msAgregarNuevosClientes.Size = new System.Drawing.Size(566, 28);
            this.msAgregarNuevosClientes.TabIndex = 0;
            this.msAgregarNuevosClientes.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(75, 24);
            this.toolStripMenuItem1.Text = "Sistema";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevosClientesToolStripMenuItem,
            this.listadoDeTodosLosClientesToolStripMenuItem,
            this.listadoDeClientesDeudoresToolStripMenuItem,
            this.listadoDeClientesOrdenadosPorToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // agregarNuevosClientesToolStripMenuItem
            // 
            this.agregarNuevosClientesToolStripMenuItem.Name = "agregarNuevosClientesToolStripMenuItem";
            this.agregarNuevosClientesToolStripMenuItem.Size = new System.Drawing.Size(326, 26);
            this.agregarNuevosClientesToolStripMenuItem.Text = "Agregar nuevos clientes...";
            this.agregarNuevosClientesToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevosClientesToolStripMenuItem_Click);
            // 
            // listadoDeTodosLosClientesToolStripMenuItem
            // 
            this.listadoDeTodosLosClientesToolStripMenuItem.Name = "listadoDeTodosLosClientesToolStripMenuItem";
            this.listadoDeTodosLosClientesToolStripMenuItem.Size = new System.Drawing.Size(326, 26);
            this.listadoDeTodosLosClientesToolStripMenuItem.Text = "Listado de todos los clientes";
            this.listadoDeTodosLosClientesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeTodosLosClientesToolStripMenuItem_Click);
            // 
            // listadoDeClientesDeudoresToolStripMenuItem
            // 
            this.listadoDeClientesDeudoresToolStripMenuItem.Name = "listadoDeClientesDeudoresToolStripMenuItem";
            this.listadoDeClientesDeudoresToolStripMenuItem.Size = new System.Drawing.Size(326, 26);
            this.listadoDeClientesDeudoresToolStripMenuItem.Text = "Listado de clientes deudores...";
            this.listadoDeClientesDeudoresToolStripMenuItem.Click += new System.EventHandler(this.listadoDeClientesDeudoresToolStripMenuItem_Click);
            // 
            // listadoDeClientesOrdenadosPorToolStripMenuItem
            // 
            this.listadoDeClientesOrdenadosPorToolStripMenuItem.Name = "listadoDeClientesOrdenadosPorToolStripMenuItem";
            this.listadoDeClientesOrdenadosPorToolStripMenuItem.Size = new System.Drawing.Size(326, 26);
            this.listadoDeClientesOrdenadosPorToolStripMenuItem.Text = "Listado de clientes ordenados por...";
            this.listadoDeClientesOrdenadosPorToolStripMenuItem.Click += new System.EventHandler(this.listadoDeClientesOrdenadosPorToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(66, 26);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // frmManejoClientes
            // 
            this.ClientSize = new System.Drawing.Size(566, 423);
            this.Controls.Add(this.msAgregarNuevosClientes);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msAgregarNuevosClientes;
            this.Name = "frmManejoClientes";
            this.Text = "Sistema de gestion de clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msAgregarNuevosClientes.ResumeLayout(false);
            this.msAgregarNuevosClientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip msAgregarNuevosClientes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeTodosLosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesDeudoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesOrdenadosPorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
    }
}