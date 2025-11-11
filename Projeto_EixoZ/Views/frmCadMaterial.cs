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
using Projeto_EixoZ.Models;

namespace Projeto_EixoZ.Views
{
    public partial class frmCadMaterial: Form
    {
        MateriaisController materiaisController = new MateriaisController();
        public frmCadMaterial(int acao = 1, Materiais materiais = null)
        {
            InitializeComponent();
            DefinirModoTela(acao, materiais);
        }
        private void DefinirModoTela(int acao, Materiais materiais)
        {
            // Carrega os dados do material se fornecido
            if (materiais != null)
                CarregarDados(materiais);
            // Define o título da janela com base na ação
            switch (acao)
            {
                case 1:
                    this.Text = "Cadastrar Material"; // Título para cadastro
                    break;
                case 2:
                    this.Text = "Editar Material"; // Título para edição
                    break;
                case 3:
                    this.Text = "Visualizar Material"; // Título para visualização
                    DesativarCampos();
                    break;
            }
        }

        void DesativarCampos() // Desativa os campos para visualização apenas
        {
            txtIDCadMaterial.ReadOnly = true;   
            txtNomeCadMaterial.ReadOnly = true;
            txtMtlCadMaterial.ReadOnly = true;
            txtPesoCadMaterial.ReadOnly = true;

            // Desativa os ComboBoxes
            cbxTipo.Enabled = false;
            cbxMarca.Enabled = false;

            // Oculta os botões de salvar e limpar
            btnClrCadProd.Visible = true;
            btnClrCadProd.Text = "Fechar";
            btnSalvarCadProd.Visible = false;
        }

        void CarregarDados(Materiais materiais)
        {
            // Preenche os campos com os dados do material
            txtIDCadMaterial.Text = materiais.IdMaterial.ToString();
            txtNomeCadMaterial.Text = materiais.NomeFornecedor;
            txtMtlCadMaterial.Text = materiais.MateriaPrima;
            txtPesoCadMaterial.Text = materiais.PesoProduto.ToString();
            cbxTipo.SelectedItem = materiais.Tipo;
            cbxMarca.SelectedItem = materiais.Marca;
        }

        private void btnSalvarCadProd_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validação dos campos obrigatórios
                // Verifica se os campos obrigatórios estão preenchidos
                if (string.IsNullOrWhiteSpace(txtNomeCadMaterial.Text) ||
                string.IsNullOrWhiteSpace(txtMtlCadMaterial.Text) ||
                cbxTipo.SelectedItem == null ||
                cbxMarca.SelectedItem == null)
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios!");
                    return;
                }

                // Tenta converter o peso para decimal
                // Se a conversão falhar, exibe uma mensagem de erro
                if (!decimal.TryParse(txtPesoCadMaterial.Text, out decimal peso))
                {
                    MessageBox.Show("Peso inválido. Digite um valor numérico.");
                    return;
                } 

                Materiais materiais = new Materiais
                {
                    NomeFornecedor = txtNomeCadMaterial.Text,
                    MateriaPrima = txtMtlCadMaterial.Text,
                    PesoProduto = peso,
                    Tipo = cbxTipo.SelectedItem.ToString(),
                    Marca = cbxMarca.SelectedItem.ToString()
                };

                int resultado;
                if (string.IsNullOrEmpty(txtIDCadMaterial.Text))
                {
                    // Se o ID está vazio, é um INSERT
                    resultado = materiaisController.Inserir(materiais);
                }
                else
                {
                    // Se o ID tem valor, é um UPDATE
                    materiais.IdMaterial = int.Parse(txtIDCadMaterial.Text); 
                    resultado = materiaisController.Alterar(materiais);
                }

                if (resultado > 0)
                {
                    MessageBox.Show("Pedido salvo com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao salvar pedido.");
                }
            }
            catch (Exception ex)
            {
                // A rede de segurança que pega qualquer erro
                MessageBox.Show(
                    "Ocorreu um erro: " + ex.Message + "\n\nDetalhes: " + ex.ToString(),
                    "Erro Crítico",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnClrCadProd_Click(object sender, EventArgs e)
        {
            if (btnSalvarCadProd.Visible == false)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                DialogResult = DialogResult.Cancel;
                this.Close();

            }
        }
    }
}
