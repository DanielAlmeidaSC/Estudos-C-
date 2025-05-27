namespace System
{
    public static class Reverse
    {
        public static string Inverter(this string palavra)
        {
            if (string.IsNullOrWhiteSpace(palavra))
            {
                throw new ArgumentNullException("Entrada inválida! Insira um texto!");
            }

            if (palavra.Length <= 1)
            {
                throw new ArgumentException("Erro! Apenas um caractere inserido!");
            }


            char[] invertida = palavra.ToCharArray(); //Como uma string é um array de caracteres, convertemos de forma explicita

            Array.Reverse(invertida);

            return new string(invertida);


        }
    }
}