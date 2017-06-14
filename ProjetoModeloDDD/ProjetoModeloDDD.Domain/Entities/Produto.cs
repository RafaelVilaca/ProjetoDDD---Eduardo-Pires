namespace ProjetoModeloDDD.Domain.Entities
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Disponivel { get; set; }
        public int ClienteId { get; set; }

        public virtual Cliente Cliente { get; set; }

        public int IsValid()
        {
            if (string.IsNullOrEmpty(Nome) || Nome.Trim().Length <= 3)
                return 1;

            if (ClienteId < 0)
                return 2;

            return 0;
        }
    }
}
