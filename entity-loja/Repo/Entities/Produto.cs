using System.Collections.Generic;
using System.Text;
using entity_loja.Utils;
namespace entity_loja.Repo.Entities
{
    public class Produto
    {

        public Produto()
        {
            Promocoes = new List<Promocao>();
        }
        public int Id { get; internal set; }
        public string Nome { get; internal set; }
        public string Categoria { get; internal set; }
        public double PrecoUnitario { get; internal set; }
        public string Unidade { get; internal set; }
        public List<Promocao> Promocoes { get; set; }



        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(@$"Produto: [{Id}], {Nome}, {Categoria}, {PrecoUnitario}, {Unidade}");
            sb.AppendLine(Util.ListaToString<Promocao>(Promocoes));

            return sb.ToString();
        }
    }
}