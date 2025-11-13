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
using Projeto_EixoZ.Controllers;

namespace Projeto_EixoZ.Views
{
    public partial class frmPedidos: Form
    {
        public frmPedidos()
        {
            InitializeComponent();
        }

        PedidosController PedidosContr = new PedidosController();
       
        void AtualizarGrid(string texto)
        {
            dgvDadosRetornados.DataSource = null;

            if (CBSelec.Text == "")

            {
                dgvDadosRetornados.DataSource = PedidosContr.GetAll();
                MessageBox.Show("Retornando todos os dados! Caso queria, por favor selecione um campo para pesquisa !");
            }
            else
                switch (CBSelec.SelectedIndex)
                {
                    //id
                    case 0:
                        if (!string.IsNullOrEmpty(txtPesquisa.Text) && int.TryParse(texto, out int id))
                        {
                            Pedidos pedidos = PedidosContr.GetById(int.Parse(texto));


                            PedidosCollection lista = new PedidosCollection();
                            lista.Add(pedidos);
                            dgvDadosRetornados.DataSource = lista;

                        }
                        else
                        {

                            MessageBox.Show("Preencha o campo de pesquisa com um valor numérico válido ");
                            break;
                        }
                        break;
                    // Id da transportadora 
                    case 1:
                        dgvDadosRetornados.DataSource = PedidosContr.GetByIdTransportadora(texto);
                        break;
                    //Id do vendedor 
                    case 2:
                        dgvDadosRetornados.DataSource = PedidosContr.GetByIdVendedor(texto);
                        break;
                    // Endereço de entrega
                    case 3:
                     
                        dgvDadosRetornados.DataSource =  PedidosContr.GetByEndereco(texto);
                        break;
                    //  Data do Pedido 
                    case 4:
                        dgvDadosRetornados.DataSource = PedidosContr.GetByData(texto);
                        break;
                    // Status do Pedido 
                    case 5:
                        dgvDadosRetornados.DataSource = PedidosContr.GetByStatus(texto);
                        break;
                    //Observação
                    case 6:
                        dgvDadosRetornados.DataSource = PedidosContr.GetByObeservacao(texto);
                        break;

                }

            lblRegistros.Text = "Registros encontrados: " + dgvDadosRetornados.RowCount.ToString();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid(txtPesquisa.Text);

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Ação 1 = Cadastrar
            frmCadPedidos tela = new frmCadPedidos(1, null);

            // 5. CORREÇÃO: Atualizar o grid se o cadastro for salvo
            if (tela.ShowDialog() == DialogResult.OK)
            {
                AtualizarGrid(""); // Recarrega o grid
            }
        }

        private Pedidos GetSelecionado()
        {
            if (dgvDadosRetornados.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecione um pedido da lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            // Pega o objeto 'Cliente' inteiro da linha selecionada
            return (Pedidos)dgvDadosRetornados.CurrentRow.DataBoundItem;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // LÓGICA IMPLEMENTADA
             Pedidos pedido = GetSelecionado();
            if (pedido == null) return;

            // Ação 2 = Alterar
            frmCadPedidos tela = new frmCadPedidos(2, pedido);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                // Recarrega a pesquisa atual para ver a alteração
                AtualizarGrid(txtPesquisa.Text);
            }

        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // LÓGICA IMPLEMENTADA
            Pedidos pedido = GetSelecionado();
            if (pedido == null) return;

            // Confirmação
            if (MessageBox.Show("Tem certeza que deseja excluir o pedido '" + pedido.IdPedido + "'?",
                                "Confirmação",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                     PedidosContr.Excluir(pedido.IdPedido);

                    MessageBox.Show("Pedido excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recarrega a pesquisa
                    AtualizarGrid(txtPesquisa.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnViualizar_Click(object sender, EventArgs e)
        {
            // LÓGICA IMPLEMENTADA (Botão está escrito "Viualizar" no seu código)
            Pedidos pedido = GetSelecionado();
            if (pedido == null) return;

            // Ação 3 = Visualizar
            frmCadPedidos tela = new frmCadPedidos(3, pedido);
            tela.ShowDialog(); // Apenas abre para ver, não precisa recarregar grid
        }
    }
}
