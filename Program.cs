using System;

namespace Aula60Ex84
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] vet1 = new double[2]; 
            double[] vet2 = new double[2]; 
            double[] soma = new double[2]; 

            for (int i = 0; vet1.Length < 2; i++)
            {
                Console.WriteLine("Informe os valores do vetor 1");
                vet1[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; vet1.Length < 2; i++)
            {
                Console.WriteLine("Informe os valores do vetor 2");
                vet2[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; vet1.Length < 2; i++)
            {
                soma[i] = vet1[i]+vet2[i];
                Console.WriteLine(soma[i]);
            }

        }




    }
}
