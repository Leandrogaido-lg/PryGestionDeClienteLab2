namespace PryGestionDeClienteLab
{
    partial class frmClientesDeudores
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
            this.dgvClientesDeudores = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.lblCantidadClientes = new System.Windows.Forms.Label();
            this.lblPromedioDeuda = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnListarDeudores = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesDeudores)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnListarDeudores);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblPromedioDeuda);
            this.groupBox1.Controls.Add(this.lblCantidadClientes);
            this.groupBox1.Controls.Add(this.lblTotalDeuda);
            this.groupBox1.Controls.Add(this.dgvClientesDeudores);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta de Datos";
            // 
            // dgvClientesDeudores
            // 
            this.dgvClientesDeudores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesDeudores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvClientesDeudores.Location = new System.Drawing.Point(6, 21);
            this.dgvClientesDeudores.Name = "dgvClientesDeudores";
            this.dgvClientesDeudores.RowHeadersWidth = 51;
            this.dgvClientesDeudores.RowTemplate.Height = 24;
            this.dgvClientesDeudores.Size = new System.Drawing.Size(546, 264);
            this.dgvClientesDeudores.TabIndex = 0;
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
            this.Column2.Width = 125;
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
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.AutoSize = true;
            this.lblTotalDeuda.Location = new System.Drawing.Point(281, 303);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(101, 16);
            this.lblTotalDeuda.TabIndex = 1;
            this.lblTotalDeuda.Text = "Total de Deuda";
            // 
            // lblCantidadClientes
            // 
            this.lblCantidadClientes.AutoSize = true;
            this.lblCantidadClientes.Location = new System.Drawing.Point(281, 331);
            this.lblCantidadClientes.Name = "lblCantidadClientes";
            this.lblCantidadClientes.Size = new System.Drawing.Size(131, 16);
            this.lblCantidadClientes.TabIndex = 2;
            this.lblCantidadClientes.Text = "Cantidad de Clientes";
            // 
            // lblPromedioDeuda
            // 
            this.lblPromedioDeuda.AutoSize = true;
            this.lblPromedioDeuda.Location = new System.Drawing.Point(281, 359);
            this.lblPromedioDeuda.Name = "lblPromedioDeuda";
            this.lblPromedioDeuda.Size = new System.Drawing.Size(129, 16);
            this.lblPromedioDeuda.TabIndex = 3;
            this.lblPromedioDeuda.Text = "Promedio de Deuda";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(418, 297);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(418, 325);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(418, 353);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(134, 22);
            this.textBox3.TabIndex = 6;
            // 
            // btnListarDeudores
            // 
            this.btnListarDeudores.Location = new System.Drawing.Point(418, 393);
            this.btnListarDeudores.Name = "btnListarDeudores";
            this.btnListarDeudores.Size = new System.Drawing.Size(134, 27);
            this.btnListarDeudores.TabIndex = 7;
            this.btnListarDeudores.Text = "Listar Deudores";
            this.btnListarDeudores.UseVisualStyleBackColor = true;
            // 
            // frmClientesDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmClientesDeudores";
            this.Text = "Clientes Deudores";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesDeudores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvClientesDeudores;
        private System.Windows.Forms.Button btnListarDeudores;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPromedioDeuda;
        private System.Windows.Forms.Label lblCantidadClientes;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}