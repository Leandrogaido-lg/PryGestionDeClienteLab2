namespace PryGestionDeClienteLab
{
    partial class frmListadoClientes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPromedioDeuda = new System.Windows.Forms.Label();
            this.lblCantidadClientes = new System.Windows.Forms.Label();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.DgvListadoClientes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DgvListadoClientes);
            this.groupBox1.Controls.Add(this.txtPromedio);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.lblTotalDeuda);
            this.groupBox1.Controls.Add(this.lblCantidadClientes);
            this.groupBox1.Controls.Add(this.lblPromedioDeuda);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 460);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta de Datos";
            // 
            // lblPromedioDeuda
            // 
            this.lblPromedioDeuda.AutoSize = true;
            this.lblPromedioDeuda.Location = new System.Drawing.Point(348, 415);
            this.lblPromedioDeuda.Name = "lblPromedioDeuda";
            this.lblPromedioDeuda.Size = new System.Drawing.Size(129, 16);
            this.lblPromedioDeuda.TabIndex = 0;
            this.lblPromedioDeuda.Text = "Promedio de Deuda";
            // 
            // lblCantidadClientes
            // 
            this.lblCantidadClientes.AutoSize = true;
            this.lblCantidadClientes.Location = new System.Drawing.Point(348, 388);
            this.lblCantidadClientes.Name = "lblCantidadClientes";
            this.lblCantidadClientes.Size = new System.Drawing.Size(131, 16);
            this.lblCantidadClientes.TabIndex = 1;
            this.lblCantidadClientes.Text = "Cantidad de Clientes";
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.AutoSize = true;
            this.lblTotalDeuda.Location = new System.Drawing.Point(348, 360);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(101, 16);
            this.lblTotalDeuda.TabIndex = 2;
            this.lblTotalDeuda.Text = "Total de Deuda";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(485, 354);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(112, 22);
            this.txtTotal.TabIndex = 3;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(485, 382);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(112, 22);
            this.txtCantidad.TabIndex = 4;
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(485, 409);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(112, 22);
            this.txtPromedio.TabIndex = 5;
            // 
            // DgvListadoClientes
            // 
            this.DgvListadoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DgvListadoClientes.Location = new System.Drawing.Point(18, 21);
            this.DgvListadoClientes.Name = "DgvListadoClientes";
            this.DgvListadoClientes.RowHeadersWidth = 51;
            this.DgvListadoClientes.RowTemplate.Height = 24;
            this.DgvListadoClientes.Size = new System.Drawing.Size(579, 303);
            this.DgvListadoClientes.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre y Apellido";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Limite de Credito";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Deuda";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // frmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 484);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmListadoClientes";
            this.Text = "Listado De Clientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgvListadoClientes;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.Label lblCantidadClientes;
        private System.Windows.Forms.Label lblPromedioDeuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}