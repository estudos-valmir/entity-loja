using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

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

        public static void PrintChangeTracker(DbContext dbContext)
        {
            var entradas = dbContext.ChangeTracker.Entries();

            foreach (EntityEntry entidade in entradas)
                System.Console.WriteLine($"{entidade.Entity.ToString()} - {entidade.State}");

        }
    }
}