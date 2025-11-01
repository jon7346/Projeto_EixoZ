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
    class TransportadoraController
    {
        DataBaseServices dataBase = new DataBaseServices();

        public int Inserir(Transportadora transportadora)
        {
            //Criando o comando SQL para inserir
            //um novo registro na tabela de clientes
            string query =
                "INSERT INTO TRANSPORTADORA (NomeFantasia, MeioDeTransporte, PrecoMedio, Observacao) " +
                "VALUES (@NomeFantasia, @MeioDeTransporte, @PrecoMedio, @Observacao)";

            SqlCommand command = new SqlCommand(query);
            //Definindo os valores dos parametros
            command.Parameters.AddWithValue("@NomeFantasia", transportadora.NomeFantasia);
            command.Parameters.AddWithValue("@MeioDeTransporte", transportadora.MeioDeTransporte);
            command.Parameters.AddWithValue("@PrecoMedio", transportadora.PrecoMedio);
            command.Parameters.AddWithValue("@Observacao", transportadora.Observacao);
            //Executando o comando SQL e retornando
            //a quantidade de linhas afetadas
            return dataBase.ExecuteSQL(command);
        }

        //Método publico par alterar o registro
        public int Alterar(Transportadora transportadora)
        {
            //Criando o comando SQL para alterar
            //um registro na tabela de clientes
            string query =
                "UPDATE TRANSPORTADORA SET " +
                "NomeFantasia = @NomeFantasia, " +
                "MeioDeTransporte = @MeioDeTransporte, " +
                "PrecoMedio = @PrecoMedio, " +
                "Observacao = @Observacao " +
                "WHERE IdTransportadora = @IdTransportadora";

            SqlCommand command = new SqlCommand(query);
            //Definindo os valores dos parametros
            command.Parameters.AddWithValue("@NomeFantasia", transportadora.NomeFantasia);
            command.Parameters.AddWithValue("@MeioDeTransporte", transportadora.MeioDeTransporte);
            command.Parameters.AddWithValue("@PrecoMedio", transportadora.PrecoMedio);
            command.Parameters.AddWithValue("@Observacao", transportadora.Observacao);
            command.Parameters.AddWithValue("@IdTransportadora", transportadora.IdTranportadora);
            //Executando o comando SQL e retornando
            //a quantidade de linhas afetadas
            return dataBase.ExecuteSQL(command);
        }

        //Método publico para excluir um registro
        public int Excluir(int transportadoraId)
        {
            //Criando o comando SQL para excluir
            //um registro na tabela de clientes
            string query =
                "DELETE FROM TRANSPORTADORA " +
                "WHERE IdTransportadora = @IdTransportadora";
            SqlCommand command = new SqlCommand(query);
            //Definindo os valores dos parametros
            command.Parameters.AddWithValue("@IdTransportadora", transportadoraId);
            //Executando o comando SQL e retornando
            //a quantidade de linhas afetadas
            return dataBase.ExecuteSQL(command);
        }

        //Método publico que retorna um objeto do tipo Transportadora
        public Transportadora GetById(int transportadoraId)
        {
            //Criando o comando SQL para selecionar
            //um registro na tabela de clientes
            string query =
                "SELECT * " +
                "FROM TRANSPORTADORA " +
                "WHERE IdTransportadora = @IdTransportadora" +
                "ORDER BY NomeFantasia";
            SqlCommand command = new SqlCommand(query);
            //Definindo os valores dos parametros
            command.Parameters.AddWithValue("@IdTransportadora", transportadoraId);
            //Executando o comando SQL e armazenando o resultado
            //em um objeto do tipo DataTable
            DataTable dataTable = dataBase.GetDataTable(command);

            if (dataTable.Rows.Count > 0)
            {
                //Criando um novo objeto do tipo Transportadora
                Transportadora transportadora = new Transportadora();
                // Agora vou indetificar o valor da linha na coluna
                //e atribuir ao objeto
                //Todo dado precisa ser convertido
                //do SQL Server para C#
                transportadora.IdTranportadora = (int)dataTable.Rows[0]["IdTranportadora"];
                transportadora.NomeFantasia = (string)dataTable.Rows[0]["NomeFantasia"];
                transportadora.MeioDeTransporte = (string)dataTable.Rows[0]["MeioDeTransporte"];
                transportadora.PrecoMedio = (decimal)dataTable.Rows[0]["PrecoMedio"];
                transportadora.Observacao = (string)dataTable.Rows[0]["Observacao"];

                return transportadora;
            }
            else
                return null;

        }

        //Método publico que retorna uma coleção de Clientes com filtro
        //Adicionado opção de filtro apenas para não ter q repetir código
        public TransportadoraCollection GetByFilter(string filtro = "")
        {
            //Criando o comando SQL para selecionar
            //todos os registros na tabela de clientes
            string query = "SELECT * FROM TRANSPORTADORA ";

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
            TransportadoraCollection transportadoras = new TransportadoraCollection();
            //Percorrendo todas as linhas retornadas no DataTable
            foreach (DataRow row in dataTable.Rows)
            {
                //Criando um novo objeto do tipo Transportadora
                Transportadora transportadora = new Transportadora();
                //Agora vou indetificar o valor da linha na coluna
                //e atribuir ao objeto
                //Todo dado precisa ser convertido
                //do SQL Server para C#
                transportadora.IdTranportadora = (int)row["IdTranportadora"];
                transportadora.NomeFantasia = (string)row["NomeFantasia"];
                transportadora.MeioDeTransporte = (string)row["MeioDeTransporte"];
                transportadora.PrecoMedio = (decimal)row["PrecoMedio"];
                transportadora.Observacao = (string)row["Observacao"];
                //Adicionando o objeto transportadora na coleção
                transportadoras.Add(transportadora);
            }
            return transportadoras;
        }

        //Método publico que retorna uma coleção de Clientes
        public TransportadoraCollection GetAll()
        {
            return GetByFilter();
        }

        //Método para consultar po nome
        //Aplicando o filtro diretamente no método
        //Onde é preciso definir o campo e o valor do filtro
        public TransportadoraCollection GetByName(string value)
        {
            return GetByFilter("NomeFantasia LIKE '%" + value + "%'");
        }

    }
}
