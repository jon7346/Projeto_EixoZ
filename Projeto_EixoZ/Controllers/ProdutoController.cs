using Projeto_EixoZ.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Projeto_EixoZ.Models;

namespace Projeto_EixoZ.Controllers
{
    public class ProdutoController
    {
        DataBaseServices dataBase = new DataBaseServices();

        public int Inserir(Produto produto)
        {
            //Criando o comando SQL para inserir
            //um novo registro na tabela de clientes
            string query =
                "INSERT INTO Produto (NomeProduto, Material, Peso, Tamanho, Preco) " +
                "VALUES (@NomeProduto, @Material, @Peso, @Tamanho, @Preco)";

            SqlCommand command = new SqlCommand(query);
            //Definindo os valores dos parametros
            command.Parameters.AddWithValue("@NomeProduto", produto.NomeProduto);
            command.Parameters.AddWithValue("@Material", produto.Material);
            command.Parameters.AddWithValue("@Peso", produto.Peso);
            command.Parameters.AddWithValue("@Tamanho", produto.Tamanho);
            command.Parameters.AddWithValue("@Preco", produto.Preco);
            //Executando o comando SQL e retornando
            //a quantidade de linhas afetadas
            return dataBase.ExecuteSQL(command);
        }

        //Método publico par alterar o registro
        public int Alterar(Produto produto)
        {
            //Criando o comando SQL para alterar
            //um registro na tabela de clientes
            string query =
                "UPDATE Produto SET " +
                "NomeProduto = @NomeProduto, " +
                "Material = @Material, " +
                "Peso = @Peso, " +
                "Tamanho = @Tamanho " +
                "Preco = @Preco " +
                "WHERE IdProduto = @IdProduto";

            SqlCommand command = new SqlCommand(query);
            //Definindo os valores dos parametros
            command.Parameters.AddWithValue("@Nome", produto.NomeProduto);
            command.Parameters.AddWithValue("@Idade", produto.Material);
            command.Parameters.AddWithValue("@Email", produto.Peso);
            command.Parameters.AddWithValue("@Senha", produto.Tamanho);
            command.Parameters.AddWithValue("@Enderco", produto.Preco);
            command.Parameters.AddWithValue("@IdProduto", produto.IdProduto);
            //Executando o comando SQL e retornando
            //a quantidade de linhas afetadas
            return dataBase.ExecuteSQL(command);
        }

        //Método publico para excluir um registro
        public int Excluir(int produtoId)
        {
            //Criando o comando SQL para excluir
            //um registro na tabela de clientes
            string query =
                "DELETE FROM Produto " +
                "WHERE IdProduto = @IdProduto";
            SqlCommand command = new SqlCommand(query);
            //Definindo os valores dos parametros
            command.Parameters.AddWithValue("@IdProduto", produtoId);
            //Executando o comando SQL e retornando
            //a quantidade de linhas afetadas
            return dataBase.ExecuteSQL(command);
        }

        //Método publico que retorna um objeto do tipo Produto
        public Produto GetById(int produtoId)
        {
            //Criando o comando SQL para selecionar
            //um registro na tabela de clientes
            string query =
                "SELECT * " +
                "FROM Produto " +
                "WHERE IdProduto = @IdProduto" +
                "ORDER BY Nome";
            SqlCommand command = new SqlCommand(query);
            //Definindo os valores dos parametros
            command.Parameters.AddWithValue("@IdProduto", produtoId);
            //Executando o comando SQL e armazenando o resultado
            //em um objeto do tipo DataTable
            DataTable dataTable = dataBase.GetDataTable(command);

            if (dataTable.Rows.Count > 0)
            {
                //Criando um novo objeto do tipo Produto
                Produto Produto = new Produto();
                // Agora vou indetificar o valor da linha na coluna
                //e atribuir ao objeto
                //Todo dado precisa ser convertido
                //do SQL Server para C#
                Produto.ClienteId = (int)dataTable.Rows[0]["IdProduto"];
                Produto.Nome = (string)dataTable.Rows[0]["Nome"];
                Produto.Idade = (int)dataTable.Rows[0]["Idade"];
                Produto.Email = (string)dataTable.Rows[0]["Email"];
                Produto.Senha = (string)dataTable.Rows[0]["Senha"];
                Produto.Endereco = (string)dataTable.Rows[0]["Endereco"];

                return Produto;
            }
            else
                return null;

        }

        //Método publico que retorna uma coleção de Clientes com filtro
        //Adicionado opção de filtro apenas para não ter q repetir código
        public ProdutoCollection GetByFilter(string filtro = "")
        {
            //Criando o comando SQL para selecionar
            //todos os registros na tabela de clientes
            string query = "SELECT * FROM Produto ";

            //Validar se o filtro foi passado no parametro
            if (filtro != "")
                query += "WHERE @filtro ";

            query += "ORDER BY nome";

            SqlCommand command = new SqlCommand(query);

            command.Parameters.AddWithValue("@filtro", filtro);
            //Executando o comando SQL e armazenando o resultado
            //em um objeto do tipo DataTable
            DataTable dataTable = dataBase.GetDataTable(command);
            //Criando um novo objeto do tipo ClienteColletion
            ProdutoCollection clientes = new ProdutoCollection();
            //Percorrendo todas as linhas retornadas no DataTable
            foreach (DataRow row in dataTable.Rows)
            {
                //Criando um novo objeto do tipo Produto
                Produto Produto = new Produto();
                //Agora vou indetificar o valor da linha na coluna
                //e atribuir ao objeto
                //Todo dado precisa ser convertido
                //do SQL Server para C#
                Produto.ClienteId = (int)row["IdProduto"];
                Produto.Nome = (string)row["nome"];
                Produto.Idade = (int)row["Idade"];
                Produto.Email = (string)row["email"];
                Produto.Senha = (string)row["senha"];
                Produto.Endereco = (string)row["Endereco"];
                //Adicionando o objeto Produto na coleção
                clientes.Add(Produto);
            }
            return clientes;
        }

        //Método publico que retorna uma coleção de Clientes
        public ProdutoCollection GetAll()
        {
            return GetByFilter();
        }

        //Método para consultar po nome
        //Aplicando o filtro diretamente no método
        //Onde é preciso definir o campo e o valor do filtro
        public ProdutoCollection GetByName(string value)
        {
            return GetByFilter("Nome LIKE '%" + value + "%'");
        }

        //Método para consultar por email
        public ProdutoCollection GetByEmail(string value)
        {
            return GetByFilter("Email = " + value);
        }
    }
}
