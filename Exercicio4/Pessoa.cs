namespace Exercicio4
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public string exibir()
        {
            return $"{Nome} - {Idade}";
        }
    }


}
