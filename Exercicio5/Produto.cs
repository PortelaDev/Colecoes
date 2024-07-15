namespace Exercicio5
{
    public class Produto
    {
        public string Nome { get; set; } = string.Empty;
        public decimal preco { get; set; }

        public static void ExibirProduto(List<Produto> produto)
        {
            Console.WriteLine("Produto\tPreco");
            decimal somaPreco = 0.0M;
            foreach (var item in produto)
            {
                somaPreco += item.preco;
                Console.WriteLine($"{item.Nome}\t{item.preco}");
            }
            var mediaPreco = somaPreco / produto.Count;
            Console.WriteLine($"\nMedia de preco\t{Math.Round(mediaPreco)}");
            Console.WriteLine($"total de Produtos: {produto.Count}");
        }

    }
}
