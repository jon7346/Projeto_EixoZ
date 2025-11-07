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
    class VendedorController
    {
        DataBaseServices dataBase = new DataBaseServices();

        public int Inserir(Vendedor vendedor)
        {
            //Criando o comando SQL para inserir
            //um novo registro na tabela de clientes
            string query =
                "INSERT INTO Vendedor (Nome, Idade, Email, Senha, Endereco) " +
                "VALUES (@Nome, @Idade, @Email, @Senha, @Endereco)";

            SqlCommand command = new SqlCommand(query);
            //Definindo os valores dos parametros
            command.Parameters.AddWithValue("@Nome", vendedor.Nome);
            command.Parameters.AddWithValue("@Idade", vendedor.Idade);
            command.Parameters.AddWithValue("@Email", vendedor.Email);
            command.Parameters.AddWithValue("@Senha", vendedor.Senha);
            command.Parameters.AddWithValue("@Enderco", vendedor.Endereco);
            //Executando o comando SQL e retornando
            //a quantidade de linhas afetadas
            return dataBase.ExecuteSQL(command);
        }

        //Método publico par alterar o registro
        public int Alterar(Vendedor vendedor)
        {
            //Criando o comando SQL para alterar
            //um registro na tabela de clientes
            string query =
                "UPDATE vendedor SET " +
                "Nome = @Nome, " +
                "Idade = @Idade, " +
                "Email = @Email, " +
                "Senha = @Senha " +
                "Endereco = @Endereco " +
                "WHERE IdVendedor = @IdVendedor";

            SqlCommand command = new SqlCommand(query);
            //Definindo os valores dos parametros
            command.Parameters.AddWithValue("@Nome", vendedor.Nome);
            command.Parameters.AddWithValue("@Idade", vendedor.Idade);
            command.Parameters.AddWithValue("@Email", vendedor.Email);
            command.Parameters.AddWithValue("@Senha", vendedor.Senha);
            command.Parameters.AddWithValue("@Enderco", vendedor.Endereco);
            command.Parameters.AddWithValue("@IdVendedor", vendedor.IdVendedor);
            //Executando o comando SQL e retornando
            //a quantidade de linhas afetadas
            return dataBase.ExecuteSQL(command);
        }

        //Método publico para excluir um registro
        public int Excluir(int idVendedor)
        {
            //Criando o comando SQL para excluir
            //um registro na tabela de clientes
            string query =
                "DELETE FROM vendedor " +
                "WHERE IdVendedor = @IdVendedor";
            SqlCommand command = new SqlCommand(query);
            //Definindo os valores dos parametros
            command.Parameters.AddWithValue("@IdCliente", idVendedor);
            //Executando o comando SQL e retornando
            //a quantidade de linhas afetadas
            return dataBase.ExecuteSQL(command);
        }

        //Método publico que retorna um objeto do tipo vendedor
        public Vendedor GetById(int idVendedor)
        {
            //Criando o comando SQL para selecionar
            //um registro na tabela de clientes
            string query =
                "SELECT * " +
                "FROM vendedor " +
                "WHERE IdVendedor = @IdVendedor" +
                "ORDER BY Nome";
            SqlCommand command = new SqlCommand(query);
            //Definindo os valores dos parametros
            command.Parameters.AddWithValue("@IdVendedor", idVendedor);
            //Executando o comando SQL e armazenando o resultado
            //em um objeto do tipo DataTable
            DataTable dataTable = dataBase.GetDataTable(command);

            if (dataTable.Rows.Count > 0)
            {
                //Criando um novo objeto do tipo vendedor
                Vendedor vendedor = new Vendedor();
                // Agora vou indetificar o valor da linha na coluna
                //e atribuir ao objeto
                //Todo dado precisa ser convertido
                //do SQL Server para C#
                vendedor.IdVendedor = (int)dataTable.Rows[0]["idVendedor"];
                vendedor.Nome = (string)dataTable.Rows[0]["Nome"];
                vendedor.Idade = (int)dataTable.Rows[0]["Idade"];
                vendedor.Email = (string)dataTable.Rows[0]["Email"];
                vendedor.Senha = (string)dataTable.Rows[0]["Senha"];
                vendedor.Endereco = (string)dataTable.Rows[0]["Endereco"];

                return vendedor;
            }
            else
                return null;

        }

        //Método publico que retorna uma coleção de Clientes com filtro
        //Adicionado opção de filtro apenas para não ter q repetir código
        public VendedorCollection GetByFilter(string filtro = "")
        {
            //Criando o comando SQL para selecionar
            //todos os registros na tabela de clientes
            string query = "SELECT * FROM vendedor ";

            //Validar se o filtro foi passado no parametro
            if (filtro != "")
                query += "WHERE @filtro ";

            query += "ORDER BY Nome";

            SqlCommand command = new SqlCommand(query);

            command.Parameters.AddWithValue("@filtro", filtro);
            //Executando o comando SQL e armazenando o resultado
            //em um objeto do tipo DataTable
            DataTable dataTable = dataBase.GetDataTable(command);
            //Criando um novo objeto do tipo ClienteColletion
            VendedorCollection Vendedores = new VendedorCollection();
            //Percorrendo todas as linhas retornadas no DataTable
            foreach (DataRow row in dataTable.Rows)
            {
                //Criando um novo objeto do tipo vendedor
                Vendedor vendedor = new Vendedor();
                //Agora vou indetificar o valor da linha na coluna
                //e atribuir ao objeto
                //Todo dado precisa ser convertido
                //do SQL Server para C#
                vendedor.IdVendedor = (int)row["idVendedor"];
                vendedor.Nome = (string)row["Nome"];
                vendedor.Idade = (int)row["Idade"];
                vendedor.Email = (string)row["email"];
                vendedor.Senha = (string)row["senha"];
                vendedor.Endereco = (string)row["Endereco"];
                //Adicionando o objeto vendedor na coleção
                Vendedores.Add(vendedor);
            }
            return Vendedores;
        }

        //Método publico que retorna uma coleção de Clientes
        public VendedorCollection GetAll()
        {
            return GetByFilter();
        }

        //Método para consultar po nome
        //Aplicando o filtro diretamente no método
        //Onde é preciso definir o campo e o valor do filtro
        public VendedorCollection GetByName(string value)
        {
            return GetByFilter("Nome LIKE '%" + value + "%'");
        }

        //Método para consultar por email
        public VendedorCollection GetByEmail(string value)
        {
            return GetByFilter("Email = " + value);
        }
    }
}
