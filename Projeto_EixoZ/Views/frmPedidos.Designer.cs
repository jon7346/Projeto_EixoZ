namespace Projeto_EixoZ.Views
{
    partial class frmPedidos
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
            this.CBSelec = new System.Windows.Forms.ComboBox();
            this.dgvDadosRetornados = new System.Windows.Forms.DataGridView();
            this.btnViualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosRetornados)).BeginInit();
            this.SuspendLayout();
            // 
            // CBSelec
            // 
            this.CBSelec.FormattingEnabled = true;
            this.CBSelec.Items.AddRange(new object[] {
            "Id",
            "Id do cliente",
            "Id da transportadora ",
            "Id do vendedor ",
            "Endereço de entrega",
            "Data do Pedido ",
            "Status do Pedido ",
            "Observação "});
            this.CBSelec.Location = new System.Drawing.Point(583, 35);
            this.CBSelec.Name = "CBSelec";
            this.CBSelec.Size = new System.Drawing.Size(121, 24);
            this.CBSelec.TabIndex = 40;
            // 
            // dgvDadosRetornados
            // 
            this.dgvDadosRetornados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosRetornados.Location = new System.Drawing.Point(15, 76);
            this.dgvDadosRetornados.Name = "dgvDadosRetornados";
            this.dgvDadosRetornados.RowHeadersWidth = 51;
            this.dgvDadosRetornados.RowTemplate.Height = 24;
            this.dgvDadosRetornados.Size = new System.Drawing.Size(518, 218);
            this.dgvDadosRetornados.TabIndex = 39;
            // 
            // btnViualizar
            // 
            this.btnViualizar.Location = new System.Drawing.Point(684, 408);
            this.btnViualizar.Name = "btnViualizar";
            this.btnViualizar.Size = new System.Drawing.Size(119, 26);
            this.btnViualizar.TabIndex = 38;
            this.btnViualizar.Text = "Visualizar";
            this.btnViualizar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(559, 408);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(119, 26);
            this.btnExcluir.TabIndex = 37;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(434, 408);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(119, 26);
            this.btnAlterar.TabIndex = 36;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(309, 408);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 26);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(585, 85);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(119, 26);
            this.btnPesquisar.TabIndex = 34;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(15, 35);
            this.txtPesquisa.Multiline = true;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(553, 22);
            this.txtPesquisa.TabIndex = 33;
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Location = new System.Drawing.Point(-2, 379);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(65, 16);
            this.lblRegistros.TabIndex = 32;
            this.lblRegistros.Text = "Registros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Materiais";
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.CBSelec);
            this.Controls.Add(this.dgvDadosRetornados);
            this.Controls.Add(this.btnViualizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label1);
            this.Name = "frmPedidos";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosRetornados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBSelec;
        private System.Windows.Forms.DataGridView dgvDadosRetornados;
        private System.Windows.Forms.Button btnViualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label label1;
    }
}