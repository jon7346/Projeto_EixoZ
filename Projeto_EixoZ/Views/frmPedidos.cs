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

        PedidosController Pedidos = new PedidosController();
       
        void AtualizarGrid(string texto)
        {
            dgvDadosRetornados.DataSource = null;

            if (CBSelec.Text == "")

            {
                dgvDadosRetornados.DataSource = Pedidos.GetAll();
                MessageBox.Show("Retornando todos os dados! Caso queria, por favor selecione um campo para pesquisa !");
            }
            else
                switch (CBSelec.SelectedIndex)
                {
                    //id
                    case 0:
                        dgvDadosRetornados.DataSource = Pedidos.GetById(int.Parse(texto.ToString()));
                        break;
                    // Id da transportadora 
                    case 1:
                        dgvDadosRetornados.DataSource = Pedidos.GetByIdTransportadora(texto);
                        break;
                    //Id do vendedor 
                    case 2:
                        dgvDadosRetornados.DataSource = Pedidos.GetByIdVendedor(texto);
                        break;
                    // Endereço de entrega
                    case 3:
                     
                        dgvDadosRetornados.DataSource = Pedidos.GetByEndereco(texto);
                        break;
                    //  Data do Pedido 
                    case 4:
                        dgvDadosRetornados.DataSource = Pedidos.GetByData(texto);
                        break;
                    // Status do Pedido 
                    case 5:
                        dgvDadosRetornados.DataSource = Pedidos.GetByStatus(texto);
                        break;
                    //Observação
                    case 6:
                        dgvDadosRetornados.DataSource = Pedidos.GetByObeservacao(texto);
                        break;

                }

            lblRegistros.Text = "Registros encontrados: " + dgvDadosRetornados.RowCount.ToString();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid(txtPesquisa.Text);
        }
    }
}
