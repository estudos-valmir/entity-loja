using System;
using entity_loja.Repo.DAOS;
using entity_loja.Repo.Entities;

namespace entity_loja
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ProdutoDAOEntity())
            {
                Produto produto = new Produto(){
                    Nome = "Harry Potter",
                    Categoria = "Fantasia",
                    PrecoUnitario = 2.66,
                    Unidade = "unidade"
                    };

                context.Adicionar(produto);


                context.Print();

                
            }
        }
    }
}
