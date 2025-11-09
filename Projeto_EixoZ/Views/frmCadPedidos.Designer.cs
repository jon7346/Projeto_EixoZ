namespace Projeto_EixoZ.Views
{
    partial class frmCadPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadPedidos));
            this.btnCancelarCadPedido = new System.Windows.Forms.Button();
            this.btnSalvarCadPedido = new System.Windows.Forms.Button();
            this.txtObsCadPedidos = new System.Windows.Forms.TextBox();
            this.txtStatusCadPedidos = new System.Windows.Forms.TextBox();
            this.txtDataCadPedidos = new System.Windows.Forms.TextBox();
            this.txtIDTransp = new System.Windows.Forms.TextBox();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.txtIDCadPedido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEnderecoEntrega = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelarCadPedido
            // 
            this.btnCancelarCadPedido.Location = new System.Drawing.Point(472, 170);
            this.btnCancelarCadPedido.Name = "btnCancelarCadPedido";
            this.btnCancelarCadPedido.Size = new System.Drawing.Size(129, 34);
            this.btnCancelarCadPedido.TabIndex = 27;
            this.btnCancelarCadPedido.Text = "Cancelar";
            this.btnCancelarCadPedido.UseVisualStyleBackColor = true;
            this.btnCancelarCadPedido.Click += new System.EventHandler(this.btnCancelarCadPedido_Click);
            // 
            // btnSalvarCadPedido
            // 
            this.btnSalvarCadPedido.Location = new System.Drawing.Point(472, 79);
            this.btnSalvarCadPedido.Name = "btnSalvarCadPedido";
            this.btnSalvarCadPedido.Size = new System.Drawing.Size(129, 34);
            this.btnSalvarCadPedido.TabIndex = 26;
            this.btnSalvarCadPedido.Text = "Salvar";
            this.btnSalvarCadPedido.UseVisualStyleBackColor = true;
            this.btnSalvarCadPedido.Click += new System.EventHandler(this.btnSalvarCadPedido_Click);
            // 
            // txtObsCadPedidos
            // 
            this.txtObsCadPedidos.Location = new System.Drawing.Point(102, 416);
            this.txtObsCadPedidos.Name = "txtObsCadPedidos";
            this.txtObsCadPedidos.Size = new System.Drawing.Size(237, 22);
            this.txtObsCadPedidos.TabIndex = 25;
            // 
            // txtStatusCadPedidos
            // 
            this.txtStatusCadPedidos.Location = new System.Drawing.Point(106, 358);
            this.txtStatusCadPedidos.Name = "txtStatusCadPedidos";
            this.txtStatusCadPedidos.Size = new System.Drawing.Size(237, 22);
            this.txtStatusCadPedidos.TabIndex = 24;
            // 
            // txtDataCadPedidos
            // 
            this.txtDataCadPedidos.Location = new System.Drawing.Point(102, 303);
            this.txtDataCadPedidos.Name = "txtDataCadPedidos";
            this.txtDataCadPedidos.Size = new System.Drawing.Size(237, 22);
            this.txtDataCadPedidos.TabIndex = 23;
            // 
            // txtIDTransp
            // 
            this.txtIDTransp.Location = new System.Drawing.Point(106, 170);
            this.txtIDTransp.Name = "txtIDTransp";
            this.txtIDTransp.Size = new System.Drawing.Size(237, 22);
            this.txtIDTransp.TabIndex = 22;
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Location = new System.Drawing.Point(106, 103);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(237, 22);
            this.txtIDCliente.TabIndex = 21;
            // 
            // txtIDCadPedido
            // 
            this.txtIDCadPedido.Location = new System.Drawing.Point(102, 42);
            this.txtIDCadPedido.Name = "txtIDCadPedido";
            this.txtIDCadPedido.Size = new System.Drawing.Size(180, 22);
            this.txtIDCadPedido.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Observação:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Status de entega:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Data do pedido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID Pedido:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "ID Cliente:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(103, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "ID Transportadora:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(103, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Endereco de Entrega:";
            // 
            // txtEnderecoEntrega
            // 
            this.txtEnderecoEntrega.Location = new System.Drawing.Point(106, 235);
            this.txtEnderecoEntrega.Name = "txtEnderecoEntrega";
            this.txtEnderecoEntrega.Size = new System.Drawing.Size(180, 22);
            this.txtEnderecoEntrega.TabIndex = 31;
            // 
            // frmCadPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEnderecoEntrega);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancelarCadPedido);
            this.Controls.Add(this.btnSalvarCadPedido);
            this.Controls.Add(this.txtObsCadPedidos);
            this.Controls.Add(this.txtStatusCadPedidos);
            this.Controls.Add(this.txtDataCadPedidos);
            this.Controls.Add(this.txtIDTransp);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.txtIDCadPedido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadPedidos";
            this.Text = "frmCadPedidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarCadPedido;
        private System.Windows.Forms.Button btnSalvarCadPedido;
        private System.Windows.Forms.TextBox txtObsCadPedidos;
        private System.Windows.Forms.TextBox txtStatusCadPedidos;
        private System.Windows.Forms.TextBox txtDataCadPedidos;
        private System.Windows.Forms.TextBox txtIDTransp;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.TextBox txtIDCadPedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEnderecoEntrega;
    }
}