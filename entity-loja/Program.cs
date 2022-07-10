using System;
using entity_loja.Repo.DAOS;
using entity_loja.Repo.Context;
using entity_loja.Repo.Entities;
using System.Linq;

namespace entity_loja
{
    class Program
    {
        static void Main(string[] args)
        {
            // UmParaMuitos();
            // MuitosParaMuitos();
        }

        private static void UmParaMuitos()
        {
            var compra = new Compra()
            {
                Quantidade = 3,
                Produto = new Produto()
                {
                    Categoria = "Livro",
                    Nome = "A Culpa é das Estrelas",
                    PrecoUnitario = 5.50,
                    Unidade = "Peça"
                }
            };

            compra.Preco = compra.Produto.PrecoUnitario * compra.Quantidade;


            using (var repo = new BaseDAOEntity<Compra>())
            {
                repo.Adicionar(compra);
                repo.Print();
            }
        }

        private static void MuitosParaMuitos()
        {

            var promocaoPascoa = new Promocao();
            promocaoPascoa.Descricao = "Páscoa Feliz";
            promocaoPascoa.DataIniciacao = DateTime.Now;
            promocaoPascoa.DataFim = DateTime.Now.AddMonths(3);
            promocaoPascoa.Produtos.Add(new Produto()
            {
                Nome = "Suco de Laranja",
                Categoria = "Bebidas",
                Unidade = "litros",
                PrecoUnitario = 25.30
            });
            promocaoPascoa.Produtos.Add(new Produto()
            {
                Nome = "Biscoito",
                Categoria = "Alimentos",
                Unidade = "gramas",
                PrecoUnitario = 3.50
            });

            using (var repo = new BaseDAOEntity<Promocao>())
            {
                repo.Adicionar(promocaoPascoa);
                repo.Print();
            }

        }
    }
}
