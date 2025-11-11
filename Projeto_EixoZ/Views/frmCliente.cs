using System;
using System.Collections.Generic; // Necessário para List
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_EixoZ.Controllers;
using Projeto_EixoZ.Models; // IMPORTANTE: Adicione o using dos Models

namespace Projeto_EixoZ.Views
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        ClienteController CLI = new ClienteController();
        private void frmCliente_Load(object sender, EventArgs e)
        {
            // Carrega todos os clientes quando a tela abre
            AtualizarGrid("");
            CBSelec.SelectedIndex = 1; // Deixa "Nome" pré-selecionado
        }

        void AtualizarGrid(string texto)
        {
            try
            {
                dgvDadosRetornados.DataSource = null;

                if (CBSelec.Text == "")
                {
                    dgvDadosRetornados.DataSource = CLI.GetAll();
                }
                else
                {
                    switch (CBSelec.SelectedIndex)
                    {
                        //Id
                        case 0:
                            if (int.TryParse(texto, out int id))
                            {
                                Cliente cliente = CLI.GetById(id);
                                if (cliente != null)
                                {
                                    ClienteCollection lista = new ClienteCollection();
                                    lista.Add(cliente);
                                    dgvDadosRetornados.DataSource = lista;
                                }
                                else
                                {
                                    dgvDadosRetornados.DataSource = null; // ID não encontrado
                                }
                            }
                            else
                            {
                                // Se o texto não for um número, não faz nada ou avisa
                                if (!string.IsNullOrEmpty(texto))
                                {
                                    MessageBox.Show("Por favor, digite um ID numérico válido.");
                                }
                            }
                            break;
                        //Nome
                        case 1:
                            dgvDadosRetornados.DataSource = CLI.GetByName(texto);
                            break;
                        //Idade
                        case 2:
                            if (!int.TryParse(texto, out int idade))
                            {
                                if (!string.IsNullOrEmpty(texto))
                                {
                                    MessageBox.Show("Por favor, digite uma Idade numérica válida.");
                                }
                                break;
                            }
                            dgvDadosRetornados.DataSource = CLI.GetByIdade(texto);
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
                }
            }
            catch (Exception ex)
            {
                // Se algo der errado (ex: erro no SQL do Controller), seremos avisados
                MessageBox.Show("Erro ao pesquisar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lblRegistros.Text = "Registros encontrados: " + dgvDadosRetornados.RowCount.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Ação 1 = Cadastrar
            frmCadastroCliente tela = new frmCadastroCliente(1, null);

            // 5. CORREÇÃO: Atualizar o grid se o cadastro for salvo
            if (tela.ShowDialog() == DialogResult.OK)
            {
                AtualizarGrid(""); // Recarrega o grid
            }
        }

        private Cliente GetClienteSelecionado()
        {
            if (dgvDadosRetornados.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecione um cliente na lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            // Pega o objeto 'Cliente' inteiro da linha selecionada
            return (Cliente)dgvDadosRetornados.CurrentRow.DataBoundItem;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // LÓGICA IMPLEMENTADA
            Cliente cliente = GetClienteSelecionado();
            if (cliente == null) return;

            // Ação 2 = Alterar
            frmCadastroCliente tela = new frmCadastroCliente(2, cliente);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                // Recarrega a pesquisa atual para ver a alteração
                AtualizarGrid(txtPesquisa.Text);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // LÓGICA IMPLEMENTADA
            Cliente cliente = GetClienteSelecionado();
            if (cliente == null) return;

            // Confirmação
            if (MessageBox.Show("Tem certeza que deseja excluir o cliente '" + cliente.Nome + "'?",
                                "Confirmação",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    CLI.Excluir(cliente.ClienteId);

                    MessageBox.Show("Cliente excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            Cliente cliente = GetClienteSelecionado();
            if (cliente == null) return;

            // Ação 3 = Visualizar
            frmCadastroCliente tela = new frmCadastroCliente(3, cliente);
            tela.ShowDialog(); // Apenas abre para ver, não precisa recarregar grid
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid(txtPesquisa.Text);
        }
    }
}