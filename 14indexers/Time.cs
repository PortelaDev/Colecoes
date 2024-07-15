namespace _14indexers
{
    public class Time
    {

        //define os limites do array
        string[] valor = new string[10];
        public string this[int i]
        {
            get
            {
                if (i >= 0 && i < valor.Length)
                {
                    //retorna o valor
                    return valor[i];
                }
                return "Erro";
            }
            set
            {
                if (i >= 0 && i < valor.Length)
                {
                    //atribui o valor 
                    valor[i] = value;
                }
            }
        }
    }
}
