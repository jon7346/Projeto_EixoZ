namespace Projeto_EixoZ.Views
{
    partial class frmCadTransportadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadTransportadora));
            this.btnCancelarCadTransp = new System.Windows.Forms.Button();
            this.btnSalvarCadTransp = new System.Windows.Forms.Button();
            this.txtObsCadTransp = new System.Windows.Forms.TextBox();
            this.txtPrecoCadTransp = new System.Windows.Forms.TextBox();
            this.txtMeioCadTransp = new System.Windows.Forms.TextBox();
            this.txtNomeCadTransp = new System.Windows.Forms.TextBox();
            this.txtIDCadTransp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelarCadTransp
            // 
            this.btnCancelarCadTransp.Location = new System.Drawing.Point(633, 145);
            this.btnCancelarCadTransp.Name = "btnCancelarCadTransp";
            this.btnCancelarCadTransp.Size = new System.Drawing.Size(129, 34);
            this.btnCancelarCadTransp.TabIndex = 55;
            this.btnCancelarCadTransp.Text = "Cancelar";
            this.btnCancelarCadTransp.UseVisualStyleBackColor = true;
            this.btnCancelarCadTransp.Click += new System.EventHandler(this.btnCancelarCadTransp_Click);
            // 
            // btnSalvarCadTransp
            // 
            this.btnSalvarCadTransp.Location = new System.Drawing.Point(633, 28);
            this.btnSalvarCadTransp.Name = "btnSalvarCadTransp";
            this.btnSalvarCadTransp.Size = new System.Drawing.Size(129, 34);
            this.btnSalvarCadTransp.TabIndex = 54;
            this.btnSalvarCadTransp.Text = "Salvar";
            this.btnSalvarCadTransp.UseVisualStyleBackColor = true;
            this.btnSalvarCadTransp.Click += new System.EventHandler(this.btnSalvarCadTransp_Click);
            // 
            // txtObsCadTransp
            // 
            this.txtObsCadTransp.Location = new System.Drawing.Point(12, 151);
            this.txtObsCadTransp.Name = "txtObsCadTransp";
            this.txtObsCadTransp.Size = new System.Drawing.Size(589, 22);
            this.txtObsCadTransp.TabIndex = 52;
            // 
            // txtPrecoCadTransp
            // 
            this.txtPrecoCadTransp.Location = new System.Drawing.Point(11, 88);
            this.txtPrecoCadTransp.Name = "txtPrecoCadTransp";
            this.txtPrecoCadTransp.Size = new System.Drawing.Size(184, 22);
            this.txtPrecoCadTransp.TabIndex = 51;
            // 
            // txtMeioCadTransp
            // 
            this.txtMeioCadTransp.Location = new System.Drawing.Point(254, 88);
            this.txtMeioCadTransp.Name = "txtMeioCadTransp";
            this.txtMeioCadTransp.Size = new System.Drawing.Size(347, 22);
            this.txtMeioCadTransp.TabIndex = 50;
            // 
            // txtNomeCadTransp
            // 
            this.txtNomeCadTransp.Location = new System.Drawing.Point(254, 28);
            this.txtNomeCadTransp.Name = "txtNomeCadTransp";
            this.txtNomeCadTransp.Size = new System.Drawing.Size(347, 22);
            this.txtNomeCadTransp.TabIndex = 49;
            // 
            // txtIDCadTransp
            // 
            this.txtIDCadTransp.Location = new System.Drawing.Point(15, 28);
            this.txtIDCadTransp.Name = "txtIDCadTransp";
            this.txtIDCadTransp.Size = new System.Drawing.Size(180, 22);
            this.txtIDCadTransp.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Observação:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Preço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Meio de Transporte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nome Fantasia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "ID:";
            // 
            // frmCadTransportadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 364);
            this.Controls.Add(this.btnCancelarCadTransp);
            this.Controls.Add(this.btnSalvarCadTransp);
            this.Controls.Add(this.txtObsCadTransp);
            this.Controls.Add(this.txtPrecoCadTransp);
            this.Controls.Add(this.txtMeioCadTransp);
            this.Controls.Add(this.txtNomeCadTransp);
            this.Controls.Add(this.txtIDCadTransp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadTransportadora";
            this.Text = "frmCadTransportadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarCadTransp;
        private System.Windows.Forms.Button btnSalvarCadTransp;
        private System.Windows.Forms.TextBox txtObsCadTransp;
        private System.Windows.Forms.TextBox txtPrecoCadTransp;
        private System.Windows.Forms.TextBox txtMeioCadTransp;
        private System.Windows.Forms.TextBox txtNomeCadTransp;
        private System.Windows.Forms.TextBox txtIDCadTransp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}