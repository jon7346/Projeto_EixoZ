using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_EixoZ.Models
{
    public class Transportadora
    {
        public int IdTransportadora { get; set; }

        public string NomeFantasia { get; set; }

        public string MeioDeTransporte { get; set;  }

        public decimal PrecoMedio { get; set; }

        public string Observacao { get; set; }


    }
    public class TransportadoraCollection : List<Transportadora> { }
}
