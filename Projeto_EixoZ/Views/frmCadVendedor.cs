using Projeto_EixoZ.Controllers;
using Projeto_EixoZ.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_EixoZ.Views
{
    public partial class frmCadVendedor: Form
    {
        VendedorController vendedorController = new VendedorController();
        public frmCadVendedor(int Acao = 1, Vendedor vendedor = null)
        {
            InitializeComponent();
            DefinirModoTela(Acao, vendedor);
        }

        private void DefinirModoTela(int acao, Vendedor vendedor)
        {
            if (vendedor != null)
                CarregarDados(vendedor);

            // Define o título da janela com base na ação
            switch (acao)
            {
                case 1:
                    this.Text = "Cadastrar Vendedor";
                    break;
                case 2:
                    this.Text = "Editar Vendedor";
                    break;
                case 3:
                    this.Text = "Visualizar Vendedor";
                    DesativarCampos();
                    break;
            }


        }
        void DesativarCampos()
        {
            // Desativa os campos para visualização apenas
            txtIDCadVendedor.ReadOnly = true;
            txtNomeCadVendedor.ReadOnly = true;
            txtEmailCadVendedor.ReadOnly = true;
            txtSenhaCadVendedor.ReadOnly = true;
            txtEnderecoCadVendedor.ReadOnly = true;
            txtIdadeCadVendedor.ReadOnly = true;

            // Oculta os botões de salvar e limpar
            btnSalvarCadVendedor.Visible = false;
            btnCancelarCadVendedor.Visible = true;
            btnCancelarCadVendedor.Text = "Fechar";
        }

        void CarregarDados(Vendedor vendedor)
        {
            //carrega os dados que forem inseridos nos campos de cliente
            txtIDCadVendedor.Text = vendedor.IdVendedor.ToString();
            txtNomeCadVendedor.Text = vendedor.Nome.ToString();
            txtEmailCadVendedor.Text = vendedor.Email.ToString();
            txtSenhaCadVendedor.Text = vendedor.Senha.ToString();
            txtEnderecoCadVendedor.Text = vendedor.Endereco.ToString();
            txtIdadeCadVendedor.Text = vendedor.Idade.ToString();
        }

        private void btnSalvarCadVendedor_Click(object sender, EventArgs e)
        {

            Vendedor vendedor = new Vendedor();

            vendedor.Nome = txtNomeCadVendedor.Text;
            vendedor.Email = txtEmailCadVendedor.Text;
            vendedor.Senha = txtSenhaCadVendedor.Text;

            int retorno = 0;
            if (txtIDCadVendedor.Text == "")
                retorno = vendedorController.Inserir(vendedor);
            else
            {

                vendedor.IdVendedor = int.Parse(txtIDCadVendedor.Text);
                retorno = vendedorController.Alterar(vendedor);
            }

            if (retorno > 0)
            {
                MessageBox.Show(
                    "Cadastro salvo com sucesso!",
                    "Informação!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show(
                    "Falha ao salvar o cadastro!",
                    "Atenção!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
        }

        private void btnCancelarCadVendedor_Click(object sender, EventArgs e)
        {
            if (btnSalvarCadVendedor.Visible == false)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                if (MessageBox.Show(
                    "Deseja realmente sair?" + Environment.NewLine + Environment.NewLine +
                    "Ao Sair os dados alterados serão descartados!",
                    "Confirmação!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    DialogResult = DialogResult.Cancel;
                    this.Close();
                }

            }
        }
    }
}
