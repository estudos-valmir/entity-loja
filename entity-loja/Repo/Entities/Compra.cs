using System.Text;

namespace entity_loja.Repo.Entities
{
    public class Compra
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public double Preco { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Compra: [{Id}], {Quantidade}, {Preco}");
            sb.AppendLine(Produto.ToString());
            return sb.ToString();
        }
    }

}