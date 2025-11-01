using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_EixoZ.Models
{
    public class Itens_Pedidos
    {
        public int IdItemPedido { get; set; }
        public int IdPedido { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitarioVenda { get; set; }


    }
    public class Itens_PedidosCollection : List<Itens_Pedidos> { }
}
