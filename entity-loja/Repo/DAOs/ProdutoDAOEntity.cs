using System;
using System.Collections.Generic;
using System.Linq;
using entity_loja.Repo.Context;
using entity_loja.Repo.Entities;
using entity_loja.Repo.Interfaces;

namespace entity_loja.Repo.DAOS
{
     public class ProdutoDAOEntity : IDisposable, IProdutoDAO, IPrintable
    {
        private LojaContext _contexto;

        public ProdutoDAOEntity()
        {
            _contexto = new LojaContext();

        }

        public void Adicionar(Produto produto)
        {
            _contexto.Produtos.Add(produto);
            _contexto.SaveChanges();
        }

        public void Atualizar(Produto produto)
        {
            _contexto.Produtos.Update(produto);
            _contexto.SaveChanges();
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }

        public IList<Produto> ListarProdutos()
        {
            return _contexto.Produtos.ToList();
        }

        public void Print()
        {

            Console.WriteLine($"Foram encontrados {_contexto.Produtos.ToList().Count} produtos:");

            _contexto.Produtos.ToList()
                .ForEach(p => Console.WriteLine($"[{p.Nome}]"));


        }

        public void Remover(Produto produto)
        {
            _contexto.Produtos.Remove(produto);
            _contexto.SaveChanges();
        }
    }
    
}