namespace Projeto_EixoZ.Views
{
    partial class frmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduto));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProdutos = new System.Windows.Forms.TextBox();
            this.btnPesquisarProd = new System.Windows.Forms.Button();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.btnAlterarProd = new System.Windows.Forms.Button();
            this.btnExcluirProd = new System.Windows.Forms.Button();
            this.btnViualizarProd = new System.Windows.Forms.Button();
            this.btnSelecionarProd = new System.Windows.Forms.Button();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produtos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registros";
            // 
            // txtProdutos
            // 
            this.txtProdutos.Location = new System.Drawing.Point(21, 53);
            this.txtProdutos.Multiline = true;
            this.txtProdutos.Name = "txtProdutos";
            this.txtProdutos.Size = new System.Drawing.Size(553, 22);
            this.txtProdutos.TabIndex = 2;
            // 
            // btnPesquisarProd
            // 
            this.btnPesquisarProd.Location = new System.Drawing.Point(580, 49);
            this.btnPesquisarProd.Name = "btnPesquisarProd";
            this.btnPesquisarProd.Size = new System.Drawing.Size(119, 26);
            this.btnPesquisarProd.TabIndex = 3;
            this.btnPesquisarProd.Text = "Pesquisar";
            this.btnPesquisarProd.UseVisualStyleBackColor = true;
            // 
            // btnAddProd
            // 
            this.btnAddProd.Location = new System.Drawing.Point(363, 458);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(119, 26);
            this.btnAddProd.TabIndex = 4;
            this.btnAddProd.Text = "Adicionar";
            this.btnAddProd.UseVisualStyleBackColor = true;
            // 
            // btnAlterarProd
            // 
            this.btnAlterarProd.Location = new System.Drawing.Point(488, 458);
            this.btnAlterarProd.Name = "btnAlterarProd";
            this.btnAlterarProd.Size = new System.Drawing.Size(119, 26);
            this.btnAlterarProd.TabIndex = 5;
            this.btnAlterarProd.Text = "Alterar";
            this.btnAlterarProd.UseVisualStyleBackColor = true;
            // 
            // btnExcluirProd
            // 
            this.btnExcluirProd.Location = new System.Drawing.Point(613, 458);
            this.btnExcluirProd.Name = "btnExcluirProd";
            this.btnExcluirProd.Size = new System.Drawing.Size(119, 26);
            this.btnExcluirProd.TabIndex = 6;
            this.btnExcluirProd.Text = "Excluir";
            this.btnExcluirProd.UseVisualStyleBackColor = true;
            // 
            // btnViualizarProd
            // 
            this.btnViualizarProd.Location = new System.Drawing.Point(738, 458);
            this.btnViualizarProd.Name = "btnViualizarProd";
            this.btnViualizarProd.Size = new System.Drawing.Size(119, 26);
            this.btnViualizarProd.TabIndex = 7;
            this.btnViualizarProd.Text = "Visualizar";
            this.btnViualizarProd.UseVisualStyleBackColor = true;
            // 
            // btnSelecionarProd
            // 
            this.btnSelecionarProd.Location = new System.Drawing.Point(12, 458);
            this.btnSelecionarProd.Name = "btnSelecionarProd";
            this.btnSelecionarProd.Size = new System.Drawing.Size(119, 26);
            this.btnSelecionarProd.TabIndex = 8;
            this.btnSelecionarProd.Text = "Selecionar";
            this.btnSelecionarProd.UseVisualStyleBackColor = true;
            // 
            // dgvProd
            // 
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Location = new System.Drawing.Point(35, 109);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.RowHeadersWidth = 51;
            this.dgvProd.RowTemplate.Height = 24;
            this.dgvProd.Size = new System.Drawing.Size(518, 218);
            this.dgvProd.TabIndex = 9;
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 574);
            this.Controls.Add(this.dgvProd);
            this.Controls.Add(this.btnSelecionarProd);
            this.Controls.Add(this.btnViualizarProd);
            this.Controls.Add(this.btnExcluirProd);
            this.Controls.Add(this.btnAlterarProd);
            this.Controls.Add(this.btnAddProd);
            this.Controls.Add(this.btnPesquisarProd);
            this.Controls.Add(this.txtProdutos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProduto";
            this.Text = "frmProduto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProdutos;
        private System.Windows.Forms.Button btnPesquisarProd;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Button btnAlterarProd;
        private System.Windows.Forms.Button btnExcluirProd;
        private System.Windows.Forms.Button btnViualizarProd;
        private System.Windows.Forms.Button btnSelecionarProd;
        private System.Windows.Forms.DataGridView dgvProd;
    }
}