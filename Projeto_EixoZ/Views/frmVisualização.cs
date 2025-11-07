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
    public partial class frmVisualização: Form
    {
       
        public frmVisualização()
        {
            ClienteController CLIControler = new ClienteController();
            //MaterialController FORController = new MaterialController();
            PedidosController PEDControler = new PedidosController(); 
            
            InitializeComponent();

            void AtualizarGrid()
            {
                dgvDados.DataSource = null;
        
                dgvDados.DataSource = CLIControler.GetAll();
                
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
    }
}
