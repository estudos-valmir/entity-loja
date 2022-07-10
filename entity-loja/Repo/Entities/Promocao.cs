using System;
using System.Collections.Generic;
using System.Text;
using entity_loja.Utils;

namespace entity_loja.Entities
{

    public class Promocao
    {

        public Promocao()
        {
            Produtos = new List<Produto>();
        }

        public int Id { get; set; }
        public string Descricao { get; internal set; }
        public DateTime DataIniciacao { get; internal set; }
        public DateTime DataFim { get; internal set; }
        public List<Produto> Produtos { get; internal set; }


        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(@$"Promocao: [{Id}], {Descricao}, {DataIniciacao}, {DataFim}");
            //sb.AppendLine(Util.ListaToString<Produto>(Produtos));

            return sb.ToString();
        }
    }
}