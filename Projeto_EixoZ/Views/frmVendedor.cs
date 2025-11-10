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
    public partial class frmVendedor: Form
    {
        public frmVendedor()
        {
            InitializeComponent();
        }
        VendedorController Vendedores = new VendedorController();
        void AtualizarGrid(string texto)
        {
            dgvDadosRetornados.DataSource = null;

            if (CBSelec.Text == "")

            {
                dgvDadosRetornados.DataSource = Vendedores.GetAll();
                MessageBox.Show("Retornando todos os dados! Caso queria, por favor selecione um campo para pesquisa !");
            }
            else
                switch (CBSelec.SelectedIndex)
                {
                    //Id
                    case 0:
                        dgvDadosRetornados.DataSource = Vendedores.GetById(int.Parse(texto.ToString()));
                        break;
                    //Nome
                    case 1:
                        dgvDadosRetornados.DataSource = Vendedores.GetByName(texto);
                        break;
                    //Idade
                    case 2:
                        dgvDadosRetornados.DataSource = Vendedores.GetByIdade(texto.ToString());
                        break;
                    //Email
                    case 3:
                        dgvDadosRetornados.DataSource = Vendedores.GetByEmail(texto);
                        break;
                    //Endereço
                    case 4:
                        dgvDadosRetornados.DataSource = Vendedores.GetByEndereco(texto);
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
            frmCadMaterial tela = new frmCadMaterial();           
            tela.ShowDialog();
        }
    }
}
