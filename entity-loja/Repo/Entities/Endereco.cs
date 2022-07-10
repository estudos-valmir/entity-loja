using System.Text;

namespace entity_loja.Entities
{
    public class Endereco
    {
        public int Numero { get; internal set; }
        public string Logradouro { get; internal set; }
        public string Complemento { get; internal set; }
        public string Bairro { get; internal set; }
        public string Cidade { get; internal set; }
        public Cliente Cliente { get; set; }


        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Compra: [{Numero}], {Logradouro}, {Complemento}, {Bairro}, {Cidade}");
            //sb.AppendLine(Cliente.ToString());
            return sb.ToString();
        }
    }
}