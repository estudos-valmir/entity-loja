using System.Collections.Generic;
using System.Text;

namespace entity_loja.Utils
{
    public class Util
    {

        public static string ListaToString<T>(List<T> lista)
        {
            var sb = new StringBuilder();

            lista.ForEach(p => sb.AppendLine(p.ToString()));
            return sb.ToString();
        }
    }
}