using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_EixoZ.Controllers;

namespace Projeto_EixoZ.Views
{
    public partial class frmMaterial: Form
    {
        public frmMaterial()
        {
            InitializeComponent();

        }
        MateriaisController Materiais  = new MateriaisController();
        void AtualizarGrid(string texto)
        {
            dgvDadosRetornados.DataSource = null;

            if (CBSelec.Text == "")

            {
                dgvDadosRetornados.DataSource = Materiais.GetAll();
                MessageBox.Show("Retornando todos os dados! Caso queria, por favor selecione um campo para pesquisa !");
            }
            else
                switch (CBSelec.SelectedIndex)
        {
                    //id
                    case 0:
                        dgvDadosRetornados.DataSource = Materiais.GetById(int.Parse(texto.ToString()));
                        break;
                    //Materia prima
                    case 1:
                        dgvDadosRetornados.DataSource = Materiais.GetByMateria(texto);
                        break;
                    //nome do fornedor
                    case 2:
                        dgvDadosRetornados.DataSource = Materiais.GetByFornecedor(texto);
                        break;
                    case 3:
                    //peso do produto
                        dgvDadosRetornados.DataSource = Materiais.GetByPeso(texto);
                        break;
                    //tipo 
                    case 4:
                        dgvDadosRetornados.DataSource = Materiais.GetByTipo(texto);
                    break;
                    //marca
                    case 5:
                        dgvDadosRetornados.DataSource = Materiais.GetByMarca(texto);
                    break;
                    
                }

            lblRegistros.Text = "Registros encontrados: " + dgvDadosRetornados.RowCount.ToString();
        }

        private void btnPesquisarProd_Click(object sender, EventArgs e)
        {
            AtualizarGrid(txtPesquisa.Text);

        }
    }
}
