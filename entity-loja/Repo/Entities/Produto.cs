namespace entity_loja.Repo.Entities
{
    public class Produto
    {
        public int Id { get; internal set; }
        public string Nome { get; internal set; }
        public string Categoria { get; internal set; }
        public double PrecoUnitario { get; internal set; }
        public string Unidade { get; internal set; }




        public override string ToString()
        {
           return $"Produto: {Id}, {Nome}, {Categoria}, {PrecoUnitario}, {Unidade}";
        }
    }
}