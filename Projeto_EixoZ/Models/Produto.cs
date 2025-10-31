using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_EixoZ.Models
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }

        public string Material { get; set; }

        public decimal Peso { get; set; }

        public decimal Tamanho { get; set; }

        public decimal Preco { get; set; }

    }

    public class ProdutoCollection : List<Produto> { }
}
