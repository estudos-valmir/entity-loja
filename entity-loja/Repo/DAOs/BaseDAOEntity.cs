using System;
using System.Linq;
using entity_loja.Entities;
using entity_loja.Repo.Context;
using entity_loja.Repo.Interfaces;
using entity_loja.Utils;

namespace entity_loja.Repo.DAOS
{
    public class BaseDAOEntity<T> : IDisposable, IBaseContext<T>, IPrintable where T : class
    {
        private LojaContext _contexto;

        public BaseDAOEntity()
        {
            _contexto = new LojaContext();
        }

        public void Adicionar(T dbSet)
        {
            _contexto.Set<T>().Add(dbSet);
            _contexto.SaveChanges();
        }

        public void Atualizar(T dbSet)
        {
            _contexto.Set<T>().Update(dbSet);
            _contexto.SaveChanges();
        }

        public T Consultar(int id)
        {
            return _contexto.Set<T>().Find(id);
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }

        public IQueryable<T> ListarProdutos()
        {
            return _contexto.Set<T>();
        }

        public void Print()
        {
            var lista = _contexto.Set<T>().ToList();
            lista.ForEach(p => Console.WriteLine($"{p.ToString()}"));
        }

        public void Remover(T dbSet)
        {
            _contexto.Set<T>().Remove(dbSet);
            _contexto.SaveChanges();
        }

        public LojaContext Sefie()
        {
            return _contexto;
        }

    }

}