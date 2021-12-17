using System;

namespace Dio_Desafio3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong resultado = 0;
            const ulong MaxValue = 18446744073709551615;
            double resultParcial = 0;

            int qtdTeste = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtdTeste; i++)
            {
                int contador = 0;
                int casas = int.Parse(Console.ReadLine()) - 1;
                do
                {

                    resultParcial += Math.Pow(2, contador);
                    if (resultParcial > MaxValue)
                    {
                        resultParcial = MaxValue;
                        break;
                    }
                    Console.WriteLine("Resultado: " + resultParcial);
                    contador++;
                } while (contador <= casas);
                resultado = (ulong)(resultParcial / 12000);
                Console.WriteLine($"{resultado} kg");
                resultParcial = 0;
                resultado = 0;
            }
        }
    }
}
