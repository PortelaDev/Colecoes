namespace Exercicio7
{
    public class Aluno
    {
        string[] indexer = new string[10];
        public string this[int i]
        {
            get
            {
                if (i >= 0 && i < indexer.Length)
                {
                    return indexer[i];
                }
                return "Error";
            }
            set
            {
                if (i >= 0 && i < indexer.Length)
                    indexer[i] = value;

            }
        }
    }
}
