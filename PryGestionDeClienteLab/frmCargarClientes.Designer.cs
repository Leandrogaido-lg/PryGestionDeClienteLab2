namespace PryGestionDeClienteLab
{
    partial class frmCargarClientes
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
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblNombreApellido = new System.Windows.Forms.Label();
            this.lblLimiteCredito = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.txtNyA = new System.Windows.Forms.TextBox();
            this.txtLimiteCredito = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLimiteCredito);
            this.groupBox1.Controls.Add(this.txtNyA);
            this.groupBox1.Controls.Add(this.txtDeuda);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.lblLimiteCredito);
            this.groupBox1.Controls.Add(this.lblNombreApellido);
            this.groupBox1.Controls.Add(this.lblDeuda);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.btnCargar);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carga de Datos";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(506, 172);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(63, 56);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 16);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Location = new System.Drawing.Point(63, 121);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(48, 16);
            this.lblDeuda.TabIndex = 2;
            this.lblDeuda.Text = "Deuda";
            // 
            // lblNombreApellido
            // 
            this.lblNombreApellido.AutoSize = true;
            this.lblNombreApellido.Location = new System.Drawing.Point(302, 59);
            this.lblNombreApellido.Name = "lblNombreApellido";
            this.lblNombreApellido.Size = new System.Drawing.Size(119, 16);
            this.lblNombreApellido.TabIndex = 3;
            this.lblNombreApellido.Text = "Nombre y Apellido";
            // 
            // lblLimiteCredito
            // 
            this.lblLimiteCredito.AutoSize = true;
            this.lblLimiteCredito.Location = new System.Drawing.Point(302, 121);
            this.lblLimiteCredito.Name = "lblLimiteCredito";
            this.lblLimiteCredito.Size = new System.Drawing.Size(107, 16);
            this.lblLimiteCredito.TabIndex = 4;
            this.lblLimiteCredito.Text = "Limite de Credito";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(146, 50);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 5;
            // 
            // txtDeuda
            // 
            this.txtDeuda.Location = new System.Drawing.Point(146, 118);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(100, 22);
            this.txtDeuda.TabIndex = 6;
            // 
            // txtNyA
            // 
            this.txtNyA.Location = new System.Drawing.Point(427, 53);
            this.txtNyA.Name = "txtNyA";
            this.txtNyA.Size = new System.Drawing.Size(154, 22);
            this.txtNyA.TabIndex = 7;
            // 
            // txtLimiteCredito
            // 
            this.txtLimiteCredito.Location = new System.Drawing.Point(481, 121);
            this.txtLimiteCredito.Name = "txtLimiteCredito";
            this.txtLimiteCredito.Size = new System.Drawing.Size(100, 22);
            this.txtLimiteCredito.TabIndex = 8;
            // 
            // frmCargarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 241);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCargarClientes";
            this.Text = "Cargar Clientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLimiteCredito;
        private System.Windows.Forms.Label lblNombreApellido;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtLimiteCredito;
        private System.Windows.Forms.TextBox txtNyA;
        private System.Windows.Forms.TextBox txtDeuda;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}