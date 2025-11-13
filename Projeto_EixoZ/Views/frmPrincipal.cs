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
    public partial class frmPrincipal: Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendedor tela = new frmVendedor();
            tela.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCliente telaCLI = new frmCliente();
            telaCLI.ShowDialog();
        }

        private void pedidosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmPedidos tela = new frmPedidos();
            tela.ShowDialog();
        }

        private void transportadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTransportadora tela = new FrmTransportadora();
            tela.ShowDialog();
        }

        private void materialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterial tela = new frmMaterial();
            tela.ShowDialog();
        }
    }
}
