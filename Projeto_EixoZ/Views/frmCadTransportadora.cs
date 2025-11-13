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
    public partial class frmCadTransportadora: Form
    {
        TransportadoraController transportadoraController = new TransportadoraController();

        public frmCadTransportadora(int acao = 1, Transportadora transportadora = null)
        {
            InitializeComponent();
            DefinirModoTela(acao, transportadora);
        }
        private void DefinirModoTela(int acao, Transportadora transportadora)
        {
            // Carrega os dados do material se fornecido
            if (transportadora != null)
                CarregarDados(transportadora);
            // Define o título da janela com base na ação
            switch (acao)
            {
                case 1:
                    this.Text = "Cadastrar Transportadora"; // Título para cadastro
                    txtIDCadTransp.ReadOnly = true;
                    break;
                case 2:
                    this.Text = "Editar Transportadora"; // Título para edição
                    break;
                case 3:
                    this.Text = "Visualizar Transportadoras"; // Título para visualização
                    DesativarCampos();
                    break;
            }
        }
        void DesativarCampos() // Desativa os campos para visualização apenas
        {
            txtIDCadTransp.ReadOnly = true;
            txtNomeCadTransp.ReadOnly = true;
            txtPrecoCadTransp.ReadOnly = true;
            txtObsCadTransp.ReadOnly = true;

            // Oculta os botões de salvar e limpar
            btnCancelarCadTransp.Visible = true;
            btnCancelarCadTransp.Text = "Fechar";
            btnSalvarCadTransp.Visible = false;
        }

        void CarregarDados(Transportadora transportadora)
        {
            // Preenche os campos com os dados do material
            txtIDCadTransp.Text = transportadora.IdTransportadora.ToString();
            txtNomeCadTransp.Text = transportadora.NomeFantasia;
            txtMeioCadTransp.Text = transportadora.MeioDeTransporte;
            txtPrecoCadTransp.Text = transportadora.PrecoMedio.ToString();
            txtObsCadTransp.Text = transportadora.Observacao;
        }

        private void btnSalvarCadTransp_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNomeCadTransp.Text) ||
                string.IsNullOrWhiteSpace(txtPrecoCadTransp.Text) ||
                string.IsNullOrWhiteSpace(txtMeioCadTransp.Text))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios!");
                    return;
                }

                // Tenta converter o preco para decimal
                // Se a conversão falhar, exibe uma mensagem de erro
                if (!decimal.TryParse(txtPrecoCadTransp.Text, out decimal preco))
                {
                    MessageBox.Show("Preço inválido. Digite um valor numérico.");
                    return;
                } // Atribui o preço convertido -->

                Transportadora transportadora = new Transportadora
                {
                    NomeFantasia = txtNomeCadTransp.Text,
                    PrecoMedio = preco, // Atribui o preço convertido <--
                    MeioDeTransporte = txtMeioCadTransp.Text,
                    Observacao = txtObsCadTransp.Text
                };

                int resultado;
                if (string.IsNullOrEmpty(txtIDCadTransp.Text))
                {
                    // Vazio = Inserir
                    resultado = transportadoraController.Inserir(transportadora);
                }
                else
                {
                    // Preenchido = Alterar
                    transportadora.IdTransportadora = int.Parse(txtIDCadTransp.Text);
                    resultado = transportadoraController.Alterar(transportadora);
                }

                if (resultado > 0)
                {
                    MessageBox.Show("Pedido salvo com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao salvar pedido.");
                }
            }
            catch (Exception ex)
            {
                // A rede de segurança
                MessageBox.Show(
                    "Ocorreu um erro: " + ex.Message + "\n\nDetalhes: " + ex.ToString(),
                    "Erro Crítico",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancelarCadTransp_Click(object sender, EventArgs e)
        {
            if (btnCancelarCadTransp.Visible == false)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
