using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_EixoZ.Models
{
    public class Pedidos 
    {
        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public int IdTransportadora { get; set; }
        public string EnderecoEntrega { get; set; }
        public DateTime DataPedido { get; set; }
        public string StatusPedido { get; set; }
        public string Observacao { get; set; }

        

    }

    public class PedidosCollection : List<Pedidos> { }
}
