using SaoDubas.Domain.Interfaces.Repositories;
using SaoDubas.Domain.Interfaces.Services;
using SaoDubas.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaoDubas.Application
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;


        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public Produto BuscarProduto(int idProduto)
        {
            return _produtoRepository.BuscarProduto(idProduto);
        }

        public List<Produto> ListarProdutos()
        {
            return _produtoRepository.ListarProdutos();
        }
    }
}
