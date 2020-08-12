using Microsoft.Extensions.Configuration;
using SaoDubas.Domain.Interfaces.Repositories;
using SaoDubas.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaoDubas.Infrastructure.Repositories
{
    public class ProdutoRepository : BaseRepository, IDisposable, IProdutoRepository
    {
        public ProdutoRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public Produto BuscarProduto(int idProduto)
        {
            return _context.Produtos.Find(idProduto);
        }

        
        public List<Produto> ListarProdutos()
        {
            return _context.Produtos.ToList();
        }
    }
}
