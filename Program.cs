using System;

namespace Aula60Ex84
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamVet;
            Console.WriteLine("Informe o tamando do vetor:");
            tamVet = int.Parse(Console.ReadLine());

            double[] vet1 = new double[tamVet]; 
            double[] vet2 = new double[tamVet]; 
            double[] soma = new double[tamVet];                       

            for (int i = 0; i < tamVet; i++)
            {
                Console.WriteLine($"Informe o valor do vetor 1 pos {i}:");
                vet1[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < tamVet; i++)
            {
                Console.WriteLine($"Informe o valor do vetor 2 pos {i}:");
                vet2[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Soma dos vetores:");
            for (int i = 0; i < tamVet; i++)
            {
                soma[i] = vet1[i]+vet2[i];
                Console.WriteLine(soma[i]);
            }
        }
    }
}
