using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_EixoZ.Models
{
    public class Pedidos
    {
        public string EnderecoEntrega { get; set; }

        public DateTime DataPedido { get; set; }

        public string StatusPedido { get; set; }

        public string Observacao { get; set; }

        public int Quantidade { get; set; }

        public decimal PrecoUnitarioVenda { get; set; }
    }
}
