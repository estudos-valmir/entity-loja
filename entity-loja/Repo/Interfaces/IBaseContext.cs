using System.Collections.Generic;
using System.Linq;

namespace entity_loja.Repo.Interfaces
{
    public interface IBaseContext<T>
    {
        void Adicionar(T dbSet);
        void Atualizar(T dbSet);
        void Remover(T dbSet);
        T Consultar(int id);
        IQueryable<T> ListarProdutos();
    }
}