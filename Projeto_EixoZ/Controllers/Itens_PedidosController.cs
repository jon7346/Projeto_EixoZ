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
    class Itens_PedidosController
    {

        DataBaseServices dataBase = new DataBaseServices();

        public int Inserir(Itens_Pedidos itenspedidos)
        {
            //Criando o comando SQL para inserir
            //um novo registro na tabela de clientes
            string query =
                "INSERT INTO ITENS_PEDIDOS (IdPedido, IdProduto, Quantidade, PrecoUnitarioVenda) " +
                "VALUES (@IdPedido, @IdProduto, @Quantidade, @PrecoUnitarioVenda)";

            SqlCommand command = new SqlCommand(query);
            //Definindo os valores dos parametros
            command.Parameters.AddWithValue("@IdPedido", itenspedidos.IdPedido);
            command.Parameters.AddWithValue("@IdProduto", itenspedidos.IdProduto);
            command.Parameters.AddWithValue("@Quantidade", itenspedidos.Quantidade);
            command.Parameters.AddWithValue("@PrecoUnitarioVenda", itenspedidos.PrecoUnitarioVenda);

            //a quantidade de linhas afetadas
            return dataBase.ExecuteSQL(command);
        }

        //Método publico par alterar o registro
        public int Alterar(Itens_Pedidos itenspedidos)
        {
            //Criando o comando SQL para alterar
            //um registro na tabela de clientes
            string query =
                "UPDATE ITENS_PEDIDOS SET " +
                "IdPedido = @IdPedido, " +
                "IdProduto = @IdProduto, " +
                "Quantidade = @Quantidade, " +
                "PrecoUnitarioVenda = @PrecoUnitarioVenda " +
                "WHERE IdItemPedido = @IdItemPedido";

            SqlCommand command = new SqlCommand(query);
            //Definindo os valores dos parametros
            command.Parameters.AddWithValue("@IdItemPedido", itenspedidos.IdItemPedido);
            command.Parameters.AddWithValue("@IdPedido", itenspedidos.IdPedido);
            command.Parameters.AddWithValue("@IdProduto", itenspedidos.IdProduto);
            command.Parameters.AddWithValue("@Quantidade", itenspedidos.Quantidade);
            command.Parameters.AddWithValue("@PrecoUnitarioVenda", itenspedidos.PrecoUnitarioVenda);


            //Executando o comando SQL e retornando
            //a quantidade de linhas afetadas
            return dataBase.ExecuteSQL(command);
        }

        //Método publico para excluir um registro
        public int Excluir(int itenspedidosId)
        {
            //Criando o comando SQL para excluir
            //um registro na tabela de clientes
            string query =
                "DELETE FROM ITENS_PEDIDOS " +
                "WHERE IdItemPedido = @IdItemPedido";
            SqlCommand command = new SqlCommand(query);
            //Definindo os valores dos parametros
            command.Parameters.AddWithValue("@IdItemPedido", itenspedidosId);
            //Executando o comando SQL e retornando
            //a quantidade de linhas afetadas
            return dataBase.ExecuteSQL(command);
        }

        //Método publico que retorna um objeto do tipo Itens_Pedidos
        public Itens_Pedidos GetById(int itenspedidosId)
        {
            //Criando o comando SQL para selecionar
            //um registro na tabela de clientes
            string query =
                "SELECT * " +
                "FROM ITENS_PEDIDOS " +
                "WHERE IdItemPedido = @IdItemPedido" +
                "ORDER BY IdPedido";
            SqlCommand command = new SqlCommand(query);
            //Definindo os valores dos parametros
            command.Parameters.AddWithValue("@IdItemPedido", itenspedidosId);
            //Executando o comando SQL e armazenando o resultado
            //em um objeto do tipo DataTable
            DataTable dataTable = dataBase.GetDataTable(command);

            if (dataTable.Rows.Count > 0)
            {
                //Criando um novo objeto do tipo Itens_Pedidos
                Itens_Pedidos itenspedidos = new Itens_Pedidos();
                // Agora vou indetificar o valor da linha na coluna
                //e atribuir ao objeto
                //Todo dado precisa ser convertido
                //do SQL Server para C#
                itenspedidos.IdItemPedido = (int)dataTable.Rows[0]["IdItemPedido"];
                itenspedidos.IdPedido = (int)dataTable.Rows[0]["IdPedido"];
                itenspedidos.IdProduto = (int)dataTable.Rows[0]["IdProduto"];
                itenspedidos.Quantidade = (int)dataTable.Rows[0]["Quantidade"];
                itenspedidos.PrecoUnitarioVenda = (decimal)dataTable.Rows[0]["PrecoUnitarioVenda"];


                return itenspedidos;
            }
            else
                return null;

        }

        //Método publico que retorna uma coleção de Clientes com filtro
        //Adicionado opção de filtro apenas para não ter q repetir código
        public Itens_PedidosCollection GetByFilter(string filtro = "")
        {
            //Criando o comando SQL para selecionar
            //todos os registros na tabela de clientes
            string query = "SELECT * FROM ITENS_PEDIDOS ";

            //Validar se o filtro foi passado no parametro
            if (filtro != "")
                query += "WHERE @filtro ";

            query += "ORDER BY IdPedido";

            SqlCommand command = new SqlCommand(query);

            command.Parameters.AddWithValue("@filtro", filtro);
            //Executando o comando SQL e armazenando o resultado
            //em um objeto do tipo DataTable
            DataTable dataTable = dataBase.GetDataTable(command);
            //Criando um novo objeto do tipo ClienteColletion
            Itens_PedidosCollection itenspedidoss = new Itens_PedidosCollection();
            //Percorrendo todas as linhas retornadas no DataTable
            foreach (DataRow row in dataTable.Rows)
            {
                //Criando um novo objeto do tipo Itens_Pedidos
                Itens_Pedidos itenspedidos = new Itens_Pedidos();
                //Agora vou indetificar o valor da linha na coluna
                //e atribuir ao objeto
                //Todo dado precisa ser convertido
                //do SQL Server para C#
                itenspedidos.IdItemPedido = (int)row["IdPedido"];
                itenspedidos.IdPedido = (int)row["IdCliente"];
                itenspedidos.IdProduto = (int)row["IdTransportadora"];
                itenspedidos.Quantidade = (int)row["EnderecoEntrega"];
                itenspedidos.PrecoUnitarioVenda = (decimal)row["DataPedido"];


                //Adicionando o objeto Itens_Pedidos na coleção
                itenspedidoss.Add(itenspedidos);
            }
            return itenspedidoss;
        }

        //Método publico que retorna uma coleção de Clientes
        public Itens_PedidosCollection GetAll()
        {
            return GetByFilter();
        }

        //Método para consultar po nome
        //Aplicando o filtro diretamente no método
        //Onde é preciso definir o campo e o valor do filtro
        public Itens_PedidosCollection GetByName(string value)
        {
            return GetByFilter("IdPedido LIKE '%" + value + "%'");
        }
    }
}
