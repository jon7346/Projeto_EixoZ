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
using Projeto_EixoZ.Models;

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
            try {
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
                            if (!string.IsNullOrEmpty(txtPesquisa.Text) && int.TryParse(texto, out int id))
                            {
                                MateriaisCollection lista = new MateriaisCollection();
                                lista.Add(Materiais.GetById(int.Parse(texto)));
                                dgvDadosRetornados.DataSource = lista;
                                break;
                            }
                            else
                            {

                                MessageBox.Show("Preencha o campo de pesquisa com um valor numérico válido ");
                                break;
                            }
                             ;
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
            catch (Exception ex)
            {
                // Se algo der errado (ex: erro no SQL do Controller), seremos avisados
                MessageBox.Show("Erro ao pesquisar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lblRegistros.Text = "Registros encontrados: " + dgvDadosRetornados.RowCount.ToString();
        }

        private void btnPesquisarProd_Click(object sender, EventArgs e)
        {
            AtualizarGrid(txtPesquisa.Text);

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Ação 1 = Cadastrar
            frmCadMaterial tela = new frmCadMaterial(1, null);

            // 5. CORREÇÃO: Atualizar o grid se o cadastro for salvo
            if (tela.ShowDialog() == DialogResult.OK)
            {
                AtualizarGrid(""); // Recarrega o grid
            }
        }

        private Materiais GetSelecionado()
        {
            if (dgvDadosRetornados.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecione um material da lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            // Pega o objeto 'Cliente' inteiro da linha selecionada
            return (Materiais)dgvDadosRetornados.CurrentRow.DataBoundItem;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // LÓGICA IMPLEMENTADA
            Materiais material = GetSelecionado();
            if (Materiais == null) return;

            // Ação 2 = Alterar
            frmCadMaterial tela = new frmCadMaterial(2, material);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                // Recarrega a pesquisa atual para ver a alteração
                AtualizarGrid(txtPesquisa.Text);
            }

        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // LÓGICA IMPLEMENTADA
            Materiais materiais = GetSelecionado();
            if (materiais == null) return;

            // Confirmação
            if (MessageBox.Show("Tem certeza que deseja excluir o material '" + materiais.MateriaPrima + "'?",
                                "Confirmação",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Materiais.Excluir(materiais.IdMaterial);

                    MessageBox.Show("Material excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            Materiais materiais = GetSelecionado();
            if (materiais == null) return;

            // Ação 3 = Visualizar
            frmCadMaterial tela = new frmCadMaterial(3, materiais);
            tela.ShowDialog(); // Apenas abre para ver, não precisa recarregar grid
        }


    }
}
