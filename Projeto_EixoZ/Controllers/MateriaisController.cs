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
    class MateriaisController
    {
        
     

            DataBaseServices dataBase = new DataBaseServices();

            public int Inserir(Materiais material)
            {
                //Criando o comando SQL para inserir
                //um novo registro na tabela de clientes
                string query =
                    "INSERT INTO material (MateriaPrima, NomeFornecedor, PesoProduto, Tipo, Marca) " +
                    "VALUES (@MateriaPrima, @NomeFornecedor, @PesoProduto, @Tipo, @Marca)";

                SqlCommand command = new SqlCommand(query);
                //Definindo os valores dos parametros
                command.Parameters.AddWithValue("@MateriaPrima", material.MateriaPrima);
                command.Parameters.AddWithValue("@NomeFornecedor", material.NomeFornecedor);
                command.Parameters.AddWithValue("@PesoProduto", material.PesoProduto);
                command.Parameters.AddWithValue("@Tipo", material.Tipo);
                command.Parameters.AddWithValue("@Marca", material.Marca);
                //Executando o comando SQL e retornando
                //a quantidade de linhas afetadas
                return dataBase.ExecuteSQL(command);
            }

            //Método publico par alterar o registro
            public int Alterar(Materiais material)
            {
                //Criando o comando SQL para alterar
                //um registro na tabela de clientes
                string query =
                    "UPDATE material SET " +
                    "MateriaPrima = @MateriaPrima, " +
                    "NomeFornecedor = @NomeFornecedor, " +
                    "PesoProduto = @PesoProduto, " +
                    "Tipo = @Tipo " +
                    "Marca = @Marca " +
                    "WHERE IdMaterial = @IdMaterial";

                SqlCommand command = new SqlCommand(query);
                //Definindo os valores dos parametros
                command.Parameters.AddWithValue("@MateriaPrima", material.MateriaPrima);
                command.Parameters.AddWithValue("@NomeFornecedor", material.NomeFornecedor);
                command.Parameters.AddWithValue("@PesoProduto", material.PesoProduto);
                command.Parameters.AddWithValue("@Tipo", material.Tipo);
                command.Parameters.AddWithValue("@Marca", material.Marca);
                command.Parameters.AddWithValue("@IdMaterial", material.IdMaterial);
                //Executando o comando SQL e retornando
                //a quantidade de linhas afetadas
                return dataBase.ExecuteSQL(command);
            }

            //Método publico para excluir um registro
            public int Excluir(int idmaterial)
            {
                //Criando o comando SQL para excluir
                //um registro na tabela de clientes
                string query =
                    "DELETE FROM material " +
                    "WHERE IdMaterial = @IdMaterial";
                SqlCommand command = new SqlCommand(query);
                //Definindo os valores dos parametros
                command.Parameters.AddWithValue("@idMaterial", idmaterial);
                //Executando o comando SQL e retornando
                //a quantidade de linhas afetadas
                return dataBase.ExecuteSQL(command);
            }

            //Método publico que retorna um objeto do tipo material
            public Materiais GetById(int fornecedorId)
            {
                //Criando o comando SQL para selecionar
                //um registro na tabela de clientes
                string query =
                    "SELECT * " +
                    "FROM material " +
                    "WHERE IdMaterial = @IdMaterial" +
                    "ORDER BY NomeFornecedor";
                SqlCommand command = new SqlCommand(query);
                //Definindo os valores dos parametros
                command.Parameters.AddWithValue("@IdMaterial", fornecedorId);
                //Executando o comando SQL e armazenando o resultado
                //em um objeto do tipo DataTable
                DataTable dataTable = dataBase.GetDataTable(command);

                if (dataTable.Rows.Count > 0)
                {
                    //Criando um novo objeto do tipo material
                    Materiais material = new Materiais();
                    // Agora vou indetificar o valor da linha na coluna
                    //e atribuir ao objeto
                    //Todo dado precisa ser convertido
                    //do SQL Server para C#
                    material.IdMaterial = (int)dataTable.Rows[0]["IdMaterial"];
                    material.MateriaPrima = (string)dataTable.Rows[0]["MateriaPrima"];
                    material.NomeFornecedor = (string)dataTable.Rows[0]["NomeFornecedor"];
                    material.PesoProduto = (decimal)dataTable.Rows[0]["PesoProduto"];
                    material.Tipo = (string)dataTable.Rows[0]["Tipo"];
                    material.Marca = (string)dataTable.Rows[0]["Marca"];

                    return material;
                }
                else
                    return null;

            }

            //Método publico que retorna uma coleção de Clientes com filtro
            //Adicionado opção de filtro apenas para não ter q repetir código
            public MateriaisCollection GetByFilter(string filtro = "")
            {
                //Criando o comando SQL para selecionar
                //todos os registros na tabela de clientes
                string query = "SELECT * FROM material ";

                //Validar se o filtro foi passado no parametro
                if (filtro != "")
                    query += "WHERE @filtro ";

                query += "ORDER BY NomeFornecedor";

                SqlCommand command = new SqlCommand(query);

                command.Parameters.AddWithValue("@filtro", filtro);
                //Executando o comando SQL e armazenando o resultado
                //em um objeto do tipo DataTable
                DataTable dataTable = dataBase.GetDataTable(command);
                //Criando um novo objeto do tipo ClienteColletion
                MateriaisCollection materiais = new MateriaisCollection();
                //Percorrendo todas as linhas retornadas no DataTable
                foreach (DataRow row in dataTable.Rows)
                {
                    //Criando um novo objeto do tipo material
                    Materiais material = new Materiais();
                    //Agora vou indetificar o valor da linha na coluna
                    //e atribuir ao objeto
                    //Todo dado precisa ser convertido
                    //do SQL Server para C#
                    material.IdMaterial = (int)row["IdMaterial"];
                    material.MateriaPrima = (string)row["MateriaPrima"];
                    material.NomeFornecedor = (string)row["NomeFornecedor"];
                    material.PesoProduto = (decimal)row["PesoProduto"];
                    material.Tipo = (string)row["Tipo"];
                    material.Marca = (string)row["Marca"];
                    //Adicionando o objeto material na coleção
                       materiais.Add(material);
                }
                return materiais;
            }

            //Método publico que retorna uma coleção de Clientes
            public MateriaisCollection GetAll()
            {
                return GetByFilter();
            }

            //Método para consultar po nome
            //Aplicando o filtro diretamente no método
            //Onde é preciso definir o campo e o valor do filtro
            public MateriaisCollection GetByFornecedor(string value)
            {
                return GetByFilter("NomeFornecedor LIKE '%" + value + "%'");
            }
            public MateriaisCollection GetByMateria(string value)
            {
                return GetByFilter("MateriaPrima LIKE '%" + value + "%'");
            }
            public MateriaisCollection GetByPeso(string value)
            {
                return GetByFilter("PesoProduto LIKE '%" + value + "%'");
            }

            public MateriaisCollection GetByTipo(string value)
            {
                return GetByFilter("Tipo LIKE '%" + value + "%'");
            }
            public MateriaisCollection GetByMarca(string value)
            {
                return GetByFilter("Marca LIKE '%" + value + "%'");
            }





    }
}
