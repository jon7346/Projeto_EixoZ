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
    public partial class frmVisualizaçãoCoringa: Form
    {
       
        public frmVisualizaçãoCoringa()
        {
            ClienteController CLIControler = new ClienteController();
            MateriaisController FORController = new MateriaisController();
            PedidosController PEDController = new PedidosController();
            VendedorController VENController = new VendedorController();
            TransportadoraController TRANController = new TransportadoraController();
            
            InitializeComponent();

            // Atualiza a lista 
            void AtualizarGrid(ClienteController Cli, MateriaisController Mat)
            {
                dgvDados.DataSource = null;
        
                dgvDados.DataSource = Cli.GetAll();

                

                lblRegistros.Text = "Registros encontrados: " + dgvDados.RowCount.ToString();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch() 
            {
                case 1: 

            }
        }
    }
}
