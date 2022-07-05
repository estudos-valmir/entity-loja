using System.Collections.Generic;
using entity_loja.Repo.Entities;

namespace entity_loja.Repo.Interfaces
{
    public interface IProdutoDAO
    {
         void Adicionar(Produto produto);
        void Atualizar(Produto produto);
        void Remover(Produto produto);
        IList<Produto> ListarProdutos();
    }
}