using Projeto_EixoZ.Models;
using Projeto_EixoZ.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_EixoZ.Controllers
{
    class FornecedorController
    {
        
     

            DataBaseServices dataBase = new DataBaseServices();

            public int Inserir(Fornecedor fornecedor)
            {
                //Criando o comando SQL para inserir
                //um novo registro na tabela de clientes
                string query =
                    "INSERT INTO FORNECEDOR (MateriaPrima, NomeFantasia, PesoProduto, Tipo, Marca) " +
                    "VALUES (@MateriaPrima, @NomeFantasia, @PesoProduto, @Tipo, @Marca)";

                SqlCommand command = new SqlCommand(query);
                //Definindo os valores dos parametros
                command.Parameters.AddWithValue("@MateriaPrima", fornecedor.MateriaPrima);
                command.Parameters.AddWithValue("@NomeFantasia", fornecedor.NomeFantasia);
                command.Parameters.AddWithValue("@PesoProduto", fornecedor.PesoProduto);
                command.Parameters.AddWithValue("@Tipo", fornecedor.Tipo);
                command.Parameters.AddWithValue("@Marca", fornecedor.Marca);
                //Executando o comando SQL e retornando
                //a quantidade de linhas afetadas
                return dataBase.ExecuteSQL(command);
            }

            //Método publico par alterar o registro
            public int Alterar(Fornecedor fornecedor)
            {
                //Criando o comando SQL para alterar
                //um registro na tabela de clientes
                string query =
                    "UPDATE FORNECEDOR SET " +
                    "MateriaPrima = @MateriaPrima, " +
                    "NomeFantasia = @NomeFantasia, " +
                    "PesoProduto = @PesoProduto, " +
                    "Tipo = @Tipo " +
                    "Marca = @Marca " +
                    "WHERE IdFornecedor = @IdFornecedor";

                SqlCommand command = new SqlCommand(query);
                //Definindo os valores dos parametros
                command.Parameters.AddWithValue("@MateriaPrima", fornecedor.MateriaPrima);
                command.Parameters.AddWithValue("@NomeFantasia", fornecedor.NomeFantasia);
                command.Parameters.AddWithValue("@PesoProduto", fornecedor.PesoProduto);
                command.Parameters.AddWithValue("@Tipo", fornecedor.Tipo);
                command.Parameters.AddWithValue("@Marca", fornecedor.Marca);
                command.Parameters.AddWithValue("@IdFornecedor", fornecedor.IdFornecedor);
                //Executando o comando SQL e retornando
                //a quantidade de linhas afetadas
                return dataBase.ExecuteSQL(command);
            }

            //Método publico para excluir um registro
            public int Excluir(int fornecedorId)
            {
                //Criando o comando SQL para excluir
                //um registro na tabela de clientes
                string query =
                    "DELETE FROM FORNECEDOR " +
                    "WHERE IdFornecedor = @IdFornecedor";
                SqlCommand command = new SqlCommand(query);
                //Definindo os valores dos parametros
                command.Parameters.AddWithValue("@IdCliente", fornecedorId);
                //Executando o comando SQL e retornando
                //a quantidade de linhas afetadas
                return dataBase.ExecuteSQL(command);
            }

            //Método publico que retorna um objeto do tipo Fornecedor
            public Fornecedor GetById(int fornecedorId)
            {
                //Criando o comando SQL para selecionar
                //um registro na tabela de clientes
                string query =
                    "SELECT * " +
                    "FROM FORNECEDOR " +
                    "WHERE IdFornecedor = @IdFornecedor" +
                    "ORDER BY NomeFantasia";
                SqlCommand command = new SqlCommand(query);
                //Definindo os valores dos parametros
                command.Parameters.AddWithValue("@IdFornecedor", fornecedorId);
                //Executando o comando SQL e armazenando o resultado
                //em um objeto do tipo DataTable
                DataTable dataTable = dataBase.GetDataTable(command);

                if (dataTable.Rows.Count > 0)
                {
                    //Criando um novo objeto do tipo Fornecedor
                    Fornecedor fornecedor = new Fornecedor();
                    // Agora vou indetificar o valor da linha na coluna
                    //e atribuir ao objeto
                    //Todo dado precisa ser convertido
                    //do SQL Server para C#
                    fornecedor.IdFornecedor = (int)dataTable.Rows[0]["IdFornecedor"];
                    fornecedor.MateriaPrima = (string)dataTable.Rows[0]["MateriaPrima"];
                    fornecedor.NomeFantasia = (string)dataTable.Rows[0]["NomeFantasia"];
                    fornecedor.PesoProduto = (decimal)dataTable.Rows[0]["PesoProduto"];
                    fornecedor.Tipo = (string)dataTable.Rows[0]["Tipo"];
                    fornecedor.Marca = (string)dataTable.Rows[0]["Marca"];

                    return fornecedor;
                }
                else
                    return null;

            }

            //Método publico que retorna uma coleção de Clientes com filtro
            //Adicionado opção de filtro apenas para não ter q repetir código
            public FornecedorCollection GetByFilter(string filtro = "")
            {
                //Criando o comando SQL para selecionar
                //todos os registros na tabela de clientes
                string query = "SELECT * FROM FORNECEDOR ";

                //Validar se o filtro foi passado no parametro
                if (filtro != "")
                    query += "WHERE @filtro ";

                query += "ORDER BY NomeFantasia";

                SqlCommand command = new SqlCommand(query);

                command.Parameters.AddWithValue("@filtro", filtro);
                //Executando o comando SQL e armazenando o resultado
                //em um objeto do tipo DataTable
                DataTable dataTable = dataBase.GetDataTable(command);
                //Criando um novo objeto do tipo ClienteColletion
                FornecedorCollection fornecedores = new FornecedorCollection();
                //Percorrendo todas as linhas retornadas no DataTable
                foreach (DataRow row in dataTable.Rows)
                {
                    //Criando um novo objeto do tipo Fornecedor
                    Fornecedor fornecedor = new Fornecedor();
                    //Agora vou indetificar o valor da linha na coluna
                    //e atribuir ao objeto
                    //Todo dado precisa ser convertido
                    //do SQL Server para C#
                    fornecedor.IdFornecedor = (int)row["IdFornecedor"];
                    fornecedor.MateriaPrima = (string)row["MateriaPrima"];
                    fornecedor.NomeFantasia = (string)row["NomeFantasia"];
                    fornecedor.PesoProduto = (decimal)row["PesoProduto"];
                    fornecedor.Tipo = (string)row["Tipo"];
                    fornecedor.Marca = (string)row["Marca"];
                    //Adicionando o objeto fornecedor na coleção
                    fornecedores.Add(fornecedor);
                }
                return fornecedores;
            }

            //Método publico que retorna uma coleção de Clientes
            public FornecedorCollection GetAll()
            {
                return GetByFilter();
            }

            //Método para consultar po nome
            //Aplicando o filtro diretamente no método
            //Onde é preciso definir o campo e o valor do filtro
            public FornecedorCollection GetByName(string value)
            {
                return GetByFilter("NomeFantasia LIKE '%" + value + "%'");
            }

    }
}
