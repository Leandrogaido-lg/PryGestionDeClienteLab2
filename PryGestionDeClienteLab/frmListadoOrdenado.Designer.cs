namespace PryGestionDeClienteLab
{
    partial class frmListadoOrdenado
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
            this.cbxCampo = new System.Windows.Forms.ComboBox();
            this.cbxModo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblModo = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.dgvCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxCampo
            // 
            this.cbxCampo.FormattingEnabled = true;
            this.cbxCampo.Items.AddRange(new object[] {
            "Còdigo",
            "Nombre",
            "Limite de Credito",
            "Deuda"});
            this.cbxCampo.Location = new System.Drawing.Point(141, 58);
            this.cbxCampo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxCampo.Name = "cbxCampo";
            this.cbxCampo.Size = new System.Drawing.Size(160, 24);
            this.cbxCampo.TabIndex = 0;
            // 
            // cbxModo
            // 
            this.cbxModo.FormattingEnabled = true;
            this.cbxModo.Items.AddRange(new object[] {
            "Ascendente",
            "Descendente"});
            this.cbxModo.Location = new System.Drawing.Point(444, 59);
            this.cbxModo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxModo.Name = "cbxModo";
            this.cbxModo.Size = new System.Drawing.Size(160, 24);
            this.cbxModo.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnListar);
            this.groupBox1.Controls.Add(this.lblModo);
            this.groupBox1.Controls.Add(this.lblCampo);
            this.groupBox1.Controls.Add(this.dgvListado);
            this.groupBox1.Controls.Add(this.cbxCampo);
            this.groupBox1.Controls.Add(this.cbxModo);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(652, 436);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta de Datos";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(476, 393);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(129, 36);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblModo
            // 
            this.lblModo.AutoSize = true;
            this.lblModo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblModo.Location = new System.Drawing.Point(371, 59);
            this.lblModo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModo.Name = "lblModo";
            this.lblModo.Size = new System.Drawing.Size(62, 25);
            this.lblModo.TabIndex = 4;
            this.lblModo.Text = "Modo";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCampo.Location = new System.Drawing.Point(53, 58);
            this.lblCampo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(76, 25);
            this.lblCampo.TabIndex = 3;
            this.lblCampo.Text = "Campo";
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCodigo,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvListado.Location = new System.Drawing.Point(31, 122);
            this.dgvListado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.RowHeadersWidth = 51;
            this.dgvListado.Size = new System.Drawing.Size(575, 251);
            this.dgvListado.TabIndex = 2;
            // 
            // dgvCodigo
            // 
            this.dgvCodigo.HeaderText = "Còdigo";
            this.dgvCodigo.MinimumWidth = 6;
            this.dgvCodigo.Name = "dgvCodigo";
            this.dgvCodigo.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Limite de Credito";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Deuda";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // frmListadoOrdenado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 465);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListadoOrdenado";
            this.Text = "Listado Ordenado";
            this.Load += new System.EventHandler(this.frmListadoOrdenado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCampo;
        private System.Windows.Forms.ComboBox cbxModo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblModo;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}