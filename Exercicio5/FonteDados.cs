namespace Exercicio5
{
    public class FonteDados
    {
        public static List<Produto> GetProdutos()
        {
            List<Produto> produtos = new()
            {
                new Produto(){Nome= "Clips", preco = 3.95M},
                new Produto(){Nome= "Caneta", preco = 5.99M},
                new Produto(){Nome= "Lapis", preco = 4.15M},
                new Produto(){Nome= "Estojo", preco = 6.99M},
                new Produto(){Nome= "Caderno", preco = 7.55M}
            };
            return produtos;
        }
    }
}
