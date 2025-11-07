using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_EixoZ.Models
{
    public class Materiais
    {
        public int IdMaterial { get; set; }
        public string MateriaPrima { get; set; }

        public string NomeFornecedor { get; set; }

        public decimal PesoProduto { get; set; }

        public string Tipo { get; set; }

        public string Marca { get; set; }

    }

    public class MateriaisCollection : List<Materiais> { }
}
