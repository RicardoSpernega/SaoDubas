using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaoDubas.Models
{
    public class ProdutoViewModel
    {
        public int ProdutoId { get; set; }
        public float Preco { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
