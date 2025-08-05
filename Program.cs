namespace TesteSelecao
{
    // Problema 1035 - Teste de Seleção 1 (Beecrowd)
    // Link: https://judge.beecrowd.com/pt/problems/view/1035

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TESTE DE SELEÇÃO");

            String[] valoresDigitados = Console.ReadLine().Split();
            int A = Convert.ToInt32(valoresDigitados[0]);
            int B = Convert.ToInt32(valoresDigitados[1]);
            int C = Convert.ToInt32(valoresDigitados[2]);
            int D = Convert.ToInt32(valoresDigitados[3]);

            int somaDC = D + C;
            int somaAB = A + B;

            if (B > C && D > A && (somaDC > somaAB) && (C > 0 && D > 0))
            {
                Console.WriteLine("Valores aceitos");

            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}