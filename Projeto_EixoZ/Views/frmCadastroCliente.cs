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
    public partial class frmCadastroCliente: Form
    {
        //criando instancia com a controller
        ClienteController clienteController = new ClienteController();
        public frmCadastroCliente(int Acao = 1, Cliente cliente = null)
        {
            InitializeComponent();
            DefinirModoTela(Acao, cliente);
        }

        private void DefinirModoTela(int acao, Cliente cliente)
        {
            if (cliente != null)
                CarregarDados(cliente);

            // Define o título da janela com base na ação
            switch (acao)
            {
                case 1:
                    this.Text = "Cadastrar Cliente";
                    break;
                case 2:
                    this.Text = "Editar Cliente";
                    break;
                case 3:
                    this.Text = "Visualizar Cliente";
                    DesativarCampos();
                    break;
            }
        }
        void DesativarCampos()
        {
            // Desativa os campos para visualização apenas
            txtIDCadCliente.ReadOnly = true;
            txtNomeCadCliente.ReadOnly = true;
            txtEmailCadCliente.ReadOnly = true;
            txtSenhaCadCliente.ReadOnly = true;
            txtEnderecoCadCliente.ReadOnly = true;
            txtIdadeCadCliente.ReadOnly = true;

            // Oculta os botões de salvar e limpar
            btnSalvarCadCliente.Visible = false;
            btnCancelarCadCliente.Visible = true;
            btnCancelarCadCliente.Text = "Fechar";
        }

        void CarregarDados(Cliente cliente)
        {
            //carrega os dados que forem inseridos nos campos de cliente
            txtIDCadCliente.Text = cliente.ClienteId.ToString();
            txtNomeCadCliente.Text = cliente.Nome.ToString();
            txtEmailCadCliente.Text = cliente.Email.ToString();
            txtSenhaCadCliente.Text = cliente.Senha.ToString();
            txtEnderecoCadCliente.Text = cliente.Endereco.ToString();
            txtIdadeCadCliente.Text = cliente.Idade.ToString();
        }

        private void btnSalvarCadCliente_Click_1(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.Nome = txtNomeCadCliente.Text;
                cliente.Email = txtEmailCadCliente.Text;
                cliente.Senha = txtSenhaCadCliente.Text;
                cliente.Endereco = txtEnderecoCadCliente.Text;

                if (!int.TryParse(txtIdadeCadCliente.Text, out int idade))
                {
                    MessageBox.Show("Por favor, insira uma idade válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Para a execução
                }
                cliente.Idade = idade;

                int retorno = 0;
                if (txtIDCadCliente.Text == "")
                {
                    retorno = clienteController.Inserir(cliente);
                }
                else
                {
                    cliente.ClienteId = int.Parse(txtIDCadCliente.Text);
                    retorno = clienteController.Alterar(cliente);
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
                {
                    MessageBox.Show(
                        "Falha ao salvar o cadastro!",
                        "Atenção!", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // ISSO AQUI É O MAIS IMPORTANTE:
                // Se qualquer erro acontecer (Typo, Banco, int.Parse), ele será exibido
                MessageBox.Show(
                    "Ocorreu um erro: " + ex.Message + "\n\nDetalhes: " + ex.ToString(),
                    "Erro Crítico",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancelarCadCliente_Click_1(object sender, EventArgs e)
        {
            if (btnSalvarCadCliente.Visible == false)
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
