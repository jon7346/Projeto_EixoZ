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
            string query =
                "INSERT INTO ITENS_PEDIDOS (IdPedido, IdMaterial, Quantidade, PrecoUnitarioVenda) " +
                "VALUES (@IdPedido, @IdMaterial, @Quantidade, @PrecoUnitarioVenda)";

            SqlCommand command = new SqlCommand(query);

            command.Parameters.AddWithValue("@IdPedido", itenspedidos.IdPedido);
            command.Parameters.AddWithValue("@IdMaterial", itenspedidos.IdMaterial);
            command.Parameters.AddWithValue("@Quantidade", itenspedidos.Quantidade);
            command.Parameters.AddWithValue("@PrecoUnitarioVenda", itenspedidos.PrecoUnitarioVenda);

            return dataBase.ExecuteSQL(command);
        }

        public int Alterar(Itens_Pedidos itenspedidos)
        {
            string query =
                "UPDATE ITENS_PEDIDOS SET " +
                "IdPedido = @IdPedido, " +
                "IdMaterial = @IdMaterial, " +
                "Quantidade = @Quantidade, " +
                "PrecoUnitarioVenda = @PrecoUnitarioVenda " +
                "WHERE IdItemPedido = @IdItemPedido";

            SqlCommand command = new SqlCommand(query);

            command.Parameters.AddWithValue("@IdItemPedido", itenspedidos.IdItemPedido);
            command.Parameters.AddWithValue("@IdPedido", itenspedidos.IdPedido);
            command.Parameters.AddWithValue("@IdMaterial", itenspedidos.IdMaterial);
            command.Parameters.AddWithValue("@Quantidade", itenspedidos.Quantidade);
            command.Parameters.AddWithValue("@PrecoUnitarioVenda", itenspedidos.PrecoUnitarioVenda);

            return dataBase.ExecuteSQL(command);
        }

        public int Excluir(int itenspedidosId)
        {
            string query =
                "DELETE FROM ITENS_PEDIDOS " +
                "WHERE IdItemPedido = @IdItemPedido";
            SqlCommand command = new SqlCommand(query);

            command.Parameters.AddWithValue("@IdItemPedido", itenspedidosId);

            return dataBase.ExecuteSQL(command);
        }

        public Itens_Pedidos GetById(int itenspedidosId)
        {
            string query =
                "SELECT * " +
                "FROM ITENS_PEDIDOS " +
                "WHERE IdItemPedido = @IdItemPedido" +
                "ORDER BY IdPedido";
            SqlCommand command = new SqlCommand(query);

            command.Parameters.AddWithValue("@IdItemPedido", itenspedidosId);

            DataTable dataTable = dataBase.GetDataTable(command);

            if (dataTable.Rows.Count > 0)
            {
                Itens_Pedidos itenspedidos = new Itens_Pedidos();

                itenspedidos.IdItemPedido = (int)dataTable.Rows[0]["IdItemPedido"];
                itenspedidos.IdPedido = (int)dataTable.Rows[0]["IdPedido"];
                itenspedidos.IdMaterial = (int)dataTable.Rows[0]["IdMaterial"];
                itenspedidos.Quantidade = (int)dataTable.Rows[0]["Quantidade"];
                itenspedidos.PrecoUnitarioVenda = (decimal)dataTable.Rows[0]["PrecoUnitarioVenda"];

                return itenspedidos;
            }
            else
                return null;
        }

        public Itens_PedidosCollection GetByFilter(string filtro = "")
        {
            string query = "SELECT * FROM ITENS_PEDIDOS ";

            if (filtro != "")
                query += " WHERE " + filtro;

            query += " ORDER BY IdPedido";

            SqlCommand command = new SqlCommand(query);

            DataTable dataTable = dataBase.GetDataTable(command);

            Itens_PedidosCollection itenspedidoss = new Itens_PedidosCollection();

            foreach (DataRow row in dataTable.Rows)
            {
                Itens_Pedidos itenspedidos = new Itens_Pedidos();

                itenspedidos.IdItemPedido = (int)row["IdItemPedido"];
                itenspedidos.IdPedido = (int)row["IdPedido"];
                itenspedidos.IdMaterial = (int)row["IdMaterial"];
                itenspedidos.Quantidade = (int)row["Quantidade"];
                itenspedidos.PrecoUnitarioVenda = (decimal)row["PrecoUnitarioVenda"];

                itenspedidoss.Add(itenspedidos);
            }
            return itenspedidoss;
        }

        public Itens_PedidosCollection GetAll()
        {
            return GetByFilter();
        }

        public Itens_PedidosCollection GetByIdPedido(string value)
        {
            return GetByFilter("IdPedido = " + value);
        }
    }
}