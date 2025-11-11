using Projeto_EixoZ.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_EixoZ.Services;

namespace Projeto_EixoZ.Controllers
{
    class PedidosController
    {

        DataBaseServices dataBase = new DataBaseServices();

        public int Inserir(Pedidos pedidos)
        {
            //Criando o comando SQL para inserir
            //um novo registro na tabela de clientes
            string query =
                "INSERT INTO PEDIDOS (IdCliente, IdTransportadora, EnderecoEntrega, DataPedido, StatusPedido, Observacao) " +
                "VALUES (@IdCliente, @IdTransportadora, @EnderecoEntrega, @DataPedido, @StatusPedido, @Observacao)";

            SqlCommand command = new SqlCommand(query);
            //Definindo os valores dos parametros
            command.Parameters.AddWithValue("@IdCliente", pedidos.IdCliente);
            command.Parameters.AddWithValue("@IdTransportadora", pedidos.IdTransportadora);
            command.Parameters.AddWithValue("@EnderecoEntrega", pedidos.EnderecoEntrega);
            command.Parameters.AddWithValue("@DataPedido", pedidos.DataPedido);
            command.Parameters.AddWithValue("@StatusPedido", pedidos.StatusPedido);
            command.Parameters.AddWithValue("@Observacao", pedidos.Observacao);
            //Executando o comando SQL e retornando
            //a quantidade de linhas afetadas
            return dataBase.ExecuteSQL(command);
        }

        //Método publico par alterar o registro
        public int Alterar(Pedidos pedidos)
        {
            //Criando o comando SQL para alterar
            //um registro na tabela de clientes
            string query =
                "UPDATE PEDIDOS SET " +
                "IdCliente = @IdCliente, " +
                "IdTransportadora = @IdTransportadora, " +
                "EnderecoEntrega = @EnderecoEntrega, " +
                "DataPedido = @DataPedido, " +       
                "StatusPedido = @StatusPedido, " + 
                "Observacao = @Observacao " +
                "WHERE IdPedido = @IdPedido";

            SqlCommand command = new SqlCommand(query);
            //Definindo os valores dos parametros
            command.Parameters.AddWithValue("@IdCliente", pedidos.IdCliente);
            command.Parameters.AddWithValue("@IdTransportadora", pedidos.IdTransportadora);
            command.Parameters.AddWithValue("@EnderecoEntrega", pedidos.EnderecoEntrega);
            command.Parameters.AddWithValue("@DataPedido", pedidos.DataPedido);
            command.Parameters.AddWithValue("@StatusPedido", pedidos.StatusPedido);
            command.Parameters.AddWithValue("@Observacao", pedidos.Observacao);
            command.Parameters.AddWithValue("@IdPedido", pedidos.IdPedido);

            //Executando o comando SQL e retornando
            //a quantidade de linhas afetadas
            return dataBase.ExecuteSQL(command);
        }

        //Método publico para excluir um registro
        public int Excluir(int pedidoId)
        {
            //Criando o comando SQL para excluir
            //um registro na tabela de clientes
            string query =
                "DELETE FROM PEDIDOS " +
                "WHERE IdPedido = @IdPedido";
            SqlCommand command = new SqlCommand(query);
            //Definindo os valores dos parametros
            command.Parameters.AddWithValue("@IdPedido", pedidoId);
            //Executando o comando SQL e retornando
            //a quantidade de linhas afetadas
            return dataBase.ExecuteSQL(command);
        }

        //Método publico que retorna um objeto do tipo Pedidos
        public Pedidos GetById(int pedidoId)
        {
            //Criando o comando SQL para selecionar
            //um registro na tabela de clientes
            string query =
                "SELECT * " +
                "FROM PEDIDOS " +
                "WHERE IdPedido = @IdPedido" +
                "ORDER BY DataPedido";
            SqlCommand command = new SqlCommand(query);
            //Definindo os valores dos parametros
            command.Parameters.AddWithValue("@IdPedido", pedidoId);
            //Executando o comando SQL e armazenando o resultado
            //em um objeto do tipo DataTable
            DataTable dataTable = dataBase.GetDataTable(command);

            if (dataTable.Rows.Count > 0)
            {
                //Criando um novo objeto do tipo Pedidos
                Pedidos pedidos = new Pedidos();
                // Agora vou indetificar o valor da linha na coluna
                //e atribuir ao objeto
                //Todo dado precisa ser convertido
                //do SQL Server para C#
                pedidos.IdPedido = (int)dataTable.Rows[0]["IdPedido"];
                pedidos.IdCliente = (int)dataTable.Rows[0]["IdCliente"];
                pedidos.IdTransportadora = (int)dataTable.Rows[0]["IdTransportadora"];
                pedidos.EnderecoEntrega = (string)dataTable.Rows[0]["EnderecoEntrega"];
                pedidos.DataPedido = (DateTime)dataTable.Rows[0]["DataPedido"];
                pedidos.StatusPedido = (string)dataTable.Rows[0]["StatusPedido"];
                pedidos.Observacao = (string)dataTable.Rows[0]["Observacao"];

                return pedidos;
            }
            else
                return null;

        }

        //Método publico que retorna uma coleção de Clientes com filtro
        //Adicionado opção de filtro apenas para não ter q repetir código
        public PedidosCollection GetByFilter(string filtro = "")
        {
            //Criando o comando SQL para selecionar
            //todos os registros na tabela de clientes
            string query = "SELECT * FROM PEDIDOS ";

            //Validar se o filtro foi passado no parametro
            if (filtro != "")
                query += " WHERE " + filtro;

            query += " ORDER BY DataPedido";

            SqlCommand command = new SqlCommand(query);

            command.Parameters.AddWithValue("@filtro", filtro);
            //Executando o comando SQL e armazenando o resultado
            //em um objeto do tipo DataTable
            DataTable dataTable = dataBase.GetDataTable(command);
            //Criando um novo objeto do tipo ClienteColletion
            PedidosCollection pedidoss = new PedidosCollection();
            //Percorrendo todas as linhas retornadas no DataTable
            foreach (DataRow row in dataTable.Rows)
            {
                //Criando um novo objeto do tipo Pedidos
                Pedidos pedidos = new Pedidos();
                //Agora vou indetificar o valor da linha na coluna
                //e atribuir ao objeto
                //Todo dado precisa ser convertido
                //do SQL Server para C#
                pedidos.IdPedido = (int)row["IdPedido"];
                pedidos.IdCliente = (int)row["IdCliente"];
                pedidos.IdTransportadora = (int)row["IdTransportadora"];
                pedidos.EnderecoEntrega = (string)row["EnderecoEntrega"];
                pedidos.DataPedido = (DateTime)row["DataPedido"];
                pedidos.StatusPedido = (string)row["StatusPedido"];
                pedidos.Observacao = (string)row["Observacao"];

                //Adicionando o objeto Pedidos na coleção
                pedidoss.Add(pedidos);
            }
            return pedidoss;
        }

        //Método publico que retorna uma coleção de Clientes
        public PedidosCollection GetAll()
        {
            return GetByFilter();
        }

        //Método para consultar po nome
        //Aplicando o filtro diretamente no método
        //Onde é preciso definir o campo e o valor do filtro
        public PedidosCollection GetByData(string value)
        {
            return GetByFilter("DataPedido LIKE '%" + value + "%'");
        }
        public PedidosCollection GetByIdCliente(string value)
        {
            return GetByFilter("IdCliente = " + value );
        }
        public PedidosCollection GetByIdTransportadora(string value)
        {
            return GetByFilter("IdTransportadora =" + value );
        }
        public PedidosCollection GetByIdVendedor(string value)
        {
            return GetByFilter("IdVendedor =" + value );
        }
        public PedidosCollection GetByEndereco(string value)
        {
            return GetByFilter("EnderecoEntrega LIKE '%" + value + "%'");
        }
        public PedidosCollection GetByStatus(string value)
        {
            return GetByFilter("StatusPedido LIKE '%" + value + "%'");
        }
        public PedidosCollection GetByObeservacao(string value)
        {
            return GetByFilter("Observacao LIKE '%" + value + "%'");
        }
    
    }
}
