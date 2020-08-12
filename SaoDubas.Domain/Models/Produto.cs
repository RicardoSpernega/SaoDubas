using System;
using System.Collections.Generic;
using System.Text;

namespace SaoDubas.Domain.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public float Preco { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
