using System.Text;

namespace entity_loja.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public Endereco EnderecoEntrega { get; set; }
        public string Nome { get; internal set; }


        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Compra: [{Id}], {Nome}");
            //sb.AppendLine(Endereco.ToString());
            return sb.ToString();
        }

    }
}