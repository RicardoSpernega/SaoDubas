using SaoDubas.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaoDubas.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository
    {
        Produto BuscarProduto(int idProduto);

        List<Produto> ListarProdutos();
    }
}
