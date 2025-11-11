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
    public partial class frmCadPedidos: Form
    {
        PedidosController pedidosController = new PedidosController();

        public frmCadPedidos(int acao = 1, Pedidos pedido = null)
        {
            InitializeComponent();
            DefinirModoTela(acao, pedido);
        }

        private void DefinirModoTela(int acao, Pedidos pedido)
        {
            // Carrega os dados do pedido se fornecido
            if (pedido != null)
                CarregarDados(pedido);

            // Define o título da janela com base na ação
            switch (acao)
            {
                case 1:
                    this.Text = "Cadastrar Pedido";
                    break;
                case 2:
                    this.Text = "Editar Pedido";
                    break;
                case 3:
                    this.Text = "Visualizar Pedido";
                    DesativarCampos();
                    break;
            }
        }
        void DesativarCampos()
        {
            // Desativa os campos para visualização apenas
            txtIDCadPedido.ReadOnly = true;
            txtIDCliente.ReadOnly = true;
            txtIDTransp.ReadOnly = true;
            txtEnderecoEntrega.ReadOnly = true;
            txtDataCadPedidos.ReadOnly = true;
            txtStatusCadPedidos.ReadOnly = true;
            txtObsCadPedidos.ReadOnly = true;

            // Oculta os botões de salvar e limpar
            btnSalvarCadPedido.Visible = false;
            btnCancelarCadPedido.Visible = true;
            btnCancelarCadPedido.Text = "Fechar";
        }

        void CarregarDados(Pedidos pedido)
        {
            // Preenche os campos com os dados do pedido
            txtIDCadPedido.Text = pedido.IdPedido.ToString();
            txtIDCliente.Text = pedido.IdCliente.ToString();
            txtIDTransp.Text = pedido.IdTransportadora.ToString();
            txtEnderecoEntrega.Text = pedido.EnderecoEntrega;
            txtDataCadPedidos.Text = pedido.DataPedido.ToString("dd-MM-yyyy");
            txtStatusCadPedidos.Text = pedido.StatusPedido;
            txtObsCadPedidos.Text = pedido.Observacao;
        }

        private void btnSalvarCadPedido_Click(object sender, EventArgs e)
        {
            try
            {
                // Validação dos campos obrigatórios
                if (string.IsNullOrWhiteSpace(txtIDCliente.Text) ||
                string.IsNullOrWhiteSpace(txtIDTransp.Text) ||
                string.IsNullOrWhiteSpace(txtEnderecoEntrega.Text) ||
                string.IsNullOrWhiteSpace(txtStatusCadPedidos.Text))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios!");
                    return;
                }

                if (!int.TryParse(txtIDCadPedido.Text, out int IdPedido))
                {
                    MessageBox.Show("ID Pedido inválido!");
                    return;
                }
                // Conversão segura dos tipos de dados
                if (!int.TryParse(txtIDCliente.Text, out int idCliente))
                {
                    MessageBox.Show("ID Cliente inválido!");
                    return;
                }

                if (!int.TryParse(txtIDTransp.Text, out int idTransportadora))
                {
                    MessageBox.Show("ID Transportadora inválido!");
                    return;
                }

                DateTime dataPedido = DateTime.TryParse(txtDataCadPedidos.Text, out DateTime data) ? data : DateTime.Now;

                Pedidos pedido = new Pedidos
                {
                    IdCliente = idCliente,
                    IdTransportadora = idTransportadora,
                    EnderecoEntrega = txtEnderecoEntrega.Text,
                    DataPedido = dataPedido,
                    StatusPedido = txtStatusCadPedidos.Text,
                    Observacao = txtObsCadPedidos.Text
                };

                // Define a ação com base no contexto (inserir ou editar)
                int resultado;
                if (string.IsNullOrEmpty(txtIDCadPedido.Text))
                {
                    resultado = pedidosController.Inserir(pedido);
                }
                else
                {
                    if (!int.TryParse(txtIDCadPedido.Text, out int idPedido))
                    {
                        MessageBox.Show("ID do Pedido inválido!");
                        return;
                    }

                    pedido.IdPedido = idPedido; // Adiciona o ID ao objeto
                    resultado = pedidosController.Alterar(pedido);
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
                // A rede de segurança que pega qualquer erro
                MessageBox.Show(
                    "Ocorreu um erro: " + ex.Message + "\n\nDetalhes: " + ex.ToString(),
                    "Erro Crítico",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancelarCadPedido_Click(object sender, EventArgs e)
        {
            if (btnCancelarCadPedido.Visible == false)
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
