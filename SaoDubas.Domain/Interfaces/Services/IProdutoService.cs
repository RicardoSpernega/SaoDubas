using SaoDubas.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaoDubas.Domain.Interfaces.Services
{
    public interface IProdutoService
    {
        Produto BuscarProduto(int idProduto);
        List<Produto> ListarProdutos();
    }
}
