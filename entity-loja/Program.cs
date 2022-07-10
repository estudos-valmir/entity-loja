using System;
using entity_loja.Repo.DAOS;
using entity_loja.Entities;

namespace entity_loja
{
    class Program
    {
        static void Main(string[] args)
        {
            // UmParaMuitos();
            // MuitosParaMuitos();
            // UmParaUm();


        }

        private static void UmParaUm()
        {
            var cliente = new Cliente()
            {
                Nome = "Joao do teste",
                EnderecoEntrega = new Endereco()
                {
                    Numero = 12,
                    Logradouro = "Rua da cidade",
                    Complemento = "Casa",
                    Bairro = "Centro",
                    Cidade = "São Paulo"
                }
            };

            using (var repo = new BaseDAOEntity<Cliente>())
            {
                repo.Adicionar(cliente);
            }
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
                Nome = "Maçã",
                Categoria = "Frutas",
                Unidade = "unidade",
                PrecoUnitario = 5.00
            });
            promocaoPascoa.Produtos.Add(new Produto()
            {
                Nome = "Nescau",
                Categoria = "Alimentos",
                Unidade = "gramas",
                PrecoUnitario = 10.15
            });

            using (var repo = new BaseDAOEntity<Promocao>())
            {
                repo.Adicionar(promocaoPascoa);
                repo.Print();
            }

        }
    }
}
