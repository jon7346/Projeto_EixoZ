using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_EixoZ.Models
{
    public class Vendedor
    {
       
            public int IdVendedor { get; set; }

            public string Nome { get; set; }

            public int Idade { get; set; }

            public string Email { get; set; }

            public string Senha { get; set; }

            public string Endereco { get; set; }
        
    }
    public class VendedorCollection : List<Vendedor> { }
}
