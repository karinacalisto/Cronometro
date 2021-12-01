using System;
using System.Threading;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu(); 
        }

        static void Menu(){

            Console.Clear();
            Console.WriteLine("S = Segundo escreva S ao final => 10s");
            Console.WriteLine("m = minuto escreva m ao final => 1m");
            Console.WriteLine("Digite 0 para Sair");
            Console.WriteLine("Quanto tempo deseja contar? ");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int mult = 1;

            if (type == 'm')
                mult = 60;

            if (time == 0)
                System.Environment.Exit(0);

            PreStart(mult - time);


        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;
           
            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("FIM DA CONTAGEM");
            Thread.Sleep(2500);
            Menu();
        }

    }
}
