namespace Projeto_EixoZ.Views
{
    partial class FrmTransportadora
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
            "id",
            "Nome ",
            "Meio de transporte ",
            "Preço médio ",
            "Observação"});
            this.CBSelec.Location = new System.Drawing.Point(601, 32);
            this.CBSelec.Name = "CBSelec";
            this.CBSelec.Size = new System.Drawing.Size(121, 24);
            this.CBSelec.TabIndex = 50;
            // 
            // dgvDadosRetornados
            // 
            this.dgvDadosRetornados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosRetornados.Location = new System.Drawing.Point(33, 73);
            this.dgvDadosRetornados.Name = "dgvDadosRetornados";
            this.dgvDadosRetornados.RowHeadersWidth = 51;
            this.dgvDadosRetornados.RowTemplate.Height = 24;
            this.dgvDadosRetornados.Size = new System.Drawing.Size(518, 218);
            this.dgvDadosRetornados.TabIndex = 49;
            // 
            // btnViualizar
            // 
            this.btnViualizar.Location = new System.Drawing.Point(702, 405);
            this.btnViualizar.Name = "btnViualizar";
            this.btnViualizar.Size = new System.Drawing.Size(119, 26);
            this.btnViualizar.TabIndex = 48;
            this.btnViualizar.Text = "Visualizar";
            this.btnViualizar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(577, 405);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(119, 26);
            this.btnExcluir.TabIndex = 47;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(452, 405);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(119, 26);
            this.btnAlterar.TabIndex = 46;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(327, 405);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 26);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(603, 82);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(119, 26);
            this.btnPesquisar.TabIndex = 44;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(33, 32);
            this.txtPesquisa.Multiline = true;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(553, 22);
            this.txtPesquisa.TabIndex = 43;
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Location = new System.Drawing.Point(16, 376);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(65, 16);
            this.lblRegistros.TabIndex = 42;
            this.lblRegistros.Text = "Registros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Transportadora";
            // 
            // FrmTransportadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 573);
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
            this.Name = "FrmTransportadora";
            this.Text = "FrmTransportadoracs";
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