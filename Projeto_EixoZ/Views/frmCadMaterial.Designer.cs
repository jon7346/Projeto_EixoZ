namespace Projeto_EixoZ.Views
{
    partial class frmCadMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadMaterial));
            this.txtPesoCadMaterial = new System.Windows.Forms.TextBox();
            this.txtMtlCadMaterial = new System.Windows.Forms.TextBox();
            this.txtNomeCadMaterial = new System.Windows.Forms.TextBox();
            this.txtIDCadMaterial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvarCadProd = new System.Windows.Forms.Button();
            this.btnClrCadProd = new System.Windows.Forms.Button();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtPesoCadMaterial
            // 
            this.txtPesoCadMaterial.Location = new System.Drawing.Point(310, 113);
            this.txtPesoCadMaterial.Name = "txtPesoCadMaterial";
            this.txtPesoCadMaterial.Size = new System.Drawing.Size(151, 22);
            this.txtPesoCadMaterial.TabIndex = 21;
            // 
            // txtMtlCadMaterial
            // 
            this.txtMtlCadMaterial.Location = new System.Drawing.Point(12, 113);
            this.txtMtlCadMaterial.Name = "txtMtlCadMaterial";
            this.txtMtlCadMaterial.Size = new System.Drawing.Size(267, 22);
            this.txtMtlCadMaterial.TabIndex = 20;
            // 
            // txtNomeCadMaterial
            // 
            this.txtNomeCadMaterial.Location = new System.Drawing.Point(121, 44);
            this.txtNomeCadMaterial.Name = "txtNomeCadMaterial";
            this.txtNomeCadMaterial.Size = new System.Drawing.Size(340, 22);
            this.txtNomeCadMaterial.TabIndex = 19;
            // 
            // txtIDCadMaterial
            // 
            this.txtIDCadMaterial.Location = new System.Drawing.Point(12, 44);
            this.txtIDCadMaterial.Name = "txtIDCadMaterial";
            this.txtIDCadMaterial.Size = new System.Drawing.Size(75, 22);
            this.txtIDCadMaterial.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tipo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Peso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Materia prima";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome Fornecedor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID:";
            // 
            // btnSalvarCadProd
            // 
            this.btnSalvarCadProd.Location = new System.Drawing.Point(633, 36);
            this.btnSalvarCadProd.Name = "btnSalvarCadProd";
            this.btnSalvarCadProd.Size = new System.Drawing.Size(131, 38);
            this.btnSalvarCadProd.TabIndex = 24;
            this.btnSalvarCadProd.Text = "Salvar";
            this.btnSalvarCadProd.UseVisualStyleBackColor = true;
            this.btnSalvarCadProd.Click += new System.EventHandler(this.btnSalvarCadProd_Click_1);
            // 
            // btnClrCadProd
            // 
            this.btnClrCadProd.Location = new System.Drawing.Point(633, 113);
            this.btnClrCadProd.Name = "btnClrCadProd";
            this.btnClrCadProd.Size = new System.Drawing.Size(131, 38);
            this.btnClrCadProd.TabIndex = 25;
            this.btnClrCadProd.Text = "Cancelar";
            this.btnClrCadProd.UseVisualStyleBackColor = true;
            this.btnClrCadProd.Click += new System.EventHandler(this.btnClrCadProd_Click);
            // 
            // cbxMarca
            // 
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Items.AddRange(new object[] {
            "Hatchbox Filamento",
            "",
            "",
            "eSUN Filamento",
            "",
            "",
            "Elegoo Filamento",
            "",
            "",
            "Polymaker Filamento",
            "",
            "",
            "Prusament Filamento",
            "",
            "",
            "Overture Filamento",
            "",
            "",
            "Sunlu Filamento"});
            this.cbxMarca.Location = new System.Drawing.Point(12, 188);
            this.cbxMarca.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(155, 24);
            this.cbxMarca.TabIndex = 41;
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "PLA (ácido poliláctico)",
            "",
            "",
            "PLA+",
            "",
            "",
            "PETG",
            "",
            "",
            "ABS",
            "",
            "",
            "TPU (filamento flexível)",
            "",
            "",
            "Nylon"});
            this.cbxTipo.Location = new System.Drawing.Point(200, 188);
            this.cbxTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(153, 24);
            this.cbxTipo.TabIndex = 42;
            // 
            // frmCadMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 367);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.btnClrCadProd);
            this.Controls.Add(this.btnSalvarCadProd);
            this.Controls.Add(this.txtPesoCadMaterial);
            this.Controls.Add(this.txtMtlCadMaterial);
            this.Controls.Add(this.txtNomeCadMaterial);
            this.Controls.Add(this.txtIDCadMaterial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadMaterial";
            this.Text = "frmCadProduto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPesoCadMaterial;
        private System.Windows.Forms.TextBox txtMtlCadMaterial;
        private System.Windows.Forms.TextBox txtNomeCadMaterial;
        private System.Windows.Forms.TextBox txtIDCadMaterial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvarCadProd;
        private System.Windows.Forms.Button btnClrCadProd;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxTipo;
    }
}