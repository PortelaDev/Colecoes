using Exercicio5;

Console.WriteLine("## Exercicio 5 ##\n");
List<Produto> produto = FonteDados.GetProdutos();

Console.WriteLine("Lista de Produtos Original: ");
Produto.ExibirProduto(produto);

Console.WriteLine("\nAdicionando novo produto:");
Produto mochila = new Produto() { Nome = "Mochila", preco = 22.44M };
produto.Add(mochila);

Console.WriteLine("Exibindo novamente:");
Produto.ExibirProduto(produto);

Console.WriteLine("\nOrdenando a lista pelo nome e exibindo");
var produtosOrdenados = produto.OrderBy(x => x.Nome).ToList();
Produto.ExibirProduto(produtosOrdenados);

Console.WriteLine("\nProdutos inferiores a R$5,00: ");
var precoAbaixo5 = produto.FindAll(x => x.preco < 5.00M);
Produto.ExibirProduto(precoAbaixo5);


Console.WriteLine("\nProcurando o Estojo");
Console.WriteLine(produto.Find(x => x.Equals("Estojo")));

Console.ReadKey();