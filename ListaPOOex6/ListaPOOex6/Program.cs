using System;

namespace ListaPOOex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Distancia dist;

            dist = new Distancia();

            Console.Write("Informe a distancia em milhas ");
            dist.setMilhas(int.Parse(Console.ReadLine()));

            dist.converterDistancia();

            Console.WriteLine("O valor {0} em milhas é correspondente a {1} em quilometros",dist.getMilhas() ,dist.getQuilometros());
        }
    }
}
