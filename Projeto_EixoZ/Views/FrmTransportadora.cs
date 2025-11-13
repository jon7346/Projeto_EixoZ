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
            try
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
                            if (!string.IsNullOrEmpty(txtPesquisa.Text) && int.TryParse(texto, out int id))
                            {
                                TransportadoraCollection lista = new TransportadoraCollection();
                                lista.Add(transportadoras.GetById(int.Parse(texto)));
                                dgvDadosRetornados.DataSource = lista;
                                break;
                            }
                          else
                            {

                                MessageBox.Show("Preencha o campo de pesquisa com um valor numérico válido ");
                                break;
                            }
                             ;
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
            }
            catch (Exception ex)
            {
                // Se algo der errado (ex: erro no SQL do Controller), seremos avisados
                MessageBox.Show("Erro ao pesquisar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lblRegistros.Text = "Registros encontrados: " + dgvDadosRetornados.RowCount.ToString();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid(txtPesquisa.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Ação 1 = Cadastrar
            frmCadTransportadora tela = new frmCadTransportadora(1, null);

            // 5. CORREÇÃO: Atualizar o grid se o cadastro for salvo
            if (tela.ShowDialog() == DialogResult.OK)
            {
                AtualizarGrid(""); // Recarrega o grid
            }
        }

        private Transportadora GetTransportadoraSelecionado()
        {
            if (dgvDadosRetornados.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecione uma Transportadora da lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            // Pega o objeto 'Cliente' inteiro da linha selecionada
            return (Transportadora)dgvDadosRetornados.CurrentRow.DataBoundItem;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // LÓGICA IMPLEMENTADA
            Transportadora transportadora = GetTransportadoraSelecionado();
            if (transportadora == null) return;

            // Ação 2 = Alterar
            frmCadTransportadora tela = new frmCadTransportadora(2, transportadora);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                // Recarrega a pesquisa atual para ver a alteração
                AtualizarGrid(txtPesquisa.Text);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // LÓGICA IMPLEMENTADA
            Transportadora transportadora = GetTransportadoraSelecionado();
            if (transportadora  == null) return;

            // Confirmação
            if (MessageBox.Show("Tem certeza que deseja excluir a transportadora '" + transportadora.NomeFantasia + "'?",
                                "Confirmação",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    transportadoras.Excluir(transportadora.IdTransportadora);

                    MessageBox.Show("Transportadora excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            Transportadora transportadora = GetTransportadoraSelecionado();
            if (transportadora == null) return;

            // Ação 3 = Visualizar
            frmCadTransportadora tela = new frmCadTransportadora(3, transportadora);
            tela.ShowDialog(); // Apenas abre para ver, não precisa recarregar grid
        }

        

    }
}
