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
using static System.Net.Mime.MediaTypeNames;

namespace Projeto_EixoZ.Views
{
    public partial class frmCliente: Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        ClienteController CLI = new ClienteController();


        void AtualizarGrid(string texto)
        {
            dgvDadosRetornados.DataSource = null;

            if(CBSelec.Text == "") 
                
            {
                dgvDadosRetornados.DataSource = CLI.GetAll();
                MessageBox.Show("Retornando todos os dados! Caso queria, por favor selecione um campo para pesquisa !"); }
            else
                switch (CBSelec.SelectedIndex)
                {   //Id
                    case 0:
                        dgvDadosRetornados.DataSource = CLI.GetById(int.Parse(texto.ToString()));
                        break;
                    //Nome
                    case 1:
                        dgvDadosRetornados.DataSource = CLI.GetByName(texto);
                        break;
                    //Idade
                    case 2:
                        dgvDadosRetornados.DataSource = CLI.GetByIdade(texto.ToString());
                        break;
                    //Email
                    case 3:
                        dgvDadosRetornados.DataSource = CLI.GetByEmail(texto);
                        break;
                    //Endereço
                    case 4:
                        dgvDadosRetornados.DataSource = CLI.GetByEndereco(texto);
                        break;
                }
    
            lblRegistros.Text = "Registros encontrados: " + dgvDadosRetornados.RowCount.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnViualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid(txtPesquisa.Text);
        }
    }
}
