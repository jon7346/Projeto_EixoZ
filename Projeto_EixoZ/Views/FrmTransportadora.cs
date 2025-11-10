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
    public partial class FrmTransportadora: Form
    {
        public FrmTransportadora()
        {
            InitializeComponent();

        }
        TransportadoraController transportadoras = new TransportadoraController();
        void AtualizarGrid(string texto)
        {
            dgvDadosRetornados.DataSource = null;

            if (CBSelec.Text == "")

            {
                dgvDadosRetornados.DataSource = transportadoras.GetAll();
                MessageBox.Show("Retornando todos os dados! Caso queria, por favor selecione um campo para pesquisa !");
            }
            else
               
                switch (CBSelec.SelectedIndex)
                {
                    //Id
                    case 0:
                        dgvDadosRetornados.DataSource = transportadoras.GetById(int.Parse(texto.ToString()));
                        break;
                    //Nome
                    case 1:
                        dgvDadosRetornados.DataSource = transportadoras.GetByName(texto);
                        break;
                    //Meio de transporte
                    case 2:
                        dgvDadosRetornados.DataSource = transportadoras.GetByMeioTransporte(texto.ToString());
                        break;
                    //Preço Médio
                    case 3:
                        dgvDadosRetornados.DataSource = transportadoras.GetByPrecoMedio(texto);
                        break;
                    //Obeservação
                    case 4:
                        dgvDadosRetornados.DataSource = transportadoras.GetByObservacao(texto);
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
            frmCadTransportadora tela = new frmCadTransportadora();
            tela.ShowDialog();
        }
    }
}
