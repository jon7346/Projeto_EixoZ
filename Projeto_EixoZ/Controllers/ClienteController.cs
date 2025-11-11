using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_EixoZ.Services;
using System.Data;
using System.Data.SqlClient;
using Projeto_EixoZ.Models;
using System.Net;

namespace Projeto_EixoZ.Controllers
{
    public class ClienteController
    {

        DataBaseServices dataBase = new DataBaseServices();

        public int Inserir(Cliente cliente)
        {
            //Criando o comando SQL para inserir
            //um novo registro na tabela de clientes
            string query =
                "INSERT INTO CLIENTE (Nome, Idade, Email, Senha, Endereco) " +
                "VALUES (@Nome, @Idade, @Email, @Senha, @Endereco)";

            SqlCommand command = new SqlCommand(query);
            //Definindo os valores dos parametros
            command.Parameters.AddWithValue("@Nome", cliente.Nome);
            command.Parameters.AddWithValue("@Idade", cliente.Idade);
            command.Parameters.AddWithValue("@Email", cliente.Email);
            command.Parameters.AddWithValue("@Senha", cliente.Senha);
            command.Parameters.AddWithValue("@Endereco", cliente.Endereco);
            //Executando o comando SQL e retornando
            //a quantidade de linhas afetadas
            return dataBase.ExecuteSQL(command);
        }

        //Método publico par alterar o registro
        public int Alterar(Cliente cliente)
        {
            //Criando o comando SQL para alterar
            //um registro na tabela de clientes
            string query =
                "UPDATE CLIENTE SET " +
                "Nome = @Nome, " +
                "Idade = @Idade, " +
                "Email = @Email, " +
                "Senha = @Senha, " +
                "Endereco = @Endereco " +
                "WHERE IdCliente = @IdCliente";

            SqlCommand command = new SqlCommand(query);
            //Definindo os valores dos parametros
            command.Parameters.AddWithValue("@Nome", cliente.Nome);
            command.Parameters.AddWithValue("@Idade", cliente.Idade);
            command.Parameters.AddWithValue("@Email", cliente.Email);
            command.Parameters.AddWithValue("@Senha", cliente.Senha);
            command.Parameters.AddWithValue("@Endereco", cliente.Endereco);
            command.Parameters.AddWithValue("@IdCliente", cliente.ClienteId);
            //Executando o comando SQL e retornando
            //a quantidade de linhas afetadas
            return dataBase.ExecuteSQL(command);
        }

        //Método publico para excluir um registro
        public int Excluir(int clienteId)
        {
            //Criando o comando SQL para excluir
            //um registro na tabela de clientes
            string query =
                "DELETE FROM CLIENTE " +
                "WHERE IdCliente = @IdCliente";
            SqlCommand command = new SqlCommand(query);
            //Definindo os valores dos parametros
            command.Parameters.AddWithValue("@IdCliente", clienteId);
            //Executando o comando SQL e retornando
            //a quantidade de linhas afetadas
            return dataBase.ExecuteSQL(command);
        }

        //Método publico que retorna um objeto do tipo Cliente
        public Cliente GetById(int clienteId)
        {
            //Criando o comando SQL para selecionar
            //um registro na tabela de clientes
            string query =
                "SELECT * " +
                "FROM CLIENTE " +
                "WHERE IdCliente = @IdCliente" +
                "ORDER BY Nome";
            SqlCommand command = new SqlCommand(query);
            //Definindo os valores dos parametros
            command.Parameters.AddWithValue("@IdCliente", clienteId);
            //Executando o comando SQL e armazenando o resultado
            //em um objeto do tipo DataTable
            DataTable dataTable = dataBase.GetDataTable(command);

            if (dataTable.Rows.Count > 0)
            {
                //Criando um novo objeto do tipo Cliente
                Cliente cliente = new Cliente();
                // Agora vou indetificar o valor da linha na coluna
                //e atribuir ao objeto
                //Todo dado precisa ser convertido
                //do SQL Server para C#
                cliente.ClienteId = (int)dataTable.Rows[0]["idCliente"];
                cliente.Nome = (string)dataTable.Rows[0]["Nome"];
                cliente.Idade = (int)dataTable.Rows[0]["Idade"];
                cliente.Email = (string)dataTable.Rows[0]["Email"];
                cliente.Senha = (string)dataTable.Rows[0]["Senha"];
                cliente.Endereco = (string)dataTable.Rows[0]["Endereco"];

                return cliente;
            }
            else
                return null;

        }

        //Método publico que retorna uma coleção de Clientes com filtro
        //Adicionado opção de filtro apenas para não ter q repetir código
        public ClienteCollection GetByFilter(string filtro = "")
        {
            //Criando o comando SQL para selecionar
            //todos os registros na tabela de clientes
            string query = "SELECT * FROM CLIENTE ";

            
            //Validar se o filtro foi passado no parametro
            if (filtro != "")
                query += " WHERE " + filtro;

            query += " ORDER BY nome";

            //query += "ORDER BY Nome";
            SqlCommand command = new SqlCommand(query);


            //Executando o comando SQL e armazenando o resultado
            //em um objeto do tipo DataTable
            DataTable dataTable = dataBase.GetDataTable(command);
            //Criando um novo objeto do tipo ClienteColletion
            ClienteCollection clientes = new ClienteCollection();
            //Percorrendo todas as linhas retornadas no DataTable
            foreach (DataRow row in dataTable.Rows)
            {
                //Criando um novo objeto do tipo Cliente
                Cliente cliente = new Cliente();
                //Agora vou indetificar o valor da linha na coluna
                //e atribuir ao objeto
                //Todo dado precisa ser convertido
                //do SQL Server para C#
                cliente.ClienteId = (int)row["idCliente"];
                cliente.Nome = (string)row["Nome"];
                cliente.Idade = (int)row["Idade"];
                cliente.Email = (string)row["email"];
                cliente.Senha = (string)row["senha"];
                cliente.Endereco = (string)row["Endereco"];
                //Adicionando o objeto cliente na coleção
                clientes.Add(cliente);
            }
            return clientes;
        }

        //Método publico que retorna uma coleção de Clientes
        public ClienteCollection GetAll()
        {
            return GetByFilter();
        }

        //Método para consultar po nome
        //Aplicando o filtro diretamente no método
        //Onde é preciso definir o campo e o valor do filtro
        public ClienteCollection GetByName(string value)
        {
            return GetByFilter("Nome LIKE '%" + value + "%'");
        }

        //Método para consultar por email
        public ClienteCollection GetByEmail(string value)
        {
            return GetByFilter("Email LIKE '%" + value + "%'");
        }

        public ClienteCollection GetByEndereco(string value)
        {
            return GetByFilter("Endereco LIKE '%" + value + "%'");
        }
        
            public ClienteCollection GetByIdade(string value)
        {
            return GetByFilter("Idade = " + value);
        }

    }  
}
