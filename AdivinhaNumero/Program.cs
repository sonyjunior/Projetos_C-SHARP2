using System;
using System.Threading;

namespace AdivinhaNumero
    
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int numero_gerado, numero_palpite;
            string continuar = "s";

            numero_gerado = new Random().Next(1, 10);
           
            while (true)
            {
                Console.WriteLine("Informe seu palpite");
                numero_palpite = int.Parse(Console.ReadLine());
                if (numero_palpite == numero_gerado)
                {
                    Console.WriteLine("Parabéns !!! Você acertou");
                    Console.WriteLine("Informe [N] para parar SAIR [S] para continuar");
                    continuar = Console.ReadLine();
                    numero_gerado = new Random().Next(1, 9);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Você errou !  You lose");
                }              
           
                if (continuar == "n" || continuar == "N")

                {
                    break;
                }
                else
                   {
                     if (numero_gerado < numero_palpite)
                    {
                        Console.WriteLine("Informe um número MENOR");
                    }
                     else
                    {
                        Console.WriteLine("Informe um número MAIOR");

                    }
                }
            }
        }
    }
}
